using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<Post> Posts { get; set; }
    }
}