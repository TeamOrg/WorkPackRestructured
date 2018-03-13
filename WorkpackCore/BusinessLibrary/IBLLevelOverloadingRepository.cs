using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLLevelOverloadingRepository
    {
        IList<LevelOverloading> GetAllLevelOverloading();
        IList<LevelOverloading> GetLevelOverloadingListByLoggedInUserID(int loggedinUserID);
    }
}