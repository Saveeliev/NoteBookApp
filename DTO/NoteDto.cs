using System;

namespace DTO
{
    public class NoteDto
    {
        public Guid Id { get; set; }

        public int LikesCount { get; set; }
        public bool IsLiked { get; set; }
        public string Text { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsFavoriteExist { get; set; }
        public string UserName { get; set; }
        public Guid UserId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}