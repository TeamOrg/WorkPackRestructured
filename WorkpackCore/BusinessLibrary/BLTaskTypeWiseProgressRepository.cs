using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskTypeWiseProgressRepository : IBLTaskTypeWiseProgressRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskTypeWiseProgress> _tasktypewise;

        public BLTaskTypeWiseProgressRepository(WorkpackDBContext context, IGenericDataRepository<TaskTypeWiseProgress> tasktypewise)
        {
            _context = context;
            _tasktypewise = tasktypewise;
        }




        public IList<TaskTypeWiseProgress> GetAllRecords()
        {
            return _tasktypewise.GetAll();
        }
        public TaskTypeWiseProgress GetTaskTypeWiseProgressByID(int TaskTypeWiseProgressID)
        {
            return _tasktypewise.GetSingle(d => d.TaskTypeWiseProgressID == TaskTypeWiseProgressID);
        }
        public void AddTaskTypeWiseProgress(params TaskTypeWiseProgress[] TaskTypeWiseProgress)
        {
            try
            {
                _tasktypewise.Add(TaskTypeWiseProgress);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public List<int> Get_Milestone_ids_by_projectid_and_tasktype_id(int projectid, int projecttasktypeid)
        {
            List<int> listids = new List<int>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        List<TaskTypeWiseProgress> listid = (from c in context.TaskTypeWiseProgresses
            //                                             where c.ProjectID == projectid && c.TaskTypeID == projecttasktypeid && c.PercentWeitage != null
            //                                             select c).ToList<TaskTypeWiseProgress>();
            //        foreach (var pmid in listid)
            //        {
            //            if (!listids.Contains(Convert.ToInt32(pmid.ProjectMilestoneID)))
            //            {
            //                listids.Add(Convert.ToInt32(pmid.ProjectMilestoneID));
            //            }
            //        }
            //    }

            //    catch (Exception ex)
            //    {
            //    }
               
            //}
            return listids;
        }



       



        public string NextMileStoneID(int projectID, int TaskTypeID, int TaskID)
        {
            string bookPer = "";
            TaskTypeWiseProgress Plst = null;
            ProjectMilestone lst = null;
            bookPer = "";

            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    Plst = (from pm in context.ProjectMilestones
            ////            join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            ////            join tm in context.TaskMilestoneTargetDates on pm.ProjectMilestoneID equals tm.MileStoneID
            ////            where pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID && tm.TaskID == TaskID && mtty.PercentWeitage != null && tm.ActualTaskMilestoneTargetDates != null
            ////            orderby mtty.PercentWeitage descending
            ////            select mtty).FirstOrDefault();
            ////}
            ////if (Plst == null)
            ////{
            ////    using (var context = new Cubicle_EntityEntities())
            ////    {
            ////        Plst = (from pm in context.ProjectMilestones
            ////                join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            ////                join tm in context.TaskMilestoneTargetDates on pm.ProjectMilestoneID equals tm.MileStoneID
            ////                where pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID && tm.TaskID == TaskID && mtty.PercentWeitage != null 
            ////                orderby mtty.PercentWeitage ascending
            ////                select mtty).FirstOrDefault();
            ////        bookPer = Convert.ToString(Plst.ProjectMilestoneID);
            ////    }
            ////}

            ////else if (Plst != null)
            ////{
            ////    using (var context = new Cubicle_EntityEntities())
            ////    {
            ////        Plst = (from pm in context.ProjectMilestones
            ////                join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            ////                join tm in context.TaskMilestoneTargetDates on pm.ProjectMilestoneID equals tm.MileStoneID
            ////                where pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID && tm.TaskID == TaskID && mtty.PercentWeitage != null && mtty.PercentWeitage > Plst.PercentWeitage 
            ////                orderby mtty.PercentWeitage ascending
            ////                select mtty).FirstOrDefault();
            ////        if (Plst != null)
            ////        {
            ////            bookPer = Convert.ToString(Plst.ProjectMilestoneID);
            ////        }
            ////        else
            ////        {
            ////            Plst = (from pm in context.ProjectMilestones
            ////                    join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            ////                    join tm in context.TaskMilestoneTargetDates on pm.ProjectMilestoneID equals tm.MileStoneID
            ////                    where pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID && tm.TaskID == TaskID && mtty.PercentWeitage != null && tm.ActualTaskMilestoneTargetDates != null
            ////                    orderby mtty.PercentWeitage descending
            ////                    select mtty).FirstOrDefault();
            ////            bookPer = Convert.ToString(Plst.ProjectMilestoneID);
            ////        }
            ////    }
            ////}




            return bookPer;
        }










        public void UpdateTaskTypeWiseProgress(params TaskTypeWiseProgress[] TaskTypeWiseProgress)
        {
            try
            {
                _tasktypewise.Update(TaskTypeWiseProgress);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaskTypeWiseProgress(params TaskTypeWiseProgress[] TaskTypeWiseProgress)
        {
            try
            {
                _tasktypewise.Remove(TaskTypeWiseProgress);
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
        }
        public List<TaskTypeWiseProgress> GetAllTaskTypeWiseProgressByProjectID(int ProjectID)
        {
            List<TaskTypeWiseProgress> list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.TaskTypeWiseProgresses.Where(c => c.ProjectID == ProjectID).ToList<TaskTypeWiseProgress>();
            //}
            return list;
        }

        public List<TaskTypeWiseProgress> GetAllTaskTypeWiseProgressByProjectIDandMilestoneID(int ProjectID, int MilestoneID)
        {
            List<TaskTypeWiseProgress> list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.TaskTypeWiseProgresses.Where(c => c.ProjectID == ProjectID && c.ProjectMilestoneID == MilestoneID).ToList<TaskTypeWiseProgress>();
            //}
            return list;
        }

        public List<TaskTypeWiseProgress> GetAllTaskTypeWiseProgressByProjectIDandMilestoneIDandTaskTypeID(int MilestoneID, int TaskTypeID)
        {
            List<TaskTypeWiseProgress> list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.TaskTypeWiseProgresses.Where(c => c.ProjectMilestoneID == MilestoneID && c.TaskTypeID == TaskTypeID).ToList<TaskTypeWiseProgress>();
            //}
            return list;
        }
    }
}
