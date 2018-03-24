using System;
using System.Collections.Generic;
using System.Data;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public interface IBLProjectCreationRepository
    {
        void AddProject(params Project[] projects);
        int AssignEngForEstimation(string xml, int createdBy, int resourceRequestStatusID, int TaskStatusAccepted, int TaskStatusAssigned);
        string checkEditProjectDate(string ProjectID, DateTime stratDate1, DateTime endDate1);
        void CreateStandardMDL(int projectID, int userID);
        void deleteAllTaskRelatedDataBeyondProjectPeriod(int ProjectID, DateTime StartDate, DateTime EndDate, string DateShift);
        bool deleteproject(int projID);
        string DeleteProjectEstimationTasksDetail(int ProjectID, string MasterTaskType = "1");
        bool GenerateResourceRequest(int projectID);
        void GenerateResourceRequest(int ProjectID, string ProjectStatusFlag, int TaskStatusID, int UserID);
        IList<Project> GetAllProject(int companyId);
        List<object> GetAllProjectCode(int ProjectStatusArchived);
        List<object> GetAllProjectCodeArchived(int ProjectStatusArchived);
        List<object> GetAllProjectCostReport(int ProjectID, string groupby, string distribution);
        List<int> GetAllProjectIDByProjectStatus(string status);
        List<int> GetAllProjectIDOfClosedArchived();
        List<object> GetAllProjectLeader();
        usp_getProjectDataByprojectID_Result GetAllProjectRelatedDataByID(int projectID);
        IList<Project> GetAllProjectsByClientAsset_Client(string Client, int ClientAsset);
        List<ProjectStatu> GetAllProjectStatus();
        List<object> getAssignEngineers(int DeptID, int ProjectID, int EstimationID, int AwaitedID);
        ArrayList GetCurrentlyWorkingOnProjects(DateTime fromdt, DateTime todt, int userid, int EstimationID, int AwaitedID);
        Project GetDummyProjectByCompanyID(int Companyid);
        int getEnableImport(int ProjectID, int ActivityType);
        List<usp_getMilestoneDetailsAndTask_Result> getMilestoneDetailsAndTask(int ProjectID);
        List<usp_ProjectBurnChart_Result> GetPlannedAndAchievedProgress(int ProjectID);
        List<ProjectsAdmin> getProjectAdmin(int ProjectID);
        Project GetProjectByID(int projectID);
        Project GetProjectByIDWithMilestone(int projectID);
       // Project GetProjectByProjectCode(string projectCode, int projectid);
        string getProjectCostHealth(int pkId, string healthType);
        List<usp_getProjectDeptDataByprojectID_Result> getProjectDeptByProjectID(int ProjectID);
        List<object> getProjectDropDownData(string DataType, int DeptID = 0);
        string getProjectScheduleHealth(int ProjectID, string healthType);
        IList<Project> GetProjectsWithNoTaskList();
        List<usp_getProjectTaskOwner_Result> getProjectTaskOwner(int projectID);
        Project GetProjectWithCompanyByID(int projectID);
        List<Project> GetXmlImportProject(int ProjectID);
        bool IsProjectMember(int UserID, int ProjectID);
     //   DataTable LINQToDataTable(IEnumerable<Project> enumerable);
        void RemoveProject(params Project[] projects);
        void ReSetTaskStartDateBeyoundProjectStartDate(int ProjectID, DateTime StartDate, DateTime EndDate, string DateShift);
        List<usp_GetUserArchivedProject_Result> searchArchivedProject(Project project, int ProjectStatus, int UserID);
        List<usp_searchUserProjectList_Result> searchProjectList(int ProjectType, int ProjectStage, int ProjectCode, string ClientProjectNo, int ClientAssetID, int ProjectStatus, string ProjectStartDate, string ProjectEndDate, int ProjectLeader, int UserID, int ProjectStatusArchived, int AwaitedID, int EstimationID);
        IList<SP_GET_SEARCH_BAR_RESULT_Result> SearchResults(string category, int userid, string query);
        List<usp_searchUserProject_Result> searchUserClosedProject(Project project, int UserID, int ProjectStatusArchived);
        List<usp_searchUserProject_Result> searchUserEstimationProject(Project project, int UserID, int ProjectStatusArchived);
        List<usp_searchUserProject_Result> searchUserProject(Project project, int UserID, int ProjectStatusArchived);

        List<Android_usp_GetProjectDetails_Result> GetDashboardProjects(int userID, string searchText, int startIndex, int endIndex, int projectStatus);


        void UpdateProject(params Project[] projects);
        bool UpdateProjectStatus(int ProjectID, string status);
    }
}