using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLAcceptanceClassRepository : IBLAcceptanceClassRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<AcceptanceClass> _acceptanceclassRepository;
        
        public BLAcceptanceClassRepository(WorkpackDBContext context, IGenericDataRepository<AcceptanceClass> acceptanceclassRepository)
        {
            _context = context;
            _acceptanceclassRepository = acceptanceclassRepository;
        }
        public IList<AcceptanceClass> GetAllAcceptanceClasses()
        {
            return _acceptanceclassRepository.GetAll();
        }
        public AcceptanceClass GetAcceptanceClassByID(Int32 acceptanceclassID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _acceptanceclassRepository.GetSingle(d => d.AcceptanceClassID == acceptanceclassID);
            //include related employees
        }


        public AcceptanceClass GetAcceptanceClassByID(Int32 acceptanceclassID, bool flag)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _acceptanceclassRepository.GetSingle(d => d.AcceptanceClassID == acceptanceclassID);
            //include related employees
        }


        public void AddAcceptanceClass(params AcceptanceClass[] acceptanceclass)
        {
            /* Validation and error handling omitted */
            try
            {
                _acceptanceclassRepository.Add(acceptanceclass);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public void UpdateAcceptanceClass(params AcceptanceClass[] acceptanceclass)
        {
            /* Validation and error handling omitted */
            try
            {
                _acceptanceclassRepository.Update(acceptanceclass);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public void RemoveAcceptanceClass(params AcceptanceClass[] acceptanceclass)
        {
            /* Validation and error handling omitted */
            try
            {
                _acceptanceclassRepository.Remove(acceptanceclass);
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
        public Boolean CheckDuplicate(AcceptanceClass acceptanceclass, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _acceptanceclassRepository.GetSingle(p => p.AcceptanceClassCode.ToUpper() == acceptanceclass.AcceptanceClassCode.ToUpper() && p.AcceptanceClass1.ToUpper() == acceptanceclass.AcceptanceClass1.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.AcceptanceClassID == acceptanceclass.AcceptanceClassID)
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
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
            return Result;
        }
        public IList<AcceptanceClass> GetAcceptanceClassList(AcceptanceClass acceptanceclass)
        {
            IList<AcceptanceClass> fetchedClient = null;
            // fetchedClient = new List<AcceptanceClass>();
            //try
            //{
            //    using (var Context = new Cubicle_EntityEntities())
            //    {
            //        IQueryable<AcceptanceClass> query = Context.AcceptanceClasses;
            //        if (acceptanceclass.AcceptanceClass1 != string.Empty)
            //            query = query.Where(p => p.AcceptanceClass1.ToUpper().Contains(acceptanceclass.AcceptanceClass1.ToUpper()));
            //        if (acceptanceclass.AcceptanceClassCode != string.Empty)
            //            query = query.Where(p => p.AcceptanceClassCode.ToUpper().Contains(acceptanceclass.AcceptanceClassCode.ToUpper()));
            //        fetchedClient = query.ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    //if (false)
            //    //{
            //    //    throw ex;
            //    //}
            //}
            return fetchedClient;
        }
    }
}
