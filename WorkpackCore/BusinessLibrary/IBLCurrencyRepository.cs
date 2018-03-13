using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLCurrencyRepository
    {
        void AddCurrency(params Currency[] Currency);
        Currency CheckDuplicate(string CurrencyName, int CurrencyID);
        IList<Currency> GetAllCurrency();
        List<object> getAllCurrencyForDropdown();
        Currency GetCurrencyByCurrencyCode(string CurrencyCode);
        Currency GetCurrencyByCurrencyID(int CurrencyID);
        Currency GetCurrencyByCurrencyName(string CurrencyName);
        void RemoveCurrency(params Currency[] Currency);
        void UpdateCurrency(params Currency[] Currency);
    }
}