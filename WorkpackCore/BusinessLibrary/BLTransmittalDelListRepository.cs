using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTransmittalDelListRepository : IBLTransmittalDelListRepository
    {

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TransmittalDelList> _transmittalDelListRepository;

        public BLTransmittalDelListRepository(WorkpackDBContext context, IGenericDataRepository<TransmittalDelList> transmittalDelListRepository)
        {
            _context = context;
            _transmittalDelListRepository = transmittalDelListRepository;
        }




        public IList<TransmittalDelList> GetAllTransmittalDelLists()
        {
            return _transmittalDelListRepository.GetAll();
        }
        public TransmittalDelList GetTransmittalDelListByID(Int32 TransmittalDelListID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _transmittalDelListRepository.GetSingle(d => d.DelTransmittalId == TransmittalDelListID);                
                //include related employees
        }
        public void AddTransmittalDelList(params TransmittalDelList[] TransmittalDelList)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalDelListRepository.Add(TransmittalDelList);
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
        public void UpdateTransmittalDelList(params TransmittalDelList[] TransmittalDelList)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalDelListRepository.Update(TransmittalDelList);
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
        public void RemoveTransmittalDelList(params TransmittalDelList[] TransmittalDelList)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalDelListRepository.Remove(TransmittalDelList);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                    throw ex;
                //}
            }
        }
    }
}
