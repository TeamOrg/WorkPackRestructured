using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLUserActivityTrackerRepository : IBLUserActivityTrackerRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<UserActivityTracker> _userActivityTrackerRepository;

        public BLUserActivityTrackerRepository(WorkpackDBContext context, IGenericDataRepository<UserActivityTracker> userActivityTrackerRepository)
        {
            _context = context;
            _userActivityTrackerRepository = userActivityTrackerRepository;
        }







        public IList<UserActivityTracker> GetAllUserActivity()
        {
            return _userActivityTrackerRepository.GetAll();
        }
        public UserActivityTracker GetUserActivityByID(Int32 trackID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _userActivityTrackerRepository.GetSingle(d => d.TrackID == trackID);                
                //include related employees
        }        
        public void AddUserActivityTracker(params UserActivityTracker[] useractivity)
        {
            /* Validation and error handling omitted */
            try
            {
                _userActivityTrackerRepository.Add(useractivity);
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
        public void UpdateUserActivityTracker(params UserActivityTracker[] useractivity)
        {
            /* Validation and error handling omitted */
            try
            {
                _userActivityTrackerRepository.Update(useractivity);
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
        public void RemoveUserActivityTracker(params UserActivityTracker[] useractivity)
        {
            /* Validation and error handling omitted */
            try
            {
                _userActivityTrackerRepository.Remove(useractivity);
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
