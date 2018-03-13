using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLEstimationTaskDetailRepository
    {
        void ActivityTracker(string Message, string strPage, string userID, string eventname);
        void addCustomPropertiesToFile(string deliverableFolderUrl, string fileUploadDir, int ProjectTaskID, int MilestoneID, int RevisionID = 0);
        OperationResult addEstimationTask(string ProjectID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string IsManHoursDisable, string MasterTaskType = "1");
        void AddEstimationTaskDetails(params EstimationTaskDetail[] EstimationTaskDetail);
        OperationResult addEstimationTask_Contract(string ProjectID, string ProjectContractID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string MasterTaskType = "1");
        OperationResult editEstimationTask(string PrimaryId, string ProjectID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string IsManHoursDisable, int ScopeChangeID = 0, string MasterTaskType = "1");
        OperationResult editEstimationTask_Contract(string PrimaryId, string ProjectID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string MasterTaskType = "1");
        IList<EstimationTaskDetail> GetAllEstimationTaskDetail();
        List<object> getEstimationDetail(int ProjectID);
        List<object> getEstimationDetail_Contract(int ProjectID, int ProjectContractID);
        List<NormsManageTable> getNormsManageTable();
        List<NormsManageTableColumnData> getNormsManageTableColumn();
        List<NormsManageTableColumn> getNormsManageTableColumn(int NormManageTableID);
        List<object> getProjectMilestone(int ProjectID, int MasterTaskType);
        List<object> getProjectMilestoneProgressUpdate(int ProjectID, int ProjectTaskID);
        List<object> getProjectTaskByProjectIDTaskID(int ProjectID, int ProjectTaskID);
        List<object> getSearchProjectMilestone(int ProjectID, List<ProjectTaskList> lstFilteredProjectTask);
        List<object> getSearchTaskDesnByProjectID(int ProjectID, List<ProjectTaskList> lstFilteredProjectTask);
        List<object> getSearchTaskDetail(int ProjectID, List<ProjectTaskList> lstFilteredProjectTask);
        List<object> getSubTaskByProjectIDTaskID(int ProjectID, int ProjectTaskID);
        List<object> getTaskDesnByProjectID(int ProjectID);
        List<object> getTaskDesnByProjectID_Contract(int ProjectID, int ProjectContractID);
        string getTaskSequenceNumber(int ParentTaskID);
        void RemoveEstimationTaskDetails(params EstimationTaskDetail[] EstimationTaskDetail);
        void UpdateEstimationTaskDetails(params EstimationTaskDetail[] EstimationTaskDetail);
        void validateTaskEntry(int normId, bool isProjectLeader, string colValue, EstimationTaskColumnsMaster est, IEnumerable<NormDesDet> pEqVal, IEnumerable<NormDesDet> pEqValNorm, int UserID, int ProjectID, int ProjectTaskId, out OperationResult result, List<DateTime> milestonedates = null, ProjectTaskList ptl = null);
        void validateTaskEntry(int normId, bool isProjectLeader, string colValue, EstimationTaskColumnsMaster est, IEnumerable<NormDesDet> pEqVal, IEnumerable<NormDesDet> pEqValNorm, int UserID, int ProjectID, int ProjectTaskId, string DataMappingID, out OperationResult result, List<object> lstMilestoneReq);
    }
}