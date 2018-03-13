using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLUserCommentRepository
    {
        void AddUserComment(params UserComment[] userComment);
        bool AddUserCommentList(List<Int_ListItem> commentIDList, int UserID);
        IList<UserComment> GetAllUserComments();
        UserComment GetCommentListByCommentID_UserID(int CommentID, int UserID);
        UserComment GetUserCommentByID(int UserCommentID);
        void RemoveUserComment(params UserComment[] userComment);
        void UpdateUserComment(params UserComment[] userComment);
    }
}