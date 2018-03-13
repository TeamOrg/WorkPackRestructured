using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLResourceLevelChartRepository
    {
        IList<ResourceLevelChart> GetAllResourceLevelChart();
        IList<ResourceLevelChart> GetResourceLevelChartByLoggedInUserID(int loggedinUserID);
    }
}