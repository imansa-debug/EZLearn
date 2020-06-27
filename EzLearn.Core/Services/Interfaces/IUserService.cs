using EzLearn.Core.DTOs;
using EzLearn.DataLayer.Entities.User;
using EzLearn.DataLayer.Entities.Wallet;
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
        int GetUserIdByUserName(string username);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string activeCode);
        User GetUserByUserName(string username);
        User GetUserById(int userId);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);


        #region User Panel
        InformationUserViewModel GetUserInformation(string username);
        SideBarUserPanelViewModel GetSideBarUserPanelData(string username);
        EditProfileViewModel GetDataForEditProfileUser(string username);
        void EditProfile(string username, EditProfileViewModel profile);
        bool CompareOldPassword(string oldpassword, string username);
        void ChangeUserPassoword(string username, string newpassword);
        #endregion

        #region Wallet

        int BalanceUserWallet(string username);
        List<WalletViewModel> GetWalletUser(string userName);
        int ChargeWallet(string userName, int amount,string description,bool isPay=false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);
        #endregion


        #region AdminPanel
        UsersForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filteruserName = "");
        int AddUserFromAdmin(CreateUserViewModel user);
        UsersForAdminViewModel GetDeletedUsers(int pageId = 1, string filterEmail = "", string filteruserName = "");

        EditUserViewModel GetUserForShowInEditMode(int userId);

        void EditUserFromAdmin(EditUserViewModel editUser);
        #endregion

    }
}
