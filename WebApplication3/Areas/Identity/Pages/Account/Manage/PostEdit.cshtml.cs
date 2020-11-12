using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Areas.Identity.Pages.Account.Manage
{
    public class PostEditModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext db;
        private readonly ILogger<PostEditModel> _logger;

        public PostEditModel(ILogger<PostEditModel> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            db = context;
            _logger = logger;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public PostEditView PostEdit { get; set; }

        public class PostEditView
        {
            public List<Category> Categories { get; set; }
            public Post Post { get; set; }
        }

        public string Username { get; set; }

        public IActionResult OnGet(int id)
        {
            var post = db.Posts.Find(id);
            var categories = db.Categories.ToList();
            PostEdit = new PostEditView
            {
                Categories = categories,
                Post = post
            };
            return Page();
        }

        public IActionResult OnPost(Post post)
        {
            var _post = db.Posts.Find(post.Id);
            _post.Category = post.Category;
            _post.CategoryId = post.CategoryId;
            _post.Title = post.Title;
            _post.ShortDescription = post.ShortDescription;
            _post.Description = post.Description;
            db.SaveChanges();
            return RedirectToPage("PostView");
        }
    }
}
