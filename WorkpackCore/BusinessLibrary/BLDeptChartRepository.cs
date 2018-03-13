using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDeptChartRepository : IBLDeptChartRepository
    {
        public usp_GetDeptResourceLoadingChart_Result GetWeeklyData(DateTime Fdate, DateTime Tdate, string UserList,int EstimationID,int AwaitedID)
        {
            usp_GetDeptResourceLoadingChart_Result Record = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    Record = context.usp_GetDeptResourceLoadingChart(UserList,Fdate, Tdate, EstimationID, AwaitedID).Single();
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
            return Record;
        }
        public usp_GetDeptResourceForecostLoadingChart_Result GetWeeklyDataForecast(DateTime Fdate, DateTime Tdate, string UserList, int EstimationID, int AwaitedID)
        {
            usp_GetDeptResourceForecostLoadingChart_Result Record = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    Record = context.usp_GetDeptResourceForecostLoadingChart(UserList, Fdate, Tdate, EstimationID, AwaitedID).Single();
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
            return Record;
        }
        public Boolean SaveDel(string FlagId, string[] UserList)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var Context = new Cubicle_EntityEntities())
            //        {
            //            foreach (var a in Context.TempDeptLists.Where(p => p.FlagId == FlagId))
            //            {
            //                Context.TempDeptLists.Remove(a);
            //            }
            //            Context.SaveChanges();
            //            foreach (var val in UserList)
            //            {
            //                TempDeptList obj = new TempDeptList { FlagId=FlagId,UserList=val };
            //                Context.TempDeptLists.Add(obj);
            //            }
            //            Context.SaveChanges();
            //        }
            //        ts.Complete();
            //        res = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        res = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return res;
        }     
        public IList<usp_getUserList_Result> GetUsersByDept(Int32 DeptID,Int32 CompanyID)
        {
            IList<usp_getUserList_Result> UList = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    UList = context.usp_getUserList(0, 0, 0).ToList<usp_getUserList_Result>().Where(p => p.DepartmentID == DeptID && p.CompanyId == CompanyID && p.Status == "A").ToList();
                //    if (UList.Count == 0 && DeptID != 0)
                //        UList = context.usp_getUserList(0,0,0).ToList<usp_getUserList_Result>().Where(p => p.Status == "A" && p.CompanyId==CompanyID).OrderBy(p => new { p.FirstName, p.MiddleName, p.LastName }).ToList();
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
            return UList;
        }
        public IList<usp_getUserList_Result> GetDeptUserList(string flagId)
        {
            IList<usp_getUserList_Result> UList = null;
            try
            {
                UList = new List<usp_getUserList_Result>();
                //using (var context = new Cubicle_EntityEntities())
                //{                    
                //    foreach (var a in context.TempDeptLists.Where(p => p.FlagId == flagId))
                //    {
                //        int id = Convert.ToInt32(a.UserList == string.Empty ? "0" : a.UserList);
                //        usp_getUserList_Result user = context.usp_getUserList(0,0,0).ToList<usp_getUserList_Result>().FirstOrDefault(p => p.UserID == id);
                //        if(user!=null)
                //            UList.Add(user);
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
            return UList;
        }      
    }
}
