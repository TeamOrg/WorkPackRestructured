using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectProgressLevelTemplateTaskType
    {
        void AddProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType);
        int getAddProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType);
        int getRemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType);
        IEnumerable<ProjectProgressLevelTemplateTaskType> GetTemplateTaskTypeByTemplateDetailID(int TemplateDetailID);
        int getUpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType);
        void RemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType);
        void UpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType);
    }
}