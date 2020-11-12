using DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class UserDb
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public ICollection<NoteDb> Notes { get; set; }
        public ICollection<LikeDb> Likes { get; set; }
        public ICollection<FavoriteDb> Favorites { get; set; }
    }
}