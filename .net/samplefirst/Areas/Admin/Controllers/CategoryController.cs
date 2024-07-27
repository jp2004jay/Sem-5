using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using samplefirst.DataAccessLayer;
using samplefirst.DataAccessLayer.Infrastructure.IRepository;
using samplefirst.Models;
using samplefirst.Models.ViewModels;
using System.Security.Principal;

namespace samplefirst.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            CategoryViewModel categoryView = new CategoryViewModel();
            categoryView.categories = _unitOfWork.Category.GetAll();
            return View(categoryView);
        }
        [HttpGet]
        public IActionResult CreateUpdate(int? id)
        {
            CategoryViewModel categoryView = new CategoryViewModel();
            if (id == null || id == 0)
            {
                categoryView.category = new Category();
                categoryView.category.ID = 0;
                return View(categoryView);
            }
            else
            {
                categoryView.category = _unitOfWork.Category.GetT(x => x.ID == id);
                if (categoryView.category == null) 
                {
                    return NotFound();
                }
                else
                { 
                    return View(categoryView);
                }
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUpdate(CategoryViewModel categoryView)
        {
            if (ModelState.IsValid)
            {
                if (categoryView.category.ID == 0)
                {
                    _unitOfWork.Category.Add(categoryView.category);
                    _unitOfWork.Save();
                    TempData["success"] = "Category Saved!";
                    return RedirectToAction("Index");
                }
                else
                {
                    _unitOfWork.Category.Update(categoryView.category);
                    _unitOfWork.Save();
                    TempData["success"] = "Category Edited!";
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        { 
            if (id == null || id == 0)
            {
                return NotFound();
            }
            CategoryViewModel categoryView = new CategoryViewModel();
            categoryView.category = _unitOfWork.Category.GetT(x => x.ID == id);
            if (categoryView.category == null)
            {
                return NotFound();
            }
            return View(categoryView);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            CategoryViewModel categoryView = new CategoryViewModel();
            categoryView.category = _unitOfWork.Category.GetT(x => x.ID == id);
            if (categoryView.category == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Delete(categoryView.category);
            _unitOfWork.Save();
            TempData["success"] = "Category Deleted!";
            return RedirectToAction("Index");
        }
    }
}
