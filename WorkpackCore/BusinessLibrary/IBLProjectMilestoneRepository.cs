using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectMilestoneRepository
    {
        OperationResult AddCopyFiletoUploadFileDel(string TaskID, string ProjectMilestoneID, string RevisionID, string deptname);
        void AddMilestone(params ProjectMilestone[] projectMilestone);
        int DeleteProgressLevelTemplate(int ProgressLevelTemplateDetailID);
        int GetActivityTypeID(string strActivityType);
        List<ProjectMilestone> GetAllMilestoneByProjectIDTaskTypeID(int projectID, int tasktypeid);
        List<ProjectMilestone> GetAllMilestoneByTaskTypeID(int projectID, int tasktypeid);
        List<MileStoneTaskType> getAllMileStoneTaskType();
        List<ProjectProgressLevelTemplate> getAllProgressLevelTemplte();
        List<ProjectProgressLevelTemplate> getAllProgressLevelTemplte(int CompanyId);
        List<ProjectMilestone> getDisplaypmvalInDb(int ProjectID, int activitytypeid);
        IList<usp_getEditMilestone_Result> getEditMilestone(int TaskID);
        string GetLatestedBookMilestonePer(int projectID, int TaskTypeID, int TaskID);
        ProjectMilestone GetMilestoneByID(int MileStoneId);
        List<ProjectMilestone> GetMilestoneByProjectID();
        List<ProjectMilestone> GetMilestoneByProjectID(int projectID);
        List<ProjectMilestone> GetMilestoneByProjectIDTaskTypeID(int projectID, int TaskTypeID);
        List<ProjectMilestone> GetMilestoneByProjectIDTaskTypeID(int projectID, int TaskTypeID, int TaskSettingID, int WorkFlowTemplateID);
        int GetMilestoneIDFromRevisionID(int RevisionID);
        List<BLProjectMilestoneRepository.Copytabfile> GetMileStoneIdTaskIDofPreviousTab(int TaskID, int ProjectMilestoneID);
        List<BLProjectMilestoneRepository.Copytabfile> GetMileStoneIdTaskIDofPrvTabFrmRvsnToVrsn(int TaskID, int ProjectMilestoneID);
        IList<usp_getProgressLevelByProjectID_Result> getProgressLevelByProjectID(int ProjectID);
        List<ProjectMilestone> GetProgressLevelDetailsByProjectID(int projectID);
        List<usp_getProgressLevelTemplte_Result> getProgressLevelTemplte(int TemplateID);
        int getProjectMileStoneIDByName(string projectMilestoneName, int projectID);
        List<SP_ProjectResourceOverLoading_Result> getProjectResourceLoadingData(DateTime FromDate, DateTime ToDate, int ProjectID, int UserID, string leveloverloading, string display);
        List<usp_PT_VS_NPT_CHART_Result> getPTNPTCHART(DateTime FromDate, DateTime ToDate, int Dept, int Desgn, int ClientAsset, int Project, int ClientId);
        List<BLProjectMilestoneRepository.CopytabRevfile> GetRevIdTaskIDofPreviousTab(int TaskID, int ProjectMilestoneID, int RevisionId);
        string GetRevisionNoByID(int rvsnID);
        List<TaskMilestoneTargetDate> getTaskMilestoneTargetDatesByProjectID(int ProjectID);
        List<MileStoneTaskType> GetTaskTypeByMilestoneID(int MilestoneID);
        List<usp_VOWD_Chart_Result> getVOWDChartData(DateTime FromDate, DateTime ToDate, int Dept, int Desgn, int ClientAsset, int Project, string GroupBy, string groupItem, int ClientID);
        int ImportProgressLevelTemplate(int ProgressLevelTemplateDetailID, int ProjectID);
        string IsPreviousProgressLevelApproved(int TaskID, int ProjectMilestoneID, int RevNumber);
        bool IsSubApproved(int MileStoneId, int TaskID);
        bool IsWorkflowpercentdefined(int MileStoneId);
        int RemoveMilestone(params ProjectMilestone[] projectMilestone);
        int saveProgressLevelTemplate(ProjectProgressLevelTemplate progressTemplate);
        int saveProjectMileStone(List<MileStoneTaskType> lstMileStoneTaskType, ProjectMilestone projectMilestone);
        int saveProjectMileStoneNew(ProjectMilestone projectMilestone);
        void UpdateMilestone(params ProjectMilestone[] projectMilestone);
    }
}