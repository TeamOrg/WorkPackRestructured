using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectStageRepository
    {
        void AddProjectStage(params ProjectStage[] projectstage);
        bool CheckDuplicate(ProjectStage projectstage, bool IsInsert);
        IList<ProjectStage> GetAllProjectStages();
        ProjectStage GetProjectStageByID(int projectstageID);
        IList<ProjectStage> GetProjectStageList(ProjectStage projectstage);
        void RemoveProjectStage(params ProjectStage[] projectstage);
        void UpdateProjectStage(params ProjectStage[] projectstage);
    }
}