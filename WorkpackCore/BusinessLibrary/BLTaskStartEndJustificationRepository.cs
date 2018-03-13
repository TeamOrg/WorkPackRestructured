using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskStartEndJustificationRepository : IBLTaskStartEndJustificationRepository
    {

       


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskStartEndJustification> _taskStartEndJustification;

        public BLTaskStartEndJustificationRepository(WorkpackDBContext context, IGenericDataRepository<TaskStartEndJustification> taskStartEndJustification)
        {
            _context = context;
            _taskStartEndJustification = taskStartEndJustification;
        }







        public IList<TaskStartEndJustification> GetAllTaskStartEndJustification()
        {
            return _taskStartEndJustification.GetAll();
        }
        public TaskStartEndJustification GetTaskStartEndJustificationByID(Int32 TaskStartEndJustificationID)
        {
            return _taskStartEndJustification.GetSingle(d => d.ID == TaskStartEndJustificationID);         
        }
        public void AddTaskStartEndJustification(params TaskStartEndJustification[] client)
        {
            try
            {
                _taskStartEndJustification.Add(client);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateTaskStartEndJustification(params TaskStartEndJustification[] client)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskStartEndJustification.Update(client);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateTaskStartEndJustificationDormantUser(int User, int ProjectTaskID, int ProjectID,string IsStart,string Deviation)
        {
           // try
          //  {
            //    BLTaskStartEndJustificationRepository bltaskstartend = new BLTaskStartEndJustificationRepository();
            //    List<TaskStartEndJustification> lststartend= bltaskstartend.GetAllTaskStartEndJustificationByTaskID(ProjectTaskID);
            //    if (lststartend.Count > 0)
            //    {
            //        foreach (var i in lststartend)
            //        {
            //            i.ActualStartEndJustification = Deviation;
            //            i.EntityState = DominModel.EntityState.Modified;
            //            bltaskstartend.UpdateTaskStartEndJustification(i);
            //        }
            //    }
            //    else
            //    {
            //        TaskStartEndJustification taskstartend = new TaskStartEndJustification();
            //        taskstartend.TaskID = ProjectTaskID;
            //        taskstartend.UserID = User;
            //        taskstartend.ActualStartEndJustification = Deviation;
            //        taskstartend.ProjectID = ProjectID;
            //        taskstartend.isStart = IsStart;
            //        taskstartend.ApprovalStatus = "Submit";
            //        taskstartend.EntityState = DominModel.EntityState.Added;
            //        AddTaskStartEndJustification(taskstartend);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
        public void RemoveTaskStartEndJustification(params TaskStartEndJustification[] client)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskStartEndJustification.Remove(client);
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

        public List<TaskStartEndJustification> GetAllTaskStartEndJustificationByTaskID(int TaskID)
        {
            List<TaskStartEndJustification> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TaskStartEndJustifications.Where(a => a.TaskID == TaskID).ToList <TaskStartEndJustification>();
            //}
            return lst;
        }

    }



}
