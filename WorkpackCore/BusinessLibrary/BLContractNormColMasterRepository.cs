using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLContractNormColMasterRepository : IBLContractNormColMasterRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ContractNormColMaster> _contractNormColMaster;

        public BLContractNormColMasterRepository(WorkpackDBContext context, IGenericDataRepository<ContractNormColMaster> contractNormColMaster)
        {
            _context = context;
            _contractNormColMaster = contractNormColMaster;
        }


        public IList<ContractNormColMaster> GetAllContractNormColMaster()
        {
            return _contractNormColMaster.GetAll();
        }
        public ContractNormColMaster GetContractNormColMasterByID(Int32 ContractNormColMasterID)
        {
            return _contractNormColMaster.GetSingle(d => d.ContractNormsColumnID == ContractNormColMasterID);
        }
        public void AddContractNormColMaster(params ContractNormColMaster[] ContractNormColMaster)
        {
            try
            {
                _contractNormColMaster.Add(ContractNormColMaster);
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
        public void RearrangeContractNormsColumnMaster(int NormSetID,int DisplayOrder)
        {
            try
            {
                //List<ContractNormColMaster> lst = null;
                //BLContractNormColMasterRepository blcontract = new BLContractNormColMasterRepository();

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    //int DisplayOrder = (from t in context.NormsColumnsMasters
                //    //                    where t.NormsColumnID == NormsColumnID
                //    //                    select t.DisplayOrder).FirstOrDefault();
                //    //DisplayOrder = DisplayOrder == null ? 0 : DisplayOrder;
                //    lst = context.ContractNormColMasters.Where(c => c.DisplayOrder > DisplayOrder && c.CompanyNormSetID == NormSetID).ToList<ContractNormColMaster>();
                //    if (lst.Count > 0)
                //    {
                //        List<ContractNormColMaster> listarr = new List<ContractNormColMaster>();
                //        foreach (var item in lst)
                //        {
                //            item.DisplayOrder = Convert.ToInt32(item.DisplayOrder) - 1;
                //            item.EntityState = DominModel.EntityState.Modified;
                //        }

                //        _contractNormColMaster.Update(lst.ToArray());                       
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public void UpdateContractNormColMaster(params ContractNormColMaster[] ContractNormColMaster)
        {
            try
            {
                _contractNormColMaster.Update(ContractNormColMaster);
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
        public void RemoveContractNormColMaster(params ContractNormColMaster[] ContractNormColMaster)
        {
            try
            {
                _contractNormColMaster.Remove(ContractNormColMaster);
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
       
    }
}
