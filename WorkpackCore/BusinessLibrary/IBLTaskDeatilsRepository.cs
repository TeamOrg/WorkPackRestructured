using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskDeatilsRepository
    {
        void AddTaskDetails(params TaskDetail[] taskDetail);
        IList<TaskDetail> GetAllTaskDetail();
        TaskDetail GetTaskDetailByID(int TaskDetailID);
        void RemoveTaskDetails(params TaskDetail[] taskDetail);
        void UpdateTaskDetails(params TaskDetail[] taskDetail);
        void updateTaskNo(int ProjectId, int TaskIntPart, int TaskDecimalPart, int originalTaskNo);
        void UpdateTaskNoByParentID(int taskID, int newParentID, int oldParentID, int ProjectId);
    }
}