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
    
    public partial class uspIsDuplicateProjectMileStone_Result
    
    {
        public int ProjectMilestoneID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string ProjectMilestone { get; set; }
        public string ProjectMilestoneDesc { get; set; }
        public Nullable<decimal> Weightage { get; set; }
        public string Type { get; set; }
        public string Remarks { get; set; }
        public string MileStone { get; set; }
        public Nullable<int> LOCK { get; set; }
        public Nullable<int> RequestID { get; set; }
    }
}