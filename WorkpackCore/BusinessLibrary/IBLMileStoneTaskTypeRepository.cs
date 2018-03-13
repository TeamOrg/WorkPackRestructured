using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMileStoneTaskTypeRepository
    {
        void AddMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType);
        int getAddMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType);
        List<ProjectMilestone> GetMileStoneByProjectIDAndTaskTypeID(int ProjectID, int TaskTypeID);
        List<MileStoneTaskType> GetMileStoneTaskTypeByMileStoneID(int MileStoneId);
        void RemoveMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType);
        void UpdateMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType);
    }
}