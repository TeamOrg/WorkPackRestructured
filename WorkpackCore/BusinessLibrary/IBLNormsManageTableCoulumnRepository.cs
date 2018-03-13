using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNormsManageTableCoulumnRepository
    {
        void AddNormsManageTableCoulumn(params NormsManageTableColumn[] NormsManageTableColumn);
        NormsManageTableColumn GetNormsManageTableCoulumnByID(int Id);
        void RemoveNormsManageTableCoulumn(params NormsManageTableColumn[] NormsManageTableColumn);
        void UpdateNormsManageTableCoulumn(params NormsManageTableColumn[] NormsManageTableColumn);
    }
}