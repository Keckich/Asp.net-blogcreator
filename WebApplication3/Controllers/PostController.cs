using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PostController : Controller
    {
        private PostContext db;
        UserManager<IdentityUser> _userManager;
        public PostController(PostContext context, UserManager<IdentityUser> userManager)
        {
            db = context;
            _userManager = userManager;
        }
        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View(db.Categories.ToList());
            /*return View();*/
        }
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                post.Author = _userManager.GetUserName(this.User);
                post.PostedOn = DateTime.Now;
                db.Posts.Add(post);
                db.SaveChanges();
            }
            return View(db.Categories.ToList());
            /*return View();*/
        }
        /*[HttpGet("Home/Details/{Id}")]
        public async Task<IActionResult> Details(int? PostId)
        {

            var comment = new Comment { PostId = PostId.Value};
            return View(comment);
        }
        [HttpPost("Home/Details/{Id}")]
        public async Task<IActionResult> CreateComment(int PostId, Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Add(comment);
                await db.SaveChangesAsync();

                return View("Details", new Comment { PostId = comment.PostId });
            }
            return View("Details");
        }*/
        
    }
}