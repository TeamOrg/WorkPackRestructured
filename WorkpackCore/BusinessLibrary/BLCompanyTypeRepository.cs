using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLCompanyTypeRepository : IBLCompanyTypeRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<CompanyType> _companyType;

        public BLCompanyTypeRepository(WorkpackDBContext context, IGenericDataRepository<CompanyType> companyType)
        {
            _context = context;
            _companyType = companyType;
        }
        public IList<CompanyType> GetAllCompanyType()
        {
            return _companyType.GetAll();
        }
        public CompanyType GetCompanyTypeID(Int32 CompanyTypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _companyType.GetSingle(d => d.CompanyTypeID == CompanyTypeID);                
                //include related employees
        }
        public void AddCompanyType(params CompanyType[] companyType)
        {
            /* Validation and error handling omitted */
            _companyType.Add(companyType);
        }
        public void UpdateCompanyType(params CompanyType[] companyType)
        {
            /* Validation and error handling omitted */
            _companyType.Update(companyType);
        }
        public void RemoveCompanyType(params CompanyType[] companyType)
        {
            /* Validation and error handling omitted */
            try
            {
                _companyType.Remove(companyType);
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
        public Boolean CheckDuplicate(CompanyType companyType, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _companyType.GetSingle(p => p.CompanyTypeName.ToUpper() == companyType.CompanyTypeName.ToUpper() && p.CompanyTypeID == companyType.CompanyTypeID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.CompanyTypeID == companyType.CompanyTypeID)
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
       
    }
}
