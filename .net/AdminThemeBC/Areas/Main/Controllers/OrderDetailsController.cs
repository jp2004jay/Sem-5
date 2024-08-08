using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class OrderDetailsController : Controller
    {
        public List<OrderDetailModel> orderDetails = new List<OrderDetailModel>()
        {
            new OrderDetailModel{OrderDetailID = 501, OrderID = 401, ProductID = 101, Quantity = 2, Amount = 69.00, TotalAmount = 138.00, UserID = 301},
            new OrderDetailModel{OrderDetailID = 502, OrderID = 402, ProductID = 102, Quantity = 2, Amount = 159.00, TotalAmount = 318.00, UserID = 302},
            new OrderDetailModel{OrderDetailID = 503, OrderID = 403, ProductID = 103, Quantity = 3, Amount = 89.00, TotalAmount = 267.00, UserID = 303},
            new OrderDetailModel{OrderDetailID = 504, OrderID = 404, ProductID = 104, Quantity = 1, Amount = 49.00, TotalAmount = 49.00, UserID = 304},
            new OrderDetailModel{OrderDetailID = 505, OrderID = 405, ProductID = 105, Quantity = 2, Amount = 99.00, TotalAmount = 198.00, UserID = 305}
        };

        public IActionResult OrderDetailsList()
        {
            return View(orderDetails);
        }
    }
}
