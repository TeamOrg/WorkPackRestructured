using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLRemindProgressRepository
    {
        void AddRemindMeProgressLevel(params RemindMeProgressLevel[] reminder);
        IList<RemindMeProgressLevel> GetAllReminder();
        RemindMeProgressLevel GetReminderByID(int RemindMeProgressLevelID);
        List<usp_GetReminderForProgressByUserID_Result> GetUserReminddataByUserID(int UserID);
        IList<RemindMeProgressLevel> GetUserReminddataByUserProgressLevel(int UserID, int ProgressLevelID, int TaskID);
        void UpdateRemindme(params RemindMeProgressLevel[] reminder);
    }
}