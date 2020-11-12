using DataBase.Models;
using System;
using System.Collections.Generic;

namespace DataBase
{
    public class NoteDb
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsPrivate { get; set; }

        public Guid UserId { get; set; }
        public UserDb User { get; set; }

        public ICollection<LikeDb> Likes { get; set; }
        public ICollection<FavoriteDb> Favorites { get; set; }
    }
}