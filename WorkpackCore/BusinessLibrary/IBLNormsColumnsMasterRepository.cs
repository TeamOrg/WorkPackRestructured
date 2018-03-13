using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNormsColumnsMasterRepository
    {
        void AddNormsColumnsMasters(params NormsColumnsMaster[] NormsColumnsMaster);
        string changeNormsDisplayOrder(int NormsColumnID, int RowIndex);
        bool checkDuplicateFieldName(string FieldName, int NormsColumnID, int NormSetID);
        bool checkDuplicateNameInDb(string NameInDb, int NormsColumnID, int NormSetID);
        NormsColumnsMaster GeNormsColumnsMasterByID(int NormsColumnsMasterID);
        List<string> getAllNameInDb(int NormSetID);
        IList<NormsColumnsMaster> GetAllNormsColumnsMasters();
        List<NormsColumnsMaster> GetAllNormsColumnsMastersByNormSetID(int NormSetID);
        List<usp_getAllNormsColumnsMastersWithContractField_Result> getAllNormsColumnsMastersWithContractField(int CompanyNormSetID);
        //T GetByPrimaryKey<T>(int id) where T : class;
        int getMaxDisplayOrderByNormSet(int NormSetID);
        int getNormsColumnIdbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int NormSetID);
        decimal getNormsColumnIdbySqlTableFieldNameAndValueAndMappingNormSet(string SqlTableColumnName, string SqlTableColumnValue, int NormSetID, int MappingNormSetID, int ProjectStageID);
        decimal getValueFromMappingNormSet(int NormSetID, string word, int MappingNormSetID, int ContractNormID);
        void ReArrangeDisplayOrderNormColumnMaster(int NormSetID, int NormsColumnID, int ContractNormCoumnID);
        void RearrangeNormsColMaster(int NormSetID, int DisplayOrder);
        void RemoveNormsColumnsMasters(params NormsColumnsMaster[] NormsColumnsMaster);
        void UpdateNormsColumnsMasters(params NormsColumnsMaster[] NormsColumnsMaster);
    }
}