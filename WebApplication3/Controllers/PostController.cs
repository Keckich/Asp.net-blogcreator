using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Hubs;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PostController : Controller
    {
        private ApplicationDbContext db;
        private readonly ILogger<PostController> _logger;
        UserManager<ApplicationUser> _userManager;
        IHubContext<NotificationHub> _hubContext;
        public PostController(ILogger<PostController> logger, ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager, IHubContext<NotificationHub> hubContext)
        {
            _logger = logger;
            db = context;
            _userManager = userManager;
            _hubContext = hubContext;   
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
            
            return RedirectPermanent("~/Home/Index");
        }       
    }
}