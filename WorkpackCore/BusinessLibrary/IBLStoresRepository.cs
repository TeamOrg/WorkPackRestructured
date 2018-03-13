using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLStoresRepository
    {
        void AddStore(params Store[] Store);
        IList<Store> GetAllStores(int CompanyID);
        Store GetStoreByID(int StoreID);
        void RemoveStore(params Store[] Store);
        void UpdateStore(params Store[] Store);
    }
}