using DoAnTMDT.DbContext;
using DoAnTMDT.Sevices;
using DoAnTMDT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DoAnTMDT.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public float ProductPrice { get; set; }

        public byte SmallSizeQuantity { get; set; }

        public byte MediumSizeQuantity { get; set; }

        public byte LargeSizeQuantity { get; set; }

        public int InstockQuantity
        {
            get { return SmallSizeQuantity + MediumSizeQuantity + LargeSizeQuantity; }
        }

        public string ImagePath { get; set; }
    }

    public static class ProductClassChucNang
    {
        internal static CookieServices _cookieServices = new CookieServices();
        internal static IEnumerable<Product> SortPriceAsc(this DoAnTMDT_Entities _context)
        {
            return _context.ProductTable.OrderBy(x => x.ProductPrice).ToList();
        }

        internal static IEnumerable<Product> SortNameAsc(this DoAnTMDT_Entities _context)
        {
            return _context.ProductTable.OrderBy(x => x.ProductName).ToList();
        }
        internal static IEnumerable<Cart> DisplayCart(this DoAnTMDT_Entities _context, HttpContext httpContext, CookieServices _cookieServices)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            {
                _cookieServices.AddCookie(httpContext, "CART_INFORMATION", httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                //Muốn lấy đơn hàng theo điều kiện thì dùng exstension method Where(x => x.Property) ở đoạn code dưới
                //Code dưới hiển thị danh sách chưa đơn hàng chưa được thanh toán
                var dsdonhangchuathanhtoan = _context.CartTable.Include(x => x.CartDetails).ThenInclude(x => x.Product).Where(x => !x.IsPayed).ToList();
                return dsdonhangchuathanhtoan;
            }
        }

        internal static bool AddToCart(this DoAnTMDT_Entities _context, HttpContext httpContext, int? itemID)
        {
            if (itemID != null)
            {
                Product bienkiemtraxemcosanphamtrongdb = _context.ProductTable.Find(itemID);

                if (bienkiemtraxemcosanphamtrongdb != null)
                {
                    string cookieKey = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
                    string guidKey = Guid.NewGuid().ToString();
                    if (string.IsNullOrEmpty(cookieKey))
                    {
                        cookieKey = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                        _cookieServices.AddCookie(httpContext, "CART_INFORMATION", cookieKey);
                    }
                    var bienkiemtraxemcodonhangchuathanhtoancocungmadonhang = _context.CartDetailTable.Include(x => x.Cart).Where(x => x.CartID == x.Cart.CartID && !x.Cart.IsPayed);

                    if (bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.Count() > 0)
                    {
                        var bienkiemtraxemsanphamdodacotronggiohangchua = bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.Where(x => x.ProductID == itemID).FirstOrDefault();
                        if ( bienkiemtraxemsanphamdodacotronggiohangchua != null)
                        {
                            bienkiemtraxemsanphamdodacotronggiohangchua.Quantity++;
                        }
                        //_context.CartDetailTable.Add(new CartDetail { Product = bienkiemtraxemcosanphamtrongdb, Quantity = 1, Cart = bienkiemtraxemsanphamdodacotronggiohangchua.Cart, CartID = bienkiemtraxemsanphamdodacotronggiohangchua.CartID });
                        _context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Cart cartDetail = new Cart { CartID = guidKey, UserID = cookieKey };
                        var bienchitietgiohang = new CartDetail { Product = bienkiemtraxemcosanphamtrongdb, Quantity = 1, CartID = guidKey, Cart = cartDetail };
                        _context.CartDetailTable.Add(bienchitietgiohang);
                        _context.SaveChanges();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
