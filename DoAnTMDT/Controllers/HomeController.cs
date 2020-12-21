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
using System;
using DoAnTMDT.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace DoAnTMDT.Controllers
{
    public class HomeController : Controller
    {
        private readonly CookieServices _cookieServices;
        private readonly DoAnTMDT_Entities _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string _clientID;
        private readonly string _secretID;


        public HomeController(CookieServices cookieServices, DoAnTMDT_Entities context, IConfiguration config, UserManager<ApplicationUser> userManager)
        {
            _cookieServices = cookieServices;
            _userManager = userManager;
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
        [Authorize]
        public JsonResult GetAddressInfo(int addressValue)
        {
            string userID = _cookieServices.ReadCookie(HttpContext, "CART_INFORMATION");
            var returnItem = _context.DeliveryInfoTable.Single(x => x.User.Id == userID && x.AddressValue == addressValue);
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

        public IActionResult About()
        {

            return View();
        }

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

        #region Thanh toán COD
        [Authorize]
        [HttpPost]
        public IActionResult CodCheckout(string id, bool? usePoint = false)
        {
            try
            {
                var giohangthanhtoanthanhcong = _context.CartTable.Find(id).IsCOD = true;
                _context.SaveChanges();

                var totalPrice = _context.CartDetailTable.Where(x => x.CartID == id).Include(x => x.Product).Sum(x => x.Product.ProductPrice * x.Quantity);
                var user = _userManager.Users.Include(x => x.DeliveryInfo).SingleAsync(x => x.Id == _cookieServices.ReadCookie(HttpContext, "CART_INFORMATION")).Result;
                var pointLeft = user.Point;


                if (usePoint == true && user.Point > 0)
                {
                    if (user.Point <= totalPrice)
                    {
                        pointLeft = 0;
                    }
                    else
                    {
                        pointLeft = (user.Point - Convert.ToInt32(totalPrice));
                    }
                }
                return Redirect(Url.Action(nameof(CheckoutSuccess), "Home", new { id = id, userid = user.Id, pointLeft = pointLeft }, protocol: Request.Scheme));
            }
            catch (HttpException e)
            {
                return RedirectToAction(nameof(CheckoutFail));
            }
        }
        #endregion

        #region Thanh toán Paypal
        [Authorize]
        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> CheckoutAsync(string id, int? addressValue, bool? usePoint = false)
        {
            var environment = new SandboxEnvironment(_clientID, _secretID);
            var client = new PayPalHttpClient(environment);

            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            //Query tính tổng giá của đơn hàng bằng cách lặp rồi tính sum của giá * số lượng
            //Nếu cart được tìm thuộc giỏ hàng đang hiển thị thì mới gọi paypal tránh hiện tượng user nhập lại id cũ đã thanh toán nhưng vẫn gọi api paypal
            if (_context.CartTable.Find(id).IsDisplay == true)
            {

                var totalPrice = _context.CartDetailTable.Where(x => x.CartID == id).Include(x => x.Product).Sum(x => x.Product.ProductPrice * x.Quantity);
                var cartItem = _context.CartDetailTable.Where(x => x.CartID == id).Include(x => x.Product);
                //Free ship 15$
                var saleOff = 15;
                var user = await _userManager.Users.Include(x => x.DeliveryInfo).SingleAsync(x => x.Id == _cookieServices.ReadCookie(HttpContext, "CART_INFORMATION"));
                var pointLeft = user.Point;
                var orderAmount = new Amount()
                {
                    Total = (totalPrice - saleOff).ToString(),
                    Currency = "USD",
                    Details = new AmountDetails
                    {
                        Tax = "0",
                        Shipping = "0",
                        ShippingDiscount = saleOff.ToString(),
                        Subtotal = totalPrice.ToString()
                    }
                };
                if (usePoint == true && user.Point > 0)
                {
                    if (user.Point <= totalPrice)
                    {
                        Item point = new Item { Name = "Xu", Currency = "USD", Price = (-user.Point).ToString(), Quantity = "1", Description = $"Sử dụng {user.Point} xu " };
                        itemList.Items.Add(point);
                        orderAmount.Details.Subtotal = (Convert.ToInt32(orderAmount.Details.Subtotal) - user.Point).ToString();
                        orderAmount.Total = (Convert.ToInt32(orderAmount.Total) - user.Point).ToString();
                        pointLeft = 0;
                    }
                    else
                    {
                        Item point = new Item { Name = "Xu", Currency = "USD", Price = (-user.Point).ToString(), Quantity = user.Point.ToString(), Description = $"Sử dụng {totalPrice} xu để giảm giá" };
                        itemList.Items.Add(point);
                        orderAmount.Details.ShippingDiscount = "0";
                        orderAmount.Details.Subtotal = (Convert.ToInt32(orderAmount.Details.Subtotal) - user.Point).ToString();
                        orderAmount.Total = (Convert.ToInt32(orderAmount.Total) - user.Point).ToString();
                        pointLeft = (user.Point - Convert.ToInt32(totalPrice));
                    }
                }

                foreach (var item in cartItem)
                {
                    itemList.Items.Add(new Item()
                    {
                        Name = item.Product.ProductName,
                        Currency = "USD",
                        Price = (item.Product.ProductPrice).ToString(),
                        Quantity = item.Quantity.ToString()
                    });
                }

                if (addressValue >= 1 && addressValue <= 2)
                {
                    itemList.ShippingAddress = new ShippingAddress { City = user.DeliveryInfo.Single(x => x.AddressValue == addressValue).Address, Phone = user.DeliveryInfo.Single(x => x.AddressValue == addressValue).Phone, CountryCode = "VN", Line1 = "Q.10", Line2 = "Sư Vạn Hạnh", State = user.DeliveryInfo.Single(x => x.AddressValue == addressValue).Address, RecipientName = user.UserName, PostalCode = "70000" };
                    itemList.ShippingPhoneNumber = user.DeliveryInfo.Single(x => x.AddressValue == addressValue).Phone;
                }

                var payment = new Payment()
                {
                    Intent = "sale",
                    Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = orderAmount,
                        ItemList = itemList,
                        Description = "Hóa đơn 696",
                        InvoiceNumber = id
                    }
                },
                    RedirectUrls = new RedirectUrls()
                    {
                        CancelUrl = Url.Action(nameof(CheckoutFail), "Home", null, protocol: Request.Scheme),
                        ReturnUrl = Url.Action(nameof(CheckoutSuccess), "Home", new { id = id, userid = user.Id, pointLeft = pointLeft }, protocol: Request.Scheme),
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
            else
            {
                return RedirectToAction(nameof(CheckoutFail));
            }
        }
        #endregion
        public IActionResult CheckoutSuccess(string id, string userid, int pointLeft)
        {
            try
            {
                var giohangthanhtoanthanhcong = _context.CartTable.Find(id);

                giohangthanhtoanthanhcong.IsDisplay = false;
                if (!giohangthanhtoanthanhcong.IsCOD)
                {
                    giohangthanhtoanthanhcong.IsPayed = true;
                    giohangthanhtoanthanhcong.PayDate = DateTime.Now;
                }
                var user = _userManager.FindByIdAsync(userid).Result;
                user.Point = pointLeft;
                //_userManager.UpdateAsync(user);
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
            var giohang = _context.DisplayCartAndUserInfo(HttpContext, _userManager, _cookieServices);
            return View(giohang);
        }
        public IActionResult TrackCart()
        {
            TrackCartViewModel donhang = new TrackCartViewModel(_context.DisplayCompletedCart(HttpContext, _cookieServices), _context.DisplayCart(HttpContext, _cookieServices));
            return View(donhang);
        }

        [HttpPost]
        public IActionResult ConfirmCompleted(string id)
        {
            if (_context.ConfirmOrder(_userManager, HttpContext, _cookieServices, id))
            {
                return Ok();
            }
            return BadRequest();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
