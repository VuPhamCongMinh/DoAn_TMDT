using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnTMDT.AutomatedGUITests
{
    class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly string URL = "https://localhost:44313/";

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement LoginRegisterModal => _driver.FindElement(by: By.Id("loginBtn"));
        private IWebElement UsernameTextbox => _driver.FindElement(by: By.CssSelector(@"#loginForm input[name=""UserName""]"));
        private IWebElement PasswordTextbox => _driver.FindElement(by: By.CssSelector(@"#loginForm input[name=""Password""]"));
        private IWebElement LoginButton => _driver.FindElement(by: By.CssSelector("#loginForm button.normal-button"));
        private IWebElement LogoutButton => _driver.FindElement(by: By.CssSelector(".right-top-bar > #logoutForm"));
        public bool HienThiManHinhDangXuatThanhCong
        {
            get
            {
                try
                {
                    if (!LogoutButton.Displayed)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }

            }
        }

        public bool HienThiManHinhDangNhapThanhCong
        {
            get
            {
                try
                {
                    if (LogoutButton.Displayed)
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


        public void MoFormDangKyDangNhap() => LoginRegisterModal.Click();
        public void DieuHuong() => _driver.Navigate().GoToUrl(URL);
        public void NhapThongTinVaoUsernameTextBox(string VanBanDeNhapVao) => UsernameTextbox.SendKeys(VanBanDeNhapVao);
        public void NhapThongTinVaoPasswordTextBox(string VanBanDeNhapVao) => PasswordTextbox.SendKeys(VanBanDeNhapVao);
        public void ClickVaoNutDangNhap() => LoginButton.Click();
        public void ClickVaoNutDangXuat()
        {
            if (LogoutButton.Displayed)
            {
                LogoutButton.Click();
            }
        }
    }
}