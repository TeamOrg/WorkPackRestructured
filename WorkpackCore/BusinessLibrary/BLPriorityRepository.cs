using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLPriorityRepository : IBLPriorityRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Priority> _priorityRepository;

        public BLPriorityRepository(WorkpackDBContext context, IGenericDataRepository<Priority> priorityRepository)
        {
            _context = context;
            _priorityRepository = priorityRepository;
        }
        public IList<Priority> GetAllPrioritys()
        {
            return _priorityRepository.GetAll();
        }
        public Priority GetPriorityByID(Int32 priorityID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _priorityRepository.GetSingle(d => d.PriorityID == priorityID);                
                //include related employees
        }
        public void AddPriority(params Priority[] priority)
        {
            /* Validation and error handling omitted */
            try
            {
                _priorityRepository.Add(priority);
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

        public string GetDefaultPriority(string projectName, int PriorityID)
        {

            string DefaultPriority = "";          
            if (PriorityID > 0)
            {
                var c = _priorityRepository.GetSingle(p => p.IsDefault == "Y" && p.PriorityID != PriorityID);
                if (c != null)
                {
                    DefaultPriority = c.PriorityName.SingleOrDefault().ToString();
                }
              

            }
            else
            {
                var c = _priorityRepository.GetSingle(p => p.IsDefault == "Y");
                if (c != null)
                {
                    DefaultPriority = c.PriorityName.SingleOrDefault().ToString();
                }

            }
            return DefaultPriority;


        }


        public int priorityidByName(string prorityname)
        {
            int proritynum = 0;

            //using (var context = new Cubicle_EntityEntities())

            //{

            //    try
            //    {
            //        proritynum = (from p in context.Priorities
            //                      where p.PriorityName.ToUpper() == prorityname.ToUpper()

            //                      select p).ToList<Priority>().FirstOrDefault().PriorityID; ;


            //    }

            //    catch (Exception ex)

            //    { }

            //    return proritynum;
            //}

            return proritynum;


        }



        public void UpdatePriority(params Priority[] priority)
        {
            /* Validation and error handling omitted */
            try
            {
                _priorityRepository.Update(priority);
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
        public void RemovePriority(params Priority[] priority)
        {
            /* Validation and error handling omitted */
            try
            {
                _priorityRepository.Remove(priority);
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
        public Boolean CheckDuplicate(Priority priority,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _priorityRepository.GetSingle(p => p.PriorityName.ToUpper() == priority.PriorityName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.PriorityID == priority.PriorityID)
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


        public Boolean CheckDuplicateRank(Priority priority, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
             
                if (!IsInsert)
                {
                    var c = _priorityRepository.GetSingle(p => p.Rank == priority.Rank && p.PriorityID!=priority.PriorityID);
                    if (c == null)
                        Result = false;                 
                    else
                        Result = true;
                }
                else
                {
                    var c = _priorityRepository.GetSingle(p => p.Rank == priority.Rank);
                    if (c == null)
                        Result = false;
                    else
                        Result = true;
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






        public IList<Priority> GetPriorityList(Priority priority)
        {
            IList<Priority> fetchedPriority = new List<Priority>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<Priority> query = Context.Priorities;
                //    if (priority.PriorityName != string.Empty)
                //        query = query.Where(p => p.PriorityName.ToUpper().Contains(priority.PriorityName.ToUpper()));

                //    fetchedPriority = query.ToList();
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
            return fetchedPriority;
        }

        public Priority getDefaultPriority()
        {
            Priority priority = null;   
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    priority = Context.Priorities.Where(a => a.IsDefault == "Y").SingleOrDefault();
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
            return priority;
        }
    }
}
