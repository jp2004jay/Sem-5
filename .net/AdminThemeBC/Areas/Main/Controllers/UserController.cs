using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class UserController : Controller
    {
        public List<UserModel> users = new List<UserModel>()
        {
            new UserModel{UserID = 301, UserName = "Ravi Kumar", Email = "ravi.kumar@example.com", Password = "password123", MobileNo = "9876543210", Address = "A-123, Lajpat Nagar, Delhi", IsActive = true},
            new UserModel{UserID = 302, UserName = "Priya Sharma", Email = "priya.sharma@example.com", Password = "password123", MobileNo = "8765432109", Address = "B-456, Andheri, Mumbai", IsActive = true},
            new UserModel{UserID = 303, UserName = "Vikas Gupta", Email = "vikas.gupta@example.com", Password = "password123", MobileNo = "7654321098", Address = "C-789, Salt Lake, Kolkata", IsActive = true},
            new UserModel{UserID = 304, UserName = "Anjali Singh", Email = "anjali.singh@example.com", Password = "password123", MobileNo = "6543210987", Address = "D-101, Indiranagar, Bangalore", IsActive = true},
            new UserModel{UserID = 305, UserName = "Manoj Jain", Email = "manoj.jain@example.com", Password = "password123", MobileNo = "5432109876", Address = "E-202, Banjara Hills, Hyderabad", IsActive = true}
        };

        public IActionResult UserList()
        {
            return View(users);
        }
        public IActionResult AddUser()
        {
            return View();
        }
    }
}
