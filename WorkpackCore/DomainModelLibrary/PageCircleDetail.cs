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
    
    public partial class PageCircleDetail
    {
        public int PageCircleDetailID { get; set; }
        public Nullable<int> PageDetailID { get; set; }
        public Nullable<int> CenterX { get; set; }
        public Nullable<int> CenterY { get; set; }
        public string Color { get; set; }
        public Nullable<int> RadiusX { get; set; }
        public Nullable<int> RadiusXY { get; set; }
        public Nullable<int> Weight { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual PageDetail PageDetail { get; set; }
    }
}
