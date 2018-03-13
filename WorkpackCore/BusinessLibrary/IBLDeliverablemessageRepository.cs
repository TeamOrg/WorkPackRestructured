using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDeliverablemessageRepository
    {
        void AddDeliverablemessage(params DeliverableMessage[] Deliverablemessage);
        IList<DeliverableMessage> GetAllDeliverablemessages();
        List<object> GetAllDeliverablemessages(int Fileid);
        DeliverableMessage GetAllDeliverablemessages(int Fileid, string userid);
        DeliverableMessage GetDeliverablemessageByID(int DeliverablemessageID);
        void RemoveDeliverablemessage(params DeliverableMessage[] Deliverablemessage);
        void UpdateDeliverablemessage(params DeliverableMessage[] Deliverablemessage);
    }
}