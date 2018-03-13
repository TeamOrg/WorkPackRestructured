using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    interface IBLTaskHandoverDetailRepository
    {
        void AddTaskHandoverDetail(params TaskHandoverDetail[] taskHandoverDetail);
        IList<TaskHandoverDetail> GetAllTaskHandoverDetail();
        List<TaskHandoverDetail> GetAllTaskHandoverDetailByTaskID(int TaskID);
        TaskHandoverDetail GetTaskStartEndJustificationByID(int TaskHandoverDetailID);
        void RemoveTaskHandoverDetail(params TaskHandoverDetail[] taskHandoverDetail);
        void UpdateTaskHandoverDetail(params TaskHandoverDetail[] taskHandoverDetail);
    }
}