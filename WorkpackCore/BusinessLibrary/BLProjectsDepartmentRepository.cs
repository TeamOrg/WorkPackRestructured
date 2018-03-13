using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectsDepartmentRepository : IBLProjectsDepartmentRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectsDepartment> _projectDepartment;

        public BLProjectsDepartmentRepository(WorkpackDBContext context, IGenericDataRepository<ProjectsDepartment> projectDepartment)
        {
            _context = context;
            _projectDepartment = projectDepartment;
        }





        public IList<ProjectsDepartment> GetAllProjectsDepartment()
        {
            return _projectDepartment.GetAll();
        }
        public ProjectsDepartment GetProjectsDepartmentByID(int projectsDeptID)
        {
            return _projectDepartment.GetSingle(d => d.ProjectsDepartmentID == projectsDeptID);
        }
        public void AddProjectsDepartment(params ProjectsDepartment[] ProjectsDepartment)
        {
            try
            {
                _projectDepartment.Add(ProjectsDepartment);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectsDepartment(params ProjectsDepartment[] ProjectsDepartment)
        {
            try
            {
                _projectDepartment.Update(ProjectsDepartment);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectsDepartment(params ProjectsDepartment[] ProjectsDepartment)
        {
            try
            {
                _projectDepartment.Remove(ProjectsDepartment);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }

        public void RemoveProjectsDepartmentByProjectID(int ProjectID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.ProjectsDepartments.Where(a => a.ProjectID == ProjectID);
            //        foreach (var item in x)
            //        {
            //            context.ProjectsDepartments.Remove(item);
            //            context.SaveChanges();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw new Exception("Record not deleted.");
            //    }
            //}
        }


        public List<ProjectsDepartment> GetProjectsDepartmentByProjectID(int ProjectID)
        {
            try
            {
                List<ProjectsDepartment> lst = null;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.ProjectsDepartments.Include("Department").Where(a => a.ProjectID == ProjectID).ToList<ProjectsDepartment>();
                //}
                return lst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Some error occured.");
            }
        }

        

        public List<object> GetProjectsDepartmentForDetailsByProjectID(int ProjectID)
        {
            try
            {
                List<object> lst = null;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = (from q in context.ProjectsDepartments
                //           join r in context.Departments on q.DepartmentID equals r.DepartmentID
                //           where q.ProjectID == ProjectID
                //           select new { q.ProjectsDepartmentID, q.ProjectID, Hours = q.Hours, q.Submissiondate, r.DepartmentName }).ToList<object>();
                //}
                return lst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Some error occured.");
            }
        }


        public void DeleteEstimationInvlovedDept(int ProjectsDeptID,int projectID)
        {
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_DeleteEstimationInvlovedDept(projectID, ProjectsDeptID);
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Some error occured.");
            }
        }
    }

    
}
