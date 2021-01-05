using DoAnTMDT.DbContext;
using OpenQA.Selenium;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DoAnTMDT.AutomatedGUITests
{
    class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly DoAnTMDT_Entities _context;
        private readonly string URL = "https://localhost:44313/";

        public LoginPage(IWebDriver driver)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DoAnTMDT_Entities>();
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DoAnTMDT;Trusted_Connection=true");
            _context = new DoAnTMDT_Entities(optionsBuilder.Options);
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
                    if (LogoutButton.Displayed)
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

        public string KetQuaDangNhap(string username, string password)
        {
            var aa = _context.Users;
            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return "Tài khoản hoặc mật khẩu đang trống";
                }
                else if (_context.Users.Where(u => u.NormalizedUserName == username.Normalize()).Count() == 0 )
                {
                    return "Tài khoản không tồn tại";
                }
                else if (LogoutButton.Displayed)
                {
                    return null;
                }
                else
                {
                    return "Lỗi chưa xác định";
                }
            }
            catch (NoSuchElementException e)
            {
                return e.Message;
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