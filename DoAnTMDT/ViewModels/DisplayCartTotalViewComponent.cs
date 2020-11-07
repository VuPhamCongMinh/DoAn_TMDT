using DoAnTMDT.DbContext;
using DoAnTMDT.Models;
using DoAnTMDT.Sevices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit.Encodings;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.X509;
using PayPal.v1.BillingAgreements;
using System.Linq;
using System.Security.Claims;

namespace DoAnTMDT.ViewModels
{
    public class DisplayCartTotalViewComponent : ViewComponent
    {
        private readonly CookieServices _cookieServices;
        private readonly DoAnTMDT_Entities _context;
        public DisplayCartTotalViewComponent(CookieServices cookieServices, DoAnTMDT_Entities context)
        {
            _cookieServices = cookieServices;
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            if (_cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") != null && HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) != null)
            {
                ViewBag.Total = _context.CartDetailTable.Where(x => x.Cart.UserID == _cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") && !x.Cart.IsPayed).Count();
                var dsdonhang = _context.DisplayCart(HttpContext, _cookieServices);
                return View("_TotalCartItem", dsdonhang);
            }
            else
            {
                _cookieServices.DeleteCookie(HttpContext, "CART_INFORMATION");
                return Content("");
            }
        }
    }
}
