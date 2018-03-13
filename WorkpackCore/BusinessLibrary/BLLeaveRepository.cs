using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLLeaveRepository : IBLLeaveRepository
    {  
        public IList<usp_getLeaveList_Result> GetAllLeaveRecords(Leave objLeave, int UserID, DateTime fromdate, DateTime Todate, String Leavestatus)
        {
            IList<usp_getLeaveList_Result> fetchedClient = null;
            //CultureInfo ci = new CultureInfo("en-Gb");
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    IQueryable<usp_getLeaveList_Result> query = Context.usp_getLeaveList(0, UserID,fromdate,Todate,Leavestatus).AsQueryable<usp_getLeaveList_Result>();
            //    fetchedClient = query.ToList();
            //}
            return fetchedClient;
        }
        public Boolean InsertEditDeleteLeave(Leave obj,string status)
        {
            Boolean res = false;
            try
            {
                //ObjectParameter p=new ObjectParameter("sQLMessage",typeof(string));
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    Context.usp_Leave_InsertEditDel(obj.LeaveID, obj.LeaveTypeID, obj.FromDate, obj.ToDate, obj.Remark,
                //        obj.UserID, obj.IsHalfDay, status, p);
                //    if (Convert.ToString(p.Value) == "INSERTSUCCESS" || Convert.ToString(p.Value) == "UPDATESUCCESS" || Convert.ToString(p.Value) == "DELETESUCCESS")
                //        res = true;
                //}
                return res;
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
        public Leave GetLeaveRecordById(int LeaveId)
        {
            Leave l = new Leave();
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //   l= db.Leaves.FirstOrDefault(p => p.LeaveID == LeaveId);
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
            return l;
        }
        public int GetLeaveRecordByDate(DateTime date,int UserID)
        {
            int cnt = 0;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    cnt = db.Leaves.Where(p=>p.FromDate <= date && p.ToDate >=date && p.IsHalfDay=="N" && p.UserID==UserID  && p.ApprovedBY >0).Count();
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
            return cnt;
        }
        public Boolean CheckLeavPeriod(Leave obj)
        {
            Boolean res = false;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    var val = Context.Leaves.Count(p => (p.FromDate >= obj.FromDate || p.ToDate >= obj.FromDate)
                //        && (p.FromDate <= obj.ToDate || p.ToDate <= obj.ToDate) && p.UserID==obj.UserID && p.LeaveID!=obj.LeaveID);
                //    if (val == 0)
                //        res = true;
                //}
                return res; 
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
        public IList<usp_getLeavApprovedList_Result> GetLeaveApprovedLiat(Leave objLeave,Int32 UserID)
        {
            IList<usp_getLeavApprovedList_Result> fetchedClient = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<usp_getLeavApprovedList_Result> query = Context.usp_getLeavApprovedList(UserID).AsQueryable<usp_getLeavApprovedList_Result>();
                //    if (objLeave.LeaveID != 0)
                //        query = query.Where(p => p.LeaveID == objLeave.LeaveID);
                //    if (objLeave.ApprovedBY != -1)
                //    {
                //        if (objLeave.ApprovedBY == 1)
                //            query = query.Where(p => p.ApprovedBy > 0);
                //        else
                //            query = query.Where(p => p.ApprovedBy == 0);
                //    }
                //    if (objLeave.FromDate != DateTime.MinValue && objLeave.ToDate != DateTime.MinValue)
                //        query = query.Where(p => ((
                //                                (p.FromDate <= objLeave.FromDate && objLeave.FromDate <= p.ToDate) ||
                //                                (p.FromDate <= objLeave.ToDate && objLeave.ToDate <= p.ToDate) ||
                //                                (objLeave.FromDate <= p.FromDate && p.FromDate <= objLeave.ToDate) ||
                //                                (objLeave.FromDate <= p.ToDate && p.ToDate <= objLeave.ToDate)
                //                                 )));
                //    fetchedClient = query.ToList();
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
            return fetchedClient;
        }

        //((
        //                                        (p.FromDate <= obj.FromDate && obj.FromDate <= p.ToDate) ||
        //                                        (p.FromDate <= obj.ToDate && obj.ToDate <= p.ToDate) ||
        //                                        (obj.FromDate <= p.FromDate && p.FromDate <= obj.ToDate) ||
        //                                        (obj.FromDate <= p.ToDate && p.ToDate <= obj.ToDate)
        //                                         ))

        public Boolean SaveApprovedStatus(Int32 LeaveId, Int32 UserID)
        {
            Boolean res = false;
            try
            {
                //ObjectParameter p=new ObjectParameter("sQLMessage",typeof(string));
                //using(var Context = new Cubicle_EntityEntities())
                //{
                //    Context.usp_LeaveApproved_Update(LeaveId, UserID, p);
                //    if (Convert.ToString(p.Value) == "UPDATESUCCESS") {

                //        Message BEobjMessage = new Message();
                //        BLMessageRepository BLobjMessage = new BLMessageRepository();
                //        BLLeaveRepository blleve = new BLLeaveRepository();
                //        BLUserRepository blu = new BLUserRepository();
                       
                //        Leave l = blleve.GetLeaveRecordById(LeaveId);
                //        User u = blu.GetuserByID(UserID);
                //        BEobjMessage.MessageID = 0;
                //        BEobjMessage.FromUserID = Convert.ToString(UserID);
                //        BEobjMessage.ToUserID = Convert.ToString(l.UserID);
                //        BEobjMessage.Message1 = Common.MessageConstants.LeaveApproveNotif.Replace("#ApproverName#", u.FirstName+" "+u.LastName);
                //        BEobjMessage.RedirectURL = "LeaveList.aspx";
                //        BEobjMessage.MessageFor = "LeaveList";
                //        BEobjMessage.Active = "Y";
                //        BEobjMessage.MessageType = "N";
                //        BEobjMessage.EntityState = DominModel.EntityState.Added;
                //        BLobjMessage.AddMessage(BEobjMessage);
                //        BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();

                //        MessageTemplate mst = blmt.GetMessageTemplateByMessage(Common.MessageConstants.LeaveApproveNotif);

                //        if (mst.IsEmail == true)
                //        {

                //            blmt.SendNotification(BEobjMessage.FromUserID, BEobjMessage.Message1, Convert.ToInt32(l.UserID));
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
    }
}
