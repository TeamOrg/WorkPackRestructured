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
    
    public partial class SP_MY_HANDOVER_TASKREQUEST_Result
    
    {
        public string ProjectName { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Availablehours { get; set; }
        public Nullable<System.DateTime> PlannedStart { get; set; }
        public Nullable<System.DateTime> PlannedEnd { get; set; }
        public Nullable<System.DateTime> HandoverFromDate { get; set; }
        public Nullable<System.DateTime> HandoverToDate { get; set; }
        public string Handoverto { get; set; }
        public Nullable<int> TaskID { get; set; }
        public int TaskHandoverDetailID { get; set; }
        public Nullable<int> HandovertoUserID { get; set; }
        public Nullable<int> TaskHandoverID { get; set; }
        public Nullable<int> HandovertoUserID1 { get; set; }
        public string Active { get; set; }
        public string AcceptanceStatus { get; set; }
        public Nullable<int> colHide { get; set; }
    }
}