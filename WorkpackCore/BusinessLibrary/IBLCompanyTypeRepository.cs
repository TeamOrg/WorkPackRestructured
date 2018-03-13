using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLCompanyTypeRepository
    {
        void AddCompanyType(params CompanyType[] companyType);
        bool CheckDuplicate(CompanyType companyType, bool IsInsert);
        IList<CompanyType> GetAllCompanyType();
        CompanyType GetCompanyTypeID(int CompanyTypeID);
        void RemoveCompanyType(params CompanyType[] companyType);
        void UpdateCompanyType(params CompanyType[] companyType);
    }
}