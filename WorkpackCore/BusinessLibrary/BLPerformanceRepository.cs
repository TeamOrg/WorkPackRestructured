using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLPerformanceRepository : IBLPerformanceRepository
    {
        public usp_PerformanceChartForDelay_Result GetSchedulePreformance(DateTime FromDate, DateTime ToDate, int UserID)
        {
            usp_PerformanceChartForDelay_Result obj = null;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    obj = context.usp_PerformanceChartForDelay(UserID, FromDate, ToDate, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).Single();
                ////}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }
        public ScheduleHealth GetTSH(string ScheduleType)
        {
            ScheduleHealth scheduleHealth = null;
            try
            {                
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    scheduleHealth = context.ScheduleHealths.FirstOrDefault(p => p.ScheduleType == ScheduleType);
                //}                 
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return scheduleHealth;
        }
        public usp_PerformanceChartForOverHead_Result GetSchedulePerformanceOverHead(DateTime FromDate, DateTime ToDate, int UserID)
        {
            usp_PerformanceChartForOverHead_Result obj = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    obj = context.usp_PerformanceChartForOverHead(UserID, FromDate, ToDate, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).Single();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;

        }
        public IList<usp_PerformanceGridList_Result> GetSchedulePerformanceGridList(DateTime FromDate, DateTime ToDate, int UserID)
        {
            IList<usp_PerformanceGridList_Result> objList = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    objList = context.usp_PerformanceGridList(FromDate, ToDate, UserID, Convert.ToInt16(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<usp_PerformanceGridList_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return objList;
        }
        public IList<usp_PerformanceChartForDelayByDept_Result> GetDeptPerformanceDelay(DateTime FromDate, DateTime ToDate, int DeptID)
        {
            IList<usp_PerformanceChartForDelayByDept_Result> objList = null;
            try
            {
                //using (var contect = new Cubicle_EntityEntities())
                //{
                //    objList = contect.usp_PerformanceChartForDelayByDept(DeptID, FromDate, ToDate, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<usp_PerformanceChartForDelayByDept_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return objList;
        }
        public IList<usp_PerformanceChartForOverHeadByDept_Result> GetDeptPerformanceOverHead(DateTime FromDate, DateTime ToDate, int DeptID)
        {
            IList<usp_PerformanceChartForOverHeadByDept_Result> objList = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    objList = context.usp_PerformanceChartForOverHeadByDept(DeptID, FromDate, ToDate, Convert.ToInt16(Common.TaskStatusID.AcceptedByTaskOwner)).ToList < usp_PerformanceChartForOverHeadByDept_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return objList;
        }
        

        

        public IList<usp_My_Target_GridList_Result> GetApplicationandTargetList(int UserID)
        {
            IList<usp_My_Target_GridList_Result> functionReturnValue = null;          
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    functionReturnValue=context.usp_My_Target_GridList(UserID).ToList<usp_My_Target_GridList_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }            
            return functionReturnValue;
        }

        public IList<SP_Dashboard_Applications_Result> GetApplicationandProgressTimesheetList( int UserID)
        {
            IList<SP_Dashboard_Applications_Result> functionReturnValue = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    functionReturnValue = context.SP_Dashboard_Applications(UserID, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<SP_Dashboard_Applications_Result>() ;
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }           
            return functionReturnValue;
        }
    }
}
