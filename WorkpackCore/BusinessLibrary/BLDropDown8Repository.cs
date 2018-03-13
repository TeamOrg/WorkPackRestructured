using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDropDown8Repository : IBLDropDown8Repository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Dropdown8> _dropdown8;

        public BLDropDown8Repository(WorkpackDBContext context, IGenericDataRepository<Dropdown8> dropdown8)
        {
            _context = context;
            _dropdown8 = dropdown8;
        }

        public Dropdown8 GetDropDown8ByID(int Id)
        {
            return _dropdown8.GetSingle(d => d.ItemId == Id);
        }
        
        public void AddDropDown8(params Dropdown8[] Dropdown8)
        {
            try
            {
                _dropdown8.Add(Dropdown8);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateDropDown8(params Dropdown8[] Dropdown8)
        {
            try
            {
                _dropdown8.Update(Dropdown8);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDropDown8(params Dropdown8[] Dropdown8)
        {
            try
            {
                _dropdown8.Remove(Dropdown8);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
