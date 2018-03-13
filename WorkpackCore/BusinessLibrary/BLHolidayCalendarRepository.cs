using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLHolidayCalendarRepository : IBLHolidayCalendarRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<HolidayCalendar> _holidayCalendarRepository;

        public BLHolidayCalendarRepository(WorkpackDBContext context, IGenericDataRepository<HolidayCalendar> holidayCalendarRepository)
        {
            _context = context;
            _holidayCalendarRepository = holidayCalendarRepository;
        }
        public IList<HolidayCalendar> GetAllHolidayCalendars()
        {

            //BLProjectCreationRepository objproject = new BLProjectCreationRepository();
            //int companyId = 0;//Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;
            //return _holidayCalendarRepository.GetAll().Where(a => a.ProjectID == projectID).ToList<HolidayCalendar>();
            IList<HolidayCalendar> lst = null;
            return lst;

        }

        public IList<HolidayCalendar> GetProjectHolidayCalendars(int mm, int yy, int projectID)
        {


            return _holidayCalendarRepository.GetAll().Where(p => p.WorkingDate.Month == mm && p.WorkingDate.Year == yy && p.ProjectID == projectID).ToList<HolidayCalendar>();
        }


        public HolidayCalendar GetHolidayCalendarByID(Int32 HolidayCalendar)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _holidayCalendarRepository.GetSingle(d => d.HolidayCalendarID == HolidayCalendar);
            //include related employees
        }
        public void AddHolidayCalendar(params HolidayCalendar[] dailyworkhr)
        {
            /* Validation and error handling omitted */
            try
            {
                _holidayCalendarRepository.Add(dailyworkhr);
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
        public void UpdateHolidayCalendar(params HolidayCalendar[] dailyworkhr)
        {
            /* Validation and error handling omitted */
            try
            {
                _holidayCalendarRepository.Update(dailyworkhr);
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
        public void RemoveHolidayCalendar(params HolidayCalendar[] dailyworkhr)
        {
            try
            {
                /* Validation and error handling omitted */
                _holidayCalendarRepository.Remove(dailyworkhr);
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
        public IList<HolidayCalendar> c_GetAllHolidayCalendars(int mm, int yy,int ProjectId)
        {
            IList<HolidayCalendar> List = new List<HolidayCalendar>();
            try
            {
               
               

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.HolidayCalendars.Where(p => p.WorkingDate.Month == mm && p.WorkingDate.Year == yy && p.ProjectID==ProjectId).ToList();
                //}
                if (List.Count == 0)
                {
                    List = GenerateNewList(mm, yy);
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;
        }
        private IList<HolidayCalendar> GenerateNewList(int mm, int yy)
        {
            IList<HolidayCalendar> List = new List<HolidayCalendar>();
            DateTime sDate = new DateTime(yy, mm, 1);
            DateTime eDate = sDate.AddMonths(1);
            try
            {
                while (sDate < eDate)
                {
                    HolidayCalendar h = new HolidayCalendar
                    {
                        WorkingDate = Convert.ToDateTime(sDate),
                        Day = sDate.DayOfWeek.ToString(),
                        day_type_code = "WR"
                    };
                    List.Add(h);
                    sDate = sDate.AddDays(1.0);
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;
        }
        public Boolean SaveHolidayCalender(int mm,int yy,params HolidayCalendar[] dailyworkhr)
        {
            Boolean res = false;

            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var Context = new Cubicle_EntityEntities())
            //        {
            //            foreach (var a in Context.HolidayCalendars.Where(p=>p.WorkingDate.Month==mm && p.WorkingDate.Year==yy))
            //            {
            //                Context.HolidayCalendars.Remove(a);
            //            }
            //            Context.SaveChanges();                       
            //            foreach (var obj in dailyworkhr)
            //            {
            //                Context.HolidayCalendars.Add(obj);
            //            }
            //            Context.SaveChanges();
            //        }
            //        ts.Complete();
            //        res = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        res = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return res;
        }

        public static int GetWorkingDaysByMonth(DateTime Month)
        {
            int res = 0;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    res = (from a in db.HolidayCalendars where a.day_type_code == "WR"  && a.WorkingDate.Month == Month.Month && a.WorkingDate.Year == Month.Year select a).Count();
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public static int GetWorkingDaysCountByPeriod(DateTime Start,DateTime End,int ProjectID)
        {
            int res = 0;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    res = (from a in db.HolidayCalendars where a.ProjectID == ProjectID && a.day_type_code == "WR" && a.WorkingDate >= Start && a.WorkingDate <= End select a).Count();
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }


        public static int GetHolidayDaysCountByPeriod(DateTime Start, DateTime End, int ProjectID)
        {
            int res = 0;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    res = (from a in db.HolidayCalendars where a.ProjectID == ProjectID &&  a.day_type_code != "WR" && a.WorkingDate >= Start && a.WorkingDate <= End select a).Count();
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }





        public static int GetNonWorkingDaysCountByPeriod(DateTime Start, DateTime End)
        {
            int res = 0;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    res = (from a in db.HolidayCalendars where (a.day_type_code == "WO" || a.day_type_code == "CH") && a.WorkingDate >= Start && a.WorkingDate <= End select a).Count();
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }



        public List<HolidayTypeMaster> getHolidayType()
        {
            List<HolidayTypeMaster> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.HolidayTypeMasters.ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }


        public List<usp_Set_Start_EndDate_Result> SetStartEndDate(int projectId, int duration)
        {
            List<usp_Set_Start_EndDate_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_Set_Start_EndDate(projectId,duration).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }



        public List<usp_GetNextWorkingDateByDuration_Result> GetNextWorkingDateByDuration(int projectId, DateTime date, int duration)
        {
            List<usp_GetNextWorkingDateByDuration_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_GetNextWorkingDateByDuration(date, duration, projectId).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }



        public List<usp_Set_Start_EndDateAwarded_Result> SetStartEndDateAwarded(DateTime startDate, DateTime EndDate,int Duration,int projectId)
        {
            List<usp_Set_Start_EndDateAwarded_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_Set_Start_EndDateAwarded(startDate, EndDate, Duration, projectId).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
       

       
    }
}
