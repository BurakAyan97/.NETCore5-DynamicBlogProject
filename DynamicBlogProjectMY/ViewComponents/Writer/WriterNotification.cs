using Microsoft.AspNetCore.Mvc;

namespace DynamicBlogProjectMY.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
