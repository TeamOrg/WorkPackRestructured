using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModelLibrary
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public partial class usp_getDeliverableTaskByUserID
    {
        public string TaskOwner { get; set; }
        public int ProjectTaskID { get; set; }
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string TaskName { get; set; }
        public int DepatmentID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string vStartDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public string vActualStartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string vEndDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public string vActualEndDate { get; set; }
        public decimal AllottedHours { get; set; }
        public int ConsumedHrs { get; set; }
        public int TaskTypeID { get; set; }
        public int ActivityTypeID { get; set; }
        public Nullable<int> Priority { get; set; }
        public int DesignationID { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> TaskOwnerID { get; set; }
        public Nullable<int> TaskStatus { get; set; }
        public string TaskProgress { get; set; }
        public Nullable<int> ResourceRequestID { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public string TaskType { get; set; }
        public string PriorityName { get; set; }
        public decimal progress { get; set; }
        public string DeliverableNo { get; set; }
        public Nullable<int> TaskNo { get; set; }
        public Nullable<System.DateTime> TaskcancelledDate { get; set; }

    }
}
