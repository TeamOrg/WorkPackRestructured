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
    public partial class GetPrediccessorTask_Result
    
    {
        public int projecttaskID { get; set; }
        public string taskName { get; set; }
        public int DependencyTaskID { get; set; }
        public string ChildTask { get; set; }
        public string RedirectURL { get; set; }
        public string Flag { get; set; }
        public string OrderByRow { get; set; }
        public Nullable<System.DateTime> PlannedDate { get; set; }
    }
}
