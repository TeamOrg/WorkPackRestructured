using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLRoleRightRepository : IBLRoleRightRepository
    {
         


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<RoleRight> _roleRightRepository;

        public BLRoleRightRepository(WorkpackDBContext context, IGenericDataRepository<RoleRight> roleRightRepository)
        {
            _context = context;
            _roleRightRepository = roleRightRepository;
        }







        public IList<RoleRight> GetAllRoleRights()
        {
            return _roleRightRepository.GetAll();
        } 
        public RoleRight GetRoleRightByID(Int32 roleRightID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _roleRightRepository.GetSingle(d => d.RoleRightsID == roleRightID);                
                //include related employees
        }        
        public void AddRoleRight(params RoleRight[] roleRight)
        {
            /* Validation and error handling omitted */
            try
            {
                _roleRightRepository.Add(roleRight);
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
        public void UpdateRoleRight(params RoleRight[] roleRight)
        {
            /* Validation and error handling omitted */
            try
            {
                _roleRightRepository.Update(roleRight);
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
        public void RemoveRoleRight(params RoleRight[] roleRight)
        {
            /* Validation and error handling omitted */
            try
            {
                _roleRightRepository.Remove(roleRight);
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
        public Boolean GetMenuVisibility(string Page,int UserID)
        {
            Boolean IsAccess = false;
            int ModuleID = 0;
            ModuleID = BLMessageRepository.GetModuleIDByPage(Page);
            try
            {
                if (BLRoleRightRepository.GetRoleRightOnPage(ModuleID, UserID) == "")
                {
                    IsAccess = false;
                }
                else
                {
                    IsAccess = true;
                }
            }
            catch (Exception ex)
            { }


            return IsAccess;
        }

        public Boolean GetMenuVisibilityview(string Page, int UserID)
        {
            Boolean IsAccess = false;
            int ModuleID = 0;
            ModuleID = BLMessageRepository.GetModuleIDByPage(Page);
            try
            {
                if (BLRoleRightRepository.GetRoleRightOnPageasperview(ModuleID, UserID) == "")
                {
                    IsAccess = false;
                }
                else
                {
                    IsAccess = true;
                }
            }
            catch (Exception ex)
            { }


            return IsAccess;
        }

        public Boolean CheckDuplicate(RoleRight roleRight,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _roleRightRepository.GetSingle(p => p.RoleRightsID == roleRight.RoleRightsID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.RoleRightsID == roleRight.RoleRightsID)
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

        public List<usp_RoleRights_Result> GetRoleRightList(int RoleID, int ProfileID)
        {
            List<usp_RoleRights_Result> list = null;
            try
            {
                list = new List<usp_RoleRights_Result>();
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_RoleRights(RoleID, ProfileID).ToList<usp_RoleRights_Result>();
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
        //public List<usp_RoleRights_Result> GetRoleRightList(int RoleID)
        //{
        //    List<usp_RoleRights_Result> list=null;
        //    try
        //    {
        //        list = new List<usp_RoleRights_Result>();
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.usp_RoleRights(RoleID).ToList<usp_RoleRights_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}
        public Boolean SaveRoleRights(int RoleID, List<RoleRight> roleRight, string profileCode)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            // {

            try
            {
                List<RoleRight> lstNew = new List<RoleRight>();
                List<int> lstModuleID = new List<int>();
                List<RoleRight> lstR = GetAllRoleRights().Where(p => p.RoleID == RoleID).ToList<RoleRight>();

                foreach (var obj in roleRight)
                {
                    RoleRight r = (from q in lstR where q.RoleID == obj.RoleID && q.ModuleID == obj.ModuleID select q).FirstOrDefault();
                    if (r != null)
                    {
                        lstModuleID.Add(r.ModuleID);
                        if (profileCode == "FR")
                        {
                            r.ViewFreeAccess = obj.ViewFreeAccess;
                            r.EditFreeAccess = obj.EditFreeAccess;
                        }
                        else if (profileCode == "SL")
                        {
                            r.ViewSilverAccess = obj.ViewSilverAccess;
                            r.EditSilverAccess = obj.EditSilverAccess;
                        }
                        else if (profileCode == "GL")
                        {
                            r.ViewGoldAccess = obj.ViewGoldAccess;
                            r.EditGoldAccess = obj.EditGoldAccess;
                        }
                        else if (profileCode == "PL")
                        {
                            r.ViewPlatinumAccess = obj.ViewPlatinumAccess;
                            r.EditPlatinumAccess = obj.EditPlatinumAccess;
                        }
                        else if (profileCode == "URM")
                        {
                            r.EditURMAccess = obj.EditURMAccess;
                            r.ViewURMAccess = obj.ViewURMAccess;
                        }
                        else
                        {
                            r.ViewAccess = obj.ViewAccess;
                            r.EditAccess = obj.EditAccess;
                        }

                        r.EntityState = DomainModelLibrary.EntityState.Modified;
                        // UpdateRoleRight(r);
                        lstNew.Add(r);
                    }
                    else
                    {
                        obj.EntityState = DomainModelLibrary.EntityState.Added;
                        //AddRoleRight(obj);
                        lstNew.Add(obj);
                    }
                }

                List<RoleRight> lstremoved = lstR.Where(a => !lstModuleID.Contains(a.ModuleID)).ToList<RoleRight>();
                foreach (var r in lstremoved)
                {

                    if (profileCode == "FR")
                    {
                        r.ViewFreeAccess = 0;
                        r.EditFreeAccess = 0;
                    }
                    else if (profileCode == "SL")
                    {
                        r.ViewSilverAccess = 0;
                        r.EditSilverAccess = 0;
                    }
                    else if (profileCode == "GL")
                    {
                        r.ViewGoldAccess = 0;
                        r.EditGoldAccess = 0;
                    }
                    else if (profileCode == "PL")
                    {
                        r.ViewPlatinumAccess = 0;
                        r.EditPlatinumAccess = 0;
                    }
                    else if (profileCode == "URM")
                    {
                        r.ViewURMAccess = 0;
                        r.EditURMAccess = 0;
                    }
                    else
                    {
                        r.ViewAccess = 0;
                        r.EditAccess = 0;
                    }

                    r.EntityState = DomainModelLibrary.EntityState.Modified;
                    // UpdateRoleRight(r);
                    lstNew.Add(r);
                }

                // ts.Complete();
                AddRoleRight(lstNew.ToArray());

                res = true;
            }

            catch (Exception ex)
            {
                //    ts.Dispose();
                res = false;
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }

            return res;
            //}
        }

        //public static void AccessPermission(int ModuleID, System.Web.UI.Control btn,int UserID)
        //{
        //    List<usp_getAccessPermission_Result> lst = new List<usp_getAccessPermission_Result>();
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            lst = context.usp_getAccessPermission(ModuleID, UserID).ToList<usp_getAccessPermission_Result>();
        //            if (Convert.ToString(lst.SingleOrDefault().EditAccess) != "1")
        //            {
        //                btn.Visible = false;
        //            }
        //            else
        //            {
        //                btn.Visible = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //      //  bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
        //        throw ex;
        //    }
        //}


        public static bool AccessPermission(int ModuleID, int UserID)
        {
            List<usp_getAccessPermission_Result> lst = new List<usp_getAccessPermission_Result>();
            try
            {
                bool result = false;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_getAccessPermission(ModuleID, UserID).ToList<usp_getAccessPermission_Result>();
                //    if (Convert.ToString(lst.SingleOrDefault().EditAccess) != "1")
                //    {
                //        result = false;
                //    }
                //    else
                //    {
                //        result = true;
                //    }
                //}

                return result;
            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }
        }



   

        public static String GetRoleRightOnPage(int ModuleID, int UserID)
        {
            String i = "0";

            //0 for view permission for this module
            //1 Edit permission for this module
            // String.Empty  No acccess for this module
            List<usp_getAccessPermission_Result> lst = new List<usp_getAccessPermission_Result>();
            try
            {
               
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_getAccessPermission(ModuleID, UserID).ToList<usp_getAccessPermission_Result>();
                //    i=lst.SingleOrDefault().EditAccess.ToString();
                //    if (i.ToString() == "" || i.ToString() == "0")
                //    {
                //        i = "";
                //    }
                //}
                  
            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return i;

        }

        public static String GetRoleRightOnPageasperview(int ModuleID, int UserID)
        {
            String i = "0";

            //0 for view permission for this module
            //1 Edit permission for this module
            // String.Empty  No acccess for this module
            List<usp_getAccessPermission_Result> lst = new List<usp_getAccessPermission_Result>();
            try
            {

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_getAccessPermission(ModuleID, UserID).ToList<usp_getAccessPermission_Result>();
                //    i = lst.SingleOrDefault().ViewAccess.ToString();
                //    if (i.ToString() == "" || i.ToString() == "0")
                //    {
                //        i = "";
                //    }
                //}

            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return i;

        }

    }
}
