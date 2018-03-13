using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTransmittalUserRepository
    {
        void AddTransmittalUser(params TransmittalUser[] TransmittalUser);
        IList<TransmittalUser> GetAllTransmittalUsers();
        TransmittalUser GetTransmittalUserByID(int TransmittalUserID);
        void RemoveTransmittalUser(params TransmittalUser[] TransmittalUser);
        void UpdateTransmittalUser(params TransmittalUser[] TransmittalUser);
    }
}