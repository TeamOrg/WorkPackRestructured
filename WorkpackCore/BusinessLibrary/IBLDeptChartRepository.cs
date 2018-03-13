using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDeptChartRepository
    {
        IList<usp_getUserList_Result> GetDeptUserList(string flagId);
        IList<usp_getUserList_Result> GetUsersByDept(int DeptID, int CompanyID);
        usp_GetDeptResourceLoadingChart_Result GetWeeklyData(DateTime Fdate, DateTime Tdate, string UserList, int EstimationID, int AwaitedID);
        usp_GetDeptResourceForecostLoadingChart_Result GetWeeklyDataForecast(DateTime Fdate, DateTime Tdate, string UserList, int EstimationID, int AwaitedID);
        bool SaveDel(string FlagId, string[] UserList);
    }
}