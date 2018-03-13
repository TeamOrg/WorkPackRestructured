using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{

    public class BLTaxTypeRepository : IBLTaxTypeRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaxType> _taxType;

        public BLTaxTypeRepository(WorkpackDBContext context, IGenericDataRepository<TaxType> taxType)
        {
            _context = context;
            _taxType = taxType;
        }





        public IList<TaxType> GetAllTaxType()
        {
            return _taxType.GetAll().ToList();
        }
        public TaxType GetTaxTypeByID(int TaxTypeID)
        {
            return _taxType.GetSingle(d => d.TaxTypeId == TaxTypeID);
        }
        public void AddTaxType(params TaxType[] TaxType)
        {
            try
            {
                _taxType.Add(TaxType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaxType(params TaxType[] TaxType)
        {
            try
            {
                _taxType.Update(TaxType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaxType(params TaxType[] TaxType)
        {
            try
            {
                _taxType.Remove(TaxType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }



    }
}
