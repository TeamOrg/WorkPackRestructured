using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLIndexDatatable
    {
        void AddIndexDataTable(params IndexDataTable[] indexdata);
        void AddToDatatable(int fileid, string file, string filename, string ext, string DeliverableTitle);
        IList<IndexDataTable> GetAllIndexdata();
        IndexDataTable GetIndexDataTableByID(int IndexID);
        int maxnumber();
    }
}