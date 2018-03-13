using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNewActivityRepository : IBLNewActivityRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NewActivity> _NewActivity;

        public BLNewActivityRepository(WorkpackDBContext context, IGenericDataRepository<NewActivity> NewActivity)
        {
            _context = context;
            _NewActivity = NewActivity;
        }
        public IList<NewActivity> GetAllNewActivities()
        {
            return _NewActivity.GetAll();
        }
        public NewActivity GetNewActivitiesByID(int NewActivityID)
        {
            return _NewActivity.GetSingle(d => d.NewActivityID == NewActivityID);
        }
        public void AddNewActivities(params NewActivity[] NewActivities)
        {
            try
            {
                _NewActivity.Add(NewActivities);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNewActivities(params NewActivity[] NewActivities)
        {
            try
            {
                _NewActivity.Update(NewActivities);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNewActivities(params NewActivity[] NewActivities)
        {
            try
            {
                _NewActivity.Remove(NewActivities);
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

        public List<NewActivity> getNewActivityByActivityNumber(string Code, int NewActivityID = 0)
        {
            List<NewActivity> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.NewActivities.Where(a => a.ActivityNo == Code  && a.ActivityNo !="" && a.NewActivityID != NewActivityID).ToList<NewActivity>();
            //}
            return lst;
        }

        public List<usp_GetAllNewActivitiesByCreatedUser_Result> GetAllNewActivitiesByCreatedUser(int UserId)
        {
            List<usp_GetAllNewActivitiesByCreatedUser_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_GetAllNewActivitiesByCreatedUser(UserId).ToList<usp_GetAllNewActivitiesByCreatedUser_Result>();
            //}
            return lst;
        }

        public List<usp_getProjectTaskByProjectID_NPA_Result> GetAllNewActivitiesByCreatedUser(int ProjectID, int UserId)
        {
            List<usp_getProjectTaskByProjectID_NPA_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_getProjectTaskByProjectID_NPA(ProjectID,UserId).ToList<usp_getProjectTaskByProjectID_NPA_Result>();
            //}
            return lst;
        }

        public List<usp_GetNewActivityForApproval_Result> GetNewActivityForApproval(int ApproverUserID)
        {
            List<usp_GetNewActivityForApproval_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_GetNewActivityForApproval(ApproverUserID).ToList<usp_GetNewActivityForApproval_Result>();
            //}
            return lst;
        }

        public List<usp_getApproveNewActivityRecord_Result> getApproveNewActivityRecord(int UserID)
        {
            try
            {
                List<usp_getApproveNewActivityRecord_Result> lst = null;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_getApproveNewActivityRecord(UserID).ToList<usp_getApproveNewActivityRecord_Result>();
                //}
                return lst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public void AssignUsersForNewActivity(int newActivityID, int userID, DateTime fromDate, DateTime toDate, decimal hours, int resourceRequestStatusClosed, int taskStatusAccepted, int createdBy)
        {
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_AssignUsersForNewActivity(newActivityID, userID, fromDate, toDate, hours, resourceRequestStatusClosed, taskStatusAccepted, createdBy);
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public void DeleteUsersForNewActivity(int newActivityDetailID)
        {
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_DeleteUsersForNewActivity(newActivityDetailID);
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
    }
}
