using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLCheckerAttachmentFile
    {
        void AddAttachmentFile(params CheckerAttachmentFile[] attachmentFile);
        void AddCheckerAttachmentFile(params CheckerAttachmentFile[] attachmentFile);
        List<CheckerAttachmentFile> GetAttachedFileBydelid(int delid, int milestoneid, int revisionid, string filename = "");
        CheckerAttachmentFile GetAttachedFileByID(int AttachedFileID);
        CheckerAttachmentFile GetByCheckerAttachmentFileID(int AttachCheckerFileID);
        IList<CheckerAttachmentFile> GetCheckerAttachmentFile();
        void RemoveCheckerAttachmentFile(params CheckerAttachmentFile[] attachmentFile);
        void UpdateCheckerAttachmentFile(params CheckerAttachmentFile[] attachmentFile);
    }
}