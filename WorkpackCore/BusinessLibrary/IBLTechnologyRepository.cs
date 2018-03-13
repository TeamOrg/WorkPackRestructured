using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTechnologyRepository
    {
        void AddTechnology(params Technology[] technology);
        bool CheckDuplicate(Technology technology, bool IsInsert);
        IList<Technology> GetAllTechnologys();
        Technology GetTechnologyByID(int technologyID);
        IList<Technology> GetTechnologyList(Technology technology);
        void RemoveTechnology(params Technology[] technology);
        void UpdateTechnology(params Technology[] technology);
    }
}