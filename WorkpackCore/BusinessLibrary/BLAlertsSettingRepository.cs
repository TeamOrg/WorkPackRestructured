using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLAlertsSettingRepository : IBLAlertsSettingRepository
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<AlertsSetting> _alertsSettingRepository;

        public BLAlertsSettingRepository(WorkpackDBContext context, IGenericDataRepository<AlertsSetting> alertsSettingRepository)
        {
            _context = context;
            _alertsSettingRepository = alertsSettingRepository;
        }
        public IList<AlertsSetting> GetAllAlertsSettings(int companyid)
        {
            //int companyid = (int)HttpContext.Current.Session["CompanyId"];
            return _alertsSettingRepository.GetAll().Where(a=>a.CompanyId==companyid).ToList();
        }

        public IList<AlertsSetting> GetDefaultAlertsSettings()
        {
            //int companyid = (int)HttpContext.Current.Session["CompanyId"];
            return _alertsSettingRepository.GetAll().ToList();
        }

        public AlertsSetting GetAlertsSettingByID(Int32 AlertID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _alertsSettingRepository.GetSingle(d => d.AlertID == AlertID);
            //include related employees
        }
        public void AddAlertsSetting(params AlertsSetting[] alertsSetting)
        {
            /* Validation and error handling omitted */
            try
            {
                _alertsSettingRepository.Add(alertsSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateAlertsSetting(params AlertsSetting[] alertsSetting)
        {
            /* Validation and error handling omitted */
            try
            {
                _alertsSettingRepository.Update(alertsSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
           
        }
        public void RemoveAlertsSetting(params AlertsSetting[] alertsSetting)
        {
            /* Validation and error handling omitted */
            try
            {
                _alertsSettingRepository.Remove(alertsSetting);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
    }
}
