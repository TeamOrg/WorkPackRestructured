using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLScopeChangeTypeRepository
    {
        void AddScopeChangeType(params ScopeChangeType[] scope);
        bool CheckDuplicate(ScopeChangeType scope, bool IsInsert);
        List<object> getAllProjectScopeChanges();
        IList<ScopeChangeType> GetAllScopeChangeTypes();
        ScopeChangeType GetScopeChangeTypeByID(int scopeID);
        IList<ScopeChangeType> GetScopeChangeTypeList(ScopeChangeType scope);
        void RemoveScopeChangeType(params ScopeChangeType[] scope);
        void UpdateScopeChangeType(params ScopeChangeType[] scope);
    }
}