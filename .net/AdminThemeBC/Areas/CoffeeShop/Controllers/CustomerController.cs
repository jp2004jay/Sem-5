using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    [Area("CoffeeShop")]
    public class CustomerController : Controller
    {
        private IConfiguration _configuration;
        private Helper _helper;
        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
            _helper = new Helper(_configuration);
        }
        public IActionResult CustomerList()
        {
            return View(_helper.GetAllThings("SP_FindAllCustomers"));
        }
        public IActionResult AddEditCustomer(int? CustomerID)
        {
            CustomerModel model = new CustomerModel();
            if (CustomerID != null)
            {
                DataTable table = _helper.GetByIDItem("SP_FindCustomerById", "@CustomerId", CustomerID);

                foreach (DataRow dataRow in table.Rows)
                {
                    model.CustomerID = Convert.ToInt32(dataRow["CustomerID"]);
                    model.CustomerName = dataRow["CustomerName"].ToString();
                    model.HomeAddress = dataRow["HomeAddress"].ToString();
                    model.Email = dataRow["Email"].ToString();
                    model.MobileNo = dataRow["MobileNo"].ToString();
                    model.GSTNo = dataRow["GstNo"].ToString();
                    model.CityName = dataRow["CityName"].ToString();
                    model.PinCode = dataRow["PinCode"].ToString();
                    model.NetAmount = Convert.ToDouble(dataRow["NetAmount"]);
                    model.UserID = Convert.ToInt32(dataRow["UserID"]);
                }
            }
            else
            {
                model.CustomerID = 0;
            }
            ViewBag.UserList = _helper.GetUsers();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CustomerModel customer)
        {
            if (ModelState.IsValid)
            {
                _helper.AddEditCustomerHelper(customer);
                TempData["SuccessMsg"] = "Saved!";
                return RedirectToAction("CustomerList");
            }
            else
            {
                ViewBag.UserList = _helper.GetUsers();
                return View("AddEditCustomer");
            }
        }
        public IActionResult CustomerDelete(int? CustomerID)
        {
            string confirmation = _helper.DeleteItem("SP_DeleteCustomer", "@CustomerID", CustomerID);
            if (confirmation != "Ok")
            {
                TempData["ErrorMsg"] = confirmation;
            }
            else
            {
                TempData["SuccessMsg"] = "Deleted!";
            }
            return RedirectToAction("CustomerList");
        }
    }
}
