using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLSharedProjectTaskListRepository
    {
        void AddSharedProjectTaskList(params SharedProjectTaskList[] SharedTask);
        bool CanUserEditSharedTask(int ProjectID, int MasterTaskTypeID, int UserID);
        List<SharedProjectTaskList> DuplicateSharedTask(string Userid, int ProjectID, int MasterTaskTypeID);
        IList<SharedProjectTaskList> GetAllSharedProjectTaskList();
        SharedProjectTaskList GetSharedProjectTaskListByID(int SharedTaskID);
        bool HasSharedTask(int ProjectID, int MasterTaskTypeID, int UserID);
        void RemoveSharedProjectTaskList(params SharedProjectTaskList[] sharedtask);
        bool ShareTaskByProjectID(int ProjectID, int MasterTaskTypeID, string usr);
        void UpdateSharedProjectTaskList(params SharedProjectTaskList[] sharedtask);
    }
}