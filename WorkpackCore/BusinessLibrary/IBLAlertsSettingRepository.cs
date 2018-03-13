using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLAlertsSettingRepository
    {
        void AddAlertsSetting(params AlertsSetting[] alertsSetting);
        AlertsSetting GetAlertsSettingByID(int AlertID);
        IList<AlertsSetting> GetAllAlertsSettings(int companyid);
        IList<AlertsSetting> GetDefaultAlertsSettings();
        void RemoveAlertsSetting(params AlertsSetting[] alertsSetting);
        void UpdateAlertsSetting(params AlertsSetting[] alertsSetting);
    }
}