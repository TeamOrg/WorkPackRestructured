using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;

namespace CommonLibrary
{

    /// <summary>
    /// Enumerator for Message Type
    /// </summary>
    public enum MessageType
    {
        Error = 1,
        Information = 2
    }
    public enum ResourceCategory
    {
        Local = 1,
        Regional = 2,
        Expat = 3

    }
    /// <summary>
    /// Enumerator for Message Type
    /// </summary>
    public enum ResourceRequestStatusID
    {
        Draft = 1,
        PendingForAllocation = 2,     
        PlannedAllocation = 3,
        Allocated = 4,
        Closed = 5//accept by Project leader
    }

        /// <summary>
    /// Enumerator for PriorityID
    /// </summary>
    public enum PriorityID
    {
        Low = 1,
        Medium = 10,
        High = 3,
        NA = 4
    }






    /// <summary>
    /// Enumerator for Message Type
    /// </summary>
    public enum ProgressSheetStatus
    {
        Submit = 1,
        Approved = 2
    }
    public enum ApproveStatus
    {
        [Description("Awaiting Approval")]
        Awaiting_Approval=0,
        [Description("Approved")]
        Approved=1
    }

    /// <summary>
    /// Enumerator for Message Type
    /// </summary>
    public enum ProjectStatus
    {
        Estimation = 1,
        Awaited = 2,
        Lost = 3,
        Awarded = 4,
        Archived = 5,
        Closed=6,
        OnGoing=7
    }

    public enum WeekDays
    {
        [Description("Monday")]
        Monday = 1,
        [Description("Tuesday")]
        Tuesday = 2,
        [Description("Wednesday")]
        Wednesday = 3,
        [Description("Thursday")]
        Thursday = 4,
        [Description("Friday")]
        Friday = 5,
        [Description("Saturday")]
        Saturday = 6,
        [Description("Sunday")]
        Sunday = 7
    }



    public enum DocStatusID
    {        
        [Description("Upload")]
        Upload = 1,
        [Description("Issue")]
        Issue = 2,
        [Description("Comments")]
        Comments = 3,
        [Description("Response")]
        Response = 4,
        [Description("Approve")]
        Approve = 5
    }



    /// <summary>
    /// Enumerator for Message Type
    /// </summary>
    public enum TaskStatusID
    {
        [Description("Draft")]
        Draft = 0,//Draft dispay Task status in Color in Grid
        [Description("Resources Awaited")]
        ResourceAwaited = 1,//Resources Awaited
        [Description("Resources Accepted")]
        ResourceAccepted = 2,//Resources Accepted
        [Description("Sent to Focal Point")]
        SendToFocalPoint = 3,//Sent
        [Description("Under Discussion")]
        UnderDiscussion = 4,//Under Discussion
        [Description("Assigned")]
        TaskAssigned = 5,//Assigned
        [Description("Accepted")]
        AcceptedByTaskOwner = 6,//Accepted   
        [Description("Started")]
        TaskStarted = 7,//started  
        [Description("Cancelled")]
        Cancelled = 8,//Cancelled: 
        [Description("Closed")]
        Closed = 9//Closed: 

        //new Task Status
        // 0 Draft
        //1 Send resource requirement At Estimation Phase
        //2 Resource Allocation At Estimation Phase
        //3 Project Statust Change
        //4 Task List lock
        //5 Ressource request generated
        //6 Resource Assigned
        //7 resource Request accepted
        // 8 SendToFocalPoint = 3,//Sent      
        //9 TaskAssigned = 5,//Assigned     
        //10 AcceptedByTaskOwner = 6,//Accepted 
        //11 TaskStarted = 7,//started  
        //12 Cancelled = 8,//Cancelled: 
        //13 Closed = 9//Closed: 







    }

    public enum CommentStatusID
    {

        [Description("Uploaded")]
        Uploaded = 0,
        [Description("Commented")]
        Commented = 1,
        [Description("Comment Resolution")]
        CommentResolution = 2,
        [Description("Response Sent")]
        PendingApproval = 3,
        [Description("Accepted")]
        Accepted = 5,
        [Description("Rejected")]
        Rejected = 4,

    }


    public enum FileStatusID
    {

        [Description("Uploaded")]
        Uploaded = 0,//Uploaded
        [Description("Commented")]
        Commented = 1,//Commented
        [Description("Comment Resolution")]
        CommentResolution = 2,//Resources Awaited
        [Description("Approved")]
        Approved = 3,//Resources Accepted
        

    }

    public enum DefaultTaskType
    {
        Calculations, 
        Contract, 
        Datasheet, 
        Document, 
        Drawing, 
        Layout, 
        Report
    }

    public enum ActivityType
    {
        Deliverable = 1,
        Procurement,
        General ,
        Document 
    }

    public enum MasterTaskType
    {
        Task = 1,
        Document,
        MaterialItem,
        MaterialReport
    }

    public enum CompanyID
    { 
        Spectrum = 8333    
    }   

    //public struct Described<T> where T : struct
    //{
    //    private T _value;
    //    public Described(T value) { _value = value; }

    //    /// <summary>
    //    ///  Get the Description attribute of an item.
    //    /// </summary>
    //    /// <returns>The string from the Description attribute.</returns>
    //    public override string ToString()
    //    {
    //        try
    //        {
    //            string text = _value.ToString();
    //            object[] attr = typeof(T).GetField(text).GetCustomAttributes(typeof(DescriptionAttribute), false);
    //            if (attr.Length == 1)
    //            {
    //                text = ((DescriptionAttribute)attr[0]).Description;
    //            }
    //            return text;
    //        }
    //        catch
    //        {
    //            return "";
    //        }
    //    }

    //    // Implicit helpers to assign between the value and the generic type.
    //    public static implicit operator Described<T>(T value)
    //    {
    //        return new Described<T>(value);
    //    }
    //    public static implicit operator T(Described<T> value)
    //    {
    //        return value._value;
    //    }

    //}
}