using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskDependencyRepository
    {
        void AddTaskDependency(params TaskDependency[] taskdependency);
        bool CheckDuplicate(TaskDependency TDependency, bool IsInsert);
        bool DeleteTaskDependency(int TaskDependencyID);
        IList<usp_getTaskDependency_Result> Fetch(int ProjectTaskID);
        IList<TaskDependency> GetAllTaskDependencies();
        IList<DependencyType> GetDependencyTypeList();
        List<TaskDependency> GetPredecessorTaskByTaskID(int TaskID);
        IList<usp_GetProjectTaskListForDependency_Result> GetProjectTaskID(int ProjectTaskID, int ProjectID);
        List<TaskDependency> GetSuccessorTaskByTaskID(int DependecyTaskID);
        TaskDependency GetTaskDependencyByID(int taskdependencyID);
        int GetTaskIDByTaskObjectID(int TaskObjectID, int ProjectID);
        void InsertDependencyHeap(string strPreTaskNode, string strSucTaskNode);
        void RemoveTaskDependency(params TaskDependency[] taskdependency);
        bool SaveTaskDependency(TaskDependency obj);
        void UpdateTaskDependency(params TaskDependency[] taskdependency);
        bool ValidDependencyCheck(string strPreTaskNode, string strSucTaskNode);
    }
}