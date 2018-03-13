using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLWeeklyTaskListRepository : IBLWeeklyTaskListRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<WeeklyTaskList> _weeklyTaskList;

        public BLWeeklyTaskListRepository(WorkpackDBContext context, IGenericDataRepository<WeeklyTaskList> weeklyTaskList)
        {
            _context = context;
            _weeklyTaskList = weeklyTaskList;
        }







        public IList<WeeklyTaskList> GetAllWeeklyTaskList()
        {
            return _weeklyTaskList.GetAll();
        }
        public WeeklyTaskList GetWeeklyTaskListByID(int WeeklyTaskListID)
        {
            return _weeklyTaskList.GetSingle(d => d.WeeklyTaskListID == WeeklyTaskListID);
        }
        public void AddWeeklyTaskList(params WeeklyTaskList[] WeeklyTaskList)
        {
            try
            {
                _weeklyTaskList.Add(WeeklyTaskList);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not added.");
            }
        }
        public void UpdateWeeklyTaskList(params WeeklyTaskList[] WeeklyTaskList)
        {
            try
            {
                _weeklyTaskList.Update(WeeklyTaskList);
            }
            catch (Exception ex)
            {
              //  //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
               // throw new Exception("Record not updated.");
            }
        }
        public void RemoveWeeklyTaskList(params WeeklyTaskList[] WeeklyTaskList)
        {
            try
            {
                _weeklyTaskList.Remove(WeeklyTaskList);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }

        public List<WeeklyTaskList> GetWeeklyTaskListByUserIDAndWeek(int UserID,DateTime StartDate,DateTime EndDate)
        {
            List<WeeklyTaskList> lst = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    lst = context.WeeklyTaskLists.Where(a => a.UserID == UserID && a.WeekStartDate == StartDate && a.WeekEndDate == EndDate).ToList<WeeklyTaskList>();
            ////}
            return lst;
        }

    }
}
