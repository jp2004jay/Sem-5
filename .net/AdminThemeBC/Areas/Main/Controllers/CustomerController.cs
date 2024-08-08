using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class CustomerController : Controller
    {
        public List<CustomerModel> customers = new List<CustomerModel>()
        {
            new CustomerModel{CustomerID = 401, CustomerName = "Amit Sharma", HomeAddress = "123 MG Road, Bengaluru", Email = "amit.sharma@example.com", MobileNo = "9876543210", GSTNo = "GSTIN123456", CityName = "Bengaluru", PinCode = "560001", NetAmount = 5000.00, UserID = 301},
            new CustomerModel{CustomerID = 402, CustomerName = "Ritu Verma", HomeAddress = "456 Lajpat Nagar, New Delhi", Email = "ritu.verma@example.com", MobileNo = "8765432109", GSTNo = "GSTIN654321", CityName = "New Delhi", PinCode = "110024", NetAmount= 6000.00, UserID = 302},
            new CustomerModel{CustomerID = 403, CustomerName = "Suresh Iyer", HomeAddress = "789 Andheri West, Mumbai", Email = "suresh.iyer@example.com", MobileNo = "7654321098", GSTNo = "GSTIN789012", CityName = "Mumbai", PinCode = "400053", NetAmount = 7000.00, UserID = 303},
            new CustomerModel{CustomerID = 404, CustomerName = "Priya Singh", HomeAddress = "101 Sector 10, Noida", Email = "priya.singh@example.com", MobileNo = "6543210987", GSTNo = "GSTIN210987", CityName = "Noida", PinCode = "201301", NetAmount = 8000.00, UserID = 304},
            new CustomerModel{CustomerID = 405, CustomerName = "Rajesh Kumar", HomeAddress = "202 Banjara Hills, Hyderabad", Email = "rajesh.kumar@example.com", MobileNo = "5432109876", GSTNo = "GSTIN321098", CityName = "Hyderabad", PinCode = "500034", NetAmount = 9000.00, UserID = 305}
        };

        public IActionResult CustomerList()
        {
            return View(customers);
        }
    }
}
