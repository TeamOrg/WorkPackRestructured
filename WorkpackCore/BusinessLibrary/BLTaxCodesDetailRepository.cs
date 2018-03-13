using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaxCodesDetailRepository : IBLTaxCodesDetailRepository
    {
        




        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaxCodesDetail> _taxCodesDetail;

        public BLTaxCodesDetailRepository(WorkpackDBContext context, IGenericDataRepository<TaxCodesDetail> taxCodesDetail)
        {
            _context = context;
            _taxCodesDetail = taxCodesDetail;
        }





        public IList<TaxCodesDetail> GetAllTaxCodesDetail()
        {
            return _taxCodesDetail.GetAll().ToList();
        }
        public TaxCodesDetail GetTaxCodesDetailByID(int TaxCodesDetailID)
        {
            return _taxCodesDetail.GetSingle(d => d.TaxCodeDetailsID == TaxCodesDetailID);
        }

        public IList<TaxCodesDetail> GetAllTaxCodesDetailByTaxCodeID(int TaxCodeID)
        {
            return _taxCodesDetail.GetAll().Where(x => x.TaxCodeID == TaxCodeID).ToList();
        }

        public void AddTaxCodesDetail(params TaxCodesDetail[] TaxCodesDetail)
        {
            try
            {
                _taxCodesDetail.Add(TaxCodesDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaxCodesDetail(params TaxCodesDetail[] TaxCodesDetail)
        {
            try
            {
                _taxCodesDetail.Update(TaxCodesDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaxCodesDetail(params TaxCodesDetail[] TaxCodesDetail)
        {
            try
            {
                _taxCodesDetail.Remove(TaxCodesDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }



    }
}
