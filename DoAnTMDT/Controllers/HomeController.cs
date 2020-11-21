using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DoAnTMDT.Models;
using DoAnTMDT.DbContext;
using DoAnTMDT.Sevices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using PayPal.Core;
using PayPal.v1.Payments;
using Microsoft.EntityFrameworkCore;
using BraintreeHttp;

namespace DoAnTMDT.Controllers
{
    public class HomeController : Controller
    {
        private readonly CookieServices _cookieServices;
        private readonly DoAnTMDT_Entities _context;
        private readonly string _clientID;
        private readonly string _secretID;


        public HomeController(CookieServices cookieServices, DoAnTMDT_Entities context, IConfiguration config)
        {
            _cookieServices = cookieServices;
            _context = context;
            _clientID = config["paypal:clientId"];
            _secretID = config["paypal:clientSecret"];
        }
        public IActionResult ReloadCountTotal()
        {
            return ViewComponent("CountCartTotal");
        }
        public IActionResult ReloadDisplayCartTotal()
        {
            return ViewComponent("DisplayCartTotal");
        }
        #region Các chức năng hiển thị = partial view, view components
        public JsonResult ItemToJson(string s)
        {
            var list = _context.ProductTable.Where(x => x.ProductName.StartsWith(s)).ToList();
            return Json(list);
        }

        public IActionResult SingleItemToToModal(int id)
        {
            var returnItem = _context.ProductTable.Find(id);
            return PartialView("_ShowModal", returnItem);
        }

        public IActionResult SingleItemToJson(int id)
        {
            var returnItem = _context.ProductTable.Find(id);
            return Json(returnItem);
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
        #region Chức năng Sort,Hiển thị danh sách SP, Trang giỏ hàng
        public IActionResult DisplayProduct(int id = 1)
        {
            return ViewComponent("DisplayProducts", new { currentPage = id });
        }

        public PartialViewResult SortPriceAsc()
        {
            return PartialView("ProductView/_ShowProduct", _context.SortPriceAsc());
        }
        public PartialViewResult SortNameAsc()
        {
            return PartialView("ProductView/_ShowProduct", _context.SortNameAsc());
        }
        [Authorize]
        public PartialViewResult DisplayCart()
        {
            var dsdonhangchuathanhtoan = _context.DisplayCart(HttpContext, _cookieServices);
            return PartialView("ProductView/_ShowCart", dsdonhangchuathanhtoan);
        }
        #endregion

        [Authorize]
        public IActionResult AddCart(int itemID, string size, byte quantity)
        {
            if (_context.AddToCart(HttpContext, itemID, size, quantity))
            {
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Error));
        }

        [Authorize]
        public IActionResult RemoveCart(int itemID, string size, byte quantity = 1)
        {
            if (_context.RemoveFromCart(HttpContext, itemID, size, quantity))
            {
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Error));
        }

        public async System.Threading.Tasks.Task<IActionResult> CheckoutAsync(string id)
        {
            var environment = new SandboxEnvironment(_clientID, _secretID);
            var client = new PayPalHttpClient(environment);

            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            //Query tính tổng giá của đơn hàng bằng cách lặp rồi tính sum của giá * số lượng
            var totalPrice = _context.CartDetailTable.Where(x => x.CartID == id).Include(x => x.Product).Sum(x => x.Product.ProductPrice * x.Quantity);
            var cartItem = _context.CartDetailTable.Where(x => x.CartID == id).Include(x => x.Product);

            foreach (var item in cartItem)
            {
                itemList.Items.Add(new Item()
                {
                    Name = item.Product.ProductName,
                    Currency = "USD",
                    Price = item.Product.ProductPrice.ToString(),
                    Quantity = item.Quantity.ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
            }

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = totalPrice.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = totalPrice.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = "Hóa đơn 696",
                        InvoiceNumber = "696969"
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = Url.Action(nameof(CheckoutFail), "Home", null, protocol: Request.Scheme),
                    ReturnUrl = Url.Action(nameof(CheckoutSuccess), "Home", new { id = id }, protocol: Request.Scheme),
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                var response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                //Process when Checkout with Paypal fails
                return RedirectToAction(nameof(CheckoutFail));
            }
        }

        public IActionResult CheckoutSuccess(string id)
        {
            try
            {
                _context.CartTable.Find(id).IsPayed = true;
                _context.SaveChanges();
                TempData["CheckoutSuccess"] = true;
            }
            catch (System.Exception)
            {

                throw;
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult CheckoutFail()
        {
            return View("Error");
        }

        public IActionResult Cart()
        {
            var giohang = _context.DisplayCart(HttpContext, _cookieServices);
            return View(giohang);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
