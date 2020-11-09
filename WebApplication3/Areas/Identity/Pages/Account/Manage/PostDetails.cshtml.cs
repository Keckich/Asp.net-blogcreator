using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;

namespace WebApplication3.Areas.Identity.Pages.Account.Manage
{
    public class PostDetailsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private PostContext db;
        private readonly ILogger<PostDetailsModel> _logger;

        public PostDetailsModel(ILogger<PostDetailsModel> logger, UserManager<ApplicationUser> userManager, PostContext context)
        {
            _userManager = userManager;
            db = context;
            _logger = logger;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public Post PostDetails { get; set; }        

        public string Username { get; set; }

        public IActionResult OnGet(int id)
        {
            var post = db.Posts.Find(id);
            PostDetails = post;
            return Page();
        }
    }
}
