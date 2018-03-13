using System.ComponentModel.DataAnnotations;
namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlertsSetting
    {
        [Key]
        public int AlertID { get; set; }
        public Nullable<System.DateTime> TimeSheetSendingTime { get; set; }
        public string TimeSheetSendingDay { get; set; }
        public Nullable<System.DateTime> TimeSheetsubmittedTime { get; set; }
        public string TimeSheetsubmittedDay { get; set; }
        public Nullable<int> TaskDelayByDay { get; set; }
        public Nullable<int> Milestonpriority { get; set; }
        public Nullable<int> Afterplannedstartday { get; set; }
        public Nullable<int> Remindme { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModefiedBy { get; set; }
        public Nullable<System.DateTime> ModefiedOn { get; set; }
        public Nullable<int> SendProgressRequestNOD { get; set; }
        public Nullable<decimal> CompareProgressPercentage { get; set; }
        public Nullable<int> DesktopNotificationTime { get; set; }
        public Nullable<int> CompanyId { get; set; }
    }
}
