using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Xunit;

namespace DoAnTMDT.AutomatedGUITests
{
    public class AutomatedGUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;
        private readonly ShoppingPage _shoppingPage;

        public AutomatedGUITests()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            _loginPage = new LoginPage(_driver);
            _shoppingPage = new ShoppingPage(_driver);
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void LoginTest()
        {
            //Trường hợp cố tình nhập sai
            //_driver.Navigate().GoToUrl("https://localhost:44313/Account/Login");

            //_driver.FindElement(by: By.Id("UserName")).SendKeys("minhdeptrai");
            //_driver.FindElement(by: By.Id("Password")).SendKeys("1234567");
            //_driver.FindElement(by: By.CssSelector(".btn.btn-primary")).Click();

            //string layvanbancuacainut = _driver.FindElement(by: By.CssSelector("a.hvr-buzz-out.btn.btn-light:nth-child(2)")).Text;
            //Assert.Equal("Đăng xuất", layvanbancuacainut);

            //Implement lại nhưng theo Page Object Model Design Pattern
            _loginPage.DieuHuong();
            _loginPage.MoFormDangKyDangNhap();
            _loginPage.NhapThongTinVaoUsernameTextBox("minhdeptrai");
            _loginPage.NhapThongTinVaoPasswordTextBox("123456");
            _loginPage.ClickVaoNutDangNhap();
            Thread.Sleep(1000); //Đợi 1s để đợi chức năng đăng nhập xử lý xong
            Assert.True(_loginPage.HienThiManHinhDangNhapThanhCong);
        }

        [Fact]
        public void LogoutTest()
        {
            LoginTest();
            _loginPage.ClickVaoNutDangXuat();
            Assert.True(_loginPage.HienThiManHinhDangXuatThanhCong);
        }


        [Fact]
        public void AddToCartTest()
        {
            LoginTest();
            _shoppingPage.DieuHuong();
            _shoppingPage.MoModalChiTietSP();
            _shoppingPage.ChonSize();
            _shoppingPage.ThemVaoGioHang();
            Assert.True(_shoppingPage.HienThiManHinhThemGioHangThanhCong);
        }
    }
}
