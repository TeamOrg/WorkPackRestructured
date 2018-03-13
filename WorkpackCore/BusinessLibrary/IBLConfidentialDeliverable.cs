using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLConfidentialDeliverable
    {
        void AddConfidentialDeliverable(params Confidential[] Confidential);
        bool IsDeliverableConfidential(int DeliverableID, int MileStoneId, int RevisionId);
        void RemoveConfidentialDeliverable(params Confidential[] Confidential);
    }
}