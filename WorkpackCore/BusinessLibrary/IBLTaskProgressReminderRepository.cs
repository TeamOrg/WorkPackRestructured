using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskProgressReminderRepository
    {
        void AddTaskProgressReminder(params TaskProgressReminder[] TaskProgressReminder);
        IList<TaskProgressReminder> GetAllTaskProgressReminder();
        TaskProgressReminder GetTaskProgressReminderByID(int TaskProgressReminderID);
        List<TaskProgressReminder> GetTaskProgressReminderByProjectID(int ProjectID);
        string GetUserRemiderFlag(int ProjectID, int UserID);
        void RemoveTaskProgressReminder(params TaskProgressReminder[] TaskProgressReminder);
        void RemoveTaskProgressReminderByProjectID(int ProjectID);
        void UpdateTaskProgressReminder(params TaskProgressReminder[] TaskProgressReminder);
    }
}