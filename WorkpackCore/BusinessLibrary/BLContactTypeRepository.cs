using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLContactTypeRepository : IBLContactTypeRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ContactType> _contactType;

        public BLContactTypeRepository(WorkpackDBContext context, IGenericDataRepository<ContactType> contactType)
        {
            _context = context;
            _contactType = _contactType;
        }
        public IList<ContactType> GetAllContactType()
        {
            return _contactType.GetAll();
        }
        public ContactType GetContactTypeByID(Int32 ContactTypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _contactType.GetSingle(d => d.ContactTypeID == ContactTypeID);                
                //include related employees
        }
        public void AddContactType(params ContactType[] contactType)
        {
            /* Validation and error handling omitted */
            _contactType.Add(contactType);
        }
        public void UpdateContactType(params ContactType[] contactType)
        {
            /* Validation and error handling omitted */
            _contactType.Update(contactType);
        }
        public void RemoveContactType(params ContactType[] contactType)
        {
            /* Validation and error handling omitted */
            try
            {
                _contactType.Remove(contactType);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public Boolean CheckDuplicate(ContactType contacttype, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _contactType.GetSingle(p => p.ContactType1.Trim().ToUpper() == contacttype.ContactType1.Trim().ToUpper() && p.CompanyID == contacttype.CompanyID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.ContactTypeID == contacttype.ContactTypeID)
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
