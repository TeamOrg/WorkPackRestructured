using System.Collections.Generic;
using DomainModelLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public interface IBLCustomReportFilterRepository
    {
        void AddCustomReportFilter(params CustomReportFilterMaster[] CustomReportFilter);
        List<CustomReportFilterMaster> GetAllCustomReportFilter();
        OperationResult GetCustomReportFilter(int CustomReportID);
        List<CustomReportFilterMaster> GetCustomReportFilterByCustomReportID(int CustomReportID);
        CustomReportFilterMaster GetCustomReportFilterByID(int Id);
        void RemoveCustomReportFilter(params CustomReportFilterMaster[] CustomReportFilter);
        void UpdateCustomReportFilter(params CustomReportFilterMaster[] CustomReportFilter);
    }
}