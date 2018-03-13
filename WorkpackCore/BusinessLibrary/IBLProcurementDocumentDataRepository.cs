using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProcurementDocumentDataRepository
    {
        void AddProcurementDocumentData(params ProcurementDocumentData[] ProcurementDocumentData);
        List<object> GetAllDelListByProjectID(int ProjectID);
        IList<ProcurementDocumentData> GetAllProcurementDocumentData();
        IList<object> GetAllProcurementDocumentData(int TaskID, int MilestoneID, int FileID);
        List<ProcurementDocumentData> GetAllProcurementDocumentDataperprojectid(int projectid);
        ProcurementDocumentData GetProcurementDocumentDataByID(int TaskID);
        void RemoveProcurementDocumentData(params ProcurementDocumentData[] ProcurementDocumentData);
        void UpdateProcurementDocumentData(params ProcurementDocumentData[] ProcurementDocumentData);
    }
}