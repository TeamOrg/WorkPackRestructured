using System;
using System.Collections.Generic;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public interface IBLLoadingRepository
    {
        double GetLeaveHrs(DateTime FDate, DateTime TDate, int UserId);
        IList<usp_getProjectwiseHrsInWeek_Result> GetProjects(DateTime Date, int UserID, int EstimationID, int AwaitedID);
        IList<usp_getProjectwiseHrsInWeek_Result> GetProjectsByMonth(int UserID, ArrayList ALst);
        IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectsByMonthForecast(int UserID, ArrayList ALst);
        IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectsForecast(DateTime Date, int UserID, int EstimationID, int AwaitedID);
        IList<usp_getProjectwiseHrsInWeek_Result> GetProjectwiseHrs(DateTime Date, int UserId, int EstimationID, int AwaitedID);
        IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectwiseHrsForecast(DateTime Date, int UserId, int EstimationID, int AwaitedID);
        IList<usp_getProjectwiseHrsInWeek_Result> GetProjectwiseHrsPerWeek(DateTime FDate, DateTime TDate, int UserId, int EstimationID, int AwaitedID);
        IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectwiseHrsPerWeekForcast(DateTime FDate, DateTime TDate, int UserId, int EstimationID, int AwaitedID);
        IList<usp_getProjectWiseHrsForLoadingDetails_Result> GetTasksByProject(DateTime date, int UserId, int EstimationID, int AwaitedID);
        double GetTotalAvailableHours(DateTime FDate, DateTime TDate, int UserId, int EstimationID, int AwaitedID);
        IList<getUserFromDateAndEndDate_Result> GetUserFromAndEndDates(DateTime FDate, DateTime TDate, int UserId);
        double GetWorkingHrsOfWeekDay(string Day);
    }
}