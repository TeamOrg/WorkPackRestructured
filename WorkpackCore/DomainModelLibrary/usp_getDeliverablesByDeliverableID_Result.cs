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
    
    public partial class usp_getDeliverablesByDeliverableID_Result
    
    {
        public int ProjectTaskID { get; set; }
        public string DeliverableTitle { get; set; }
        public string DeliverableNo { get; set; }
        public Nullable<int> TaskNo { get; set; }
        public int DepatmentID { get; set; }
        public string DepartmentName { get; set; }
        public int TaskTypeID { get; set; }
        public string DeliverableType { get; set; }
        public Nullable<int> TaskOwner { get; set; }
        public string ClientCode { get; set; }
        public string Clientname { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string ClientDeliverableNo { get; set; }
        public int ProjectID { get; set; }
        public Nullable<System.DateTime> ProjectStartDate { get; set; }
        public Nullable<System.DateTime> ProjectEndDate { get; set; }
        public Nullable<System.DateTime> ProjectCloseDate { get; set; }
        public int ProjectLeader { get; set; }
    }
}