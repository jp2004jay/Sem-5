using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Controllers
{
    [Area("Main")]
    public class TablesController : Controller
    {
        public IActionResult GeneralTables()
        {
            return View();
        }
        public IActionResult DataTables()
        {
            return View();
        }
    }
}
