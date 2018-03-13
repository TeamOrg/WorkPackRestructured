using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDailyWorkingHrRepository
    {
        void AddDailyWorkingHr(params DailyWorkingHr[] dailyworkhr);
        IList<DailyWorkingHr> c_GetAllDailyWorkingHrs(int projectID);
        IList<DailyWorkingHr> GetAllDailyWorkingHrs();
        DailyWorkingHr GetDailyWorkingHrByID(int dailyworkhrID);
        IList<DailyWorkingHr> GetProjectDailyWorking(int projectID);
        void RemoveDailyWorkingHr(params DailyWorkingHr[] dailyworkhr);
        bool SaveDailyWorkHrs(params DailyWorkingHr[] dailyworkhr);
        void UpdateDailyWorkingHr(params DailyWorkingHr[] dailyworkhr);
    }
}