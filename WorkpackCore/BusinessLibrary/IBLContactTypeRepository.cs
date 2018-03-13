using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLContactTypeRepository
    {
        void AddContactType(params ContactType[] contactType);
        bool CheckDuplicate(ContactType contacttype, bool IsInsert);
        IList<ContactType> GetAllContactType();
        ContactType GetContactTypeByID(int ContactTypeID);
        void RemoveContactType(params ContactType[] contactType);
        void UpdateContactType(params ContactType[] contactType);
    }
}