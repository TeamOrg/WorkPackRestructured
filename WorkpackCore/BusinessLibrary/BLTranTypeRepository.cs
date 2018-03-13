using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTranTypeRepository : IBLTranTypeRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TranType> _trantypeRepository;

        public BLTranTypeRepository(WorkpackDBContext context, IGenericDataRepository<TranType> trantypeRepository)
        {
            _context = context;
            _trantypeRepository = trantypeRepository;
        }




        public IList<TranType> GetAllTranTypes(int CompanyId)
        {
            return _trantypeRepository.GetAll().Where(a => a.CompanyID == CompanyId).ToList<TranType>();
        }
        public TranType GetTranTypeByID(Int32 TranTypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _trantypeRepository.GetSingle(d => d.TranTypeID == TranTypeID);                
                //include related employees
        }

        public void AddTranType(params TranType[] trantype)
        {
            /* Validation and error handling omitted */
            try
            {
                _trantypeRepository.Add(trantype);
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
        public void UpdateTranType(params TranType[] trantype)
        {
            /* Validation and error handling omitted */
            try
            {
                _trantypeRepository.Update(trantype);
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
        public void RemoveTranType(params TranType[] trantype)
        {
            /* Validation and error handling omitted */
            try
            {
                _trantypeRepository.Remove(trantype);
            }
            catch (Exception ex)
            {
                throw ex;              
            }
        }
    }
}
