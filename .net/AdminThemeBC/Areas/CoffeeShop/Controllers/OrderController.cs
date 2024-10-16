using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    [Area("CoffeeShop")]
    [CheckAccess]
    public class OrderController : Controller
    {
        private IConfiguration _configuration;
        private Helper _helper;
        public OrderController(IConfiguration configuration)
        {
            _configuration = configuration;
            _helper = new Helper(_configuration);
        }
        public IActionResult OrderList()
        {
            return View(_helper.GetAllThings("SP_FindAllOrders"));
        }
        public IActionResult AddEditOrder(int? OrderID)
        {
            OrderModel model = new OrderModel();
            if (OrderID != null)
            {
                DataTable table = _helper.GetByIDItem("SP_FindOrderById", "@OrderId", OrderID);

                foreach (DataRow dataRow in table.Rows)
                {
                    model.OrderID = Convert.ToInt32(dataRow["OrderID"]);
                    model.OrderName = dataRow["OrderName"].ToString();
                    model.OrderDate = Convert.ToDateTime(dataRow["OrderDate"]);
                    model.CustomerID = Convert.ToInt32(dataRow["CustomerID"]);
                    model.PaymentMode = dataRow["PaymentMode"].ToString();
                    model.TotalAmount = dataRow["TotalAmount"] != DBNull.Value ? Convert.ToDouble(dataRow["TotalAmount"]) : (double?)null;
                    model.ShippingAddress = dataRow["ShippingAddress"].ToString();
                    model.UserID = Convert.ToInt32(dataRow["UserID"]);
                }
            }
            else
            {
                model.OrderID = 0;
            }
            ViewBag.customers = _helper.GetCustomers();
            ViewBag.users = _helper.GetUsers();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(OrderModel order)
        {
            if (ModelState.IsValid)
            {
                _helper.AddEditOrderHelper(order);
                TempData["SuccessMsg"] = "Saved!";
                return RedirectToAction("OrderList");
            }
            else
            {
                ViewBag.customers = _helper.GetCustomers();
                ViewBag.users = _helper.GetUsers();
                return View("AddEditOrder");
            }
        }
        public IActionResult OrderDelete(int? OrderID)
        {
            string confirmation = _helper.DeleteItem("SP_DeleteOrder", "@OrderID", OrderID);
            if (confirmation != "Ok")
            {
                TempData["ErrorMsg"] = confirmation;
            }
            else
            {
                TempData["SuccessMsg"] = "Deleted!";
            }
            return RedirectToAction("OrderList");
        }
    }
}
