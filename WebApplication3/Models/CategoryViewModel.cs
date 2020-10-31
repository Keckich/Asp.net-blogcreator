using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class CategoryViewModel
    {
        public List<Post> Posts { get; set; }
        public SelectList Categories { get; set; }
        public string PostCategory { get; set; }
        public string SearchString { get; set; }
    }
}