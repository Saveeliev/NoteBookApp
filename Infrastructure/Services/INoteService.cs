using DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface INoteService
    {
        Task<ActionResult> AddNote(NoteDto note);
        Task<ActionResult> UpdateNote(NoteDto note);
        Task<ActionResult> DeleteNote(Guid noteId);
        Task<ChangeModifierResult> ChangeModifier(Guid noteId);
        Task AddToFavorite(Guid noteId);
        Task DeleteFromFavorite(Guid noteId);
        Task Like(Guid noteId);
        Task UnLike(Guid noteId);
        Task RestoreNote(Guid noteId);

        NoteDto GetNote(Guid noteId);
        List<NoteDto> GetNotes(NotesToWrite getNotesToWrite);

        Task Fill();
        Task DeleteAll();
    }
}