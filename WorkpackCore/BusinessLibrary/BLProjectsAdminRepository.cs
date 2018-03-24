using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectsAdminRepository : IBLProjectsAdminRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectsAdmin> _projectsAdmin;

        public BLProjectsAdminRepository(WorkpackDBContext context, IGenericDataRepository<ProjectsAdmin> projectsAdmin)
        {
            _context = context;
            _projectsAdmin = projectsAdmin;
        }

        public IList<ProjectsAdmin> GetAllProjectsAdmin()
        {
            return _projectsAdmin.GetAll();
        }
        public ProjectsAdmin GetProjectsAdminByID(int ProjectsAdminID)
        {
            return _projectsAdmin.GetSingle(d => d.ProjectsAdminID == ProjectsAdminID);
        }
        public void AddProjectsAdmin(params ProjectsAdmin[] ProjectsAdmins)
        {
            try
            {
                _projectsAdmin.Add(ProjectsAdmins);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectsAdmin(params ProjectsAdmin[] ProjectsAdmins)
        {
            try
            {
                _projectsAdmin.Update(ProjectsAdmins);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectsAdmin(params ProjectsAdmin[] ProjectsAdmins)
        {
            try
            {
                _projectsAdmin.Remove(ProjectsAdmins);
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

        public List<User> GetProjectAdminByProjectID(int ProjectID)
        {
            try
            {
                List<User> lst = null;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = (from t in context.Users
                //           join p in context.ProjectsAdmins on t.UserID equals p.UserID
                //           where p.ProjectID == ProjectID
                //           select t).ToList<User>();
                //}
                return lst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Some error occured.");
            }
        }

        public void RemoveProjectsAdminByProjectID(int ProjectID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.ProjectsAdmins.Where(a => a.ProjectID == ProjectID);
            //        foreach (var item in x)
            //        {
            //            context.ProjectsAdmins.Remove(item);
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
        public Boolean IsProjectAdmin(int projectID, int UserID)
        {
            Boolean IsProjectAdmin = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var items = from item in context.ProjectsAdmins
            //                where item.ProjectID == projectID && item.UserID == UserID
            //                select item;

            //    if (items.Count() > 0)
            //    {
            //        IsProjectAdmin = true;
            //    }

            //}
            return IsProjectAdmin;
        }

      



    }
}
