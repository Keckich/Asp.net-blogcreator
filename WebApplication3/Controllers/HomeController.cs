using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext db;
        UserManager<ApplicationUser> _userManager;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            db = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string searchString, string postCategory)
        {
            var posts = from p in db.Posts select p;
            IQueryable<string> categoryQuery = from p in db.Categories orderby p.Title select p.Title;   
            if (!String.IsNullOrEmpty(searchString))
            {
                posts = posts.Where(s => s.Title.Contains(searchString));
            }
            
            if (!String.IsNullOrEmpty(postCategory))
            {
                posts = posts.Where(p => p.Category.Title == postCategory);
            }

            var postCategoryVm = new CategoryViewModel
            {
                Categories = new SelectList(await categoryQuery.Distinct().ToListAsync()),                
                Posts = await posts.ToListAsync()
            };
            return View(postCategoryVm);
        }
        [HttpGet]
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
        [Authorize]
        public IActionResult Details(Comment comment, int id)
        {
            if (ModelState.IsValid)
            {
                comment.PostedOn = DateTime.Now;                
                comment.CommentAuthor = _userManager.GetUserName(this.User);                
                db.Add(comment);
                
                db.SaveChanges();
                
                var postCommentVm = new CommentViewModel
                {
                    Post = db.Posts.Find(id),
                    Comments = db.Comments.ToList()
                };
                return View("Details", postCommentVm);
            }
            return View("Details");
        }

        [HttpPost]
        public IActionResult Delete(int id, string author)
        {           
            if (ModelState.IsValid)
            {                              
                db.Posts.Remove(db.Posts.Find(id));                
                db.SaveChanges();
            }
            return RedirectToAction("Index");            
        }

        [HttpPost]
        public IActionResult DeleteComment(int id, int postId)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Remove(db.Comments.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction("CommentList", new { id = postId });
        }

        public PartialViewResult CommentList(int id)
        {
            var postCommentVm = new CommentViewModel
            {
                Post = db.Posts.Find(id),
                Comments = db.Comments.ToList()
            };
            return PartialView(postCommentVm);
        }

        public IActionResult Like(int commentId, int postId)
        {
            if (ModelState.IsValid)
            {
                var comment = db.Comments.Find(commentId);
                var like = new Like
                {
                    Username = _userManager.GetUserName(this.User),
                    CommentId = commentId
                };
                if (db.Likes
                    .Where(l => l.CommentId == commentId)
                    .Where(l => l.Username == _userManager.GetUserName(this.User))
                    .Any())
                {
                    var likes = db.Likes
                    .Where(l => l.CommentId == commentId)
                    .Where(l => l.Username == _userManager.GetUserName(this.User))
                    .ToList();
                    _logger.LogInformation("tuta");
                    db.Likes.Remove(likes[0]);
                    comment.LikesCount--;
                }
                else
                {
                    db.Likes.Add(like);                    
                    comment.LikesCount++;                              
                }
                db.SaveChanges();
            }
            //return RedirectToAction("_CommentPartial", new { id = CommentId});
            return RedirectToAction("CommentList", new { id = postId });
        }

        public PartialViewResult _CommentPartial(int id)
        {
            return PartialView(db.Comments.Find(id));
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1)}
            );
            return LocalRedirect(returnUrl);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}