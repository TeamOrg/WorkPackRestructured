using System.Collections.Generic;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public interface IBLEstimationTaskColumnsMasterRepository
    {
        void AddEstimationTaskColumnsMasters(params EstimationTaskColumnsMaster[] EstimationTaskColumnsMaster);
        bool applySettingTaskTemplate(List<EstimationTaskColumnsMaster> TemplateData, int ProjectID, int UserID, int MasterTaskType = 1);
        bool checkDuplicateFieldName(string FieldName, int NormsColumnID);
        bool checkDuplicateNameInDb(string NameInDb, int EstimationTaskColumnID);
        DataTable GetAllDesignationEstimationTaskColumnsMastersByProjectID(int ProjectID, string IsManHoursDisable);
        IList<EstimationColSettingTemplateDetail> GetAllEstimationTaskColumnsByTemplateID(int TemplateId);
        IList<EstimationTaskColumnsMaster> GetAllEstimationTaskColumnsMasters();
        IList<EstimationTaskColumnsMaster> GetAllEstimationTaskColumnsMastersByProjectID(int ProjectID);
        IList<EstimationTaskColumnsMaster> GetAllEstimationTaskColumnsMastersByProjectID(int ProjectID, int MasterTaskType);
        List<usp_GetAllEstimationTaskColumnsMasters_Result> GetAllEstimationTaskColumnsMastersWithNormColumnName(int ProjectID);
        List<object> GetAllEstTaskColMastersByProjectID(int projectID);
        List<object> GetAllEstTaskColMastersByProjectID(int projectID, int MasterTaskType);
        List<string> getAllNameInDb(int ProjectID);
        List<object> GetAllProcurementColMastersByProjectID(int projectID, int MilestoneID);
        int getDbColPkIDbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int ProjectID);
        List<EstimationTaskColumnsMaster> getDisplayColNameInDb(int ProjectID, int MasterTaskTypeID);
        List<object> GetEqnEstTaskColMastersByProjectID(int projectID);
        int getEstimationTaskColumnIdbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int ProjectID);
        EstimationTaskColumnsMaster GetEstimationTaskColumnsMasterByID(int EstimationTaskColumnsMasterID);
        EstimationTaskColumnsMaster GetEstimationTaskColumnsMasterByName(string EstimationTaskColumnsMasterName);
        List<object> GetEstimationTemplateDetailByTemplateID(int TemplateID);
        List<object> GetEstimationTemplateDetailByTemplateID(int TemplateID, int companyid);
        int GetInvolvedDesignationEstimationSettingByProjectID(int ProjectID);
        EstimationTaskColumnsMaster GetLastUsedBufferColoumnETCM(int projectid, string datatype, int? MasterTaskTypeID);
        List<EstimationTaskColumnsMaster> GetLastUsedBufferColoumnETCM(int? projectid, string datatype, int? MasterTaskTypeID);
        int GetMaxDiplayNumber(int ProjectID);
        void ReArrangeDisplayOrderEstimationTaskColumnsMaster(int EstimationColID, int DisplayOrder, int vTemplateID, int ProjectID);
        dynamic rearrengebuffercoloummapping(int vid, int TemplateID, int MasterTaskTypeR);
        void RemoveEstimationTaskColumnsMasters(params EstimationTaskColumnsMaster[] EstimationTaskColumnsMaster);
        int saveEstimationColSettingTemplate(EstimationColSettingTemplate EstimationColSettingTemplate);
        void UpdateEstimationTaskColumnsMasters(params EstimationTaskColumnsMaster[] EstimationTaskColumnsMaster);
    }
}