using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectStatusRepository : IBLProjectStatusRepository
    {
       


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectStatu> _projectStatusRepository;

        public BLProjectStatusRepository(WorkpackDBContext context, IGenericDataRepository<ProjectStatu> projectStatusRepository)
        {
            _context = context;
            _projectStatusRepository = projectStatusRepository;
        }


        public IList<ProjectStatu> GetAllProjectStatus()
        {
            return _projectStatusRepository.GetAll();
        }
        public ProjectStatu GetProjectStatusByID(Int32 departmentID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _projectStatusRepository.GetSingle(d => d.ProjectStatusID == departmentID);
            //include related employees
        }
        public List<ProjectStatu> GetAllProjectStatusExceptArchived(int ProjectStatusArchived)
        {
            List<ProjectStatu> lstStatus = null;
            List<ProjectStatu> lstretStatus = new List<ProjectStatu>();
            try
            {
              
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lstStatus = (from s in context.ProjectStatus                                
                //                 select s).ToList<ProjectStatu>();

                //    foreach (var item in lstStatus)
                //    {
                //        if (item.ProjectStatusID != ProjectStatusArchived)
                //        {
                //            lstretStatus.Add(item);
                //        }
                //    }
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
            return lstretStatus;
        }

        public List<ProjectStatu> GetProjectStatusClosedOngoing(int ProjectStatusOngoing, int ProjectStatusClosed)
        {
            List<ProjectStatu> lstStatus = null;
            List<ProjectStatu> lstretStatus = new List<ProjectStatu>();
            try
            {

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lstStatus = (from s in context.ProjectStatus
                //                 select s).ToList<ProjectStatu>();

                //    foreach (var item in lstStatus)
                //    {
                //        if (item.ProjectStatusID == ProjectStatusOngoing || item.ProjectStatusID == ProjectStatusClosed)
                //        {
                //            lstretStatus.Add(item);
                //        }
                //    }
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
            return lstretStatus;
        }

        public void AddProjectStatus(params ProjectStatu[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectStatusRepository.Add(department);
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
        public void UpdateProjectStatus(params ProjectStatu[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectStatusRepository.Update(department);
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
        public void RemoveProjectStatus(params ProjectStatu[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectStatusRepository.Remove(department);
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
    }
}
