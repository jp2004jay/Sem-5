using Microsoft.AspNetCore.Mvc;

namespace FrontEndTheme.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
