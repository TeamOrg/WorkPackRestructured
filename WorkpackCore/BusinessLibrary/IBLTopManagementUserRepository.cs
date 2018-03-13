using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTopManagementUserRepository
    {
        void AddTopManagementUsers(params TopManagementUser[] TopManagementUsers);
        IList<TopManagementUser> GetAllTopManagementUsers();
        void RemoveTopManagementUsers(params TopManagementUser[] TopManagementUsers);
        void RemoveTopManagemnt();
        void UpdateTopManagementUsers(params TopManagementUser[] TopManagementUsers);
    }
}