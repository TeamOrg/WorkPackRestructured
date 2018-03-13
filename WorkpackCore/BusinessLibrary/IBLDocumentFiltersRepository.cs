using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDocumentFiltersRepository
    {
        int addDocFilterIds(string projectID, string DocFilterIds, string Action);
        void AddDocumentFilters(params DocumentFilter[] documentFiltersRepository);
        bool deleteDistributionMatrix(string DocumentFiltersID);
        IList<DocumentFilter> GetAllDocumentFilter();
        List<usp_getDistributionMatrixByProjectId_Result> getDistributionMatrix(string projectID);
        DocumentFilter GetDocumentFilterByID(int documentFiltersRepositoryID);
        List<usp_getUserByDistributionMatrixByTaskId_Result> getUserByDistributionMatrixByTaskId(int DeliverableId, int MilestoneId, int RevisionId);
        void RemoveDocumentFilters(params DocumentFilter[] documentFiltersRepository);
        void UpdateDocumentFilters(params DocumentFilter[] documentFiltersRepository);
    }
}