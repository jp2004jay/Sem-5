using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class OrderController : Controller
    {
        public List<OrderModel> orders = new List<OrderModel>()
        {
            new OrderModel{OrderID = 401, OrderDate = DateTime.Parse("2023-07-01"), CustomerID = 501, PaymentMode = "Credit Card", TotalAmount = 500.00, ShippingAddress = "A-123, Lajpat Nagar, Delhi", UserID = 301},
            new OrderModel{OrderID = 402, OrderDate = DateTime.Parse("2023-07-02"), CustomerID = 502, PaymentMode = "Cash", TotalAmount = 750.00, ShippingAddress = "B-456, Andheri, Mumbai", UserID = 302},
            new OrderModel{OrderID = 403, OrderDate = DateTime.Parse("2023-07-03"), CustomerID = 503, PaymentMode = "Debit Card", TotalAmount = 1000.00, ShippingAddress = "C-789, Salt Lake, Kolkata", UserID = 303},
            new OrderModel{OrderID = 404, OrderDate = DateTime.Parse("2023-07-04"), CustomerID = 504, PaymentMode = "Credit Card", TotalAmount = 1250.00, ShippingAddress = "D-101, Indiranagar, Bangalore", UserID = 304},
            new OrderModel{OrderID = 405, OrderDate = DateTime.Parse("2023-07-05"), CustomerID = 505, PaymentMode = "Cash", TotalAmount = 1500.00, ShippingAddress = "E-202, Banjara Hills, Hyderabad", UserID = 305}
        };

        public IActionResult OrderList()
        {
            return View(orders);
        }
    }
}
