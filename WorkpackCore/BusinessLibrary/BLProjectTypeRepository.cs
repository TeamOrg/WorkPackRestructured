using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectTypeRepository : IBLProjectTypeRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectTypes> _projecttypeRepository;

        public BLProjectTypeRepository(WorkpackDBContext context, IGenericDataRepository<ProjectTypes> projecttypeRepository)
        {
            _context = context;
            _projecttypeRepository = projecttypeRepository;
        }
        
        public IList<ProjectTypes> GetAllProjectTypes()
        {
            List<ProjectTypes> lst = (from q in _context.ProjectTypes select q).ToList<ProjectTypes>();
            return lst;
        }
        //public System.Data.DataTable LINQToDataTable(IEnumerable<ProjectType> enumerable)
        //{
        //    return _projecttypeRepository.LINQToDataTable(enumerable);
        //}
        public ProjectTypes GetProjectTypeByID(Int32 projecttypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _projecttypeRepository.GetSingle(d => d.ProjectTypeID == projecttypeID);
            //include related employees
        }
        public void AddProjectType(params ProjectTypes[] projecttype)
        {
            /* Validation and error handling omitted */
            try
            {
                _projecttypeRepository.Add(projecttype);
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
        public void UpdateProjectType(params ProjectTypes[] projecttype)
        {
            /* Validation and error handling omitted */
            try
            {
                _projecttypeRepository.Update(projecttype);
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
        public void RemoveProjectType(params ProjectTypes[] projecttype)
        {
            /* Validation and error handling omitted */
            try
            {
                _projecttypeRepository.Remove(projecttype);
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
        public Boolean CheckDuplicate(ProjectTypes projecttype, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _projecttypeRepository.GetSingle(p => p.ProjectType.ToUpper() == projecttype.ProjectType.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.ProjectTypeID == projecttype.ProjectTypeID)
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
        public IList<ProjectTypes> GetProjectTypeList(ProjectTypes projecttype)
        {
            IList<ProjectTypes> fetchedProjectType = new List<ProjectTypes>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<ProjectType> query = Context.ProjectTypes;
                //    if (projecttype.ProjectType1 != string.Empty)
                //        query = query.Where(p => p.ProjectType1.ToUpper().Contains(projecttype.ProjectType1.ToUpper()));
                //    fetchedProjectType = query.ToList();
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
            return fetchedProjectType;
        }

        //Solar EPC

        public int GetProjecTypeIDByProjectTypeCode(string projectTypeCode)
        {
            int ProjectTypeID = 0;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    var c = Context.ProjectTypes.Where(a => a.ProjectTypeCode == projectTypeCode).ToList<ProjectType>().FirstOrDefault();
                //    if (c != null)
                //        ProjectTypeID = c.ProjectTypeID;                    
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
            return ProjectTypeID;
        }


    }
}
