using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLResourceCostSettingRepository
    {
        void AddCostSetting(params ResourceCostSetting[] resourcecost);
        IList<ResourceCostSetting> GetAllDetails();
        List<ResourceCostSetting> GetRecordCountByCategoryMappingID(int category, int clientMapID);
        ResourceCostSetting GetSettingByID(int SettingID);
        void RemoveCostSetting(ResourceCostSetting[] resourcecost);
        void UpdateCostSetting(params ResourceCostSetting[] resourcecost);
    }
}