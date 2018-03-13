using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLClientFocalPointRepository
    {
        void AddClientFocalPoint(params ClientFocalPoint[] clientFP);
        bool CheckDuplicate(ClientFocalPoint clientFP, bool IsInsert);
        IList<ClientFocalPoint> GetAllClientFocalPoints();
        ClientFocalPoint GetClientFocalPointByID(int clientFPID);
        IList<Client_FocalPoint> GetClientFocalPointList(ClientFocalPoint clientFP);
        void RemoveClientFocalPoint(params ClientFocalPoint[] clientFP);
        void UpdateClientFocalPoint(params ClientFocalPoint[] clientFP);
    }
}