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
        private readonly IGenericDataRepository<ProjectType> _projecttypeRepository;

        public BLProjectTypeRepository(WorkpackDBContext context, IGenericDataRepository<ProjectType> projecttypeRepository)
        {
            _context = context;
            _projecttypeRepository = projecttypeRepository;
        }







        public IList<ProjectType> GetAllProjectTypes()
        {
            return _projecttypeRepository.GetAll();
        }
        //public System.Data.DataTable LINQToDataTable(IEnumerable<ProjectType> enumerable)
        //{
        //    return _projecttypeRepository.LINQToDataTable(enumerable);
        //}
        public ProjectType GetProjectTypeByID(Int32 projecttypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _projecttypeRepository.GetSingle(d => d.ProjectTypeID == projecttypeID);
            //include related employees
        }
        public void AddProjectType(params ProjectType[] projecttype)
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
        public void UpdateProjectType(params ProjectType[] projecttype)
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
        public void RemoveProjectType(params ProjectType[] projecttype)
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
        public Boolean CheckDuplicate(ProjectType projecttype, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _projecttypeRepository.GetSingle(p => p.ProjectType1.ToUpper() == projecttype.ProjectType1.ToUpper());
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
        public IList<ProjectType> GetProjectTypeList(ProjectType projecttype)
        {
            IList<ProjectType> fetchedProjectType = new List<ProjectType>();
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
