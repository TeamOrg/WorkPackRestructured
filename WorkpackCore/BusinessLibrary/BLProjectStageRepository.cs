using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectStageRepository : IBLProjectStageRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectStage> _projectstageRepository;

        public BLProjectStageRepository(WorkpackDBContext context, IGenericDataRepository<ProjectStage> projectstageRepository)
        {
            _context = context;
            _projectstageRepository = projectstageRepository;
        }







        public IList<ProjectStage> GetAllProjectStages()
        {
            return _projectstageRepository.GetAll();
        } 
        public ProjectStage GetProjectStageByID(Int32 projectstageID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _projectstageRepository.GetSingle(d => d.ProjectStageID == projectstageID);                
                //include related employees
        }        
        public void AddProjectStage(params ProjectStage[] projectstage)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectstageRepository.Add(projectstage);
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
        public void UpdateProjectStage(params ProjectStage[] projectstage)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectstageRepository.Update(projectstage);
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
        public void RemoveProjectStage(params ProjectStage[] projectstage)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectstageRepository.Remove(projectstage);
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
        public Boolean CheckDuplicate(ProjectStage projectstage,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _projectstageRepository.GetSingle(p => p.StageName.ToUpper() == projectstage.StageName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.ProjectStageID == projectstage.ProjectStageID)
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
        public IList<ProjectStage> GetProjectStageList(ProjectStage projectstage)
        {
            IList<ProjectStage> fetchedProjectStage = new List<ProjectStage>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<ProjectStage> query = Context.ProjectStages;
                //    if (projectstage.StageName != string.Empty)
                //        query = query.Where(p => p.StageName.ToUpper().Contains(projectstage.StageName.ToUpper()));
                //    fetchedProjectStage = query.ToList();
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
            return fetchedProjectStage;
        }
    }
}
