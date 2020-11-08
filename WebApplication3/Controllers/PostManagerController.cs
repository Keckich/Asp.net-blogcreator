using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PostManagerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PostContext db;
        UserManager<ApplicationUser> _userManager;
        public PostManagerController(ILogger<HomeController> logger, PostContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            db = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
                      

            var postCategoryVm = new CommentViewModel
            {
                Posts = db.Posts.ToList(),                
                Comments = db.Comments.ToList()
            };
            return View(postCategoryVm);
        }

        public IActionResult Details(int id)
        {
            var postCommentVm = new CommentViewModel
            {
                Post = db.Posts.Find(id),
                //PostComment = new Comment {PostId = id}
                Comments = db.Comments.ToList()
            };

            return View(postCommentVm);
        }

        [HttpPost]
        public IActionResult Apply(int id)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Find(id).Posted = true;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Remove(db.Posts.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ApplyComment(int id, int postId)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Find(id).CommentPosted = true;
                db.SaveChanges();
            }
            return RedirectPermanent($"~/PostManager/Details/{postId}");
        }

        [HttpPost]
        public IActionResult RemoveComment(int id, int postId)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Remove(db.Comments.Find(id));
                db.SaveChanges();
            }
            return RedirectPermanent($"~/PostManager/Details/{postId}");
        }
    }
}
