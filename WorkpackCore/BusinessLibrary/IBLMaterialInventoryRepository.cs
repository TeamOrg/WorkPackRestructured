using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMaterialInventoryRepository
    {
        void AddMaterialInventory(params MaterialInventory[] MaterialInventory);
        MaterialInventory GetMaterialInventoryID(int Id);
        void RemoveMaterialInventory(params MaterialInventory[] MaterialInventory);
        void UpdateMaterialInventory(params MaterialInventory[] MaterialInventory);
    }
}