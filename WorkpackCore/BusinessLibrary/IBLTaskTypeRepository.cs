using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskTypeRepository
    {
        void AddTaskType(params TaskType[] tasktype);
        bool CheckDuplicate(TaskType tasktype, bool IsInsert);
        List<object> GetAllTaskTypeList();
        List<object> GetAllTaskTypeList(int Companyid);
        IList<TaskType> GetAllTaskTypes();
        TaskType GetTaskTypeByID(int tasktypeID);
        TaskType getTaskTypeByMilestoneGroup();
        int GetTaskTypeByName(string tasktypeID, int companyid);
        TaskType getTaskTypeByTaskGroup();
        TaskType getTaskTypeByTaskGroup(string TaskGroup);
        IList<Usp_Gettasktypewithactivity_Result> GetTaskTypeList(TaskType tasktype);
        void RemoveTaskType(params TaskType[] tasktype);
        void UpdateTaskType(params TaskType[] tasktype);
    }
}