using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDropDown9Repository : IBLDropDown9Repository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Dropdown9> _dropdown9;

        public BLDropDown9Repository(WorkpackDBContext context, IGenericDataRepository<Dropdown9> dropdown9)
        {
            _context = context;
            _dropdown9 = dropdown9;
        }
        public Dropdown9 GetDropDown9ByID(int Id)
        {
            return _dropdown9.GetSingle(d => d.ItemId == Id);
        }
        
        public void AddDropDown9(params Dropdown9[] Dropdown9)
        {
            try
            {
                _dropdown9.Add(Dropdown9);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateDropDown9(params Dropdown9[] Dropdown9)
        {
            try
            {
                _dropdown9.Update(Dropdown9);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDropDown9(params Dropdown9[] Dropdown9)
        {
            try
            {
                _dropdown9.Remove(Dropdown9);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
