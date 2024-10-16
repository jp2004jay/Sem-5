using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    [Area("CoffeeShop")]
    [CheckAccess]
    public class OrderDetailsController : Controller
    {
        private IConfiguration _configuration;
        private Helper _helper;
        public OrderDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _helper = new Helper(_configuration);
        }
        public IActionResult OrderDetailsList()
        { 
            return View(_helper.GetAllThings("SP_FindAllOrderDetails"));
        }
        public IActionResult AddEditOrderDetail(int? OrderDetailID)
        {
            OrderDetailModel model = new OrderDetailModel();
            if (OrderDetailID != null)
            {
                DataTable table = _helper.GetByIDItem("SP_FindOrderDetailById", "@OrderDetailId", OrderDetailID);

                foreach (DataRow dataRow in table.Rows)
                {
                    model.OrderDetailID = Convert.ToInt32(dataRow["OrderDetailID"]);
                    model.OrderID = Convert.ToInt32(dataRow["OrderID"]);
                    model.ProductID = Convert.ToInt32(dataRow["ProductID"]);
                    model.Quantity = Convert.ToInt32(dataRow["Quantity"]);
                    model.Amount = Convert.ToDouble(dataRow["Amount"]);
                    model.TotalAmount = Convert.ToDouble(dataRow["TotalAmount"]);
                    model.UserID = Convert.ToInt32(dataRow["UserID"]);
                }
            }
            else
            {
                model.OrderDetailID = 0;
            }
            ViewBag.orders = _helper.GetOrders();
            ViewBag.products = _helper.GetProducts();
            ViewBag.users = _helper.GetUsers();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(OrderDetailModel orderDetails)
        {
            if (ModelState.IsValid)
            {
                _helper.AddEditOrderDetailHelper(orderDetails);
                TempData["SuccessMsg"] = "Saved!";
                return RedirectToAction("OrderDetailsList");
            }
            else
            {
                ViewBag.users = _helper.GetUsers();
                ViewBag.products = _helper.GetProducts();
                ViewBag.orders = _helper.GetOrders();
                return View("AddEditOrderDetail");
            }
        }
        public IActionResult OrderDetailDelete(int? OrderDetailID)
        {
            string confirmation = _helper.DeleteItem("SP_DeleteOrderDetail", "@OrderDetailID", OrderDetailID);
            if (confirmation != "Ok")
            {
                TempData["ErrorMsg"] = confirmation;
            }
            else
            {
                TempData["SuccessMsg"] = "Deleted!";
            }
            return RedirectToAction("OrderDetailsList");
        }
    }
}
