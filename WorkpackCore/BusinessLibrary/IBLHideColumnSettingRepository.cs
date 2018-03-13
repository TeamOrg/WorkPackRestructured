using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLHideColumnSettingRepository
    {
        void AddHideColumnSetting(params HideColumnSetting[] hideColumnSetting);
        IList<HideColumnSetting> GetAllhideColumnSetting();
        List<HideColumnSetting> GetAllhideColumnSettingByProjectIdAndUserId(int ProjectId, int UserId);
        HideColumnSetting GetHideColumnSettingByID(int hideColumnSettingID);
        OperationResult hideColumnSettingMethod(int PId, int ProjectId, int UserId, bool IsChecked);
        void RemoveHideColumnSetting(params HideColumnSetting[] hideColumnSetting);
        void UpdateHideColumnSetting(params HideColumnSetting[] hideColumnSetting);
    }
}