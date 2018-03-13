using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLPageDetailRepository : IBLPageDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<PageDetail> _pageDetailRepository;

        public BLPageDetailRepository(WorkpackDBContext context, IGenericDataRepository<PageDetail> pageDetailRepository)
        {
            _context = context;
            _pageDetailRepository = pageDetailRepository;
        }

        public IList<PageDetail> GetAllRoleRights()
        {
            return _pageDetailRepository.GetAll();
        }
        public PageDetail GetPageDetailByID(Int32 PageDetailID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _pageDetailRepository.GetSingle(d => d.PageDetailID == PageDetailID);
            //include related employees
        }
        public void AddPageDetail(params PageDetail[] pageDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _pageDetailRepository.Add(pageDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdatepageDetail(params PageDetail[] pageDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _pageDetailRepository.Update(pageDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemovepageDetail(params PageDetail[] pageDetail)
        {
            /* Validation and error handling omitted */
            _pageDetailRepository.Remove(pageDetail);
        }
        public IList<PageDetail> GetPageDetails(int FileID)
        {
            IList<PageDetail> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.PageDetails.Include("PageLineDetails").Include("PageCircleDetails").Include("PageRecDetails").Include("PageCommentDetails").Include("PageTextDetails").Include("PageClouds").Include("PageClouds.PageCloudDetails").Where(p => p.FileID == FileID).ToList<PageDetail>();
                //}
            }

            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);

            }
            return list;
        }
        public PageDetail GetPageDetailsByIndex(int FileID, int PageID)
        {
            PageDetail list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.PageDetails.Where(p => p.FileID == FileID && p.PageIndex == PageID).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);

            }
            return list;
        }

        public PageDetail GetPageDetailsByFileId(int FileID)
        {
            PageDetail list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.PageDetails.Where(p => p.FileID == FileID).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);

            }
            return list;
        }

        public PageDetail GetPageDetailsByIndexWithInclude(int FileID, int PageID)
        {
            PageDetail list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                
                //    list = (from q in db.PageDetails.Include("PageCommentDetails").Include("PageLineDetails").Include("PageCircleDetails").Include("PageRecDetails").Include("PageTextDetails").Include("PageClouds") where q.FileID == FileID && q.PageIndex == PageID select q).SingleOrDefault();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);

            }
            return list;
        }

        public Boolean SavePageDetail(params PageDetail[] page)
        {
            Boolean res = false;
            try
            {
                AddPageDetail(page);
                res = true;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);

            }
            return res;
        }
    }
}
