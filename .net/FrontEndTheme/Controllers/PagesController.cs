using Microsoft.AspNetCore.Mvc;

namespace FrontEndTheme.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Elements()
        {
            return View();
        }
    }
}
