using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLAttachmentFileRepository
    {
        void AddAttachmentFile(params AttachmentFile[] attachmentFile);
        bool Checkattachmentfilifexists(int fileid, int refid);
        string Checkattachmentfilifexists(int fileid, string filename, string tablename, int delid = 0, int milestoneid = 0, int revesionid = 0);
        IList<AttachmentFile> GetAllAttachmentFile();
        AttachmentFile GetAttachmentFileByAttachFileID(int attachmentFileID);
        List<AttachmentFile> GetAttachmentFileByDelFileID(int DelFileID);
        List<GetAttachmentFileAsPerSource_Result> GetFileAsAttachment(int fileid, string source);
        void RemoveAttachmentFile(params AttachmentFile[] attachmentFile);
        void UpdateAttachmentFile(params AttachmentFile[] attachmentFile);
    }
}