using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PostController : Controller
    {

       // [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        /*[HttpPost]
        public IActionResult Create(Post model)
        {
            
        }*/
        
    }
}