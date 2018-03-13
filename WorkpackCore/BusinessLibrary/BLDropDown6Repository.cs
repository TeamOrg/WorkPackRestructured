using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDropDown6Repository : IBLDropDown6Repository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Dropdown6> _dropdown6;

        public BLDropDown6Repository(WorkpackDBContext context, IGenericDataRepository<Dropdown6> dropdown6)
        {
            _context = context;
            _dropdown6 = dropdown6;
        }
        public Dropdown6 GetDropDown6ByID(int Id)
        {
            return _dropdown6.GetSingle(d => d.ItemId == Id);
        }
        

        public void AddDropDown6(params Dropdown6[] Dropdown6)
        {
            try
            {
                _dropdown6.Add(Dropdown6);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateDropDown6(params Dropdown6[] Dropdown6)
        {
            try
            {
                _dropdown6.Update(Dropdown6);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveDropDown6(params Dropdown6[] Dropdown6)
        {
            try
            {
                _dropdown6.Remove(Dropdown6);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
