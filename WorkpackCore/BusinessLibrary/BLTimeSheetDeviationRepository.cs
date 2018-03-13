using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTimeSheetDeviationRepository : IBLTimeSheetDeviationRepository
    {

        

            private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TimeSheetDeviation> _timeSheetDeviation;

        public BLTimeSheetDeviationRepository(WorkpackDBContext context, IGenericDataRepository<TimeSheetDeviation> timeSheetDeviation)
        {
            _context = context;
            _timeSheetDeviation = timeSheetDeviation;
        }



        public IList<TimeSheetDeviation> GetAllTimeSheetDeviation()
        {
            return _timeSheetDeviation.GetAll();
        }
        public TimeSheetDeviation GetTimeSheetDeviationByID(Int32 TimeSheetDeviationID)
        {
            return _timeSheetDeviation.GetSingle(d => d.TimeSheetDeviationID == TimeSheetDeviationID);
        }
        public void AddTimeSheetDeviation(params TimeSheetDeviation[] timeSheetDeviation)
        {
            try
            {
                _timeSheetDeviation.Add(timeSheetDeviation);
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
        public void UpdateTimeSheetDeviation(params TimeSheetDeviation[] timeSheetDeviation)
        {
            /* Validation and error handling omitted */
            try
            {
                _timeSheetDeviation.Update(timeSheetDeviation);
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
        public void RemoveTimeSheetDeviation(params TimeSheetDeviation[] timeSheetDeviation)
        {
            /* Validation and error handling omitted */
            try
            {
                _timeSheetDeviation.Remove(timeSheetDeviation);
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

        public List<TimeSheetDeviation> GetAllTimeSheetDeviationByTaskID(int TaskID)
        {
            List<TimeSheetDeviation> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TimeSheetDeviations.Where(a => a.TaskID == TaskID).ToList<TimeSheetDeviation>();
            //}
            return lst;
        }
        public List<TimeSheetDeviation> GetAllTimeSheetDeviationByWeekTaskID(int weekID,int TaskID)
        {
            List<TimeSheetDeviation> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TimeSheetDeviations.Where(a => a.TaskID == TaskID && a.TimeSheetWeeklyID==weekID).ToList<TimeSheetDeviation>();
            //}
            return lst;
        }


    }
}
