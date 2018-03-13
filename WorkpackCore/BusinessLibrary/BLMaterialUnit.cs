using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMaterialUnit : IBLMaterialUnit
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MaterialUnit> _MaterialUnit;

        public BLMaterialUnit(WorkpackDBContext context, IGenericDataRepository<MaterialUnit> MaterialUnit)
        {
            _context = context;
            _MaterialUnit = MaterialUnit;
        }

        public MaterialUnit GetMaterialUnitBYID(int Id)
        {
            return _MaterialUnit.GetSingle(d => d.UnitID == Id);
        }
        public void AddMaterialUnit(params MaterialUnit[] MaterialUnit)
        {
            try
            {
                _MaterialUnit.Add(MaterialUnit);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateMaterialUnit(params MaterialUnit[] MaterialUnit)
        {
            try
            {
                _MaterialUnit.Update(MaterialUnit);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveMaterialUnit(params MaterialUnit[] MaterialUnit)
        {
            try
            {
                _MaterialUnit.Remove(MaterialUnit);
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

