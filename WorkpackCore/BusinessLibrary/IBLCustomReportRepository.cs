using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLCustomReportRepository
    {
        void AddCustomReport(int CompanyID);
        void AddCustomReport(params CustomReport[] CustomReport);
        List<CustomReport> GetAllCustomReport();
        List<object> GetCustomReport(int CompanyId);
        CustomReport GetCustomReportByID(int Id);
        CustomReport GetCustomReportByModuleID(int ModuleId, int CompanyID);
        void RemoveCustomReport(params CustomReport[] CustomReport);
        void UpdateCustomReport(params CustomReport[] CustomReport);
    }
}