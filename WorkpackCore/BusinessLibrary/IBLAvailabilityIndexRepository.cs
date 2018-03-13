using DomainModelLibrary;
using System;

namespace BusinessLibrary
{
    public interface IBLAvailabilityIndexRepository
    {
        System.Collections.Generic.IList<usp_AvailabilityInWeek_Result> GetAvailabilityIndex(DateTime From, DateTime To, int UserID, out string totalHrs, int EstimationID, int AwaitedID);
    }
}