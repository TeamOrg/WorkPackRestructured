using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNormSetTypeRepository : IBLNormSetTypeRepository
    {

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NormSetType> _NormSetTypeRepository;

        public BLNormSetTypeRepository(WorkpackDBContext context, IGenericDataRepository<NormSetType> NormSetTypeRepository)
        {
            _context = context;
            _NormSetTypeRepository = NormSetTypeRepository;
        }
        public IList<NormSetType> GetAllNormSetType()
        {
            return _NormSetTypeRepository.GetAll();
        }
        public NormSetType GetNormSetTypeByID(Int32 NormSetTypeID)
        {
            return _NormSetTypeRepository.GetSingle(d => d.NormSetTypeID == NormSetTypeID);  
        }
        public void AddNormSetType(params NormSetType[] NormSetType)
        {
            try
            {
                _NormSetTypeRepository.Add(NormSetType);
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
        public void UpdateNormSet(params NormSetType[] NormSetType)
        {
            try
            {
                _NormSetTypeRepository.Update(NormSetType);
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
        public void RemoveNormSet(params NormSetType[] NormSetType)
        {
            try
            {
                _NormSetTypeRepository.Remove(NormSetType);
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
