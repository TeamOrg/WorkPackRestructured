using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskMilestoneBookedQtyRepository : IBLTaskMilestoneBookedQtyRepository
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskMilestoneBookedQty> _taskMilestoneBookedQtyRepository;

        public BLTaskMilestoneBookedQtyRepository(WorkpackDBContext context, IGenericDataRepository<TaskMilestoneBookedQty> taskMilestoneBookedQtyRepository)
        {
            _context = context;
            _taskMilestoneBookedQtyRepository = taskMilestoneBookedQtyRepository;
        }





        public IList<TaskMilestoneBookedQty> GetAllTaskMilestoneBookedQty()
        {
            return _taskMilestoneBookedQtyRepository.GetAll();
        }
        public TaskMilestoneBookedQty GetTaskMilestoneBookedQtyByID(Int32 taskMilestoneBookedQtyID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _taskMilestoneBookedQtyRepository.GetSingle(d => d.TaskMilestoneBookedQtyID == taskMilestoneBookedQtyID);
            //include related employees
        }



        public int GetTaskMilestoneBookedQtyByName(string taskMilestoneBookedQtyID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            int query = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    query = context.Departments.Where(c => c.DepartmentName.ToUpper() == taskMilestoneBookedQtyID.ToUpper()).Select(c => c.DepartmentID).SingleOrDefault();

            //}
            return query;

        }

        public List<TaskMilestoneBookedQty> GetTaskMilestoneBookedQtyByFileIdMilestoneId(int FileId, int MilestoneId, int TaskId)
        {
            List<TaskMilestoneBookedQty> lst = null;
            return lst;

            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var query = context.TaskMilestoneBookedQties.Where(c => c.FileID == FileId && c.MileStoneID == MilestoneId && c.TaskID == TaskId).ToList();

            //    return query;

            //}
        }

        public List<TaskMilestoneBookedQty> GetTaskMilestoneBookedQtyByFileId(int FileId)
        {
            List<TaskMilestoneBookedQty> lst = null;
            return lst;
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties

            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    var query = context.TaskMilestoneBookedQties.Where(c => c.FileID == FileId).ToList();

            ////    return query;

            ////}
        }


        public List<object> GetTaskMilestoneBookedQtyByFileIdMilestoneId(params  int[] TaskId)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            List<object> query = new List<object>();
            //BLFileStatusRepository blfilestatus = new BLFileStatusRepository();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    context.Configuration.LazyLoadingEnabled = false;
            //    var lst = context.TaskMilestoneBookedQties.Where(c => TaskId.Contains(c.TaskID)).ToList<TaskMilestoneBookedQty>();
            //    try
            //    {
            //        query = lst.Select(x => new
            //       {
            //           TaskMilestoneBookedQtyID = x.TaskMilestoneBookedQtyID,
            //           TaskID = x.TaskID,
            //           MileStoneID = x.MileStoneID,
            //           FileID = x.FileID,
            //           FileStatus = blfilestatus.FilestatusText(x.FileID),
            //           NormsID = x.NormsID,
            //           DepatmentID = x.DepatmentID,
            //           TaskName = string.IsNullOrEmpty(x.TaskName) ? (from a in context.ProjectTaskLists where a.ProjectTaskID == x.TaskID select a.TaskName).FirstOrDefault() : x.TaskName,
            //           TaskTypeID = x.TaskTypeID == null ? (from a in context.ProjectTaskLists where a.ProjectTaskID == x.TaskID select a.TaskTypeID).FirstOrDefault() : Convert.ToInt32(x.TaskTypeID),
            //           Duration = x.Duration,
            //           AllottedHours = x.AllottedHours,
            //           WBSID = x.WBSID,
            //           Priority = x.Priority,
            //           StartDate = x.StartDate.HasValue ? x.StartDate.ToString() : null,
            //           EndDate = x.EndDate.HasValue ? x.EndDate.ToString() : null,
            //           Remarks = x.Remarks,
            //           DeliverableNo = x.DeliverableNo,
            //           TaskOwner = x.TaskOwner,
            //           CreatedOn = x.CreatedOn.ToString(),
            //           CreatedBy = x.CreatedBy,
            //           ModifyBy = x.ModifyBy,
            //           ModifyOn = x.ModifyOn.ToString(),
            //           Number_1 = x.Number_1,
            //           Number_2 = x.Number_2,
            //           Number_3 = x.Number_3,
            //           Number_4 = x.Number_4,
            //           Number_5 = x.Number_5,
            //           Number_6 = x.Number_6,
            //           Number_7 = x.Number_7,
            //           Number_8 = x.Number_8,
            //           Number_9 = x.Number_9,
            //           Number_10 = x.Number_10,
            //           RelatedTasks = (from q in context.RelatedTasks join u in context.ProjectTaskLists on q.TaskID equals u.ProjectTaskID where q.TaskMilestoneBookedQtyID == x.TaskMilestoneBookedQtyID select new { u, q }).ToList<object>(),
            //           TaskMilestoneBookedQtyFiles = (from j in context.TaskMilestoneBookedQtyFiles join k in context.UploadDeliverableFiles on j.UploadDeliverableFileID equals k.UploadDeliverableFileID where j.TaskMilestoneBookedQtyID == x.TaskMilestoneBookedQtyID select new { k, j }).ToList<object>(),
            //           DateTime_1 = x.DateTime_1.HasValue ? x.DateTime_1.ToString() : null,
            //           DateTime_2 = x.DateTime_2.HasValue ? x.DateTime_2.ToString() : null,
            //           DateTime_3 = x.DateTime_3.HasValue ? x.DateTime_3.ToString() : null,
            //           DateTime_4 = x.DateTime_4.HasValue ? x.DateTime_4.ToString() : null,
            //           DateTime_5 = x.DateTime_5.HasValue ? x.DateTime_5.ToString() : null,
            //           DateTime_6 = x.DateTime_6.HasValue ? x.DateTime_6.ToString() : null,
            //           DateTime_7 = x.DateTime_7.HasValue ? x.DateTime_7.ToString() : null,
            //           DateTime_8 = x.DateTime_8.HasValue ? x.DateTime_8.ToString() : null,
            //           DateTime_9 = x.DateTime_9.HasValue ? x.DateTime_9.ToString() : null,
            //           DateTime_10 = x.DateTime_10.HasValue ? x.DateTime_10.ToString() : null,
            //           String_1 = x.String_1,
            //           String_2 = x.String_2,
            //           String_3 = x.String_3,
            //           String_4 = x.String_4,
            //           String_5 = x.String_5,
            //           String_6 = x.String_6,
            //           String_7 = x.String_7,
            //           String_8 = x.String_8,
            //           String_9 = x.String_9,
            //           String_10 = x.String_10,
            //           ForeCastStartDate = x.ForeCastStartDate.HasValue ? x.ForeCastStartDate.ToString() : null,
            //           ForeCastEndDate = x.ForeCastEndDate.HasValue ? x.ForeCastEndDate.ToString() : null,
            //           MasterTaskType = x.MasterTaskType,
            //           TaskWeight = x.TaskWeight,
            //           TaskCost = x.TaskCost,
            //           TotalCost = x.TotalCost

            //       }).ToList<object>();
            //    }
            //    catch(Exception ex){}

               

            //}

            return query;
        }
        public void AddTaskMilestoneBookedQty(params TaskMilestoneBookedQty[] taskMilestoneBookedQty)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskMilestoneBookedQtyRepository.Add(taskMilestoneBookedQty);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateTaskMilestoneBookedQty(params TaskMilestoneBookedQty[] taskMilestoneBookedQty)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskMilestoneBookedQtyRepository.Update(taskMilestoneBookedQty);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveTaskMilestoneBookedQty(params TaskMilestoneBookedQty[] taskMilestoneBookedQty)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskMilestoneBookedQtyRepository.Remove(taskMilestoneBookedQty);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                throw ex;
                //}
            }
        }

        public List<object> GetAllTaskMilestoneBookedQtyForProcurement(int FileID)
        {
            List<object> obj = null;
            return obj;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var lst = (from tm in context.TaskMilestoneBookedQties
            //               join pt in context.ProjectTaskLists on tm.TaskID equals pt.ProjectTaskID
            //               join p in context.Projects on pt.ProjectID equals p.ProjectID
            //               where tm.FileID == FileID
            //               select new { tm, pt, p }).ToList();

            //    var query = lst.Select(x => new
            //    {


            //        TaskMilestoneBookedQtyID = x.tm.TaskMilestoneBookedQtyID,
            //        TaskID = x.tm.TaskID,
            //        MileStoneID = x.tm.MileStoneID,
            //        FileID = x.tm.FileID,
            //        NormsID = x.tm.NormsID,
            //        DepatmentID = x.tm.DepatmentID,
            //        TaskName = x.tm.TaskName + " (" + x.p.ProjectName + ")",
            //        TaskTypeID = x.tm.TaskTypeID,
            //        Duration = x.tm.Duration,
            //        AllottedHours = x.tm.AllottedHours,
            //        WBSID = x.tm.WBSID,
            //        Priority = x.tm.Priority,
            //        StartDate = x.tm.StartDate.HasValue ? x.tm.StartDate.ToString() : null,
            //        EndDate = x.tm.EndDate.HasValue ? x.tm.EndDate.ToString() : null,
            //        Remarks = x.tm.Remarks,
            //        DeliverableNo = x.tm.DeliverableNo,
            //        TaskOwner = x.tm.TaskOwner,
            //        CreatedOn = x.tm.CreatedOn.ToString(),
            //        CreatedBy = x.tm.CreatedBy,
            //        ModifyBy = x.tm.ModifyBy,
            //        ModifyOn = x.tm.ModifyOn.ToString(),
            //        Number_1 = x.tm.Number_1,
            //        Number_2 = x.tm.Number_2,
            //        Number_3 = x.tm.Number_3,
            //        Number_4 = x.tm.Number_4,
            //        Number_5 = x.tm.Number_5,
            //        Number_6 = x.tm.Number_6,
            //        Number_7 = x.tm.Number_7,
            //        Number_8 = x.tm.Number_8,
            //        Number_9 = x.tm.Number_9,
            //        Number_10 = x.tm.Number_10,
            //        DateTime_1 = x.tm.DateTime_1.HasValue ? x.tm.DateTime_1.ToString() : null,
            //        DateTime_2 = x.tm.DateTime_2.HasValue ? x.tm.DateTime_2.ToString() : null,
            //        DateTime_3 = x.tm.DateTime_3.HasValue ? x.tm.DateTime_3.ToString() : null,
            //        DateTime_4 = x.tm.DateTime_4.HasValue ? x.tm.DateTime_4.ToString() : null,
            //        DateTime_5 = x.tm.DateTime_5.HasValue ? x.tm.DateTime_5.ToString() : null,
            //        DateTime_6 = x.tm.DateTime_6.HasValue ? x.tm.DateTime_6.ToString() : null,
            //        DateTime_7 = x.tm.DateTime_7.HasValue ? x.tm.DateTime_7.ToString() : null,
            //        DateTime_8 = x.tm.DateTime_8.HasValue ? x.tm.DateTime_8.ToString() : null,
            //        DateTime_9 = x.tm.DateTime_9.HasValue ? x.tm.DateTime_9.ToString() : null,
            //        DateTime_10 = x.tm.DateTime_10.HasValue ? x.tm.DateTime_10.ToString() : null,
            //        String_1 = x.tm.String_1,
            //        String_2 = x.tm.String_2,
            //        String_3 = x.tm.String_3,
            //        String_4 = x.tm.String_4,
            //        String_5 = x.tm.String_5,
            //        String_6 = x.tm.String_6,
            //        String_7 = x.tm.String_7,
            //        String_8 = x.tm.String_8,
            //        String_9 = x.tm.String_9,
            //        String_10 = x.tm.String_10,
            //        ForeCastStartDate = x.tm.ForeCastStartDate.HasValue ? x.tm.ForeCastStartDate.ToString() : null,
            //        ForeCastEndDate = x.tm.ForeCastEndDate.HasValue ? x.tm.ForeCastEndDate.ToString() : null,
            //        MasterTaskType = x.tm.MasterTaskType,
            //        TaskWeight = x.tm.TaskWeight,
            //        TaskCost = x.tm.TaskCost,
            //        TotalCost = x.tm.TotalCost

            //    }).ToList<object>();

            //    return query;

            //}
        }

    }
}
