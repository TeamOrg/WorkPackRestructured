using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLIntroPageRepository
    {
        void AddIntroPage(params IntroPage[] IntroPage);
        IList<IntroPage> GetAllIntroPage();
        IntroPage GetIntroPageByID(int IntroPageID);
        List<IntroPage> GetIntroPageByUserIDAndPage(string UserID, string PageName);
        void RemoveIntroPageDesignation(params IntroPage[] IntroPage);
        void UpdateIntroPage(params IntroPage[] IntroPage);
    }
}