using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNormsRepository
    {
        void AddNorms(params Norm[] Norms);
        string GetActivityCodeByNormsID(int NormsID);
        IList<Norm> GetAllNorms();
        List<Norm> GetAllNormsByNormSetID(int NormSetID);
        List<Norm> GetAllNormsByProjectID(int ProjectID);
        Norm GetNormsByID(int NormsID);
        void RemoveNorms(params Norm[] Norms);
        void UpdateNorms(params Norm[] Norms);
    }
}