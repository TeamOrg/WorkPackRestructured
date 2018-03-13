using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLContractNormColMasterRepository
    {
        void AddContractNormColMaster(params ContractNormColMaster[] ContractNormColMaster);
        IList<ContractNormColMaster> GetAllContractNormColMaster();
        ContractNormColMaster GetContractNormColMasterByID(int ContractNormColMasterID);
        void RearrangeContractNormsColumnMaster(int NormSetID, int DisplayOrder);
        void RemoveContractNormColMaster(params ContractNormColMaster[] ContractNormColMaster);
        void UpdateContractNormColMaster(params ContractNormColMaster[] ContractNormColMaster);
    }
}