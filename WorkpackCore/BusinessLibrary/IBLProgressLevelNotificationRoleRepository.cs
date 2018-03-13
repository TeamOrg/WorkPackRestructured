using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProgressLevelNotificationRoleRepository
    {
        List<ProgressLevelNotificationRole> GetAllProgressLevelNotificationRoleByRoleID(int RoleID);
        IList<ProgressLevelNotificationRole> GetAllRoles();
        int GetRoleIDByRoleName(string RoleName);
    }
}