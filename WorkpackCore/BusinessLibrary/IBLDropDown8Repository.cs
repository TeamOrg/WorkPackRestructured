using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDropDown8Repository
    {
        void AddDropDown8(params Dropdown8[] Dropdown8);
        Dropdown8 GetDropDown8ByID(int Id);
        void RemoveDropDown8(params Dropdown8[] Dropdown8);
        void UpdateDropDown8(params Dropdown8[] Dropdown8);
    }
}