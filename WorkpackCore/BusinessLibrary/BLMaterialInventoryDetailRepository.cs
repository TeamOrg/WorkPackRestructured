using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMaterialInventoryDetailRepository : IBLMaterialInventoryDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MaterialInventoryDetail> _MaterialInventoryDetail;

        public BLMaterialInventoryDetailRepository(WorkpackDBContext context, IGenericDataRepository<MaterialInventoryDetail> MaterialInventoryDetail)
        {
            _context = context;
            _MaterialInventoryDetail = MaterialInventoryDetail;
        }
        public MaterialInventoryDetail GetMaterialInventoryDetailID(int Id)
        {
            return _MaterialInventoryDetail.GetSingle(d => d.MaterialInventoryDetailID == Id);
        }
        
        public void AddMaterialInventoryDetail(params MaterialInventoryDetail[] MaterialInventoryDetail)
        {
            try
            {
                _MaterialInventoryDetail.Add(MaterialInventoryDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateMaterialInventoryDetail(params MaterialInventoryDetail[] MaterialInventoryDetail)
        {
            try
            {
                _MaterialInventoryDetail.Update(MaterialInventoryDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveMaterialInventoryDetail(params MaterialInventoryDetail[] MaterialInventoryDetail)
        {
            try
            {
                _MaterialInventoryDetail.Remove(MaterialInventoryDetail);
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
        public MaterialInventoryDetail GetMaterialInventoryDetailByMaterialItemID(int Id, int MatInvID)
        {
            return _MaterialInventoryDetail.GetAll().Where(d => d.MaterialItemsID == Id && d.MaterialInventoryID == MatInvID).FirstOrDefault();
        }


    }
}
