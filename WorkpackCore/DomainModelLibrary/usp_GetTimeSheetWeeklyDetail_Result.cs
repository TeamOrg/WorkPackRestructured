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
    
    public partial class usp_GetTimeSheetWeeklyDetail_Result
    
    {
        public int TimeSheetID { get; set; }
        public int TaskID { get; set; }
        public System.DateTime TimesheetDate { get; set; }
        public string WDay { get; set; }
        public decimal NorHrs { get; set; }
        public decimal OTHrs { get; set; }
        public int TimeSheetWeeklyID { get; set; }
        public Nullable<int> FinalStatus { get; set; }
        public string Deviation { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> JustifydeviationHrs { get; set; }
        public Nullable<int> TimeSheetDeviationID { get; set; }
        public Nullable<int> AcceptanceClassID { get; set; }
        public string AcceptanceClass { get; set; }
    }
}
