using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLCommentRepository
    {
        void AddComment(params Comment[] comment);
        //string GenerateTabsMenu(List<usp_getAllRevisionByProjectID_Result> list, int FileID, int DeliverableID, Label lbl, string status);
        List<Comment> GetAllCommentByTaskID(int TaskID);
        IList<Comment> GetAllComments();
        Comment GetCommentByID(int commentID);
        IList<Comment> GetCommentRecordsOnly(int ID);
        void RemoveComment(params Comment[] comment);
        void UpdateComment(params Comment[] comment);
    }
}