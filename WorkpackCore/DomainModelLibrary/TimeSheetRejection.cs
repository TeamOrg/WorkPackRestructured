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
    
    public partial class TimeSheetRejection
    {
        public int TimeSheetRejectionID { get; set; }
        public Nullable<int> TimeSheetWeeklyID { get; set; }
        public string RejectionReason { get; set; }
        public Nullable<System.DateTime> RejectionDate { get; set; }
        public Nullable<int> RejectedBy { get; set; }
    
        public virtual TimeSheetWeekly TimeSheetWeekly { get; set; }
    }
}
