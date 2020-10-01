using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnTMDT.AutomatedGUITests
{
    class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly string URL = "https://localhost:44313/Account/Login";

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement UsernameTextbox => _driver.FindElement(by: By.Id("UserName"));
        private IWebElement PasswordTextbox => _driver.FindElement(by: By.Id("Password"));
        private IWebElement LoginButton => _driver.FindElement(by: By.CssSelector(".btn.btn-primary"));
        public bool IsDangNhapThanhCong
        {
            get
            {
                try
                {
                    return !_driver.FindElement(By.CssSelector(".text-danger.validation-summary-errors")).Displayed;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }

            }
        }



        public void DieuHuong() => _driver.Navigate().GoToUrl(URL);
        public void NhapThongTinVaoUsernameTextBox(string VanBanDeNhapVao) => UsernameTextbox.SendKeys(VanBanDeNhapVao);
        public void NhapThongTinVaoPasswordTextBox(string VanBanDeNhapVao) => PasswordTextbox.SendKeys(VanBanDeNhapVao);
        public void ClickVaoNutDangNhap() => LoginButton.Click();
    }
}
