using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLHandOverListRepository : IBLHandOverListRepository
    {
        //public static IList<SP_MY_HANDOVER_TASKREQUEST_Result> GetMyHandoverTaskRequestList(int TaskHandoverID)
        //{
        //    IList<SP_MY_HANDOVER_TASKREQUEST_Result>List=null;
        //    try
        //    {
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //            List = db.SP_MY_HANDOVER_TASKREQUEST(Convert.ToInt32(HttpContext.Current.Session["UserID"]), TaskHandoverID).ToList<SP_MY_HANDOVER_TASKREQUEST_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return List;
        //}

        //public static IList<usp_TaskHandoverDetails_Result> GetMyHandoverTaskDetails(int TaskHandoverID)
        //{
        //    IList<usp_TaskHandoverDetails_Result> List = null;
        //    try
        //    {
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //            List = db.usp_TaskHandoverDetails(TaskHandoverID).ToList<usp_TaskHandoverDetails_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return List;
        //}


        //public static IList<SP_HandOverProjectList_Result> getUserHandOverList(string userID, int TaskHandoverID)
        //{
        //    IList<SP_HandOverProjectList_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.SP_HandOverProjectList(Convert.ToInt32(userID), TaskHandoverID).ToList<SP_HandOverProjectList_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}

        //public static IList<SP_PROJECT_WISE_HANDOVER_TASKLIST_Result> GetProjectwiseHandoverTaskList(string TaskHandoverID)
        //{
        //    IList<SP_PROJECT_WISE_HANDOVER_TASKLIST_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.SP_PROJECT_WISE_HANDOVER_TASKLIST(Convert.ToInt32(HttpContext.Current.Session["UserID"]), Convert.ToInt32(TaskHandoverID)).ToList<SP_PROJECT_WISE_HANDOVER_TASKLIST_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}
        public Boolean deleteTaskByTaskHandoverDetailID(int TaskHandoverDetailID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    int val = context.usp_DeleteHandOverTask(TaskHandoverDetailID).FirstOrDefault().GetValueOrDefault();
                //    if (val == 1)
                //        res = true;
                //}
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
            return res;
        }
        //public static IList<usp_GetHandOverTaskList_Result> getTaskList(int userID, DateTime startDate, DateTime endDate, string TaskHandoverID)
        //{
        //    IList<usp_GetHandOverTaskList_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.usp_GetHandOverTaskList(userID, startDate, endDate, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner), Convert.ToInt32(TaskHandoverID), Convert.ToInt32(Common.TaskStatusID.Closed)).ToList<usp_GetHandOverTaskList_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}

        //public static List<Int32> getUserIDList(int TaskHandoverID)
        //{
        //    List<Int32> userList = null;
        //    try
        //    {
        //        using (var Context = new Cubicle_EntityEntities())
        //        {
        //            userList = (from u in Context.HandOverRecipients where u.TaskHandoverID == TaskHandoverID select u.UserID.Value).ToList();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return userList;
        //}

        //public static Int32 saveHandOverTaskList(DateTime fromdate, DateTime todate, string handovernotes, string xmlProjectTaskList, int TaskHandoverID, string strSubject, string xmlUserID)
        //{
        //    int res = 0;
        //    try
        //    {
        //        ObjectParameter p = new ObjectParameter("ID", typeof(int));
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            context.SP_ADD_HANDOVER_TASK_LIST(Convert.ToInt32(HttpContext.Current.Session["UserID"]), fromdate, todate,
        //                handovernotes, xmlProjectTaskList, TaskHandoverID, strSubject,p, xmlUserID);
        //            res = Convert.ToInt32(p.Value);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return res;
        //}

        //public static IList<SP_VALID_PERIOD_Result> ValidPeriod(DateTime fromdate, DateTime todate, int HandOverID)
        //{
        //    IList<SP_VALID_PERIOD_Result>list=null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.SP_VALID_PERIOD(Convert.ToInt32(HttpContext.Current.Session["UserID"]), fromdate, todate, HandOverID).ToList<SP_VALID_PERIOD_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list; 
        //}

        //public static IList<SP_MyHandoverList_Result> HandoverList(string userID)
        //{
        //    IList<SP_MyHandoverList_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.SP_MyHandoverList(Convert.ToInt32(userID)).ToList<SP_MyHandoverList_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}

        //public static Boolean UpdateTaskHandoverRequestStatus(Int32 TaskHandoverDetailID)
        //{
        //    Boolean res = false;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            var obj = context.TaskHandoverDetails.Where(t => t.TaskHandoverDetailID == TaskHandoverDetailID).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                obj.Active = "Y";
        //                context.Entry(obj).State = System.Data.EntityState.Modified;
        //                context.SaveChanges();
        //                res = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return res;
        //}

        //public static Boolean UpdateTaskOwnerTrfStatus(Int32 TastID)
        //{
        //    Boolean res = false;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            var obj = context.ProjectTaskLists.Where(t => t.ProjectTaskID == TastID).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                obj.TaskOwnerTrf = 2;
        //                context.Entry(obj).State = System.Data.EntityState.Modified;
        //                context.SaveChanges();
        //                res = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return res;
        //}

        //public static IList<User> GetUserList(int UserID, int deptID)
        //{
        //    IList<User> list = null;
        //    try
        //    {
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //            list = (from a in db.Users where a.DepartmentID == deptID && a.UserID != UserID select a).ToList<User>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return list;
        //}



        //public static Boolean UpdateTransferPeriod(int TastID,int TaskHandoverDetailID)
        //{
        //    Boolean res = false;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            var obj = context.TaskTransfers.Where(t => t.TaskID == TastID).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                var objHandOver = context.TaskHandoverDetails.Where(t => t.TaskID == TastID).FirstOrDefault();
        //                if (objHandOver != null)
        //                {
        //                    if (obj.FromDate < objHandOver.FromDate && obj.ToDate > objHandOver.FromDate)
        //                    {
        //                        obj.ToDate = Convert.ToDateTime(objHandOver.FromDate);
        //                        context.Entry(obj).State = System.Data.EntityState.Modified;
        //                        context.SaveChanges();
        //                        res = true;
        //                    }
        //                    else if (obj.FromDate < objHandOver.ToDate && obj.ToDate > objHandOver.ToDate)
        //                    {
        //                        obj.FromDate = Convert.ToDateTime(objHandOver.ToDate);
        //                        context.Entry(obj).State = System.Data.EntityState.Modified;
        //                        context.SaveChanges();
        //                        res = true;
        //                    }
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return res;
        //}

        //public static Boolean UpdateTimesheetRecord(int TaskID, int TaskHandoverDetailID)
        //{
        //    Boolean res = false;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            var objHandOverDt = context.TaskHandoverDetails.Where(t => t.TaskHandoverDetailID == TaskHandoverDetailID).FirstOrDefault();
        //            if (objHandOverDt != null)
        //            {
        //                var objHandOver = context.TaskHandOvers.Where(t => t.TaskHandoverID == objHandOverDt.TaskHandoverID).FirstOrDefault();
        //                if (objHandOver != null)
        //                {
        //                    using (TransactionScope ts = new TransactionScope())
        //                    {
        //                        List<TimeSheetWeeklyDetail> objTimeSheetDetails = context.TimeSheetWeeklyDetails.Where(t => t.UserID == objHandOver.HandoverFromUserID && t.TimesheetDate >= objHandOverDt.FromDate && t.TimesheetDate <= objHandOverDt.ToDate && t.TaskID == objHandOverDt.TaskID).ToList<TimeSheetWeeklyDetail>();
        //                        if (objTimeSheetDetails.Count != 0)
        //                        {
        //                            try
        //                            {
        //                                List<int> weeklyID = objTimeSheetDetails.Select(a => a.TimeSheetWeeklyID).Distinct().ToList<int>();
        //                                foreach (var obj in objTimeSheetDetails)
        //                                {
        //                                    context.Entry(obj).State = System.Data.EntityState.Deleted;
        //                                }
        //                                context.SaveChanges();
        //                                foreach (var Wid in weeklyID)
        //                                {
        //                                    List<TimeSheetWeeklyDetail> objHandOverDt_1 = context.TimeSheetWeeklyDetails.Where(t => t.TimeSheetWeeklyID == Wid).ToList<TimeSheetWeeklyDetail>();

        //                                    if (objHandOverDt_1.Count == 0)
        //                                    {
        //                                        List<TimeSheetDeviation> objDeviation = context.TimeSheetDeviations.Where(t => t.TimeSheetWeeklyID == Wid).ToList<TimeSheetDeviation>();
        //                                        foreach (var obj in objDeviation)
        //                                        {
        //                                            context.Entry(obj).State = System.Data.EntityState.Deleted;
        //                                        }
        //                                        context.SaveChanges();

        //                                        var objTimeSheetWeek = context.TimeSheetWeeklies.Where(t => t.TimeSheetWeeklyID == Wid).FirstOrDefault();
        //                                        context.Entry(objTimeSheetWeek).State = System.Data.EntityState.Deleted;
        //                                        context.SaveChanges();
        //                                    }
        //                                    else
        //                                    {
        //                                        List<TimeSheetDeviation> objDeviation = context.TimeSheetDeviations.Where(t => t.TimeSheetWeeklyID == Wid && t.TaskID == TaskID).ToList<TimeSheetDeviation>();
        //                                        foreach (var obj in objDeviation)
        //                                        {
        //                                            context.Entry(obj).State = System.Data.EntityState.Deleted;
        //                                        }
        //                                        context.SaveChanges();

        //                                        var objTimeSheetWeek = context.TimeSheetWeeklies.Where(t => t.TimeSheetWeeklyID == Wid).FirstOrDefault();
        //                                        objTimeSheetWeek.FinalStatus = 0;
        //                                        context.Entry(objTimeSheetWeek).State = System.Data.EntityState.Modified;
        //                                        context.SaveChanges();
        //                                    }
        //                                }
        //                                ts.Complete();
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                ts.Dispose();
        //                            }
        //                        }
        //                    }

        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return res;
        //}
    }
}
