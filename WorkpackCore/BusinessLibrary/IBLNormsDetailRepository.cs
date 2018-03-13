using System.Collections.Generic;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public interface IBLNormsDetailRepository
    {
        void AddNormDetails(params NormsDetail[] NormsDetail);
        List<usp_BindDDLFromNormsDetails_Result> BindDDLFromNormsDetails(int NormSetID, string ddlType);
        bool deleteNormDetail(int NormID);
        IList<NormsDetail> GetAllNormDetail();
        List<usp_getAllNormsDetails_Result> getAllNormsDetails();
        List<usp_getAllNormsDetailsByNormSetID_Result> getAllNormsDetailsByNormSetID(int NormSetID);
        NormsDetail GetNormDetailByID(int NormsDetailID);
        NormsDetail GetNormDetailByNormIDAndColumnID(int NormID, int NormsColumnID);
        List<object> getNormsDesDetailsByNormID(int NormsID);
        List<NormDesDet> getNormsDesDetailsByNormIDCls(int NormsID);
        List<NormsDetail> getNormsDetailsByColumnID(string ColumnID);
        List<NormsDetail> getNormsDetailsByNormID(int NormID);
        List<usp_GetNormsDetailsByNormsID_Result> GetNormsDetailsByNormsID(int NormID);
        DataTable getNormsDetailsDatatableyNormID(int NormID, int NormSetID);
        List<NormsManageTable> getNormsManageTable();
        List<NormsManageTableColumn> getNormsManageTableColumn(int NormManageTableID);
        List<usp_getNormsDetailsByColumnID_Result> getuspNormsDetailsByColumnID(string ColumnID, int NormSetID);
        void RemoveNormDetails(params NormsDetail[] NormsDetail);
        void UpdateNormDetails(params NormsDetail[] NormsDetail);
    }
}