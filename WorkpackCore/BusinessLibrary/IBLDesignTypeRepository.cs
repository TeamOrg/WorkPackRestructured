using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDesignTypeRepository
    {
        void AddDesignType(params DesignType[] designType);
        bool CheckDuplicate(DesignType designType, bool IsInsert);
        IList<DesignType> GetAllDesignType();
        DesignType GetDesignTypeByID(int DesignTypeID);
        void RemoveDesignType(params DesignType[] designType);
        void UpdateDesignType(params DesignType[] designType);
    }
}