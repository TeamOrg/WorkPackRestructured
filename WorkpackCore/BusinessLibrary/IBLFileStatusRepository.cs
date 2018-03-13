using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLFileStatusRepository
    {
        void AddFileStatus(params FileStatu[] fileStatus);
        void DuplicateFileCheckerhavingNoCommentRight(string Userid, int FileID, int milestone);
        List<FileStatu> DuplicateFilestatus(string Userid, int FileID);
        string FilestatusText(int iFileID);
        IList<FileStatu> GetAllFileStatus();
        List<FileStatu> GetApprovedCountList(int FileID, int ProgresslevelID);
        List<FileStatu> GetDuplicateFileCheckerhavingNoCommentRight(int FileID, string userID, int ProgresslevelID);
        FileStatu GetFileStatusByID(int FileStatusID);
        int GetfileStatusID(int FileID);
        bool IsFileApprovedByUser(int FileID, string userID);
        void RemoveFileStatuse(params FileStatu[] fileStatus);
        void UpdateFileStatuse(params FileStatu[] fileStatus);
        void UpdateFileStatusOnComment(string Userid, int FileID, int statusID);
    }
}