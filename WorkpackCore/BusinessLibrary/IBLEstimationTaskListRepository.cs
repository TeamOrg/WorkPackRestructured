using System;
using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLEstimationTaskListRepository
    {
        void AddEstimationTaskList(params EstimationTaskList[] EstimationTaskList);
        bool checkUniqueness(int ProjectID, string DataMappingID, string code, int id);
        IList<EstimationTaskList> GetAllEstimationTaskList();
        List<usp_getDynamicDropdownData_Result> getDynamicDropdownData1(string TableName, string DBColName, string FilterColumn, string FilterValue);
        List<object> getNormsDetailForTask(int NormID);
        List<usp_getWorkingDateDuration_Result> getWorkingDateDuration(DateTime startdate, DateTime enddate);
        void RemoveEstimationTaskList(params EstimationTaskList[] EstimationTaskList);
        void UpdateEstimationTaskList(params EstimationTaskList[] EstimationTaskList);
    }
}