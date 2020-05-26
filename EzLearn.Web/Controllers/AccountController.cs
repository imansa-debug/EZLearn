using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzLearn.Core.DTOs;
using EzLearn.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using EzLearn.Core.Convertor;
using EzLearn.DataLayer.Entities.User;
using EzLearn.Core.Generator;
using EzLearn.Core.Security;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using EzLearn.Core.Senders;

namespace EzLearn.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUserService _userService;
        private readonly IViewRenderService _viewRender;
        public AccountController(IUserService userService,IViewRenderService viewRender)
        {
            _userService = userService;
            _viewRender = viewRender;
        }


        #region Register
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            if (_userService.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری تکراری می باشد");
                return View(register);
            }
            if (_userService.IsExistEmail(FixedText.FixEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده تکراری می باشد");
                return View(register);
            }



            DataLayer.Entities.User.User user = new User()
            {
                ActiveCode = NameGenerator.GenerateUniqCode(),
                Email = FixedText.FixEmail(register.Email),
                IsActive = false,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                RegisterDate = DateTime.Now,
                UserAvatar = "Default.jpg",
                UserName = register.UserName

            };

            _userService.AddUser(user);


            #region send Activation Email


            string body = _viewRender.RenderToStringAsync("_ActiverEmail", user);

            SendEmail.Send(user.Email, "فعال سازی", body);
        #endregion
            return View("SuccessRegister", user);
        }

        #endregion


        #region Login
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _userService.LoginUser(login);
            if (user!=null)
            {
                if (user.IsActive)
                {

                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RemmemberMe
                    };
                    HttpContext.SignInAsync(principal, properties);


                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد");
                }
                
            }
            return View();
        }

        #endregion
        #region Logout

        [Route("LogOut")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
        #endregion

      
        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userService.ActiveAccount(id);

            return View();
        }



        #region ForgotPassword 

        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forget)
        {
            if (!ModelState.IsValid)
            {
                return View(forget);
            }

            string fixedEmail = FixedText.FixEmail(forget.Email);
            var user = _userService.GetUserByEmail(fixedEmail);

            if (user == null)
            {
                ModelState.AddModelError("Email", "کاربری یافت نشد");
                return View(forget);
            }

            string bodyEmail = _viewRender.RenderToStringAsync("_ForgotPassword", user);
            SendEmail.Send(user.Email, "بازیابی حساب کاربری", bodyEmail);
            ViewBag.IsSuccess = true;
            return View();
        }


        #endregion


        #region Reset Password

        public ActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel()
            {ActiveCode=id
            });
        }
        [HttpPost]
        public ActionResult ResetPassword(ResetPasswordViewModel reset)
        {
            if (!ModelState.IsValid)
                return View(reset);

            var user = _userService.GetUserByActiveCode(reset.ActiveCode);
            if (user == null)
            {
                return NotFound();
            }

            string hashNewPassword = PasswordHelper.EncodePasswordMd5(reset.Password);
            user.Password = hashNewPassword;

            _userService.UpdateUser(user);

            return Redirect("/Login");

        }
        #endregion
    }
}