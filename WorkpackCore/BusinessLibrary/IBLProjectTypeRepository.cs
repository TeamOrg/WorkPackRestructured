using System.Collections.Generic;
using System.Data;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectTypeRepository
    {
        void AddProjectType(params ProjectTypes[] projecttype);
        bool CheckDuplicate(ProjectTypes projecttype, bool IsInsert);
        IList<ProjectTypes> GetAllProjectTypes();
        ProjectTypes GetProjectTypeByID(int projecttypeID);
        IList<ProjectTypes> GetProjectTypeList(ProjectTypes projecttype);
        int GetProjecTypeIDByProjectTypeCode(string projectTypeCode);
      //  DataTable LINQToDataTable(IEnumerable<ProjectType> enumerable);
        void RemoveProjectType(params ProjectTypes[] projecttype);
        void UpdateProjectType(params ProjectTypes[] projecttype);
    }
}