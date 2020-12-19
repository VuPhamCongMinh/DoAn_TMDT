using DoAnTMDT.DbContext;
using DoAnTMDT.Sevices;
using DoAnTMDT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        [ForeignKey("User")]
        public string UserID { get; set; }
        public bool IsPayed { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OderDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PayDate { get; set; }

        public bool IsCompleted { get; set; }
        public bool IsCOD { get; set; }
        public bool IsDisplay { get; set; } = true;
        public ICollection<CartDetail> CartDetails { get; set; }


    }
    public static class CartChucNang
    {
        internal static CookieServices _cookieServices = new CookieServices();

        internal static IEnumerable<Cart> DisplayPopupCart(this DoAnTMDT_Entities _context, HttpContext httpContext, CookieServices _cookieServices)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                //_cookieServices.AddCookie(httpContext, "CART_INFORMATION", httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                //Muốn lấy đơn hàng theo điều kiện thì dùng exstension method Where(x => x.Property) ở đoạn code dưới
                //Code dưới hiển thị danh sách chưa đơn hàng chưa được thanh toán
                var dsdonhangduochienthi = _context.CartTable.Include(x => x.CartDetails).ThenInclude(x => x.Product).Where(x => x.UserID == cookie && x.IsDisplay).ToList();
                return dsdonhangduochienthi;
            }
            return null;
        }

        internal static CartAndUserViewModel DisplayCartAndUserInfo(this DoAnTMDT_Entities _context, HttpContext httpContext, UserManager<ApplicationUser> _userManager, CookieServices _cookieServices)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                //_cookieServices.AddCookie(httpContext, "CART_INFORMATION", httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                //Muốn lấy đơn hàng theo điều kiện thì dùng exstension method Where(x => x.Property) ở đoạn code dưới
                //Code dưới hiển thị danh sách chưa đơn hàng chưa được thanh toán
                var dsdonhangduochienthi = _context.CartTable.Include(x => x.CartDetails).ThenInclude(x => x.Product).Where(x => x.UserID == cookie && x.IsDisplay).ToList();
                return new CartAndUserViewModel(dsdonhangduochienthi, _userManager.FindByNameAsync(httpContext.User.Identity.Name).Result);
            }
            return null;
        }

        internal static IEnumerable<Cart> DisplayCart(this DoAnTMDT_Entities _context, HttpContext httpContext, CookieServices _cookieServices)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                //_cookieServices.AddCookie(httpContext, "CART_INFORMATION", httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                //Muốn lấy đơn hàng theo điều kiện thì dùng exstension method Where(x => x.Property) ở đoạn code dưới
                //Code dưới hiển thị danh sách chưa đơn hàng chưa được thanh toán
                var dsdonhangchuathanhtoan = _context.CartTable.Include(x => x.CartDetails).ThenInclude(x => x.Product).Where(x => x.UserID == cookie && !x.IsCompleted && !x.IsDisplay).ToList();
                return dsdonhangchuathanhtoan;
            }
            return null;
        }
        internal static IEnumerable<Cart> DisplayCompletedCart(this DoAnTMDT_Entities _context, HttpContext httpContext, CookieServices _cookieServices)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                var dsdonhangdathanhtoan = _context.CartTable.Include(x => x.CartDetails).ThenInclude(x => x.Product).Where(x => x.IsCompleted && !x.IsDisplay).ToList();
                return dsdonhangdathanhtoan;
            }
            return null;
        }

        internal static bool ConfirmOrder(this DoAnTMDT_Entities _context, UserManager<ApplicationUser> _userManager, HttpContext httpContext, CookieServices _cookieServices, string orderID)
        {
            string cookie = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");
            if (cookie != null)
            {
                try
                {
                    var cartInDB = _context.CartTable.Find(orderID);
                    double pointConverted;
                    if (cartInDB.IsCOD)
                    {
                        cartInDB.IsPayed = true;
                        cartInDB.PayDate = DateTime.Now;
                        pointConverted = _context.CartDetailTable.Where(x => x.CartID == orderID).Include(x => x.Product).Sum(x => x.Product.ProductPrice * x.Quantity) / 20;
                    }
                    cartInDB.IsCompleted = true;
                    //Tính điểm xu, nếu thanh toán = Paypal thì dc giảm 20% => tổng giá nhân cho (1*0.2)
                    //Xu được tính theo tỉ lệ tổng giá chia 20, khi sử dụng 1 xu tương đương 1$
                    pointConverted = (_context.CartDetailTable.Where(x => x.CartID == orderID).Include(x => x.Product).Sum(x => x.Product.ProductPrice * x.Quantity) * (1 - 0.2) / 20);
                    var user = _userManager.FindByNameAsync(httpContext.User.Identity.Name).Result;
                    user.Point += Convert.ToInt32(pointConverted);
                    _userManager.UpdateAsync(user);

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
