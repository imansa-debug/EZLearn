using EzLearn.Core.Convertor;
using EzLearn.Core.DTOs;
using EzLearn.Core.Generator;
using EzLearn.Core.Security;
using EzLearn.Core.Services.Interfaces;
using EzLearn.DataLayer.Context;
using EzLearn.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzLearn.Core.Services
{
    public class UserService : IUserService
    {
        private readonly EzLearnContext _context;
        public UserService(EzLearnContext context)
        {
            _context = context;
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user == null ||user.IsActive) {
                return false;
            }
            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqCode();
            _context.SaveChanges();
            return true;
        }

        public int AddUser(User user)
        {
           var addeddUser= _context.Add(user);
            _context.SaveChanges();
            return addeddUser.Entity.UserId;
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashedPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedText.FixEmail(login.Email);
            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == hashedPassword);
        }
    }
}
