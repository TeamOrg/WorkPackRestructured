using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLRevisionFile
    {
        bool addRevision(string RevisionName, int DeliverableID, int statusID, string UserID, string RevisionType);
        void AddRevisionFile(params RevisionFile[] revisionFile);
        bool checkRevisionName(string RevisionName, int DeliverableID);
        IList<RevisionFile> GetAllRevisionFile();
        List<RevisionFile> GetRevisionFileByDeliverableID(int DeliverableID);
        RevisionFile GetRevisionFileByDeliverableIDandMilestoneID(int DeliverableID, int MilestoneId);
        RevisionFile GetRevisionFileByID(int revisionFileID);
        void RemoveRevisionFile(params RevisionFile[] revisionFile);
        void UpdateRevisionFile(params RevisionFile[] revisionFile);
    }
}