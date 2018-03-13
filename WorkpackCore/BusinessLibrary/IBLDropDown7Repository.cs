using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDropDown7Repository
    {
        void AddDropDown7(params Dropdown7[] Dropdown7);
        Dropdown7 GetDropDown7ByID(int Id);
        void RemoveDropDown7(params Dropdown7[] Dropdown7);
        void UpdateDropDown7(params Dropdown7[] Dropdown7);
    }
}