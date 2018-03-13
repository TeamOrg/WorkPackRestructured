using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNormsManageTableRepository : IBLNormsManageTableRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NormsManageTable> _NormsManageTable;

        public BLNormsManageTableRepository(WorkpackDBContext context, IGenericDataRepository<NormsManageTable> NormsManageTable)
        {
            _context = context;
            _NormsManageTable = NormsManageTable;
        }

        public NormsManageTable GetNormsManageTableID(int Id)
        {
            return _NormsManageTable.GetSingle(d => d.NormsManageTableID == Id);
        }
        public void AddNormsManageTable(params NormsManageTable[] NormsManageTable)
        {
            try
            {
                _NormsManageTable.Add(NormsManageTable);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNormsManageTable(params NormsManageTable[] NormsManageTable)
        {
            try
            {
                _NormsManageTable.Update(NormsManageTable);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNormsManageTable(params NormsManageTable[] NormsManageTable)
        {
            try
            {
                _NormsManageTable.Remove(NormsManageTable);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



    }
}
