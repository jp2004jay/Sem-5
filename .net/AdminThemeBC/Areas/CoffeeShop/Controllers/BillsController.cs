using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Microsoft.CodeAnalysis;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    [Area("CoffeeShop")]
    public class BillsController : Controller
    {
        private IConfiguration _configuration;
        private Helper _helper;
        public BillsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _helper = new Helper(_configuration);
        }
        public IActionResult BillsList()
        {
            return View(_helper.GetAllThings("SP_FindAllBills"));
        }
        public IActionResult AddEditBill(int? BillID)
        {
            BillModel model = new BillModel();
            if (BillID != null)
            {
                DataTable table = _helper.GetByIDItem("SP_FindBillById", "@BillId", BillID);

                foreach (DataRow dataRow in table.Rows)
                {
                    model.BillID = Convert.ToInt32(dataRow["BillID"]);
                    model.BillNumber = dataRow["BillNumber"].ToString();
                    model.BillDate = Convert.ToDateTime(dataRow["BillDate"]);
                    model.OrderID = Convert.ToInt32(dataRow["OrderID"]);
                    model.TotalAmount = Convert.ToDouble(dataRow["TotalAmount"]);
                    model.Discount = dataRow["Discount"] != DBNull.Value ? Convert.ToDouble(dataRow["Discount"]) : (double?)null;
                    model.NetAmount = Convert.ToDouble(dataRow["NetAmount"]);
                    model.UserID = Convert.ToInt32(dataRow["UserID"]);
                }
            }
            else
            {
                model.BillID = 0;
            }
            ViewBag.orders = _helper.GetOrders();
            ViewBag.users = _helper.GetUsers();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(BillModel bill)
        {
            if (ModelState.IsValid)
            {
                _helper.AddEditBillHelper(bill);
                TempData["SuccessMsg"] = "Saved!";
                return RedirectToAction("BillsList");
            }
            else
            {
                ViewBag.users = _helper.GetUsers();
                ViewBag.orders = _helper.GetOrders();
                return View("AddEditBill");
            }
        }
        public IActionResult BillDelete(int? BillID)
        {
            string confirmation = _helper.DeleteItem("SP_DeleteBill", "@BillID", BillID);
            if (confirmation != "Ok")
            {
                TempData["ErrorMsg"] = confirmation;
            }
            else
            {
                TempData["SuccessMsg"] = "Deleted!";
            }
            return RedirectToAction("BillsList");            
        }
    }
}
