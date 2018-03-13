using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLRecipientFiltersRepository
    {
        void AddRecipientFilterts(params RecipientFilter[] RecipientFiltersRepository);
        void addRecipientIds(string RecipientIds, int DocumentFiltersID);
        IList<RecipientFilter> GetAllRecipientFilter();
        List<RecipientFilter> GetRecipientFilterByDocFilterId(int prId);
        RecipientFilter GetRecipientFilterByID(int RecipientFiltersRepositoryID);
        void RemoveRecipientFilters(params RecipientFilter[] RecipientFiltersRepository);
        void UpdateRecipientFilters(params RecipientFilter[] RecipientFiltersRepository);
    }
}