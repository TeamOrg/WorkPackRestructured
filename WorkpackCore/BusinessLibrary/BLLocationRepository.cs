using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLLocationRepository : IBLLocationRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Location> _locationRepository;

        public BLLocationRepository(WorkpackDBContext context, IGenericDataRepository<Location> locationRepository)
        {
            _context = context;
            _locationRepository = locationRepository;
        }

        public IList<Location> GetAllLocation()
        {
            return _locationRepository.GetAll();
        }
        public Location GetLocationByID(Int32 locationID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _locationRepository.GetSingle(d => d.LocationID == locationID);                
                //include related employees
        }
        public void AddLocation(params Location[] location)
        {
            /* Validation and error handling omitted */
            _locationRepository.Add(location);
        }
        public void UpdateLocation(params Location[] location)
        {
            /* Validation and error handling omitted */
            _locationRepository.Update(location);
        }
        public void RemoveLocation(params Location[] location)
        {
            /* Validation and error handling omitted */
            try
            {
                _locationRepository.Remove(location);
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
        public Boolean CheckDuplicate(Location location, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _locationRepository.GetSingle(p => p.LocationName.ToUpper() == location.LocationName.ToUpper() && p.Locationcode.ToUpper() == location.Locationcode.ToUpper() && p.LocationID == location.LocationID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.LocationID == location.LocationID)
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
