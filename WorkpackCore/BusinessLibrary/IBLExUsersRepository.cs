using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLExUsersRepository
    {
        void AddExUsers(params ExUsers[] ExUsers);
        IList<ExUsers> GetAllExUsers(int companyId);
        ExUsers GetExUsersByID(int ExUsersID);
        void RemoveExUsers(params ExUsers[] ExUsers);
        void UpdateExUsers(params ExUsers[] ExUsers);
    }
}