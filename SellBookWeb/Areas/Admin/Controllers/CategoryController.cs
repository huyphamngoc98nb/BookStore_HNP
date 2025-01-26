using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SellBook.DataAccess.Data;
using SellBook.DataAccess.Repository.IRepository;
using SellBook.Models;
using SellBook.Utility;

namespace SellBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_User_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _context;

        public CategoryController(IUnitOfWork context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _context.Category.GetAll().OrderBy(row => row.DisplayOrder).ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {

            if (ModelState.IsValid)
            {
                _context.Category.Add(obj);
                _context.Save();
                TempData["Success"] = "Category Successfully Created!";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        public IActionResult Edit(Guid? id)
        {
            Category categoryFromDb = _context.Category.Get(row => row.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _context.Category.Update(obj);
                _context.Save();
                TempData["Success"] = "Category Successfully Modified!";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(Guid id)
        {
            Category categoryFromDb = _context.Category.Get(row => row.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Category.Remove(categoryFromDb);
                _context.Save();
                TempData["Success"] = "Category Successfully Deleted!";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
