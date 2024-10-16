using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    [Area("CoffeeShop")]
    [CheckAccess]
    public class TBLProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TBL_Product product)
        {
            if (ModelState.IsValid)
            {
                // Save the product to the database (not implemented here)
                return RedirectToAction("Index"); // Redirect to a suitable action
            }
            return View("Index", product);
        }
    }
}
