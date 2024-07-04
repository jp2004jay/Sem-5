using Microsoft.AspNetCore.Mvc;

namespace samplefirst.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NameFirst()
        {
            return View();
        }
    }
}
