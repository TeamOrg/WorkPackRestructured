using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLFileCheckerEmailDetailRepository
    {
        void AddUploadDeliverableFile(params FileCheckerEmailDetail[] fileChecker);
        IList<FileCheckerEmailDetail> GetAllFileCheckers();
        string GetAllFileCheckersBySentCounter(int SentCounter, List<FileCheckerEmailDetail> lstfc);
        FileCheckerEmailDetail GetFileCheckerByID(int FileCheckerID);
        FileCheckerEmailDetail GetFileCheckerEmailDetailAsPerFileidUseridSentcounter(string userid, int fileid, int sentcounter);
        void RemoveUploadDeliverableFile(params FileCheckerEmailDetail[] fileChecker);
        FileCheckerEmailDetail UpdateCheckerMessageID(int? FilecheckeID, int? sentCounter, string MessageID, string MessageSubject);
        void UpdateUploadDeliverableFile(params FileCheckerEmailDetail[] fileChecker);
    }
}