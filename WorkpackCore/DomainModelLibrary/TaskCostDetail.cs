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
    
    public partial class TaskCostDetail
    {
        public int TaskCostDetailsID { get; set; }
        public int TaskID { get; set; }
        public Nullable<decimal> CostsIncurred { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string PONumber { get; set; }
        public string Invoice { get; set; }
        public string Supplier { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
