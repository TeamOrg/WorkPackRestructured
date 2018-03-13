using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProgressLevelTemplateDetail
    {
        void AddProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail);
        int getAddProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail);
        int getRemoveProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail);
        ProgressLevelTemplateDetail GetTemplateDetailByID(int TemplateDetailID);
        List<ProgressLevelTemplateDetail> GetTemplateDetailsBytemplateID(int TemplateID, int TaskTypeID);
        List<ProgressLevelTemplateDetail> GetTemplateDetailsFromDocBytemplateID(int TemplateID);
        List<ProgressLevelTemplateDocDetail> GetTemplateDocDetailsByTemplateDetID(int TemplateDetID);
        IEnumerable<ProjectProgressLevelTemplateTaskType> GetTemplateTaskTypeByID(int TemplateDetailID);
        int getUpdateProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail);
        void RemoveProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail);
        void UpdateProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail);
    }
}