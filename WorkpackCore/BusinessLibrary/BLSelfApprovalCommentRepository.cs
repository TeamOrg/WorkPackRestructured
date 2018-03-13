using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLSelfApprovalCommentRepository : IBLSelfApprovalCommentRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<SelfApprovalComment> _selfApprovalComment;

        public BLSelfApprovalCommentRepository(WorkpackDBContext context, IGenericDataRepository<SelfApprovalComment> selfApprovalComment)
        {
            _context = context;
            _selfApprovalComment = selfApprovalComment;
        }







        public SelfApprovalComment GetSelfApprovalCommentID(int Id)
        {
            return _selfApprovalComment.GetSingle(d => d.CommentID == Id);
        }

        public List<SelfApprovalComment> GetSelfApprovalCommentByFileID(int Id)
        {
            return _selfApprovalComment.GetAll().Where(d => d.UploadDeliverableFileID == Id).ToList();
        }
       
        public void AddSelfApprovalComment(params SelfApprovalComment[] SelfApprovalComment)
        {
            try
            {
                _selfApprovalComment.Add(SelfApprovalComment);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateSelfApprovalComment(params SelfApprovalComment[] SelfApprovalComment)
        {
            try
            {
                _selfApprovalComment.Update(SelfApprovalComment);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveSelfApprovalComment(params SelfApprovalComment[] SelfApprovalComment)
        {
            try
            {
                _selfApprovalComment.Remove(SelfApprovalComment);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }


    }
}
