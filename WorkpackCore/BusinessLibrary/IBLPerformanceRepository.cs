using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLPerformanceRepository
    {
        IList<SP_Dashboard_Applications_Result> GetApplicationandProgressTimesheetList(int UserID);
        IList<usp_My_Target_GridList_Result> GetApplicationandTargetList(int UserID);
        IList<usp_PerformanceChartForDelayByDept_Result> GetDeptPerformanceDelay(DateTime FromDate, DateTime ToDate, int DeptID);
        IList<usp_PerformanceChartForOverHeadByDept_Result> GetDeptPerformanceOverHead(DateTime FromDate, DateTime ToDate, int DeptID);
        IList<usp_PerformanceGridList_Result> GetSchedulePerformanceGridList(DateTime FromDate, DateTime ToDate, int UserID);
        usp_PerformanceChartForOverHead_Result GetSchedulePerformanceOverHead(DateTime FromDate, DateTime ToDate, int UserID);
        usp_PerformanceChartForDelay_Result GetSchedulePreformance(DateTime FromDate, DateTime ToDate, int UserID);
        ScheduleHealth GetTSH(string ScheduleType);
    }
}