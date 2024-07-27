using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Controllers
{
    [Area("Main")]
    public class IconsController : Controller
    {
        public IActionResult BootstrapIcons()
        {
            return View();
        }
        public IActionResult RemixIcons()
        {
            return View();
        }
        public IActionResult BoxiIcons()
        {
            return View();
        }
    }
}
