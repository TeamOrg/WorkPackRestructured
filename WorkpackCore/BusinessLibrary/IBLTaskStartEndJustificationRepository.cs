using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskStartEndJustificationRepository
    {
        void AddTaskStartEndJustification(params TaskStartEndJustification[] client);
        IList<TaskStartEndJustification> GetAllTaskStartEndJustification();
        List<TaskStartEndJustification> GetAllTaskStartEndJustificationByTaskID(int TaskID);
        TaskStartEndJustification GetTaskStartEndJustificationByID(int TaskStartEndJustificationID);
        void RemoveTaskStartEndJustification(params TaskStartEndJustification[] client);
        void UpdateTaskStartEndJustification(params TaskStartEndJustification[] client);
        void UpdateTaskStartEndJustificationDormantUser(int User, int ProjectTaskID, int ProjectID, string IsStart, string Deviation);
    }
}