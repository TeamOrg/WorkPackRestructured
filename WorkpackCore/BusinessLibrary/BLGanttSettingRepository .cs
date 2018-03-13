using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLGanttSettingRepository : IBLGanttSettingRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<GanntChartSetting> _ganttSetting;

        public BLGanttSettingRepository(WorkpackDBContext context, IGenericDataRepository<GanntChartSetting> ganttSetting)
        {
            _context = context;
            _ganttSetting = ganttSetting;
        }

        public IList<GanntChartSetting> GetAllGanntChartSetting()
        {
            return _ganttSetting.GetAll();
        }
        public GanntChartSetting GetGanntChartSettingByID(int ganttSettingID)
        {
            return _ganttSetting.GetSingle(d => d.GanttSettingID == ganttSettingID);
        }
        public void AddGanttSetting(params GanntChartSetting[] ganntChartSetting)
        {
            try
            {
                _ganttSetting.Add(ganntChartSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateGanttSetting(params GanntChartSetting[] ganntChartSetting)
        {
            try
            {
                _ganttSetting.Update(ganntChartSetting);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveGanttSetting(params GanntChartSetting[] ganntChartSetting)
        {
            try
            {
            _ganttSetting.Remove(ganntChartSetting);
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
        public List<usp_getLongestChain_Result> getLongestChain(int ProjectID)
        {
            List<usp_getLongestChain_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getLongestChain(ProjectID).ToList<usp_getLongestChain_Result>();
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
            return list;
        }


        public List<USP_GetWBSIDNotInTaskList_Result> getWBSNotInTaskList(int ProjectID)
        {
            List<USP_GetWBSIDNotInTaskList_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.USP_GetWBSIDNotInTaskList(ProjectID).ToList<USP_GetWBSIDNotInTaskList_Result>();
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
            return list;
        }






        public List<usp_getTaskFloatByProjectID_Result> getTaskFloatByProjectID(int ProjectID, string ScheduleLevel)
        {
            List<usp_getTaskFloatByProjectID_Result> list = null;          
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    ((System.Data.Entity.Infrastructure.IObjectContextAdapter)context).ObjectContext.CommandTimeout = 0;
                  
                //    list = context.usp_getTaskFloatByProjectID(ProjectID, ScheduleLevel).ToList<usp_getTaskFloatByProjectID_Result>();                    
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
            return list;
        }

       
        public string scheduleProject(int projectID)
        {
            //ObjectParameter obj = new ObjectParameter("sQLMessage", typeof(string));
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_scheduleProject(projectID, obj);
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
            return "";
        }

        public string scheduleProject_Contract(int projectID, int projectContractID)
        {
            //ObjectParameter obj = new ObjectParameter("sQLMessage", typeof(string));
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_scheduleProject_Contract(projectID, projectContractID, obj);
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
            return "";
        }

    }
}
