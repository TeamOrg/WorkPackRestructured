using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLEstimationColSettingTemplateDetail
    {
        void AddEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail);
        int getAddEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail);
        IList<EstimationColSettingTemplateDetail> GetAllEstimationColSettingTemplateDetail();
        EstimationColSettingTemplateDetail getEstimationColSettingTemplateDetailByID(int EstimationColSettingTemplateDetailID);
        List<EstimationColSettingTemplateDetail> getEstimationSettingTemplateDetailByTempID(int TemplateID);
        List<EstimationColSettingTemplateDetail> getEstimationSettingTemplateDetailByTempID(int TemplateID, int companyid);
        EstimationColSettingTemplateDetail GetLastUsedBufferColoumnByTemplateID(int templateID, string datatype, int MasterTaskTypeR);
        List<EstimationColSettingTemplateDetail> GetLastUsedBufferColoumnByTemplateID(int? templateID, string datatype, int MasterTaskTypeR);
        int GetMaxDiplayNumberTemplate(int TemplateID);
        int getRemoveEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail);
        int getUpdateEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail);
        void RemoveEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail);
        void UpdateEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail);
    }
}