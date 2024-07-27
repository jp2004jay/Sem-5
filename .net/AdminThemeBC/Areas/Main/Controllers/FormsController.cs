using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Controllers
{
    [Area("Main")]
    public class FormsController : Controller
    {
        public IActionResult FormElements()
        {
            return View();
        }
        public IActionResult FormLayouts()
        {
            return View();
        }
        public IActionResult FormEditors()
        {
            return View();
        }
        public IActionResult FormValidations()
        {
            return View();
        }
    }
}
