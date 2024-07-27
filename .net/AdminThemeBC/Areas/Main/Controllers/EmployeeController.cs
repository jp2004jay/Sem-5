using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
