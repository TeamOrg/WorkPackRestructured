using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTimeSheetWeeklyDetailRepository
    {
        void AddTimeSheetWeeklyDetail(params TimeSheetWeeklyDetail[] timeSheetWeeklyDetail);
        IList<TimeSheetWeeklyDetail> GetAllTimeSheetWeeklyDetail();
        List<TimeSheetWeeklyDetail> GetAllTimeSheetWeeklyDetailByTaskID(int TaskID);
        IList<TimeSheetWeeklyDetail> GetAllTimeSheetWeeklyDetailByTaskWeekUserID(int TaskID, int WeekID, int UserID);
        TimeSheetWeeklyDetail GetTimeSheetWeeklyDetailByID(int timeSheetWeeklyDetailID);
        List<TimeSheetWeeklyDetail> GetTimeSheetWeeklyDetailByweekID(int weekID);
        void RemoveTimeSheetWeeklyDetail(params TimeSheetWeeklyDetail[] timeSheetWeeklyDetail);
        void UpdateTimeSheetWeeklyDetail(params TimeSheetWeeklyDetail[] timeSheetWeeklyDetail);
    }
}