using System.Security.Claims;
using System.Threading.Tasks;
using DoAnTMDT.DbContext;
using DoAnTMDT.Models;
using DoAnTMDT.Sevices;
using DoAnTMDT.ViewModels;
using Microsoft.AspNetCore.Authentication.Google;
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
            ApplicationUser identity = new ApplicationUser { UserName = vm.UserName, Email = vm.UserName };
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
                    await _mailer.SendEmailAsync(vm.UserName, "Test thử lần n", confirmationLink);
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
                try
                {
                    await _signInManager.SignInAsync(user, false);

                    if (_cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") != _userManager.FindByNameAsync(user.UserName).Result.Id || _cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") == null)
                    {
                        _cookieServices.AddCookie(HttpContext, "CART_INFORMATION", _userManager.FindByNameAsync(user.UserName).Result.Id);
                    }
                    return RedirectToAction("Index", "Home");
                }
                catch (System.Exception)
                {
                    return View("Error");
                }
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
        public async Task<IActionResult> ChangeInfo(string diachi, string sdt)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

                if (!string.IsNullOrWhiteSpace(diachi) && !string.IsNullOrWhiteSpace(sdt))
                {
                    user.Address = diachi;
                    user.Phone = sdt;
                    await _userManager.UpdateAsync(user);
                }

                return View(user);
            }
            catch (System.Exception)
            {
                return View("Error");
            }
        }

        public IActionResult GoogleLogin()
        {

            var redirectUrl = Url.Action("GoogleResponse", "Account");
            var properties = _signInManager
                .ConfigureExternalAuthenticationProperties(GoogleDefaults.AuthenticationScheme, redirectUrl);
            return new ChallengeResult(GoogleDefaults.AuthenticationScheme, properties);
        }

        public async Task<IActionResult> GoogleResponse()
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider,
         info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (signInResult.Succeeded)
            {
                if (_cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") != _userManager.FindByEmailAsync(info.Principal.FindFirstValue(ClaimTypes.Email)).Result.Id || _cookieServices.ReadCookie(HttpContext, "CART_INFORMATION") == null)
                {
                    _cookieServices.AddCookie(HttpContext, "CART_INFORMATION", _userManager.FindByEmailAsync(info.Principal.FindFirstValue(ClaimTypes.Email)).Result.Id);
                }
            }
            else
            {
                // Get the email claim value
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if (email != null)
                {
                    // Create a new user without password if we do not have a user already
                    var user = await _userManager.FindByEmailAsync(email);

                    if (user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                            EmailConfirmed = true,
                        };

                        await _userManager.CreateAsync(user);
                    }

                    // Add a login (i.e insert a row for the user in AspNetUserLogins table)
                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}

