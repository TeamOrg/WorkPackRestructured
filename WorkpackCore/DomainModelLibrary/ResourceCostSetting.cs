//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResourceCostSetting
    {
        public ResourceCostSetting()
        {
            this.ResourceCostSettingDetails = new HashSet<ResourceCostSettingDetail>();
        }
    
        public int ResourceCostSettingID { get; set; }
        public Nullable<int> ResourceCategoryID { get; set; }
        public Nullable<int> ContractMappingID { get; set; }
    
        public virtual ResourceCategory ResourceCategory { get; set; }
        public virtual ICollection<ResourceCostSettingDetail> ResourceCostSettingDetails { get; set; }
    }
}
