using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaxCodesDetailRepository
    {
        void AddTaxCodesDetail(params TaxCodesDetail[] TaxCodesDetail);
        IList<TaxCodesDetail> GetAllTaxCodesDetail();
        IList<TaxCodesDetail> GetAllTaxCodesDetailByTaxCodeID(int TaxCodeID);
        TaxCodesDetail GetTaxCodesDetailByID(int TaxCodesDetailID);
        void RemoveTaxCodesDetail(params TaxCodesDetail[] TaxCodesDetail);
        void UpdateTaxCodesDetail(params TaxCodesDetail[] TaxCodesDetail);
    }
}