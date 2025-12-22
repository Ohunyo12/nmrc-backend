using FintrakBanking.ViewModels;
using FintrakBanking.ViewModels.Admin;
using FintrakBanking.ViewModels.WorkFlow;
using FintrakBanking.ViewModels.Credit;
using FintrakBanking.ViewModels.Setups.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FintrakBanking.ViewModels.Finance;
using FintrakBanking.Entities.Models;

namespace FintrakBanking.Interfaces.Admin
{
    public interface IAdminRepository
    {
        #region Users

        void DeactivateInactiveUsers();

        IEnumerable<UserViewModel> GetAllUsers();

        UserViewModel GetUsersByStaffId(int staffId);


        UserViewModel GetSingleUser(int userId);

        UserViewModel GetSingleUserByUserName(string userName);

        bool isUserExist(string username);

        bool isStaffExist(long staffId);

        bool GoForApproval(ApprovalViewModel entity);

        int GoForUserAccountStatusApproval(ApprovalViewModel entity);
        

        IEnumerable<UserViewModel> GetUsersAwaitingApproval(int staffId, int companyId);
        IEnumerable<UserViewModel> GetUsersWithAccountStatusChangeAwaitingApproval(int staffId, int companyId);
        IEnumerable<ApprovalStatusViewModel> GetApprovalStatus();

        bool CreateUser(AppUserViewModel user);

        bool UpdateUser(int userId, AppUserViewModel user);

        //   Object ManageUserAccount(int userId, int lockStatus);        

        List<string> GetUserActivitiesByUser(int userId);

        #endregion Users

        #region Group
        Users GetStaffActiveDirectoryDetails(string staffCode ,string loginUser, string password);

        IEnumerable<AppGroupViewModel> GetAllGroups();
        GlobalSettingViewModel GetAllGlobalSettings();

        AppGroupViewModel GetSingleGroup(int groupId);

        bool isGroupExist(string groupName);

        bool AddGroup(AppGroupViewModel group);

        bool UpdateGroup(short groupId, AppGroupViewModel groupModel);
        //Task<bool> AddGroup(AppGroupViewModel group);

        // Task<bool> UpdateGroup(short groupId, AppGroupViewModel groupModel);

        #endregion

        #region Activity

        IEnumerable<ActivityParent> GetActivities();
        IEnumerable<UserActivities> GetActivityDetails(int parentId);

        IEnumerable<GroupVModel> GetGroupActivities();

        bool AddAccessToActivity(int id, ActivitiesUpdateVm model);

        #endregion

        bool LogUserStatusUpdateRequest(ActiveUserDetails entity, out string message);
        IEnumerable<ActiveUserDetails> GetActiveUsers(int companyId);

        bool StaffHasActivity(int staffId, string activity);

        #region Two Factor Authentication
        TwoFactorAutheticationOutputViewModel TwoFactorAuthentication(string staffCode, string passCode);
        bool TwoFactorAuthenticationEnabled();
        bool Enable2FAForLastApproval(int staffId, int operationId, int? productClassId, int? productId, decimal levelAmount = 0);
       // bool Enable2FAForLastApproval(int staffId, int operationId, int? productClassId, int? productId);
        bool IsSuperAdmin(int staffId);

        #endregion
        Task<TBL_DOWN_PAYMENT> AddDownPaymentSetup(TBL_DOWN_PAYMENT model);
        Task<TBL_DOWN_PAYMENT> UpdateDownPaymentSetup(long id, TBL_DOWN_PAYMENT model);
        Task<bool> DeleteDownPaymentSetup(int id);
        Task<List<TBL_DOWN_PAYMENT>> GetDownPaymentSetups();
        Task<TBL_REFINANCE_PERIOD> AddRefinancePeriodSetup(TBL_REFINANCE_PERIOD model);
        Task<TBL_REFINANCE_PERIOD> UpdateRefinacePeriodSetup(long id, TBL_REFINANCE_PERIOD model); 
        Task<bool> DeleteRefinancePeriodSetup(int id);
        Task<List<TBL_REFINANCE_PERIOD>> GetRefiancePeriodSetups();
        Task<TBL_ORIGINATION_FEE> AddOriginationFeeSetup(TBL_ORIGINATION_FEE model);
        Task<TBL_ORIGINATION_FEE> UpdateOriginationFeeSetup(long id, TBL_ORIGINATION_FEE model);
        Task<bool> DeleteOriginationFeeSetup(int id);
        Task<List<TBL_ORIGINATION_FEE>> GetOriginationFeeSetup();
        Task<TBL_SERVICE_FEE> AddServiceFeeSetup(TBL_SERVICE_FEE model);
        Task<TBL_SERVICE_FEE> UpdateServicefee(long id, TBL_SERVICE_FEE model);
        Task<bool> DeleteServiceFeeSetup(int id);
        Task<List<TBL_SERVICE_FEE>> GetServiceFeeSetup();




    }
}
