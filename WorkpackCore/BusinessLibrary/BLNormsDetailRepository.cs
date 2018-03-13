using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public class BLNormsDetailRepository : IBLNormsDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NormsDetail> _NormsDetail;

        public BLNormsDetailRepository(WorkpackDBContext context, IGenericDataRepository<NormsDetail> NormsDetail)
        {
            _context = context;
            _NormsDetail = NormsDetail;
        }


        public IList<NormsDetail> GetAllNormDetail()
        {
            return _NormsDetail.GetAll();
        }
        public NormsDetail GetNormDetailByID(int NormsDetailID)
        {
            return _NormsDetail.GetSingle(d => d.NormsDetailID == NormsDetailID);
        }
        public void AddNormDetails(params NormsDetail[] NormsDetail)
        {
            try
            {
                _NormsDetail.Add(NormsDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNormDetails(params NormsDetail[] NormsDetail)
        {
            try
            {
                _NormsDetail.Update(NormsDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNormDetails(params NormsDetail[] NormsDetail)
        {
            try
            {
                _NormsDetail.Remove(NormsDetail);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }

        public List<usp_getAllNormsDetails_Result> getAllNormsDetails()
        {
            List<usp_getAllNormsDetails_Result> lst = null;
            return lst;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    return context.usp_getAllNormsDetails().ToList<usp_getAllNormsDetails_Result>();
            //}
        }

        public List<usp_getAllNormsDetailsByNormSetID_Result> getAllNormsDetailsByNormSetID(int NormSetID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    return context.usp_getAllNormsDetailsByNormSetID(NormSetID).ToList<usp_getAllNormsDetailsByNormSetID_Result>();
            //}

            List<usp_getAllNormsDetailsByNormSetID_Result> lst = null;
            return lst;
        }

        public List<NormsDetail> getNormsDetailsByNormID(int NormID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    return context.NormsDetails.Where(a => a.NormsID == NormID).ToList<NormsDetail>();
            //}
            List<NormsDetail> lst = null;
            return lst;
        }
        public List<usp_BindDDLFromNormsDetails_Result> BindDDLFromNormsDetails(int NormSetID, string ddlType)
        {
            List<usp_BindDDLFromNormsDetails_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_BindDDLFromNormsDetails(NormSetID, ddlType).ToList<usp_BindDDLFromNormsDetails_Result>();
            //}
            return lst;
        }
        public static string ExecuteSql(string sql)
        {
            string res = "";
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    SqlConnection entityConnection = (SqlConnection)context.Database.Connection;
            //    DbConnection conn = entityConnection;
            //    ConnectionState initialState = conn.State;
            //    try
            //    {
            //        if (initialState != ConnectionState.Open)
            //            conn.Open();  // open connection if not already open
            //        using (DbCommand cmd = conn.CreateCommand())
            //        {
            //            cmd.CommandText = sql;
            //            var result = cmd.ExecuteScalar();
            //            res = Convert.ToString(result);
            //        }
            //    }
            //    finally
            //    {
            //        if (initialState != ConnectionState.Open)
            //            conn.Close(); // only close connection if not initially open
            //    }
            //}
            return res;
        }

        public static DataTable ExecuteSqlDataTable(string sql)
        {
            DataTable dt = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    SqlConnection entityConnection = (SqlConnection)context.Database.Connection;
            //    //DbConnection conn = entityConnection;
            //    ConnectionState initialState = entityConnection.State;
            //    try
            //    {
            //        if (initialState != ConnectionState.Open)
            //            entityConnection.Open();  // open connection if not already open

            //        using (SqlDataAdapter da = new SqlDataAdapter(sql, entityConnection))
            //        {
            //            da.Fill(dt);
            //        }
            //    }
            //    finally
            //    {
            //        if (initialState != ConnectionState.Open)
            //            entityConnection.Close(); // only close connection if not initially open
            //    }
            //}
            return dt;
        }

        public bool deleteNormDetail(int NormID)
        {
            bool status = true;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        BLNormsRepository blNorm = new BLNormsRepository();
            //        Norm norm = blNorm.GetNormsByID(NormID);
            //        norm.IsDeleted = "Y";
            //        norm.EntityState = EntityState.Modified;
            //        blNorm.RemoveNorms(norm);

            //        ts.Complete();
            //        status = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        status = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    }
            //}
            return status;
        }

        public NormsDetail GetNormDetailByNormIDAndColumnID(int NormID, int NormsColumnID)
        {
            NormsDetail det = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    det = context.NormsDetails.Where(a => a.NormsID == NormID && a.NormsColumnID == NormsColumnID).FirstOrDefault();
            //}
            return det;
        }

        public List<NormsManageTable> getNormsManageTable()
        {
            List<NormsManageTable> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.NormsManageTables.ToList<NormsManageTable>();
            //}
            return lst;
        }
        public List<NormsManageTableColumn> getNormsManageTableColumn(int NormManageTableID)
        {
            List<NormsManageTableColumn> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.NormsManageTableColumns.Where(a => a.NormsManageTableID == NormManageTableID).ToList<NormsManageTableColumn>();
            //}
            return lst;
        }

        public List<NormsDetail> getNormsDetailsByColumnID(string ColumnID)
        {
            List<NormsDetail> lst = null;
            int CmnID = Convert.ToInt32(ColumnID);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.NormsDetails.Where(a => a.NormsColumnID == CmnID).ToList<NormsDetail>();
            //}
            return lst;
        }

        public List<usp_getNormsDetailsByColumnID_Result> getuspNormsDetailsByColumnID(string ColumnID,int NormSetID)
        {
            List<usp_getNormsDetailsByColumnID_Result> lst = null;
            int CmnID = Convert.ToInt32(ColumnID);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_getNormsDetailsByColumnID(CmnID, NormSetID).ToList<usp_getNormsDetailsByColumnID_Result>();
            //}
            return lst;
        }

                
        public DataTable getNormsDetailsDatatableyNormID(int NormID,int NormSetID)
        {
            DataTable dt = null;
            //dt.Columns.Add("NormsID");
            //BLNormsColumnsMasterRepository blNormMaster = new BLNormsColumnsMasterRepository();
            //List<NormsColumnsMaster> lstNormMaster = blNormMaster.GetAllNormsColumnsMasters().ToList<NormsColumnsMaster>();
            //foreach (var item in lstNormMaster)
            //{
            //    if (item.DisplayInGrid == "Y")
            //    {
            //        dt.Columns.Add(item.DisplayColName);
            //    }
            //}

            //BLNormsDetailRepository blNormsDet = new BLNormsDetailRepository();
            //List<usp_getAllNormsDetails_Result> lst = blNormsDet.getAllNormsDetails();
            //List<usp_getAllNormsDetails_Result> lstNormIDs = lst;
            //if (lst.Count > 0)
            //{
            //    Array NormIDs = lstNormIDs.Where(a => a.NormsID == NormID).Select(a => a.NormsID).Distinct().ToArray();

            //    foreach (var arrItem in NormIDs)
            //    {
            //        DataRow dr = dt.NewRow();
            //        int arrNormID = Convert.ToInt32(arrItem);
            //        List<usp_getAllNormsDetails_Result> lstNormIdWise = lst.Where(a => a.NormsID == arrNormID).ToList<usp_getAllNormsDetails_Result>();
            //        dr["NormsID"] = arrNormID;
            //        foreach (var item in lstNormIdWise)
            //        {
            //            if (item.DisplayInGrid == "Y")
            //            {
            //                if (item.IsDropDown == "M" || item.IsDropDown == "Y")
            //                {
            //                    string str = "";
            //                    string WhereCond = BLNormsDetailRepository.ExecuteSql("SELECT Column_Name FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE Table_Name='" + item.TableName + "'");
            //                    if (item.IsDropDown == "Y")
            //                    {
            //                        str = "SELECT " + item.DBColName + " from " + item.TableName + " WHERE ";
            //                        str = str + WhereCond + "=" + item.ColValue;
            //                    }
            //                    else
            //                    {
            //                        str = "SELECT(SELECT LEFT(Result,LEN(Result) - 1) FROM (SELECT CONVERT(VARCHAR(max),( ";
            //                        str = str + "SELECT " + item.DBColName + " as [text()], ',' as [text()] FROM NormsMultipleEntryDetails NM ";
            //                        str = str + " INNER JOIN " + item.TableName + " AS TT ON NM.MappingTableColumnId=TT." + WhereCond;
            //                        str = str + " WHERE NormsID=" + item.NormsID + " and NormsColumnID=" + item.NormsColumnID;
            //                        str = str + " FOR XML PATH('')))as Result)s) AS ColumnResultName";
            //                    }

            //                    dr[item.DisplayColName] = BLNormsDetailRepository.ExecuteSql(str);
            //                }
            //                else
            //                {
            //                    if (item.InputOutput == "Output" && item.EquationID != null)
            //                    {
            //                        string[] separators = { "+", "-", "*", "/" };
            //                        string[] token = item.EquationID.Split(separators, StringSplitOptions.None);
            //                        string Eqn = item.EquationID;
            //                        List<string> NameInDb = blNormMaster.getAllNameInDb(NormSetID);
            //                        foreach (var word in token)
            //                        {
            //                            double n;
            //                            if (!double.TryParse(word, out n))
            //                            {
            //                                if (!NameInDb.Contains(word))
            //                                {
            //                                    int wordColumnID = blNormMaster.getNormsColumnIdbySqlTableFieldNameAndValue("NameInDb", word.Trim(),NormSetID);
            //                                    Eqn = Eqn.Replace(word.Trim(), "(select ColValue from dbo.NormsDetail where NormsID=" + item.NormsID + " and NormsColumnID=" + wordColumnID + ")");
            //                                }
            //                            }
            //                        }

            //                        dr[item.DisplayColName] = BLNormsColumnsMasterRepository.ExecuteSql("SELECT " + Eqn);
            //                    }
            //                    else
            //                    {
            //                        dr[item.DisplayColName] = item.ColValue;
            //                    }
            //                }
            //            }
            //        }

            //        dt.Rows.Add(dr);
            //    }

            //}

            return dt;
        }



        public List<usp_GetNormsDetailsByNormsID_Result> GetNormsDetailsByNormsID(int NormID)
        {
            List<usp_GetNormsDetailsByNormsID_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_GetNormsDetailsByNormsID(NormID).ToList<usp_GetNormsDetailsByNormsID_Result>();
            //}
            return lst;
        }

        public List<object> getNormsDesDetailsByNormID(int NormsID)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = ((from q in context.NormsDetails
            //            join r in context.NormsColumnsMasters on q.NormsColumnID equals r.NormsColumnID
            //            where q.NormsID == NormsID //&& r.DBColPkID > 0
            //            select new
            //            {
            //                q.ColValue,
            //                r.NameInDb,
            //                r.DBColPkID
            //            }).ToList().Where(a => Convert.ToString(a.ColValue as object) != "")).ToList<object>();
            //}
            return lst;
        }

        public List<NormDesDet> getNormsDesDetailsByNormIDCls(int NormsID)
        {
            List<NormDesDet> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = ((from q in context.NormsDetails
            //            join r in context.NormsColumnsMasters on q.NormsColumnID equals r.NormsColumnID
            //            where q.NormsID == NormsID //&& r.DBColPkID > 0
            //            select new NormDesDet
            //            {
            //                ColValue = q.ColValue,
            //                NameInDb = r.NameInDb,
            //                DBColPkID = r.DBColPkID
            //            }).ToList<NormDesDet>().Where(q => Convert.ToString(q.ColValue as object) != "")).ToList<NormDesDet>();
            //}
            return lst;
        }
    }

    public class NormDesDet
    {
        public string ColValue;
        public string NameInDb;
        public int? DBColPkID;
    }
}
