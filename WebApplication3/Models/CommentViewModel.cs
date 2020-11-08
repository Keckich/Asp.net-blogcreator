using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class CommentViewModel
    {
        public Post Post { get; set; }
        //public Comment PostComment { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}