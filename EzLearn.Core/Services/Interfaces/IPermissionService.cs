using EzLearn.DataLayer.Entities.Permissions;
using EzLearn.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace EzLearn.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Roles
        List<Role> GetRoles();
        int AddRole(Role role);
        Role GetRoleById(int id);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRoleUser(int userID, List<int> roles);
        #endregion

        #region Permission 
        List<Permission> GetAllPermissions();

        void AddPermissionsToRole(int roleId, List<int> permission);

        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> Permissions);

        bool CheckPermission(int permissionId, string userName);
        #endregion
    }
}
