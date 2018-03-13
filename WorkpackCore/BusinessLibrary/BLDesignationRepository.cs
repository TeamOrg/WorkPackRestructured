using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDesignationRepository : IBLDesignationRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Designation> _designationRepository;

        public BLDesignationRepository(WorkpackDBContext context, IGenericDataRepository<Designation> designationRepository)
        {
            _context = context;
            _designationRepository = designationRepository;
        }
        public IList<Designation> GetAllDesignations()
        {
            List<Designation> lst = (from q in _context.Designation select q).ToList<Designation>();
            return lst;
        }

        public List<object> GetAllDesgn()
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.Designations select new { q.DesignationID, q.DesignationName, q.DesignationCode, q.DisplayOrder, q.DistributationReq }).ToList<object>();
            //}
            return lst;
        }

        public Designation GetDesignationByID(Int32 designationID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _designationRepository.GetSingle(d => d.DesignationID == designationID);
            //include related employees
        }
        public void AddDesignation(params Designation[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _designationRepository.Add(department);
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
        public void UpdateDesignation(params Designation[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _designationRepository.Update(department);
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
        public void RemoveDesignation(params Designation[] department)
        {
            /* Validation and error handling omitted */
            try
            {
                _designationRepository.Remove(department);
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
        public Boolean CheckDuplicate(Designation designation, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _designationRepository.GetSingle(p => p.DesignationName.ToUpper() == designation.DesignationName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.DesignationID == designation.DesignationID)
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
        public IList<Designation> GetDesignationList(Designation designation)
        {
            IList<Designation> fetchedClient = new List<Designation>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<Designation> query = Context.Designations;
                //    if (designation.DesignationName != string.Empty)
                //        query = query.Where(p => p.DesignationName.ToUpper().Contains(designation.DesignationName.ToUpper()));
                //    if (designation.DesignationCode != string.Empty)
                //        query = query.Where(p => p.DesignationCode.ToUpper().Contains(designation.DesignationCode.ToUpper()));
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
        public List<Designation> GetDistinctDesignationByDepartment(int DepartmentID)
        {
            List<Designation> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = (from u in context.Users
                //            join d in context.Designations on u.DesignationID equals d.DesignationID
                //            where u.DepartmentID == DepartmentID
                //            select d).Distinct().ToList<Designation>();
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
            return List;
        }
        public static IList<Designation> GetDesignationByDept(int Dept, int Project, int ClientAsset)
        {
            IList<Designation> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from dg in db.Designations
                //            join
                //                pt in db.ProjectTaskLists on dg.DesignationID equals pt.DesignationID
                //            join
                //                p in db.Projects on pt.ProjectID equals p.ProjectID

                //            where pt.ProjectID == (Project == 0 ? pt.ProjectID : Project)
                //            && pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept)
                //            && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset)
                //            select dg).Distinct().ToList();
                //}

            }
            catch (Exception ex)
            {
            }
            return list;
        }
    }
}
