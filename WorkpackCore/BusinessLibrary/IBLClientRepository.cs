using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLClientRepository
    {
        void AddClient(params Client[] client);
        bool CheckDuplicate(Client client, bool IsInsert);
        IList<Client> GetAllClients();
        List<object> GetAllClientsContracts();
        List<object> GetAllClientsContractsByClientID(int ClientID);
        Client GetClientByID(int clientID);
        IList<Client> GetClientList(Client client);
        void RemoveClient(params Client[] client);
        void UpdateClient(params Client[] client);
    }
}