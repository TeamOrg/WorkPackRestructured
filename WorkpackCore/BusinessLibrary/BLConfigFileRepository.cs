using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLConfigFileRepository : IBLConfigFileRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ConfigFile> _configFileRepository;

        public BLConfigFileRepository(WorkpackDBContext context, IGenericDataRepository<ConfigFile> configFileRepository)
        {
            _context = context;
            _configFileRepository = configFileRepository;
        }
        
        public IList<ConfigFile> GetAllConfigFiles()
        {
            return _configFileRepository.GetAll();
        }
        public ConfigFile GetConfigFileByID(Int32 ConfigID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _configFileRepository.GetSingle(d => d.ConfigID == ConfigID);
            //include related employees
        }
        public void AddConfigFile(params ConfigFile[] configFile)
        {
            /* Validation and error handling omitted */
            try
            {
                _configFileRepository.Add(configFile);
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
        public void UpdateConfigFile(params ConfigFile[] configFile)
        {
            /* Validation and error handling omitted */
            try
            {
                _configFileRepository.Update(configFile);
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
        public void RemoveConfigFile(params ConfigFile[] configFile)
        {
            /* Validation and error handling omitted */
            try
            {
                _configFileRepository.Remove(configFile);
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

        public List<Currency> GetAllCurrency()
        {
            List<Currency> list=null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.Currencies.ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public List<Currency> GetCurrencyByCode(string code)
        {
            List<Currency> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from c in db.Currencies where c.CurrencyCode == code select c).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
    }
}
