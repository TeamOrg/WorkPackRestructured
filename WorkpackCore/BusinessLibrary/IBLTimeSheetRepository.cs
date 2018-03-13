using System;
using System.Collections.Generic;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public interface IBLTimeSheetRepository
    {
        bool ApproveRejectTimeSheet(int WeeklyId, int UserId, string ApproveFlag, string sessionUser, string rejectionReason);
        List<usp_getWeeklyApprovalTimesheet_Result> getApprovalTimesheetRecords(int UserId);
        IList<usp_getApproveTimeSheetRecord_Result> getApproveTimeSheetRecord(int UserID);
        bool getFinalLockStatusTimeSheetWeekly(DateTime WeekStartDate, int UserID);
        IList<HolidayCalendar> getHolidayBetweenDate(DateTime fromDate, DateTime toDate);
        IList<usp_getTimeSheetDetails_Result> GetTimeSheet(DateTime fromDate, DateTime toDate, int userId);
        IList<usp_getTimeSheetDetailsNew_Result> GetTimeSheetNew(DateTime fromDate, DateTime toDate, int userId);
        TimeSheetWeekly GetTimeSheetWeeklyByID(int TimeSheetWeeklyID);
        IList<TimeSheetWeekly> GetTimeSheetWeeklyByWeek(DateTime fromDate, DateTime toDate, int UserID, int TaskID);
        IList<usp_GetTimeSheetWeeklyDetail_Result> GetTimeSheetWeeklyDetails(DateTime fromDate, DateTime toDate, int userId);
        List<usp_getUnlockTimeSheetMasterData_Result> getUnlockTimeSheetMasterData(int userID);
        List<usp_getUnlockTimeSheetPreviousData_Result> getUnlockTimeSheetPreviousData(int UnlockTimeSheetWeeklyID);
        IList<DailyWorkingHr> getWorkingHrs();
        void RemoveTimeSheetWeekly(params TimeSheetWeekly[] timeSheetWeekly);
        string RemoveTimesheetWeeklyDetailsByTaskWeekUserID(string TaskID, int WeekID, int UserID, DateTime fromDate, DateTime toDate);
        bool saveApproveTimeSheet(string xmlTargetDates);
        ArrayList saveTimeSheet(TimeSheet objTimeSheet, string xmlDetailTimeSheet, string xmlTimeSheetDeviation, string xmlTimeSheetLeave, int FinalStatus);
        void UnlockTimeSheet(int UserID, DateTime WeekStartDate, string Remark, int CreatedBy);
        void UpdateTimeSheetWeekly(params TimeSheetWeekly[] timeSheetWeekly);
    }
}