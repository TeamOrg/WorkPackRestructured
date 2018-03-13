using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProgressLevelNotificationRepository
    {
        void AddProgressLevelNotification(params ProgressLevelNotification[] ProgressLevelNotification);
        List<ProgressLevelNotification> GetAllProgressLevelNotificationByProjectMilestonesDocID(int ProjectMilestonesDocID);
        List<string> GetIntUsersByMilestonesIDandDocstageId(int MileStoneID, int DocstageID);
        ProgressLevelNotification GetProgressLevelNotificationByProjectMilestonesDocID(int ProjectMilestonesDocID);
        List<List<string>> GetRolesByMilestonesIDandDocstageId(int MileStoneID, int DocstageID);
        void RemoveProgressLevelNotification(params ProgressLevelNotification[] ProgressLevelNotification);
    }
}