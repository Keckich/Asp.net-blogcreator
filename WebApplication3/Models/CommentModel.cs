using System;

namespace WebApplication3.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CContent { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public string? CommentAuthor { get; set; }
        public DateTime? PostedOn { get; set; }
    }
}