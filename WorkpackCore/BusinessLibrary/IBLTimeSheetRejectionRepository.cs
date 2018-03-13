using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTimeSheetRejectionRepository
    {
        void AddTimesheetRejection(params TimeSheetRejection[] TimesheetRejection);
        IList<TimeSheetRejection> GetAllTimesheetRejection();
        TimeSheetRejection GetTimesheetRejectionByID(int TimesheetRejectionID);
        List<object> GetTimesheetRejectionByTimeSheetWeeklyID(int TimeSheetWeeklyID, int? OwnerID);
        void RemoveTimesheetRejection(params TimeSheetRejection[] TimesheetRejection);
        void UpdateTimesheetRejection(params TimeSheetRejection[] TimesheetRejection);
    }
}