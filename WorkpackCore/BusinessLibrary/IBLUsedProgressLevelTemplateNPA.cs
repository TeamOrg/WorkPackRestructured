using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLUsedProgressLevelTemplateNPA
    {
        void AddUsedProgressLevelTemplateNPA(params UsedProgressLevelTemplateNPA[] usedprogressLevelTemplateNPA);
        List<UsedProgressLevelTemplateNPA> GetUsedProgressLevelTemplateNPAByProjectIDandTempID(int TemplateID, int TasksettingTempID);
        void RemoveProjectProgressLevelTemplate(params UsedProgressLevelTemplateNPA[] usedprogressLevelTemplateNPA);
        void UpdateProjectProgressLevelTemplate(params UsedProgressLevelTemplateNPA[] usedprogressLevelTemplateNPA);
    }
}