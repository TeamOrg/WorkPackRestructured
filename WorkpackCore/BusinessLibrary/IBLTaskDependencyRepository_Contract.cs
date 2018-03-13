using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskDependencyRepository_Contract
    {
        void AddTaskDependency(params TaskDependency_Contract[] taskdependency);
        bool CheckDuplicate(TaskDependency_Contract TDependency, bool IsInsert);
        bool DeleteTaskDependency(int TaskDependencyID);
        IList<usp_getTaskDependency_Contract_Result> Fetch(int ProjectTaskID);
        IList<TaskDependency_Contract> GetAllTaskDependencies();
        IList<DependencyType> GetDependencyTypeList();
        IList<usp_GetProjectTaskListForDependency_Contract_Result> GetProjectTaskID(int ProjectTaskID, int ProjectID);
        TaskDependency_Contract GetTaskDependencyByID(int taskdependencyID);
        int GetTaskIDByTaskObjectID(int TaskObjectID, int ProjectID);
        void InsertDependencyHeap(string strPreTaskNode, string strSucTaskNode);
        void RemoveTaskDependency(params TaskDependency_Contract[] taskdependency);
        bool SaveTaskDependency(TaskDependency_Contract obj);
        void UpdateTaskDependency(params TaskDependency_Contract[] taskdependency);
        bool ValidDependencyCheck(string strPreTaskNode, string strSucTaskNode);
    }
}