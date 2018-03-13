using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectListReportRepository : IBLProjectListReportRepository
    {
         public static IList<usp_getTaskMilestoneTargetDates_Result> getTaskMilestoneTargetDatesByProjectID(int ProjectID)
        {
            IList<usp_getTaskMilestoneTargetDates_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskMilestoneTargetDates(ProjectID).ToList<usp_getTaskMilestoneTargetDates_Result>();
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
        
        public IList<usp_MY_ProjectTaskList_Result> FetchMyProjectList(int UserID)
        {
            IList<usp_MY_ProjectTaskList_Result> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.usp_MY_ProjectTaskList(UserID, Convert.ToInt32(Common.TaskStatusID.TaskAssigned),Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_MY_ProjectTaskList_Result>();
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
            return List;
        }
        public IList<usp_ProjectListForResourceList_Result> FetchProjectListForResourceList(int UserID)
        {
            IList<usp_ProjectListForResourceList_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_ProjectListForResourceList(UserID, Convert.ToInt32(Common.ResourceRequestStatusID.Closed),Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_ProjectListForResourceList_Result>();
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
        public IList<usp_getAllottedVsConsumedHoursOfProject_Result> GetAllottedVsConsumedHoursOfProject(int ProjectID)
        {
            IList<usp_getAllottedVsConsumedHoursOfProject_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getAllottedVsConsumedHoursOfProject(ProjectID).ToList<usp_getAllottedVsConsumedHoursOfProject_Result>();
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
       
        public List<usp_getTaskRecordByID_Result> getSPTaskRecordByID(int taskID)
        {
            List<usp_getTaskRecordByID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskRecordByID(taskID).ToList<usp_getTaskRecordByID_Result>(); ;
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

        public int transferTask(int taskID, DateTime fromDate, DateTime toDate, int transferFrom, int transferTo, int userID)
        {
            int result = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    result = context.usp_TransferTask(taskID, transferFrom, transferTo, fromDate, toDate, userID);
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
            return result;
        }

        public int UnlockProgressSheet(int taskID, int UserID)
        {
            int result = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    result = context.usp_UnlockProgressSheet(taskID, Convert.ToInt32(Common.ProgressSheetStatus.Submit), UserID);
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
            return result;
        }

        //public int cancelTask(int taskID,ScopeChange objScopeType, int UserID)
        //{
        //    int result = 0;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            result = context.usp_CancelTask(taskID, objScopeType.ScopeCode, objScopeType.ScopeChangeID, objScopeType.Title, objScopeType.Reason, objScopeType.Description, objScopeType.ProjectID, objScopeType.ScopeChangeID, Convert.ToInt32(Common.TaskStatusID.Cancelled),UserID);
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
        //    return result;
        //}

    
        public string getOwnerPeriod(int userID, int TaskID)
        {
            string result = "";
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    result = context.usp_getOwnerPeriod(TaskID, userID).FirstOrDefault().ToString();
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
            return result;
        }


        public static IList<usp_ProjectListForTaskProgressLevel_Result> FetchProjectListForTaskProgressLevel(int UserID)
        {
            IList<usp_ProjectListForTaskProgressLevel_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_ProjectListForTaskProgressLevel(UserID, Convert.ToInt32(Common.ResourceRequestStatusID.Closed),Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_ProjectListForTaskProgressLevel_Result>();
                
                //}
                list = list.Where(a => a.ProjectName != "No Project Selected").ToList();
            }
            catch (Exception ex)
            {
            }
            return list;

        }

        public static IList<usp_ProjectProjectTaskList_Report_Result> Fetch(int Userid)
        {
            IList<usp_ProjectProjectTaskList_Report_Result> List = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    List = db.usp_ProjectProjectTaskList_Report(Userid, Convert.ToInt32(Common.ResourceRequestStatusID.Closed),Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_ProjectProjectTaskList_Report_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return List;
        }
        
    }
}
