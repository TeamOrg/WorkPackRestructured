using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLActivityLogRepository
    {
        void AddActivityLog(params ActivityLog[] ActivityLog);
        void AddActivityLogByFileID(string ActionBy, int FileID, string Action);
        ActivityLog GetActivityLogByID(int ActivityLogID);
        IList<ActivityLog> GetAllActivityLog();
        void RemoveActivityLog(params ActivityLog[] activityLog);
        void UpdateActivityLog(params ActivityLog[] activityLog);
    }
}