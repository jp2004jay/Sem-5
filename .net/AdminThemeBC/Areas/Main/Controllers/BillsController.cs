using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class BillsController : Controller
    {
        public List<BillModel> bills = new List<BillModel>()
        {
            new BillModel{BillID = 601, BillNumber = "B001", BillDate = DateTime.Parse("2023-07-01"), OrderID = 401, TotalAmount = 500.00, Discount = 50.00, NetAmount = 450.00, UserID = 301},
            new BillModel{BillID = 602, BillNumber = "B002", BillDate = DateTime.Parse("2023-07-02"), OrderID = 402, TotalAmount = 750.00, Discount = 75.00, NetAmount = 675.00, UserID = 302},
            new BillModel{BillID = 603, BillNumber = "B003", BillDate = DateTime.Parse("2023-07-03"), OrderID = 403, TotalAmount = 1000.00, Discount = 100.00, NetAmount = 900.00, UserID = 303},
            new BillModel{BillID = 604, BillNumber = "B004", BillDate = DateTime.Parse("2023-07-04"), OrderID = 404, TotalAmount = 1250.00, Discount = 125.00, NetAmount = 1125.00, UserID = 304},
            new BillModel{BillID = 605, BillNumber = "B005", BillDate = DateTime.Parse("2023-07-05"), OrderID = 405, TotalAmount = 1500.00, Discount = 150.00, NetAmount = 1350.00, UserID = 305}
        };

        public IActionResult BillsList()
        {
            return View(bills);
        }
    }
}
