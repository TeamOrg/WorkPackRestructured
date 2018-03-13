using System.Collections.Generic;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public interface IBLFileCheckerRepository
    {
        void AddUploadDeliverableFile(params FileChecker[] fileChecker);
        List<FileChecker> DuplicateFileChecker(string Userid, int FileID);
        List<FileChecker> DuplicateFileChecker(string Userid, int FileID, string Type);
        IList<FileChecker> GetAllFileCheckers();
        string GetCheckerList(string UserID, int FileID);
        List<FileChecker> GetFileCheckerByFileID(int FileID);
        FileChecker GetFileCheckerByID(int FileCheckerID);
        List<FileChecker> GetFileCheckerByUploadDelFileID(string FileIDs);
        List<FileChecker> GetFileCheckerCanEditByFileID(int FileID);
        int getFilecheckerIdByUserIDFileID(string UserID, int? FileID);
        IList<FileChecker> GetFileCheckerList(string Userid, int FileID, string CanEdit);
        //List<ListItem> GetFileCheckersByFileID(int FileID);
        int GetSentCounter(int FileID);
        void PopulatesenderData(List<FileCheckerEmailDetail> lstfc, ref DataTable dt, int ProjectID);
        void RemoveUploadDeliverableFile(params FileChecker[] fileChecker);
        void SetReadOnlyDemaildetails(string Userid, int FileID, int SentCounter);
        FileChecker UpdateCheckerMessageID(string UserID, int FileID, string messageID, string emailSubject);
        void UpdateUploadDeliverableFile(params FileChecker[] fileChecker);
    }
}