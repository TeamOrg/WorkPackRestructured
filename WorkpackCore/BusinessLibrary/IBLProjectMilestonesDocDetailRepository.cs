using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectMilestonesDocDetailRepository
    {
        void AddProjectMilestonesDocDetail(params ProjectMilestonesDocDetail[] progressdeliverabledetail);
        List<ProjectMilestonesDocDetail> GetAllpercentageByMilestone(int MilestoneID);
        List<ProjectMilestonesDocDetail> GetAllpercentageByMilestoneAndTaskTypeID(int MilestoneID, int TaskTypeID);
        IList<ProjectMilestonesDocDetail> GetAllProjectMilestonesDocDetail();
        void RemoveProjectMilestonesDocDetail(params ProjectMilestonesDocDetail[] ProjectMilestonesDocDetail);
        void UpdateProjectMilestonesDocDetail(params ProjectMilestonesDocDetail[] progressdeliverabledetail);
    }
}