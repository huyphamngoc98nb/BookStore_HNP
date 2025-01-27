using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SellBook.DataAccess.Repository.IRepository;
using SellBook.Models;
using SellBook.Models.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace SellBookWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _context;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> objProductList = _context.Product.GetAll(includeProperties: "Category");
            return View(objProductList);
        }
        public IActionResult Details(Guid id)
        {
            ShoppingCart cart = new()
            {
                Product = _context.Product.Get(row => row.Id == id, includeProperties: "Category"),
                Count = 1,
                ProductId = id

            };
            return View(cart);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart obj)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            obj.ApplicationUserId = userId;

            ShoppingCart cartFromDB = _context.ShoppingCart.Get(row => row.ApplicationUserId == userId && row.ProductId == obj.ProductId);

            if (cartFromDB != null)
            {
                cartFromDB.Count += obj.Count;
                _context.ShoppingCart.Update(cartFromDB);
            }
            else
            {
                _context.ShoppingCart.Add(obj);
            }

            _context.Save();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
