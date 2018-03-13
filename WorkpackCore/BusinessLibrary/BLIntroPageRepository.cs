using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLIntroPageRepository : IBLIntroPageRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<IntroPage> _IntroPage;

        public BLIntroPageRepository(WorkpackDBContext context, IGenericDataRepository<IntroPage> IntroPage)
        {
            _context = context;
            _IntroPage = IntroPage;
        }
        public IList<IntroPage> GetAllIntroPage()
        {
            return _IntroPage.GetAll();
        }
        public IntroPage GetIntroPageByID(int IntroPageID)
        {
            return _IntroPage.GetSingle(d => d.IntroPageID == IntroPageID);
        }
        public void AddIntroPage(params IntroPage[] IntroPage)
        {
            try
            {
                _IntroPage.Add(IntroPage);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateIntroPage(params IntroPage[] IntroPage)
        {
            try
            {
                _IntroPage.Update(IntroPage);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveIntroPageDesignation(params IntroPage[] IntroPage)
        {
            try
            {
                _IntroPage.Remove(IntroPage);
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
        public List<IntroPage> GetIntroPageByUserIDAndPage(string UserID,string PageName)
        {
            List<IntroPage> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.IntroPages.Where(a => a.UserID == UserID && a.PageName.StartsWith(PageName) && a.PageName.EndsWith(PageName) && a.PageName.ToUpper() == PageName.ToUpper()).ToList<IntroPage>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }


    }
}
