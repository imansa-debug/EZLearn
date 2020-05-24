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

namespace EzLearn.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
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

            //TODO :Register User

            DataLayer.Entities.User.User user = new User()
            {
                ActiveCode = NameGenerator.GenerateUniqCode(),
                Email = FixedText.FixEmail(register.Email),
                IsActive = false,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                RegisterDate = DateTime.Now,
                UserAvatar = "Default.jpg",
                UserName=register.UserName

            };

            _userService.AddUser(user);
            return View("SuccessRegister",user);
        }
    }
}