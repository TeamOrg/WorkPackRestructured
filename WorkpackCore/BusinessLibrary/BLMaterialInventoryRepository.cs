using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMaterialInventoryRepository : IBLMaterialInventoryRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MaterialInventory> _MaterialInventory;

        public BLMaterialInventoryRepository(WorkpackDBContext context, IGenericDataRepository<MaterialInventory> MaterialInventory)
        {
            _context = context;
            _MaterialInventory = MaterialInventory;
        }

        public MaterialInventory GetMaterialInventoryID(int Id)
        {
            return _MaterialInventory.GetSingle(d => d.MaterialInventoryID == Id);
        }
        public void AddMaterialInventory(params MaterialInventory[] MaterialInventory)
        {
            try
            {
                _MaterialInventory.Add(MaterialInventory);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateMaterialInventory(params MaterialInventory[] MaterialInventory)
        {
            try
            {
                _MaterialInventory.Update(MaterialInventory);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveMaterialInventory(params MaterialInventory[] MaterialInventory)
        {
            try
            {
                _MaterialInventory.Remove(MaterialInventory);
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
