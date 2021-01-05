using DoAnTMDT.DbContext;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnTMDT.AutomatedGUITests
{
    class ShoppingPage
    {
        private readonly IWebDriver _driver;
        private readonly DoAnTMDT_Entities _context;
        private readonly string URL = "https://localhost:44313/";

        public ShoppingPage(IWebDriver driver)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DoAnTMDT_Entities>();
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DoAnTMDT;Trusted_Connection=true");
            _context = new DoAnTMDT_Entities(optionsBuilder.Options);
            _driver = driver;
        }

        private IWebElement ProductDetailModal(int productID) => _driver.FindElement(by: By.CssSelector($@"a[data-productid=""{productID}""]"));
        private IWebElement SizeDropdown => _driver.FindElement(by: By.Id("sizeSelect"));
        private IWebElement AddToCartButton => _driver.FindElement(by: By.CssSelector("button.js-addcart-detail"));
        private IWebElement AddToCartSuccessModal => _driver.FindElement(by: By.CssSelector("div.swal2-container"));


        public void DieuHuong() => _driver.Navigate().GoToUrl(URL);
        public string KetQuaThemGioHang(int productID, int size)
        {
                var productInDB = _context.ProductTable.Find(productID);
                if (productInDB == null)
                {
                    return "Sản phẩm này không tồn tại";
                }
                else
                {
                    try
                    {
                        if (size == 1 && productInDB.SmallSizeQuantity <= 0)
                        {
                            return "Sản phẩm này đã hết hàng";
                        }
                        else if (size == 2 && productInDB.MediumSizeQuantity <= 0)
                        {
                            return "Sản phẩm này đã hết hàng";
                        }
                        else if (size == 3 && productInDB.LargeSizeQuantity <= 0)
                        {
                            return "Sản phẩm này đã hết hàng";
                        }
                        else
                        {
                            Actions actionHover = new Actions(_driver);
                            actionHover.MoveToElement(ProductDetailModal(productID)).Build().Perform();
                            ProductDetailModal(productID).Click();
                            ChonSize(size);
                            ThemVaoGioHang();
                            if (HienThiManHinhThemGioHangThanhCong)
                            {
                                return null;
                            }
                            else
                            {
                                return "Lỗi ko thể xác định";
                                //Lỗi ko thể xác định
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
            }
        }
        public void ThemVaoGioHang() => AddToCartButton.Click();
        public void ChonSize(int size)
        {
            var sizeDropdown = new SelectElement(SizeDropdown);
            if (size == 1)
            {
                sizeDropdown.SelectByValue("small");
            }
            else if (size == 2)
            {
                sizeDropdown.SelectByValue("medium");
            }
            else if (size == 3)
            {
                sizeDropdown.SelectByValue("large");
            }

        }
        public bool HienThiManHinhThemGioHangThanhCong
        {
            get
            {
                try
                {
                    if (AddToCartSuccessModal.Displayed)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }

            }
        }
    }
}
