using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLCurrencyRepository : IBLCurrencyRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Currency> _currencyRepository;
       
        public BLCurrencyRepository(WorkpackDBContext context, IGenericDataRepository<Currency> currencyRepository)
        {
            _context = context;
            _currencyRepository = currencyRepository;
        }
       public IList<Currency> GetAllCurrency()
        {
            return _currencyRepository.GetAll();
        }

       public Currency GetCurrencyByCurrencyID(int CurrencyID)
        {
            return _currencyRepository.GetSingle(
                p => p.CurrencyID == CurrencyID);
        }

       public Currency GetCurrencyByCurrencyName(string CurrencyName)
        {
            return _currencyRepository.GetSingle(
                p => p.CurrencyName.Trim().ToUpper() == CurrencyName.Trim().ToUpper());
        }

       public Currency GetCurrencyByCurrencyCode(string CurrencyCode)
       {
           return _currencyRepository.GetSingle(
               p => p.CurrencyCode.Trim().ToUpper() == CurrencyCode.Trim().ToUpper());
       }

       public void AddCurrency(params Currency[] Currency)
        {
            /* Validation and error handling omitted */
            _currencyRepository.Add(Currency);
        }

       public void UpdateCurrency(params Currency[] Currency)
        {
            /* Validation and error handling omitted */
            _currencyRepository.Update(Currency);
        }

       public void RemoveCurrency(params Currency[] Currency)
        {
            /* Validation and error handling omitted */
            _currencyRepository.Remove(Currency);
        }

       //public operationResult deleteCurrencyById(string id, string UserID)
       // {
       //     using (var context = new WorkpackDBContext())
       //     {
       //         operationResult res = new operationResult();
       //         int m = Convert.ToInt32(id);
       //         try
       //         {
       //             Currency currency = context.Currency.Where(a => a.CurrencyID == m).First();
       //             RemoveCurrency(currency);
       //             res.MessageType = "S";
       //             res.Message = MessageConstants.SuccessfulMsg;
       //         }
       //         catch (Exception ex)
       //         {
       //             CustomErrorlog.WriteLog(ex);
       //             res.MessageType = "S";
       //             res.Message = "Error Occured.Please try again.";
       //         }
       //         return res;
       //     }
       // }

       public Currency CheckDuplicate(string CurrencyName,int CurrencyID)
       {
           if (CurrencyID == 0)
               return _currencyRepository.GetSingle(
                  p => p.CurrencyName.Trim().ToUpper() == CurrencyName.Trim().ToUpper());
           else
               return _currencyRepository.GetSingle(
                  p => p.CurrencyName.Trim().ToUpper() == CurrencyName.Trim().ToUpper() && p.CurrencyID != CurrencyID); 
       }

       public List<object> getAllCurrencyForDropdown()
       {
           List<object> lst = null;
           
               lst = (from q in _context.Currency
                      select new
                      {
                          CurrencyName = q.CurrencyName,
                          CurrencyId = q.CurrencyID
                      }).ToList<object>();
           
           return lst;
       }
    }
}
