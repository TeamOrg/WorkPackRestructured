using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTimeSheetDeviationRepository
    {
        void AddTimeSheetDeviation(params TimeSheetDeviation[] timeSheetDeviation);
        IList<TimeSheetDeviation> GetAllTimeSheetDeviation();
        List<TimeSheetDeviation> GetAllTimeSheetDeviationByTaskID(int TaskID);
        List<TimeSheetDeviation> GetAllTimeSheetDeviationByWeekTaskID(int weekID, int TaskID);
        TimeSheetDeviation GetTimeSheetDeviationByID(int TimeSheetDeviationID);
        void RemoveTimeSheetDeviation(params TimeSheetDeviation[] timeSheetDeviation);
        void UpdateTimeSheetDeviation(params TimeSheetDeviation[] timeSheetDeviation);
    }
}