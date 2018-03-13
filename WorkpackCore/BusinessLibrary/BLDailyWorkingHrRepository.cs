using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDailyWorkingHrRepository : IBLDailyWorkingHrRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<DailyWorkingHr> _dailyworkhrRepository;

        public BLDailyWorkingHrRepository(WorkpackDBContext context, IGenericDataRepository<DailyWorkingHr> dailyworkhrRepository)
        {
            _context = context;
            _dailyworkhrRepository = dailyworkhrRepository;
        }
        public IList<DailyWorkingHr> GetAllDailyWorkingHrs()
        {

            //BLProjectCreationRepository objproject = new BLProjectCreationRepository();
            //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;
            IList < DailyWorkingHr > lst= null;
            return lst; //_dailyworkhrRepository.GetAll().Where(a => a.ProjectID == projectID).ToList<DailyWorkingHr>();
        }
        public DailyWorkingHr GetDailyWorkingHrByID(Int32 dailyworkhrID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _dailyworkhrRepository.GetSingle(d => d.DailyWorkingHrsID == dailyworkhrID);
            //include related employees
        }
        public void AddDailyWorkingHr(params DailyWorkingHr[] dailyworkhr)
        {
            /* Validation and error handling omitted */
            try
            {
                _dailyworkhrRepository.Add(dailyworkhr);
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
        public void UpdateDailyWorkingHr(params DailyWorkingHr[] dailyworkhr)
        {
            /* Validation and error handling omitted */
            try
            {
                _dailyworkhrRepository.Update(dailyworkhr);
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
        public void RemoveDailyWorkingHr(params DailyWorkingHr[] dailyworkhr)
        {
            try
            {
                /* Validation and error handling omitted */
                _dailyworkhrRepository.Remove(dailyworkhr);
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

        public IList<DailyWorkingHr> c_GetAllDailyWorkingHrs(int projectID)
        {
            IList<DailyWorkingHr> List = new List<DailyWorkingHr>();
         
            List = _dailyworkhrRepository.GetAll().Where(a => a.ProjectID == projectID).ToList<DailyWorkingHr>();
            if (List.Count == 0)
            {
                List = GenerateNewList();
            }
            return List;
        }


        public IList<DailyWorkingHr> GetProjectDailyWorking(int projectID)
        {
            IList<DailyWorkingHr> List = new List<DailyWorkingHr>();

            List = _dailyworkhrRepository.GetAll().Where(a => a.ProjectID == projectID).ToList<DailyWorkingHr>();
          
            return List;
        }




        private IList<DailyWorkingHr> GenerateNewList()
        {
            //var values = (from e in Enum.GetValues(typeof(Common.WeekDays)).Cast<Common.WeekDays>()
            //              select e).ToList();
            IList<DailyWorkingHr> List = new List<DailyWorkingHr>();
            //try
            //{
            //    foreach (var val in values)
            //    {
            //        DailyWorkingHr d = new DailyWorkingHr
            //        {
            //            WeekDay = Convert.ToString(val),
            //            Workinghours = Convert.ToDecimal(0.00),
            //            OtHours = Convert.ToDecimal(0.00),
            //            IsHoliday = "Y"
            //        };
            //        List.Add(d);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return List;
        }

        public Boolean SaveDailyWorkHrs(params DailyWorkingHr[] dailyworkhr)
        {
            Boolean res = false;

            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var Context = new Cubicle_EntityEntities())
            //        {
            //            foreach (var a in Context.DailyWorkingHrs)
            //            {
            //                Context.DailyWorkingHrs.Remove(a);
            //            }
            //            Context.SaveChanges();                       
            //            foreach (var obj in dailyworkhr)
            //            {
            //                Context.DailyWorkingHrs.Add(obj);
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
        //public Boolean CheckDuplicate(DailyWorkingHr dailyworkhr, Boolean IsInsert)
        //{
        //    Boolean Result = true;

        //    var c = _dailyworkhrRepository.GetSingle(p => p.DailyWorkingHrCode == dailyworkhr.DailyWorkingHrCode && p.DailyWorkingHrName == dailyworkhr.DailyWorkingHrName);
        //    if(!IsInsert)
        //    {
        //        if (c == null)
        //            Result = true;
        //        else if (c.DailyWorkingHrsID == dailyworkhr.DailyWorkingHrsID)
        //            Result=true;
        //        else
        //            Result=false;
        //    }
        //    else
        //    {
        //        if (c == null)
        //            Result = true;
        //        else
        //            Result = false;
        //    }
        //    return Result;
        //}
        //public IList<DailyWorkingHr> GetDailyWorkingHrList(DailyWorkingHr dailyworkhr)
        //{
        //    IList<DailyWorkingHr> fetchedClient = new List<DailyWorkingHr>();
        //    using (var Context = new Cubicle_EntityEntities())
        //    {
        //        IQueryable<DailyWorkingHr> query = Context.DailyWorkingHrs;
        //        if (dailyworkhr.DailyWorkingHrName != string.Empty)
        //            query = query.Where(p => p.DailyWorkingHrName.ToUpper().Contains(dailyworkhr.DailyWorkingHrName.ToUpper()));
        //        if (dailyworkhr.DailyWorkingHrCode != string.Empty)
        //            query = query.Where(p => p.DailyWorkingHrCode.ToUpper().Contains(dailyworkhr.DailyWorkingHrCode.ToUpper()));
        //        fetchedClient = query.ToList();
        //    }
        //    return fetchedClient;
        //}

         public static Boolean isWorkingDay(string day)
        {
            Boolean res = false;
            //try
            //{

            //    BLProjectCreationRepository objproject = new BLProjectCreationRepository();
            //    int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //    int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        string val = (from a in context.DailyWorkingHrs where a.WeekDay == day && a.ProjectID == projectID select a.IsHoliday).FirstOrDefault().ToString();
            //        if (val == "Y")
            //            res = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            return res;
        }
         public static Decimal DailyWorkingHoursByDay(string day)
         {
             decimal res = 0;
             //try
             //{
             //    BLProjectCreationRepository objproject = new BLProjectCreationRepository();
             //    int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
             //    int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

             //    using (var context = new Cubicle_EntityEntities())
             //    {
                    
             //        var val = context.DailyWorkingHrs.Where(a => a.WeekDay.Substring(0,3) == day && a.ProjectID==projectID).Select(c => c.Workinghours).FirstOrDefault();
             //        res = Convert.ToDecimal(val);
             //    }
             //}
             //catch (Exception ex)
             //{
             //}
             return res;
         }


         public static Decimal NormalWorkingHrsPerPersonInMonth(DateTime Month)
         {
             Decimal hrs = 0.0M;
             //try
             //{
             //    BLProjectCreationRepository objproject = new BLProjectCreationRepository();
             //    int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
             //    int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

             //    using (var db = new Cubicle_EntityEntities())
             //    {
             //        hrs = (from h in db.HolidayCalendars
             //              join d in db.DailyWorkingHrs
             //                  on h.Day equals d.WeekDay
             //              where h.day_type_code == "WR" && h.ProjectID==projectID && h.WorkingDate.Month == Month.Month && h.WorkingDate.Year == Month.Year

             //              select new { d.Workinghours }).Sum(p=>p.Workinghours).GetValueOrDefault();
             //    }
             //}
             //catch (Exception ex)
             //{
             //}
             return hrs;
         }

         public static int NormalWorkingDaysPerPeriod(DateTime SDate, DateTime LDate)
         {
             int days = 0;
             //try
             //{
             //    BLProjectCreationRepository objproject = new BLProjectCreationRepository();
             //    int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
             //    int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

             //    using (var db = new Cubicle_EntityEntities())
             //    {
             //        days = (from h in db.HolidayCalendars
             //               join d in db.DailyWorkingHrs
             //                   on h.Day equals d.WeekDay
             //               where h.day_type_code == "WR" && h.ProjectID==projectID && h.WorkingDate >= SDate.Date && h.WorkingDate <= LDate.Date

             //               select new { d }).Count();
             //    }
             //}
             //catch (Exception ex)
             //{
             //}
             return days;
         }

         public static decimal getMaxDailyWorkingHrs()
         {
             decimal res = 0;
             //try
             //{
             //    BLProjectCreationRepository objproject = new BLProjectCreationRepository();
             //    int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
             //    int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

             //    using (var db = new Cubicle_EntityEntities())
             //    {
             //        res = (from a in db.DailyWorkingHrs where a.IsHoliday == "N" && a.ProjectID==projectID select a).Max(p => p.Workinghours).GetValueOrDefault();
             //    }
             //}
             //catch (Exception ex)
             //{
             //}
             return res;
         }
         public static int getTotalDailyWorkingDaysInWeek()
         {
             int res = 0;
             //try
             //{
             //    BLProjectCreationRepository objproject = new BLProjectCreationRepository();
             //    int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
             //    int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

             //    using (var db = new Cubicle_EntityEntities())
             //    {
             //        res = (from a in db.DailyWorkingHrs where a.IsHoliday == "N" && a.ProjectID==projectID select a).Count();
             //    }
             //}
             //catch (Exception ex)
             //{
             //}
             return res;
         }
    }
}
