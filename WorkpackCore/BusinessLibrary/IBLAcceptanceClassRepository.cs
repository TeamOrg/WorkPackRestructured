using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLAcceptanceClassRepository
    {
        void AddAcceptanceClass(params AcceptanceClass[] acceptanceclass);
        bool CheckDuplicate(AcceptanceClass acceptanceclass, bool IsInsert);
        AcceptanceClass GetAcceptanceClassByID(int acceptanceclassID);
        AcceptanceClass GetAcceptanceClassByID(int acceptanceclassID, bool flag);
        IList<AcceptanceClass> GetAcceptanceClassList(AcceptanceClass acceptanceclass);
        IList<AcceptanceClass> GetAllAcceptanceClasses();
        void RemoveAcceptanceClass(params AcceptanceClass[] acceptanceclass);
        void UpdateAcceptanceClass(params AcceptanceClass[] acceptanceclass);
    }
}