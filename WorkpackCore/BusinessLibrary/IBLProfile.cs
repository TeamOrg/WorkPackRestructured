using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProfile
    {
        void AddProfile(params CompanyProfile[] attachmentFile);
        CompanyProfile GetByProfileID(int ProfileId);
        IList<CompanyProfile> GetProfile();
        List<CompanyProfile> GetProfileByFileID(int DelFileID);
        int GetProfileIDByCode(string ProfileCode);
        void RemoveProfile(params CompanyProfile[] attachmentFile);
        void UpdateProfile(params CompanyProfile[] attachmentFile);
    }
}