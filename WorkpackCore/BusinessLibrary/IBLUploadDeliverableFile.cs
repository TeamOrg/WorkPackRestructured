using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLUploadDeliverableFile
    {
        void AddUploadDeliverableFile(params UploadDeliverableFile[] UploadDeliverableFile);
        string ApproveFileByCheckerWithComments(int fileID, string UserID);
        bool CheckIfDuplicateFileInCurrentTab(int DeliverableID, int MilestoneID, int RevisionID, List<UploadDeliverableFile> UploadDeliverableFile);
        bool CheckIfDuplicateFileInCurrentTab(int DeliverableID, int MilestoneID, int RevisionID, string FileName, string FileExtension);
        List<UploadDeliverableFile> checkuploaddelivarablefilesifexistes(int projectid);
        string CheckUserRoleOnFile(string CurrentUserId, string taskOwner, int FileID);
        string generatemassage(string msg, string userid, DateTime? createdon, int UploadDeliverableFileID, List<ApprovalAttachmentFile> lstaaf);
        int GetActivityType(int TaskType);
        List<object> GetAllFilesofsameTaskbyFileid(int fileId);
        IList<UploadDeliverableFile> GetAllUploadDeliverableFile();
        List<UploadDeliverableFile> GetAllUploadDeliverableFileByRevMilID(int RevisionID, int MileStoneID, int DeliverableID);
        int GetCompanyIDByTaskID(int TaskID);
        int Getcountof_dwgpdffileVersion(int Uploadeliverablefileid);
        ProjectTaskList GetDeliverableListByFileID(int FileID);
        List<usp_getDeliverablesByDeliverableID_Result> getDeliverablesByDelID(int DeliverableID);
        List<usp_getDeliverablesByID_Result> getDeliverablesByID1(int DeliverableID);
        int GetFileCountInCurrentTab(int DeliverableID, int MilestoneID, int RevisionID, string FileName, string FileExtension);
        IList<UploadDeliverableFile> GetFilesByDeliverableID(int DeliverableID);
        OperationResult GetLatesRevisionTabFilesAtSUBStage(int FileID, int RevNo);
        OperationResult GetLatestRevisionTabFilesAtSUBStage(int FileID);
        Project getProjectByDeliverableID(int DeliverableID);
        Project getProjectWithCompanyByDeliverableID(int DeliverableID);
        List<usp_getScheduleDetailsByDelID_Result> getScheduleDetails(int DeliverableID);
        List<UploadDeliverableFile> GetUploadDeliverableByArrDelId(List<int> UploadDeliverableFileID);
        UploadDeliverableFile GetUploadDeliverableDwgfileid(int Dwgfileid);
        UploadDeliverableFile GetUploadDeliverableFileByID(int uploadDeliverableFileID);
        List<UploadDeliverableFile> GetUploadDeliverableFileByRevMilID(string Rtype, int MileStoneID, int DeliverableID);
        string GetUploadDeliverableFilePathByID(int uploadDeliverableFileID);
        List<UploadDeliverableFile> GetUploadDeliverableListByDeliverableID(int DeliverableID);
        string GetUploaderInfo(int uploadDeliverableFileID, DateTime? createdon = default(DateTime?));
        List<USP_GetUsersDeliverableFileByRevMilID_Result> GetUsersDeliverableFileByRevMilID(int RevisionID, int MileStoneID, string UserID, int DelID);
        List<usp_fetchattachmentasperfileid_Result> Getusp_fetchattachmentasperfileid_Result(string uploaddeliverableid, int DeliverableID, int MilestoneId, int RevisionId, string UserID);
        List<usp_FetchCheckerAttachment_Result> Getusp_FetchCheckerAttachment_Result(int DeliverableID, int MilestoneId, int RevisionId, string UserID);
        int GetWhetherAdmin(int ProjectID, int DeliverableID);
        int GetWhetherAdmin(int ProjectID, int DeliverableID, int MilestoneID);
        bool IsCheckerRevision(int DeliverableID, int MileStoneID, int RevisionID);
        bool IsDeliverableChecker(int DeliverableID);
        bool IsStakeHolder(int DeliverableID, int MilestoneID, int RevisionID, int ProjectId);
        List<string> ListOftakeHolder(int DeliverableID, int MilestoneID, int RevisionID, int ProjectId);
        bool QuickSendEmailToClientUserForComment(int UserID, string UsersEmails, int DeliverableID, int fileID, string Reminder, string ServerUrl);
        void RemoveUploadDeliverableFile(params UploadDeliverableFile[] uploadDeliverableFile);
        bool SendEmailTocheckerforApprove(int UserID, string UsersEmails, int DeliverableID, string fileID, string ServerUrl);
        bool SendEmailTocheckerforreminder(int UserID, string UsersEmails, int DeliverableID, string fileID, string ServerUrl);
        bool SendEmailToClientUserForComment(int UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, string messagedel = null);
        string SendEmailToClientUserForCommentForEmailDetails(int UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, List<FileCheckerEmailDetail> lstEmailDetail, string messagedel = null, string subject = null);
        bool SendEmailToClientUserForCommentWithAttachment(int UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl);
        bool SendEmailToClientUserFromExternal(string UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, string messagedel = null);
        bool SendEmailToClientUserFromExternalForEmailDetails(string UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, string messagedel = null);
        bool SendEmailToStakeHolder(int UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl);
        bool SendEmailToStakeHolder(int UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl, string messagedel = null, string subject = null);
        bool SendEmailToStakeHolder(string UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl);
        bool SendEmailToStakeHolder(string UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl, string messagedel = null, string subject = null);
        void TrackFileUpload(string TabName, int DeliverableID, string UserID);
        int UpdateProgressDeliverable(int MilestoneID, int docstatus, int DeliverableID, int RevisionID, int fileID, string filestatus);
        void UpdateUploadDeliverableFile(params UploadDeliverableFile[] uploadDeliverableFile);
        //int UploadFile(HttpPostedFile file, int DeliverableID, int MilestoneID, int RevisionID, string UserID, string Client = "W");
        int UploadFiledata(string DocumentTitle, string ProjectNo, string ProjectName, int CompanyID, string DocType, string Revision, string Version, string DocNo, string UploadFilePath, string FileName, string FileExt, int FileSize, int UserID);
    }
}