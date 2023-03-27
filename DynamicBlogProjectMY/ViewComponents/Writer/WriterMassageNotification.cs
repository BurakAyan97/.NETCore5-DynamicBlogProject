using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DynamicBlogProjectMY.ViewComponents.Writer
{
    public class WriterMassageNotification : ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "burak@gmail.com";
            var values = mm.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
