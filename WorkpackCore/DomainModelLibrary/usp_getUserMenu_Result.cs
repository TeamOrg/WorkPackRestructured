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
    
    public partial class usp_getUserMenu_Result
    
    {
        public short ModuleID { get; set; }
        public string ModuleName { get; set; }
        public short ParentModuleID { get; set; }
        public string URL { get; set; }
        public string AncharClass { get; set; }
        public string CountClass { get; set; }
        public string SortOrder { get; set; }
        public short MenuVisible { get; set; }
        public Nullable<int> OrderMenuHeader { get; set; }
        public string DisableManHours { get; set; }
    }
}