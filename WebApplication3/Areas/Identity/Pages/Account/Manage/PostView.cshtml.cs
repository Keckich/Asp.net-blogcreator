using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Areas.Identity.Pages.Account.Manage
{
    public class PostViewModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext db;
        private readonly ILogger<PostViewModel> _logger;

        public PostViewModel(ILogger<PostViewModel> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            db = context;
            _logger = logger;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputPost Post { get; set; }

        public class InputPost
        {
            public List<Post> Posts { get; set; }
        }

        public string Username { get; set; }


        public IActionResult OnGet()
        {
            string author = _userManager.GetUserAsync(User).Result.UserName;
            Post = new InputPost
            {                
                Posts = db.Posts.Where(p => p.Author == author).ToList()
            };            
            return Page();
        }

        public IActionResult OnGetDetails()
        {
            return RedirectToPage("PostDetails");
        }
               

        public async Task<IActionResult> OnPostDelete(int id)
        {
            
            db.Posts.Remove(await db.Posts.FindAsync(id));
            await db.SaveChangesAsync();
            string author = _userManager.GetUserAsync(User).Result.UserName;
            Post = new InputPost            
            {                
                Posts = db.Posts.Where(p => p.Author == author).ToList()
            };
            StatusMessage = "Your post has been deleted.";
            return RedirectToPage();

        }
    }
}
