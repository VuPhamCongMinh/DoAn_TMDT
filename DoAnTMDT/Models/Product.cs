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
        internal static bool AddToCart(this DoAnTMDT_Entities _context, HttpContext httpContext, int itemID, string size, byte quantity = 1)
        {
            Product bienkiemtraxemcosanphamtrongdb = _context.ProductTable.Find(itemID);
            if (bienkiemtraxemcosanphamtrongdb != null)
            {
                string cookieKey = _cookieServices.ReadCookie(httpContext, "CART_INFORMATION");

                if (string.IsNullOrEmpty(cookieKey))
                {
                    cookieKey = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    _cookieServices.AddCookie(httpContext, "CART_INFORMATION", cookieKey);
                }
                var bienkiemtraxemcodonhangchuathanhtoancocungmadonhang = _context.CartDetailTable.Include(x => x.Cart).Where(x => x.Cart.UserID == cookieKey && x.Cart.IsDisplay);

                if (bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.Count() > 0)
                {
                    var bienkiemtraxemsanphamdodacotronggiohangchua = bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.Where(x => x.ProductID == itemID && x.Size == size).FirstOrDefault();
                    if (bienkiemtraxemsanphamdodacotronggiohangchua != null)
                    {
                        byte calculatedQuantity = 0;
                        if (size == "small")
                        {
                            if (bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity - quantity < 0)
                            {
                                if (bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity > 0)
                                {
                                    calculatedQuantity = bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity;
                                    bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity = 0;
                                }
                            }
                            else
                            {
                                bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity -= quantity;
                            }
                        }
                        else if (size == "large")
                        {
                            if (bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity - quantity < 0)
                            {
                                if (bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity > 0)
                                {
                                    calculatedQuantity = bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity;
                                    bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity = 0;
                                }
                            }
                            else
                            {
                                bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity -= quantity;
                            }
                        }
                        else
                        {
                            if (bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity - quantity < 0)
                            {
                                if (bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity > 0)
                                {
                                    calculatedQuantity = bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity;
                                    bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity = 0;
                                }
                            }
                            else
                            {
                                bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity -= quantity;
                            }
                        }


                        if (calculatedQuantity > 0)
                        {
                            bienkiemtraxemsanphamdodacotronggiohangchua.Quantity += calculatedQuantity;
                        }
                        else
                        {
                            bienkiemtraxemsanphamdodacotronggiohangchua.Quantity += quantity;
                        }
                    }
                    else
                    {
                        byte calculatedQuantity = 0;
                        bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.First().Cart.OderDate = DateTime.Now;
                        if (size == "small")
                        {
                            if (bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity - quantity < 0)
                            {
                                if (bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity > 0)
                                {
                                    calculatedQuantity = bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity;
                                    bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity = 0;
                                }
                            }
                            else
                            {
                                bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity -= quantity;
                            }
                        }
                        else if (size == "large")
                        {
                            if (bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity - quantity < 0)
                            {
                                if (bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity > 0)
                                {
                                    calculatedQuantity = bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity;
                                    bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity = 0;
                                }
                            }
                            else
                            {
                                bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity -= quantity;
                            }
                        }
                        else
                        {
                            if (bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity - quantity < 0)
                            {
                                if (bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity > 0)
                                {
                                    calculatedQuantity = bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity;
                                    bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity = 0;
                                }
                            }
                            else
                            {
                                bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity -= quantity;
                            }
                        }
                        if (calculatedQuantity > 0)
                        {
                            _context.CartDetailTable.Add(new CartDetail { Product = bienkiemtraxemcosanphamtrongdb, Quantity = calculatedQuantity, Cart = bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.First().Cart, Size = size, CartID = bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.First().CartID });
                        }
                        else
                        {
                            _context.CartDetailTable.Add(new CartDetail { Product = bienkiemtraxemcosanphamtrongdb, Quantity = quantity, Cart = bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.First().Cart, Size = size, CartID = bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.First().CartID });
                        }
                    }
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    string guidKey = Guid.NewGuid().ToString();
                    Cart cartDetail = new Cart { CartID = guidKey, UserID = cookieKey, OderDate = DateTime.Now };
                    CartDetail detail;
                    byte calculatedQuantity = 0;
                    if (size == "small")
                    {
                        if (bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity - quantity < 0)
                        {
                            if (bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity > 0)
                            {
                                calculatedQuantity = bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity;
                                bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity = 0;
                            }
                        }
                        else
                        {
                            bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity -= quantity;
                        }
                    }
                    else if (size == "large")
                    {
                        if (bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity - quantity < 0)
                        {
                            if (bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity > 0)
                            {
                                calculatedQuantity = bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity;
                                bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity = 0;
                            }
                        }
                        else
                        {
                            bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity -= quantity;
                        }
                    }
                    else
                    {
                        if (bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity - quantity < 0)
                        {
                            if (bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity > 0)
                            {
                                calculatedQuantity = bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity;
                                bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity = 0;
                            }
                        }
                        else
                        {
                            bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity -= quantity;
                        }
                    }
                    if (calculatedQuantity > 0)
                    {
                        detail = new CartDetail { Product = bienkiemtraxemcosanphamtrongdb, Quantity = calculatedQuantity, Size = size, CartID = guidKey, Cart = cartDetail };
                    }
                    else
                    {
                        detail = new CartDetail { Product = bienkiemtraxemcosanphamtrongdb, Quantity = quantity, Size = size, CartID = guidKey, Cart = cartDetail };
                    }
                    _context.CartDetailTable.Add(detail);
                    _context.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        internal static bool RemoveFromCart(this DoAnTMDT_Entities _context, HttpContext httpContext, int itemID, string size, byte quantity = 1)
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
                    var bienkiemtraxemsanphamdodacotronggiohangchua = bienkiemtraxemcodonhangchuathanhtoancocungmadonhang.Where(x => x.ProductID == itemID && x.Size == size).FirstOrDefault();
                    if (bienkiemtraxemsanphamdodacotronggiohangchua != null)
                    {
                        if (size == "small")
                        {
                            bienkiemtraxemcosanphamtrongdb.SmallSizeQuantity++;
                        }
                        else if (size == "large")
                        {
                            bienkiemtraxemcosanphamtrongdb.LargeSizeQuantity++;
                        }
                        else
                        {
                            bienkiemtraxemcosanphamtrongdb.MediumSizeQuantity++;
                        }
                        bienkiemtraxemsanphamdodacotronggiohangchua.Quantity--;

                        if (bienkiemtraxemsanphamdodacotronggiohangchua.Quantity == 0)
                        {
                            var chitietdonhangsexoa = _context.CartDetailTable.Where(x => x.ProductID == itemID && x.Size == size).FirstOrDefault();
                            if (_context.CartTable.Find(chitietdonhangsexoa.CartID) != null)
                            {
                                _context.Remove(chitietdonhangsexoa);
                            }
                        }
                        _context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
