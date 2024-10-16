using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace AdminThemeBC.Areas.Outer.Controllers
{
    [Area("Outer")]
    public class PagesController : Controller
    {
        IConfiguration _configuration;
        public PagesController(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public IActionResult RegisterPage()
        {
            return View();
        }
        [Route("~/")]
        public IActionResult LoginPage(UserLoginModel userLoginModel)
        {
            return View(userLoginModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserLogin(UserLoginModel userLoginModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string connectionString = this._configuration.GetConnectionString("ConnectionString");
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "PR_User_Login";
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = userLoginModel.Email;
                    sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = userLoginModel.Password;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(sqlDataReader);
                    sqlConnection.Close();

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            HttpContext.Session.SetString("UserID", dr["UserID"].ToString());
                            HttpContext.Session.SetString("UserName", dr["UserName"].ToString());
                            HttpContext.Session.SetString("EmailAddress", dr["Email"].ToString());
                        }

                        return RedirectToAction("ProductList", "Product", new { area = "CoffeeShop" });
                    }
                    else
                    {
                        TempData["ErrorMsg"] = "Invalid login attempt.";
                    }
                }
                catch (Exception ex)
                {
                    TempData["ErrorMsg"] = ex.Message;
                }
                TempData["ErrorMsg"] = "Invalid Login attempt, Please Register first";
                return RedirectToAction("LoginPage");
            }
            else
            {
                if (string.IsNullOrEmpty(userLoginModel.Email))
                {
                    TempData["ErrorMsg"] = "Email is required";
                }
                else if (!userLoginModel.Email.Contains("@") || !userLoginModel.Email.Contains("."))
                {
                    TempData["ErrorMsg"] = "Invalid email format";
                }
                else if (string.IsNullOrEmpty(userLoginModel.Password))
                {
                    TempData["ErrorMsg"] = "Password is required";
                }
                else
                {
                    TempData["ErrorMsg"] = "Please fill all the fields properly";
                }
                return RedirectToAction("LoginPage", userLoginModel);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserRegister(UserRegisterModel userRegisterModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string connectionString = this._configuration.GetConnectionString("ConnectionString");
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandText = "PR_User_Register";
                    sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userRegisterModel.UserName;
                    sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = userRegisterModel.Password;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = userRegisterModel.Email;
                    sqlCommand.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = userRegisterModel.MobileNo;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    TempData["SuccessMsg"] = "Registration Successful";
                    return RedirectToAction("LoginPage", "Pages");
                }
            }
            catch (Exception e)
            {
                TempData["ErrorMsg"] = e.Message;
                return RedirectToAction("RegisterPage");
            }
            return RedirectToAction("RegisterPage");
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LoginPage", "Pages");
        }
        public IActionResult ErrorPage()
        {
            return View();
        }
    }
}
