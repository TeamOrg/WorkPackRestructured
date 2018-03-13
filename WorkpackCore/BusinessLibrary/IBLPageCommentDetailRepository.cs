using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLPageCommentDetailRepository
    {
        void AddPageCommentDetail(params PageCommentDetail[] pageCommentDetail);
        bool deletecommentfrompdfjs(int commentdetailsid);
        IList<PageCommentDetail> GetAllPageCommentDetail();
        void GetDeliverableDetails(int FileID, out string ProjectInfo, out string DeliverableInfo, out string DeliverableID);
        List<PageCommentDetail> getPageCommentByFileIdAndUserId(int FileID, string UserID);
        IList<usp_GetPageCommentDetails_Result> GetPageCommentDetail(int fileID, int OwnerID);
        PageCommentDetail GetPageCommentDetailByID(int PageCommentDetailID);
        PageCommentDetail GetPageCommentDetailByID(long commentclientid);
        IList<usp_GetPageCommentDetailsForApprov_Result> GetPageCommentDetailForApprove(int FileID, string UserID);
        int getUnapprovedCommentCount(int FileID);
        bool isAllCommentsResponsedByOwner(int FileID, string checkerID);
        List<string> isAnyResponsePresentAgainstCommentsByUserCheckerID(int FileID);
        void RemovePageCommentDetail(params PageCommentDetail[] pageCommentDetail);
        void UpdatePageCommentDetail(params PageCommentDetail[] pageCommentDetail);
    }
}