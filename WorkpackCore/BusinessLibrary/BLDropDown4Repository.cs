using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDropDown4Repository : IBLDropDown4Repository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Dropdown4> _dropdown4;

        public BLDropDown4Repository(WorkpackDBContext context, IGenericDataRepository<Dropdown4> dropdown4)
        {
            _context = context;
            _dropdown4 = dropdown4;
        }
        public Dropdown4 GetDropDown4ByID(int Id)
        {
            return _dropdown4.GetSingle(d => d.ItemId == Id);
        }
        
        public void AddDropDown4(params Dropdown4[] Dropdown4)
        {
            try
            {
                _dropdown4.Add(Dropdown4);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateDropDown4(params Dropdown4[] Dropdown4)
        {
            try
            {
                _dropdown4.Update(Dropdown4);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDropDown4(params Dropdown4[] Dropdown4)
        {
            try
            {
                _dropdown4.Remove(Dropdown4);
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }



    }
}
