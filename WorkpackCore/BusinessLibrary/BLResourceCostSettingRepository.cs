using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLResourceCostSettingRepository : IBLResourceCostSettingRepository
    {
        
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ResourceCostSetting> _resourcecost;

        public BLResourceCostSettingRepository(WorkpackDBContext context, IGenericDataRepository<ResourceCostSetting> resourcecost)
        {
            _context = context;
            _resourcecost = resourcecost;
        }


        public IList<ResourceCostSetting> GetAllDetails()
        {
            return _resourcecost.GetAll();
        }
        public ResourceCostSetting GetSettingByID(Int32 SettingID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _resourcecost.GetSingle(d => d.ResourceCostSettingID == SettingID);                
                //include related employees
        }
        public void AddCostSetting(params ResourceCostSetting[] resourcecost)
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
        public void UpdateCostSetting(params ResourceCostSetting[] resourcecost)
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
        public void RemoveCostSetting(ResourceCostSetting[] resourcecost)
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

        public List<ResourceCostSetting> GetRecordCountByCategoryMappingID(int category, int clientMapID)
        {
            List<ResourceCostSetting> res = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = context.ResourceCostSettings.Where(c => c.ContractMappingID == clientMapID && c.ResourceCategoryID == category).ToList<ResourceCostSetting>(); 
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }
    }
}
