using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDeliverableListRepository
    {
        void AddDeliverableList(params ProjectTaskList[] deliverableList);
        bool deleteTaskById(int DeliverableListID);
        IList<usp_getActivityLogByDelID_Result> getActivityLogByDelID(string DelID);
        IList<Department> GetAllInvolvedDepartments(int ClientId, int ClientAsset, int ProjectID);
        IList<Designation> GetAllInvolvedDesignations(int ClientId, int ClientAsset, int ProjectID);
        IList<User> GetAllInvolvedUser(int ClientId, int ClientAsset, int ProjectID, int Dept, int Desig);
        List<usp_getAllRevisionByProjectID_Result> getAllRevisionByDeliverableID(int DeliverableID, int DeliverableTypeID);
        List<usp_getAllRevisionByProjectIDForDropDown_Result> getAllRevisionByDeliverableIDForDropDown(int DeliverableID, int DeliverableTypeID);
        IList<ProjectTaskList> GetAllUploadDeliverableFile();
        ProjectTaskList GetDeliverableListByID(int deliverableListID);
        int GetDeliverableOwnerIDByFileID(int FileID);
        IList<usp_getDeliverableTaskByUserID_Result> getDeliverableTaskByUserID(string UserID, int Deliverablelst, int TaskAssignedStatusID);
        List<usp_getAllRevisionByProjectID_Result> getDeliverableTypeByDeliverableID(int DeliverableID, int DeliverableTypeID);
        int GetLockCountForProjectList(int ProjectID);
        IList<usp_getMileStoneDetails_Report_Result> getMileStoneDetailsByProjectID_Report(int ProjectID);
        IList<VW_MYTASK> GetMyTask(VW_MYTASK objTask, int ProjectId);
        List<usp_getPendingResponseFileList_Result> getPendingResponseFileList(int UserID);
        ProjectTaskList getTaskDetailsByTaskId(int DeliverableListID);
        int GetTaskIDByTaskObjectID(int TaskObjectID, int ProjectID);
        IList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result> getTaskMilestoneTargetDatesByTask(int DeliverableListID);
        IList<usp_getDeliverableListReportByProjectID_Result> getUpLoadFilesReportByUserID(int UserID);
        IList<usp_UserActivityTracker_Result> getUserActivityTracker();
        void RemoveDeliverableList(params ProjectTaskList[] deliverableList);
        bool saveDeliverable(string data);
        //bool saveProjectTaskList(string xmlTargetDates, ProjectTaskList obj, int DeliverableListID, string xmlTaskDependency, int statusID, int ScopeChangeID);
        bool SendNotificationForTaskOwnerChange(int DelID, string NotfUserID, int ModuleID, int loggedInUser);
        void UpdateDeliverableList(params ProjectTaskList[] deliverableList);
    }
}