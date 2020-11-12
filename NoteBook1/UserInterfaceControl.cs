using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataBase;
using DTO;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace NoteBookApp
{
    public partial class UserInterfaceControl : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserService _userService;
        private readonly INoteService _noteService;

        public UserInterfaceControl(IServiceProvider serviceProvider, IUserService userService, INoteService noteService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _noteService = noteService ?? throw new ArgumentNullException(nameof(noteService));
        }

        private void UserInterfaceControl_Load(object sender, EventArgs e)
        {
            var activeUser = _userService.GetAndSetActiveUserIfExist();
            LabelName.Text = activeUser.Login;

            var notesBuilder = _serviceProvider.GetRequiredService<NotesBuilder>();

            var notes = _noteService.GetNotes(NotesToWrite.AllNotes);
            var noteControls = notesBuilder.BuildNotes(notes);
           
            ClearAndAddRange(noteControls.ToArray());
        }

        private void ClearAndAddRange(NoteControl[] noteControls)
        {
            NotesPanel.Controls.Clear();
            NotesPanel.Controls.AddRange(noteControls);
        }

        private void ButtonToExit_Click(object sender, EventArgs e)
        {
            _userService.DeleteActiveUser();
            var activeForm = Application.OpenForms[0];
            activeForm.Controls.Clear();
            var loginControl = _serviceProvider.GetRequiredService<LoginControl>();
            FormEditor.ClearForm(loginControl);
            activeForm.Controls.Add(loginControl);
        }

        private void ButtonToAddNote_Click(object sender, EventArgs e)
        {
            var addNoteForm = _serviceProvider.GetRequiredService<AddNoteForm>();
            addNoteForm.Show();
        }

        private async void LinkToFill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await _noteService.Fill();
        }

        private async void LinkToDeleteNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await _noteService.DeleteAll();

        }

        private void FavoriteItem_Click(object sender, EventArgs e)
        {
            var notesBuilder = _serviceProvider.GetRequiredService<NotesBuilder>();

            var notesToBuild = _noteService.GetNotes(NotesToWrite.Favorites);
            var noteControls = notesBuilder.BuildNotes(notesToBuild);
            ClearAndAddRange(noteControls.ToArray());
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            var accountForm = _serviceProvider.GetRequiredService<AccountForm>();
            accountForm.Show();
        }

        private void AllNotesItem_Click(object sender, EventArgs e)
        {
            var notesBuilder = _serviceProvider.GetRequiredService<NotesBuilder>();

            var notesToBuild = _noteService.GetNotes(NotesToWrite.AllNotes);
            var noteControls = notesBuilder.BuildNotes(notesToBuild);
            ClearAndAddRange(noteControls.ToArray());
        }

        private void MyNotesItem_Click(object sender, EventArgs e)
        {
            var notesBuilder = _serviceProvider.GetRequiredService<NotesBuilder>();

            var notesToBuild = _noteService.GetNotes(NotesToWrite.MyNotes);
            var noteControls = notesBuilder.BuildNotes(notesToBuild);
            ClearAndAddRange(noteControls.ToArray());
        }

        private void RecycleBinItem_Click(object sender, EventArgs e)
        {
            var notesBuilder = _serviceProvider.GetRequiredService<NotesBuilder>();

            var notesToBuild = _noteService.GetNotes(NotesToWrite.RecycledNotes);
            var noteControls = notesBuilder.BuildNotes(notesToBuild);
            ClearAndAddRange(noteControls.ToArray());
        }

        private void SortByDateOldFirst_Click(object sender, EventArgs e)
        {
            
        }
    }
}