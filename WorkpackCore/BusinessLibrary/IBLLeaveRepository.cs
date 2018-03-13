using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLLeaveRepository
    {
        bool CheckLeavPeriod(Leave obj);
        IList<usp_getLeaveList_Result> GetAllLeaveRecords(Leave objLeave, int UserID, DateTime fromdate, DateTime Todate, string Leavestatus);
        IList<usp_getLeavApprovedList_Result> GetLeaveApprovedLiat(Leave objLeave, int UserID);
        int GetLeaveRecordByDate(DateTime date, int UserID);
        Leave GetLeaveRecordById(int LeaveId);
        bool InsertEditDeleteLeave(Leave obj, string status);
        bool SaveApprovedStatus(int LeaveId, int UserID);
    }
}