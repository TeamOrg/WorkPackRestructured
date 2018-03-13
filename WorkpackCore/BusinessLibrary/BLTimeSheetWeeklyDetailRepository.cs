using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTimeSheetWeeklyDetailRepository : IBLTimeSheetWeeklyDetailRepository
    {

        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TimeSheetWeeklyDetail> _timeSheetWeeklyDetailRepository;

        public BLTimeSheetWeeklyDetailRepository(WorkpackDBContext context, IGenericDataRepository<TimeSheetWeeklyDetail> timeSheetWeeklyDetailRepository)
        {
            _context = context;
            _timeSheetWeeklyDetailRepository = timeSheetWeeklyDetailRepository;
        }


        public IList<TimeSheetWeeklyDetail> GetAllTimeSheetWeeklyDetail()
        {
            return _timeSheetWeeklyDetailRepository.GetAll();
        }
        public TimeSheetWeeklyDetail GetTimeSheetWeeklyDetailByID(Int32 timeSheetWeeklyDetailID)
        {
            return _timeSheetWeeklyDetailRepository.GetSingle(d => d.TimeSheetID == timeSheetWeeklyDetailID);
        }
        public void AddTimeSheetWeeklyDetail(params TimeSheetWeeklyDetail[] timeSheetWeeklyDetail)
        {
            try
            {
                _timeSheetWeeklyDetailRepository.Add(timeSheetWeeklyDetail);
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
        public void UpdateTimeSheetWeeklyDetail(params TimeSheetWeeklyDetail[] timeSheetWeeklyDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _timeSheetWeeklyDetailRepository.Update(timeSheetWeeklyDetail);
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
        public void RemoveTimeSheetWeeklyDetail(params TimeSheetWeeklyDetail[] timeSheetWeeklyDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _timeSheetWeeklyDetailRepository.Remove(timeSheetWeeklyDetail);
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
        public IList<TimeSheetWeeklyDetail> GetAllTimeSheetWeeklyDetailByTaskWeekUserID(int TaskID,int WeekID,int UserID)
        {
            IList<TimeSheetWeeklyDetail> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TimeSheetWeeklyDetails.Where(a => a.TaskID == TaskID && a.TimeSheetWeeklyID == WeekID && a.UserID == UserID).ToList<TimeSheetWeeklyDetail>();
            //}
            return lst;
        }
        public List<TimeSheetWeeklyDetail> GetAllTimeSheetWeeklyDetailByTaskID(int TaskID)
        {
            List<TimeSheetWeeklyDetail> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TimeSheetWeeklyDetails.Where(a => a.TaskID == TaskID).ToList<TimeSheetWeeklyDetail>();
            //}
            return lst;
        }
        public List<TimeSheetWeeklyDetail> GetTimeSheetWeeklyDetailByweekID(int weekID)
        {
            List<TimeSheetWeeklyDetail> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TimeSheetWeeklyDetails.Where(a => a.TimeSheetWeeklyID == weekID).ToList<TimeSheetWeeklyDetail>();
            //}
            return lst;
        }
    }

}

