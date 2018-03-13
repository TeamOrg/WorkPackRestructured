using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskProgressHistoryRepository
    {
        void AddprogressHistory(params TaskProgressHistory[] progresshistory);
        IList<TaskProgressHistory> GetAllprogressHistory();
        TaskProgressHistory GetprogresshistoryByID(int progresshistoryID);
        IList<TaskProgressHistory> GetprogressHistoryByTaskIDCurrentDate(int TaskID);
        void Removeprogresshistory(params TaskProgressHistory[] progresshistory);
        void Updateprogresshistroy(params TaskProgressHistory[] progresshistory);
        void UpdateTaskProgressHistory(int ProjectTaskID, decimal ProgressValue, int UserID);
    }
}