using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLUserProjectListRepository : IBLUserProjectListRepository
    {



        public  IList<Project> GetProjectNameandCode()
        {
            IList<Project> list = null;
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{
                ////    list = (from a in db.Projects select a).ToList();
                ////}
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
       
        public  IList<User> GetProjectUser(Int32 ProjectID)
        {
            IList<User> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from t in db.ProjectTaskLists join u in db.Users on t.TaskOwner equals u.UserID where t.ProjectID == ProjectID select u).ToList();
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

        public  IList<Project> getUserProject(int UserID)
        {
            IList<Project> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from ra in db.ResourceAllocations
                //            join rr in db.ResourceRequests on ra.ResourceRequestID equals rr.ResourceRequestID
                //            join p in db.Projects on rr.ProjectID equals p.ProjectID
                //            where ra.UserID == 2
                //            select p).Distinct().ToList();
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
        public  IList<usp_getUserMenu_Result> getUserMenu(int userID,string DisableManHours)
        {
            IList<usp_getUserMenu_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getUserMenu(userID, DisableManHours).ToList<usp_getUserMenu_Result>();
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
        public  IList<usp_Menubreadcrumb_Result> getMenubreadcrumb(int ModuleID)
        {
            IList<usp_Menubreadcrumb_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_Menubreadcrumb(ModuleID).ToList<usp_Menubreadcrumb_Result>();
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

        public  List<int> getSuperVisionCount(int userID)
        {
            List<int> res = new List<int>();
            List<usp_getApproveTimeSheetProgressSheetCount_Result> lstcounts = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstcounts = db.usp_getApproveTimeSheetProgressSheetCount(userID).ToList <usp_getApproveTimeSheetProgressSheetCount_Result>();
                //    if (lstcounts.Count > 0)
                //    {
                //        res.Add(Convert.ToInt32(lstcounts.SingleOrDefault().TimeSheetCount));
                //        res.Add(Convert.ToInt32(lstcounts.SingleOrDefault().ProgressSheetCount));
                //        res.Add(Convert.ToInt32(lstcounts.SingleOrDefault().Total));
                //    }
                
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
            return res;
        }
    }
}
