using System.Collections.Generic;
using DomainModelLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public interface IBLTransmittalRepository
    {
        void AddTransmittal(params Transmittal[] Transmittal);
        OperationResult CheckUnique(string value);
        IList<Transmittal> GetAllTransmittals();
        List<usp_getTransmittalDetails_Result> GetgetTransmittalDetails(string UserID);
        List<object> GetTransmittal(int TransmittalId);
        Transmittal GetTransmittalByID(int TransmittalID);
        int GetTransmittalsRunningNumber(int ProjectID);
        List<object> GetTransmittalUser(int transmittalId);
        List<usp_getViewTransmittalDetails_Result> GetViewgetTransmittalDetails(int TransmittalId, string UserId);
        void RemoveTransmittal(params Transmittal[] Transmittal);
        void UpdateTransmittal(params Transmittal[] Transmittal);
    }
}