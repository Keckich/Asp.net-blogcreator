using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        [Required]
        [MaxLength(18)]
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime PostedOn { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public bool Posted { get; set; }
        //public IList<Tag> Tags { get; set; } 
        public List<Comment> Comments { get; set; }
    }
}