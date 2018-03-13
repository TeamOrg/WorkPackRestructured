using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLApprovalAttachmentFileRepository
    {
        void AddAttachmentFile(params ApprovalAttachmentFile[] attachmentFile);
        IList<ApprovalAttachmentFile> GetAllAttachmentFile();
        ApprovalAttachmentFile GetAttachmentFileByAttachFileID(int attachmentFileID);
        List<ApprovalAttachmentFile> GetAttachmentFileByDelFileID(int DelFileID);
        void RemoveAttachmentFile(params ApprovalAttachmentFile[] attachmentFile);
        void UpdateAttachmentFile(params ApprovalAttachmentFile[] attachmentFile);
    }
}