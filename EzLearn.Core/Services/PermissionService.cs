using EzLearn.Core.Services.Interfaces;
using EzLearn.DataLayer.Context;
using EzLearn.DataLayer.Entities.Permissions;
using EzLearn.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzLearn.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private EzLearnContext _context;
        public PermissionService(EzLearnContext context)
        {
            _context = context;
        }

        public void AddPermissionsToRole(int roleId, List<int> permission)
        {
            foreach (var p in permission)
            {
                _context.RolePermission.Add(new RolePermission()
                {
                    PermissionId=p,
                    RoleId=roleId
                });
            }
            _context.SaveChanges();
        }

        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach (var roleId in roleIds)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId
                });

            }
            _context.SaveChanges();
        }

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _context.Users.Single(u => u.UserName == userName).UserId;
            List<int> UserRoles = _context.UserRoles
                .Where(r => r.UserId ==userId).Select(r => r.RoleId).ToList();
            if (!UserRoles.Any())
                return false;
            List<int> RolesPermission = _context.RolePermission
                .Where(p => p.PermissionId == permissionId).Select(p => p.RoleId).ToList();

            return RolesPermission.Where(p => UserRoles.Contains(p)).Any();
        }

        public void DeleteRole(Role role)
        {
            role.IsDelete = true;
            UpdateRole(role);
        }

        public void EditRoleUser(int userID, List<int> roles)
        {//Delete All Roles User
            _context.UserRoles.Where(r => r.UserId == userID).ToList().ForEach(r => _context.UserRoles.Remove(r));

            //Add New Roles
            AddRolesToUser(roles, userID);
        }

        public List<Permission> GetAllPermissions()
        {
            return _context.Permission.ToList();
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.Find(id);
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public List<int> PermissionsRole(int roleId)
        {
            return _context.RolePermission.Where(r => r.RoleId == roleId).Select(r => r.PermissionId).ToList();
        }

        public void UpdatePermissionsRole(int roleId, List<int> Permissions)
        {
            _context.RolePermission.Where(p => p.RoleId == roleId).ToList()
                 .ForEach(p => _context.RolePermission.Remove(p));

            AddPermissionsToRole(roleId, Permissions);
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }
    }
}
