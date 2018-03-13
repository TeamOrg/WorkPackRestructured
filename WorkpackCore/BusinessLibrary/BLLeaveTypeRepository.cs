using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLLeaveTypeRepository : IBLLeaveTypeRepository
    {        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<LeaveType> _leavetypeRepository;

        public BLLeaveTypeRepository(WorkpackDBContext context, IGenericDataRepository<LeaveType> leavetypeRepository)
        {
            _context = context;
            _leavetypeRepository = leavetypeRepository;
        }


        public IList<LeaveType> GetAllLeaveTypes()
        {
            return _leavetypeRepository.GetAll();
        } 
        public LeaveType GetLeaveTypeByID(Int32 LeaveTypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _leavetypeRepository.GetSingle(d => d.LeaveTypeID == LeaveTypeID);                
                //include related employees
        }        
        public void AddLeaveType(params LeaveType[] LeaveType)
        {
            /* Validation and error handling omitted */
            try
            {
                _leavetypeRepository.Add(LeaveType);
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
        public void UpdateLeaveType(params LeaveType[] LeaveType)
        {
            /* Validation and error handling omitted */
            try
            {
                _leavetypeRepository.Update(LeaveType);
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
        public void RemoveLeaveType(params LeaveType[] LeaveType)
        {
            /* Validation and error handling omitted */
            try
            {
                _leavetypeRepository.Remove(LeaveType);
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
        public Boolean CheckDuplicate(LeaveType LeaveType,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _leavetypeRepository.GetSingle(p => p.LeaveType1.ToUpper() == LeaveType.LeaveType1.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.LeaveTypeID == LeaveType.LeaveTypeID)
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
        public IList<LeaveType> GetLeaveTypeList(LeaveType LeaveType)
        {
            IList<LeaveType> fetchedLeaveType = new List<LeaveType>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<LeaveType> query = Context.LeaveTypes;
                //    if (LeaveType.LeaveType1 != string.Empty)
                //        query = query.Where(p => p.LeaveType1.ToUpper().Contains(LeaveType.LeaveType1.ToUpper()));
                //    fetchedLeaveType = query.ToList();
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
            return fetchedLeaveType;
        }
    }
}
