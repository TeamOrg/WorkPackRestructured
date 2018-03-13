using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLEstimationTaskColumnsMasterTempRepository
    {
        int AddEstimationTaskColumnsMastersTemp(params EstimationTaskColumnsMasterTemp[] EstimationTaskColumnsMasterTemp);
        bool checkDuplFieldName(string FieldName, int PrimaryID, int ProjectID, string TemplateID, int MasterTaskType);
        bool checkDuplNameInDb(string NameInDb, int PrimaryId, int ProjectID, int NormSetID, string TemplateID, int MasterTaskType);
        IList<EstimationTaskColumnsMasterTemp> GetAllEstimationTaskColumnsMastersTemp();
        void RemoveEstimationTaskColumnsMasterTemp(params EstimationTaskColumnsMasterTemp[] EstimationTaskColumnsMasterTemp);
        void UpdateEstimationTaskColumnsMasterTemp(params EstimationTaskColumnsMasterTemp[] EstimationTaskColumnsMasterTemp);
    }
}