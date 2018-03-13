using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public class BLLoadingRepository : IBLLoadingRepository
    {
        public IList<usp_getProjectwiseHrsInWeek_Result> GetProjectwiseHrs(DateTime Date, int UserId,int EstimationID, int AwaitedID)
        {
            IList<usp_getProjectwiseHrsInWeek_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectwiseHrsInWeek(Date,Date, UserId, EstimationID, AwaitedID).ToList<usp_getProjectwiseHrsInWeek_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectwiseHrsForecast(DateTime Date, int UserId, int EstimationID, int AwaitedID)
        {
            IList<usp_getProjectwiseForeCostHrsInWeek_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectwiseForeCostHrsInWeek(Date, Date, UserId, EstimationID, AwaitedID).ToList<usp_getProjectwiseForeCostHrsInWeek_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public Double GetWorkingHrsOfWeekDay(string Day)
        {
            Double val = 0.00;
            try
            {
                //BLProjectCreationRepository objproject = new BLProjectCreationRepository();
                //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    val = (double)context.DailyWorkingHrs.Where(p => p.WeekDay == Day && p.ProjectID == projectID).Select(p => p.Workinghours).Single();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }            
            return val;
        }
        public IList<usp_getProjectwiseHrsInWeek_Result> GetProjects(DateTime Date, int UserID,int EstimationID,int AwaitedID)
        {
            IList<usp_getProjectwiseHrsInWeek_Result> MList = null;
            IList<usp_getProjectwiseHrsInWeek_Result> UList = null;
            try
            {
                 UList = new List<usp_getProjectwiseHrsInWeek_Result>();
                for (int i = 0; i < 7; i++)
                {
                    MList = GetProjectwiseHrs(Date.AddDays(i + 1), UserID,EstimationID,AwaitedID);
                    foreach (var val in MList)
                    {
                        if (Convert.ToDouble(val.Hrs) != 0.0)
                        {
                            if (!UList.Any(p => p.ProjectID == val.ProjectID))
                                UList.Add(val);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return  UList.Distinct().ToList<usp_getProjectwiseHrsInWeek_Result>();;
        }
        public IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectsForecast(DateTime Date, int UserID, int EstimationID, int AwaitedID)
        {
            IList<usp_getProjectwiseForeCostHrsInWeek_Result> MList = null;
            IList<usp_getProjectwiseForeCostHrsInWeek_Result> UList = null;
            try
            {
                UList = new List<usp_getProjectwiseForeCostHrsInWeek_Result>();
                for (int i = 0; i < 7; i++)
                {
                    MList = GetProjectwiseHrsForecast(Date.AddDays(i + 1), UserID, EstimationID, AwaitedID);
                    foreach (var val in MList)
                    {
                        if (Convert.ToDouble(val.Hrs) != 0.0)
                        {
                            if (!UList.Any(p => p.ProjectID == val.ProjectID))
                                UList.Add(val);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return UList.Distinct().ToList<usp_getProjectwiseForeCostHrsInWeek_Result>(); ;
        }
        public IList<usp_getProjectWiseHrsForLoadingDetails_Result> GetTasksByProject(DateTime date, int UserId,int EstimationID, int AwaitedID)
        {
            IList<usp_getProjectWiseHrsForLoadingDetails_Result> list = null;
            try
            {
                //CultureInfo ci = new CultureInfo("en-GB");
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectWiseHrsForLoadingDetails(date, UserId ,EstimationID, AwaitedID).ToList<usp_getProjectWiseHrsForLoadingDetails_Result>();
                   
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getProjectwiseHrsInWeek_Result> GetProjectwiseHrsPerWeek(DateTime FDate, DateTime TDate, int UserId, int EstimationID, int AwaitedID)
        {
            IList<usp_getProjectwiseHrsInWeek_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getProjectwiseHrsInWeek(FDate, TDate, UserId, EstimationID, AwaitedID).ToList<usp_getProjectwiseHrsInWeek_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectwiseHrsPerWeekForcast(DateTime FDate, DateTime TDate, int UserId, int EstimationID, int AwaitedID)
        {
            IList<usp_getProjectwiseForeCostHrsInWeek_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getProjectwiseForeCostHrsInWeek(FDate, TDate, UserId, EstimationID, AwaitedID).ToList<usp_getProjectwiseForeCostHrsInWeek_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<usp_getProjectwiseHrsInWeek_Result> GetProjectsByMonth(int UserID, ArrayList ALst)
        {
            IList<usp_getProjectwiseHrsInWeek_Result> list = null;
            IList<usp_getProjectwiseHrsInWeek_Result> UList = null;
            try
            {
                //int EstimationID = Convert.ToInt32(Common.ProjectStatus.Estimation);
                //int AwaitedID = Convert.ToInt32(Common.ProjectStatus.Awaited);
            
                //UList = new List<usp_getProjectwiseHrsInWeek_Result>();
                //for (int i = 1; i <= ALst.Count; i++)
                //{
                //    string[] WDate = ALst[i - 1].ToString().Split('-');
                //    list = GetProjectwiseHrsPerWeek(Convert.ToDateTime(WDate[0]), Convert.ToDateTime(WDate[1]), UserID, EstimationID, AwaitedID);
                //   foreach (var a in list)
                //   {
                //       if (a.Hrs > 0)
                //       {
                //           if(!UList.Any(p=>p.ProjectID==a.ProjectID))
                //           UList.Add(a);
                //       }
                //   }
                //}
                               
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return UList.ToList<usp_getProjectwiseHrsInWeek_Result>(); ;
        }
        public IList<usp_getProjectwiseForeCostHrsInWeek_Result> GetProjectsByMonthForecast(int UserID, ArrayList ALst)
        {
            IList<usp_getProjectwiseForeCostHrsInWeek_Result> list = null;
            IList<usp_getProjectwiseForeCostHrsInWeek_Result> UList = null;
            try
            {
                //int EstimationID = Convert.ToInt32(Common.ProjectStatus.Estimation);
                //int AwaitedID = Convert.ToInt32(Common.ProjectStatus.Awaited);

                //UList = new List<usp_getProjectwiseForeCostHrsInWeek_Result>();
                //for (int i = 1; i <= ALst.Count; i++)
                //{
                //    string[] WDate = ALst[i - 1].ToString().Split('-');
                //    list = GetProjectwiseHrsPerWeekForcast(Convert.ToDateTime(WDate[0]), Convert.ToDateTime(WDate[1]), UserID, EstimationID, AwaitedID);
                //    foreach (var a in list)
                //    {
                //        if (a.Hrs > 0)
                //        {
                //            if (!UList.Any(p => p.ProjectID == a.ProjectID))
                //                UList.Add(a);
                //        }
                //    }
                //}

            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return UList.ToList<usp_getProjectwiseForeCostHrsInWeek_Result>(); ;
        }
        public double GetLeaveHrs(DateTime FDate, DateTime TDate, int UserId)
        {
            double res = 0.0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = Convert.ToDouble(context.usp_GetLeaveHrsByUser(FDate, TDate, UserId).Single());
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public IList<getUserFromDateAndEndDate_Result> GetUserFromAndEndDates(DateTime FDate, DateTime TDate, int UserId)
        {
            IList<getUserFromDateAndEndDate_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.getUserFromDateAndEndDate(FDate, TDate, UserId).ToList<getUserFromDateAndEndDate_Result>(); 
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                    throw ex;
            }
            return list;
        }
        public double GetTotalAvailableHours(DateTime FDate, DateTime TDate, int UserId,int EstimationID, int AwaitedID)
        {
            double res = 0.0;
            IList<getUserFromDateAndEndDate_Result> UList = null;
            try
            {
                UList = GetUserFromAndEndDates(FDate, TDate, UserId);
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    var a = UList.First();
                //    res = Convert.ToDouble(Context.usp_Get_Total_AvailableHrs(a.FromDate, a.ToDate).Single());                    
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }


        //public static Decimal GetLoadingPercentForPersonByProjectInMonth(int UserId, DateTime Month,int ProjectID)
        //{
        //    Decimal res = 0.0M;
        //    try
        //    {                
        //        DateTime fDate=new DateTime(Month.Year,Month.Month,1);
        //        DateTime eDate=fDate.AddMonths(1).AddDays(-1);
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //             res = (from a in db.getTaskWiseDailyHrsDistr(fDate, eDate, UserId) where a.ProjectID == ProjectID select a.DailyHrs).Sum().GetValueOrDefault();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return res;
        //}


    }    
}
