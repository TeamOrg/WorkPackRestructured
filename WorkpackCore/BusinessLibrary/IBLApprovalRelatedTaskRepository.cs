using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLApprovalRelatedTaskRepository
    {
        void AddApprovalRelatedTask(params ApprovalRelatedTask[] ApprovalRelatedTask);
        IList<ApprovalRelatedTask> GetAllApprovalRelatedTask();
        ApprovalRelatedTask GetApprovalRelatedTask(int Id);
        List<ApprovalRelatedTask> GetApprovalRelatedTaskByFileID(int FileId);
        void RemoveApprovalRelatedTask(params ApprovalRelatedTask[] ApprovalRelatedTask);
        void UpdateApprovalRelatedTask(params ApprovalRelatedTask[] ApprovalRelatedTask);
        //bool WhetherAllRelatedTaskApproved(int FileID);
    }
}