using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SellBook.DataAccess.Repository.IRepository;
using SellBook.Models.Models;
using SellBook.Models.ViewModel;
using SellBook.Utility;
using System.Security.Claims;

namespace SellBookWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _context;
        [BindProperty]
        public ShoppingCartVM ShoppingCartVM { get; set; }

        public CartController(IUnitOfWork context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            ShoppingCartVM = new()
            {
                ListCart = _context.ShoppingCart.GetAll(row => row.ApplicationUserId == userId, includeProperties: "Product"),
                OrderHeader = new()
            };

            foreach (var item in ShoppingCartVM.ListCart)
            {
                item.Price = GetPriceBaseOnQuantity(item);
                ShoppingCartVM.OrderHeader.OrderTotal += (item.Price * item.Count);
            }
            return View(ShoppingCartVM);
        }

        public IActionResult Summary()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            ShoppingCartVM = new()
            {
                ListCart = _context.ShoppingCart.GetAll(row => row.ApplicationUserId == userId, includeProperties: "Product"),
                OrderHeader = new()
            };

            ShoppingCartVM.OrderHeader.ApplicationUser = _context.ApplicationUser.Get(row => row.Id == userId);

            ShoppingCartVM.OrderHeader.Name = ShoppingCartVM.OrderHeader.ApplicationUser.Name;
            ShoppingCartVM.OrderHeader.PhoneNumber = ShoppingCartVM.OrderHeader.ApplicationUser.PhoneNumber;
            ShoppingCartVM.OrderHeader.StreetAddress = ShoppingCartVM.OrderHeader.ApplicationUser.StreetAddress;
            ShoppingCartVM.OrderHeader.City = ShoppingCartVM.OrderHeader.ApplicationUser.City;
            ShoppingCartVM.OrderHeader.State = ShoppingCartVM.OrderHeader.ApplicationUser.State;
            ShoppingCartVM.OrderHeader.PostalCode = ShoppingCartVM.OrderHeader.ApplicationUser.PostalCode;

            foreach (var item in ShoppingCartVM.ListCart)
            {
                item.Price = GetPriceBaseOnQuantity(item);
                ShoppingCartVM.OrderHeader.OrderTotal += (item.Price * item.Count);
            }
            return View(ShoppingCartVM);
        }
        [HttpPost]
        [ActionName("Summary")]
        public IActionResult SummaryPOST()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            ShoppingCartVM.ListCart = _context.ShoppingCart.GetAll(row => row.ApplicationUserId == userId, includeProperties: "Product");
            
            ShoppingCartVM.OrderHeader.OrderDate = DateTime.Now;
            ShoppingCartVM.OrderHeader.ApplicationUserId = userId;

            ApplicationUser applicationUser = _context.ApplicationUser.Get(row => row.Id == userId);

            foreach (var item in ShoppingCartVM.ListCart)
            {
                item.Price = GetPriceBaseOnQuantity(item);
                ShoppingCartVM.OrderHeader.OrderTotal += (item.Price * item.Count);
            }

            if (applicationUser.CompanyId.GetValueOrDefault() == Guid.Empty)
            {
                // Not a company user
                ShoppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusPending;
                ShoppingCartVM.OrderHeader.OrderStatus = SD.StatusPending;
            }
            else
            {
                //Company User
                ShoppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusDelayPayment;
                ShoppingCartVM.OrderHeader.OrderStatus = SD.StatusApproved;
            }

            _context.OrderHeader.Add(ShoppingCartVM.OrderHeader);
            _context.Save();

            foreach (var cart in ShoppingCartVM.ListCart)
            {
                OrderDetail orderDetail = new()
                {
                    ProductId = cart.ProductId,
                    OrderHeaderId = ShoppingCartVM.OrderHeader.Id,
                    Price = cart.Price,
                    Count = cart.Count,
                };

                _context.OrderDetail.Add(orderDetail);
                _context.Save();
            }

            if (applicationUser.CompanyId.GetValueOrDefault() == Guid.Empty)
            {
                // Stripe setup
            }
            return RedirectToAction(nameof(OrderConfirmation), new { id = ShoppingCartVM.OrderHeader.Id });
        }

        public IActionResult OrderConfirmation(Guid id)
        {
            return View(id);
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
