using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaxCodeRepository
    {
        void AddTaxCode(params TaxCode[] TaxCode);
        IList<TaxCode> GetAllTaxCode();
        TaxCode GetTaxCodeByID(int TaxCodeID);
        void RemoveTaxCode(params TaxCode[] TaxCode);
        void UpdateTaxCode(params TaxCode[] TaxCode);
    }
}