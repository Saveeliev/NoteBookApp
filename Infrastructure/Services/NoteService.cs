using DataBase;
using DataBase.Models;
using DTO;
using DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class NoteService : BaseService, INoteService
    {
        private readonly IDataProvider _dataProvider;
        private readonly Context _context;

        public NoteService(IDataProvider dataProvider, IUserService userService, Context context)
        {
            _dataProvider = dataProvider ?? throw new ArgumentNullException(nameof(dataProvider));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ActionResult> AddNote(NoteDto note)
        {
            if (note == null)
                return new Error("Note cannot be null");

            if (string.IsNullOrWhiteSpace(note.Text))
                return new Error("Text cannot be empty");

            var currentDate = DateTime.Now;

            using var transaction = _context.Database.BeginTransaction();

            var user = _dataProvider.Get<UserDb>(i => i.Login == ActiveUser.Login).SingleOrDefault();
            var noteToAdd = new NoteDb { CreatedDate = currentDate, UpdatedDate = currentDate, Text = note.Text, IsPrivate = note.IsPrivate, User = user };
            await _dataProvider.Insert(noteToAdd);
            await transaction.CommitAsync();

            return new Success();
        }

        public async Task<ActionResult> UpdateNote(NoteDto note)
        {
            if (note == null)
                return new Error("Note cannot be null");

            if (string.IsNullOrWhiteSpace(note.Text))
                return new Error("Text cannot be empty");

            using var transaction = _context.Database.BeginTransaction();

            var noteToUpdate = _dataProvider.Get<NoteDb>(i => i.Id == note.Id && !i.DeletedDate.HasValue).SingleOrDefault();
            noteToUpdate.UpdatedDate = DateTime.Now;
            noteToUpdate.Text = note.Text;

            await _dataProvider.Update(noteToUpdate);

            transaction.Commit();

            return new Success();
        }

        public async Task<ChangeModifierResult> ChangeModifier(Guid noteId)
        {
            var currentNote = _dataProvider.Get<NoteDb>(n => n.Id == noteId).SingleOrDefault();

            currentNote.IsPrivate = !currentNote.IsPrivate;

            await _dataProvider.Update(currentNote);

            return currentNote.IsPrivate ? ChangeModifierResult.Private : ChangeModifierResult.Public;
        }

        public async Task<ActionResult> DeleteNote(Guid noteId)
        {
            var currentNote = _dataProvider.Get<NoteDb>(n => n.Id == noteId).SingleOrDefault();

            if (currentNote.DeletedDate == null)
            {
                currentNote.DeletedDate = DateTime.Now;
                await _dataProvider.Update(currentNote);
            }
            else
            {
                await _dataProvider.Delete(currentNote);
            }

            return new Success();
        }

        public async Task AddToFavorite(Guid noteId)
        {
            var currentNote = _dataProvider.Get<NoteDb>(n => n.Id == noteId).SingleOrDefault();
            var favorite = new FavoriteDb() { NoteId = currentNote.Id, UserId = ActiveUser.Id };

            await _dataProvider.Insert(favorite);

        }

        public async Task DeleteFromFavorite(Guid noteId)
        {
            var favorite = _dataProvider.Get<FavoriteDb>(i => i.NoteId == noteId && i.UserId == ActiveUser.Id).SingleOrDefault();

            await _dataProvider.Delete(favorite);
        }

        public async Task Like(Guid noteId)
        {
            var like = new LikeDb() { NoteId = noteId, UserId = ActiveUser.Id };

            await _dataProvider.Insert(like);
        }

        public async Task UnLike(Guid noteId)
        {
            var like = _dataProvider.Get<LikeDb>(i => i.NoteId == noteId && i.UserId == ActiveUser.Id).SingleOrDefault();

            await _dataProvider.Delete(like);
        }

        public async Task RestoreNote(Guid noteId)
        {
            var currentNote = _dataProvider.Get<NoteDb>(i => i.Id == noteId).SingleOrDefault();
            currentNote.DeletedDate = null;
            currentNote.UpdatedDate = DateTime.Now;

            await _dataProvider.Update(currentNote);
        }

        public NoteDto GetNote(Guid noteId)
        {
            var noteDTO = _dataProvider.Get<NoteDb>(i => i.Id == noteId)
                .Select(i => new NoteDto
                {
                    Id = i.Id,
                    IsFavoriteExist = i.Favorites.Any(u => u.UserId == ActiveUser.Id),
                    UserName = i.User.Name,
                    DeletedDate = i.DeletedDate,
                    UpdatedDate = i.UpdatedDate,
                    IsPrivate = i.IsPrivate,
                    Text = i.Text,
                    UserId = i.UserId,
                    IsLiked = i.Likes.Any(n => n.UserId == ActiveUser.Id),
                    LikesCount = i.Likes.Count()
                })
                .SingleOrDefault();

            return noteDTO;
        }

        public List<NoteDto> GetNotes(NotesToWrite whatToWrite)
        {
            var notes = new List<NoteDb>();
            switch (whatToWrite)
            {
                case NotesToWrite.AllNotes:
                    {
                        notes = _dataProvider.Get<NoteDb>(k => k.IsPrivate == false && k.DeletedDate == null || k.UserId == ActiveUser.Id && k.DeletedDate == null)
                            .OrderByDescending(u => u.UpdatedDate)
                            .ToList();
                        break;
                    }

                case NotesToWrite.MyNotes:
                    {
                        notes = _dataProvider.Get<NoteDb>(w => w.UserId == ActiveUser.Id && w.DeletedDate == null)
                            .OrderByDescending(u => u.UpdatedDate)
                            .ToList();
                        break;
                    }

                case NotesToWrite.RecycledNotes:
                    {
                        notes = _dataProvider.Get<NoteDb>(q => q.UserId == ActiveUser.Id && q.DeletedDate != null)
                            .OrderByDescending(u => u.UpdatedDate)
                            .ToList();
                        break;
                    }

                case NotesToWrite.Favorites:
                    {
                        var favorites = _dataProvider.Get<FavoriteDb>(i => i.UserId == ActiveUser.Id).ToArray();

                        foreach (var favorite in favorites)
                        {
                            if (favorite.Note.DeletedDate == null)
                                notes.Add(favorite.Note);
                        }
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

            var notesToWrite = new List<NoteDto>();

            foreach (var note in notes)
            {
                var noteDTO = GetNote(note.Id);
                notesToWrite.Add(noteDTO);
            }

            return notesToWrite;
        }

        public async Task Fill()
        {
            var text = "Note ";
            var k = 0;

            for (var i = 0; i < 10; i++)
            {
                var textNote = text + k;
                var note = new NoteDto() { Text = textNote, UserId = ActiveUser.Id };
                await AddNote(note);
                k++;
            }
        }

        public async Task DeleteAll()
        {
            var notes = _dataProvider.Get<NoteDb>(j => j.UserId == ActiveUser.Id).ToArray();

            foreach (var note in notes)
            {
                await DeleteNote(note.Id);
            }
        }
    }
}