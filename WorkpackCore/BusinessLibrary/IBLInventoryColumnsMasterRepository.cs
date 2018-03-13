using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLInventoryColumnsMasterRepository
    {
        void AddInventoryColumnsMaster(params InventoryColumnsMaster[] InventoryColumnsMaster);
        List<GridMaterialReceiptFormCreationColumns> CreateDynamicControls(int TrantypeId);
        IList<InventoryColumnsMaster> GetAllInventoryColumnsMaster();
        InventoryColumnsMaster GetInventoryColumnsMasterByID(int InventoryColumnsMasterID);
        List<InventoryColumnsMaster> GetInventoryColumnsMasterByTranTypeID(int TranTypeID);
        List<usp_GetMaterialItems_Result> GetMaterialList(int StoreID, int TypeID, int MaterialNormsID);
        List<usp_GetMaterialItemsbyId_Result> GetMaterialListById(int MaterialNormsID);
        void RemoveInventoryColumnsMaster(params InventoryColumnsMaster[] InventoryColumnsMaster);
        void UpdateInventoryColumnsMaster(params InventoryColumnsMaster[] InventoryColumnsMaster);
    }
}