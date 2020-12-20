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
        private readonly string URL = "https://localhost:44313/";

        public ShoppingPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement ProductDetailModal => _driver.FindElement(by: By.CssSelector(@"a[data-productid=""3""]"));
        private IWebElement SizeDropdown => _driver.FindElement(by: By.Id("sizeSelect"));
        private IWebElement AddToCartButton => _driver.FindElement(by: By.CssSelector("button.js-addcart-detail"));
        private IWebElement AddToCartSuccessModal => _driver.FindElement(by: By.CssSelector("div.swal2-container"));


        public void DieuHuong() => _driver.Navigate().GoToUrl(URL);
        public void MoModalChiTietSP()
        {
            Actions actionHover = new Actions(_driver);
            actionHover.MoveToElement(ProductDetailModal).Build().Perform();
            ProductDetailModal.Click();
        }
        public void ThemVaoGioHang() => AddToCartButton.Click();
        public void ChonSize()
        {
            var sizeDropdown = new SelectElement(SizeDropdown);
            sizeDropdown.SelectByValue("small");
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
