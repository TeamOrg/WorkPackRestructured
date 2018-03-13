using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDesignTypeRepository : IBLDesignTypeRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<DesignType> _designTypeRepository;

        public BLDesignTypeRepository(WorkpackDBContext context, IGenericDataRepository<DesignType> designTypeRepository)
        {
            _context = context;
            _designTypeRepository = designTypeRepository;
        }
        public IList<DesignType> GetAllDesignType()
        {
            return _designTypeRepository.GetAll();
        }
        public DesignType GetDesignTypeByID(Int32 DesignTypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _designTypeRepository.GetSingle(d => d.DesignTypeID == DesignTypeID);                
                //include related employees
        }
        public void AddDesignType(params DesignType[] designType)
        {
            /* Validation and error handling omitted */
            _designTypeRepository.Add(designType);
        }
        public void UpdateDesignType(params DesignType[] designType)
        {
            /* Validation and error handling omitted */
            _designTypeRepository.Update(designType);
        }
        public void RemoveDesignType(params DesignType[] designType)
        {
            /* Validation and error handling omitted */
            try
            {
                _designTypeRepository.Remove(designType);
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
        public Boolean CheckDuplicate(DesignType designType, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _designTypeRepository.GetSingle(p => p.DesignTypeName.ToUpper() == designType.DesignTypeName.ToUpper() && p.DesignTypecode.ToUpper() == designType.DesignTypecode.ToUpper() && p.DesignTypeID == designType.DesignTypeID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.DesignTypeID == designType.DesignTypeID)
                        Result = true;
                    else
                        Result = false;
                }
                else
                {
                    if (c == null)
                        Result = true;
                    else
                        Result = false;
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return Result;
        }
       
    }
}
