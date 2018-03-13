using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNormSetRepository
    {
        void AddNormSet(params NormSet[] NormSet);
        int checkDuplicateNormName(string NormSetName, int NormSetID, int CompanyID);
        bool deleteNormSet(int NormID);
        IList<NormSet> GetAllNormSet();
        List<usp_getNormSetData_Result> GetAllNormSetData(int CompanyID);
        int GetDefaultCompanyNorm(string ClientName);
        List<NormSet> getMappingNormSetByNormSetID(int CompanyNormSetID, int projectID);
        NormSet GetNormSetByID(int NormSetID);
        void InsertTempdataIntoMainTables(int templateid, int projectid, bool edit = false);
        int InsertTemplateData(int? projectid, int templateid);
        void RemoveNormSet(params NormSet[] NormSet);
        void UpdateNormSet(params NormSet[] NormSet);
    }
}