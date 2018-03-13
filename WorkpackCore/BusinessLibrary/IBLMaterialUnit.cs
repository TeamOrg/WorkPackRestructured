using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMaterialUnit
    {
        void AddMaterialUnit(params MaterialUnit[] MaterialUnit);
        MaterialUnit GetMaterialUnitBYID(int Id);
        void RemoveMaterialUnit(params MaterialUnit[] MaterialUnit);
        void UpdateMaterialUnit(params MaterialUnit[] MaterialUnit);
    }
}