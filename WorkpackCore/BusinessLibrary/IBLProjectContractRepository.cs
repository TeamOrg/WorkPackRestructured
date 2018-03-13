using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectContractRepository
    {
        void AddProjectContract(params ProjectContract[] ProjectContract);
        bool CheckDuplicate(string CopyName, int ProjectID);
        IList<ProjectContract> GetAllProjectContract();
        ProjectContract GetProjectContractByID(int ProjectContractID);
        List<ProjectContract> GetProjectContractByProjectID(int ProjectID);
        ProjectContract GetProjectContractByProjectIDAndNormSetIDAndName(int ProjectID, int NormSetID, string CopyName);
        void RemoveProjectContract(params ProjectContract[] ProjectContract);
        void UpdateProjectContract(params ProjectContract[] ProjectContract);
    }
}