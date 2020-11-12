using DTO;
using DTO.Responses;
using Infrastructure.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NoteBookApp
{
    public partial class EditNoteForm : Form
    {
        private readonly INoteService _noteService;
        private readonly NoteDto _noteToEdit;

        public EditNoteForm(NoteDto note, INoteService noteService)
        {
            InitializeComponent();
            _noteService = noteService ?? throw new ArgumentNullException(nameof(noteService));
            _noteToEdit = note ?? throw new ArgumentNullException(nameof(note));
        }

        private void EditNoteFrom_Load(object sender, EventArgs e)
        {
            NoteText.Text = _noteToEdit.Text;
        }

        private async void ButtonToUpdate_Click(object sender, EventArgs e)
        {
            var note = new NoteDto() { Text = NoteText.Text, Id = _noteToEdit.Id };
            var result = await _noteService.UpdateNote(note);

            if (result is Success)
            {
                Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void EditNoteFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}