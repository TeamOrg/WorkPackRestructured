using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLEstimationColSettingTemplate
    {
        void AddEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate);
        void applyDefaultTemplateSetting(string ProjectID, string TemplateId, string UserID, int MasterTaskType);
        bool deleteSettingTemplate(int TemplateID, out OperationResult result, string MasterTaskType = "1");
        void Dispose();
        int getAddEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate);
        IList<EstimationColSettingTemplate> GetAllEstimationColSettingTemplate();
        List<object> GetAllEstimationColSettingTemplateObject();
        List<object> GetAllEstimationColSettingTemplateObject(int MasterTaskType);
        string GetDefaultTemplateID(int MasterTaskType);
        EstimationColSettingTemplate GetEstimationColSettingTemplateById(int TemplateID);
        EstimationColSettingTemplate GetEstimationColSettingTemplateByName(string Name);
        List<EstimationTaskColumnsMaster> GetEstimationTaskColumnsMasterDetailsByID(int EstimationTaskColumnID);
        List<object> GetObjEstimationColSettingTemplateByName(string Name);
        int getRemoveEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate);
        int getUpdateEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate);
        void RemoveEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate);
        bool saveSettingTemplateChanges(int TemplateId, int UserID, List<EstimationColSettingTemplateDetail> TemplateData, out OperationResult result);
        bool saveTemplate(string TemplateName, string UserID, int ProjectID, int TemplateID, out OperationResult result, string MasterTaskType = "1");
        void UpdateEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate);
    }
}