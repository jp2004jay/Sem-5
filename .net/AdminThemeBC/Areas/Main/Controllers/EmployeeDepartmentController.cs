using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class EmployeeDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
