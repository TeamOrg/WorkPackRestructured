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
    using System.ComponentModel.DataAnnotations;
    public partial class usp_searchUserProject_Result
    
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        
        public string ProjectCode { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectStatusName { get; set; }
        public string ProjectLeaderName { get; set; }
        public string InvolvedDepartment { get; set; }
        public string ClientCode { get; set; }
        public string Clientname { get; set; }
        public Nullable<System.DateTime> ProjectStartDate { get; set; }
        public Nullable<System.DateTime> ProjectEndDate { get; set; }
        public decimal AllottedManHrs { get; set; }
        public decimal ConsumedManHrs { get; set; }
        public Nullable<int> ActualResources { get; set; }
        public Nullable<int> ProjectSecretary { get; set; }
        public string ProjectDescription { get; set; }
        public string ClientFocalPoint { get; set; }
        public string ClientFocalPointName { get; set; }
        public string ProjectType { get; set; }
        public Nullable<int> ProjectTypeID { get; set; }
        public string StageName { get; set; }
        public Nullable<int> ProjectStage { get; set; }
        public string PriorityName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ClientProjectNo { get; set; }
        public int ProjectLeader { get; set; }
        public string ClientAssetName { get; set; }
        public Nullable<int> ClientAssetID { get; set; }
        public Nullable<int> MilestoneCount { get; set; }
        public Nullable<int> IsProjectAdmin { get; set; }
    }
}
