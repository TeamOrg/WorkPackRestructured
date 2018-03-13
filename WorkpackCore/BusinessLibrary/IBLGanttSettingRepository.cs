using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLGanttSettingRepository
    {
        void AddGanttSetting(params GanntChartSetting[] ganntChartSetting);
        IList<GanntChartSetting> GetAllGanntChartSetting();
        GanntChartSetting GetGanntChartSettingByID(int ganttSettingID);
        List<usp_getLongestChain_Result> getLongestChain(int ProjectID);
        List<usp_getTaskFloatByProjectID_Result> getTaskFloatByProjectID(int ProjectID, string ScheduleLevel);
        List<USP_GetWBSIDNotInTaskList_Result> getWBSNotInTaskList(int ProjectID);
        void RemoveGanttSetting(params GanntChartSetting[] ganntChartSetting);
        string scheduleProject(int projectID);
        string scheduleProject_Contract(int projectID, int projectContractID);
        void UpdateGanttSetting(params GanntChartSetting[] ganntChartSetting);
    }
}