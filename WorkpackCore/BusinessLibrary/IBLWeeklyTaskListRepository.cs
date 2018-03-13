using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLWeeklyTaskListRepository
    {
        void AddWeeklyTaskList(params WeeklyTaskList[] WeeklyTaskList);
        IList<WeeklyTaskList> GetAllWeeklyTaskList();
        WeeklyTaskList GetWeeklyTaskListByID(int WeeklyTaskListID);
        List<WeeklyTaskList> GetWeeklyTaskListByUserIDAndWeek(int UserID, DateTime StartDate, DateTime EndDate);
        void RemoveWeeklyTaskList(params WeeklyTaskList[] WeeklyTaskList);
        void UpdateWeeklyTaskList(params WeeklyTaskList[] WeeklyTaskList);
    }
}