using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLOverTimeRepository : IBLOverTimeRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<OverTimeRequest> _OverTime;

        public BLOverTimeRepository(WorkpackDBContext context, IGenericDataRepository<OverTimeRequest> OverTime)
        {
            _context = context;
            _OverTime = OverTime;
        }

        public OverTimeRequest GetOverTimeByID(int OverTimeRequestID)
        {
            return _OverTime.GetSingle(d => d.OverTimeRequestID == OverTimeRequestID);
        }
        public IList<usp_GetOverTimeRequestList_Result> GetOverTimeRequestList(OverTimeRequest obj, int UserId)
        {
            IList<usp_GetOverTimeRequestList_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<usp_GetOverTimeRequestList_Result> query = Context.usp_GetOverTimeRequestList(0, UserId, Convert.ToInt32(Common.ProjectStatus.Archived)).AsQueryable<usp_GetOverTimeRequestList_Result>();
                //    if (obj.ProjectID != 0)
                //        query = query.Where(p => p.ProjectID == obj.ProjectID);
                //    if (obj.OverTimeRequestID != 0)
                //        query = query.Where(p => p.OverTimeRequestID == obj.OverTimeRequestID);
                //    if (obj.TaskID != 0)
                //        query = query.Where(p => p.TaskID == obj.TaskID);
                //    if (obj.FromDate != DateTime.MinValue && obj.ToDate != DateTime.MinValue)
                //        query = query.Where(p => ((
                //                                (p.FromDate <= obj.FromDate && obj.FromDate <= p.ToDate) ||
                //                                (p.FromDate <= obj.ToDate && obj.ToDate <= p.ToDate) ||
                //                                (obj.FromDate <= p.FromDate && p.FromDate <= obj.ToDate) ||
                //                                (obj.FromDate <= p.ToDate && p.ToDate <= obj.ToDate)
                //                                 )));
                //    if (obj.OTStatus != string.Empty)
                //        query = query.Where(p => p.OTStatus == obj.OTStatus).OrderByDescending(a => a.OverTimeRequestID);
                //    list = query.ToList();
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
        public IList<object> GetProjectListByUserID(int UserID)
        {
            IList<object> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = ((from p in context.Projects
                //             join t in context.ProjectTaskLists.Where(p2 => p2.TaskOwner == UserID) on p.ProjectID equals t.ProjectID
                //                 into ProjectList
                //             where ProjectList.Any()
                //             select new
                //             {
                //                 ProjectCode = p.ProjectCode + " - " + p.ProjectName,
                //                 p.ProjectID
                //             }).OrderBy(s => s.ProjectCode)).ToList<object>();

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
        public IList<object> GetProjectTaskByProject(int ProjectID, int UserID)
        {
            IList<object> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = ((from t in context.ProjectTaskLists.Where(p => p.ProjectID == ProjectID && p.TaskOwner == UserID)
                //             select new
                //             {
                //                 t.ProjectTaskID,
                //                 t.TaskName
                //             }).OrderBy(p => p.TaskName)).ToList<object>();
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
        public IList<usp_GetProjectRunningTaskByProject_Result> GetProjectRunningTaskByProject(int ProjectID, int userID, DateTime from, DateTime to)
        {
            IList<usp_GetProjectRunningTaskByProject_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetProjectRunningTaskByProject(ProjectID, userID, from, to).ToList<usp_GetProjectRunningTaskByProject_Result>();

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
        public Boolean CheckDate(DateTime fDate, DateTime tDate, int tid, int uid, int OtrequestID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var val = context.OverTimeRequests.Count(p => ((p.FromDate >= fDate || p.ToDate >= fDate) && (p.FromDate <= tDate || p.ToDate <= tDate)
                //        && p.TaskID == tid && p.UserID == uid && p.OverTimeRequestID != OtrequestID));
                //    if (val == 0)
                //        res = true;
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
        public Boolean OTSaveEditDelete(OverTimeRequest ot, string Status)
        {
            Boolean res = false;
            try
            {
                //ObjectParameter p = new ObjectParameter("sQLMessage", typeof(string));
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_OverTimeRequest_InsertEditDel(ot.OverTimeRequestID, ot.FromDate, ot.ToDate, ot.UserID, ot.TaskID,
                //        ot.OtHours, ot.OtJustification, Status, p);
                //    if (Convert.ToString(p.Value) == "INSERTSUCCESS" || Convert.ToString(p.Value) == "UPDATESUCCESS" || Convert.ToString(p.Value) == "DELETESUCCESS")
                //        res = true;
                //}
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
            return res;
        }
        public IList<usp_GetOverTimeRequestForApprove_Result> FetchApproveData(OverTimeRequest obj, int UserID)
        {
            IList<usp_GetOverTimeRequestForApprove_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<usp_GetOverTimeRequestForApprove_Result> query = context.usp_GetOverTimeRequestForApprove(UserID).AsQueryable<usp_GetOverTimeRequestForApprove_Result>();

                //    if (obj.OverTimeRequestID != 0)
                //        query = query.Where(p => p.OverTimeRequestID == obj.OverTimeRequestID);

                //    if (obj.FromDate != DateTime.MinValue && obj.ToDate != DateTime.MinValue)
                //        query = query.Where(p => ((
                //                                (p.FromDate <= obj.FromDate && obj.FromDate <= p.ToDate) ||
                //                                (p.FromDate <= obj.ToDate && obj.ToDate <= p.ToDate) ||
                //                                (obj.FromDate <= p.FromDate && p.FromDate <= obj.ToDate) ||
                //                                (obj.FromDate <= p.ToDate && p.ToDate <= obj.ToDate)
                //                                 )));
                //    if (obj.OTStatus != string.Empty)
                //        query = query.Where(p => p.OTStatus == obj.OTStatus).OrderByDescending(a => a.OverTimeRequestID);
                //    list = query.ToList();
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


        //  (@STARTDATE BETWEEN  PT.StartDate and PT.EndDate) 
        //  OR (@ENDDATE  BETWEEN  PT.StartDate and PT.EndDate)  
        //  OR (PT.StartDate BETWEEN  @STARTDATE and @ENDDATE) 
        //OR (PT.EndDate  BETWEEN @STARTDATE and @ENDDATE) ) 
        //and   (TaskcancelledDate IS NULL OR TaskcancelledDate >=@STARTDATE)     

        public Boolean UpdateApproveStatus(int UserID, int OverTimeRequestID, string Status)
        {
            Boolean res = false;
            try
            {
                //BLMessageRepository blm = new BLMessageRepository();
                //BLOverTimeRepository blo = new BLOverTimeRepository();
                //BLUserRepository blu = new BLUserRepository();
                //ObjectParameter p = new ObjectParameter("sQLMessage", typeof(string));
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_OverTimeRequestApprove_Update(OverTimeRequestID, UserID, Status, p);
                //    if (Convert.ToString(p.Value) == "UPDATESUCCESS")
                //    {

                //        OverTimeRequest ot = blo.GetOverTimeByID(OverTimeRequestID);
                //        User u = blu.GetuserByID(UserID);
                //        string message = Common.MessageConstants.OverTimeApproval.Replace("#ApproverName#", u.FirstName + " " + u.LastName);

                //        Message ms = new Message();
                //        ms.FromUserID = Convert.ToString(UserID);
                //        ms.ToUserID = Convert.ToString(ot.UserID);
                //        ms.RedirectURL = "OverTimeRequestList.aspx";
                //        ms.QueryString = "";
                //        ms.MessageFor = "OverTimeRequestList";
                //        ms.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //        ms.MessageType = "N";
                //        ms.Message1 = message;
                //        ms.Active = "Y";
                //        ms.Date = DateTime.Now;
                //        ms.EntityState = DominModel.EntityState.Added;
                //        blm.AddMessage(ms);
                //        BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();
                //        MessageTemplate mst = new MessageTemplate();
                //        mst = blmt.GetMessageTemplateByMessage(Common.MessageConstants.TimesheetApplying);

                //        if (mst != null && mst.IsEmail == true)
                //        {

                //            blmt.SendNotification(UserID, message, Convert.ToInt32(ot.UserID));
                //        }

                //        res = true;
                //    }
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
        public static decimal GetProjectTaskAllotedHrs(int TaskID)
        {
            decimal res = 0.0m;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = (from a in db.ProjectTaskLists where a.ProjectTaskID == TaskID select a.AllottedHours).FirstOrDefault();
                //    res = val;
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public static int getTaskStatus(int TaskID)
        {
            int res = 0;
            BLTaskListRepository blTask = null;
            try
            {
                //blTask = new BLTaskListRepository();
                //ProjectTaskList objTask = blTask.getTaskDetailsByTaskId(TaskID);
                //res = objTask.TaskStatus.GetValueOrDefault();
            }
            catch (Exception ex)
            {
            }
            return res;
        }




    }
}
