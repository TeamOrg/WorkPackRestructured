using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLCompanyRepository
    {
        void AddCompany(params Company[] company);
        IList<Company> GetAllCompanies();
        Company GetCompanyByCompanyID(int CompanyID);
        int GetCompanyIDByCompanyName(string companyName);
        void RemoveRole(params Company[] company);
        int SaveCompany(Company objCompany);
        void UpdateCompany(params Company[] company);
        void UpdateUserAlertFlag(int CompanyId);
        void UpdateUserAlertFlag1(int CompanyId);
    }
}