using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDropDown5Repository : IBLDropDown5Repository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Dropdown5> _dropdown5;

        public BLDropDown5Repository(WorkpackDBContext context, IGenericDataRepository<Dropdown5> dropdown5)
        {
            _context = context;
            _dropdown5 = dropdown5;
        }
        public Dropdown5 GetDropDown5ByID(int Id)
        {
            return _dropdown5.GetSingle(d => d.ItemId == Id);
        }
       
        public void AddDropDown5(params Dropdown5[] Dropdown5)
        {
            try
            {
                _dropdown5.Add(Dropdown5);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateDropDown5(params Dropdown5[] Dropdown5)
        {
            try
            {
                _dropdown5.Update(Dropdown5);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDropDown5(params Dropdown5[] Dropdown5)
        {
            try
            {
                _dropdown5.Remove(Dropdown5);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
