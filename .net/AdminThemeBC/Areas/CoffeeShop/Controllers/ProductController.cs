using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    [Area("CoffeeShop")]
    [CheckAccess]
    public class ProductController : Controller
    {
        public IConfiguration _configuration;
        private Helper _helper;
        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
            _helper = new Helper(_configuration);
        }
        public IActionResult ProductList()
        {
            return View(_helper.GetAllThings("SP_FindAllProducts"));
        }
        public IActionResult AddEditProduct(int? ProductID)
        {
            ProductModel model = new ProductModel();
            if (ProductID != null) 
            {
                try
                {
                    DataTable table = _helper.GetByIDItem("SP_FindProductById", "@ProductId", ProductID);

                    foreach (DataRow dataRow in table.Rows)
                    {
                        model.ProductID = Convert.ToInt32(dataRow["ProductID"]);
                        model.ProductName = dataRow["ProductName"].ToString();
                        model.ProductCode = dataRow["ProductCode"].ToString();
                        model.ProductPrice = Convert.ToDouble(dataRow["ProductPrice"]);
                        model.Description = dataRow["Description"].ToString();
                        model.UserID = Convert.ToInt32(dataRow["UserID"]);
                    }
                } 
                catch(Exception e) 
                {
                    TempData["ErrorMsg"] = e.Message;
                }
            }
            else
            {
                model.ProductID = 0;
            }
            ViewBag.UserList = _helper.GetUsers();
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                _helper.AddEditProductHelper(product);
                TempData["SuccessMsg"] = "Saved!";
                return RedirectToAction("ProductList");
            }
            else
            {
                ViewBag.UserList = _helper.GetUsers();
                return View("AddEditProduct", product);
            }
        }
        public IActionResult ProductDelete(int? ProductID)
        { 
            string confirmation = _helper.DeleteItem("SP_DeleteProduct", "@ProductID", ProductID);
            if (confirmation != "Ok")
            {
                TempData["ErrorMsg"] = confirmation;
            }
            else
            {
                TempData["SuccessMsg"] = "Deleted!";
            }
            return RedirectToAction("ProductList");
        }
    }
}
