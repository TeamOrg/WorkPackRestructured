using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskCreationNormDetailRepository : IBLTaskCreationNormDetailRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskCreationNormDetail> _taskCreationNormDetail;

        public BLTaskCreationNormDetailRepository(WorkpackDBContext context, IGenericDataRepository<TaskCreationNormDetail> taskCreationNormDetail)
        {
            _context = context;
            _taskCreationNormDetail = taskCreationNormDetail;
        }


        public IList<TaskCreationNormDetail> GetAllTaskCreationNormDetail()
        {
            return _taskCreationNormDetail.GetAll();
        }
        public TaskCreationNormDetail GetTaskCreationNormDetailByID(int TaskCreationNormDetailID)
        {
            return _taskCreationNormDetail.GetSingle(d => d.TaskCreationNormDetID == TaskCreationNormDetailID);
        }
        public void AddTaskCreationNormDetail(params TaskCreationNormDetail[] TaskCreationNormDetail)
        {
            try
            {
                _taskCreationNormDetail.Add(TaskCreationNormDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaskCreationNormDetail(params TaskCreationNormDetail[] TaskCreationNormDetail)
        {
            try
            {
                _taskCreationNormDetail.Update(TaskCreationNormDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaskCreationNormDetail(params TaskCreationNormDetail[] TaskCreationNormDetail)
        {
            try
            {
                _taskCreationNormDetail.Remove(TaskCreationNormDetail);
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

        public TaskCreationNormDetail GetTaskCreationNormDetailByProjectTaskID(int ProjectTaskID)
        {
            TaskCreationNormDetail list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.TaskCreationNormDetails.Where(a => a.ProjectTaskID == ProjectTaskID).SingleOrDefault();
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


    }
}
