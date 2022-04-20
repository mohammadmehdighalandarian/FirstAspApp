using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<ItemsInMessageMenue> _servises = new List<ItemsInMessageMenue>
        {
            new ItemsInMessageMenue(1, "نقره ای"),
            new ItemsInMessageMenue(1, "طلایی"),
            new ItemsInMessageMenue(1, "پلاتین"),
            new ItemsInMessageMenue(1, "الماس"),
        };

        

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ContactUs()
        {
            var model = new SendMessage()
            {
                servises = new SelectList(_servises, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult ContactUs(SendMessage Form)
        {
            Form.servises = new SelectList(_servises, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = ".اطلاعات وارد شده نادرست است لطفا دوباره تلاش کنید";
                return View(Form);
            }
            ModelState.Clear();
            Form = new SendMessage
            {
                servises = new SelectList(_servises, "Id", "Name")
            };
            ViewBag.succes = "پیام شما با موفقیت ارسال شد با تشکر.";
            return View(Form);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}