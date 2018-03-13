using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLChangeTaskListRepository
    {
        string cellAllign(string oldvalue);
        IList<usp_ChangeProjectTaskList_Result> GetChageprojectTaskList(int ChangeScopeId, int NotificationGroupID);
        IList<object> GetChageprojectTaskListObject(int ProjectID, int NotificationGroupID);
        IList<usp_ChangeMilestoneTargetDates_Result> GetChageTaskMilestoneList(int ChangeScopeId);
        List<usp_LockTaskListUnderScopeChange_Result> GetScopeChageprojectTaskListObject(int ProjectID);
    }
}