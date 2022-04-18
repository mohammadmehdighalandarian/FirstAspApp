using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace FirstApp.ViewComponents
{
    public class ProjectViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<projects>()
            {
                new projects(1, "alibaba", "project-1.jpg", "for the first one in iran", "tehran"),
                new projects(1, "alibaba", "project-2.jpg", "for the first one in iran", "tehran"),
                new projects(1, "alibaba", "project-3.jpg", "for the first one in iran", "tehran"),
                new projects(1, "alibaba", "project-4.jpg", "for the first one in iran", "tehran"),
            };
            return View("Project", projects);
        }
    }
}
