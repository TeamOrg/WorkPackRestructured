using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProgressLevelTemplateDocDetailRepository
    {
        void AddProgressLevelTemplateDocDetail(params ProgressLevelTemplateDocDetail[] templatedocdetails);
        List<ProgressLevelTemplateDocDetail> GetAllpercentageByMilestoneAndTaskTypeID(int MilestoneID, int TaskTypeID);
        IList<ProgressLevelTemplateDocDetail> GetAllTemplateDocDetail();
    }
}