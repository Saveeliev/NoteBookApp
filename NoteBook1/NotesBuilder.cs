using DTO;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace NoteBookApp
{
    public class NotesBuilder
    {
        private readonly INoteService _noteService;
        private readonly IUserService _userService;

        public NotesBuilder(INoteService noteService, IUserService userService)
        {
            _noteService = noteService ?? throw new ArgumentNullException(nameof(noteService));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public ObservableCollection<NoteControl> BuildNotes(List<NoteDto> notes)
        {
            var controls = new ObservableCollection<NoteControl>();
            var noteControlPoint = 0;

            foreach (var note in notes)
            {
                var noteControl = new NoteControl(note, _noteService, _userService);
                noteControl.Location = new Point(0, 0 + noteControlPoint);

                controls.Add(noteControl);

                noteControlPoint += 45;
            }

            return controls;
        }
    }
}