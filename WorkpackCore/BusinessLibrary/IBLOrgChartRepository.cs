using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLOrgChartRepository
    {
        List<usp_getMembersCountForProjectUnderFocalPt_Result> GetAllMembersCount(int ProjectID);
        List<usp_FocalPointByProject_Result> GetProjectFocalPoints(int projectID);
        List<usp_ProjectLeaderByProject_Result> GetProjectLeader(int ProjectID);
        List<usp_ProjectsByUserIDForOrgChart_Result> getProjectList(int UserId, int projectAwaitedStatusID, int ProjectStatusArchived);
        List<usp_TeamMembersByProject_Result> GetProjectTeamMembers(int ProjectID, int FocalPoint);
    }
}