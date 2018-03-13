using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLApprovalRelatedTaskRepository : IBLApprovalRelatedTaskRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ApprovalRelatedTask> _approvalRelatedTask;

        public BLApprovalRelatedTaskRepository(WorkpackDBContext context, IGenericDataRepository<ApprovalRelatedTask> approvalRelatedTask)
        {
            _context = context;
            _approvalRelatedTask = approvalRelatedTask;
        }
        public ApprovalRelatedTask GetApprovalRelatedTask(int Id)
        {
            return _approvalRelatedTask.GetSingle(d => d.ApproveFileID == Id);
        }


        public IList<ApprovalRelatedTask> GetAllApprovalRelatedTask()
        {
            return _approvalRelatedTask.GetAll();
        }

        public List<ApprovalRelatedTask> GetApprovalRelatedTaskByFileID(int FileId)
        {
            return _approvalRelatedTask.GetAll().Where(a => a.UploadDeliverableFileID == FileId).ToList();
        }
        //public BLApprovalRelatedTaskRepository(IApprovalRelatedTaskRepository ApprovalRelatedTask)
        //{
        //    _approvalRelatedTask = ApprovalRelatedTask;
        //}
        public void AddApprovalRelatedTask(params ApprovalRelatedTask[] ApprovalRelatedTask)
        {
            try
            {
                _approvalRelatedTask.Add(ApprovalRelatedTask);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not added.");
            }
        }
        public void UpdateApprovalRelatedTask(params ApprovalRelatedTask[] ApprovalRelatedTask)
        {
            try
            {
                _approvalRelatedTask.Update(ApprovalRelatedTask);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not updated.");
            }
        }
        public void RemoveApprovalRelatedTask(params ApprovalRelatedTask[] ApprovalRelatedTask)
        {
            try
            {
                _approvalRelatedTask.Remove(ApprovalRelatedTask);
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

        //public bool WhetherAllRelatedTaskApproved(int FileID)
        //{

        //    using (var context = new Cubicle_EntityEntities())
        //    {
        //        int countRelatedTask = (from r in context.RelatedTasks
        //                                join t in context.TaskMilestoneBookedQties on r.TaskMilestoneBookedQtyID equals t.TaskMilestoneBookedQtyID
        //                                where t.FileID == FileID 
        //                                select r).Count();

        //        int countApprovedRelatedTask = (from ar in context.ApprovalRelatedTasks
        //                                        join r in context.RelatedTasks on ar.TaskID equals r.TaskID
        //                                        join t in context.TaskMilestoneBookedQties on new { x = (int)r.TaskMilestoneBookedQtyID, y = (int)ar.UploadDeliverableFileID } equals new { x = t.TaskMilestoneBookedQtyID, y = t.FileID }
        //                                        where t.FileID == FileID
        //                                        select ar).Count();

        //        if (countRelatedTask == countApprovedRelatedTask)
        //            return true;
        //        else
        //            return false;
        //    }

        //}

        


    }
}
