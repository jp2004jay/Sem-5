using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace samplefirst.Areas.Admin.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult CreateCookie()
        {
            string key = "jp_patel";
            string value = "This is my project";

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            options.Secure = true;

            HttpContext.Response.Cookies.Append(key, value, options);

            return View();
        }
    }
}
