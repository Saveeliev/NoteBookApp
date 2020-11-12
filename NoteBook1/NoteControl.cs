using DTO;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace NoteBookApp
{
    public partial class NoteControl : UserControl
    {
        private readonly NoteDto _currentNote;
        private readonly INoteService _noteService;
        private readonly IUserService _userService;

        public NoteControl(NoteDto note, INoteService noteService, IUserService userService)
        {
            InitializeComponent();

            _noteService = noteService ?? throw new ArgumentNullException(nameof(noteService));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _currentNote = note ?? throw new ArgumentNullException(nameof(note));

            var activeUser = _userService.GetAndSetActiveUserIfExist();

            if (_currentNote.UserId != activeUser.Id)
            {
                ButtonToChangeModifier.Hide();
                ButtonToDelete.Hide();
                ButtonToUpdate.Hide();
                ButtonToRestore.Hide();
            }

            if (_currentNote.DeletedDate == null)
            {
                ButtonToRestore.Hide();
            }
            else
            {
                ButtonToFavorite.Hide();
                ButtonToLike.Hide();
                ButtonToUpdate.Hide();
                ButtonToChangeModifier.Hide();
                LabelLikesCount.Hide();
            }

            if (_currentNote.IsPrivate == false)
                ButtonToChangeModifier.BackgroundImage = new Bitmap("public.png");

            if (_currentNote.IsLiked == true)
                ButtonToLike.BackgroundImage = new Bitmap("liked.png");

            if (_currentNote.IsFavoriteExist == true)
                ButtonToFavorite.BackgroundImage = new Bitmap("favorited.png");

            LinkToOpen.Text = GetTitle(_currentNote.Text);
            LabelLikesCount.Text = _currentNote.LikesCount.ToString();
            LabelDateAndUser.Text = GetDate(_currentNote.UpdatedDate) + ", " + _currentNote.UserName;

            ButtonToChangeModifier.Click += ButtonToChangeModifier_Click;
            ButtonToDelete.Click += ButtonToDelete_Click;
            ButtonToFavorite.Click += ButtonToFavorite_Click;
            ButtonToLike.Click += ButtonToLike_Click;
            ButtonToUpdate.Click += ButtonToUpdate_Click;
            ButtonToRestore.Click += ButtonToRestore_Click;
        }

        private async void ButtonToRestore_Click(object sender, EventArgs e)
        {
            await _noteService.RestoreNote(_currentNote.Id);
            Hide();
        }

        private void ButtonToUpdate_Click(object sender, EventArgs e)
        {
            var editNoteForm = new EditNoteForm(_currentNote, _noteService);
            editNoteForm.Show();
        }

        private void ButtonToLike_Click(object sender, EventArgs e)
        {
            if (_currentNote.IsLiked == false)
            {
                _noteService.Like(_currentNote.Id);
                _currentNote.LikesCount++;
                var likesCount = Convert.ToInt32(LabelLikesCount.Text);
                likesCount++;
                LabelLikesCount.Text = likesCount.ToString();
                _currentNote.IsLiked = true;
                ButtonToLike.BackgroundImage = new Bitmap("liked.png");
            }
            else
            {
                _noteService.UnLike(_currentNote.Id);
                _currentNote.LikesCount--;
                var likesCount = Convert.ToInt32(LabelLikesCount.Text);
                likesCount--;
                LabelLikesCount.Text = likesCount.ToString();
                _currentNote.IsLiked = false;
                ButtonToLike.BackgroundImage = new Bitmap("like.png");
            }
        }

        private async void ButtonToFavorite_Click(object sender, EventArgs e)
        {
            if (_currentNote.IsFavoriteExist == false)
            {
                await _noteService.AddToFavorite(_currentNote.Id);
                _currentNote.IsFavoriteExist = true;
                ButtonToFavorite.BackgroundImage = new Bitmap("favorited.png");
            }
            else
            {
                await _noteService.DeleteFromFavorite(_currentNote.Id);
                _currentNote.IsFavoriteExist = false;
                ButtonToFavorite.BackgroundImage = new Bitmap("favorite.png");
            }
        }

        private async void ButtonToDelete_Click(object sender, EventArgs e)
        {
            await _noteService.DeleteNote(_currentNote.Id);
            Hide();
        }

        private async void ButtonToChangeModifier_Click(object sender, EventArgs e)
        {
            var result = await _noteService.ChangeModifier(_currentNote.Id);

            switch (result)
            {
                case ChangeModifierResult.Private:
                    ButtonToChangeModifier.BackgroundImage = new Bitmap("private.png");
                    break;
                case ChangeModifierResult.Public:
                    ButtonToChangeModifier.BackgroundImage = new Bitmap("public.png");
                    break;
            }
        }

        private string GetTitle(string text)
        {
            var title = string.Empty;
            var titleLength = 10;

            if (text.Length > titleLength)
            {
                string[] words = text.Split(new char[] { ' ' });
                var counter = 0;

                foreach (var word in words)
                {
                    if ((title + " " + word).Length <= titleLength)
                    {
                        if (counter != 0)
                            title = title + " " + word;
                        else
                            title = title + word;
                    }
                    else
                    {
                        title += "...";
                        break;
                    }
                    counter++;
                }
                return title;
            }
            else
                return text;
        }

        private void LinkToOpen_Click(object sender, EventArgs e)
        {
            var readNoteForm = new ReadNoteForm(_currentNote);
            readNoteForm.Show();
        }

        public string GetDate(DateTime date)
        {
            var currentDate = DateTime.Now;
            CultureInfo lang = new CultureInfo("en-EN");

            if (date.Day == currentDate.Day)
            {
                return date.ToString("HH:mm", lang);
            }
            else if ((currentDate - date).TotalDays < 7)
            {
                return date.ToString("ddd, HH:mm", lang);
            }
            else if (currentDate.Month == date.Month && currentDate.Year == date.Year)
            {
                return date.ToString("M", lang);
            }
            else
            {
                return date.ToString("d", lang);
            }
        }
    }
}