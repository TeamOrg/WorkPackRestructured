using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectProgressLevelTemplate
    {
        void AddProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate);
        int getAddProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate);
        ProjectProgressLevelTemplate GetMilestoneTemplateByName(string Name);
        ProjectProgressLevelTemplate GetProgressTemplateByID(int TemplateDetailID);
        int getRemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate);
        int getUpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate);
        void RemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate);
        void UpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate);
    }
}