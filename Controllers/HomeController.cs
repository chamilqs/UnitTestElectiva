using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, World! This is my first Unit Test!");
        }
    }
}
