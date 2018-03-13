using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskDesignationRepository : IBLTaskDesignationRepository
    {
      


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskDesignation> _taskDesignation;

        public BLTaskDesignationRepository(WorkpackDBContext context, IGenericDataRepository<TaskDesignation> taskDesignation)
        {
            _context = context;
            _taskDesignation = taskDesignation;
        }




        public IList<TaskDesignation> GetAllTaskDesignation()
        {
            return _taskDesignation.GetAll();
        }
        public TaskDesignation GetTaskDesignationByID(int TaskDesignationID)
        {
            return _taskDesignation.GetSingle(d => d.TaskDesignationID == TaskDesignationID);
        }
        public void AddTaskDesignation(params TaskDesignation[] TaskDesignation)
        {
            try
            {
                _taskDesignation.Add(TaskDesignation);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTaskDesignation(params TaskDesignation[] TaskDesignation)
        {
            try
            {
                _taskDesignation.Update(TaskDesignation);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTaskDesignation(params TaskDesignation[] TaskDesignation)
        {
            try
            {
                _taskDesignation.Remove(TaskDesignation);
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
       
        public List<TaskDesignation> GetTaskDesignationByProjectTaskID(int ProjectTaskID)
        {
            List<TaskDesignation> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TaskDesignations.Where(a => a.ProjectTaskID == ProjectTaskID).ToList<TaskDesignation>();
            //}
            return lst;
        }
        public List<ProjectTaskListCompareCost> GetTaskDesignationDetailsByProjectID(int ProjectID)
        {
            List<ProjectTaskListCompareCost> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = (from ec in Context.EstimationTaskColumnsMasters where ec.DBColPkID>0
            //           join td in Context.TaskDesignations on new { DBColPkID = ec.DBColPkID.Value, ProjectID = ec.ProjectID }
            //           equals new { DBColPkID = td.DesignationID, ProjectID = td.ProjectID } 
            //           where ec.ProjectID == ProjectID
            //           select new ProjectTaskListCompareCost
            //           {
            //               ProjectTaskID = td.ProjectTaskID,
            //               EstimationTaskColumnID = ec.EstimationTaskColumnID,
            //               IsDbField = ec.IsDbField,
            //               DisplayColName = ec.DisplayColName,
            //               DBColName = ec.DBColName,
            //               DBColPkID = ec.DBColPkID,
            //               TableName = ec.TableName,
            //               DisplayOrder = ec.DisplayOrder,
            //               DataType = ec.DataType,
            //               InputOutput = ec.InputOutput,
            //               EquationID = ec.EquationID,
            //               PermanentNameInDb = ec.PermanentNameInDb,
            //               ProjectID = td.ProjectID,
            //               DepartmentID = td.DepartmentID,
            //               DesignationID = td.DesignationID,
            //               DesgHours = td.Hours,
            //               NormsID = td.NormID

            //           }).ToList<ProjectTaskListCompareCost>();
            //}
            return lst;
        }

        public List<TaskDesignation> GetTaskDesignationByProjectID(int ProjectID)
        {
            List<TaskDesignation> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TaskDesignations.Where(a => a.ProjectID == ProjectID).ToList<TaskDesignation>();
            //}
            return lst;
        }



        public List<object> GetTaskDesignationIDAndNameByProjectTaskID(int ProjectTaskID)
        {
            List<object> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = (from td in Context.TaskDesignations
            //          join d in Context.Designations on td.DesignationID equals d.DesignationID
            //          where td.ProjectTaskID == ProjectTaskID
            //          select new { DesignationID=td.DesignationID,DesignationName=d.DesignationName }).ToList<object>();
            //}
            return lst;
        }
        public List<TaskDesignation> GetTaskDesignationByEstimationTaskID(int EstimationTaskID)
        {
            List<TaskDesignation> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TaskDesignations.Where(a => a.EstimationTaskID == EstimationTaskID && (a.ProjectTaskID == null || a.ProjectTaskID == 0)).ToList<TaskDesignation>();
            //}
            return lst;
        }
        public decimal GetUpdatedHours(int ParentTaskID, int DesignationID, decimal allottedHrs)
        {
            decimal Hours = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    decimal hrs = context.TaskDesignations.Where(a => a.ProjectTaskID == ParentTaskID && a.DesignationID == DesignationID).SingleOrDefault().Hours;
                //    if (hrs != null && hrs > 0)
                //    {
                //        Hours = hrs - allottedHrs;
                //        if (Hours < 0)
                //        {
                //            Hours = 0;
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            }
            return Hours;
        }
        public decimal GetUpdatedHoursToOtherDesignation(int ParentTaskID,int selectedDesg, int DesignationID, decimal allottedHrs)
        {
            decimal Hours = 0;
            decimal result = 0;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        decimal hrs = context.TaskDesignations.Where(a => a.ProjectTaskID == ParentTaskID && a.DesignationID == selectedDesg).SingleOrDefault().Hours;

            //        decimal hrsOfOthers = context.TaskDesignations.Where(a => a.ProjectTaskID == ParentTaskID && a.DesignationID == DesignationID).SingleOrDefault().Hours;
            //        int[] selecteddesignation = { selectedDesg };       
           
                 

            //        if ( hrs > 0 && selectedDesg!=DesignationID)
            //        {
            //            decimal TotaltaskHours = (from t in context.TaskDesignations
            //                                      where t.ProjectTaskID == ParentTaskID && !selecteddesignation.Contains(t.DesignationID)
            //                                      group t by new { ProjectTaskID = t.ProjectTaskID } into g
            //                                      select new { Total = g.Sum(c => c.Hours) }).SingleOrDefault().Total;
            //            Hours = hrs - allottedHrs;
            //            if (Hours < 0)
            //            {
            //                Hours = allottedHrs - hrs;
            //                result = (hrsOfOthers - Hours * (hrsOfOthers / TotaltaskHours));
            //            }
            //            else
            //            {
            //                result = hrsOfOthers;
            //            }
            //        }
            //        else if (hrs == 0)
            //        {
            //            decimal TotaltaskHours = (from t in context.TaskDesignations
            //                                      where t.ProjectTaskID == ParentTaskID && !selecteddesignation.Contains(t.DesignationID)
            //                                      group t by new { ProjectTaskID = t.ProjectTaskID } into g
            //                                      select new { Total = g.Sum(c => c.Hours) }).SingleOrDefault().Total;
            //            Hours = hrs - allottedHrs;
            //            if (Hours < 0)
            //            {
            //                Hours = allottedHrs - hrs;
            //                result = (hrsOfOthers - Hours * (hrsOfOthers / TotaltaskHours));
            //            }
            //            else
            //            {
            //                result = hrsOfOthers;
            //            }
            //        }
            //        else if(hrs > 0 && selectedDesg==DesignationID)
            //        {
            //            Hours = hrs - allottedHrs;
            //            if (Hours < 0)
            //            {
            //                Hours = 0;
            //            }
            //            result = Hours;

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //}
            return result;
        }       

        public void InsertIntoTaskDesgnByEstID(int EstimationTaskID)
        {
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    Context.usp_InsertIntoTaskDesgnByEstID(EstimationTaskID);
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
    }
}
