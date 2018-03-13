using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectlevelTaskDependencyRepository : IBLProjectlevelTaskDependencyRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectlevelTaskDependency> _projectlevelTaskDependency;

        public BLProjectlevelTaskDependencyRepository(WorkpackDBContext context, IGenericDataRepository<ProjectlevelTaskDependency> projectlevelTaskDependency)
        {
            _context = context;
            _projectlevelTaskDependency = projectlevelTaskDependency;
        }




        public ProjectlevelTaskDependency GetProjectlevelTaskDependencyByID(int Id)
        {
            return _projectlevelTaskDependency.GetSingle(d => d.TaskDependencyID == Id);
        }


        public void AddProjectlevelTaskDependency(params ProjectlevelTaskDependency[] ProjectlevelTaskDependency)
        {
            try
            {
                _projectlevelTaskDependency.Add(ProjectlevelTaskDependency);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectlevelTaskDependency(params ProjectlevelTaskDependency[] ProjectlevelTaskDependency)
        {
            try
            {
                _projectlevelTaskDependency.Update(ProjectlevelTaskDependency);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectlevelTaskDependency(params ProjectlevelTaskDependency[] ProjectlevelTaskDependency)
        {
            try
            {
                _projectlevelTaskDependency.Remove(ProjectlevelTaskDependency);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public Boolean DeleteProjectlevelTaskDependency(int TaskDependencyID)
        {
            Boolean res = false;
            try
            {
                ProjectlevelTaskDependency obj = GetProjectlevelTaskDependencyByID(TaskDependencyID);
                obj.EntityState = DomainModelLibrary.EntityState.Deleted;
                RemoveProjectlevelTaskDependency(obj);
                res = true;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }

    }
}
