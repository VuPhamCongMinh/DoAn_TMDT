using DoAnTMDT.DbContext;
using DoAnTMDT.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.Models
{
    public class Cart
    {
        [Key]
        public string CartID { get; set; }
        public string UserID { get; set; }
        public bool IsPayed { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OderDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PayDate { get; set; }

        public bool IsCompleted { get; set; }
        public ICollection<CartDetail> CartDetails { get; set; }


    }
    public static class CartChucNang
    {
        internal static CookieServices _cookieServices = new CookieServices();

        internal static IEnumerable<Cart> DisplayCart(this DoAnTMDT_Entities _context, HttpContext httpContext, CookieServices _cookieServices)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                //_cookieServices.AddCookie(httpContext, "CART_INFORMATION", httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                //Muốn lấy đơn hàng theo điều kiện thì dùng exstension method Where(x => x.Property) ở đoạn code dưới
                //Code dưới hiển thị danh sách chưa đơn hàng chưa được thanh toán
                var dsdonhangchuathanhtoan = _context.CartTable.Include(x => x.CartDetails).ThenInclude(x => x.Product).Where(x => !x.IsPayed).ToList();
                return dsdonhangchuathanhtoan;
            }
            return null;
        }
        internal static IEnumerable<Cart> DisplayPayedCart(this DoAnTMDT_Entities _context, HttpContext httpContext, CookieServices _cookieServices)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                var dsdonhangdathanhtoan = _context.CartTable.Include(x => x.CartDetails).ThenInclude(x => x.Product).Where(x => x.IsPayed).ToList();
                return dsdonhangdathanhtoan;
            }
            return null;
        }

        internal static bool ConfirmOrder(this DoAnTMDT_Entities _context, HttpContext httpContext, CookieServices _cookieServices,string orderID)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                try
                {
                    _context.CartTable.Find(orderID).IsCompleted = true;
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }


    }
}
