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
    
    public partial class usp_getNewActivityMasterRecord_Result
    
    {
        public int NewActivityMasterID { get; set; }
        public string UserFullName { get; set; }
        public int UserID { get; set; }
        public Nullable<int> DesignationID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string DesignationName { get; set; }
        public string DepartmentName { get; set; }
        public string Approver { get; set; }
        public int ApproverUserID { get; set; }
    }
}
