using DynamicBlogProjectMY.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DynamicBlogProjectMY.ViewComponents
{
    public class CommentsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Burak",
                },
                new UserComment
                {
                    ID = 2,
                    Username = "Mesut",
                },
                new UserComment
                {
                    ID = 3,
                    Username = "Recep",
                }
            };
            return View(commentValues);
        }
    }
}
