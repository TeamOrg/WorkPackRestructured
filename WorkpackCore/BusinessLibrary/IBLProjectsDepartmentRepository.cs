using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectsDepartmentRepository
    {
        void AddProjectsDepartment(params ProjectsDepartment[] ProjectsDepartment);
        void DeleteEstimationInvlovedDept(int ProjectsDeptID, int projectID);
        IList<ProjectsDepartment> GetAllProjectsDepartment();
        ProjectsDepartment GetProjectsDepartmentByID(int projectsDeptID);
        List<ProjectsDepartment> GetProjectsDepartmentByProjectID(int ProjectID);
        List<object> GetProjectsDepartmentForDetailsByProjectID(int ProjectID);
        void RemoveProjectsDepartment(params ProjectsDepartment[] ProjectsDepartment);
        void RemoveProjectsDepartmentByProjectID(int ProjectID);
        void UpdateProjectsDepartment(params ProjectsDepartment[] ProjectsDepartment);
    }
}