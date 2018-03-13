using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectleveltaskRepository
    {
        void AddProjectleveltask(params Projectleveltask[] Projectleveltask);
        bool CheckDuplicateofProjectLeveltasks(int projectlevelltaskid, string name);
        Projectleveltask GetProjectleveltaskByID(int Id);
        List<Usp_GetProjectleveltasksForMilestone_Result> GetProjectleveltasksForMilestone(int Projectid);
        void RemoveProjectleveltask(params Projectleveltask[] Projectleveltask);
        void UpdateProjectleveltask(params Projectleveltask[] Projectleveltask);
        void UpdateProjectTaskProgress(int ProjectID, string Completionon, string ActionType);
    }
}