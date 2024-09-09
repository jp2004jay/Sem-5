using AdminThemeBC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    [Area("CoffeeShop")]
    public class UserController : Controller
    {
        private IConfiguration _configuration;
        private Helper _helper;
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
            _helper = new Helper(_configuration);
        }
        public IActionResult UserList()
        {
            return View(_helper.GetAllThings("SP_FindAllUsers"));
        }
        public IActionResult AddEditUser(int? UserID)
        {
            UserModel model = new UserModel();
            if (UserID != null)
            {
                DataTable table = _helper.GetByIDItem("SP_FindUserById", "@UserId", UserID);

                foreach (DataRow dataRow in table.Rows)
                {
                    model.UserID = Convert.ToInt32(dataRow["UserID"]);
                    model.UserName = dataRow["UserName"].ToString();
                    model.Email = dataRow["Email"].ToString();
                    model.Password = dataRow["Password"].ToString();
                    model.MobileNo = dataRow["MobileNo"].ToString();
                    model.Address = dataRow["Address"].ToString();
                    model.IsActive = Convert.ToInt32(dataRow["IsActive"]);
                }
            }
            else
            {
                model.UserID = 0;
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(UserModel user)
        {
            if (ModelState.IsValid)
            {
                _helper.AddEditUserHelper(user);
                TempData["SuccessMsg"] = "Saved!";
                return RedirectToAction("UserList");
            }
            else
            {
                return View("AddEditUser");
            }
        }
        public IActionResult UserDelete(int? UserID)
        {
            string confirmation = _helper.DeleteItem("SP_DeleteUser", "@UserID", UserID);
            if (confirmation != "Ok")
            {
                TempData["ErrorMsg"] = confirmation;
            }
            else
            {
                TempData["SuccessMsg"] = "Deleted!";
            }
            return RedirectToAction("UserList");
        }
    }
}
