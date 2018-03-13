using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public class BLResourceRequestRepository : IBLResourceRequestRepository
    {


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ResourceRequest> _resourceRequest;

        public BLResourceRequestRepository(WorkpackDBContext context, IGenericDataRepository<ResourceRequest> resourceRequest)
        {
            _context = context;
            _resourceRequest = resourceRequest;
        }

        public IList<ResourceRequest> GetAllResourceRequest()
        {
            return _resourceRequest.GetAll();
        }

        public ResourceRequest GetResourceRequestByID(int ResourceRequestID)
        {
            return _resourceRequest.GetSingle(d => d.ResourceRequestID == ResourceRequestID);
        }
        public void AddResourceRequest(params ResourceRequest[] ResourceRequest)
        {
            try
            {
                _resourceRequest.Add(ResourceRequest);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateResourceRequest(params ResourceRequest[] ResourceRequest)
        {
            try
            {
                _resourceRequest.Update(ResourceRequest);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveResourceRequestDesignation(params ResourceRequest[] ResourceRequest)
        {
            try
            {
                _resourceRequest.Remove(ResourceRequest);
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

        public static int GetResourceRequesteCountInAwardPhase(int ProjectID,int deptId,int RequestID)
        {
            int recCount = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    recCount = (from r in context.ResourceRequests
                //                join ra in context.ResourceAllocations on r.ResourceRequestID equals ra.ResourceRequestID
                //                where r.ProjectID == ProjectID && r.DepartmentID==deptId && r.RequestID==RequestID && (r.IsEstimationRequest=="N")
                //                && (r.SysGen!="Y" || r.SysGen==null) select r.ResourceRequestID).Count();
                             
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
            return recCount;
        }



        public static int CheckAccept(int ProjectID, int deptId, int RequestID)
        {
            int recCount = 0;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    var RequestHrs = (from r in context.ResourceRequests
                ////                      where r.ProjectID == ProjectID && r.DepartmentID == deptId && r.RequestID == RequestID
                ////                      && (r.SysGen != "Y" || r.SysGen == null)
                ////                      select r.AllottedManhours).Sum();



                ////    var AllocateHrs = (from r in context.ResourceRequests
                ////                       join ra in context.ResourceAllocations on r.ResourceRequestID equals ra.ResourceRequestID
                ////                       where r.ProjectID == ProjectID && r.DepartmentID == deptId && r.RequestID == RequestID
                ////                       && (r.SysGen != "Y" || r.SysGen == null)
                ////                       select ra.AllocatedManHrs).Sum();
                ////    if (RequestHrs == AllocateHrs)
                ////    {
                ////        recCount = 1;
                ////    }
                ////}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return recCount;
        }





        public static List<string> CheckUpdatedResourceRequest(int ProjectID)
        {
            List<string> res = new List<string>();
            List<ResourceRequest> lstResource = null;
            List<ProjectTaskList> lstTaskLists = null;            
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lstResource = context.ResourceRequests.Where(c => c.ProjectID == ProjectID).ToList<ResourceRequest>();
                 
                //    foreach (var item in lstResource)
                //    {
                //        lstTaskLists = (from pt in context.ProjectTaskLists
                //                        join td in context.TaskDesignations on pt.ProjectTaskID equals td.ProjectTaskID
                //                        where
                //                            td.ProjectID == ProjectID && pt.DepatmentID == item.DepartmentID && pt.RequestID == item.RequestID && td.DesignationID == item.DesignationID
                //                        select pt).ToList<ProjectTaskList>();
                //        List<int> lsttaskids = new List<int>();
                //        foreach (var t in lstTaskLists)
                //        {
                //            lsttaskids.Add(Convert.ToInt32(t.ProjectTaskID));
                //        }
                //        decimal TDallottedhrs = context.TaskDesignations.Where(c => lsttaskids.Contains(c.ProjectTaskID) && c.DesignationID==item.DesignationID).Select(r => r.Hours).Sum();
                //        decimal RRallottedhrs = item.AllottedManhours;

                //        DateTime smindate = lstTaskLists.Select(c =>Convert.ToDateTime( c.StartDate)).Min();
                //        DateTime emaxdate = lstTaskLists.Select(c => Convert.ToDateTime(c.EndDate)).Max();

                //        if (TDallottedhrs != RRallottedhrs || smindate!=item.FromDate || emaxdate!=item.ToDate)
                //        {
                //            res.Add("false");
                //            break;
                //        }


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
        public static int IsAwardedResourceRequest(int ProjectID)
        {
            int recCount = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    recCount = (from r in context.ResourceRequests
                //                where r.ProjectID == ProjectID && (r.IsEstimationRequest == "N")
                //                && (r.SysGen != "Y" || r.SysGen==null)
                //                select r.ResourceRequestID).Count();

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
            return recCount;
        }


        public static ArrayList GetResourceRequester(string ProjectID)
        {
            ArrayList aUserID = new ArrayList();
            try
            {
                int projectId = Convert.ToInt32(ProjectID);
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var list = (from r in context.Projects
                //                join s in context.Users on r.ProjectLeader equals s.UserID
                //                where r.ProjectID == projectId
                //                select new
                //                {
                //                    r.ProjectLeader,
                //                    UserName = s.FirstName + "-" + s.LastName,
                //                    r.ProjectCode
                //                }).FirstOrDefault();


                //    aUserID.Add(list.ProjectLeader);
                //    aUserID.Add(list.UserName);
                //    aUserID.Add(list.ProjectCode);
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
            return aUserID;
        }

        public static ArrayList getAllProjectTeamMembers(int ProjectID)
        {
            ArrayList arrUserList = new ArrayList();          
            try
            {               
                //using (var context = new Cubicle_EntityEntities())
                //{

                //    var usersList = (from rr in context.ResourceRequests
                //                        join ra in context.ResourceAllocations
                //                        on rr.ResourceRequestID equals ra.ResourceRequestID
                //                        where rr.ProjectID == ProjectID
                //                        select new { UserID = ra.UserID }).Distinct();
                //    foreach (var userlist in usersList)
                //    {
                //        arrUserList.Add(userlist.UserID);
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
            return arrUserList;
        }
        public List<ResourceAllocation> DisableAllocatedResources(int ResourceRequestID)
        {
            List<ResourceAllocation> lstUsers = null;
            try
            {               
                //using (var db = new Cubicle_EntityEntities())
                //{

                //    lstUsers = (from RR in db.ResourceRequests
                //                join RA in db.ResourceAllocations on RR.ResourceRequestID equals RA.ResourceRequestID
                //                where  RR.ResourceRequestID == ResourceRequestID
                //                select RA).ToList<ResourceAllocation>();
                //}
               
            }
            catch (Exception ex)
            {

            }
            return lstUsers;
        }


      



        public static IList<usp_getResourceRequest_Result> getResourceRequest(int ProjectID)
        {
            IList<usp_getResourceRequest_Result> list = null;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    list = context.usp_getResourceRequest(ProjectID, Convert.ToInt32(Common.ResourceRequestStatusID.Closed)).ToList<usp_getResourceRequest_Result>();
                ////}
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
        public static Boolean UpdateFocalPoint(int RequestID, int DeptID, int ProjectID)
        {
            Boolean res = false;

            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    //int val = context.UPDATEFOCAL_POINT(RequestID, DeptID, ProjectID);
                //    //if (val > 0)
                //    //    res = true;
                //}
            }
            catch (Exception ex)
            {
                res = false;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public static bool UpdateResourceRequestStatus(int ResourceRequestID, int StatusID)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            var ResourceRequestList = from a in context.ResourceRequests where a.ResourceRequestID == ResourceRequestID select a;
            //            foreach (var val in ResourceRequestList)
            //            {
            //                val.ResourceRequestStatus = StatusID.ToString();
            //                context.Entry(val).State = System.Data.EntityState.Modified;
            //            }
            //            context.SaveChanges();
            //            if (Convert.ToInt32(Common.ResourceRequestStatusID.Closed) == StatusID)
            //            {
            //                var ProjectTaskList = from a in context.ProjectTaskLists where a.ResourceRequestID == ResourceRequestID select a;
            //                foreach (var val in ProjectTaskList)
            //                {
            //                    val.TaskStatus = Convert.ToInt32(Common.TaskStatusID.ResourceAccepted);
            //                    context.Entry(val).State = System.Data.EntityState.Modified;
            //                }
            //                context.SaveChanges();
            //            }
            //            ts.Complete();
            //            res = true;
            //        }
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
        public static bool saveResourceRequest(int ResourceRequestID, int NoOfResources)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            var ResourceRequestList = from a in context.ResourceRequests where a.ResourceRequestID == ResourceRequestID select a;
            //            foreach (var val in ResourceRequestList)
            //            {
            //                val.NoOfResource = NoOfResources;
            //                val.ResourceRequestStatus = Convert.ToInt32(Common.ResourceRequestStatusID.PendingForAllocation).ToString();
            //                context.Entry(val).State = System.Data.EntityState.Modified;
            //            }
            //            context.SaveChanges();
            //            ts.Complete();
            //            res = true;
            //        }
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
        public static IList<usp_ViewResourceRequest_Result> ViewResourceRequest(int ProjectID)
        {
            IList<usp_ViewResourceRequest_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_ViewResourceRequest(ProjectID).ToList<usp_ViewResourceRequest_Result>();
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
        public static IList<GET_FP_PL_TW_TASK_Result> GET_FP_PL_TW_TASK(int taskID)
        {
            IList<GET_FP_PL_TW_TASK_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //   list= context.GET_FP_PL_TW_TASK(taskID).ToList<GET_FP_PL_TW_TASK_Result>();
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

       //public static int IsAllAllocationDone(int ProjectID)
       // {
       //     //select COUNT(*) from ResourceRequest Where ProjectID=545  and ResourceRequestStatus >=4
       //     int count = 0;
       //    int AllocatedID=Convert.ToInt32(Common.ResourceRequestStatusID.Allocated);
       //     try
       //     {
       //         using (var context = new Cubicle_EntityEntities())
       //         {
       //            // var list = context.ResourceRequests.Where(x => x.ProjectID == ProjectID).Select(x => new Int_ListItem { itemField1 = x.ProjectID, itemField2 = x.ResourceRequestStatusNo.GetValueOrDefault() });
       //             var list = context.ResourceRequests.Where(x => x.ProjectID == ProjectID).Select(x => x.ResourceRequestStatus).ToList<string>().Select<string,int>(q=>Convert.ToInt32(q));

       //             count = list.Where(x => x < AllocatedID).Count();
                             
                  
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
       //         if (false)
       //         {
       //             throw ex;
       //         }
       //     }
       //     return count;
       // }


       public List<ResourceRequest> GetResourceRequestByProjectIDRequestIDAndDeptID(int ProjectID, int RequestID, int DeptID)
       {
           List<ResourceRequest> list = null;
           try
           {
               //using (var context = new Cubicle_EntityEntities())
               //{
               //    list = context.ResourceRequests.Where(a => a.ProjectID == ProjectID && a.RequestID == RequestID && a.DepartmentID == DeptID).ToList<ResourceRequest>();
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

       public List<ResourceRequest> GetResourceRequestByProjectID(int ProjectID)
       {
           List<ResourceRequest> list = null;
           try
           {
               //using (var context = new Cubicle_EntityEntities())
               //{
               //    list = context.ResourceRequests.Where(a => a.ProjectID == ProjectID && (a.SysGen != "Y" || a.SysGen == null)).ToList<ResourceRequest>();
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






       public List<int> GetAllDistinctResources(int ProjectID)
       {
           List<int> list = null;
           try
           {
               //using (var db = new Cubicle_EntityEntities())
               //{
               //    list = (from RR in db.ResourceRequests
               //            join RA in db.ResourceAllocations on RR.ResourceRequestID equals RA.ResourceRequestID
               //            where RR.ProjectID == ProjectID
               //            select (RA.UserID)).Distinct().ToList<int>();
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
    }
}