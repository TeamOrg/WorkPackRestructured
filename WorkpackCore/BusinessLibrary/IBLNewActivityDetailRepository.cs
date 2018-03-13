using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNewActivityDetailRepository
    {
        void AddNewActivityDetails(params NewActivityDetail[] NewActivityDetails);
        IList<NewActivityDetail> GetAllNewActivityDetails();
        List<NewActivityDetail> GetAllNewActivityDetailsByActivityID(int NewActivityID);
        List<usp_GetAllNewActivityUsersByActvityID_Result> GetAllNewActivityUsersByActvityID(int ActivityID);
        NewActivityDetail GetNewActivityDetailByID(int NewActivityDetailID);
        void RemoveNewActivityDetails(params NewActivityDetail[] NewActivityDetails);
        void UpdateNewActivityDetails(params NewActivityDetail[] NewActivityDetails);
    }
}