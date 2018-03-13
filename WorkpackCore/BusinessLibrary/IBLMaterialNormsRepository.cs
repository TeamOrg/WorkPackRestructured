using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMaterialNormsRepository
    {
        void AddNorms(params MaterialNorm[] MaterialNorms);
        bool CheckDuplicateandAdd(List<MaterialNorm> lstmate);
        IList<MaterialNorm> GetAllNorms();
        List<object> GetAllNormsByCompanyID(int? CompanyId = default(int?));
        List<object> GetAllNormsTypeByCompanyID(int? CompanyId = default(int?));
        List<object> GetCurrency(int? CompanyId);
        MaterialNorm GetNormsByID(int MaterialNormsID);
        List<object> GetUOM(int? CompanyId);
        void RearrangeSrNoafterDelete(int? SrNO);
        void RemoveNorms(params MaterialNorm[] MaterialNorms);
        void UpdateNorms(params MaterialNorm[] MaterialNorms);
    }
}