using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNormSetTypeRepository
    {
        void AddNormSetType(params NormSetType[] NormSetType);
        IList<NormSetType> GetAllNormSetType();
        NormSetType GetNormSetTypeByID(int NormSetTypeID);
        void RemoveNormSet(params NormSetType[] NormSetType);
        void UpdateNormSet(params NormSetType[] NormSetType);
    }
}