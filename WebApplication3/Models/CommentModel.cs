using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CContent { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public bool CommentPosted { get; set; }
        public List<Like> Likes { get; set; }
        public int LikesCount { get; set; }
        public ApplicationUser User { get; set; }
        public string? CommentAuthor { get; set; }
        public DateTime PostedOn { get; set; }
    }
}