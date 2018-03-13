using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDocStageRepository
    {
        IList<DocStage> GetAlldocstage();
        int GetDocstageIdbyDocStage(string DocStage);
    }
}