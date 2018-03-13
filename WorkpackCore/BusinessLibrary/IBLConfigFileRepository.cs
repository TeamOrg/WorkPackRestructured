using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLConfigFileRepository
    {
        void AddConfigFile(params ConfigFile[] configFile);
        IList<ConfigFile> GetAllConfigFiles();
        List<Currency> GetAllCurrency();
        ConfigFile GetConfigFileByID(int ConfigID);
        List<Currency> GetCurrencyByCode(string code);
        void RemoveConfigFile(params ConfigFile[] configFile);
        void UpdateConfigFile(params ConfigFile[] configFile);
    }
}