using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProgressUpdateNotificationSettingRepository
    {
        void AddProgressUpdateNotificationSetting(params ProgressUpdateNotificationSetting[] ProgressUpdateNotificationSetting);
        ProgressUpdateNotificationSetting GetProgressUpdateNotificationSettingByProjectIDTaskTypeID(int MilestoneID, int TaskTypeID);
        ProgressUpdateNotificationSetting GetProgressUpdateNotificationSettingID(int Id);
        void RemoveProgressUpdateNotificationSetting(params ProgressUpdateNotificationSetting[] ProgressUpdateNotificationSetting);
        void UpdateProgressUpdateNotificationSetting(params ProgressUpdateNotificationSetting[] ProgressUpdateNotificationSetting);
    }
}