using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLIndividualRecipientsRepository
    {
        void addIndividualIds(string IndividualIds, int DocumentFiltersID);
        void AddIndividualRecipientts(params IndividualRecipient[] IndividualRecipientsRepository);
        IList<IndividualRecipient> GetAllIndividualRecipient();
        List<IndividualRecipient> GetIndividualRecipientByDocFilterId(int prId);
        IndividualRecipient GetIndividualRecipientByID(int IndividualRecipientsRepositoryID);
        void RemoveIndividualRecipients(params IndividualRecipient[] IndividualRecipientsRepository);
        void UpdateIndividualRecipients(params IndividualRecipient[] IndividualRecipientsRepository);
    }
}