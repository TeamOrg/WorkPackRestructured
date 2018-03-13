using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTransmittalUserRepository : IBLTransmittalUserRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TransmittalUser> _transmittalUserRepository;

        public BLTransmittalUserRepository(WorkpackDBContext context, IGenericDataRepository<TransmittalUser> transmittalUserRepository)
        {
            _context = context;
            _transmittalUserRepository = transmittalUserRepository;
        }


        public IList<TransmittalUser> GetAllTransmittalUsers()
        {
            return _transmittalUserRepository.GetAll();
        }

        public TransmittalUser GetTransmittalUserByID(Int32 TransmittalUserID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _transmittalUserRepository.GetSingle(d => d.TransmittalUserID == TransmittalUserID);                
                //include related employees
        }
        public void AddTransmittalUser(params TransmittalUser[] TransmittalUser)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalUserRepository.Add(TransmittalUser);
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
        public void UpdateTransmittalUser(params TransmittalUser[] TransmittalUser)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalUserRepository.Update(TransmittalUser);
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
        public void RemoveTransmittalUser(params TransmittalUser[] TransmittalUser)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmittalUserRepository.Remove(TransmittalUser);
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
