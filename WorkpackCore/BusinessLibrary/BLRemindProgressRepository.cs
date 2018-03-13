using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLRemindProgressRepository : IBLRemindProgressRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<RemindMeProgressLevel> _remindRepository;

        public BLRemindProgressRepository(WorkpackDBContext context, IGenericDataRepository<RemindMeProgressLevel> remindRepository)
        {
            _context = context;
            _remindRepository = remindRepository;
        }
        public IList<RemindMeProgressLevel> GetAllReminder()
        {
            return _remindRepository.GetAll();
        }
        public RemindMeProgressLevel GetReminderByID(Int32 RemindMeProgressLevelID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _remindRepository.GetSingle(d => d.RemindMeProgressLevelID == RemindMeProgressLevelID);                
                //include related employees
        }
        public void AddRemindMeProgressLevel(params RemindMeProgressLevel[] reminder)
        {
            /* Validation and error handling omitted */
            try
            {
                _remindRepository.Add(reminder);
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
        public void UpdateRemindme(params RemindMeProgressLevel[] reminder)
        {
            /* Validation and error handling omitted */
            try
            {
                _remindRepository.Update(reminder);
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
        public IList<RemindMeProgressLevel> GetUserReminddataByUserProgressLevel(int UserID, int ProgressLevelID,int TaskID)
        {
            IList<RemindMeProgressLevel> lstremind = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lstremind=context.RemindMeProgressLevels.Where(a=>a.TaskID==TaskID && a.UserID==UserID && a.ProgressLevelID==ProgressLevelID).ToList<RemindMeProgressLevel>();
                
            //}
            return lstremind;
        }
        public List<usp_GetReminderForProgressByUserID_Result> GetUserReminddataByUserID(int UserID)
        {
           List<usp_GetReminderForProgressByUserID_Result> lstremind = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lstremind = context.usp_GetReminderForProgressByUserID(UserID).ToList<usp_GetReminderForProgressByUserID_Result>();

            //}
            return lstremind;
        }
        //public void RemoveAcceptanceClass(params AcceptanceClass[] acceptanceclass)
        //{
        //    /* Validation and error handling omitted */
        //    try
        //    {
        //        _acceptanceclassRepository.Remove(acceptanceclass);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        //if (false)
        //        //{
        //        //    throw ex;
        //        //}
        //    }
            
        //}

    }
}
