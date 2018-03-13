using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLCommentedAttachFileRepository
    {
        void AddcommentedAttachFile(params commentedAttachFile[] commentedAttachFile);
        IList<commentedAttachFile> GetAllcommentedAttachFile();
        List<commentedAttachFile> GetcommentedAttachFileByFileID(int FileID);
        commentedAttachFile GetcommentedAttachFileByID(int commentedAttachFileID);
        List<commentedAttachFile> GetcommentedAttachFileByUserIdAndFileID(string UserID, int FileID);
        List<commentedAttachFile> GetcommentedAttachFileByUserIdAndFileIDandAttachedFileName(string UserID, int FileID, string strFileName);
        void RemovecommentedAttachFile(params commentedAttachFile[] commentedAttachFile);
        void UpdatecommentedAttachFile(params commentedAttachFile[] commentedAttachFile);
    }
}