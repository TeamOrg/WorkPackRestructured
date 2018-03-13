using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTranTypeRepository
    {
        void AddTranType(params TranType[] trantype);
        IList<TranType> GetAllTranTypes(int CompanyId);
        TranType GetTranTypeByID(int TranTypeID);
        void RemoveTranType(params TranType[] trantype);
        void UpdateTranType(params TranType[] trantype);
    }
}