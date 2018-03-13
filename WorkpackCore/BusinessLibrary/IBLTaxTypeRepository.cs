using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaxTypeRepository
    {
        void AddTaxType(params TaxType[] TaxType);
        IList<TaxType> GetAllTaxType();
        TaxType GetTaxTypeByID(int TaxTypeID);
        void RemoveTaxType(params TaxType[] TaxType);
        void UpdateTaxType(params TaxType[] TaxType);
    }
}