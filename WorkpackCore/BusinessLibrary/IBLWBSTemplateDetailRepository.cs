using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLWBSTemplateDetailRepository
    {
        void AddWBSTemplate(params WBSTemplateDetail[] wbsTemplateDetail);
        IList<WBSTemplateDetail> GetAllWBSTemplateDetail();
        List<WBSTemplateDetail> GetAllWBSTemplateDetailByWBSID(int WBSId);
        WBSTemplateDetail GetWBSTemplateDetailByID(int wbsTemplateDetailID);
        List<WBSTemplateDetail> GetWBSTemplateDetailByTemplateID(int TemplateID);
        WBSTemplateDetail GetWBSTemplateDetailByWBSID(int WBSID);
        void RemoveWBSTemplate(params WBSTemplateDetail[] wbsTemplateDetail);
        void UpdateWBSTemplate(params WBSTemplateDetail[] wbsTemplateDetail);
        OperationResult UpdateWBSTemplateDetail(int projectid, int TemplateID, List<ProjectWB> TemplateData);
    }
}