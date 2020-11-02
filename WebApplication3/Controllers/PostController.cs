using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PostController : Controller
    {
        private PostContext db;
        private readonly ILogger<PostController> _logger;
        UserManager<ApplicationUser> _userManager;
        public PostController(ILogger<PostController> logger, PostContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
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