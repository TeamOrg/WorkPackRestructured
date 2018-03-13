using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLAssignResourceForEstimationRepository
    {
        void AddAssignResourceForEstimation(params AssignResourceForEstimation[] assignResourceForEstimation);
        IList<AssignResourceForEstimation> GetAllAssignResourceForEstimation();
        AssignResourceForEstimation GetAssignResourceForEstimationByID(int assignResourceForEstimationID);
        List<AssignResourceForEstimation> GetAssignResourceForEstimationByProjectID(int ProjectID);
        int GetAssignResourceUserID(int ProjectID, int UserID);
        void RemoveAssignResourceForEstimation(params AssignResourceForEstimation[] assignResourceForEstimation);
        void UpdateAssignResourceForEstimation(params AssignResourceForEstimation[] assignResourceForEstimation);
    }
}