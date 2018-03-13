using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLEstimationTaskDependencyRepository
    {
        IList<EstimationTaskDependency> GetAllEstimationTaskDependency();
        void RemoveEstimationTaskDependency(params EstimationTaskDependency[] EstimationTaskdependency);
        bool SaveEstimationTaskDependency(EstimationTaskDependency obj);
        void UpdateEstimationTaskDependency(params EstimationTaskDependency[] EstimationTaskdependency);
    }
}