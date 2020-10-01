using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoAnTMDT.Models;
using DoAnTMDT.DbContext;
using DoAnTMDT.Sevices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using DoAnTMDT.ViewModels;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Converters;

namespace DoAnTMDT.Controllers
{
    public class HomeController : Controller
    {
        private readonly CookieServices _cookieServices;
        private readonly DoAnTMDT_Entities _context;

        public HomeController(CookieServices cookieServices, DoAnTMDT_Entities context)
        {
            _cookieServices = cookieServices;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.ProductTable.ToList());
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
        public PartialViewResult DisplayCartTotal()
        {
            ViewBag.Total = _context.DisplayCart(HttpContext, _cookieServices).Count();
            return PartialView("_TotalCartItem");
        }
        [Authorize]
        public IActionResult AddCart(int? itemID)
        {
            if (_context.AddToCart(HttpContext, itemID))
            {
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Error));
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
