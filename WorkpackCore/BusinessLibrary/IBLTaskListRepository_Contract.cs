using System;
using System.Collections.Generic;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public interface IBLTaskListRepository_Contract
    {
        void AddTaskList(params ProjectTaskList_Contract[] TaskList);
        void BackUpTaskListDetailAtEstimationPhase(int projectId);
        OperationResult checkUserRightsOnTask(int UserID, int TaskId);
        bool copyContrTask(string ProjectID, string Name, int NormSetID);
        bool deleteTaskById(int ProjectTaskID);
        bool deleteTaskByTaskId(int ProjectTaskID);
        IList<Department> GetAllInvolvedDepartments(string ClientId, int ClientAsset, int ProjectID);
        IList<Designation> GetAllInvolvedDesignations(string ClientId, int ClientAsset, int ProjectID, int Dept);
        IList<User> GetAllInvolvedUser(string ClientId, int ClientAsset, int ProjectID, int Dept, int Desig);
        IList<ProjectTaskList_Contract> GetAllTaskList();
        List<ProjectTaskList_Contract> GetAllTaskListByProjectID(int ProjectID);
        List<ProjectTaskList_Contract> GetAllTaskListExcludingSysTaskByProjectID(int ProjectID);
        IList<usp_getDelayTaskLit_Result> GetDelayTaskList(int userID, DateTime PresentDate);
        DataTable GetEstimationTaskDesignationSummary(int projectId, DataTable taskList);
        List<ProjectTaskList_Contract> GetEstimationTaskListByProjectID(int ProjectID);
        DataTable GetEstimationTaskListSummary(DataTable taskList, int projectid);
        int GetLockCountForProjectList(int ProjectID);
        IList<object> getLockTaskCreationSummaryLock(int projectID);
        IList<usp_getMileStoneDetails_Report_Result> getMileStoneDetailsByProjectID_Report(int ProjectID);
        IList<usp_getMileStoneTargetDatesDetails_Report_Result> getMileStoneTargetDatesDetails_Report(int ProjectID);
        IList<VW_MYTASK> GetMyTask(VW_MYTASK objTask, int ProjectId);
        IList<usp_getOnGoingMyTaskList_Result> getOnGoingTaskList(int UserID);
        List<ProjectTaskList> getProjectTaskByDeptIdProjectIDAndRequestID(int ProjectID, int DeptID, int RequestID);
        IEnumerable<ProjectTaskListSlickGrid> getProjectTaskByProjectID(int ProjectID);
        List<usp_getProjectTaskByProjectID_Result> getProjectTaskByProjectID1(int ProjectID, int UserID, string IsOtherClient, int MasterTaskTypeID);
        IEnumerable<ProjectTaskListSlickGrid> getSubmittedProjectTaskByProjectID(int ProjectID);
        int GetTaskCountByProjectIDAndNormSetID(int ProjectID, int NormSetID);
        IList<usp_getTaskCreationSummary_Result> getTaskCreationSummary(int projectID);
        IList<object> getTaskCreationSummaryLock(int projectID);
        DataTable GetTaskDesignationSummary(int projectId, DataTable taskList);
        ProjectTaskList_Contract getTaskDetailsByTaskId(int ProjectTaskID);
        int GetTaskIDByTaskObjectID(int TaskObjectID, int ProjectID);
        ProjectTaskList_Contract GetTaskListByID(int TaskID);
        DataTable GetTaskListSummary(DataTable taskList, int projectid);
        IList<usp_TaskMilestoneTargetDatesByProjectTaskID_Result> getTaskMilestoneTargetDatesByTask(int ProjectTaskID);
        IList<usp_getTaskStatusReportByProjectID_Result> getTaskStatusReportByProjectID(int ProjectID);
        List<ProjectTaskList> GetXmlImportTask(int ProjectID);
        bool IsAllTaskScheduled(int ProjectID);
        string IsProjectScheduledOnce(string ProjectID);
        void RemoveTaskList(params ProjectTaskList_Contract[] TaskList);
        bool saveProjectTaskList(string xmlTargetDates, ProjectTaskList obj, int ProjectTaskID, string xmlTaskDependency, int statusID, int ScopeChangeID, out int VPojectTaskID1);
        OperationResult SetStartEndDateUsingDate(string StartDate, string EndDate, int Duration, int projectID);
        OperationResult SetStartEndDateUsingDuration(int ProjectID, int Duration);
        string SubmitEstimationTaskByAllDepartment(string ProjectID);
        bool TaskUnderScopeChange(string PrimaryId, string ProjectID, string UserID, Dictionary<string, string[]> item, string mode, string ScopeChangeID);
        void UpdateTaskList(params ProjectTaskList_Contract[] TaskList);
    }
}