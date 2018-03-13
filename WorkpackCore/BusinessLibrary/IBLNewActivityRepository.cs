using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNewActivityRepository
    {
        void AddNewActivities(params NewActivity[] NewActivities);
        void AssignUsersForNewActivity(int newActivityID, int userID, DateTime fromDate, DateTime toDate, decimal hours, int resourceRequestStatusClosed, int taskStatusAccepted, int createdBy);
        void DeleteUsersForNewActivity(int newActivityDetailID);
        IList<NewActivity> GetAllNewActivities();
        List<usp_GetAllNewActivitiesByCreatedUser_Result> GetAllNewActivitiesByCreatedUser(int UserId);
        List<usp_getProjectTaskByProjectID_NPA_Result> GetAllNewActivitiesByCreatedUser(int ProjectID, int UserId);
        List<usp_getApproveNewActivityRecord_Result> getApproveNewActivityRecord(int UserID);
        NewActivity GetNewActivitiesByID(int NewActivityID);
        List<NewActivity> getNewActivityByActivityNumber(string Code, int NewActivityID = 0);
        List<usp_GetNewActivityForApproval_Result> GetNewActivityForApproval(int ApproverUserID);
        void RemoveNewActivities(params NewActivity[] NewActivities);
        void UpdateNewActivities(params NewActivity[] NewActivities);
    }
}