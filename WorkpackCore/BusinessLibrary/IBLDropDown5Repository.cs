using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDropDown5Repository
    {
        void AddDropDown5(params Dropdown5[] Dropdown5);
        Dropdown5 GetDropDown5ByID(int Id);
        void RemoveDropDown5(params Dropdown5[] Dropdown5);
        void UpdateDropDown5(params Dropdown5[] Dropdown5);
    }
}