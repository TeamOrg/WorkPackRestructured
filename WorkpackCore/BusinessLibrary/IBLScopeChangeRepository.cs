using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLScopeChangeRepository
    {
        bool checkDuplicateScopeCode(string code);
        List<object> GetAllProjectUnderScopechange(int UserID, int ProjectArchived);
        IList<ScopeChange> GetAllScopeChange();
        IList<ScopeChange> GetAllTaskTypes();
        List<usp_ScopeChangeProjectTaskList_Result> GetScopeChangeReportByProjectID(int ProjectID);
        List<usp_getTransferFromUser_Result> getTransferFromUser(int taskID);
        int SaveScopeChange(ScopeChange scopeChange);
    }
}