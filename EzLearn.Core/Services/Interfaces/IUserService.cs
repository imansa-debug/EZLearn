using EzLearn.Core.DTOs;
using EzLearn.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace EzLearn.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);

        int AddUser(User user);

        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string activeCode);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);

    }
}
