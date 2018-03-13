using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectContractRepository : IBLProjectContractRepository
    {
       

            private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectContract> _projectContractRepository;

        public BLProjectContractRepository(WorkpackDBContext context, IGenericDataRepository<ProjectContract> projectContractRepository)
        {
            _context = context;
            _projectContractRepository = projectContractRepository;
        }




        public IList<ProjectContract> GetAllProjectContract()
        {
            return _projectContractRepository.GetAll();
        }
        public ProjectContract GetProjectContractByID(Int32 ProjectContractID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _projectContractRepository.GetSingle(d => d.ProjectContractID == ProjectContractID);
            //include related employees
        }
        public void AddProjectContract(params ProjectContract[] ProjectContract)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectContractRepository.Add(ProjectContract);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }

        public void UpdateProjectContract(params ProjectContract[] ProjectContract)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectContractRepository.Update(ProjectContract);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveProjectContract(params ProjectContract[] ProjectContract)
        {
            /* Validation and error handling omitted */
            try
            {
                _projectContractRepository.Remove(ProjectContract);
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

        public Boolean CheckDuplicate(string CopyName,int ProjectID)
        {
            Boolean Result = true;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    List<ProjectContract> lst = Context.ProjectContracts.Where(p => p.ProjectID == ProjectID && p.CopyName.ToUpper() == CopyName.ToUpper()).ToList<ProjectContract>();

                //    if (lst.Count() == 0)
                //        Result = true;
                //    else
                //        Result = false;
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
            return Result;
        }

        public List<ProjectContract> GetProjectContractByProjectID(int ProjectID)
        {
            List<ProjectContract> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.ProjectContracts.Where(p => p.ProjectID == ProjectID).OrderBy(a=>a.ProjectContractID).ToList<ProjectContract>();
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
            return list;
        }

        public ProjectContract GetProjectContractByProjectIDAndNormSetIDAndName(int ProjectID, int NormSetID, string CopyName)
        {
            ProjectContract list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.ProjectContracts.Where(p => p.ProjectID == ProjectID && p.NormSetId == NormSetID && p.CopyName == CopyName).SingleOrDefault();
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
            return list;
        }
    }
         
}
