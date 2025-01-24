using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SellBook.DataAccess.Repository;
using SellBook.DataAccess.Repository.IRepository;
using SellBook.Models;
using SellBook.Models.Models;
using SellBook.Models.ViewModel;

namespace SellBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        private readonly IUnitOfWork _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public ProductController(IUnitOfWork context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _hostingEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Product> objProductList = _context.Product.GetAll(includeProperties: "Category").ToList();
            IEnumerable<SelectListItem> CategoryList = _context.Category.GetAll().Select(row => new SelectListItem
            {
                Text = row.Name,
                Value = row.Id.ToString()
            });
            ViewBag.CategoryList = CategoryList;
            return View(objProductList);
        }

        public IActionResult Upsert(Guid? id) // Update and Insert
        {
            IEnumerable<SelectListItem> CategoryList = _context.Category.GetAll().Select(row => new SelectListItem
            {
                Text = row.Name,
                Value = row.Id.ToString()
            });

            ProductVM productVM = new()
            {
                Product = new Product(),
                CategoryList = CategoryList
            };

            if (id == null || id.Equals(Guid.Empty))
            {
                //Create
                return View(productVM);
            }
            else
            {
                //Update
                productVM.Product = _context.Product.Get(row => row.Id == id);
                return View(productVM);

            }
        }

        [HttpPost]
        public IActionResult Upsert(ProductVM obj, IFormFile? file)
        {

            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostingEnvironment.WebRootPath;
                if (file != null)
                {
                    string filename = file.FileName;
                    string productPath = Path.Combine(wwwRootPath + @"\images\product");

                    if (!string.IsNullOrEmpty(obj.Product.ImageUrl))
                    {
                        var oldImageUrl = Path.Combine(wwwRootPath + obj.Product.ImageUrl);
                        if (System.IO.File.Exists(oldImageUrl))
                        {
                            System.IO.File.Delete(oldImageUrl);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(productPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    obj.Product.ImageUrl = @"\images\product\" + filename;
                }

                if (obj.Product.Id == Guid.Empty)
                {
                    _context.Product.Add(obj.Product);
                    TempData["Success"] = "Product Successfully Created!";
                }
                else
                {
                    _context.Product.Update(obj.Product);
                    TempData["Success"] = "Product Successfully Modified!";
                }
                _context.Save();

                return RedirectToAction("Index", "Product");
            }
            else
            {
                IEnumerable<SelectListItem> CategoryList = _context.Category.GetAll().Select(row => new SelectListItem
                {
                    Text = row.Name,
                    Value = row.Id.ToString()
                });

                obj.CategoryList = CategoryList;

                return View(obj.CategoryList);
            }
        }

        public IActionResult Edit(Guid? id)
        {
            Product productFromDb = _context.Product.Get(row => row.Id == id);
            if (productFromDb == null)
            {
                return NotFound();
            }
            IEnumerable<SelectListItem> CategoryList = _context.Category.GetAll().Select(row => new SelectListItem
            {
                Text = row.Name,
                Value = row.Id.ToString()
            });
            ViewBag.CategoryList = CategoryList;
            return View(productFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Update(obj);
                _context.Save();
                TempData["Success"] = "Product Successfully Modified!";
                return RedirectToAction("Index", "Product");
            }
            return View();
        }

        #region APICALL
        [HttpGet]
        public IActionResult GetAll()
        {
            var obj = _context.Product.GetAll(includeProperties: "Category");
            return Json(new { data = obj });
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            Product productFromDb = _context.Product.Get(row => row.Id == id);
            if (productFromDb == null)
            {
                return Json(new { success = false, message = "Error while delete" });
            }

            var oldImageUrl = Path.Combine(_hostingEnvironment.WebRootPath + productFromDb.ImageUrl);
            if (System.IO.File.Exists(oldImageUrl))
            {
                System.IO.File.Delete(oldImageUrl);
            }

            _context.Product.Remove(productFromDb);
            _context.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion

    }
}
