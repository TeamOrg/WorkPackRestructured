using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelLibrary
{

    public partial class NotifiMessage
    {
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public int MessageID { get; set; }
        public string FromUserID { get; set; }
        public string ToUserID { get; set; }
        public string Content { get; set; }
        public string RedirectURL { get; set; }
        public string QueryString { get; set; }
        public string MessageFor { get; set; }
        public string Active { get; set; }
        public string MessageType { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime VisitDate { get; set; }
    }
    public partial class User_Message
    {
        public int MessageID { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public string FromUserID { get; set; }
        public string ToUserID { get; set; }
        public string Message { get; set; }
        public string RedirectURL { get; set; }
        public string QueryString { get; set; }
        public string MessageFor { get; set; }
        public string Active { get; set; }
        public string MessageType { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public string IsProgressAlert { get; set; }
    }


    public partial class UploadFileData
    {
        public int fileID { get; set; }

    }



    public partial class TimeSheet
    {
        public int TimeSheetWeeklyID { get; set; }
        public System.DateTime TimeSheetFromDate { get; set; }
        public System.DateTime TimeSheetToDate { get; set; }
        public int UserID { get; set; }
        public string Justifydeviation { get; set; }
        public decimal AvailableHours { get; set; }
        public decimal ConsumedHours { get; set; }
        public string Remarks { get; set; }
        public decimal JustifydeviationHrs { get; set; }
    }
   
    public partial class usp_ResourceDistributionChart_Result
    {
        public usp_ResourceDistributionChart_Result() { }
        public usp_ResourceDistributionChart_Result(decimal absolute_Numbers, string resources_Distributed_Across_ID, string resources_Distributed_Across_Name, string resources_Distributed_Across_Code, decimal percentage_Value)
        {
            this.Absolute_Numbers = absolute_Numbers;
            this.Resources_Distributed_Across_ID = resources_Distributed_Across_ID;
            this.Resources_Distributed_Across_Name = resources_Distributed_Across_Name;
            this.Resources_Distributed_Across_Code = resources_Distributed_Across_Code;
            this.Percentage_Value = percentage_Value;
        }
        public decimal Percentage_Value { get; set; }
    }
   
    public partial class TaskTypeWiseProgress : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }




   
    public partial class TranType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class Store : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }



   
    public partial class ApprovalAttachmentFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ApprovalAttachmentFileTemp : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class CustomReportFilterMaster : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }


   
    public partial class TimeSheetRejection : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class ActivityLog : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class CompanyType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }




   
    public partial class MaterialNorm : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
    
   
    public partial class ContactType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

    

   
    public partial class RelatedTask : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }


   
    public partial class CustomReport : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class MaterialUnit : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class FileCheckerEmailDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }



   
    public partial class ProjectlevelTaskDependency : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class TaxCode : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }


   
    public partial class EstimationColSettingTemplateDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }


   
    public partial class ProjectleveltasksStakeholder : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class Projectleveltask : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCommentHistory : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class Department_Test : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskCostDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class DocumentFilter : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class IndividualRecipient : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class RecipientFilter : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class MilestonesStakeHolder : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class ProgressLevelTemplateDocDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class UsedProgressLevelTemplateNPA : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class DocStage : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class TaskMilestoneBookedQty : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaskMilestoneBookedQtyFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class DeliverableMessage : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }


   
    public partial class Company : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
    
   
    public partial class commentedAttachFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ProjectMilestonesDocDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskProgressHistory : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class TaskListColorCell : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class IndexDataTable : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class RemindMeProgressLevel : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class FileStatu : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class ResourceLevelChart : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
    //[Serializable]
    //public partial class NotifiMessage
    //{
    //    public string FromUserID { get; set; }
    //    public string ToUserID { get; set; }
    //}
    //
    //public partial class User_Message
    //{
    //    public string FromUserID { get; set; }
    //    public string ToUserID { get; set; }
    //}
   
    public partial class LevelOverloading : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class LastRuningNumber : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }


    public partial class RevisionFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProgressSheet : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class PageTextDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProjectContract : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class MessageTemplate : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class AssentUniqueNumber : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class UploadDeliverableFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
        public string flag { get; set; }



    }
   
    public partial class PageCommentDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class AttachTransmitalFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class Transmittal : IEntity
    {
        public EntityState EntityState { get; set; }

    }
   
    public partial class TransmittalDelList : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TransmittalUser : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class FileChecker : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCircleDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageLineDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCloud : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageCloudDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class PageRecDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class AttachmentFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class CompanyProfile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class CheckerAttachmentFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class MaterialdetailsColumn : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceAllocation : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class HideColumnSetting : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceCategory : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceCostSetting : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NextStepMessageUser : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceCostSettingDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDetail_Contract : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TopManagementUser : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }


   
    public partial class ProjectsAdmin : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ExtProjectsMember : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskColumnsMasterTemp : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
        public virtual ICollection<EstimationTaskColumnsMasterTemp> EstimationTaskColumnsMasterTemps { get; set; }
    }

   
    public partial class EstimationColSettingTemplate : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class NormSetType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class MileStoneTaskType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectMilestone : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class WeeklyTaskList : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ContractNormDistribution : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Message : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsMapping : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormSet : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ContractNormColMaster : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceRequestDesignation : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskCreationNormDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDesignation : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class TaskDesignation_Contract : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ResourceRequest : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class IntroPage : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class AssignResourceForEstimation : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class ProjectTempDocument : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskColumnsMaster : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskList : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class EstimationTaskDependency : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   

    public partial class Currency : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class Norm : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsColumnsMaster : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsManageTable : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NormsManageTableColumn : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NewActivity : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NewActivityDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class NewActivityMaster : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }

   
    public partial class AcceptanceClass : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class AlertsSetting : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TimeSheetWeeklyDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TimeSheetWeekly : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TimeSheetDeviation : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskStartEndJustification : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskHandoverDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Client : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ClientAsset : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class Location : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class DesignType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectWB : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class ExUser : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ClientFocalPoint : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Comment : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ConfigFile : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class DailyWorkingHr : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Department : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class DependencyType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Designation : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class EmailTemplate : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class HolidayCalendar : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class LeaveType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Priority : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskMilestoneTargetDate : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskMilestoneTargetDates_Contract : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProgressLevelTemplateDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Project : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectPipeline : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectPipelineDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class WBSTemplateDetail : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class WBSTemplate : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }

    }
   
    public partial class VW_MYTASK
    {
    }
   
    public partial class ProjectProgressLevelTemplate : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectProgressLevelTemplateTaskType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectStage : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }


   
    public partial class Confidential : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Role : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class RoleRight : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ScheduleHealth : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ScopeChangeType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Skill : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class Technology : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

    public partial class User : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

    public partial class UserRole : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

    public partial class UserActivityTracker : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectTaskList : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectTaskList_Contract : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_getProjectWiseHrsForLoadingDetails_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_getDrillDownProjectByProjectId_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_ProjectProgressSummary_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_getViewTransmittalDetails_Result
    {
        public Nullable<decimal> Loading { get; set; }
    }
   
    public partial class usp_getTaskDetailsByProjectID_Result
    {

    }
   
    public partial class usp_getTaskTypeWiseProgressByTaskID_Result
    {

    }
   
    public partial class usp_GetPageCommentDetailsForApprov_Result
    {

    }
   
    public partial class usp_getTransmittalDetails_Result
    {

    }
   
    public partial class usp_GetTransmittalUser_Result
    {

    }

   
    public partial class UserEmployerHistory
    {
    }
   
    public partial class TaskDependency : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TaskDependency_Contract : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ScopeChange : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class GanntChartSetting : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_getMilestoneDetailsAndTask_Result : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }


    public partial class usp_getUserList_Result
    {
    }

   
    public partial class usp_GetPageCommentDetails_Result
    {
    }
   
    public partial class usp_getTaskMilestoneTargetDates_Result
    {
    }
   
    public partial class usp_ChangeProjectTaskList_Result
    {
    }
   
    public partial class usp_ChangeMilestoneTargetDates_Result
    {
    }
   
    public partial class usp_getDeliverableTaskByUserID_Result
    {
    }
   
    public partial class usp_getViewTargetMilestone_Result
    {
    }
   
    public partial class usp_getTaskStatusReportByProjectID_Result
    {
    }
   
    public partial class usp_getTaskRecordByID_Result
    {
    }
   
    public partial class Leave : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class OverTimeRequest : IEntity
    {
        public EntityState EntityState { get; set; }
        public int ProjectID { get; set; }


    }
   
    public partial class ProjectDocument : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectsDepartment : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    
    
    public partial class InventoryColumnsMaster : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
    
   
    public partial class SimilarProject : IEntity
    {
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProjectStatu : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_TaskMilestoneTargetDatesByProjectTaskID_Result : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class usp_GetAllNewActivityUsersByActvityID_Result : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class UserComment : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaskProgressReminder : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class TransmitalTemplate : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class PageComment_images : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProgressLevelNotification : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class ProgressLevelNotificationRole : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
   
    public partial class BufferField : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown4 : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class Dropdown5 : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown6 : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class Dropdown7 : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class Dropdown8 : IEntity
    {
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown9 : IEntity
    {
        public EntityState EntityState { get; set; }
    }


   
    public partial class Dropdown10 : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class SharedProjectTaskList : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProcurementDocumentColumnsMaster : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class ProcurementDocumentData : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaxCodesDetail : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class TaxType : IEntity
    {
        [NotMapped]
        public EntityState EntityState { get; set; }
    }

   
    public partial class ApprovalRelatedTask : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class SelfApprovalComment : IEntity
    {
        public EntityState EntityState { get; set; }
    }

   
    public partial class MaterialInventory : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class MaterialInventoryDetail : IEntity
    {
        public EntityState EntityState { get; set; }

    }

   
    public partial class ProgressUpdateNotificationSetting : IEntity
    {
        public EntityState EntityState { get; set; }

    }
    


   
    public partial class usp_GetEstimationDetailsNotTransferedByProjectID_Result
    {
        public int Priority { get; set; }
        public string PreReqInfo { get; set; }
        public string Del { get; set; }
        public string Remarks { get; set; }

    }




    //Classes for Mapping
    public class Client_FocalPoint
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int FocalPointID { get; set; }
        public string FocalPointName { get; set; }
        public string FocalPointCode { get; set; }
    }
    public class Int_ListItem
    {
        public int itemField1 { get; set; }
        public Nullable<int> itemField2 { get; set; }
    }





}
