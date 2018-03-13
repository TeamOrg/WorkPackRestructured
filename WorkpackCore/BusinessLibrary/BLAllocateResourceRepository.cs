using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLAllocateResourceRepository : IBLAllocateResourceRepository
    {       

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ResourceAllocation> _resourceAllocation;

        public BLAllocateResourceRepository(WorkpackDBContext context, IGenericDataRepository<ResourceAllocation> resourceAllocation)
        {
            _context = context;
            _resourceAllocation = resourceAllocation;
        }


        
        public IList<ResourceAllocation> GetAllResourceAllocation()
        {
            return _resourceAllocation.GetAll();
        }

           public void RemoveResourceRequestAllocation(params ResourceAllocation[] ResourceAllocation)
        {
            try
            {
                _resourceAllocation.Remove(ResourceAllocation);
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


















        public static IList<usp_getAllocatedResourceRequestByDeptID_Result> getAllocateResourceByDeptID(string DeptID, int ProjectStatusArchived)
        {
            IList<usp_getAllocatedResourceRequestByDeptID_Result> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.usp_getAllocatedResourceRequestByDeptID(Convert.ToInt32(DeptID), Convert.ToInt32(Common.ResourceRequestStatusID.Closed), ProjectStatusArchived).ToList<usp_getAllocatedResourceRequestByDeptID_Result>();
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






     


        public static bool saveComment(Comment obj)
        {
            Boolean res = false;
             BLCommentRepository _blComment=null;
            try
            {
                //_blComment = new BLCommentRepository();
                //_blComment.AddComment(obj);
                res = true;
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
        public static IList<usp_GetTaskListByResourceRequest_Result> geTaskListByResourceRequest(int ResourceRequestID)
        {
            IList<usp_GetTaskListByResourceRequest_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetTaskListByResourceRequest(ResourceRequestID).ToList<usp_GetTaskListByResourceRequest_Result>();
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
        public static IList<usp_getAllocatedResourceRequestByResourceID_Result> getAllocateResourceByResourceID(int ProjectID, int UserID, int RequestID, int DeptID)
        {
            IList<usp_getAllocatedResourceRequestByResourceID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getAllocatedResourceRequestByResourceID(RequestID, ProjectID, UserID, DeptID).ToList<usp_getAllocatedResourceRequestByResourceID_Result>();
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
        public static IList<usp_getAllocatedResourceRequestByResourceManagerID_Result> getAllocateResourceByResourceManagerID(int ProjectID, int UserID, int RequestID)
        {
            IList<usp_getAllocatedResourceRequestByResourceManagerID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getAllocatedResourceRequestByResourceManagerID(RequestID, ProjectID, UserID).ToList<usp_getAllocatedResourceRequestByResourceManagerID_Result>();
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








        public static Boolean isResourceAllocationUpdate(int RequestID, Int32 deptID, int projectID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var resut = (from a in context.ResourceAllocations
                //                 join r in context.ResourceRequests on a.ResourceRequestID equals r.ResourceRequestID
                //                 where  r.RequestID == RequestID && r.DepartmentID == deptID && r.ProjectID == projectID &&
                //                 (a.AllocatedManHrs == null ? 0 : a.AllocatedManHrs) > 0 && (r.SysGen == null ? "N" : r.SysGen) == "N"
                //                 select a).Count();
                //    if (resut > 0)
                //    {
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



        public static Boolean isResourceAddedInAllocation(int ResourceRequestID, Int32 UserID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var resut = (from a in context.ResourceAllocations
                //                 where a.ResourceRequestID == ResourceRequestID && a.UserID==UserID
                //                 select a).Count();
                //    if (resut > 0)
                //    {
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





        public static IList<usp_getUserByDeptId_Result> getUserByDeptId(int DeptID)
        {
            IList<usp_getUserByDeptId_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getUserByDeptId(DeptID).ToList<usp_getUserByDeptId_Result>();
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
        public static IList<usp_getUserByDeptIdAndDesnId_Result> getUserByDeptIdAndDesnId(int DeptID, int ProjectID)
        {
            IList<usp_getUserByDeptIdAndDesnId_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getUserByDeptIdAndDesnId(DeptID, ProjectID).ToList<usp_getUserByDeptIdAndDesnId_Result>();
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
        public static Decimal getAvailableHrsByUserID(DateTime startDate, DateTime endDate, int UserID, int EstimationID, int AwaitedID)
        {
            Decimal functionReturnValue = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    System.Data.Objects.ObjectParameter p = new System.Data.Objects.ObjectParameter( "AvailableHrs",0);
                //    var result = context.usp_getAvailableHrsByUserID(startDate, endDate, UserID, EstimationID, AwaitedID, p).First();
                //    functionReturnValue = result.Value;
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
            return functionReturnValue;
        }
        public static IList<usp_getReseAllocationByResourceReqId_Result> getReseAllocationByResourceReqId(int ResourceRequestID)
        {
            IList<usp_getReseAllocationByResourceReqId_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getReseAllocationByResourceReqId(ResourceRequestID).ToList<usp_getReseAllocationByResourceReqId_Result>();
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

        public static List<usp_getResourceAllocationByProjectIdRequestIDAndDeptID_Result> getResourceAllocationByProjectIdRequestIDAndDeptID(int ProjectId, int RequestID, int DeptID)
        {
            List<usp_getResourceAllocationByProjectIdRequestIDAndDeptID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getResourceAllocationByProjectIdRequestIDAndDeptID(ProjectId, DeptID, RequestID).ToList<usp_getResourceAllocationByProjectIdRequestIDAndDeptID_Result>();
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

       
        public static Boolean saveAllocatedUser(IList<ResourceAllocation> objList)
        {
            Boolean result = false;
          
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {



                   
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            foreach (var a in objList)
            //            {
                            

            //                context.Entry(a).State = System.Data.EntityState.Added;
            //                context.SaveChanges();
            //            }
            //            ts.Complete();
            //            result = true;
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        result = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return result;
        }

        public static Boolean deleteUserByAllocationID(int id, int UserID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var count=(from p in context.ProjectTaskLists join a in context.ResourceAllocations on
                //                                                 p.ResourceRequestID equals a.ResourceRequestID where a.ResourceAllocationID==id
                //                                                 && p.TaskOwner==UserID && p.ActualStartDate !=null select a).Count();
                //    if (count == 0)
                //    {
                //        var obj = context.ResourceAllocations.FirstOrDefault(p => p.ResourceAllocationID == id);
                //        context.Entry(obj).State = System.Data.EntityState.Deleted;
                //        context.SaveChanges();
                //        res = true;
                //    }
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
        public static Boolean saveAllocatedResource(IList<ResourceAllocation> AllocationList, IList<ResourceRequest> RequestList, String isProjectUnderEstimationPhase)
        {
            Boolean res = false;
            //int FocalPointID = 0;
            //string strResourceRequestStatusID = "";
            //if (isProjectUnderEstimationPhase == "Y")
            //{
            //strResourceRequestStatusID = Convert.ToInt32(Common.ResourceRequestStatusID.PlannedAllocation).ToString();
            //}
            //else
            //{
            //    strResourceRequestStatusID = Convert.ToInt32(Common.ResourceRequestStatusID.Allocated).ToString();
            //}
            //BLTaskListRepository blTask = new BLTaskListRepository();
            //BLResourceRequestRepository blResReq = new BLResourceRequestRepository();
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            foreach (var val in AllocationList)
            //            {
            //                if (val.IsFocalPoint == "Y")
            //                {
            //                    FocalPointID = val.UserID;
            //                }
            //                var objA = context.ResourceAllocations.FirstOrDefault(p => p.ResourceAllocationID == val.ResourceAllocationID);
            //                objA.IsFocalPoint = val.IsFocalPoint;
            //                objA.allocatedFromDate = val.allocatedFromDate;
            //                objA.allocatedToDate = val.allocatedToDate;
            //                objA.AllocatedManHrs = val.AllocatedManHrs;
            //                objA.ModifiedOn = val.ModifiedOn;
            //                objA.ModifiedBy = val.ModifiedBy;
            //                context.Entry(objA).State = System.Data.EntityState.Modified;                            
            //            }
            //            context.SaveChanges();
            //            ResourceRequest resReq = null;
            //            foreach (var Rval in RequestList)
            //            {
            //                //string status=Convert.ToInt32(ResourceRequestStatusID.Closed).ToString();
            //                //var objR = context.ResourceRequests.FirstOrDefault(p => p.ResourceRequestID == Rval.ResourceRequestID && p.ResourceRequestStatus != status);
            //                string status = strResourceRequestStatusID.ToString();
            //                var objR = context.ResourceRequests.FirstOrDefault(p => p.ResourceRequestID == Rval.ResourceRequestID);
            //                if (objR != null)
            //                {
            //                    objR.ResourceRequestStatus = status;
            //                    context.Entry(objR).State = System.Data.EntityState.Modified;
            //                }

            //                if (resReq == null)
            //                    resReq = blResReq.GetResourceRequestByID(Rval.ResourceRequestID);
                            
            //            }
            //            context.SaveChanges();

            //            //if (resReq != null)
            //            //{
            //            //    List<ProjectTaskList> lst = blTask.getProjectTaskByDeptIdProjectIDAndRequestID(resReq.ProjectID, resReq.DepartmentID, Convert.ToInt32(resReq.RequestID));
            //            //    foreach (var item in lst)
            //            //    {
            //            //        item.FocalPoint = FocalPointID;
            //            //        item.EntityState = DominModel.EntityState.Modified;
            //            //    }

            //            //    blTask.UpdateTaskList(lst.ToArray());
            //            //}

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

        public List<ResourceAllocation> AllocatedResourcesByProjectID(int ProjectID)
        {
            List<ResourceAllocation> lst = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{

                //    lst = (from RR in db.ResourceRequests
                //           join RA in db.ResourceAllocations on RR.ResourceRequestID equals RA.ResourceRequestID
                //           where RR.ProjectID == ProjectID && (RR.SysGen != "Y" || RR.SysGen ==null)
                //           select RA).ToList<ResourceAllocation>();
                //}

            }
            catch (Exception ex)
            {

            }
            return lst;
        }



        public List<ResourceAllocation> chkIsFocalPointByProjectID(int ProjectID, int UserID)
        {
            List<ResourceAllocation> lst = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{

                //    lst = (from RR in db.ResourceRequests
                //           join RA in db.ResourceAllocations on RR.ResourceRequestID equals RA.ResourceRequestID
                //           where RR.ProjectID == ProjectID && RA.UserID == UserID && RA.IsFocalPoint== "Y" && (RR.SysGen != "Y" || RR.SysGen == null)
                //           select RA).ToList<ResourceAllocation>();
                //}

            }
            catch (Exception ex)
            {

            }
            return lst;
        }


        public static IList<usp_getAssignedUser_Result> getAssignedUser(int ProjectID, int DeptID, int Requestid)
        {

            IList<usp_getAssignedUser_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getAssignedUser(ProjectID, DeptID, Requestid).ToList<usp_getAssignedUser_Result>();
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

