using System;

namespace DataBase
{
    public class LikeDb
    {
        public Guid Id { get; set; }

        public Guid? NoteId { get; set; }
        public NoteDb Note { get; set; }

        public Guid? UserId { get; set; }
        public UserDb User { get; set; }
    }
}