using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskDeatilsRepository : IBLTaskDeatilsRepository
    {
       
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskDetail> _taskDetailsRepository;

        public BLTaskDeatilsRepository(WorkpackDBContext context, IGenericDataRepository<TaskDetail> taskDetailsRepository)
        {
            _context = context;
            _taskDetailsRepository = taskDetailsRepository;
        }




        public IList<TaskDetail> GetAllTaskDetail()
        {
            return _taskDetailsRepository.GetAll();
        }
        public TaskDetail GetTaskDetailByID(int TaskDetailID)
        {
            return _taskDetailsRepository.GetSingle(d => d.TaskDetailID == TaskDetailID);
        }
        public void AddTaskDetails(params TaskDetail[] taskDetail)
        {
            try
            {
                _taskDetailsRepository.Add(taskDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaskDetails(params TaskDetail[] taskDetail)
        {
            try
            {
                _taskDetailsRepository.Update(taskDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaskDetails(params TaskDetail[] taskDetail)
        {
            try
            {
                _taskDetailsRepository.Remove(taskDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<TaskDetail> GetAllDetailsByTaskID(int ProjectTaskID)
        {
            List<TaskDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskDetails.Where(c => c.ProjectTaskID == ProjectTaskID).ToList<TaskDetail>();
            //}
            return lst;
        }

        public void updateTaskNo(int ProjectId, int TaskIntPart, int TaskDecimalPart, int originalTaskNo)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    context.usp_updateTaskNo(ProjectId, TaskIntPart, TaskDecimalPart, originalTaskNo);
            //}
        }

        public void UpdateTaskNoByParentID(int taskID , int newParentID , int oldParentID, int ProjectId)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    context.UpdateTaskNoByParentID(taskID, newParentID, oldParentID, ProjectId);
            //}
        }
        


    }

}
