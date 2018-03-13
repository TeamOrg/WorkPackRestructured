using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskMilestoneTargetDates_Contract
    {
        void AddTargetDatesForDeliverable(int TaskId, int MilestoneID, int RevisionID, string vTxtDeviation, int UserID);
        void AddTaskMilestoneTargetDates(params TaskMilestoneTargetDates_Contract[] taskDetail);
        List<TaskMilestoneTargetDates_Contract> GetAllTaskMilestoneTargetDateByDeliverableID(int DeliverableID);
        TaskMilestoneTargetDates_Contract GetAllTaskMilestoneTargetDateByDeliverableIDAndMilestoneID(int DeliverableID, int MilestoneID);
        IList<TaskMilestoneTargetDates_Contract> GetAllTaskMilestoneTargetDates();
        TaskMilestoneTargetDates_Contract GetTaskMilestoneTargetDatesByID(int TaskMilestoneTargetDatesID);
        void RemoveTaskMilestoneTargetDates(params TaskMilestoneTargetDates_Contract[] TaskMilestoneTargetDates);
        void UpdateTaskMilestoneTargetDates(params TaskMilestoneTargetDates_Contract[] TaskMilestoneTargetDates);
    }
}