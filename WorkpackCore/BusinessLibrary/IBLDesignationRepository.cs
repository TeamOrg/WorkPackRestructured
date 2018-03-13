using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDesignationRepository
    {
        void AddDesignation(params Designation[] department);
        bool CheckDuplicate(Designation designation, bool IsInsert);
        List<object> GetAllDesgn();
        IList<Designation> GetAllDesignations();
        Designation GetDesignationByID(int designationID);
        IList<Designation> GetDesignationList(Designation designation);
        List<Designation> GetDistinctDesignationByDepartment(int DepartmentID);
        void RemoveDesignation(params Designation[] department);
        void UpdateDesignation(params Designation[] department);
    }
}