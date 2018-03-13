using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDropDown10Repository
    {
        void AddDropDown10(params Dropdown10[] Dropdown10);
        Dropdown10 GetDropDown10ByID(int Id);
        void RemoveDropDown10(params Dropdown10[] Dropdown10);
        void UpdateDropDown10(params Dropdown10[] Dropdown10);
    }
}