using System;
using System.Linq;
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
        }
        
    }
}