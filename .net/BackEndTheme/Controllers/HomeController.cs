using BackEndTheme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackEndTheme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Components()
        {
            return View();
        }
        public IActionResult Forms()
        {
            return View();
        }
        public IActionResult Tables()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public IActionResult Typography()
        {
            return View();
        }
        public IActionResult Icons()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
