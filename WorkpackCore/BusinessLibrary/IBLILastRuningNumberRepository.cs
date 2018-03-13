using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLILastRuningNumberRepository
    {
        void AddLastRuningNumber(params LastRuningNumber[] lastRuningNumber);
        IList<LastRuningNumber> GetAllLastRuningNumber();
        List<SP_GENERATE_RUNING_NUMBER_Result> GetRuningNumber(string ClientAssetID, string Year);
        void RemoveLocation(params LastRuningNumber[] lastRuningNumber);
        void UpdateLocation(params LastRuningNumber[] lastRuningNumber);
    }
}