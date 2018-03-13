using System;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public class MessageConstants
    {

        public static readonly string TimesheetForMonthWeek = "Timesheet for #MONTH# Week #WEEK_NO#";
        public static readonly string TimesheetForMonthWeekNew = "Timesheet for #User# - #MONTH# Week #WEEK_NO#";
        public static readonly string DatabaseRelationError = "Related entries exist in database. To delete this record, remove all these related entries first.";
        public static readonly string InvlidUserCodeOrPassword = "Invalid user email id / password.\n\n Note : Password is case sensitive.";
        public static readonly string NoRecordSaved = "No record saved !!!";
        public static readonly string logOut = "You have successfully logged out.";
        public static readonly string videoUrl = "http://cubicleprojects.com/Videos.aspx";
        public static readonly DateTime TrialDate = Convert.ToDateTime("2115-05-31");
        //public static readonly DateTime TrialDate = Convert.ToDateTime("2015-05-31");

        public static readonly int LimitedUser =1000;//200
        public static readonly int NormalUser = 1000;//30
        public static readonly string TimesheetApproved = "#UserFullName# has approved the timesheet";
        public static readonly string TimesheetRejected = "#UserFullName# has rejected the timesheet";
        public static readonly string TimesheetApproval = "#UserFullName# has submitted timesheet for approval";


        public static string Expiredmsg = "Software has expired please contact your administrator.";
        public static readonly string PasswordChangedMessage = "Password successfully updated.";
        public static readonly string EmailFailure = "Email could not be sent.\nContact your administrator.";
        public static readonly string PasswordCheck = "New password  should not be name or code";
        public static readonly string OperationSuccess = "Successful";
        public static readonly string uploadedsuccessfully = "File(s) Uploaded Successfully.";
        public static readonly string AllTaskSubmitted = "For project #ProjectCode#, all involved departments have submitted estimated task lists. Now you can estimate schedule and resource requirements.";

        // <UserActivityTracker message

        public static readonly string AttachedTracker = "File attached to #DeliverableName# for #ProjectName#";

        // end  UserActivityTracker message
        public static readonly string CommentAccepted = "Accepted successfully.";
        public static readonly string CommentRejected = "Rejected successfully.";

        public static readonly string ForeignKeyError = "Record can not be deleted as referencial integrity found.";
        public static readonly string InValidHandOverPeriod = "Handover is already done for selected period.Please select other period.";
        public static readonly string dataCorrection = "Department ,designation and task type must be defined to lock the task list. ";
        public static readonly string selectfile = "Please select file.";
        public static readonly string selectFromDate = "Please select from date";
        public static readonly string selecttoDate = "Please select to date";
        public static readonly string DuplicateTemplateName = "Template name already exits.";
        public static readonly string TemplateNameRequest = "Please enter Template name."; 
        public static readonly string TemplateNameNotExist = "Selected template does not exist in the database.";
        public static readonly string fileExtnAllow = "Please select an XML file to import to task list.";
        public static readonly string TaskSent = "Task sent to focal point successfully !";
        public static readonly string selecttaskdependency = "Please select task dependency. ";
        public static readonly string selectPredecessorTask = "Select Predecessor Task.";
        public static readonly string InValidDependancy = "Invalid dependancy ";
        public static readonly string errorMsg = "An error occured.";
        public static readonly string SentSuccessfully = "Sent Successfully.";
        public static readonly string UpdatedSuccessfully = "Updated Successfully.";
        public static readonly string HolidayCanlendarNotDefined = "Report is not generated as holiday calendar is not defined upto #Date#  date.  .";
        public static readonly string ErrorMsgTaskCreation = "Some error occured.Please try again.";
        public static readonly string CustomSelectField = "Please Select #FieldName#";
        public static readonly string Incompletehandover = "Incomplete handover note cannot be saved.";
        public static readonly string LeaveAlreadyApply = "Leave is already applied for selected period.";
        public static readonly string wbsCodeExist = "WBS code already exist.";
        public static readonly string wbsCantDeleteParent = "Can not delete parent record.";        
        public static string CantDelete = "Project is already active and it can not be deleted.";
        public static string OperationFailure = "Failure";
        public static string CompanyAlreadyExist = "#CompanyName# is already exist. Please enter another team Domain.";
        public static string TaskCancelledError = "You can not enter date greater than cancel date- #canceldate#";
        public static string JoiningDateError = " You can not enter date less than joining date- #joiningdate#";
        public static string Deleted = "Deleted successfully.";
        public static string Updated = "Updated successfully.";
        public static string Added = "Added successfully.";
        public static string TaskLock = "Task can not be deleted as task is locked.";
        public static string TaskLocked = "Task is locked.";
        public static string TaskNotTransfer = "You can not transfer task for the period for which you are not owner.";
        public static string HandOverNotTransfer = "You can not handover task for the period for which you are not owner.";
        public static string NoofResources = "Request can not be sent due to there is no resource in the request.";
        public static string InvalidUser = "Invalid email id or password";
        public static string InvalidUserID = "Invalid email id";
        public static string InvalidUserCode = "Invalid user code";
        public static string InvalidEmailID = "Invalid user email id";
        public static string InvalidLoginID = "Invalid login id";
        public static string InvalidData = "Record not saved due to invalid data.";
        public static string InvalidOTDate = "Over time period invalid";
        public static string EnterPwd = " Enter your password. ";
        public static string EnterUserID = " Enter your email id. ";
        public static string MustChangeYourPassword = "You have to change your Password!";
        public static string PasswordExpireMessage = "Your password has been expired.\nKindly change your password.";
        public static string IncorrectUserIdPwd = " Email ID or password you entered is incorrect. ";
        public static string NoDataFound = "No data found";
        public static string ValidationError = "Validation failed.";
        public static string canEditMsg = "Can not edit record.";
        public static string LoginFailureMessage = "Login failure. Provide correct credentials. Unauthorized use of application is prohibited. Note : password is case sensitive..";
        public static string PasswordContainsNumericAndSpecialCharacter = "Password should contain a numeric and a special character both.";
        public static string UserAccountDeactivatedOrDeleted = "You account has been deactivated / Deleted.Please contact your administrator.";
        public static string UserAccountExpired = "Your account has been expired! Please contact to admin.";
        public static string UserAccountExpiredDormantDays = "Account has been expired! since you have not logged in for long time.";
        public static string UserAccountExpireMessages = "Account expires On should be greater then or equal to today's date";
        public static string UserAccountLocked = "Your account has been locked. Please contact your software administrator.";
        public static string UserEmailUnavailable = "Email ID for user -> #UserCode# is not available. Contact your administrator.";
        public static string UserExpireMessages = "This sser code already exists!";
        public static string PasswordRepeatMessage = "You can not repeat any Of your previous #NoOfTimes# passwords!!!";
        public static string ResetPassword = "Password reset successfully ";
        public static string ResetPasswordFailure = "Password reset fail";
        public static string ResetSession = "	Session reset successfuly!";
        public static string canDeleteMsg = "Can not delete record.";
        public static string ProjectArchived = "Tasks are not completed yet. Therefore You can not assign Project Status as Archived.";
        public static string canNotDeleteResourcesMsg = "Record can not be deleted as resource is already working on this project..";
        public static string DefineDesignation = "Task designation is not defined in setting panel.";
        public static string wrongDateSequence = "Progress level dates must be in correct sequence and between start date and end date.";
        public static string PasswordReminder = "Your password will expire in #NoOfDays# Days. Kindly change your password.";
        public static string UserAccessMessage = "You do not have rights for any of the Modules. Contact your system administrator";
        public static string FillRequiredField = "Please enter all required fields.";
        public static string EnterAwardPossibility = "Please enter Award Possibility %";
        

        public static string setMileStoneTargetDates = "Please set milestone target date for task.";
        public static string selectAtleastOne = "Please select atleast one record to continue.";
        public static string selectDropdown = "Please select dropdown value.";

        public static string selectWBSTemplate = "Please select template.";
        public static string EnterTemplatename = "Please enter template.";
        public static string Duplicate = " Duplicate record found. ";
        public static string Notfoundinmaster = "#ColValue# is not defined as a #Tablename# in database.";
        public static string DuplicateRank = "This Rank is arleady Assigned to other Priority. ";     
        public static string MaxTimeSheetDateStatus = "Please note that you have booked manhours for this task till ";
        public static readonly string Accepted = "Accepted successfully!.";
        //Notification Message
        public static readonly string ActivityCreator = "An activity added by you has been approved by #ApproverName# .";
        public static readonly string ActivityApprover = "A new activity has been added and it is awaiting your approval.";
        public static readonly string FileApproved = "File approved successfully.";

        public static readonly string Assignce = "You have been assigned to work on a new activity.";
        public static readonly string TSApprover = "You have been assigned to supervise a new activity.";

        public static readonly string ResourceAllocationTitle = "Resource Allocation For #PROJECT#";
        public static readonly string OldTaskownerNotification = "#TaskNo# - #TaskName#  has now been assigned to #NewTaskOwner#";
        public static readonly string ProjectedResourceAllocationTitle = "Projected Resource Allocation For #PROJECT#";
        public static readonly string SubmittedEstimationTaskChange = "#TaskNo# - #TaskName# has been changed by #UserName#.";

        public static readonly string AllotedHrsGreaterHrsForDept = "You can not enter alloted Hrs greater than #HRS# for #DESIG#";
        public static readonly string AllotedHrsError1 = "Records are not saved due to more than  one focal point is selected.";
        public static readonly string selectFocalPoint = "You need to select one focal point among the selected users.";
        public static readonly string ResourceAllocation = "#UserFullName# has assigned resources for #ProjectCode# project.";
        public static readonly string ResourceAllocationUpdate = "#UserFullName# has updated resources for #ProjectCode# project.";
        public static readonly string AllResourceAllocationDone = "Resource allocation of #Department# department  is completed for project - #ProjectCode#. Please delegate tasks.";



        public static readonly string ResourceRequest = "#UserFullName#  has sent you a resource request for #ProjectCode# project.";
        public static readonly string ResourceRequestUpdated = "#UserFullName#  has updated resource request for #ProjectCode# project.";
        public static readonly string LeaveRequestNotif = "#UserFullName# has requested for a leave.";
        public static readonly string LeaveApproveNotif = "#ApproverName# has approved your leave request.";
        public static readonly string AcceptedAssignedResources = "#UserFullName#  has accepted the assigned resources for #ProjectCode# project.";
        public static readonly string AllocatedUsers = "You have been assigned to work on #ProjectName#.";
        public static readonly string CommentBetweenPL_HOD = "#UserFullName# has commented on resource request for #ProjectCode# project.";// - 1 minute ago.
        public static readonly string ResourceAcceptedByPL = "You can not add resources as Resources are already accepted by Project Leader";
        public static readonly string AssignResourceForHrs = "Please assign resources for #HRS# hours.";
        //Notifications for tasks 
        public static readonly string SendTaskToFocalPoint = "#UserFullName# has sent you a task list for #ProjectCode# project.";// - 1 minute ago.	From PL to FP
        public static readonly string CommentNotificationMessage = "#MessageSourceName# has sent you a message for - #ProjectCode#.";// - 1 minute ago.	From PL to FP
        

        public static readonly string UpdateProgressLebelNoti ="Task progress level #TaskProgressLevelName# for Project #ProjectCode# has been updated by #ProjectLeader#.";
        public static readonly string UpdateProjectNoti = "Details for Project #ProjectCode# have been updated by #ProjectLeader#.";
        public static readonly string DeleteProgressLebelProjectNoti = "Task progress level #TaskProgressLevelName# for Project #ProjectCode# has been deleted by #ProjectLeader#.";

       
        public static readonly string CommentBetweenPL_FP_TM = "#UserFullName# has commented on a task for #ProjectCode# project.";//; - 1 minute ago.	between LP / FP / TM

        public static readonly string SendNotificationToDeliverableOwner = "#AssigneeName# has assigned #DeliverableName# to you as a part of  #ProjectName#.";//; - 1 minute ago.	between LP / FP / TM
        public static readonly string UploadsCommentedScannedPDF = "#CheckerName# has sent a commented and marked-up file for #DeliverableName#.";//; - 1 minute ago.	between LP / FP / TM


        
        public static readonly string TaskAssignedBYFP = "#UserFullName# has assigned you a task for #ProjectCode# project.";// - 1 minute ago.	From FP to TM       
        public static readonly string StarttoFinish = "Task #TaskName1# has been started. You can now finish task #TaskName2#.";//	Start to Finish (XXX must start for YYY to finish)
        public static readonly string StarttoStart = "Task #TaskName1# has been started. You can now start task #TaskName2#.";//	Start to Start
        public static readonly string FinishtoStart = "Task #TaskName1# has been finished. You can now start task #TaskName2#.";//	Finish to Start.";//
        public static readonly string FinishtoFinish = "Task #TaskName1# has been finished. You can now finish task #TaskName2#.";//	Finish to Finish.";
        //Notifications When any task has edit
        public static readonly string ProgresssheetUnlock = "Progress sheet for task - #TaskNo# - #TaskName# has been unlocked by #ProjectLeaderName#.";
        public static readonly string transferredTaskOwner = "Task - #TaskNo# - #TaskName#  has been transferred to #NewOwner# from #oldowner#.";
        public static readonly string AllotedHrsChanged = "Allotted hours for task -  #TaskNo# - #TaskName# have been changed from #Oldhrs# to #newHrs#.";
        public static readonly string TasktypeChanged = "Task type for task -  #TaskNo# - #TaskName# have been changed from #Oldtype# to #newtype#.";
        public static readonly string PrerequisiteUpdated = "Pre-requisite info for task -  #TaskNo# - #TaskName# have been updated as  #newinfo#.";
        public static readonly string DeliverablesUpdated = "Deliverables  for task -  #TaskNo# - #TaskName# have been updated as #newDel#.";
        public static readonly string HandOverNotif = "#UserFullName#  has sent handover notes from #Fromdate# to #Todate# .";
        public static readonly string RecipientsNoti = "#UserFullName# has created a handover note for period of #Fromdate# - #Todate#.";
        public static readonly string SelectTaskOwner = "A task owner need to be selected.";


        public static readonly string WBSCODERequired = "Please enter wbs code. ";
        public static readonly string ParentWBSCODERequired = "Please select parent wbs. ";
        public static readonly string WBSNameRequired = "Please enter wbs name. ";



        public static readonly string RedColor = "#F97774";


        public static readonly string BlueColor = "#49afcd";

        

        public static readonly string YellowColor = "#FFEAA5";
        public static readonly string AlternateColor = "#fcfcfc url(grd_alt.png) repeat-x top";
        public static readonly string GreenColor = "#92C9A1";
        public static readonly string BlackColor = "#424242";
        public static readonly string TotalAllocatedHrs = "Total allocated hrs: <b> #HRS#</b>";
        public static readonly string SelectUserRole = "Select user roles.";
        public static readonly string SelectOnlyOneUserRole = "Please select only one role.";
        public static readonly string DuplicateEmployeeCode = "Employee code already assigned to #USER_NAME#";
        public static readonly string DuplicateEmailID = "Email-ID already assigned to #USER_NAME#";
        //public static readonly string DuplicateEmailID = "User with this Email-ID already exists";
        public static readonly string DuplicateMobileNo = "This mobile number is already being used by another user";
        public static readonly string DuplicateHOD = "Department head is already assigned to #USER_NAME#";
        public static readonly string SelectDepartment = "Select department.";
        public static readonly string SelectRequiredFields = "Please select all required field.";
        public static readonly string FillAllTheFields = "Please fill all Fields.";
        public static readonly string WrongProjectTaskID = "Wrong project task ID";
        public static readonly string InvalidDataForScheduleHealth = "Record not saved due to invalid data.";
        //public static readonly string DuplicateProjectCode = "A project already exist in the system with #PROJECTCODE# project code is already exist. Please enter new project code";
        public static readonly string DuplicateProjectCode = "Project code already exist.";
        public static readonly string DuplicateOverTimePeriod = "Overtime period already booked.";
        
        
     //   public static readonly string OverTimeApplication = "#UserName# booked #Hours# hours as overtime for #Task#";
        public static readonly string OverTimeApplication = "#UserName# has submitted an overtime request for your approval.";
        public static readonly string OverTimeApproval = "Your overtime request is approved by #ApproverName#";

        
        public static readonly string NoTasks = "No task.";
        public static readonly string NoProjects = "No projects.";
        public static readonly string TaskRequestForProject = "Task requests for #PROJECTNAME#";
        public static readonly string AssignTaskForProject = "Assign tasks for #PROJECTNAME#";
        public static readonly string AssignTask = "Double click to assign tasks.";
        public static readonly string ResourceRequestListTitle="Resource request list for #PROJECTNAME#";
        public static readonly string ValidationFailed = "Validation failed.";
       // public static readonly string TimesheetForMonthWeek = "Timesheet for #MONTH# Week #WEEK_NO#";
        public static readonly string TimesheetApplying= "#ApplicantName#'s timesheet needs your approval";
        //public static readonly string TimesheetApplyingexhours = "Timesheet of #Hours# hours with #extra# extra hours for #MONTH# Week #WEEK_NO#  needs your approval";
        public static readonly string CreateTaskProgressLevels = "You need to create task progress levels first for the project.";
        public static readonly string AssignResourceForAllocateHrs = "Please assign resources for #TOTAL_ALLOCATED_HRS# hours.";
        public static readonly string EnterDeviationJustification = "Please enter deviation justification.";
        public static readonly string HalfDayLeaveMessage = "From date and to date should be the same for half day leave";
        public static readonly string ResourceRequestFailedMsg = "Request generation failed due to departement head not defined.";
        public static readonly string SelectAtleastOneUser = "Please select atleast one user to allocate.";
        public static readonly string EnterStartDate = "Enter start date.";
        public static readonly string EditTooltip = "Click to edit record";
        public static readonly string cantEditTooltip = "Can not edit record.";
        public static readonly string DeleteTooltip = "Click to delete record";
        public static readonly string cantDeleteTooltip = "Can not delete record.";
        public static readonly string CancelTooltip = "Click to cancel";
        public static readonly string cantCantEditTooltip = "Tasks from other departments cannot be edited.";
     
        public static readonly string AssignResourceMsg = "Can not delete user as work is started on the task.";
        public static readonly string UserNotExist = "User does not exist.";
        public static readonly string DoubleClickToolTipForView = "Double click to view #INFO#.";
        public static readonly string FromDateGreaterThanToDateError = "From date can not be greater than to date.";
        public static readonly string TransferFromToUserSameError = "Transfer from and transfer to user can not be same.";
        public static readonly string SelectScopeTypeMsg = "Please select scope type.";
        public static readonly string SelectAllRequiredFieldsForScope = "Please select all required field for scope change.";
        public static readonly string PlannedScheduleChangMsg = "Planned schedule can be changed only for dates in the future.";
        public static readonly string PlannedScheduleDateRequired = "Planned schedule date can not be empty.";
        public static readonly string selectTemplate = "Please select template to continue.";
        public static readonly string DoubleClickToolTipForProgressSheet = "Double click to fill progress sheet for this project.";
        public static readonly string DoubleClickToolTipForTimeSheet = "Double click to view acceptance class.";
        public static readonly string DoubleClickToolTipForResourceList = "Double click to view resource list.";
        public static readonly string ProgressSheetTitle="Progress sheet for #PROJECT# between #SDATE# & #EDATE#";
        public static readonly string CannotEditRecord="You can not edit #SUBJECT# as it is approved.";
        public static readonly string MileStoneDatesNotRequired = "Milestone date not required for this task.";
        public static readonly string DoubleClickToViewJustification = "Double click to view justification details.";
        public static readonly string ToolTipForProjectTaskList = "Double click to see task requests for this project.";
        public static readonly string canDeleteprogresslevel = "Can not edit or remove as Task has been assigned for this progress level.";
        public static readonly string HalfDayErrorMsg="From date and To date should be the same for half day leave";
        public static readonly string TaskTransferThisDate = "Task is Transfered/handovered for this date.";
        public static readonly string TimeSheetProjectPeriodStatus = "You can not enter timesheet as project period is #SUBJECT# ";
        public static readonly string ToolTipAllocateResource = "Double click to allocate resource for this project.";
        public static readonly string LockTaskList = "Lock task list to freeze scope of work and enable resource requests";
        public static readonly string UnLockTaskList = "Click to  unlock progress level.";
        public static readonly string ClickToResourceRequest = "Click to generate resource request";
        public static readonly string CanDelRecordHandover = "You can not handover following tasks for the period for which you are not owner.";
        public static readonly string sendNotificationToDepartments = "#PLName# has sent you project #ProjectName# for estimation.";
        public static readonly string sendNotificationToCompanyAdmin = "#UserName# has joined your team on WorkPack.";
        public static readonly string sendNotificationToAssignEngForUpdate = "#PLName# has updated your project estimation plan for  #ProjectName#";
        public static readonly string NormFieldNameExist = "Norm Field name already exist.";
        public static readonly string SendEstimationTask = "#UserFullName# has submitted an estimated task list  for #ProjectName#.";
        public static readonly string SendEstimationTaskSelf = "You have submitted an estimated task list for #ProjectName#.";


        public static readonly string DuplicateWBSCodes = "Following WBS Codes are already exist. #WBSCODES";
        public static readonly string sendNotificationToProjectAdmin = "You have been assigned as Project Admin for project - #ProjectName#";
        public static readonly string sendNotificationToExtProjectAdmin = "#ProjectOwner# has invited you to join the project team for #ProjectName#";

        public static readonly string generalError = "Something went wrong.Please try again.";


        public static readonly string Deliverableownerdded = "#XXX# has listed you as originator for #DeliverableName# - #DeliverableNo#  for Project - #ProjectCode#.";
        public static readonly string Deliverable_is_sent_for_comments = " #OriginatorName# has sent you a deliverable - #DeliverableName# for comments. ";
        public static readonly string Deliverable_is_sent_for_comments_noti = " #OriginatorName# has sent  a deliverable - #DeliverableName# for comments. ";
        public static readonly string Deliverable_is_uploaded = " #OriginatorName# has uploaded a deliverable - #DeliverableName# . ";

        public static readonly string Bulk_Deliverable_is_sent_for_comments = "#SenderName# has sent you a document transmittal - #TransmittalName# - #TransmittalNumber# for review under #ProjectName#.";

        public static readonly string Task_is_shared = " #OriginatorName# has shared #TaskListType# for #ProjectName#.";

        public static readonly string Reminder_for_comments = " #OriginatorName# has sent you a reminder #DeliverableName# for comments. ";
        public static readonly string Deliverable_is_sent_for_Viewing = " #OriginatorName# has sent you a deliverable - #DeliverableName#.";
        public static readonly string Deliverable_is_sent_to_document_Controller = " #OriginatorName# has sent you a deliverable - #DeliverableName#, to be sent for external check with a transmittal.";
        public static readonly string Send_response_to_the_comments = "#OriginatorName# has responded to your comments on #FileName# of deliverable - #DeliverableName#.";
        public static readonly string Send_response_to_the_comments_noti = "#OriginatorName# has responded on a comments on #FileName# of deliverable - #DeliverableName#.";
        public static readonly string StakeHolderNotification = " #OriginatorName# has shared a folder with you #TabAcronym# of #DeliverableName#.";

        public static string ActivityLogDelOwnerAction = "Sent for Review / Reference";
        public static string ActivityLogFileCOmment = "Comments Received";
        public static string ActivityLogFileApproved = "Approved";
        public static string ActivityLogFileApprovedWithComments = "Approved with comments";
        public static string ActivityLogFileSelfApproved = "Self Approved";
        public static string Fileuploaded = "File Uploaded";



        public static string Sent = "Sent";
        public static string SentItems = "Sent Items";
        public static string SentMail = "Sent Mail";
        public static string SentEmail = "Sent Email";
        public static string SentEmails = "Sent Emails";
        public static string SentMails = "Sent Mails";
        public static string SentObjects = "Sent Objects";
        public static string SentMesaages = "Sent Messages";
        public static string SentMessage = "Sent Message";
     






        public static readonly string Send_response_to_the_commentsOnlyForAttachedFile = "#OriginatorName# has attached a new file to comment resolution of - #DeliverableName#.";
        
        public static readonly string ALL_responses_to_comments_are_accepted = "#CheckerName# has accepted comment resolution on #FileName# of deliverable - #DeliverableName#.";
        public static readonly string Any_comment_is_rejected = "#CheckerName# has rejected response to a comment on #FileName# of deliverable - #DeliverableName#.";
        public static readonly string Any_comment_is_accepted = "#CheckerName# has accepted response to a comment on #FileName# of deliverable - #DeliverableName#.";
        public static readonly string All_the_comments_from_All_the_checkers_are_resolved_and_accepted = "All the comments made on #DeliverableName# have been resolved and closed. The deliverable can now be approved.";
        public static readonly string All_the_comments_from_All_the_checkers_are_approved = "All the comments made on #DeliverableName# are approved.";       

        public static readonly string ApproveWithoutComments = "#checkername# has approved #DeliverableName# without comments.";
        public static readonly string ApproveWithComments = "#checkername# has approved #DeliverableName# with comments.";
        public static readonly string ApproveByOriginator = " #OriginatorName# has approved #DeliverableName#";


        public static readonly string CheckerCommetNotification = "#CheckerName# has Commented on #FileName# of deliverable - #DeliverableName#.";
        public static readonly string SubtaskDeletedByOwner = "Subtask #TaskName# of #Project# ,assigned to #UserFullName# has been deleted by #UserFullName#.";

        public static readonly string progressLevelDateChangeSingle = "Planned date for #TPLAbbreviation# of #DeliverableName# has been changed from #OldDate# to #NewDate#.";
        public static readonly string progressLevelDateChange = "Planned date for #TPLAbbreviation# of #DeliverableName# have been changed.";

    }
}
