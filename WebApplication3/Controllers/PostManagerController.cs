using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    public class PostManagerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> _userManager;
        private INotificationRepository _notificationRepository;
        public PostManagerController(ILogger<HomeController> logger, ApplicationDbContext context, 
                                     UserManager<ApplicationUser> userManager, INotificationRepository notificationRepository)
        {
            _logger = logger;
            db = context;
            _userManager = userManager;
            _notificationRepository = notificationRepository;
        }
        public IActionResult Index()
        {
            var postCategoryVm = new CommentViewModel
            {
                Posts = db.Posts.ToList(),                
                Comments = db.Comments.ToList()
            };
            return View(postCategoryVm);
        }

        public IActionResult Details(int id, int postId)
        {
            var postCommentVm = new CommentViewModel
            {
                Post = db.Posts.Find(postId),
                //PostComment = new Comment {PostId = id}
                Comments = db.Comments.Where(c => c.PostId == postId).ToList()
            };

            return View(postCommentVm);
        }

        [HttpPost]
        public IActionResult Apply(int id)
        {
            if (ModelState.IsValid)
            {
                var post = db.Posts.Find(id);
                post.Posted = true;
                string text = $"New article in category {db.Categories.Find(post.CategoryId).Title} has been already posted!";
                _notificationRepository.Create(text);
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
            //return RedirectPermanent($"~/PostManager/Details/{postId}");
            return RedirectToAction("ManageComments", new { postIdManage = postId });
        }

        [HttpPost]
        public IActionResult RemoveComment(int id, int postId)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Remove(db.Comments.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction("ManageComments", new { postIdManage = postId });
        }

        public PartialViewResult ManageComments(int postIdManage)
        {
            //var comments = db.Comments.Where(c => c.PostId == postIdManage).ToList();
            var postCommentVm = new CommentViewModel
            {
                Post = db.Posts.Find(postIdManage),
                //PostComment = new Comment {PostId = id}
                Comments = db.Comments.ToList()
            };
            return PartialView(postCommentVm);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            await _userManager.DeleteAsync(_userManager.FindByIdAsync(id).Result);
            
            return RedirectToAction("ManageUsers");
        }


        public PartialViewResult ManageUsers()
        {
            return PartialView();
        }
    }
}
