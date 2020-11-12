using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Like
    {
        public int Id { get; set; }
        public Comment Comment { get; set; }         
        public int CommentId { get; set; }
        public string Username { get; set; }
        public ApplicationUser User { get; set; }
    }

}
