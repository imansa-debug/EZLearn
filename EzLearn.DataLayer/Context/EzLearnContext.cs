using EzLearn.DataLayer.Entities.Course;
using EzLearn.DataLayer.Entities.Permissions;
using EzLearn.DataLayer.Entities.User;
using EzLearn.DataLayer.Entities.Wallet;
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


        #region Wallet
        public DbSet<WalletType> walletTypes { get; set; }
        public DbSet<Wallet> wallets { get; set; }


        #endregion

        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }


        #region Course
        public DbSet<CourseGroup> CourseGroups { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {// dar tamaame query ha IsDelete ha ro hazf mikonad
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>().HasQueryFilter(r=> !r.IsDelete);
            modelBuilder.Entity<CourseGroup>().HasQueryFilter(c => !c.IsDelete);
            base.OnModelCreating(modelBuilder);
        }
    }
}
