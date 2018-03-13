using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDropDown7Repository : IBLDropDown7Repository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Dropdown7> _dropdown7;

        public BLDropDown7Repository(WorkpackDBContext context, IGenericDataRepository<Dropdown7> dropdown7)
        {
            _context = context;
            _dropdown7 = dropdown7;
        }
        public Dropdown7 GetDropDown7ByID(int Id)
        {
            return _dropdown7.GetSingle(d => d.ItemId == Id);
        }
        
        public void AddDropDown7(params Dropdown7[] Dropdown7)
        {
            try
            {
                _dropdown7.Add(Dropdown7);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateDropDown7(params Dropdown7[] Dropdown7)
        {
            try
            {
                _dropdown7.Update(Dropdown7);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDropDown7(params Dropdown7[] Dropdown7)
        {
            try
            {
                _dropdown7.Remove(Dropdown7);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
