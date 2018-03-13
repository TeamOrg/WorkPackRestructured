using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskDeatilsRepository_Contract 
    {
        //private readonly ITaskDetailsRepository_Contract TaskDetailsRepository_Contract;       
 
        //public BLTaskDeatilsRepository_Contract()
        //{
        //    TaskDetailsRepository_Contract = new TaskDetailsRepository_Contract();           
        //}
        //public BLTaskDeatilsRepository_Contract(ITaskDetailsRepository_Contract TaskDetailsRepository)
        //{
        //    TaskDetailsRepository_Contract = TaskDetailsRepository;
        //}

        //public IList<TaskDetail_Contract> GetAllTaskDetail()
        //{
        //    return TaskDetailsRepository_Contract.GetAll();
        //}
        //public TaskDetail_Contract GetTaskDetailByID(int TaskDetailID)
        //{
        //    return TaskDetailsRepository_Contract.GetSingle(d => d.TaskDetailID == TaskDetailID);
        //}
        //public void AddTaskDetails(params TaskDetail_Contract[] taskDetail)
        //{
        //    try
        //    {
        //        TaskDetailsRepository_Contract.Add(taskDetail);
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        throw new Exception("Record not added.");
        //    }
        //}
        //public void UpdateTaskDetails(params TaskDetail_Contract[] taskDetail)
        //{
        //    try
        //    {
        //        TaskDetailsRepository_Contract.Update(taskDetail);
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        throw new Exception("Record not updated.");
        //    }
        //}
        //public void RemoveTaskDetails(params TaskDetail_Contract[] taskDetail)
        //{
        //    try
        //    {
        //        TaskDetailsRepository_Contract.Remove(taskDetail);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static List<TaskDetail_Contract> GetAllDetailsByTaskID(int ProjectTaskID)
        //{
        //    List<TaskDetail_Contract> lst = null;
        //    using(var context=new Cubicle_EntityEntities())
        //    {
        //        lst = context.TaskDetail_Contract.Where(c => c.ProjectTaskID == ProjectTaskID).ToList<TaskDetail_Contract>();
        //    }
        //    return lst;
        //}

        //public void updateTaskNo(int ProjectId, int TaskIntPart, int TaskDecimalPart, int originalTaskNo)
        //{
        //    using (var context = new Cubicle_EntityEntities())
        //    {
        //        context.usp_updateTaskNo(ProjectId, TaskIntPart, TaskDecimalPart, originalTaskNo);
        //    }
        //}

        //public void updateTaskNo_Contract(int ProjectId, int TaskIntPart, int TaskDecimalPart, int originalTaskNo)
        //{
        //    using (var context = new Cubicle_EntityEntities())
        //    {
        //        context.usp_updateTaskNo(ProjectId, TaskIntPart, TaskDecimalPart, originalTaskNo);
        //    }
        //}
    }
}
