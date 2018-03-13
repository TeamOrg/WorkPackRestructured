using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLPageDetailRepository
    {
        void AddPageDetail(params PageDetail[] pageDetail);
        IList<PageDetail> GetAllRoleRights();
        PageDetail GetPageDetailByID(int PageDetailID);
        IList<PageDetail> GetPageDetails(int FileID);
        PageDetail GetPageDetailsByFileId(int FileID);
        PageDetail GetPageDetailsByIndex(int FileID, int PageID);
        PageDetail GetPageDetailsByIndexWithInclude(int FileID, int PageID);
        void RemovepageDetail(params PageDetail[] pageDetail);
        bool SavePageDetail(params PageDetail[] page);
        void UpdatepageDetail(params PageDetail[] pageDetail);
    }
}