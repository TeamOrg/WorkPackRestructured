using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DomainModelLibrary
{


    public partial class User
    {        
        [Key]
        public int UserID { get; set; }
        public string UserCode { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string CurrentAddress { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneExt { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public decimal Locked { get; set; }
        public string EmpCode { get; set; }
        public Nullable<decimal> AttemptCount { get; set; }
        public Nullable<System.DateTime> LogIn { get; set; }
        public Nullable<System.DateTime> LogOut { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string LoggedIPAddress { get; set; }
        public Nullable<bool> SysGenPwd { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> DesignationID { get; set; }
        public string ImagePath { get; set; }
        public string FocalPoint { get; set; }
        public Nullable<int> ReportingTo { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public Nullable<int> MaxAlert { get; set; }
        public Nullable<int> MAxNotification { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public Nullable<System.DateTime> RelievingDate { get; set; }
        public Nullable<decimal> HourlyRate { get; set; }
        public int ResourceCategoryID { get; set; }
        public Nullable<decimal> OvertimeRate { get; set; }
        public Nullable<decimal> MonthlySalary { get; set; }
        public string IsDormantUser { get; set; }
        public string EmailID1 { get; set; }
        public string Country { get; set; }
        public string IsRejected { get; set; }
        public string EmailPassword { get; set; }
        public string SMTPHost { get; set; }
        public string FirebaseID { get; set; }

        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual ICollection<NewActivityDetail> NewActivityDetails { get; set; }
        public virtual ICollection<ProgressSheet> ProgressSheets { get; set; }
        public virtual ICollection<ProjectsAdmin> ProjectsAdmins { get; set; }
        public virtual ICollection<TaskHandOver> TaskHandOvers { get; set; }
        public virtual ICollection<UserEducationalQualification> UserEducationalQualifications { get; set; }
        public virtual ICollection<UserEmployerHistory> UserEmployerHistories { get; set; }
        public virtual ICollection<UserSkillInformation> UserSkillInformations { get; set; }
        public virtual ICollection<Transmittal> Transmittals { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplates { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplates1 { get; set; }
        public virtual Company Company { get; set; }
    }
}
