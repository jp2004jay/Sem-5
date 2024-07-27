using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Controllers
{
    [Area("Main")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Jay Ramani";

            TempData["ageSmall"] = 6;
            TempData["age"] = 16;
            TempData["ageBig"] = 26;

            ViewData["address"] = "Rajkot, Gujarat";
         
            return RedirectToAction("ChartJS","Charts");
        }
    }
}
