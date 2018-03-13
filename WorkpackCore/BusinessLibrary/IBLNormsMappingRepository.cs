using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNormsMappingRepository
    {
        void AddNormsMapping(params NormsMapping[] NormsMapping);
        List<usp_getAllContractNormDetailByCompanyNormSetID_Result> getAllContractNormDetailByCompanyNormSetID(int NormSetID);
        IList<NormsMapping> GetAllNormsMapping();
        List<NormSet> getContractNormSetByCompNormID(int NormSetID);
        NormsMapping GetNormsMappingByID(int NormsMappingID);
        NormsMapping GetNormsMappingByNormIdAndContractNormSetID(int NormID, int contactNormSetID);
        void RemoveNormsMapping(params NormsMapping[] NormsMapping);
        void UpdateNormsMapping(params NormsMapping[] NormsMapping);
    }
}