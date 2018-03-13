using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLExUsersRepository
    {
        void AddExUsers(params ExUser[] ExUsers);
        IList<ExUser> GetAllExUsers();
        ExUser GetExUsersByID(int ExUsersID);
        void RemoveExUsers(params ExUser[] ExUsers);
        void UpdateExUsers(params ExUser[] ExUsers);
    }
}