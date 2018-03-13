using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectStatusRepository
    {
        void AddProjectStatus(params ProjectStatu[] department);
        IList<ProjectStatu> GetAllProjectStatus();
        List<ProjectStatu> GetAllProjectStatusExceptArchived(int ProjectStatusArchived);
        ProjectStatu GetProjectStatusByID(int departmentID);
        List<ProjectStatu> GetProjectStatusClosedOngoing(int ProjectStatusOngoing, int ProjectStatusClosed);
        void RemoveProjectStatus(params ProjectStatu[] department);
        void UpdateProjectStatus(params ProjectStatu[] department);
    }
}