using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLScopeChangeTypeRepository : IBLScopeChangeTypeRepository
    {


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ScopeChangeType> _scopeRepository;

        public BLScopeChangeTypeRepository(WorkpackDBContext context, IGenericDataRepository<ScopeChangeType> scopeRepository)
        {
            _context = context;
            _scopeRepository = scopeRepository;
        }
        public IList<ScopeChangeType> GetAllScopeChangeTypes()
        {
            return _scopeRepository.GetAll();
        }
        public ScopeChangeType GetScopeChangeTypeByID(Int32 scopeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _scopeRepository.GetSingle(d => d.ScopeChangeTypeID == scopeID);                
                //include related employees
        }
        public void AddScopeChangeType(params ScopeChangeType[] scope)
        {
            /* Validation and error handling omitted */
            try
            {
                _scopeRepository.Add(scope);
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
        public List<object> getAllProjectScopeChanges()
        {
            List<object> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = (from sc in context.ScopeChanges select new { ScopeChangeID = sc.ScopeChangeID, Title = sc.Title }).ToList<object>();
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
        public void UpdateScopeChangeType(params ScopeChangeType[] scope)
        {
            /* Validation and error handling omitted */
            try
            {
                _scopeRepository.Update(scope);
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
        public void RemoveScopeChangeType(params ScopeChangeType[] scope)
        {
            /* Validation and error handling omitted */
            try
            {
                _scopeRepository.Remove(scope);
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
        public Boolean CheckDuplicate(ScopeChangeType scope,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _scopeRepository.GetSingle(p => p.ScopeChangeTypeCode.ToUpper() == scope.ScopeChangeTypeCode.ToUpper() && p.ScopeChangeType1.ToUpper() == scope.ScopeChangeType1.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.ScopeChangeTypeID == scope.ScopeChangeTypeID)
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
        public IList<ScopeChangeType> GetScopeChangeTypeList(ScopeChangeType scope)
        {
            IList<ScopeChangeType> fetchedScopeChangeType = new List<ScopeChangeType>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<ScopeChangeType> query = Context.ScopeChangeTypes;
                //    if (scope.ScopeChangeType1 != string.Empty)
                //        query = query.Where(p => p.ScopeChangeType1.ToUpper().Contains(scope.ScopeChangeType1.ToUpper()));
                //    if (scope.ScopeChangeTypeCode != string.Empty)
                //        query = query.Where(p => p.ScopeChangeTypeCode.ToUpper().Contains(scope.ScopeChangeTypeCode.ToUpper()));
                //    fetchedScopeChangeType = query.ToList();
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
            return fetchedScopeChangeType;
        }
    }
}
