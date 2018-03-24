using System.Collections.Generic;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public interface IBLUserRepository
    {
        void Adduser(params User[] user);
        OperationResult CreateOrEditUser(User user, UserRole[] userRole, int CompnayId, int UserId);
        string CheckActiveUsersValidation(int userID, string mode, int CompanyId);
        string CheckLimitedUsers();
        bool CreateNewPassword_ChangePassword(User objUser, ManagePassword objManagePassword);
        bool CreateNewPassword_ForgetPwd(User objUser);
        IList<usp_getUserList_Result> c_GetAllStakeHolder(int MilestoneID, int TaskID);
        IList<usp_getUserList_Result> c_GetAllUsers(int projectid = 0);
        int GetAdminUserID(int CompanyId);
        IList<usp_getUserRoleAssigned_Result> GetAllRolesByUser(int UserID);
        IList<User> GetAllusers();
        IList<User> GetAllusers(int companyId);
        List<object> GetAllusersForMatrix();
        List<InternalUser> GetAllusersInternalModel();
        User GetDeptFocalPoint(int DepartmentID);
       // ExUser GetExuserByeEmailID(string email);
        int GetExUserCompanyID(string EmailID);
        List<int> GetLimitedusers();
        ArrayList GetNoOfLimitedUsers();
        List<object> GetNormsFieldData(string key);
        List<usp_getDynamicAutocompleteData_Result> GetNormsFieldData(string CompanyId, string key, string tableName, string columnName, string filter, string filterValue = "");
        List<usp_getPlanningEnginner_Result> getPlanningEnginner();
        List<DropdownData> GetUsersForProjectsAdminAndMembers(int companyId);
        List<object> GetResourceManagerRoleUsers(int CompanyId, int DeptID);
        User GetuserByEmailID(string userID);
        User GetUserByEmailID(string EmailID, int UserID);
        User GetUserByEmpCode(string EmpCode);
        User GetuserByID(int userID);
        List<User> GetuserByID(params int[] userID);
        User GetUserByMobileNumber(string Mobile, int UserID);
        List<User> GetuserByName(string username);
        User GetUserDetailsbyID(int UserId);
        string GetUserFullName(int userID);
        IList<usp_getUserList_Result> GetuserList(User user);
        IList<User> GetUsersByDepartment(int DepartmentID, int Projectid = 0);
        IList<usp_getUserList_Result> GlobalGetuserList(User user);
        void ImportSandboxTestingProjectDate(string companyName, int? companyID, int? userID);
        bool InsertRegisterUserRole(int RoleID, int UserId);
        bool InsertUserRole(string[] RoleList, int UserId);
        bool IsLoggedInUserAdmin(int UserID);
        bool IsLoggedInUserProjManager(int UserID);
        void Removeuser(params User[] user);
        int SaveNewUser(User objUser, string[] RoleList);
        string SaveRegisterUser(User objUser, string isCheckBoxChecked);
        void Updateuser(params User[] user);
        User ValidateUser(string UserCode);
        User ValidUserEmail(string Email);
        User ValidUserEmailForGoogle(string Email);
    }
}