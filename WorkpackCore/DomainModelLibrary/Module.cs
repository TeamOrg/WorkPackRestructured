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
    
    public partial class Module
    {
        public short ModuleID { get; set; }
        public string ModuleName { get; set; }
        public short ParentModuleID { get; set; }
        public string ModuleType { get; set; }
        public string URL { get; set; }
        public string AncharClass { get; set; }
        public string CountClass { get; set; }
        public string SortOrder { get; set; }
        public short MenuVisible { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> OrderMenuHeader { get; set; }
        public string DisableManHours { get; set; }
        public string IsSpreedSheetReport { get; set; }
    }
}
