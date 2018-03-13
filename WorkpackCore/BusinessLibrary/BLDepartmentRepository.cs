using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDepartmentRepository : IBLDepartmentRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Department> _departmentRepository;

        public BLDepartmentRepository(WorkpackDBContext context, IGenericDataRepository<Department> departmentRepository)
        {
            _context = context;
            _departmentRepository = departmentRepository;
        }


        public IList<Department> GetAllDepartments()
        {
            List<Department> lst = (from q in _context.Department select q).ToList<Department>();
            return lst;
        }
        public Department GetDepartmentByID(Int32 departmentID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _departmentRepository.GetSingle(d => d.DepartmentID == departmentID);
            //include related employees
        }



        public int GetDepartmentByName(string departmentID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            int query = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    query = context.Departments.Where(c => c.DepartmentName.ToUpper() == departmentID.ToUpper()).Select(c => c.DepartmentID).SingleOrDefault();

            //}
            return query;
            //include related employees
        }
        public void AddDepartment(params Department[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _departmentRepository.Add(department);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateDepartment(params Department[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _departmentRepository.Update(department);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveDepartment(params Department[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _departmentRepository.Remove(department);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                throw ex;
                //}
            }
        }
        public Boolean CheckDuplicate(Department department, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _departmentRepository.GetSingle(p => p.DepartmentCode.ToUpper() == department.DepartmentCode.ToUpper() && p.DepartmentName.ToUpper() == department.DepartmentName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.DepartmentID == department.DepartmentID)
                        Result = true;
                    else
                        Result = false;
                }
                else
                {
                    if (c == null)
                        Result = true;
                    else
                        Result = false;
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return Result;
        }
        public IList<Department> GetDepartmentList(Department department)
        {
            IList<Department> fetchedClient = new List<Department>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<Department> query = Context.Departments;
                //    if (department.DepartmentName != string.Empty)
                //        query = query.Where(p => p.DepartmentName.ToUpper().Contains(department.DepartmentName.ToUpper()));
                //    if (department.DepartmentCode != string.Empty)
                //        query = query.Where(p => p.DepartmentCode.ToUpper().Contains(department.DepartmentCode.ToUpper()));
                //    fetchedClient = query.ToList();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return fetchedClient;
        }
        public List<object> getRecipientFilters()
        {
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    List<Select2GroupData> lstResult = new List<Select2GroupData>();

            //    Select2GroupData s1 = new Select2GroupData();
            //    //s1.id = "0";
            //    s1.text = "Department";
            //    s1.children = (from q in context.Departments.AsEnumerable() select new { text = q.DepartmentName + "-" + q.DepartmentCode, id = "Department-" + q.DepartmentID }).ToList<Object>();

            //    lstResult.Add(s1);

            //    Select2GroupData s2 = new Select2GroupData();
            //    //s2.id = "1";
            //    s2.text = "Role";
            //    s2.children = (from q in context.Roles.AsEnumerable() select new { text = q.RoleName, id = "Role-" + q.RoleID }).ToList<Object>();

            //    lstResult.Add(s2);

            //    Select2GroupData s3 = new Select2GroupData();
            //    //s3.id = "2";
            //    s3.text = "Designation";
            //    s3.children = (from q in context.Designations.AsEnumerable() select new { text = q.DesignationName, id = "Designation-" + q.DesignationID }).ToList<Object>();

            //    lstResult.Add(s3);


            //    return lstResult.ToList<object>();
            //}
            List<object> lstResult = new List<object>();
            return lstResult.ToList<object>();
        }

        public List<object> getDocumentFilters(int projectId)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    List<Select2GroupData> lstResult = new List<Select2GroupData>();

            //    List<ProjectMilestone> lstMilestone = (from q in context.ProjectMilestones where q.ProjectID == projectId select q).ToList<ProjectMilestone>();
            //    List<RevisionFile> lstRevision = (from q in context.RevisionFiles.AsEnumerable() where lstMilestone.Select(a => a.ProjectMilestoneID).Contains(q.StatusID.GetValueOrDefault()) select q).OrderBy(a => a.RevisionID).ToList<RevisionFile>();



            //    Select2GroupData s0 = new Select2GroupData();
            //    //s1.id = "0";
            //    s0.text = "Revision";
            //    s0.children = (from q in lstMilestone.AsEnumerable()
            //                   select new { text = q.ProjectMilestone1, id = "Milestone-" + q.ProjectMilestoneID })
            //                   .Union
            //                   (
            //                   from q in lstRevision.AsEnumerable()
            //                   select new { text = q.RevisionNo, id = "Revision-" + q.RevisionID }
            //                   ).ToList<Object>();

            //    lstResult.Add(s0);

            //    Select2GroupData s1 = new Select2GroupData();
            //    //s1.id = "0";
            //    s1.text = "Department";
            //    s1.children = (from q in context.Departments.AsEnumerable() select new { text = q.DepartmentName + "-" + q.DepartmentCode, id = "Department-" + q.DepartmentID }).ToList<Object>();

            //    lstResult.Add(s1);

            //    Select2GroupData s2 = new Select2GroupData();
            //    //s2.id = "1";
            //    s2.text = "Type";
            //    s2.children = (from q in context.TaskTypes.AsEnumerable() select new { text = q.TaskType1, id = "TaskType-" + q.TaskTypeID }).ToList<Object>();

            //    lstResult.Add(s2);

            //    Select2GroupData s3 = new Select2GroupData();
            //    //s3.id = "2";
            //    s3.text = "Priority";
            //    s3.children = (from q in context.Priorities.AsEnumerable() select new { text = q.PriorityName, id = "Priority-" + q.PriorityID }).ToList<Object>();

            //    lstResult.Add(s3);


            //    return lstResult.ToList<object>();
            //}
            List<object> lstResult = new List<object>();
            return lstResult.ToList<object>();
        }

    }




    public class Select2GroupData
    {
        //public string id { get; set; }
        public string text { get; set; }
        public List<object> children { get; set; }

    }
}
