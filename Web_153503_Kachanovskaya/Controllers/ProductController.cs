using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_153503_Kachanovskaya.Services.CategoryService;
using Web_153503_Kachanovskaya.Services.ProductService;

namespace Web_153503_Kachanovskaya.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;

        }

        // GET: ProductController
        public async Task<IActionResult> Index(string? category)
        {
            var categoryResponse = await _categoryService.GetCategoryListAsync();
            if (!categoryResponse.Success)
                return NotFound(categoryResponse.ErrorMessage);

            ViewData["Categories"] = categoryResponse.Data;
            ViewData["CurrentCategory"] = categoryResponse.Data.SingleOrDefault(c => c.NormalizedName == category);

            var productResponse = await _productService.GetProductListAsync(category);
            if(!productResponse.Success)
                return NotFound(productResponse.ErrorMessage);
            else 
                return View(productResponse.Data);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
