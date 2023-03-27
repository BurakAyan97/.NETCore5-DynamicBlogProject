using Microsoft.AspNetCore.Mvc;

namespace DynamicBlogProjectMY.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
