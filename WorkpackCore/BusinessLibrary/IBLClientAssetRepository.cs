using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLClientAssetRepository
    {
        void AddClientAsset(params ClientAsset[] clientAsset);
        bool CheckDuplicate(ClientAsset clientAsset, bool IsInsert);
        IList<ClientAsset> GetAllClientAssets();
        ClientAsset GetClientAssetByID(int clientAssetID);
        IList<usp_getClientAsset_Result> GetClientAssetList(ClientAsset clientAsset);
        IList<ClientAsset> GetClientAssetsByClientID(int ClientID);
        void RemoveClientAsset(params ClientAsset[] clientAsset);
        void UpdateClientAsset(params ClientAsset[] clientAsset);
    }
}