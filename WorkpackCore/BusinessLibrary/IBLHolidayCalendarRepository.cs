using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLHolidayCalendarRepository
    {
        void AddHolidayCalendar(params HolidayCalendar[] dailyworkhr);
        IList<HolidayCalendar> c_GetAllHolidayCalendars(int mm, int yy, int ProjectId);
        IList<HolidayCalendar> GetAllHolidayCalendars();
        HolidayCalendar GetHolidayCalendarByID(int HolidayCalendar);
        List<HolidayTypeMaster> getHolidayType();
        List<usp_GetNextWorkingDateByDuration_Result> GetNextWorkingDateByDuration(int projectId, DateTime date, int duration);
        IList<HolidayCalendar> GetProjectHolidayCalendars(int mm, int yy, int projectID);
        void RemoveHolidayCalendar(params HolidayCalendar[] dailyworkhr);
        bool SaveHolidayCalender(int mm, int yy, params HolidayCalendar[] dailyworkhr);
        List<usp_Set_Start_EndDate_Result> SetStartEndDate(int projectId, int duration);
        List<usp_Set_Start_EndDateAwarded_Result> SetStartEndDateAwarded(DateTime startDate, DateTime EndDate, int Duration, int projectId);
        void UpdateHolidayCalendar(params HolidayCalendar[] dailyworkhr);
    }
}