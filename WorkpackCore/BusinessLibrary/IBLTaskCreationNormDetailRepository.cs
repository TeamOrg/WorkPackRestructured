using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskCreationNormDetailRepository
    {
        void AddTaskCreationNormDetail(params TaskCreationNormDetail[] TaskCreationNormDetail);
        IList<TaskCreationNormDetail> GetAllTaskCreationNormDetail();
        TaskCreationNormDetail GetTaskCreationNormDetailByID(int TaskCreationNormDetailID);
        TaskCreationNormDetail GetTaskCreationNormDetailByProjectTaskID(int ProjectTaskID);
        void RemoveTaskCreationNormDetail(params TaskCreationNormDetail[] TaskCreationNormDetail);
        void UpdateTaskCreationNormDetail(params TaskCreationNormDetail[] TaskCreationNormDetail);
    }
}