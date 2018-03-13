using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskMilestoneBookedQtyRepository
    {
        void AddTaskMilestoneBookedQty(params TaskMilestoneBookedQty[] taskMilestoneBookedQty);
        IList<TaskMilestoneBookedQty> GetAllTaskMilestoneBookedQty();
        List<object> GetAllTaskMilestoneBookedQtyForProcurement(int FileID);
        List<TaskMilestoneBookedQty> GetTaskMilestoneBookedQtyByFileId(int FileId);
        List<TaskMilestoneBookedQty> GetTaskMilestoneBookedQtyByFileIdMilestoneId(int FileId, int MilestoneId, int TaskId);
        List<object> GetTaskMilestoneBookedQtyByFileIdMilestoneId(params int[] TaskId);
        TaskMilestoneBookedQty GetTaskMilestoneBookedQtyByID(int taskMilestoneBookedQtyID);
        int GetTaskMilestoneBookedQtyByName(string taskMilestoneBookedQtyID);
        void RemoveTaskMilestoneBookedQty(params TaskMilestoneBookedQty[] taskMilestoneBookedQty);
        void UpdateTaskMilestoneBookedQty(params TaskMilestoneBookedQty[] taskMilestoneBookedQty);
    }
}