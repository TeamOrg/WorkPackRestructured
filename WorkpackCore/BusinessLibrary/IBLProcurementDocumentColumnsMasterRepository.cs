using System.Collections.Generic;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public interface IBLProcurementDocumentColumnsMasterRepository
    {
        void AddProcurementDocumentColumnsMasters(params ProcurementDocumentColumnsMaster[] ProcurementDocumentColumnsMaster);
        bool applySettingTaskTemplate(List<ProcurementDocumentColumnsMaster> TemplateData, int ProjectID, int UserID, int MasterTaskType = 1);
        bool checkDuplicateFieldName(string FieldName, int NormsColumnID);
        bool checkDuplicateNameInDb(string NameInDb, int ProcurementDocumentColumnID);
        DataTable GetAllDesignationProcurementDocumentColumnsMastersByProjectID(int ProjectID, string IsManHoursDisable);
        List<object> GetAllEstTaskColMastersByProjectID(int projectID);
        List<object> GetAllEstTaskColMastersByProjectID(int projectID, int MasterTaskType);
        List<string> getAllNameInDb(int ProjectID);
        List<object> GetAllProcurementColMastersByProjectID(int projectID, int MilestoneID);
        IList<EstimationColSettingTemplateDetail> GetAllProcurementDocumentColumnsByTemplateID(int TemplateId);
        IList<ProcurementDocumentColumnsMaster> GetAllProcurementDocumentColumnsMasters();
        IList<ProcurementDocumentColumnsMaster> GetAllProcurementDocumentColumnsMastersByProjectID(int ProjectID, int Milestoneid);
        int getDbColPkIDbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int ProjectID);
        List<ProcurementDocumentColumnsMaster> getDisplayColNameInDb(int ProjectID, int MasterTaskTypeID);
        List<object> GetEqnEstTaskColMastersByProjectID(int projectID);
        int GetInvolvedDesignationEstimationSettingByProjectID(int ProjectID);
        ProcurementDocumentColumnsMaster GetLastUsedBufferColoumnETCM(int projectid, int? MilestoneID, string datatype);
        List<ProcurementDocumentColumnsMaster> GetLastUsedBufferColoumnETCM(int? projectid, int? MilestoneID, string datatype);
        OperationResult getMaterialTrackingData(int ProjectID, int DeliverableID, int MilestoneID, int RevisionID);
        int GetMaxDiplayNumber(int ProjectID);
        int getProcurementDocumentColumnIdbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int ProjectID);
        ProcurementDocumentColumnsMaster GetProcurementDocumentColumnsMasterByID(int ProcurementDocumentColumnsMasterID);
        ProcurementDocumentColumnsMaster GetProcurementDocumentColumnsMasterByName(string ProcurementDocumentColumnsMasterName);
        void ReArrangeDisplayOrderProcurementDocumentColumnsMaster(int EstimationColID, int DisplayOrder, int ProjectID, int MilestoneID);
        dynamic rearrengebuffercoloummapping(int vid);
        void RemoveProcurementDocumentColumnsMasters(params ProcurementDocumentColumnsMaster[] ProcurementDocumentColumnsMaster);
        int saveEstimationColSettingTemplate(EstimationColSettingTemplate EstimationColSettingTemplate);
        void UpdateProcurementDocumentColumnsMasters(params ProcurementDocumentColumnsMaster[] ProcurementDocumentColumnsMaster);
    }
}