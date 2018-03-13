using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLIndexDatatable : IBLIndexDatatable
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<IndexDataTable> _indexdata;

        public BLIndexDatatable(WorkpackDBContext context, IGenericDataRepository<IndexDataTable> indexdata)
        {
            _context = context;
            _indexdata = indexdata;
        }
        public IList<IndexDataTable> GetAllIndexdata()
        {
            return _indexdata.GetAll();
        }
        public IndexDataTable GetIndexDataTableByID(Int32 IndexID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _indexdata.GetSingle(d => d.IndexID == IndexID);
            //include related employees
        }
        public int maxnumber()
        {
            int max = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    List<IndexDataTable> lst = null;
            //    lst = context.IndexDataTables.ToList <IndexDataTable>();
            //    if (lst.Count > 0)
            //    {
            //        max = Convert.ToInt32(lst.Select(c => c.MaxLineNumber).Sum());
            //    }
            //}
            return max;
        }
        public void AddIndexDataTable(params IndexDataTable[] indexdata)
        {
            /* Validation and error handling omitted */
            try
            {
                _indexdata.Add(indexdata);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }

        public void AddToDatatable(int fileid, string file, string filename, string ext,string DeliverableTitle)
        {
            //CustomSearch.AddUpdateLuceneIndex(IndexDataRepository.GetDataFromFile(fileid,file, filename+" "+DeliverableTitle, ext));
        }
    }
}
