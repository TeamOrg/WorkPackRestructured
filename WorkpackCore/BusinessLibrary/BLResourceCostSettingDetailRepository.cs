using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLResourceCostSettingDetailRepository : IBLResourceCostSettingDetailRepository
    {


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ResourceCostSettingDetail> _resourcecost;

        public BLResourceCostSettingDetailRepository(WorkpackDBContext context, IGenericDataRepository<ResourceCostSettingDetail> resourcecost)
        {
            _context = context;
            _resourcecost = resourcecost;
        }










        public IList<ResourceCostSettingDetail> GetAllDetails()
        {
            return _resourcecost.GetAll();
        }
        public ResourceCostSettingDetail GetSettingDetailByID(Int32 SettingID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _resourcecost.GetSingle(d => d.ResourceCostSettingID == SettingID);                
                //include related employees
        }
        public void AddCostSettingDetails(params ResourceCostSettingDetail[] resourcecost)
        {
            /* Validation and error handling omitted */
            try
            {
                _resourcecost.Add(resourcecost);
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
        public void UpdateCostSettingDetails(params ResourceCostSettingDetail[] resourcecost)
        {
            /* Validation and error handling omitted */
            try
            {
                _resourcecost.Update(resourcecost);
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
        public List<object> GetAllCategories()
        {
            List<object> category = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    category = (from d in db.ResourceCategories select d).ToList<object>();
            //}
            return category;
        }
        public void RemoveCostSettingDetails(ResourceCostSettingDetail[] resourcecost)
        {
            /* Validation and error handling omitted */
            try
            {
                _resourcecost.Remove(resourcecost);
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
        public List<ResourceCostSettingDetail> GetAllDetailsByDeptDesgSettingID(int deptID,int desgID,int CostsettingID)
        {
            List<ResourceCostSettingDetail> res = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = context.ResourceCostSettingDetails.Where(c => c.ResourceCostSettingID == CostsettingID && c.DepartmentID == deptID && c.DesignationID == desgID).ToList<ResourceCostSettingDetail>();
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }
        //public static IList<usp_GetCommentsByResourceRequestID_Result> GetComments(Int32 ID)GetAllDetailsByDeptDesgSettingID
        //{
        //    IList<usp_GetCommentsByResourceRequestID_Result> list = null;
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            list = context.usp_GetCommentsByResourceRequestID(ID).ToList<usp_GetCommentsByResourceRequestID_Result>();
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
        //public IList<Comment> GetCommentRecordsOnly(Int32 ID)
        //{
        //    return _commentRepository.GetList(p => p.ID == ID);
        //}

        public IList<ResourceCostSettingDetail> GetAllDetailsByClientCategory(int ClientID, int category)
        {
            IList<ResourceCostSettingDetail> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = (from d in context.ResourceCostSettingDetails
                //            join m in context.ResourceCostSettings on d.ResourceCostSettingID equals m.ResourceCostSettingID
                //            join cm in context.ClientContracts on m.ContractMappingID equals cm.ContractMappingID
                //            where cm.ContractMappingID == ClientID && m.ResourceCategoryID == category
                //            select d).ToList<ResourceCostSettingDetail>();
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
