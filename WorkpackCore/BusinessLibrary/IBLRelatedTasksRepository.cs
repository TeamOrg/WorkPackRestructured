using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLRelatedTasksRepository
    {
        void AddRelatedTasks(params RelatedTask[] relatedTasks);
        List<int> GetPrevioslySelectedRelatedTaskTask(int FileId, int Milestoneid, int projectID);
        List<RelatedTask> GetRelatedTaskByFileID(int FileId);
        IList<RelatedTask> GetRelatedTaskByID(int TaskMilestoneBookedQtyID);
        List<int> GetRelatedTaskByTaskID(int ProjectTaskid, int ProjectID, int Milestoneid);
        List<object> GetRelatedTaskForDropdownByFileID(int FileId);
        void RemoveRelatedTasks(params RelatedTask[] relatedTasks);
        void UpdateRelatedTasks(params RelatedTask[] relatedTasks);
        bool WhetherAllRelatedTaskApproved(int FileID);
    }
}