using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLILastRuningNumberRepository : IBLILastRuningNumberRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<LastRuningNumber> _lastRuningNumberRepository;

        public BLILastRuningNumberRepository(WorkpackDBContext context, IGenericDataRepository<LastRuningNumber> lastRuningNumberRepository)
        {
            _context = context;
            _lastRuningNumberRepository = lastRuningNumberRepository;
        }


        public IList<LastRuningNumber> GetAllLastRuningNumber()
        {
            return _lastRuningNumberRepository.GetAll();
        }



       
        public void AddLastRuningNumber(params LastRuningNumber[] lastRuningNumber)
        {
            /* Validation and error handling omitted */
            _lastRuningNumberRepository.Add(lastRuningNumber);
        }
        public void UpdateLocation(params LastRuningNumber[] lastRuningNumber)
        {
            /* Validation and error handling omitted */
            _lastRuningNumberRepository.Update(lastRuningNumber);
        }
        public void RemoveLocation(params LastRuningNumber[] lastRuningNumber)
        {
            /* Validation and error handling omitted */
            try
            {
                _lastRuningNumberRepository.Remove(lastRuningNumber);
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

        public List<SP_GENERATE_RUNING_NUMBER_Result> GetRuningNumber(string ClientAssetID,string Year)
        {
            List<SP_GENERATE_RUNING_NUMBER_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.SP_GENERATE_RUNING_NUMBER(Convert.ToInt32(ClientAssetID), Year).ToList<SP_GENERATE_RUNING_NUMBER_Result>();
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
            return list;
        }
       
       
    }
}
