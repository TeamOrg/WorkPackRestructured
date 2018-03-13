using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDropDown9Repository
    {
        void AddDropDown9(params Dropdown9[] Dropdown9);
        Dropdown9 GetDropDown9ByID(int Id);
        void RemoveDropDown9(params Dropdown9[] Dropdown9);
        void UpdateDropDown9(params Dropdown9[] Dropdown9);
    }
}