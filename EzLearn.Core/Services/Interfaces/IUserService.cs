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

    }
}
