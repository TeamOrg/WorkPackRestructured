using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDepartmentRepository
    {
        void AddDepartment(params Department[] department);
        bool CheckDuplicate(Department department, bool IsInsert);
        IList<Department> GetAllDepartments();
        Department GetDepartmentByID(int departmentID);
        int GetDepartmentByName(string departmentID);
        IList<Department> GetDepartmentList(Department department);
        List<object> getDocumentFilters(int projectId);
        List<object> getRecipientFilters();
        void RemoveDepartment(params Department[] department);
        void UpdateDepartment(params Department[] department);
    }
}