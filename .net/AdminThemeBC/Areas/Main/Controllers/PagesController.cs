using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Controllers
{
    [Area("Main")]
    public class PagesController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Blank()
        {
            return View();
        }
    }
}
