using Microsoft.AspNetCore.Mvc;
using samplefirst.DataAccessLayer;
using samplefirst.DataAccessLayer.Infrastructure.IRepository;
using samplefirst.DataAccessLayer.Infrastructure.Repository;
using samplefirst.Models;
using samplefirst.Models.ViewModels;

namespace samplefirst.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.products = _unitOfWork.Product.GetAll();
            foreach (TBL_Product product in productViewModel.products)
            {
                product.category = _unitOfWork.Category.GetT(x => x.ID == product.CategoryID);
            }
            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult CreateUpdate(int? id)
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.categories = _unitOfWork.Category.GetAll();

            if (id == null || id == 0) {
                productViewModel.product = new Models.TBL_Product();
            }
            else
            {
                productViewModel.product = _unitOfWork.Product.GetT(x => x.ID == id);
                if (productViewModel.product == null)
                {
                    return NotFound();
                }
            }
            return View(productViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUpdate(ProductViewModel productView)
        {
            if (!ModelState.IsValid)
            {
                if(productView.product.ID == 0)
                {
                    _unitOfWork.Product.Add(productView.product);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                }
                else
                {
                    _unitOfWork.Product.Update(productView.product);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                }
                
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.categories = _unitOfWork.Category.GetAll();
            productViewModel.product = _unitOfWork.Product.GetT(x => x.ID == id);
            if (productViewModel.product == null)
            {
                return NotFound();
            }
            return View(productViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.product = _unitOfWork.Product.GetT(x => x.ID == id);
            if (productViewModel.product == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Delete(productViewModel.product);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
