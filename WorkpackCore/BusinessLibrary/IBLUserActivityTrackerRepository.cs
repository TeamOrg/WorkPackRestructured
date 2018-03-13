using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLUserActivityTrackerRepository
    {
        void AddUserActivityTracker(params UserActivityTracker[] useractivity);
        IList<UserActivityTracker> GetAllUserActivity();
        UserActivityTracker GetUserActivityByID(int trackID);
        void RemoveUserActivityTracker(params UserActivityTracker[] useractivity);
        void UpdateUserActivityTracker(params UserActivityTracker[] useractivity);
    }
}