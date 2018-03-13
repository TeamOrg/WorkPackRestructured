using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLStoresRepository : IBLStoresRepository
    {
        




        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Store> _storesRepository;

        public BLStoresRepository(WorkpackDBContext context, IGenericDataRepository<Store> storesRepository)
        {
            _context = context;
            _storesRepository = storesRepository;
        }







        public IList<Store> GetAllStores(int CompanyID)
        {
            return _storesRepository.GetAll().Where(a => a.CompanyID == CompanyID).ToList<Store>();
        }
        public Store GetStoreByID(Int32 StoreID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _storesRepository.GetSingle(d => d.StoreID == StoreID);                
                //include related employees
        }

        public void AddStore(params Store[] Store)
        {
            /* Validation and error handling omitted */
            try
            {
                _storesRepository.Add(Store);
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
        public void UpdateStore(params Store[] Store)
        {
            /* Validation and error handling omitted */
            try
            {
                _storesRepository.Update(Store);
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
        public void RemoveStore(params Store[] Store)
        {
            /* Validation and error handling omitted */
            try
            {
                _storesRepository.Remove(Store);
            }
            catch (Exception ex)
            {
                throw ex;              
            }
        }
    }
}
