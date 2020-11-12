using DTO;
using System.Windows.Forms;

namespace NoteBookApp
{
    public partial class ReadNoteForm : Form
    {
        private readonly NoteDto _noteToRead;

        public ReadNoteForm(NoteDto note)
        {
            InitializeComponent();
            _noteToRead = note ?? throw new System.ArgumentNullException(nameof(note));

            NoteText.Text = _noteToRead.Text;
        }
    }
}