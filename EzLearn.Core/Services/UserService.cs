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
    }
}
