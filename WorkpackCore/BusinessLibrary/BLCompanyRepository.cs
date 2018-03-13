using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLCompanyRepository : IBLCompanyRepository
    {
       
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Company> _companyRepository;

        public BLCompanyRepository(WorkpackDBContext context, IGenericDataRepository<Company> companyRepository)
        {
            _context = context;
            _companyRepository = companyRepository;
        }
        public IList<Company> GetAllCompanies()
        {
            return _companyRepository.GetAll();
        }

        public static List<object> GetAllCompaniesObject()
        {
            List<object> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = (from p in db.Companies
            //            select new { CompanyId = p.CompanyId, ComanyName = p.ComanyName }).ToList<object>();
            //}
            return list;
        }

        public Company GetCompanyByCompanyID(Int32 CompanyID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _companyRepository.GetSingle(d => d.CompanyId == CompanyID);                
                //include related employees
        }
        public void AddCompany(params Company[] company)
        {
            /* Validation and error handling omitted */
            try
            {
                _companyRepository.Add(company);
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

        public void UpdateUserAlertFlag(int CompanyId)
        {
            Company lstblCompany = GetCompanyByCompanyID(CompanyId);
            lstblCompany.HideUserAlert = "Y";
            lstblCompany.EntityState = EntityState.Modified;
            SaveCompany(lstblCompany);
        }
        public void UpdateUserAlertFlag1(int CompanyId)
        {
            Company lstblCompany1 = GetCompanyByCompanyID(CompanyId);
            lstblCompany1.HideUserAlertDT = "Y";
            lstblCompany1.EntityState = EntityState.Modified;
            SaveCompany(lstblCompany1);
        }



        public int GetCompanyIDByCompanyName(string companyName)
        {
            int CompanyID = 0;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    Company obj = _companyRepository.GetSingle(p => p.ComanyName.ToUpper() == companyName.ToUpper());
            //    if (obj != null)
            //    {
            //        CompanyID = obj.CompanyId;
            //    }
                return CompanyID;
            //}
        }

        public int SaveCompany(Company objCompany)
        {
            int CompanyID = 0;
       
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.Companies.Attach(objCompany);
                //    context.Entry(objCompany).State = objCompany.EntityState == EntityState.Added ? System.Data.EntityState.Added : System.Data.EntityState.Modified;
                //    context.SaveChanges();
                //    CompanyID = objCompany.CompanyId;                   

                //}
            }
            catch (Exception ex)
            {

                CompanyID = 0;
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }

            return CompanyID;
        }      


        public void UpdateCompany(params Company[] company)
        {
            /* Validation and error handling omitted */
            try
            {
                _companyRepository.Update(company);
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
        public void RemoveRole(params Company[] company)
        {
            /* Validation and error handling omitted */
            try
            {
                _companyRepository.Remove(company);
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
