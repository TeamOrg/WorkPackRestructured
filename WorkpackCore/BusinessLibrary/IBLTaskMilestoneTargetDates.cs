using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskMilestoneTargetDates
    {
        void AddTargetDatesForDeliverable(int TaskId, int MilestoneID, int RevisionID, string vTxtDeviation, int UserID);
        void AddTaskMilestoneTargetDates(params TaskMilestoneTargetDate[] taskDetail);
        List<TaskMilestoneTargetDate> GetAllTaskMilestoneTargetDateByDeliverableID(int DeliverableID);
        TaskMilestoneTargetDate GetAllTaskMilestoneTargetDateByDeliverableIDAndMilestoneID(int DeliverableID, int MilestoneID);
        IList<TaskMilestoneTargetDate> GetAllTaskMilestoneTargetDates();
        List<object> GetParentTaskDetails(int TaskID);
        List<object> getTaskMilestoneTargetDates(int ProjectID);
        TaskMilestoneTargetDate GetTaskMilestoneTargetDatesByID(int TaskMilestoneTargetDatesID);
        List<usp_getTaskTypeWiseProgressByTaskID_Result> getTaskTypeWiseProgressByTaskID(int TaskId, int filestatusID);
        void RemoveTaskMilestoneTargetDates(params TaskMilestoneTargetDate[] TaskMilestoneTargetDates);
        void UpdateDelay(int TaskID);
        void UpdateDelayActual(int TaskID);
        void UpdateTaskMilestoneTargetDates(params TaskMilestoneTargetDate[] TaskMilestoneTargetDates);
    }
}