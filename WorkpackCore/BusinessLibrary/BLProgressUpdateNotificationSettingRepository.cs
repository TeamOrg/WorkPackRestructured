using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProgressUpdateNotificationSettingRepository : IBLProgressUpdateNotificationSettingRepository
    {
        
       



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProgressUpdateNotificationSetting> _progressUpdateNotificationSetting;

        public BLProgressUpdateNotificationSettingRepository(WorkpackDBContext context, IGenericDataRepository<ProgressUpdateNotificationSetting> progressUpdateNotificationSetting)
        {
            _context = context;
            _progressUpdateNotificationSetting = progressUpdateNotificationSetting;
        }

        public ProgressUpdateNotificationSetting GetProgressUpdateNotificationSettingID(int Id)
        {
            return _progressUpdateNotificationSetting.GetSingle(d => d.NotificationID == Id);
        }






        public void AddProgressUpdateNotificationSetting(params ProgressUpdateNotificationSetting[] ProgressUpdateNotificationSetting)
        {
            try
            {
                _progressUpdateNotificationSetting.Add(ProgressUpdateNotificationSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProgressUpdateNotificationSetting(params ProgressUpdateNotificationSetting[] ProgressUpdateNotificationSetting)
        {
            try
            {
                _progressUpdateNotificationSetting.Update(ProgressUpdateNotificationSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProgressUpdateNotificationSetting(params ProgressUpdateNotificationSetting[] ProgressUpdateNotificationSetting)
        {
            try
            {
                _progressUpdateNotificationSetting.Remove(ProgressUpdateNotificationSetting);
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

        public ProgressUpdateNotificationSetting GetProgressUpdateNotificationSettingByProjectIDTaskTypeID(int MilestoneID, int TaskTypeID)
        {
            ProgressUpdateNotificationSetting obj = _progressUpdateNotificationSetting.GetAll().Where(x => x.MilestoneID == MilestoneID && x.TaskTypeID == TaskTypeID).FirstOrDefault();

            return obj;
        
        }
    }
}
