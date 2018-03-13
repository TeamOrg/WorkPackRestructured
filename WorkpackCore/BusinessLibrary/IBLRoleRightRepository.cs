using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLRoleRightRepository
    {
        void AddRoleRight(params RoleRight[] roleRight);
        bool CheckDuplicate(RoleRight roleRight, bool IsInsert);
        IList<RoleRight> GetAllRoleRights();
        bool GetMenuVisibility(string Page, int UserID);
        bool GetMenuVisibilityview(string Page, int UserID);
        RoleRight GetRoleRightByID(int roleRightID);
        List<usp_RoleRights_Result> GetRoleRightList(int RoleID, int ProfileID);
        void RemoveRoleRight(params RoleRight[] roleRight);
        bool SaveRoleRights(int RoleID, List<RoleRight> roleRight, string profileCode);
        void UpdateRoleRight(params RoleRight[] roleRight);
    }
}