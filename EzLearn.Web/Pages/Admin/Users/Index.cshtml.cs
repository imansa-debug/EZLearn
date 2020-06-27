using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezlearn.Core.Security;
using EzLearn.Core.DTOs;
using EzLearn.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EzLearn.Web.Pages.Admin.Users
{
    [PermissionChecker(2)]
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;

        public IndexModel(IUserService userService)
        {
            _userService = userService;

        }
        public UsersForAdminViewModel usersForAdminViewModel { get; set; }
        public void OnGet(int pageId=1,string filterUserName="",string filterEmail="")
        {
            usersForAdminViewModel = _userService.GetUsers(pageId, filterEmail,filterUserName);
        }

       
    }
}