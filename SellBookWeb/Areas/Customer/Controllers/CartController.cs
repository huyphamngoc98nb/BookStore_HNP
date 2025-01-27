using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SellBook.DataAccess.Repository.IRepository;
using SellBook.Models.Models;
using SellBook.Models.ViewModel;
using System.Security.Claims;

namespace SellBookWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _context;
        public ShoppingCartVM ShoppingCartVM { get; set; }
        public CartController(IUnitOfWork context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            ShoppingCartVM shoppingCartVM = new()
            {
                ListCart = _context.ShoppingCart.GetAll(row => row.ApplicationUserId == userId, includeProperties: "Product")
            };

            foreach (var item in shoppingCartVM.ListCart)
            {
                item.Price = GetPriceBaseOnQuantity(item);
                shoppingCartVM.OrderTotal += (item.Price * item.Count);
            }
            return View(shoppingCartVM);
        }


        public IActionResult Plus(Guid cartId)
        {
            var cartFromDb = _context.ShoppingCart.Get(row => row.Id == cartId);
            cartFromDb.Count += 1;
            _context.ShoppingCart.Update(cartFromDb);
            _context.Save();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Minus(Guid cartId)
        {
            var cartFromDb = _context.ShoppingCart.Get(row => row.Id == cartId);
            if (cartFromDb.Count <= 1)
            {
                _context.ShoppingCart.Remove(cartFromDb);
            }
            else
            {
                cartFromDb.Count -= 1;
                _context.ShoppingCart.Update(cartFromDb);      
            }
            _context.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(Guid cartId)
        {
            var cartFromDb = _context.ShoppingCart.Get(row => row.Id == cartId);
            _context.ShoppingCart.Remove(cartFromDb);
            _context.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Summary()
        {
            return View();
        }
        private double GetPriceBaseOnQuantity(ShoppingCart obj)
        {
            if (obj.Count <= 50)
            {
                return obj.Product.Price;
            }
            else
            {
                if (obj.Count <= 100)
                {
                    {
                        return obj.Product.Price50;
                    }
                }
                else
                {
                    return obj.Product.Price100;
                }
            }
        }
    }
}
