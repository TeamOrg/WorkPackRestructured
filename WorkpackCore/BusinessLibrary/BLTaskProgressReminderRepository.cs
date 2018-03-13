using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{

    public class BLTaskProgressReminderRepository : IBLTaskProgressReminderRepository

    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskProgressReminder> _taskProgressReminder;

        public BLTaskProgressReminderRepository(WorkpackDBContext context, IGenericDataRepository<TaskProgressReminder> taskProgressReminder)
        {
            _context = context;
            _taskProgressReminder = taskProgressReminder;
        }





        public IList<TaskProgressReminder> GetAllTaskProgressReminder()
        {
            return _taskProgressReminder.GetAll();
        }
        public TaskProgressReminder GetTaskProgressReminderByID(int TaskProgressReminderID)
        {
            return _taskProgressReminder.GetSingle(d => d.ID == TaskProgressReminderID);
        }
        public void AddTaskProgressReminder(params TaskProgressReminder[] TaskProgressReminder)
        {
            try
            {
                _taskProgressReminder.Add(TaskProgressReminder);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaskProgressReminder(params TaskProgressReminder[] TaskProgressReminder)
        {
            try
            {
                _taskProgressReminder.Update(TaskProgressReminder);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaskProgressReminder(params TaskProgressReminder[] TaskProgressReminder)
        {
            try
            {
                _taskProgressReminder.Remove(TaskProgressReminder);
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

        public List<TaskProgressReminder> GetTaskProgressReminderByProjectID(int ProjectID)
        {
            List<TaskProgressReminder> lst = null;
            ////using (var Context = new Cubicle_EntityEntities())
            ////{
            ////    lst = Context.TaskProgressReminders.Where(a => a.ProjectID == ProjectID).ToList<TaskProgressReminder>();
            ////}
            return lst;
        }

        public String GetUserRemiderFlag(int ProjectID,int UserID)
        {
            String strFlag = "Y";
             List<TaskProgressReminder> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TaskProgressReminders.Where(a => a.ProjectID == ProjectID && a.UserID==UserID).ToList<TaskProgressReminder>();
            //}
            //foreach (var item in lst)
            //{
            //    strFlag = item.RemindMe;
            //}
            return strFlag;
        }

        public void RemoveTaskProgressReminderByProjectID(int ProjectID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.TaskProgressReminders.Where(a => a.ProjectID == ProjectID);
            //        foreach (var item in x)
            //        {
            //            context.TaskProgressReminders.Remove(item);
            //            context.SaveChanges();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw new Exception("Record not deleted.");
            //    }
            //}
        }
    }
}
