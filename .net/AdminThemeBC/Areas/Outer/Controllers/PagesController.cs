using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Outer.Controllers
{
    [Area("Outer")]
    public class PagesController : Controller
    {
        public IActionResult RegisterPage()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult ErrorPage()
        {
            return View();
        }
    }
}
