using EzLearn.DataLayer.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EzLearn.DataLayer.Context
{
    public class EzLearnContext:DbContext
    {

        public EzLearnContext(DbContextOptions<EzLearnContext> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        #endregion
    }
}
