using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectsAdminRepository
    {
        void AddProjectsAdmin(params ProjectsAdmin[] ProjectsAdmins);
        IList<ProjectsAdmin> GetAllProjectsAdmin();
        List<User> GetProjectAdminByProjectID(int ProjectID);
        ProjectsAdmin GetProjectsAdminByID(int ProjectsAdminID);
        bool IsProjectAdmin(int projectID, int UserID);
        void RemoveProjectsAdmin(params ProjectsAdmin[] ProjectsAdmins);
        void RemoveProjectsAdminByProjectID(int ProjectID);
        void UpdateProjectsAdmin(params ProjectsAdmin[] ProjectsAdmins);
    }
}