using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Collections;
using System.Data;

namespace BusinessLibrary
{
    public class BLTimeSheetRepository : IBLTimeSheetRepository
    {


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TimeSheetWeekly> _timesheetweeklyRepository;

        public BLTimeSheetRepository(WorkpackDBContext context, IGenericDataRepository<TimeSheetWeekly> timesheetweeklyRepository)
        {
            _context = context;
            _timesheetweeklyRepository = timesheetweeklyRepository;
        }





        public TimeSheetWeekly GetTimeSheetWeeklyByID(Int32 TimeSheetWeeklyID)
        {
            return _timesheetweeklyRepository.GetSingle(d => d.TimeSheetWeeklyID == TimeSheetWeeklyID);
        }

        public List<usp_getWeeklyApprovalTimesheet_Result> getApprovalTimesheetRecords(int UserId)
        {
            List<usp_getWeeklyApprovalTimesheet_Result> res = new List<usp_getWeeklyApprovalTimesheet_Result>();
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = context.usp_getWeeklyApprovalTimesheet(UserId).ToList<usp_getWeeklyApprovalTimesheet_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public void UpdateTimeSheetWeekly(params TimeSheetWeekly[] timeSheetWeekly)
        {
            /* Validation and error handling omitted */
            try
            {
                _timesheetweeklyRepository.Update(timeSheetWeekly);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public bool ApproveRejectTimeSheet(int WeeklyId, int UserId, string ApproveFlag, string sessionUser, string rejectionReason)
        {
            bool res = false;
            try
            {
                string[] arr = sessionUser.Split(':');
                string SessionOwnerName = Convert.ToString(arr[1]);
                int SessionOwnerID = Convert.ToInt32(arr[0]);
                //BLTimeSheetRejectionRepository blTsRejc = new BLTimeSheetRejectionRepository();
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    TimeSheetWeekly tw = GetTimeSheetWeeklyByID(WeeklyId);
                //    tw.FinalStatus = ApproveFlag == "A" ? 1 : 0;
                //    if (ApproveFlag == "A")
                //    {
                //        tw.ApprovalDate = DateTime.Now.Date;
                //        //tw.RejectionReason = null;
                //    }
                //    else
                //    {
                //        tw.ApprovalDate = (DateTime?)null;
                //        //  tw.RejectionReason = rejectionReason;
                //        TimeSheetRejection tsr = new TimeSheetRejection();
                //        tsr.TimeSheetWeeklyID = tw.TimeSheetWeeklyID;
                //        tsr.RejectionReason = rejectionReason;
                //        tsr.RejectedBy = SessionOwnerID;
                //        tsr.RejectionDate = DateTime.Now;
                //        tsr.EntityState = DominModel.EntityState.Added;
                //        blTsRejc.AddTimesheetRejection(tsr);

                //    }
                //    //tw.ApprovalDate = ApproveFlag == "A" ? DateTime.Now.Date : (DateTime?)null;
                //    tw.EntityState = DominModel.EntityState.Modified;
                //    UpdateTimeSheetWeekly(tw);









                //    string message = ApproveFlag == "A" ? Common.MessageConstants.TimesheetApproved.Replace("#UserFullName#", SessionOwnerName.ToString()) :
                //        Common.MessageConstants.TimesheetRejected.Replace("#UserFullName#", SessionOwnerName.ToString());

                //    Message BEobjMessage = new Message();
                //    BLMessageRepository BLobjMessage = new BLMessageRepository();

                //    BEobjMessage.MessageID = 0;
                //    BEobjMessage.FromUserID = Convert.ToString(SessionOwnerID);
                //    BEobjMessage.ToUserID = Convert.ToString(UserId);
                //    BEobjMessage.Message1 = message;
                //    BEobjMessage.RedirectURL = "TimeSheetnew.aspx";
                //    BEobjMessage.MessageFor = "TimesheetApproval";
                //    BEobjMessage.QueryString = "WeeklyId=" + WeeklyId.ToString() + "&&UserId=" + UserId.ToString() + "&&IsNotification=Y";
                //    BEobjMessage.Active = "Y";
                //    BEobjMessage.MessageType = "N";
                //    BEobjMessage.EntityState = DominModel.EntityState.Added;
                //    BLobjMessage.AddMessage(BEobjMessage);

                //    res = true;
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    res = false;
                }
            }
            return res;
        }


        public void RemoveTimeSheetWeekly(params TimeSheetWeekly[] timeSheetWeekly)
        {
            /* Validation and error handling omitted */
            try
            {
                _timesheetweeklyRepository.Remove(timeSheetWeekly);
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
        public  IList<usp_getTimeSheetDetails_Result> GetTimeSheet(DateTime fromDate, DateTime toDate, int userId)
        {
            IList<usp_getTimeSheetDetails_Result> List = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    List=Context.usp_getTimeSheetDetails(fromDate,toDate,userId).ToList<usp_getTimeSheetDetails_Result>();
                //}
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
        public IList<usp_getTimeSheetDetailsNew_Result> GetTimeSheetNew(DateTime fromDate, DateTime toDate, int userId)
        {
            IList<usp_getTimeSheetDetailsNew_Result> List = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    List = Context.usp_getTimeSheetDetailsNew(fromDate, toDate, userId).ToList<usp_getTimeSheetDetailsNew_Result>();
                //}
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
        public  IList<usp_GetTimeSheetWeeklyDetail_Result> GetTimeSheetWeeklyDetails(DateTime fromDate, DateTime toDate, int userId)
        {
            IList<usp_GetTimeSheetWeeklyDetail_Result> List = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    List = Context.usp_GetTimeSheetWeeklyDetail(fromDate, toDate, userId).ToList<usp_GetTimeSheetWeeklyDetail_Result>();
                //}
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
        public static IList<TimeSheetWeekly> GetWeeklyrecord(int weekid)
        {
            IList<TimeSheetWeekly> timesheetwkly = null;
            try
            {
                //using(var context=new Cubicle_EntityEntities())
                //{
                //    timesheetwkly = context.TimeSheetWeeklies.Where(a => a.TimeSheetWeeklyID == weekid).ToList<TimeSheetWeekly>();
                //}
            }
            catch(Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return timesheetwkly;
        }
        public static IList<WeeklyTaskList> GetWeeklyTaskListrecord(DateTime fromdt,DateTime todt,int taskid,int userid)
        {
            IList<WeeklyTaskList> wklytask = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    wklytask = context.WeeklyTaskLists.Where(a => a.WeekStartDate == fromdt && a.WeekEndDate == todt && a.UserID == userid && a.TaskID == taskid).ToList<WeeklyTaskList>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return wklytask;
        }
        public string RemoveTimesheetWeeklyDetailsByTaskWeekUserID(string TaskID, int WeekID, int UserID, DateTime fromDate, DateTime toDate)
        {
            string res = "0";
            //BLTimeSheetRepository bltimesheet = new BLTimeSheetRepository();
            //BLWeeklyTaskListRepository blWeek = new BLWeeklyTaskListRepository();
            //BLTimeSheetDeviationRepository bltimesheetdev = new BLTimeSheetDeviationRepository();
            //try
            //{
            //    BLTimeSheetWeeklyDetailRepository blweeklydtl = new BLTimeSheetWeeklyDetailRepository();
            //    List<TimeSheetWeeklyDetail> weeklydtl = blweeklydtl.GetAllTimeSheetWeeklyDetailByTaskWeekUserID(Convert.ToInt32(TaskID), WeekID, UserID).ToList<TimeSheetWeeklyDetail>();
            //    foreach (var item in weeklydtl)
            //    {
            //        item.EntityState = DominModel.EntityState.Deleted;
            //        blweeklydtl.RemoveTimeSheetWeeklyDetail(item);
            //    }

            //    List<TimeSheetDeviation> timedev = bltimesheetdev.GetAllTimeSheetDeviationByWeekTaskID(WeekID, Convert.ToInt32(TaskID)).ToList<TimeSheetDeviation>();
            //    if (timedev.Count > 0)
            //    {
            //        foreach (var item in timedev)
            //        {
            //            item.EntityState = DominModel.EntityState.Deleted;
            //            bltimesheetdev.RemoveTimeSheetDeviation(item);
            //        }
            //    }
            //    List<TimeSheetWeeklyDetail> lst = blweeklydtl.GetTimeSheetWeeklyDetailByweekID(WeekID);
            //    if (lst.Count() == 0)
            //    {
            //        List<TimeSheetWeekly> timesheetwkly = BLTimeSheetRepository.GetWeeklyrecord(WeekID).ToList<TimeSheetWeekly>();
            //        foreach (var item in timesheetwkly)
            //        {
            //            item.EntityState = DominModel.EntityState.Deleted;
            //            bltimesheet.RemoveTimeSheetWeekly(item);
            //        }
            //    }
            //    res = "1";
            //}
            //catch (Exception ex)
            //{
            //    res = "0";
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return res;
        }

        public IList<TimeSheetWeekly> GetTimeSheetWeeklyByWeek(DateTime fromDate, DateTime toDate,int UserID,int TaskID)
        {
            IList<TimeSheetWeekly> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = (from t in context.TimeSheetWeeklies join p in context.TimeSheetWeeklyDetails on t.TimeSheetWeeklyID equals p.TimeSheetWeeklyID
                //            where t.TimeSheetFromDate == fromDate && t.TimeSheetToDate == toDate && p.UserID==UserID && p.TaskID==TaskID
                //            select t).ToList <TimeSheetWeekly>();

                    
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<HolidayCalendar> getHolidayBetweenDate(DateTime fromDate, DateTime toDate)
        {
            IList<HolidayCalendar> list = null;
            try
            {

                //BLProjectCreationRepository objproject = new BLProjectCreationRepository();
                //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = (from a in context.HolidayCalendars
                //            where a.WorkingDate >= fromDate && a.WorkingDate <= toDate
                //                && (a.day_type_code == "WO" || a.day_type_code == "CH") && a.ProjectID == projectID
                //            select a).ToList<HolidayCalendar>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<DailyWorkingHr> getWorkingHrs()
        {
            IList<DailyWorkingHr> list = null;
            //BLDailyWorkingHrRepository _dailyWorkingHrRepository=null;
            //BLProjectCreationRepository objproject = new BLProjectCreationRepository();
            //  int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //  int? projectID = objproject.GetDummyProjectByCompanyID(companyId).ProjectID;

            //try
            //{
            //    _dailyWorkingHrRepository=new BLDailyWorkingHrRepository();
            //    list = _dailyWorkingHrRepository.GetAllDailyWorkingHrs().Where(a=>a.ProjectID==projectID).OrderBy(p => p.Orderday).ToList();
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return list;
        }
        public ArrayList saveTimeSheet(TimeSheet objTimeSheet, string xmlDetailTimeSheet, string xmlTimeSheetDeviation, string xmlTimeSheetLeave, int FinalStatus)
        {
            ArrayList arr = null;
            //ObjectParameter p=null;
            //try
            //{
            //    arr = new ArrayList();
            //    p=new ObjectParameter("sqlMsg",typeof(string));
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        var val = context.usp_saveTimeSheet(objTimeSheet.TimeSheetFromDate, objTimeSheet.TimeSheetToDate,
            //            objTimeSheet.UserID, objTimeSheet.TimeSheetWeeklyID, xmlDetailTimeSheet, xmlTimeSheetDeviation, xmlTimeSheetLeave, FinalStatus, p);
            //    }
            //    arr.Add(p.Value);
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return arr;
        }
        public IList<usp_getApproveTimeSheetRecord_Result> getApproveTimeSheetRecord(int UserID)
        {
            IList<usp_getApproveTimeSheetRecord_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    ObjectParameter sqlOutPut = new ObjectParameter("SqlCountOutput", typeof(int));
                //    list = Context.usp_getApproveTimeSheetRecord(UserID, sqlOutPut).ToList<usp_getApproveTimeSheetRecord_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public bool getFinalLockStatusTimeSheetWeekly(DateTime WeekStartDate,int UserID)
        {
            bool status = false;
            DateTime? date=WeekStartDate.Date;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    int cStatus = (from TW in Context.TimeSheetWeeklies
                //                   join
                //                   TWD in Context.TimeSheetWeeklyDetails on TW.TimeSheetWeeklyID equals TWD.TimeSheetWeeklyID
                //                   where TW.TimeSheetFromDate == date && TWD.UserID == UserID && TW.FinalStatus == 1
                //                   select TW).Count();
                //    if (cStatus != 0)
                //        status = true;
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return status;
        }

        public Boolean saveApproveTimeSheet(string xmlTargetDates)
        {
            Boolean res = false;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //   var val= Context.usp_editApproveTimeSheet(xmlTargetDates).FirstOrDefault().GetValueOrDefault();
                //   if (val == 1)
                //       res = true;
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }

        public static decimal GetActualManhoursByMonth(DateTime Month, int DeptId, int DesigId, int ProjectID)
        {
            decimal ActualHrs = 0.0M;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var list = from TW in db.TimeSheetWeeklies
                //               join
                //                   TWD in db.TimeSheetWeeklyDetails on TW.TimeSheetWeeklyID equals TWD.TimeSheetWeeklyID
                //               join pt in db.ProjectTaskLists on TWD.TaskID equals pt.ProjectTaskID
                //               where pt.DepatmentID==(DeptId==0?pt.DepatmentID:DeptId) &&
                //               pt.DesignationID == (DesigId == 0 ? pt.DesignationID : DesigId) &&
                //                pt.ProjectID == (ProjectID == 0 ? pt.ProjectID : ProjectID) &&
                //                TWD.TimesheetDate.Month==Month.Month && TWD.TimesheetDate.Year==Month.Year
                //                && TW.FinalStatus==1
                //               select new
                //               {
                //                   TWD.TimesheetDate,
                //                   TWD.NorHrs,
                //                   pt.ProjectID,
                //                   pt.DepatmentID,
                //                   pt.DesignationID
                //               };
                //    ActualHrs = list.Sum(p => p.NorHrs);
                //}
            }
            catch (Exception ex)
            {
            }
            return ActualHrs;
        }

        public static IList<usp_ResourceDistributionChart_Result> GetResourceDistributionChartData(DateTime date, int ClientId, int CAssetId, int ProjectId,
           int DeptId, int DesigId, int UserId, string GroupBy, string AvailableHourseries, int Display)
        {
            IList<usp_ResourceDistributionChart_Result> list = null;
            try
            {
                //int EstimationID = Convert.ToInt32(Common.ProjectStatus.Estimation);
                //int AwaitedID = Convert.ToInt32(Common.ProjectStatus.Awaited);
            
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var lst = db.usp_ResourceDistributionChart(date, ClientId, CAssetId, ProjectId, DeptId, DesigId, UserId, GroupBy, AvailableHourseries, EstimationID, AwaitedID).ToList<usp_ResourceDistributionChart_Result>();
                //    list = new List<usp_ResourceDistributionChart_Result>();
                //    decimal NormalHrs = BLDailyWorkingHrRepository.NormalWorkingHrsPerPersonInMonth(date);
                //    if (Display == 1)
                //    {
                //        foreach (var l in lst)
                //        {
                //            if (l.Absolute_Numbers.GetValueOrDefault() == 0.0M || NormalHrs == 0.0M)
                //                l.Absolute_Numbers = 0.0m;
                //            else
                //                l.Absolute_Numbers = decimal.Round((l.Absolute_Numbers.GetValueOrDefault() / NormalHrs),2);
                //        }
                //    }

                //    foreach (var l in lst)
                //    {
                //        l.Absolute_Numbers= l.Absolute_Numbers <= 0 ? 0 : l.Absolute_Numbers;
                //        decimal per=Math.Round( (( l.Absolute_Numbers.GetValueOrDefault()==0 ||lst.Sum(p=>p.Absolute_Numbers.GetValueOrDefault())==0?0: (l.Absolute_Numbers.GetValueOrDefault()/lst.Sum(p=>p.Absolute_Numbers.GetValueOrDefault()))*100)),2);
                //        list.Add(new usp_ResourceDistributionChart_Result(l.Absolute_Numbers.GetValueOrDefault(), l.Resources_Distributed_Across_ID, l.Resources_Distributed_Across_Name, l.Resources_Distributed_Across_Code, per));
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        //public static IList<usp_ResourceDistributionChart_Result> GetResourceDistributionChartData(DateTime date, int ClientId, int CAssetId, int ProjectId,
        //    int DeptId, int DesigId, int UserId)
        //{
        //    IList<usp_ResourceDistributionChart_Result> list = null;
        //    try
        //    {
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //            list = db.usp_ResourceDistributionChart(date, ClientId, CAssetId, ProjectId, DeptId, DesigId, UserId).ToList<usp_ResourceDistributionChart_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return list;
        //}

        public List<usp_getUnlockTimeSheetMasterData_Result> getUnlockTimeSheetMasterData(int userID)
        {
            List<usp_getUnlockTimeSheetMasterData_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getUnlockTimeSheetMasterData(userID).ToList<usp_getUnlockTimeSheetMasterData_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public void UnlockTimeSheet(int UserID,DateTime WeekStartDate,string Remark,int CreatedBy)
        {
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    db.usp_UnlockTimeSheet(UserID, WeekStartDate, Remark, CreatedBy);
                //}
            }
            catch (Exception ex)
            {
            }
        }

        public List<usp_getUnlockTimeSheetPreviousData_Result> getUnlockTimeSheetPreviousData(int UnlockTimeSheetWeeklyID)
        {
            List<usp_getUnlockTimeSheetPreviousData_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getUnlockTimeSheetPreviousData(UnlockTimeSheetWeeklyID).ToList<usp_getUnlockTimeSheetPreviousData_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }


        public static DataTable ExecuteActatekSql(string sql)
        {
            DataTable dt = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    SqlConnection conn = new SqlConnection("Data Source=HQ5R5W32S\\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=actatek3");
            //    conn.Open();
            //    try
            //    {
            //        if (conn.State != ConnectionState.Open)
            //            conn.Open();
            //        SqlCommand cmd = new SqlCommand(sql, conn);
            //        SqlDataAdapter dadapter = new SqlDataAdapter(sql, conn);
            //        dadapter.Fill(dt);
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
            return dt;
        }

    }
}
