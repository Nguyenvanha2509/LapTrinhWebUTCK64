using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class Mynew1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }
        public IActionResult error()
        {
            return View();
        }
    }
}
