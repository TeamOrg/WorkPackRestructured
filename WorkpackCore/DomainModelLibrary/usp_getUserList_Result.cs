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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class usp_getUserList_Result
    
    {
        [Key]
        public int UserID { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string ComanyName { get; set; }
        public string UserCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Fullname { get; set; }
        public string CurrentAddress { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string TelephoneExt { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string EmailID1 { get; set; }
        public string EmailPassword { get; set; }
        public decimal Locked { get; set; }
        public string EmpCode { get; set; }
        public Nullable<decimal> AttemptCount { get; set; }
        public Nullable<System.DateTime> LogIn { get; set; }
        public Nullable<System.DateTime> LogOut { get; set; }
        public Nullable<bool> SysGenPwd { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public Nullable<int> DesignationID { get; set; }
        public string DesignationName { get; set; }
        public string DesignationCode { get; set; }
        public string ImagePath { get; set; }
        public string FocalPoint { get; set; }
        public Nullable<int> ReportingTo { get; set; }
        public string ReportToName { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string JoiningDate { get; set; }
        public string RelievingDate { get; set; }
        public string Country { get; set; }
    }
}
