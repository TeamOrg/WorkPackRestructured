using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTransmittalDelListRepository
    {
        void AddTransmittalDelList(params TransmittalDelList[] TransmittalDelList);
        IList<TransmittalDelList> GetAllTransmittalDelLists();
        TransmittalDelList GetTransmittalDelListByID(int TransmittalDelListID);
        void RemoveTransmittalDelList(params TransmittalDelList[] TransmittalDelList);
        void UpdateTransmittalDelList(params TransmittalDelList[] TransmittalDelList);
    }
}