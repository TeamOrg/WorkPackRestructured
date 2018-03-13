using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLLocationRepository
    {
        void AddLocation(params Location[] location);
        bool CheckDuplicate(Location location, bool IsInsert);
        IList<Location> GetAllLocation();
        Location GetLocationByID(int locationID);
        void RemoveLocation(params Location[] location);
        void UpdateLocation(params Location[] location);
    }
}