using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Controllers
{
    [Area("Main")]
    public class ChartsController : Controller
    {
        public IActionResult ChartJS()
        {
            return View();
        }
        public IActionResult ApexCharts()
        {
            return View();
        }
        public IActionResult ECharts()
        {
            return View();
        }
    }
}
