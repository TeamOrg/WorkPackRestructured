using System.Collections.Generic;
using DomainModelLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public interface IBLWBSTemplateRepository
    {
        void AddWBSTemplate(params WBSTemplate[] wbsTemplate);
        bool DeleteWBSTemplate(int TemplateID, out OperationResult result);
        IList<WBSTemplate> GetAllWBSTemplate();
        List<object> GetAllWBSTemplateObject();
        WBSTemplate GetWBSTemplateByID(int wbsTemplateID);
        List<object> GetWBSTemplateByTemplateName(string wbsTemplateName);
        void RemoveWBSTemplate(params WBSTemplate[] wbsTemplate);
        bool saveTemplate(string TemplateName, string UserID, List<WBSTemplateDetail> TemplateData, out OperationResult result);
        void UpdateWBSTemplate(params WBSTemplate[] wbsTemplate);
    }
}