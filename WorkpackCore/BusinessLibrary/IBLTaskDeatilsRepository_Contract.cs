using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskDeatilsRepository_Contract
    {
        void AddTaskDetails(params TaskDetail_Contract[] taskDetail);
        IList<TaskDetail_Contract> GetAllTaskDetail();
        TaskDetail_Contract GetTaskDetailByID(int TaskDetailID);
        void RemoveTaskDetails(params TaskDetail_Contract[] taskDetail);
        void UpdateTaskDetails(params TaskDetail_Contract[] taskDetail);
        void updateTaskNo(int ProjectId, int TaskIntPart, int TaskDecimalPart, int originalTaskNo);
        void updateTaskNo_Contract(int ProjectId, int TaskIntPart, int TaskDecimalPart, int originalTaskNo);
    }
}