using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace AdminThemeBC.Areas.Main.Controllers
{
    [Area("Main")]
    public class ProductController : Controller
    {
        public List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel{ProductID = 101, ProductName = "Masala Dosa", ProductPrice = 69.00, Description="Crispy and spicy", ProductCode="MD01", UserID=301},
            new ProductModel{ProductID = 102, ProductName = "Paneer Butter Masala", ProductPrice = 159.00, Description="Rich and creamy", ProductCode="PBM02", UserID=302},
            new ProductModel{ProductID = 103, ProductName = "Chole Bhature", ProductPrice = 89.00, Description="Spicy chickpeas with fried bread", ProductCode="CB03", UserID=303},
            new ProductModel{ProductID = 104, ProductName = "Idli Sambhar", ProductPrice = 49.00, Description="Soft idlis with tangy sambhar", ProductCode="IS04", UserID=304},
            new ProductModel{ProductID = 105, ProductName = "Pav Bhaji", ProductPrice = 99.00, Description="Spicy mashed vegetables with bread", ProductCode="PB05", UserID=305}
        };
        private IConfiguration _configuration;

        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult ProductList()
        {
            string connectionString = this._configuration.GetConnectionString("ConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_FindAllProducts";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return View(table);
        }
        public IActionResult AddEditProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("::::::::Done");
                return RedirectToAction("ProductList");
            }
            else
            {
                Console.WriteLine("::::::::Error");
                return View("AddEditProduct", product);
            }
        }

    }
}
