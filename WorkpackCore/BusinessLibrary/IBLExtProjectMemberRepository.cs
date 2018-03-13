using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLExtProjectMemberRepository
    {
        void AddExtProjectsMember(params ExtProjectsMember[] ProjectsMember);
        List<User> GetExternalMember(int projectID, bool hasjoinedfilter = false);
        bool IsExtProjectMember(int projectID, int UserID);
        bool IsExtProjectMemberJoined(int projectID, int UserID);
        void RemoveProjectsMemberByProjectID(int ProjectID);
        void UpdateExtProjectsMember(params ExtProjectsMember[] ProjectsMember);
    }
}