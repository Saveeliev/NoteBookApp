using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Models
{
    public class FavoriteDb
    {
        public Guid Id { get; set; }

        public Guid NoteId { get; set; }
        public NoteDb Note { get; set; }

        public Guid UserId { get; set; }
        public UserDb User { get; set; }
    }
}