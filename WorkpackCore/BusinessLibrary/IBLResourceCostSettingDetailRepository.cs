using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLResourceCostSettingDetailRepository
    {
        void AddCostSettingDetails(params ResourceCostSettingDetail[] resourcecost);
        List<object> GetAllCategories();
        IList<ResourceCostSettingDetail> GetAllDetails();
        IList<ResourceCostSettingDetail> GetAllDetailsByClientCategory(int ClientID, int category);
        List<ResourceCostSettingDetail> GetAllDetailsByDeptDesgSettingID(int deptID, int desgID, int CostsettingID);
        ResourceCostSettingDetail GetSettingDetailByID(int SettingID);
        void RemoveCostSettingDetails(ResourceCostSettingDetail[] resourcecost);
        void UpdateCostSettingDetails(params ResourceCostSettingDetail[] resourcecost);
    }
}