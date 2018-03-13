using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLContractNormDistributionRepository
    {
        void AddContractNormDistribution(params ContractNormDistribution[] ContractNormDistribution);
        IList<ContractNormDistribution> GetAllContractNormDistributions();
        ContractNormDistribution GetContractNormDistributionByID(int ContractNormDistributionID);
        List<usp_GetContractNormsDistribution_Result> GetContractNormsDistribution();
        void RemoveContractNormDistribution(params ContractNormDistribution[] ContractNormDistribution);
        void UpdateContractNormDistribution(params ContractNormDistribution[] ContractNormDistribution);
    }
}