using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDepartmentRepository_test
    {
        void AddDepartment(params Department_Test[] Department_Test);
        bool CheckDuplicate(Department_Test Department_Test, bool IsInsert);
        IList<Department_Test> GetAllDepartments();
        Department_Test GetDepartmentByID(int departmentID);
        IList<Department_Test> GetDepartmentList(Department_Test Department_Test);
        List<object> GetDepartmentLists();
        bool RemoveDepartment(params Department_Test[] Department_Test);
        void UpdateDepartment(params Department_Test[] Department_Test);
    }
}