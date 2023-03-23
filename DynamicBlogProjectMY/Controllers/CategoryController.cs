using Microsoft.AspNetCore.Mvc;

namespace DynamicBlogProjectMY.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
