using DoAnTMDT.DbContext;
using DoAnTMDT.Models;
using DoAnTMDT.Sevices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            var dsdonhang = _context.DisplayCart(HttpContext, _cookieServices);
            return View("_TotalCartItem",dsdonhang);
        }
    }
}
