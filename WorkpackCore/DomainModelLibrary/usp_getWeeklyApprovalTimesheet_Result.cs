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
    
    public partial class usp_getWeeklyApprovalTimesheet_Result
    
    {
        public int TimeSheetWeeklyID { get; set; }
        public Nullable<int> Week { get; set; }
        public Nullable<int> UserID { get; set; }
        public string UserName { get; set; }
        public Nullable<decimal> NT { get; set; }
        public Nullable<decimal> OT { get; set; }
        public Nullable<decimal> LeaveHrs { get; set; }
    }
}
