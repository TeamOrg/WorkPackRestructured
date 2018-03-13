using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLPageCommentHistoryRepository
    {
        void AddPageCommentHistory(params PageCommentHistory[] PageCommentHistory);
        IList<PageCommentHistory> GetAllCommentHistory();
        List<PageCommentHistory> GetAllPageCommentHistoryByCommentDetailID(int CommentDetailID);
        PageCommentHistory GetCommentHistoryByID(int HistoryId);
        string GetCommentStatusByID(int statusid);
        PageCommentHistory GetsinglePageCommentHistoryByCommentDetailID(int DetailID);
        void RemovePageCommentHistory(params PageCommentHistory[] PageCommentHistory);
        void UpdatePageCommentHistory(params PageCommentHistory[] PageCommentHistory);
    }
}