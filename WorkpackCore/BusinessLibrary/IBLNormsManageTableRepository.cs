using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNormsManageTableRepository
    {
        void AddNormsManageTable(params NormsManageTable[] NormsManageTable);
        NormsManageTable GetNormsManageTableID(int Id);
        void RemoveNormsManageTable(params NormsManageTable[] NormsManageTable);
        void UpdateNormsManageTable(params NormsManageTable[] NormsManageTable);
    }
}