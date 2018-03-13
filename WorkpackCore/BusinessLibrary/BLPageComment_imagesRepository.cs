using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLPageComment_imagesRepository : IBLPageComment_imagesRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<PageComment_images> _PageComment_imagesRepository;

        public BLPageComment_imagesRepository(WorkpackDBContext context, IGenericDataRepository<PageComment_images> PageComment_imagesRepository)
        {
            _context = context;
            _PageComment_imagesRepository = PageComment_imagesRepository;
        }
        public IList<PageComment_images> GetAllPageComment_imagess()
        {
            return _PageComment_imagesRepository.GetAll().ToList();
        }
        public PageComment_images GetPageComment_imagesByID(Int32 PageComment_imagesID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _PageComment_imagesRepository.GetSingle(d => d.Fileid == PageComment_imagesID);                
                //include related employees
        }



        public int GetPageComment_imagesByName(string PageComment_imagesName)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties

            int tid =0;
            //using (var context = new Cubicle_EntityEntities())

            //{
            //     tid = (from b in context.PageComment_images
            //            where b.FileName.ToUpper() == PageComment_imagesName.ToUpper() 
            //              select b).ToList<PageComment_images>().FirstOrDefault().Fileid;
           
            //}


            return tid;

            //include related employees
        }
      

        public void AddPageComment_images(params PageComment_images[] PageComment_images)
        {
            /* Validation and error handling omitted */
            try
            {
                _PageComment_imagesRepository.Add(PageComment_images);
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
        public void UpdatePageComment_images(params PageComment_images[] PageComment_images)
        {
            /* Validation and error handling omitted */
            try
            {
                _PageComment_imagesRepository.Update(PageComment_images);
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
        public void RemovePageComment_images(params PageComment_images[] PageComment_images)
        {
            /* Validation and error handling omitted */
            try
            {
                _PageComment_imagesRepository.Remove(PageComment_images);
            }
            catch (Exception ex)
            {
                throw ex;              
            }
        }

        public IList<PageComment_images> GetPageComment_imagesbycommentdetailsid (int commentdetailsid)
        {
            IList<PageComment_images> list = null;
            /* Validation and error handling omitted */
            try
            {
                //using (var context = new Cubicle_EntityEntities()) {

                //    list = context.PageComment_images.Where(a => a.PageCommentDetailID == commentdetailsid).ToList();
                
                //} 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }


        public Boolean CheckDuplicate(PageComment_images PageComment_images, Boolean IsInsert)
        {
            Boolean Result = true;
            int companyID = 0;
            //companyID = Convert.ToInt16(HttpContext.Current.Session["CompanyId"]);
            //Convert.ToInt32(Session["CompanyId"])
            try
            {
                var c = _PageComment_imagesRepository.GetSingle(p => p.FileName.ToUpper() == PageComment_images.FileName.ToUpper() && p.PageCommentDetailID == PageComment_images.PageCommentDetailID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.PageCommentDetailID == PageComment_images.PageCommentDetailID)
                        Result = true;
                    else
                        Result = false;
                }
                else
                {
                    if (c == null)
                        Result = true;
                    else
                        Result = false;
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return Result;
        }
    }
}
