using System.Collections.Generic;
using System.Data;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectTypeRepository
    {
        void AddProjectType(params ProjectType[] projecttype);
        bool CheckDuplicate(ProjectType projecttype, bool IsInsert);
        IList<ProjectType> GetAllProjectTypes();
        ProjectType GetProjectTypeByID(int projecttypeID);
        IList<ProjectType> GetProjectTypeList(ProjectType projecttype);
        int GetProjecTypeIDByProjectTypeCode(string projectTypeCode);
      //  DataTable LINQToDataTable(IEnumerable<ProjectType> enumerable);
        void RemoveProjectType(params ProjectType[] projecttype);
        void UpdateProjectType(params ProjectType[] projecttype);
    }
}