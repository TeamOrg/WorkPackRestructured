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
    
    public partial class CustomReport
    {
        public int CustomReportID { get; set; }
        public string ReportTitle { get; set; }
        public string ReportCode { get; set; }
        public string Status { get; set; }
        public Nullable<int> TemplateID { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> ModuleID { get; set; }
    }
}
