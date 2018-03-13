using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLUserProjectListRepository
    {
        IList<usp_Menubreadcrumb_Result> getMenubreadcrumb(int ModuleID);
        IList<Project> GetProjectNameandCode();
        IList<User> GetProjectUser(int ProjectID);
        List<int> getSuperVisionCount(int userID);
        IList<usp_getUserMenu_Result> getUserMenu(int userID, string DisableManHours);
        IList<Project> getUserProject(int UserID);
    }
}