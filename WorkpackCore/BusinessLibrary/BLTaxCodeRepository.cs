using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{

    public class BLTaxCodeRepository : IBLTaxCodeRepository
    {
       



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaxCode> _taxCode;

        public BLTaxCodeRepository(WorkpackDBContext context, IGenericDataRepository<TaxCode> taxCode)
        {
            _context = context;
            _taxCode = taxCode;
        }





        public IList<TaxCode> GetAllTaxCode()
        {
            List<TaxCode> lst = null;
            return lst;

                //_taxCode.GetAll().Where(a => a.CompanyId == Convert.ToInt32(HttpContext.Current.Session["CompanyId"])).ToList();
        }
        public TaxCode GetTaxCodeByID(int TaxCodeID)
        {
            return _taxCode.GetSingle(d => d.Taxcodeid == TaxCodeID);
        }
        public void AddTaxCode(params TaxCode[] TaxCode)
        {
            try
            {
                _taxCode.Add(TaxCode);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaxCode(params TaxCode[] TaxCode)
        {
            try
            {
                _taxCode.Update(TaxCode);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaxCode(params TaxCode[] TaxCode)
        {
            try
            {
                _taxCode.Remove(TaxCode);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }



    }
}
