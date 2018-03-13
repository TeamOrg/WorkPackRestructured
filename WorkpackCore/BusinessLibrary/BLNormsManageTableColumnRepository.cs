using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNormsManageTableCoulumnRepository : IBLNormsManageTableCoulumnRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NormsManageTableColumn> _NormsManageTableCoulumn;

        public BLNormsManageTableCoulumnRepository(WorkpackDBContext context, IGenericDataRepository<NormsManageTableColumn> NormsManageTableCoulumn)
        {
            _context = context;
            _NormsManageTableCoulumn = NormsManageTableCoulumn;
        }

        public NormsManageTableColumn GetNormsManageTableCoulumnByID(int Id)
        {
            return _NormsManageTableCoulumn.GetSingle(d => d.NormsManageTableColId == Id);
        }

        public void AddNormsManageTableCoulumn(params NormsManageTableColumn[] NormsManageTableColumn)
        {
            try
            {
                _NormsManageTableCoulumn.Add(NormsManageTableColumn);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNormsManageTableCoulumn(params NormsManageTableColumn[] NormsManageTableColumn)
        {
            try
            {
                _NormsManageTableCoulumn.Update(NormsManageTableColumn);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNormsManageTableCoulumn(params NormsManageTableColumn[] NormsManageTableColumn)
        {
            try
            {
                _NormsManageTableCoulumn.Remove(NormsManageTableColumn);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
