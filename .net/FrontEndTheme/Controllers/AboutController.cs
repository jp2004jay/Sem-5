using Microsoft.AspNetCore.Mvc;

namespace FrontEndTheme.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
