using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskMilestoneBookedQtyFileRepository
    {
        void AddTaskMilestoneBookedQtyFile(params TaskMilestoneBookedQtyFile[] taskMilestoneBookedQtyFile);
        IList<TaskMilestoneBookedQtyFile> GetAllTaskMilestoneBookedQtyFile();
        IList<TaskMilestoneBookedQtyFile> GetAllTaskMilestoneBookedQtyFileByID(int TaskMilestoneBookedQtyID);
        void RemoveTaskMilestoneBookedQtyFile(params TaskMilestoneBookedQtyFile[] taskMilestoneBookedQtyFile);
    }
}