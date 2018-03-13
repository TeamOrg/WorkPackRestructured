using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLOverTimeRepository
    {
        bool CheckDate(DateTime fDate, DateTime tDate, int tid, int uid, int OtrequestID);
        IList<usp_GetOverTimeRequestForApprove_Result> FetchApproveData(OverTimeRequest obj, int UserID);
        OverTimeRequest GetOverTimeByID(int OverTimeRequestID);
        IList<usp_GetOverTimeRequestList_Result> GetOverTimeRequestList(OverTimeRequest obj, int UserId);
        IList<object> GetProjectListByUserID(int UserID);
        IList<usp_GetProjectRunningTaskByProject_Result> GetProjectRunningTaskByProject(int ProjectID, int userID, DateTime from, DateTime to);
        IList<object> GetProjectTaskByProject(int ProjectID, int UserID);
        bool OTSaveEditDelete(OverTimeRequest ot, string Status);
        bool UpdateApproveStatus(int UserID, int OverTimeRequestID, string Status);
    }
}