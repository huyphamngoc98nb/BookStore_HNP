using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using SellBook.DataAccess.Repository;
using SellBook.DataAccess.Repository.IRepository;
using SellBook.Models;
using SellBook.Models.Models;
using SellBook.Models.ViewModel;

namespace SellBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _context;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _context = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Company> objCompanyList = _context.Company.GetAll().ToList();
            return View(objCompanyList);
        }

        public IActionResult Upsert(Guid? id) // Update and Insert
        {
            Company companyFromDb = new Company();

            if (id == null || id.Equals(Guid.Empty))
            {
                //Create
                return View(companyFromDb);
            }
            else
            {
                //Update
                companyFromDb = _context.Company.Get(row => row.Id == id);
                return View(companyFromDb);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Company obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Id == Guid.Empty)
                {
                    _context.Company.Add(obj);
                    TempData["Success"] = "Product Successfully Created!";
                }
                else
                {
                    _context.Company.Update(obj);
                    TempData["Success"] = "Product Successfully Modified!";
                }
                _context.Save();

                return RedirectToAction("Index", "Company");
            }
            else
            {
                return View(obj);
            }
        }

        #region 
        //[HttpPost]
        //public IActionResult Create(Company obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Company.Add(obj);
        //        _context.Save();
        //        TempData["Success"] = "Company successfully added!";
        //        return RedirectToAction("Index", "Company");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        //public IActionResult Edit(Guid id)
        //{
        //    Company companyFromDb = _context.Company.Get(row => row.Id.Equals(id));
        //    if (companyFromDb != null)
        //    {
        //        return View(companyFromDb);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Edit(Company obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Company.Update(obj);
        //        _context.Save();
        //        TempData["Success"] = "Company Successfully Modified!";
        //        return RedirectToAction("Index", "Company");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        #endregion

        #region APICALL
        [HttpGet]
        public IActionResult GetAll()
        {
            var obj = _context.Company.GetAll();
            return Json(new { data = obj });
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            Company companyFromDb = _context.Company.Get(row => row.Id == id);
            if (companyFromDb == null)
            {
                return Json(new { success = false, message = "Error while delete" });
            }

            _context.Company.Remove(companyFromDb);
            _context.Save();

            return Json(new { success = true, message = "Delete Successful!" });
        }
        #endregion
    }
}
