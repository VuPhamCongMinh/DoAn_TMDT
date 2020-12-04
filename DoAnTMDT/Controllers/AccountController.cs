﻿using System.Threading.Tasks;
using DoAnTMDT.DbContext;
using DoAnTMDT.Models;
using DoAnTMDT.Sevices;
using DoAnTMDT.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static DoAnTMDT.Sevices.EmailServices;

namespace DoAnTMDT.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMailer _mailer;
        private readonly CookieServices _cookieServices;
        private readonly DoAnTMDT_Entities _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IMailer mailer, CookieServices cookieServices, DoAnTMDT_Entities context)
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
            }

            return StatusCode(69);
        }

        [Authorize]
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
            ApplicationUser identity = new ApplicationUser { UserName = vm.UserName };
            ModelState.Remove("RememberMe");
            ModelState.Remove("PasswordConfirm");
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
                    //await _signInManager.PasswordSignInAsync(new ApplicationUser { UserName = vm.UserName }, vm.Password, isPersistent: false, lockoutOnFailure: false);
                    return RedirectToAction("Index", "Home");
                }
            }

            return StatusCode(69);
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

        [Authorize]
        public IActionResult ChangeInfo()
        {
            var user = _userManager.FindByNameAsync(
                HttpContext.User.Identity.Name).Result;

            if (user != null)
            {
                return View(user);
            }
            return View("Error");
        }

        [Authorize]
        [HttpPost]
        public IActionResult ChangeInfo(string diachi, string sdt)
        {
            try
            {
                var user = _userManager.FindByNameAsync(HttpContext.User.Identity.Name).Result;

                if (!string.IsNullOrWhiteSpace(diachi) && !string.IsNullOrWhiteSpace(sdt))
                {
                    user.Address = diachi;
                    user.Phone = sdt;
                    _userManager.UpdateAsync(user);
                }

                return View(user);
            }
            catch (System.Exception)
            {
                return View("Error");
            }
        }
    }
}
