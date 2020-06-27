﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzLearn.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using System.Web;
namespace EzLearn.Web.Controllers
{

    public class HomeController : Controller
    {
        private IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Test() => View();

        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id)
        {

            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var wallet = _userService.GetWalletByWalletId(id);
                var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                var res = payment.Verification(authority).Result;

                if (res.Status == 100)
                {
                    //کد پیگیری
                    ViewBag.Code = res.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userService.UpdateWallet(wallet);
                }
            }

            

            return View();
        }
       
    }


}