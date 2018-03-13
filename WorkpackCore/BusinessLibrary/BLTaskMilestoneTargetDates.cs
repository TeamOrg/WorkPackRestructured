using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskMilestoneTargetDates : IBLTaskMilestoneTargetDates
    {

        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskMilestoneTargetDate> _taskMilestoneTargetDates;

        public BLTaskMilestoneTargetDates(WorkpackDBContext context, IGenericDataRepository<TaskMilestoneTargetDate> taskMilestoneTargetDates)
        {
            _context = context;
            _taskMilestoneTargetDates = taskMilestoneTargetDates;
        }




        public IList<TaskMilestoneTargetDate> GetAllTaskMilestoneTargetDates()
        {
            return _taskMilestoneTargetDates.GetAll();
        }
        public TaskMilestoneTargetDate GetTaskMilestoneTargetDatesByID(int TaskMilestoneTargetDatesID)
        {
            return _taskMilestoneTargetDates.GetSingle(d => d.TaskMilestoneTargetDatesID == TaskMilestoneTargetDatesID);
        }
        public void AddTaskMilestoneTargetDates(params TaskMilestoneTargetDate[] taskDetail)
        {
            try
            {
                _taskMilestoneTargetDates.Add(taskDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaskMilestoneTargetDates(params TaskMilestoneTargetDate[] TaskMilestoneTargetDates)
        {
            try
            {
                _taskMilestoneTargetDates.Update(TaskMilestoneTargetDates);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void UpdateDelay(int TaskID)
        {
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_UpdateDelayByTaskID(TaskID, DateTime.Now, "Expected");
                //}
            }
            catch (Exception ex)
            {
            }
        }
        public void UpdateDelayActual(int TaskID)
        {
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_UpdateDelayByTaskID(TaskID, DateTime.Now, "Actual");
                //}
            }
            catch (Exception ex)
            {
            }
        }
        public void RemoveTaskMilestoneTargetDates(params TaskMilestoneTargetDate[] TaskMilestoneTargetDates)
        {
            try
            {
                _taskMilestoneTargetDates.Remove(TaskMilestoneTargetDates);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<TaskMilestoneTargetDate> GetAllTaskMilestoneTargetDatesByTaskID(int ProjectTaskID)
        {
            List<TaskMilestoneTargetDate> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskMilestoneTargetDates.Where(c => c.TaskID == ProjectTaskID).ToList<TaskMilestoneTargetDate>();
            //}
            return lst;
        }

        public List<TaskMilestoneTargetDate> GetAllTaskMilestoneTargetDateByDeliverableID(int DeliverableID)
        {
            List<TaskMilestoneTargetDate> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskMilestoneTargetDates.Where(a => a.TaskID == DeliverableID).ToList<TaskMilestoneTargetDate>();
                return lst;
            //}
        }

        public List<usp_getTaskTypeWiseProgressByTaskID_Result> getTaskTypeWiseProgressByTaskID(int TaskId, int filestatusID)
        {
            List<usp_getTaskTypeWiseProgressByTaskID_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int FileStatusID = Convert.ToInt32(Common.FileStatusID.Approved);
            //    lst = context.usp_getTaskTypeWiseProgressByTaskID(TaskId, FileStatusID).ToList<usp_getTaskTypeWiseProgressByTaskID_Result>();
                return lst;
            //}
        }

        public TaskMilestoneTargetDate GetAllTaskMilestoneTargetDateByDeliverableIDAndMilestoneID(int DeliverableID, int MilestoneID)
        {
            TaskMilestoneTargetDate lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskMilestoneTargetDates.Where(a => a.TaskID == DeliverableID && a.MileStoneID == MilestoneID).SingleOrDefault();
                return lst;
            //}
        }


        public void AddTargetDatesForDeliverable(int TaskId, int MilestoneID, int RevisionID, string vTxtDeviation, int UserID)
        {
            //CultureInfo ci = new CultureInfo("en-Gb");
            //TaskMilestoneTargetDate TT = null;
            //ProgressSheet PS = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (RevisionID != 0)
            //    {
            //        BLRevisionFile blRev = new BLRevisionFile();
            //        MilestoneID = Convert.ToInt32(blRev.GetRevisionFileByID(RevisionID).StatusID);
            //    }
            //    // TT = context.TaskMilestoneTargetDates.Where(c => c.TaskID == TaskId && c.MileStoneID == MilestoneID).SingleOrDefault();
            //    PS = context.ProgressSheets.Where(a => a.TaskID == TaskId && a.MilestoneID == MilestoneID).SingleOrDefault();

            //}

            //if (TT != null)
            //{
            //    TT.ActualTaskMilestoneTargetDates = Convert.ToDateTime(DateTime.Today, ci);
            //    TT.EntityState = DominModel.EntityState.Modified;
            //    UpdateTaskMilestoneTargetDates(TT);
            //}
            ////BLProgressSheetRepository blPs = new BLProgressSheetRepository();
            ////if (PS != null)
            ////{
            ////    PS.DeviationJustifcation = vTxtDeviation;
            ////    PS.EntityState = DominModel.EntityState.Modified;
            ////    blPs.UpdateprogressSheet(PS);
            ////}
            ////else
            ////{
            ////    BLTaskListRepository blTask = new BLTaskListRepository();
            ////    ProjectTaskList PT = blTask.GetTaskListByID(TaskId);
            ////    ProgressSheet vPS = new ProgressSheet();
            ////    vPS.UserID = UserID;
            ////    vPS.ProjectID = PT.ProjectID;
            ////    vPS.TaskID = TaskId;
            ////    vPS.MilestoneID = MilestoneID;
            ////    vPS.DeviationJustifcation = vTxtDeviation;
            ////    vPS.ProgressSheetStatus = Common.ProgressSheetStatus.Submit.ToString();
            ////    vPS.EntityState = DominModel.EntityState.Added;
            ////    blPs.AddprogressSheet(vPS);
            ////}

        }


        public List<object> getTaskMilestoneTargetDates(int ProjectID)
        {
            List<object> list = null;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var db = new Cubicle_EntityEntities())
            //        {
            //            list = (from a in db.ProjectTaskLists
            //                    join b in db.TaskMilestoneTargetDates on a.ProjectTaskID equals b.TaskID
            //                    join c in db.ProjectMilestones on b.MileStoneID equals c.ProjectMilestoneID
            //                    where a.ProjectID == ProjectID
            //                    select new
            //                    {
            //                        TaskID = b.TaskID,
            //                        MilestoneID = b.MileStoneID,
            //                        StartDate = a.StartDate,
            //                        Duration = a.Duration,
            //                        SchedulingJS = c.SchedulingJS,
            //                        TaskMilestoneTargetDates = b.TaskMilestoneTargetDates
            //                    }).ToList<object>();

            //        }

            //    }
            //    catch (Exception ex) { }
            //}
            return list;
        }

        public List<object> GetParentTaskDetails(int TaskID)
        {
            List<object> list1 = null;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var db = new Cubicle_EntityEntities())
            //        {
            //            var list = (from a in db.ProjectTaskLists
            //                        //join b in db.TaskMilestoneTargetDates on a.ProjectTaskID equals b.TaskID
            //                        //join c in db.ProjectMilestones on b.MileStoneID equals c.ProjectMilestoneID
            //                        //join f in db.ProjectWBS on Convert.ToInt32(a.WBSID) equals f.WBSID into h
            //                        //from wbs in h.DefaultIfEmpty()
            //                        join d in db.Users on a.TaskOwner equals d.UserID into g
            //                        from task in g.DefaultIfEmpty()
            //                        where a.ProjectTaskID == TaskID
            //                        select new
            //                        {
            //                            TaskID = a.ProjectTaskID,
            //                            //MilestoneID = b.MileStoneID,
            //                            StartDate = a.StartDate,
            //                            Duration = a.Duration,
            //                            //Id = c.MileStone,
            //                            //TaskMilestoneTargetDates = b.TaskMilestoneTargetDates,
            //                            EndDate = a.EndDate,
            //                            Owner = a.TaskOwner,
            //                            OwnerName = task.FirstName + " " + task.LastName,
            //                            WBSID = a.WBSID,
            //                            //WBSCode = wbs.WBSCode
            //                        }).ToList();

            //            list1 = (from a in list
            //                     select new
            //                     {
            //                         TaskID = a.TaskID,
            //                        // MilestoneID = a.MilestoneID,
            //                         StartDate = a.StartDate == null ? "" : Convert.ToDateTime(a.StartDate).ToString("dd/MM/yyyy"),
            //                         Duration = a.Duration,
            //                         //Id = a.Id,
            //                         //TaskMilestoneTargetDates = a.TaskMilestoneTargetDates == null ? "" : Convert.ToDateTime(a.TaskMilestoneTargetDates).ToString("dd/MM/yyyy"),
            //                         EndDate = a.EndDate == null ? "" : Convert.ToDateTime(a.EndDate).ToString("dd/MM/yyyy"),
            //                         Owner = a.Owner,
            //                         OwnerName = a.OwnerName,
            //                         WBSID = a.WBSID,
            //                         //WBSCode = a.WBSCode
            //                     }).ToList<object>();

            //        }

            //    }
            //    catch (Exception ex) { }
            //}
            return list1;
        }
    }
}
