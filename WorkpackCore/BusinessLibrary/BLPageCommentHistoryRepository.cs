using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLPageCommentHistoryRepository : IBLPageCommentHistoryRepository
    {       
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<PageCommentHistory> _pagecommenthistory;

        public BLPageCommentHistoryRepository(WorkpackDBContext context, IGenericDataRepository<PageCommentHistory> pagecommenthistory)
        {
            _context = context;
            _pagecommenthistory = pagecommenthistory;
        }
        public IList<PageCommentHistory> GetAllCommentHistory()
        {
            return _pagecommenthistory.GetAll();
        }
        public PageCommentHistory GetCommentHistoryByID(int HistoryId)
        {
            return _pagecommenthistory.GetSingle(d => d.CommentHistoryID == HistoryId);
        }
        public void AddPageCommentHistory(params PageCommentHistory[] PageCommentHistory)
        {
            try
            {
                _pagecommenthistory.Add(PageCommentHistory);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdatePageCommentHistory(params PageCommentHistory[] PageCommentHistory)
        {
            try
            {
                _pagecommenthistory.Update(PageCommentHistory);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemovePageCommentHistory(params PageCommentHistory[] PageCommentHistory)
        {
            try
            {
                _pagecommenthistory.Remove(PageCommentHistory);
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
        public List<PageCommentHistory> GetAllPageCommentHistoryByCommentDetailID(int CommentDetailID)
        {
            List<PageCommentHistory> list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.PageCommentHistories.Where(c => c.PageCommentDetailID == CommentDetailID).ToList<PageCommentHistory>();
            //}
            return list;
        }
        public PageCommentHistory GetsinglePageCommentHistoryByCommentDetailID(int DetailID)
        {
            PageCommentHistory list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.PageCommentHistories.Where(c => c.PageCommentDetailID == DetailID).SingleOrDefault();
            //}
            return list;
        }
        public string GetCommentStatusByID(int statusid)
        {
            string status = "";
            switch (statusid)
            {
                case 1:
                    status= "Commented";break;
                case 2:
                    status= "Comment Resolution"; break;
                case 3:
                    status= "Response Sent"; break;
                case 4:
                    status= "Rejected"; break;
                case 5:
                    status= "Accepted"; break;
            }
            return status;
        }
    }
}
