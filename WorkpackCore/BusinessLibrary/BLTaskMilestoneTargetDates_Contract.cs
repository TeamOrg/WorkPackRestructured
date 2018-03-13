using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskMilestoneTargetDates_Contract : IBLTaskMilestoneTargetDates_Contract
    {

     


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskMilestoneTargetDates_Contract> _taskMilestoneTargetDates;

        public BLTaskMilestoneTargetDates_Contract(WorkpackDBContext context, IGenericDataRepository<TaskMilestoneTargetDates_Contract> taskMilestoneTargetDates)
        {
            _context = context;
            _taskMilestoneTargetDates = taskMilestoneTargetDates;
        }




        public IList<TaskMilestoneTargetDates_Contract> GetAllTaskMilestoneTargetDates()
        {
            return _taskMilestoneTargetDates.GetAll();
        }
        public TaskMilestoneTargetDates_Contract GetTaskMilestoneTargetDatesByID(int TaskMilestoneTargetDatesID)
        {
            return _taskMilestoneTargetDates.GetSingle(d => d.TaskMilestoneTargetDatesID == TaskMilestoneTargetDatesID);
        }
        public void AddTaskMilestoneTargetDates(params TaskMilestoneTargetDates_Contract[] taskDetail)
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
        public void UpdateTaskMilestoneTargetDates(params TaskMilestoneTargetDates_Contract[] TaskMilestoneTargetDates)
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
        public void RemoveTaskMilestoneTargetDates(params TaskMilestoneTargetDates_Contract[] TaskMilestoneTargetDates)
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

        public static List<TaskMilestoneTargetDates_Contract> GetAllTaskMilestoneTargetDatesByTaskID(int ProjectTaskID)
        {
            List<TaskMilestoneTargetDates_Contract> lst = null;
            //using(var context=new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskMilestoneTargetDates_Contract.Where(c => c.TaskID == ProjectTaskID).ToList<TaskMilestoneTargetDates_Contract>();
            //}
            return lst;
        }

        public List<TaskMilestoneTargetDates_Contract> GetAllTaskMilestoneTargetDateByDeliverableID(int DeliverableID)
        {
            List<TaskMilestoneTargetDates_Contract> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskMilestoneTargetDates_Contract.Where(a => a.TaskID == DeliverableID).ToList<TaskMilestoneTargetDates_Contract>();
                return lst;
            //}
        }

        public TaskMilestoneTargetDates_Contract GetAllTaskMilestoneTargetDateByDeliverableIDAndMilestoneID(int DeliverableID, int MilestoneID)
        {
            TaskMilestoneTargetDates_Contract lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskMilestoneTargetDates_Contract.Where(a => a.TaskID == DeliverableID && a.MileStoneID == MilestoneID).SingleOrDefault();
                return lst;
            //}
        }


        public void AddTargetDatesForDeliverable(int TaskId, int MilestoneID, int RevisionID, string vTxtDeviation,int UserID)
        {
            //CultureInfo ci = new CultureInfo("en-Gb");
            //TaskMilestoneTargetDates_Contract TT = null;
            //ProgressSheet PS = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (RevisionID != 0)
            //    {
            //        BLRevisionFile blRev = new BLRevisionFile();
            //        MilestoneID = Convert.ToInt32(blRev.GetRevisionFileByID(RevisionID).StatusID);
            //    }
            //    TT = context.TaskMilestoneTargetDates_Contract.Where(c => c.TaskID == TaskId && c.MileStoneID == MilestoneID).SingleOrDefault();
            //    PS = context.ProgressSheets.Where(a => a.TaskID == TaskId && a.MilestoneID == MilestoneID).SingleOrDefault();
                
            //}

            //if (TT != null)
            //{
            //    TT.ActualTaskMilestoneTargetDates = Convert.ToDateTime(DateTime.Today, ci);
            //    TT.EntityState = DominModel.EntityState.Modified;
            //    UpdateTaskMilestoneTargetDates(TT);
            //}
            //BLProgressSheetRepository blPs = new BLProgressSheetRepository();
            //if (PS != null)
            //{
            //    PS.DeviationJustifcation = vTxtDeviation;
            //    PS.EntityState = DominModel.EntityState.Modified;
            //    blPs.UpdateprogressSheet(PS);
            //}
            //else
            //{
            //    BLTaskListRepository_Contract blTask = new BLTaskListRepository_Contract();
            //    ProjectTaskList_Contract PT = blTask.GetTaskListByID(TaskId);
            //    ProgressSheet vPS = new ProgressSheet();
            //    vPS.UserID = UserID;
            //    vPS.ProjectID = PT.ProjectID;
            //    vPS.TaskID = TaskId;
            //    vPS.MilestoneID = MilestoneID;
            //    vPS.DeviationJustifcation = vTxtDeviation;
            //    vPS.ProgressSheetStatus = Common.ProgressSheetStatus.Submit.ToString();
            //    vPS.EntityState = DominModel.EntityState.Added;
            //    blPs.AddprogressSheet(vPS);
            //}
            
        }
    }
}
