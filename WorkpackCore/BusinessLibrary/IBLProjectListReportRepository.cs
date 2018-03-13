using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectListReportRepository
    {
        IList<usp_MY_ProjectTaskList_Result> FetchMyProjectList(int UserID);
        IList<usp_ProjectListForResourceList_Result> FetchProjectListForResourceList(int UserID);
        IList<usp_getAllottedVsConsumedHoursOfProject_Result> GetAllottedVsConsumedHoursOfProject(int ProjectID);
        string getOwnerPeriod(int userID, int TaskID);
        List<usp_getTaskRecordByID_Result> getSPTaskRecordByID(int taskID);
        int transferTask(int taskID, DateTime fromDate, DateTime toDate, int transferFrom, int transferTo, int userID);
        int UnlockProgressSheet(int taskID, int UserID);
    }
}