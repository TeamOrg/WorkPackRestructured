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

    public partial class usp_getUserRoleAssigned_Result
    
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public Nullable<int> RoleAssigned { get; set; }
    }
}
