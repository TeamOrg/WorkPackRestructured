using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLDropDown6Repository
    {
        void AddDropDown6(params Dropdown6[] Dropdown6);
        Dropdown6 GetDropDown6ByID(int Id);
        void RemoveDropDown6(params Dropdown6[] Dropdown6);
        void UpdateDropDown6(params Dropdown6[] Dropdown6);
    }
}