using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskCostDetailsIDRepository
    {
        void AddTaskCostDetail(params TaskCostDetail[] taskCostDetail);
        IList<TaskCostDetail> GetAllTaskCostDetails();
        List<TaskCostDetail> GetTaskCostDetailByTaskID(int TaskID);
        TaskCostDetail GetTaskCostDetailID(int TaskCostDetailID);
        void RemoveTaskCostDetail(params TaskCostDetail[] taskCostDetail);
        void UpdateTaskCostDetail(params TaskCostDetail[] taskCostDetail);
    }
}