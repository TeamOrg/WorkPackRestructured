using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTechnologyRepository : IBLTechnologyRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Technology> _technologyRepository;

        public BLTechnologyRepository(WorkpackDBContext context, IGenericDataRepository<Technology> technologyRepository)
        {
            _context = context;
            _technologyRepository = technologyRepository;
        }




        public IList<Technology> GetAllTechnologys()
        {
            return _technologyRepository.GetAll();
        } 
        public Technology GetTechnologyByID(Int32 technologyID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _technologyRepository.GetSingle(d => d.TechnologyID == technologyID);                
                //include related employees
        }        
        public void AddTechnology(params Technology[] technology)
        {
            /* Validation and error handling omitted */
            try
            {
                _technologyRepository.Add(technology);
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
        public void UpdateTechnology(params Technology[] technology)
        {
            /* Validation and error handling omitted */
            try
            {
                _technologyRepository.Update(technology);
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
        public void RemoveTechnology(params Technology[] technology)
        {
            /* Validation and error handling omitted */
            try
            {
                _technologyRepository.Remove(technology);
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
        public Boolean CheckDuplicate(Technology technology,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _technologyRepository.GetSingle(p => p.TechnologyName.ToUpper() == technology.TechnologyName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.TechnologyID == technology.TechnologyID)
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
        public IList<Technology> GetTechnologyList(Technology technology)
        {
            IList<Technology> fetchedTechnology = new List<Technology>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<Technology> query = Context.Technologies;
                //    if (technology.TechnologyName != string.Empty)
                //        query = query.Where(p => p.TechnologyName.ToUpper().Contains(technology.TechnologyName.ToUpper()));
                //    fetchedTechnology = query.ToList();
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
            return fetchedTechnology;
        }
    }
}
