using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLPriorityRepository
    {
        void AddPriority(params Priority[] priority);
        bool CheckDuplicate(Priority priority, bool IsInsert);
        bool CheckDuplicateRank(Priority priority, bool IsInsert);
        IList<Priority> GetAllPrioritys();
        Priority getDefaultPriority();
        string GetDefaultPriority(string projectName, int PriorityID);
        Priority GetPriorityByID(int priorityID);
        IList<Priority> GetPriorityList(Priority priority);
        int priorityidByName(string prorityname);
        void RemovePriority(params Priority[] priority);
        void UpdatePriority(params Priority[] priority);
    }
}