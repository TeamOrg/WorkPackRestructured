using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDeliverableListRepository : IBLDeliverableListRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectTaskList> _deliverableList;

        public BLDeliverableListRepository(WorkpackDBContext context, IGenericDataRepository<ProjectTaskList> deliverableList)
        {
            _context = context;
            _deliverableList = deliverableList;
        }


        public IList<ProjectTaskList> GetAllUploadDeliverableFile()
        {
            return _deliverableList.GetAll();
        }
        public ProjectTaskList GetDeliverableListByID(int deliverableListID)
        {
            return _deliverableList.GetSingle(d => d.ProjectTaskID == deliverableListID);
        }
        public void AddDeliverableList(params ProjectTaskList[] deliverableList)
        {
            try
            {
                _deliverableList.Add(deliverableList);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public IList<usp_getActivityLogByDelID_Result> getActivityLogByDelID(string DelID)
        {
            IList<usp_getActivityLogByDelID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getActivityLogByDelID(Convert.ToInt32(DelID)).ToList<usp_getActivityLogByDelID_Result>();
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
    
        public void UpdateDeliverableList(params ProjectTaskList[] deliverableList)
        {
            try
            {
                _deliverableList.Update(deliverableList);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDeliverableList(params ProjectTaskList[] deliverableList)
        {
            try
            {
                _deliverableList.Remove(deliverableList);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }


        public List<usp_getAllRevisionByProjectID_Result> getAllRevisionByDeliverableID(int DeliverableID,int DeliverableTypeID)
        {
            List<usp_getAllRevisionByProjectID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //   // int TaskstatusID = Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint);
                //   var lst= context.usp_getAllRevisionByProjectID(DeliverableID, DeliverableTypeID).ToList<usp_getAllRevisionByProjectID_Result>();
                //   list = (from a in lst where a.RevisionID == 0 orderby a.MilestoneID select a).ToList();
                //   foreach (var l in (from l in lst where l.RevisionID > 0 orderby l.RevisionID select l).ToList())
                //   {
                //       list.Add(l);
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
            return list;
        }

        public List<usp_getAllRevisionByProjectID_Result> getDeliverableTypeByDeliverableID(int DeliverableID, int DeliverableTypeID)
        {
            List<usp_getAllRevisionByProjectID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    // int TaskstatusID = Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint);
                //    var lst = context.usp_getAllRevisionByProjectID(DeliverableID, DeliverableTypeID).ToList<usp_getAllRevisionByProjectID_Result>();
                //    list = (from a in lst where a.RevisionID == 0 orderby a.MilestoneID select a).ToList();
                //    foreach (var l in (from l in lst where l.RevisionID > 0 orderby l.RevisionID select l).ToList())
                //    {
                //        list.Add(l);
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
            return list;
        }

        public List<usp_getAllRevisionByProjectIDForDropDown_Result> getAllRevisionByDeliverableIDForDropDown(int DeliverableID, int DeliverableTypeID)
        {
            List<usp_getAllRevisionByProjectIDForDropDown_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    // int TaskstatusID = Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint);
                //    var lst = context.usp_getAllRevisionByProjectIDForDropDown(DeliverableID, DeliverableTypeID).ToList<usp_getAllRevisionByProjectIDForDropDown_Result>();
                //    list = (from a in lst where a.RevisionID == 0 orderby a.MilestoneID select a).ToList();
                //    foreach (var l in (from l in lst where l.RevisionID > 0 orderby l.RevisionID select l).ToList())
                //    {
                //        list.Add(l);
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
            return list;
        }

        public static bool UpdateTaskStatusByRequestID(int RequestID, int StatusID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var ProjectTasklist = from a in context.ProjectTaskLists where a.ResourceRequestID == RequestID select a;
                //    foreach (var val in ProjectTasklist)
                //    {
                //        val.TaskStatus = StatusID;
                //        context.Entry(val).State = System.Data.EntityState.Modified;
                //    }
                //    context.SaveChanges();
                //    res = true;
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
        
        public int GetLockCountForProjectList(int ProjectID)
        {
            int res = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && a.LOCK == 1 select a).Count();
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
        //public IList<usp_getTaskDetailsByProjectID_Result> getTaskDetails(int ProjectID)
        //{
        //    IList<usp_getTaskDetailsByProjectID_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            int TaskstatusID=Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint);
        //            list = context.usp_getTaskDetailsByProjectID(ProjectID, TaskstatusID).ToList<usp_getTaskDetailsByProjectID_Result>();
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
        public bool deleteTaskById(int DeliverableListID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var val = context.usp_deleteTaskListByID(DeliverableListID).FirstOrDefault();
                //    if (val == 0)
                //        res = true;
                //}
            }
            catch (Exception ex)
            {                res = false;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
           
        }
        public static Boolean UpdateTaskStatus(int TaskID, int StatusID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    ProjectTaskList ptl = (from a in context.ProjectTaskLists where a.ProjectTaskID == TaskID select a).FirstOrDefault();
                //    ptl.TaskStatus = StatusID;
                //    context.Entry(ptl).State = System.Data.EntityState.Modified;
                //    context.SaveChanges();
                //    res = true;
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
       
        public int GetTaskIDByTaskObjectID(int TaskObjectID, int ProjectID)
        {
            int res = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && a.TaskObjectID == TaskObjectID select a.ProjectTaskID).FirstOrDefault();
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
        public static Boolean SaveTaskDependencyList(List<TaskDependency> list)
        {
            Boolean res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    foreach (var a in list)
                //    {
                //        db.Entry(a).State = System.Data.EntityState.Added;
                //    }
                //    db.SaveChanges();
                //    res = true;
                //}
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        //public static Boolean saveProjectTaskListP6(string xmlTasks, int ProjectID, string xmlTaskDependency, int statusID,string xmlWBSList)
        //{
        //    Boolean res = false;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
                    
        //            res = context.usp_saveProjectTaskListP6(xmlTasks, ProjectID, xmlTaskDependency, statusID, xmlWBSList).SingleOrDefault() > 0 ? true : false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return res;
        //}

        public IList<usp_getDeliverableTaskByUserID_Result> getDeliverableTaskByUserID(string UserID,int Deliverablelst, Int32 TaskAssignedStatusID)
        {
            IList<usp_getDeliverableTaskByUserID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    ((System.Data.Entity.Infrastructure.IObjectContextAdapter)context).ObjectContext.CommandTimeout = 0;
                //    list = context.usp_getDeliverableTaskByUserID(Convert.ToString(UserID), TaskAssignedStatusID, Deliverablelst).ToList<usp_getDeliverableTaskByUserID_Result>();
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


        public IList<usp_UserActivityTracker_Result> getUserActivityTracker()
        {
            IList<usp_UserActivityTracker_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_UserActivityTracker().ToList<usp_UserActivityTracker_Result>();
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


        public static List<object> getUserActivityTrackerObj()
        {
            List<usp_UserActivityTracker_Result> lst = null;       

            List<object> list = null;       
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_UserActivityTracker().ToList<usp_UserActivityTracker_Result>();
                //    list = (from p in lst
                //            select new { UserID = p.UserName, UserName = p.UserName }).Distinct().ToList<object>();
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


        public IList<usp_getDeliverableListReportByProjectID_Result> getUpLoadFilesReportByUserID(int UserID)
        {
            IList<usp_getDeliverableListReportByProjectID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getDeliverableListReportByProjectID(UserID).ToList<usp_getDeliverableListReportByProjectID_Result>();
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

        public ProjectTaskList getTaskDetailsByTaskId(int DeliverableListID)
        {
            ProjectTaskList objTask = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    objTask = context.ProjectTaskLists.FirstOrDefault(p => p.ProjectTaskID == DeliverableListID);
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
            return objTask;
        }
        public IList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result> getTaskMilestoneTargetDatesByTask(int DeliverableListID)
        {
            IList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_TaskMilestoneTargetDatesByProjectTaskID(DeliverableListID).ToList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result>();
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
        public IList<VW_MYTASK> GetMyTask(VW_MYTASK objTask, int ProjectId)
        {
            IList<VW_MYTASK> list = null;
            //int TaskStatusID=Convert.ToInt32(Common.TaskStatusID.Cancelled);
            //int AcceptID=Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner);
            //int TaskOwnerId=Convert.ToInt32( HttpContext.Current.Session["UserId"]);
            //try
            //{//DateTime.MinValue
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        IQueryable<VW_MYTASK> query = context.VW_MYTASK;
            //       query= query.Where(p => p.ProjectID == ProjectId && p.TaskStatusID != TaskStatusID && p.TaskStatusID < AcceptID && p.TaskOwner == TaskOwnerId);
            //       if (objTask.ProjectName != string.Empty)
            //           query = query.Where(p => p.ProjectName.ToUpper().Contains(objTask.ProjectName.ToUpper()));
            //       if (objTask.TaskStatus != "0")
            //           query = query.Where(p => p.TaskStatus.Equals(objTask.TaskStatus));
            //        if(objTask.StartDate!=DateTime.MinValue && objTask.EndDate!=DateTime.MinValue)                   
            //            query = query.Where(p => p.StartDate>=objTask.StartDate && p.EndDate<=objTask.EndDate);
            //        list = query.ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return list;
        }     
       
        public IList<usp_getMileStoneDetails_Report_Result> getMileStoneDetailsByProjectID_Report(int ProjectID)
        {
            IList<usp_getMileStoneDetails_Report_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getMileStoneDetails_Report(ProjectID).ToList<usp_getMileStoneDetails_Report_Result>();
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
        
        public static string  GetProjectCode(int taskID)
        {

            string res = "";
                try{
                    //using (var db = new Cubicle_EntityEntities())
                    //{
                    //    var val = from p in db.Projects where p.ProjectID == (from t in db.ProjectTaskLists where t.ProjectTaskID == taskID select t.ProjectID).FirstOrDefault() select p.ProjectCode;
                    //    res = val.FirstOrDefault().ToString();
                    //}
                }
            catch(Exception ex){
            }
            return res;
           
        }

    

        public static Int32 GetMaxID(int projectID)
        {            
            Int32 iMaxTaskID = 0; 
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = db.ProjectTaskLists.Max(p => p.ProjectTaskID);
                //    iMaxTaskID = val;
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
            return iMaxTaskID;
        }

        public static IList<ProjectTaskList> GetProjectTaskList(DateTime Month, int DeptID, int DesigID, int ProjectID)
        {
            IList<ProjectTaskList> list = null;
            DateTime fDate = new DateTime(Month.Year, Month.Month, 1);
            DateTime eDate = fDate.AddMonths(1).AddDays(-1);
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            where pt.StartDate >= fDate.Date && pt.EndDate <= eDate.Date
                //               && pt.DepatmentID == (DeptID == 0 ? pt.DepatmentID : DeptID)
                //               && pt.DesignationID == (DesigID == 0 ? pt.DesignationID : DesigID)
                //               && pt.ProjectID == (ProjectID == 0 ? pt.ProjectID : ProjectID)
                //            select pt).ToList<ProjectTaskList>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static Decimal GetRequiredMilestoneHrsByPeriod(ProjectTaskList Task, DateTime Month)
        {
            //DataTable dt = null;
            //DateTime StartDate = new DateTime(Month.Year, Month.Month, 1).Date;
            //DateTime EndDate = StartDate.AddMonths(1).AddDays(-1).Date;
            decimal TotalHrsInPeriodPerTask = 0.00M;
            //try
            //{
            //    dt = new DataTable();
            //    dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            //    dt.Columns.Add(new DataColumn("ProgressLevel", typeof(string)));
            //    dt.Columns.Add(new DataColumn("Weightage", typeof(decimal)));
            //    dt.Columns.Add(new DataColumn("WorkingDays", typeof(int)));
            //    dt.Columns.Add(new DataColumn("WDayPrgressPerDay", typeof(decimal)));
            //    dt.Columns.Add(new DataColumn("HrsRequiredPerDay", typeof(decimal)));
            //    dt.Columns.Add(new DataColumn("HrsRequiredPerPeriod", typeof(decimal)));
            //    dt.Columns["HrsRequiredPerPeriod"].DefaultValue = 0.0;
            //    using (var db = new Cubicle_EntityEntities())
            //    {
            //        var FirstMilestone = (from tt in
            //                                  (
            //                                      ((
            //                                      from PT in db.ProjectTaskLists
            //                                      where
            //                                        PT.ProjectTaskID == Task.ProjectTaskID
            //                                      select new
            //                                      {
            //                                          dat = (DateTime?)PT.StartDate,
            //                                          MileStone = "Start",
            //                                          Weightage = (Decimal?)0
            //                                      }
            //                                      )
            //                                      .Union
            //                                      (
            //                                      from PT in db.ProjectTaskLists
            //                                      join TMT in db.TaskMilestoneTargetDates on new { DeliverableListID = PT.ProjectTaskID } equals new { DeliverableListID = TMT.TaskID }
            //                                      join PM in db.ProjectMilestones on new { MileStoneID = TMT.MileStoneID } equals new { MileStoneID = PM.ProjectMilestoneID }
            //                                      where
            //                                        PT.ProjectTaskID == Task.ProjectTaskID
            //                                      select new
            //                                      {
            //                                          dat = (DateTime?)TMT.TaskMilestoneTargetDates,
            //                                          MileStone = PM.MileStone,
            //                                          Weightage = (Decimal?)PM.Weightage
            //                                      }
            //                                      )
            //                                      .Union
            //                                      (
            //                                      from PT in db.ProjectTaskLists
            //                                      where
            //                                        PT.ProjectTaskID == Task.ProjectTaskID
            //                                      select new
            //                                      {
            //                                          dat = (DateTime?)PT.EndDate,
            //                                          MileStone = "End",
            //                                          Weightage = (Decimal?)100
            //                                      }
            //                                      )))
            //                              where
            //                                tt.dat < StartDate
            //                              orderby
            //                                tt.dat descending
            //                              select new
            //                              {
            //                                  tt.dat,
            //                                  tt.MileStone,
            //                                  tt.Weightage
            //                              }).Take(1);

            //        var SecondMilestoneList = from tt in
            //                                      (
            //                                          ((
            //                                          from PT in db.ProjectTaskLists
            //                                          where
            //                                            PT.ProjectTaskID == Task.ProjectTaskID
            //                                          select new
            //                                          {
            //                                              dat = (DateTime?)PT.StartDate,
            //                                              MileStone = "Start",
            //                                              Weightage = (Decimal?)0
            //                                          }
            //                                          ).Union
            //                                          (
            //                                          from PT in db.ProjectTaskLists
            //                                          join TMT in db.TaskMilestoneTargetDates on new { DeliverableListID = PT.ProjectTaskID } equals new { DeliverableListID = TMT.TaskID }
            //                                          join PM in db.ProjectMilestones on new { MileStoneID = TMT.MileStoneID } equals new { MileStoneID = PM.ProjectMilestoneID }
            //                                          where
            //                                            PT.ProjectTaskID == Task.ProjectTaskID
            //                                          select new
            //                                          {
            //                                              dat = (DateTime?)TMT.TaskMilestoneTargetDates,
            //                                              MileStone = PM.MileStone,
            //                                              Weightage = (Decimal?)PM.Weightage
            //                                          }
            //                                          ).Union
            //                                          (
            //                                          from PT in db.ProjectTaskLists
            //                                          where
            //                                            PT.ProjectTaskID == Task.ProjectTaskID
            //                                          select new
            //                                          {
            //                                              dat = (DateTime?)PT.EndDate,
            //                                              MileStone = "End",
            //                                              Weightage = (Decimal?)100
            //                                          }
            //                                          )))
            //                                  where
            //                                    tt.dat >= StartDate && tt.dat <= EndDate
            //                                  orderby
            //                                    tt.dat
            //                                  select new
            //                                  {
            //                                      tt.dat,
            //                                      tt.MileStone,
            //                                      tt.Weightage
            //                                  };


            //        var ThiredMileStoneList = (from tt in
            //                                       (
            //                                           ((
            //                                           from PT in db.ProjectTaskLists
            //                                           where
            //                                             PT.ProjectTaskID == Task.ProjectTaskID
            //                                           select new
            //                                           {
            //                                               dat = (DateTime?)PT.StartDate,
            //                                               MileStone = "Start",
            //                                               Weightage = (Decimal?)0
            //                                           }
            //                                           ).Union
            //                                           (
            //                                           from PT in db.ProjectTaskLists
            //                                           join TMT in db.TaskMilestoneTargetDates on new { DeliverableListID = PT.ProjectTaskID } equals new { DeliverableListID = TMT.TaskID }
            //                                           join PM in db.ProjectMilestones on new { MileStoneID = TMT.MileStoneID } equals new { MileStoneID = PM.ProjectMilestoneID }
            //                                           where
            //                                             PT.ProjectTaskID == 485
            //                                           select new
            //                                           {
            //                                               dat = (DateTime?)TMT.TaskMilestoneTargetDates,
            //                                               MileStone = PM.MileStone,
            //                                               Weightage = (Decimal?)PM.Weightage
            //                                           }
            //                                           ).Union
            //                                           (
            //                                           from PT in db.ProjectTaskLists
            //                                           where
            //                                             PT.ProjectTaskID == Task.ProjectTaskID
            //                                           select new
            //                                           {
            //                                               dat = (DateTime?)PT.EndDate,
            //                                               MileStone = "End",
            //                                               Weightage = (Decimal?)100
            //                                           }
            //                                           )))
            //                                   where
            //                                     tt.dat > EndDate
            //                                   orderby
            //                                     tt.dat
            //                                   select new
            //                                   {
            //                                       tt.dat,
            //                                       tt.MileStone,
            //                                       tt.Weightage
            //                                   }).Take(1);
            //        foreach (var a in FirstMilestone)
            //        {
            //            DataRow dr = dt.NewRow();
            //            dr[0] = a.dat;
            //            dr[1] = a.MileStone;
            //            dr[2] = a.Weightage;
            //            dt.Rows.Add(dr);
            //        }
            //        foreach (var a in SecondMilestoneList)
            //        {
            //            DataRow dr = dt.NewRow();
            //            dr[0] = a.dat;
            //            dr[1] = a.MileStone;
            //            dr[2] = a.Weightage;
            //            dt.Rows.Add(dr);
            //        }
            //        foreach (var a in ThiredMileStoneList)
            //        {
            //            DataRow dr = dt.NewRow();
            //            dr[0] = a.dat;
            //            dr[1] = a.MileStone;
            //            dr[2] = a.Weightage;
            //            dt.Rows.Add(dr);
            //        }

            //        for (int i = 1; i < dt.Rows.Count; i++)
            //        {
            //            int HrsRequiredPerPeriod = BLDailyWorkingHrRepository.NormalWorkingDaysPerPeriod(Convert.ToDateTime(dt.Rows[i - 1][0]), Convert.ToDateTime(dt.Rows[i][0]));
            //            dt.Rows[i][3] = HrsRequiredPerPeriod;
            //            if (HrsRequiredPerPeriod == 0)
            //            {
            //                dt.Rows[i][4] = 0;
            //                dt.Rows[i][5] = 0;
            //            }
            //            else
            //            {

            //                //Per working day progress=(diff of progress level/No of working days
            //                dt.Rows[i][4] = ((Convert.ToDecimal(dt.Rows[i][2]) - Convert.ToDecimal(dt.Rows[i - 1][2])) / Convert.ToDecimal(HrsRequiredPerPeriod));
            //                //Hours required per day=(Per working day progress*Task Allotted hrs)/100
            //                dt.Rows[i][5] = (Convert.ToDecimal(dt.Rows[i][4]) * Task.AllottedHours)/100;
            //            }
            //            if (i == 1)
            //            {
            //                if (Convert.ToString(dt.Rows[i - 1]["ProgressLevel"]).ToUpper() == "START")
            //                {
            //                    if (Convert.ToDateTime(dt.Rows[i - 1]["Date"]).Month != StartDate.Month)
            //                    {
            //                        dt.Rows[i - 1]["Date"] = StartDate;
            //                    }
            //                }
            //                else
            //                {
            //                    dt.Rows[i - 1]["Date"] = StartDate;
            //                }
            //                HrsRequiredPerPeriod = BLDailyWorkingHrRepository.NormalWorkingDaysPerPeriod(Convert.ToDateTime(dt.Rows[i - 1][0]), Convert.ToDateTime(dt.Rows[i][0]));
            //            }
            //            if (i == dt.Rows.Count - 1)
            //            {
            //                if (Convert.ToString(dt.Rows[i]["ProgressLevel"]).ToUpper() == "END")
            //                {
            //                    if (Convert.ToDateTime(dt.Rows[i]["Date"]).Month != EndDate.Month)
            //                    {
            //                        dt.Rows[i]["Date"] = EndDate;
            //                    }
            //                }
            //                else
            //                {
            //                    dt.Rows[i]["Date"] = EndDate;
            //                }
            //                HrsRequiredPerPeriod = BLDailyWorkingHrRepository.NormalWorkingDaysPerPeriod(Convert.ToDateTime(dt.Rows[i - 1][0]), Convert.ToDateTime(dt.Rows[i][0]));
            //            }
            //            dt.Rows[i]["HrsRequiredPerPeriod"] = Convert.ToDecimal(HrsRequiredPerPeriod) * Convert.ToDecimal(dt.Rows[i]["HrsRequiredPerDay"]);
            //        }

            //    }

            //    TotalHrsInPeriodPerTask = dt.AsEnumerable().Sum(x => x.Field<decimal>("HrsRequiredPerPeriod"));
            //}
            //catch (Exception ex)
            //{
            //}
            //finally
            //{
            //    if ((dt == null) == false)
            //        dt = null;
            //}
            return TotalHrsInPeriodPerTask;
        }

        public static IList<Department> GetDepartmentsByProject(int ProjectID)
        {
            IList<Department> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            join
                //                d in db.Departments on pt.DepatmentID equals d.DepartmentID
                //            where pt.ProjectID == ProjectID
                //            select d).Distinct().ToList<Department>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static IList<Designation> GetDesignationByProject(int ProjectID, int Dept)
        {
            IList<Designation> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            join
                //                d in db.Designations on pt.DesignationID equals d.DesignationID
                //            where pt.ProjectID == ProjectID && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept)
                //            select d).Distinct().ToList<Designation>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static IList<ProjectTaskList> GetTaskListByProjectID(int ProjectID, int Dept, int Desig)
        {
            IList<ProjectTaskList> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from t in db.ProjectTaskLists where t.ProjectID == ProjectID && t.DepatmentID == (Dept == 0 ? t.DepatmentID : Dept) && t.DesignationID == (Desig == 0 ? t.DesignationID : Desig) select t).ToList<ProjectTaskList>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static IList<TaskType> GetTaskListByCompanyID(int CompanyID)
        {
            IList<TaskType> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.TaskTypes.Where(a=>a.CompanyId == CompanyID).ToList<TaskType>();
                    
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static IList<ProjectMilestone> GetMileStoneListByProjectID(int ProjectID)
        {
            IList<ProjectMilestone> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.ProjectMilestones.Where(a => a.ProjectID == ProjectID).ToList<ProjectMilestone>();                 
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }


        public static IList<ProjectMilestone> GetAllMileStoneList()
        {
            List<ProjectMilestone> list = null;
         
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.ProjectMilestones.ToList<ProjectMilestone>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static IList<RevisionFile> GetRevisionListByProjectID(int ProjectID)
        {

            List<RevisionFile> list = null;
            List<int> lstDelId = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstDelId = db.ProjectTaskLists.Where(a => a.ProjectID == ProjectID).Select(a => a.ProjectTaskID).ToList<int>();

                //    list = db.RevisionFiles.Where(a => lstDelId.Contains((Int32)a.DeliverableID)).ToList<RevisionFile>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }





        //Project Burn chart Planced Progress in period

        public static List<DateTime> GetProjectStartEndDates(int ProjectID, int Dept, int Desig, int TaskId)
        {
            List<DateTime> list = null;
            try
            {
                list = new List<DateTime>();
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = (from pt in
                //                   (from ptl in db.ProjectTaskLists
                //                    where
                //                      ptl.ProjectID == ProjectID && ptl.DepatmentID == (Dept == 0 ? ptl.DepatmentID : Dept)
                //                      && ptl.DesignationID == (Desig == 0 ? ptl.DesignationID : Desig)
                //                      && ptl.ProjectTaskID == (TaskId == 0 ? ptl.ProjectTaskID : TaskId)
                //                    select new
                //                    {
                //                        ptl.StartDate,
                //                        ptl.EndDate,
                //                        Dummy = "x"
                //                    })
                //               group pt by new { pt.Dummy } into g
                //               select new
                //               {
                //                   Column1 = (DateTime?)g.Min(p => p.StartDate),
                //                   Column2 = (DateTime?)g.Max(p => p.EndDate)
                //               });
                //    foreach (var a in val)
                //    {
                //        list.Add(a.Column1.GetValueOrDefault());
                //        list.Add(a.Column2.GetValueOrDefault());
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public static IList<ProjectTaskList> GetTaskListByProjectID_Date(int ProjectID, int Dept, int Desig, int Taskid, DateTime period)
        {
            IList<ProjectTaskList> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            where pt.ProjectID == ProjectID
                //            && (pt.StartDate <= period && pt.EndDate >= period)
                //            && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept)
                //                     && pt.DesignationID == (Desig == 0 ? pt.DesignationID : Desig)
                //                     && pt.ProjectTaskID == (Taskid == 0 ? pt.ProjectTaskID : Taskid)
                //            select pt).ToList<ProjectTaskList>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public bool saveDeliverable(string data)
        {
           // using (TransactionScope ts = new TransactionScope())
                //{
                //    try
                //    {
                //        string[] arr = data.Split('?');
                //        string[] arrDeliverable = arr[0].Split(';');
                //        string[] arrTargetMile = arr[1].Split(';');
                //        CultureInfo ci = new CultureInfo("en-Gb");
                //        string LoggedInUserID = "";
                //        BLDeliverableListRepository blDel = new BLDeliverableListRepository();
                //        BLTaskMilestoneTargetDates blTT = new BLTaskMilestoneTargetDates();
                //        int DeliverableID = arrDeliverable[0].Contains("DeliverableID") ? Convert.ToInt32(arrDeliverable[0].Split(':')[1]) : 0;
                //        ProjectTaskList del = blDel.GetDeliverableListByID(DeliverableID);
                //        List<TaskMilestoneTargetDate> TTlst = new List<TaskMilestoneTargetDate>();
                //        int TaskTypeId = 0;
                //        string ModuleID = "0";
                //        if (DeliverableID > 0)
                //        {
                //            //List<TaskMilestoneTargetDate> lstTT = blTT.GetAllTaskMilestoneTargetDateByDeliverableID(DeliverableID);
                //            del.EntityState = DominModel.EntityState.Modified;
                //            for (int i = 0; i < arrDeliverable.Length; i++)
                //            {
                //                if (arrDeliverable[i].Contains(":"))
                //                {
                //                    string[] arrIn = arrDeliverable[i].Split(':');
                //                    if (arrIn[0].Contains("Title"))
                //                    {
                //                        if (arrIn[1].Trim().Length > 0)
                //                        {
                //                            del.TaskName = arrIn[1].Trim();
                //                        }
                //                    }
                //                    if (arrIn[0].Contains("DeliverableType"))
                //                    {
                //                        if (arrIn[1].Trim() != "")
                //                        {
                //                            del.TaskTypeID = Convert.ToInt32(arrIn[1]);
                //                            TaskTypeId = Convert.ToInt32(arrIn[1]);
                //                        }
                //                    }
                //                    if (arrIn[0].Contains("Department"))
                //                    {
                //                        if (arrIn[1].Trim() != "")
                //                        {
                //                            del.DepatmentID = Convert.ToInt32(arrIn[1]);
                //                        }
                //                    }
                //                    if (arrIn[0].Contains("DelNumber"))
                //                    {
                //                        if (arrIn[1].Trim().Length > 0)
                //                        {
                //                            del.DeliverableNo = Convert.ToString(arrIn[1].Trim());
                //                        }
                //                    }
                //                    if (arrIn[0].Contains("Owner"))
                //                    {
                //                        if (arrIn[1].Trim() != "")
                //                        {
                //                            del.TaskOwner = Convert.ToInt32(arrIn[1]);
                //                        }
                //                    }
                //                    if (arrIn[0].Contains("ClientDelNo"))
                //                    {
                //                        del.ClientDeliverableNo = arrIn[1];
                //                    }
                //                    if (arrIn[0].Contains("ModuleID"))
                //                    {
                //                        ModuleID = arrIn[1];
                //                    }
                //                    if (arrIn[0].Contains("LoggedInUserID"))
                //                    {
                //                        LoggedInUserID = arrIn[1];
                //                    }
                //                }
                //            }

                //            //for (int i = 0; i < arrTargetMile.Length; i++)
                //            //{
                //            //    string[] arrIn = arrTargetMile[i].Split(':');
                //            //    if (arrIn[0] != "" && arrIn[1] != "")
                //            //    {
                //            //        int ID = Convert.ToInt32(arrIn[0]);
                //            //        DateTime dt = Convert.ToDateTime(arrIn[1], ci);
                //            //        if (ID > 0)
                //            //        {
                //            //            TaskMilestoneTargetDate tts = new TaskMilestoneTargetDate();

                //            //            tts.TaskID = DeliverableID;
                //            //            tts.TaskTypeID = TaskTypeId;
                //            //            tts.MileStoneID = ID;
                //            //            tts.TaskMilestoneTargetDates = dt;
                //            //            tts.EntityState = DominModel.EntityState.Added;
                //            //            TTlst.Add(tts);
                //            //        }
                //            //        else
                //            //        {
                //            //            if (ID == 0)
                //            //            {
                //            //                del.StartDate = dt;
                //            //            }
                //            //            else if (ID == -1)
                //            //            {
                //            //                del.EndDate = dt;
                //            //            }
                //            //        }
                //            //    }
                //            //    else if(arrIn[0] != "")
                //            //    {
                //            //        int ID = Convert.ToInt32(arrIn[0]);
                //            //        //if (ID == 0)
                //            //        //{
                //            //        //    del.StartDate =null;
                //            //        //}
                //            //        //else if (ID == -1)
                //            //        //{
                //            //        //    del.EndDate = null;
                //            //        //}
                //            //    }
                //            //}

                //            var OldDel = GetDeliverableListByID(DeliverableID);
                //            Boolean ChangeTaskOwner = false;
                //            string UserList = "";
                //            if (OldDel.TaskOwner != del.TaskOwner)
                //            {
                //                ChangeTaskOwner = true;
                //                UserList = Convert.ToString(del.TaskOwner) + "," + Convert.ToString(OldDel.TaskOwner);
                //            }
                //            blDel.UpdateDeliverableList(del);
                //            if (ChangeTaskOwner == true)
                //            {
                //                var val = SendNotificationForTaskOwnerChange(DeliverableID, UserList, Convert.ToInt32(ModuleID), Convert.ToInt32(LoggedInUserID));
                //            }
                //            //foreach (var item in lstTT)
                //            //{
                //            //    item.EntityState = DominModel.EntityState.Deleted;
                //            //}
                //            //blTT.RemoveTaskMilestoneTargetDates(lstTT.ToArray());
                //            //blTT.AddTaskMilestoneTargetDates(TTlst.ToArray());
                //        }
                //        ts.Complete();
                //        return true;
                //    }
                //    catch (Exception ex)
                //    {
                //        ts.Dispose();
                //        return false;
                //    }
                //}

                return false;

        }

        public Boolean SendNotificationForTaskOwnerChange(int DelID, string NotfUserID,int ModuleID,int loggedInUser)
        {
            Boolean res = false;
            //BLMessageRepository blMes = new BLMessageRepository();
            //BLUserRepository bluser = new BLUserRepository();
            //BLDeliverableListRepository bldel = new BLDeliverableListRepository();
           // BLProjectCreationRepository blProject=new BLProjectCreationRepository();
          
                try
                {
                    string[] arrUserID = NotfUserID.TrimEnd(',').Split(',');
                    //if (arrUserID.Length == 2)
                    //{
                    //    var Nuser = bluser.GetuserByID(Convert.ToInt32(arrUserID[0]));
                    //    var Ouser = bluser.GetuserByID(Convert.ToInt32(arrUserID[1]));
                    //    var del = bldel.GetDeliverableListByID(DelID);
                    //    var project=blProject.GetProjectByID(del.ProjectID);
                    //    for (int j = 0; j < arrUserID.Length; j++)
                    //    {
                    //        if (arrUserID[j] != "")
                    //        {
                    //            Message lstM = new Message();
                    //            //lstM.FromUserID = Convert.ToInt32(loggedInUser);
                    //            //lstM.ToUserID = Convert.ToInt32(arrUserID[j]);
                    //            lstM.FromUserID = Convert.ToString(loggedInUser);
                    //            lstM.ToUserID = Convert.ToString(arrUserID[j]);
                    //            lstM.Message1 = Common.MessageConstants.transferredTaskOwner.Replace("#DeliverableNo#", Convert.ToString(del.DeliverableNo)).Replace("#DeliverableName#", del.TaskName).Replace("#NewOwner#", Nuser.FirstName + " " + Nuser.LastName).Replace("#OldOwner#", Ouser.FirstName + " " + Ouser.LastName);
                    //            lstM.RedirectURL = "UploadDeliverables.aspx";
                    //            lstM.QueryString = "DeliverableID=" + Convert.ToSingle(DelID)+"&ModuleID="+Convert.ToString(ModuleID);
                    //            lstM.MessageFor = "TransferredDeliverableOwner";
                    //            lstM.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                    //            lstM.Active = "Y";
                    //            lstM.MessageType = "N";
                    //            lstM.Date = DateTime.Now;
                    //            lstM.EntityState = DominModel.EntityState.Added;
                    //            blMes.AddMessage(lstM);

                    //            BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();

                    //            MessageTemplate mst = blmt.GetMessageTemplateByMessage(Common.MessageConstants.transferredTaskOwner);

                    //            if (mst.IsEmail == true)
                    //            {

                    //                blmt.SendNotification(Convert.ToInt32(loggedInUser), lstM.Message1, Convert.ToInt32(arrUserID[j]));
                    //            }
                    //        }
                    //    }                       
                    //    res = true;
                    //}
                }
                catch (Exception ex)
                {
                    
                }
            
            return res;
        }
    
      
        public IList<Department> GetAllInvolvedDepartments(int ClientId, int ClientAsset, int ProjectID)
        {
            IList<Department> list = null;
            try
            {
                string VClientId = Convert.ToString(ClientId);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = ((from pt in db.ProjectTaskLists
                //             join p in db.Projects on pt.ProjectID equals p.ProjectID
                //             join d in db.Departments on pt.DepatmentID equals d.DepartmentID
                //             where p.ClientCode == (ClientId == 0 ? p.ClientCode : VClientId) && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset) && pt.ProjectID == (ProjectID == 0 ? pt.ProjectID : ProjectID)
                //             select d).Distinct()).ToList<Department>(); 
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public IList<Designation> GetAllInvolvedDesignations(int ClientId, int ClientAsset, int ProjectID)
        {
            IList<Designation> list = null;
            try
            {
                string VClientId = Convert.ToString(ClientId);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = ((from pt in db.ProjectTaskLists
                //             join p in db.Projects on pt.ProjectID equals p.ProjectID
                //             join d in db.Designations on pt.DesignationID equals d.DesignationID
                //             where p.ClientCode == (ClientId == 0 ? p.ClientCode : VClientId) && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset) && pt.ProjectID == (ProjectID == 0 ? pt.ProjectID : ProjectID)
                //             select d).Distinct()).ToList<Designation>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public IList<User> GetAllInvolvedUser(int ClientId, int ClientAsset, int ProjectID,int Dept,int Desig)
        {
            IList<User> list = null;
            try
            {
                string VClientId = Convert.ToString(ClientId);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from pt in db.ProjectTaskLists
                //            join p in db.Projects on pt.ProjectID equals p.ProjectID
                //            join u in db.Users on pt.TaskOwner equals u.UserID
                //            where p.ClientCode == (ClientId == 0 ? p.ClientCode : VClientId) && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset) && p.ProjectID == (ProjectID == 0 ? p.ProjectID : ProjectID)
                //            && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept) && pt.DesignationID == (Desig == 0 ? pt.DesignationID : Desig)
                //            select u).Distinct().ToList<User>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }


      public static Boolean Check_DuplicateDeliverableNo(string DNo, int DID)
        {
            Boolean res = true;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    int CompanyId=Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //    if (DID > 0)
                //    {
                //        ProjectTaskList vPT = db.ProjectTaskLists.Where(a => a.ProjectTaskID == DID).SingleOrDefault();
                //        var val = (from q in db.ProjectTaskLists
                //                   join s in db.Projects on q.ProjectID equals s.ProjectID
                //                   where q.DeliverableNo == DNo && q.ProjectTaskID != DID && q.ProjectID == vPT.ProjectID && s.CompanyId == CompanyId
                //                   select q).Count();
                                     
                //        if (val == 0)
                //            res = false;
                //    }
                //    else
                //    {
                //        var val = (from q in db.ProjectTaskLists 
                //                  join s in db.Projects on q.ProjectID equals s.ProjectID
                //                  where q.DeliverableNo == DNo && s.CompanyId==CompanyId select q).Count();
                            
                //        if (val == 0)
                //            res = false;
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public static List<usp_ProjectList_Owner_Result> getProjectListByOwner(int UserID)
        {
            List<usp_ProjectList_Owner_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_ProjectList_Owner(UserID).ToList<usp_ProjectList_Owner_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public List<usp_getPendingResponseFileList_Result> getPendingResponseFileList(int UserID)
        {
            List<usp_getPendingResponseFileList_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getPendingResponseFileList(UserID, Convert.ToInt32(Common.DocStatusID.Comments)).ToList<usp_getPendingResponseFileList_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static List<usp_ProjectList_Check_Result> getProjectListByCheck(int UserID)
        {
            List<usp_ProjectList_Check_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_ProjectList_Check(UserID).ToList<usp_ProjectList_Check_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public static List<object> GetAllProjects()
        {
            List<object> list = null;
            //using(var db=new Cubicle_EntityEntities()){

            //  //  list = a from db.Projects ;

            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);

            //    list = (from p in db.Projects
            //            join pl in db.ProjectTaskLists on p.ProjectID equals pl.ProjectID
            //            where pl.IsDeliverable == true && p.CompanyId == CompanyId
            //            select new { ProjectID = p.ProjectID, ProjectName = p.ProjectName + " - " + p.ProjectCode }).ToList<object>();
            //}
            return list;
        }

        public static List<object> GetAllProjectsExceptClosedArchived()
        {
            List<object> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{

            //    int projectstatusClosed = Convert.ToInt32(Common.ProjectStatus.Closed);
            //    int projectstatusArchived = Convert.ToInt32(Common.ProjectStatus.Archived);
            //    string prstatusClosed = Convert.ToString(projectstatusClosed);
            //    string prstatusArchived = Convert.ToString(projectstatusArchived);

            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);

            //    list = (from p in db.Projects
            //            join pl in db.ProjectTaskLists on p.ProjectID equals pl.ProjectID
            //            where pl.IsDeliverable == true && p.CompanyId == CompanyId
            //            && p.ProjectStatus != prstatusArchived && p.ProjectStatus != prstatusClosed 
            //            select new { ProjectID = p.ProjectID, ProjectName = p.ProjectName + " - " + p.ProjectCode }).ToList<object>();
            //}
            return list;
        }

        public static List<Project> GetAllProjectsSearch(int Deliverablelst)
        {
            List<Project> list = null;
            //BLProjectCreationRepository objbl = new BLProjectCreationRepository();
            //BLUploadDeliverableFile blupdel = new BLUploadDeliverableFile();
            //using (var db = new Cubicle_EntityEntities())
            //{

            //    //  list = a from db.Projects ;
            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //    int UserID = Convert.ToInt32(UserSession.UserID);
            //    list = (from p in db.Projects
            //            join pl in db.ProjectTaskLists on p.ProjectID equals pl.ProjectID
            //            where p.CompanyId == CompanyId
            //            select  p ).ToList();

            //    //var lstint = lst.Where(a => UserID == (Deliverablelst ==0 ? blupdel.GetWhetherAdmin(a.ProjectID, a.ProjectTaskID) : objbl.IsProjectMember(UserID, a.ProjectID) == true ? UserID : -1)).Select(x => x.ProjectID).ToList<int>();

            //    // list =  db.Projects.Where(p=> lstint.Contains(p.ProjectID)).Select(a=>a).ToList();


            //}
            return list;
        
        
        }



        public static List<Project> GetAllProjectsSearch()
        {
            List<Project> list = null;
            //BLProjectCreationRepository objbl = new BLProjectCreationRepository();
            //BLUploadDeliverableFile blupdel = new BLUploadDeliverableFile();
            //using (var db = new Cubicle_EntityEntities())
            //{

            //    //  list = a from db.Projects ;
            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //    int UserID = Convert.ToInt32(UserSession.UserID);
            //    list = (from p in db.Projects
            //               join pl in db.ProjectTaskLists on p.ProjectID equals pl.ProjectID
            //               where p.CompanyId == CompanyId
            //               select p).ToList();

               


            //}
            return list;


        }
        public static List<Project> GetAllProjectsQuickSaveAndSend()
        {
            List<Project> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{

            //    //  list = a from db.Projects ;
            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);

            //    list = (from p in db.Projects
            //           // join pl in db.ProjectTaskLists on p.ProjectID equals pl.ProjectID
            //            where p.CompanyId == CompanyId
            //            select p).ToList<Project>();
            //}
            return list;


        }


        public static int GetProjectIDByProjectCode( string projectcode)
        {
            List<Project> list = null;
            int projectiD = 0;
            //using (var db = new Cubicle_EntityEntities())
            //{

            //    //  list = a from db.Projects ;
            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);

            //    list =(from p in db.Projects.Where(a=>a.CompanyId == CompanyId && a.ProjectCode == projectcode) 
            //            select p).ToList<Project>();
            //    foreach (var i in list)
            //    {
            //        projectiD = Convert.ToInt32(i.ProjectID);
            //    }

                
            //}
            return projectiD;


        }




        public static List<Project> GetAllProjectCodes()
        {
            List<Project> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{

            //    //  list = a from db.Projects ;
            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //    list = (from p in db.Projects
            //            where p.CompanyId == CompanyId
            //            select p).ToList<Project>();
            //}
            return list;
        }

       




        public static List<usp_MyCommentResolutionSheet_Result> getMyCommentResolutionSheet(int UserID)
        {
            List<usp_MyCommentResolutionSheet_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_MyCommentResolutionSheet(UserID).ToList<usp_MyCommentResolutionSheet_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static string GetFileRoleByUserID(int UserID)
        {
            //using (var db = new Cubicle_EntityEntities())
            //{
                
            //}
            return "";
        }

        public int  GetDeliverableOwnerIDByFileID(int FileID)
        {
            int taskowner = 0;
            int? ownerid = 0;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    int? delid = db.UploadDeliverableFiles.Where(a => a.UploadDeliverableFileID == FileID).Select(a => a.DeliverableListID).FirstOrDefault();

            //     ownerid = db.ProjectTaskLists.Where(a => a.ProjectTaskID == (int)delid).Select(a => a.TaskOwner).FirstOrDefault();      
            //    taskowner= (int)ownerid;
            //}
            return taskowner;
        }
    }
    
}
