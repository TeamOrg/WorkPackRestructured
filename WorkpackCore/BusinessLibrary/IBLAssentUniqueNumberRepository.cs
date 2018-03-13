using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLAssentUniqueNumberRepository
    {
        void AddClient(params AssentUniqueNumber[] assentUniqueNumber);
        IList<AssentUniqueNumber> GetAllAssentUniqueNumbers();
        List<AssentUniqueNumber> GetAssentUniqueNumberByClientAssetIDYear(int ClientAssetID, string Year);
        AssentUniqueNumber GetClientByID(int AssentUniqueNumberID);
        void UpdateAssentUniqueNumber(params AssentUniqueNumber[] assentUniqueNumber);
    }
}