using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLApprovalAttachmentFileTempRepository
    {
        void AddAttachmentFileTemp(params ApprovalAttachmentFileTemp[] attachmentFile);
        IList<ApprovalAttachmentFileTemp> GetAllAttachmentFile();
        ApprovalAttachmentFileTemp GetAttachmentFileByAttachFileID(int attachmentFileID);
        List<ApprovalAttachmentFileTemp> GetAttachmentFileByDelFileID(int DelFileID, string UserId);
        void RemoveAttachmentFile(params ApprovalAttachmentFileTemp[] attachmentFile);
        void UpdateAttachmentFile(params ApprovalAttachmentFileTemp[] attachmentFile);
    }
}