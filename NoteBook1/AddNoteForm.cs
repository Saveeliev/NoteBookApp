using DTO;
using DTO.Responses;
using Infrastructure.Services;
using System;
using System.Windows.Forms;

namespace NoteBookApp
{
    public partial class AddNoteForm : Form
    {
        private readonly INoteService _noteService;

        public AddNoteForm(INoteService noteService)
        {
            InitializeComponent();
            _noteService = noteService ?? throw new ArgumentNullException(nameof(noteService));
        }

        private void AddNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private async void ButtonToAddNote_Click(object sender, EventArgs e)
        {
            var note = new NoteDto { Text = EnterText.Text, IsPrivate = CheckBoxIsPrivate.Checked };
            var result = await _noteService.AddNote(note);

            if (result is Success)
            {
                FormEditor.ClearForm(this);
                Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}