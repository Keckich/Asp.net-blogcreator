//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.ViewComponents
{
    public class LastPostsViewComponent : ViewComponent
    {
        private PostContext db;

        public LastPostsViewComponent(PostContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int howMany = 3)
        {
            var posts = await db.Posts
                .OrderByDescending(a => a.PostedOn)
                .Where(p => p.Posted != false)
                .Take(howMany)
                .ToListAsync();
            return View(posts);
        }
    }
}