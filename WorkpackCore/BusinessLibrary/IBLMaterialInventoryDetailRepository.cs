using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMaterialInventoryDetailRepository
    {
        void AddMaterialInventoryDetail(params MaterialInventoryDetail[] MaterialInventoryDetail);
        MaterialInventoryDetail GetMaterialInventoryDetailByMaterialItemID(int Id, int MatInvID);
        MaterialInventoryDetail GetMaterialInventoryDetailID(int Id);
        void RemoveMaterialInventoryDetail(params MaterialInventoryDetail[] MaterialInventoryDetail);
        void UpdateMaterialInventoryDetail(params MaterialInventoryDetail[] MaterialInventoryDetail);
    }
}