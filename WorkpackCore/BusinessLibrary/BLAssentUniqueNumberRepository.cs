using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLAssentUniqueNumberRepository : IBLAssentUniqueNumberRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<AssentUniqueNumber> _assentUniqueNumberRepository;

        public BLAssentUniqueNumberRepository(WorkpackDBContext context, IGenericDataRepository<AssentUniqueNumber> assentUniqueNumberRepository)
        {
            _context = context;
            _assentUniqueNumberRepository = assentUniqueNumberRepository;
        }
        public IList<AssentUniqueNumber> GetAllAssentUniqueNumbers()
        {
            return _assentUniqueNumberRepository.GetAll();
        }
        public AssentUniqueNumber GetClientByID(Int32 AssentUniqueNumberID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _assentUniqueNumberRepository.GetSingle(d => d.AssentUniqueNumber1 == AssentUniqueNumberID);                
                //include related employees
        }
        public void AddClient(params AssentUniqueNumber[] assentUniqueNumber)
        {
            /* Validation and error handling omitted */
            try
            {
                _assentUniqueNumberRepository.Add(assentUniqueNumber);
            }
            catch (Exception ex)
            {
                //throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public void UpdateAssentUniqueNumber(params AssentUniqueNumber[] assentUniqueNumber)
        {
            /* Validation and error handling omitted */
            try
            {
                _assentUniqueNumberRepository.Update(assentUniqueNumber);
            }
            catch (Exception ex)
            {
                //throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public List<AssentUniqueNumber> GetAssentUniqueNumberByClientAssetIDYear(int ClientAssetID, string Year)
        {
            List<AssentUniqueNumber> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.AssentUniqueNumbers.Where(p => p.ClientAssetID == ClientAssetID && p.Year == Year).ToList<AssentUniqueNumber>();
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
            return list;
        }

       
    }    
}
