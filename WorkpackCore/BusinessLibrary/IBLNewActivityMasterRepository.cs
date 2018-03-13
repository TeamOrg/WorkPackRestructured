using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNewActivityMasterRepository
    {
        OperationResult addEstimationTask(string ProjectID, string UserID, Dictionary<string, string[]> item, string MasterTaskType = "1");
        void AddNewActivityMaster(params NewActivityMaster[] NewActivityMaster);
        OperationResult AddNewActivityTask(string ProjectID, string UserID, Dictionary<string, string[]> item, string SetID);
        IList<NewActivityMaster> GetAllNewActivityMaster();
        NewActivityMaster GetNewActivityMasterByID(int NewActivityMasterID);
        List<usp_getNewActivityMasterRecord_Result> GetNewActivityMasterByUserID(int UserID);
        void RemoveNewActivities(params NewActivityMaster[] NewActivityMaster);
        void UpdateNewActivities(params NewActivityMaster[] NewActivityMaster);
        void validateTaskEntry(int normId, bool isProjectLeader, string colValue, EstimationTaskColumnsMaster est, IEnumerable<NormDesDet> pEqVal, IEnumerable<NormDesDet> pEqValNorm, int UserID, int ProjectID, int ProjectTaskId, string DataMappingID, out OperationResult result, List<object> lstMilestoneReq);
    }
}