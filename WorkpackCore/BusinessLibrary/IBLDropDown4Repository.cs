using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDropDown4Repository
    {
        void AddDropDown4(params Dropdown4[] Dropdown4);
        Dropdown4 GetDropDown4ByID(int Id);
        void RemoveDropDown4(params Dropdown4[] Dropdown4);
        void UpdateDropDown4(params Dropdown4[] Dropdown4);
    }
}