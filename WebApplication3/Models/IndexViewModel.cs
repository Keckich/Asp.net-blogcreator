using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class IndexViewModel
    {
        public List<Post> Posts { get; set; }
        public SelectList Categories { get; set; }
        public string PostCategory { get; set; }
        public string SearchString { get; set; }
        //public IEnumerable<Post> Posts { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
