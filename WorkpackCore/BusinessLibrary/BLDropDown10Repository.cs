using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDropDown10Repository : IBLDropDown10Repository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Dropdown10> _dropdown10;

        public BLDropDown10Repository(WorkpackDBContext context, IGenericDataRepository<Dropdown10> dropdown10)
        {
            _context = context;
            _dropdown10 = dropdown10;
        }
        public Dropdown10 GetDropDown10ByID(int Id)
        {
            return _dropdown10.GetSingle(d => d.ItemId == Id);
        }        
        
        public void AddDropDown10(params Dropdown10[] Dropdown10)
        {
            try
            {
                _dropdown10.Add(Dropdown10);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateDropDown10(params Dropdown10[] Dropdown10)
        {
            try
            {
                _dropdown10.Update(Dropdown10);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDropDown10(params Dropdown10[] Dropdown10)
        {
            try
            {
                _dropdown10.Remove(Dropdown10);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
