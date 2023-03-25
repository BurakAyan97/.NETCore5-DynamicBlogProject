using Microsoft.AspNetCore.Mvc;

namespace DynamicBlogProjectMY.ViewComponents.Writer
{
    public class WriterMassageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
