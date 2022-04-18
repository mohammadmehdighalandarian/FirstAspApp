using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.ViewComponents
{
    public class ArticleViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Articles>()
            {
                new Articles(1, "مقاله1", "this is for my new ksajdasd", "blog-post-thumb-1.jpg"),
                new Articles(1, "مقاله1", "this is for my new ksajdasd", "blog-post-thumb-1.jpg"),
                new Articles(1, "مقاله1", "this is for my new ksajdasd", "blog-post-thumb-1.jpg"),
            };
            return View()
        }
    }
}
