using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskTypeWiseProgressRepository
    {
        void AddTaskTypeWiseProgress(params TaskTypeWiseProgress[] TaskTypeWiseProgress);
        IList<TaskTypeWiseProgress> GetAllRecords();
        List<TaskTypeWiseProgress> GetAllTaskTypeWiseProgressByProjectID(int ProjectID);
        List<TaskTypeWiseProgress> GetAllTaskTypeWiseProgressByProjectIDandMilestoneID(int ProjectID, int MilestoneID);
        List<TaskTypeWiseProgress> GetAllTaskTypeWiseProgressByProjectIDandMilestoneIDandTaskTypeID(int MilestoneID, int TaskTypeID);
        TaskTypeWiseProgress GetTaskTypeWiseProgressByID(int TaskTypeWiseProgressID);
        List<int> Get_Milestone_ids_by_projectid_and_tasktype_id(int projectid, int projecttasktypeid);
        string NextMileStoneID(int projectID, int TaskTypeID, int TaskID);
        void RemoveTaskTypeWiseProgress(params TaskTypeWiseProgress[] TaskTypeWiseProgress);
        void UpdateTaskTypeWiseProgress(params TaskTypeWiseProgress[] TaskTypeWiseProgress);
    }
}