using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLRoleRepository
    {
        void AddRole(params Role[] role);
        bool CheckDuplicate(Role role, bool IsInsert);
        IList<Role> GetAllRoles();
        Role GetRoleByID(int roleID);
        int GetRoleIDByRoleName(string roleName);
        IList<usp_GetRoleList_Result> GetRoleList(Role role);
        void RemoveRole(params Role[] role);
        void UpdateRole(params Role[] role);
    }
}