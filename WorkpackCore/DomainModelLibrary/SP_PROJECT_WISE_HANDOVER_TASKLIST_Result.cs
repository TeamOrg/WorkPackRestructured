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
    
    public partial class SP_PROJECT_WISE_HANDOVER_TASKLIST_Result
    
    {
        public string TaskName { get; set; }
        public string Handoverto { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Availablehours { get; set; }
        public string RequestStatus { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> TaskID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int TaskHandoverDetailID { get; set; }
        public string Active { get; set; }
        public Nullable<System.DateTime> FromPeriod { get; set; }
        public Nullable<System.DateTime> ToPeriod { get; set; }
    }
}