using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLScheduleHealthRepository
    {
        void AddScheduleHealth(params ScheduleHealth[] scheduleHealth);
        bool c_SaveScheduleHealth(ScheduleHealth scheduleHealth);
        IList<ScheduleHealth> GetAllScheduleHealths();
        ScheduleHealth GetScheduleHealthByID(int scheduleHealthID);
        ScheduleHealth GetScheduleHealthByType(string ScheduleType);
        void RemoveScheduleHealth(params ScheduleHealth[] scheduleHealth);
        void UpdateScheduleHealth(params ScheduleHealth[] scheduleHealth);
    }
}