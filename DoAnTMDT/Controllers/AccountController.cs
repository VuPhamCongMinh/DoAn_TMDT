using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Web;
using DoAnTMDT.DbContext;
using DoAnTMDT.Models;
using DoAnTMDT.Sevices;
using DoAnTMDT.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using static DoAnTMDT.Sevices.EmailServices;

namespace DoAnTMDT.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMailer _mailer;
        private readonly CookieServices _cookieServices;
        private readonly DoAnTMDT_Entities _context;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IMailer mailer, CookieServices cookieServices, DoAnTMDT_Entities context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mailer = mailer;
            _cookieServices = cookieServices;
            _context = context;
        }
        public IActionResult Login()
        {
            return PartialView("_ShowLoginForm");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRegisterViewModel vm)
        {
            ModelState.Remove("PasswordConfirm");
            if (ModelState.IsValid)
            {
                var biendekiemtracotrongcsdlhaykhong = await _signInManager.PasswordSignInAsync(vm.UserName, vm.Password, vm.RememberMe, lockoutOnFailure: false);
                if (biendekiemtracotrongcsdlhaykhong.Succeeded)
                {
                    if (_cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") != _userManager.FindByNameAsync(vm.UserName).Result.Id || _cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") == null)
                    {
                        if (vm.RememberMe)
                        {
                            _cookieServices.AddCookie(HttpContext, "CART_INFORMATION", _userManager.FindByNameAsync(vm.UserName).Result.Id, isPersistent: true);
                        }
                        else
                        {
                            _cookieServices.AddCookie(HttpContext, "CART_INFORMATION", _userManager.FindByNameAsync(vm.UserName).Result.Id);
                        }
                    }
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Bạn hãy kiểm tra lại mật khẩu hoặc tên tài khoản hoặc chắc rằng mình đã xác nhận email");
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            _cookieServices.DeleteCookie(HttpContext, "CART_INFORMATION");
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginRegisterViewModel vm)
        {
            IdentityUser identity = new IdentityUser { UserName = vm.UserName };
            ModelState.Remove("RememberMe");
            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(identity, vm.Password);
                if (result.Succeeded)
                {
                    //Generate link xác nhận
                    var tokenString = await _userManager.GenerateEmailConfirmationTokenAsync(identity);
                    string confirmationLink = Url.Action("ConfirmEmail", "Account", new { username = identity, token = tokenString },
                    protocol: HttpContext.Request.Scheme);
                    //Gửi mail xác nhận cho user
                    await _mailer.SendEmailAsync("vggff619@gmail.com", "Test thử lần n", confirmationLink);
                    //Code dưới sẽ đăng nhập liền sau khi user vừa đăng ký xong
                    //await _signInManager.PasswordSignInAsync(new IdentityUser { UserName = vm.UserName }, vm.Password, isPersistent: false, lockoutOnFailure: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(vm);
        }

        public async Task<IActionResult> ConfirmEmail(string username, string token)
        {
            var user = await _userManager.FindByNameAsync(username);

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                ViewBag.Message = "Email confirmed successfully!";
                return View("Success");
            }
            else
            {
                ViewBag.Message = "Error while confirming your email!";
                return View("Error");
            }
        }


    }
}
