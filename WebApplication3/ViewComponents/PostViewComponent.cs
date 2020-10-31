using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.ViewComponents
{
    public class PostViewComponent : ViewComponent
    {
        private PostContext db;

        public PostViewComponent(PostContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var items = await db.Posts.Include(p => p.Comments)
                .FirstOrDefaultAsync(p => p.Id == id);
           
            return View(items);
        }
    }
}