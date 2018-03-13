using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLSelfApprovalCommentRepository
    {
        void AddSelfApprovalComment(params SelfApprovalComment[] SelfApprovalComment);
        List<SelfApprovalComment> GetSelfApprovalCommentByFileID(int Id);
        SelfApprovalComment GetSelfApprovalCommentID(int Id);
        void RemoveSelfApprovalComment(params SelfApprovalComment[] SelfApprovalComment);
        void UpdateSelfApprovalComment(params SelfApprovalComment[] SelfApprovalComment);
    }
}