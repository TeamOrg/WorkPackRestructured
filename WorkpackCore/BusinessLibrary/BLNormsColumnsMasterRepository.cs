using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNormsColumnsMasterRepository : IBLNormsColumnsMasterRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NormsColumnsMaster> _NormsColumnsMaster;

        public BLNormsColumnsMasterRepository(WorkpackDBContext context, IGenericDataRepository<NormsColumnsMaster> NormsColumnsMaster)
        {
            _context = context;
            _NormsColumnsMaster = NormsColumnsMaster;
        }
        public IList<NormsColumnsMaster> GetAllNormsColumnsMasters()
        {
            return _NormsColumnsMaster.GetAll();
        }
        public List<NormsColumnsMaster> GetAllNormsColumnsMastersByNormSetID(int NormSetID)
        {
            return _NormsColumnsMaster.GetAll().Where(a => a.NormSetID == NormSetID).ToList<NormsColumnsMaster>();
        }
        public NormsColumnsMaster GeNormsColumnsMasterByID(int NormsColumnsMasterID)
        {
            return _NormsColumnsMaster.GetSingle(d => d.NormsColumnID == NormsColumnsMasterID);
        }
        public void AddNormsColumnsMasters(params NormsColumnsMaster[] NormsColumnsMaster)
        {
            try
            {
                _NormsColumnsMaster.Add(NormsColumnsMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNormsColumnsMasters(params NormsColumnsMaster[] NormsColumnsMaster)
        {
            try
            {
                _NormsColumnsMaster.Update(NormsColumnsMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNormsColumnsMasters(params NormsColumnsMaster[] NormsColumnsMaster)
        {
            try
            {
                _NormsColumnsMaster.Remove(NormsColumnsMaster);
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

        public bool checkDuplicateFieldName(string FieldName, int NormsColumnID, int NormSetID)
        {
            int cnt = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    cnt = context.NormsColumnsMasters.Where(a => a.DisplayColName.StartsWith(FieldName) && a.DisplayColName.EndsWith(FieldName) && a.NormsColumnID != NormsColumnID && a.NormSetID==NormSetID).Count();
            //}
            if (cnt > 0)
                return true;
            else
                return false;
        }

        public bool checkDuplicateNameInDb(string NameInDb, int NormsColumnID,int NormSetID)
        {
            int cnt = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    cnt = context.NormsColumnsMasters.Where(a => a.NameInDb.StartsWith(NameInDb) && a.NameInDb.EndsWith(NameInDb) && a.NormsColumnID != NormsColumnID && a.NormSetID == NormSetID).Count();
            //    cnt = cnt + context.EstimationTaskColumnsMasters.Where(a => a.NameInDb.StartsWith(NameInDb) && a.NameInDb.EndsWith(NameInDb)).Count();
            //}
            if (cnt > 0)
                return true;
            else
                return false;
        }

        public List<string> getAllNameInDb(int NormSetID)
        {
            List<string> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.NormsColumnsMasters.Where(a => a.NormSetID == NormSetID).Select(a => a.NameInDb).ToList<string>();
            //}
            return result;
        }

        public List<usp_getAllNormsColumnsMastersWithContractField_Result> getAllNormsColumnsMastersWithContractField(int CompanyNormSetID)
        {
            List<usp_getAllNormsColumnsMastersWithContractField_Result> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.usp_getAllNormsColumnsMastersWithContractField(CompanyNormSetID).ToList<usp_getAllNormsColumnsMastersWithContractField_Result>();
            //}
            return result;
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

        public void ReArrangeDisplayOrderNormColumnMaster(int NormSetID, int NormsColumnID,int ContractNormCoumnID)
        {
            try
            {
                List<NormsColumnsMaster> lst = null;
                
                //BLContractNormColMasterRepository blcontract = new BLContractNormColMasterRepository();
                //int DisplayOrder;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    if (NormsColumnID > 0)
                //    {
                //        DisplayOrder = (from t in context.NormsColumnsMasters
                //                            where t.NormsColumnID == NormsColumnID && t.NormSetID==NormSetID
                //                            select t.DisplayOrder).FirstOrDefault();

                //        DisplayOrder = DisplayOrder == null ? 0 : DisplayOrder;
                //        lst = context.NormsColumnsMasters.Where(c => c.DisplayOrder > DisplayOrder && c.NormSetID == NormSetID).ToList<NormsColumnsMaster>();

                //        if (lst.Count > 0)
                //        {
                //            List<NormsColumnsMaster> listarr = new List<NormsColumnsMaster>();
                //            foreach (var item in lst)
                //            {
                //                item.DisplayOrder = Convert.ToInt32(item.DisplayOrder) - 1;
                //                item.EntityState = DominModel.EntityState.Modified;
                //            }

                //            _NormsColumnsMaster.Update(lst.ToArray());

                //        }
                //        blcontract.RearrangeContractNormsColumnMaster(NormSetID,DisplayOrder);
                //    }
                //    else
                //    {
                //        if (ContractNormCoumnID != null && ContractNormCoumnID.ToString() != "")
                //        {
                //            DisplayOrder = (from t in context.ContractNormColMasters
                //                            where t.ContractNormsColumnID == ContractNormCoumnID
                //                            select t.DisplayOrder).FirstOrDefault();
                //            DisplayOrder = DisplayOrder == null ? 0 : DisplayOrder;
                //            blcontract.RearrangeContractNormsColumnMaster(NormSetID, DisplayOrder);
                //            RearrangeNormsColMaster(NormSetID, DisplayOrder);
                //        }

                //    }
                    
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
        public void RearrangeNormsColMaster(int NormSetID, int DisplayOrder)
        {
            try
            {
                List<NormsColumnsMaster> lst = null;
               

                //using (var context = new Cubicle_EntityEntities())
                //{
                   
                //    lst = context.NormsColumnsMasters.Where(c => c.DisplayOrder > DisplayOrder && c.NormSetID == NormSetID).ToList<NormsColumnsMaster>();
                //    if (lst.Count > 0)
                //    {
                //        List<NormsColumnsMaster> listarr = new List<NormsColumnsMaster>();
                //        foreach (var item in lst)
                //        {
                //            item.DisplayOrder = Convert.ToInt32(item.DisplayOrder) - 1;
                //            item.EntityState = DominModel.EntityState.Modified;
                //        }

                //        _NormsColumnsMaster.Update(lst.ToArray());
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
        public int getNormsColumnIdbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int NormSetID)
        {
            int columnID = 0;
            try
            {
                string str = "SELECT NormsColumnID FROM NormsColumnsMaster WHERE NormSetID=" + NormSetID + " and " + SqlTableColumnName + "='" + SqlTableColumnValue + "'";
                string res = ExecuteSql(str);
                columnID = Convert.ToInt32(res == "" ? "0" : res);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            }

            return columnID;
        }

        public decimal getNormsColumnIdbySqlTableFieldNameAndValueAndMappingNormSet(string SqlTableColumnName, string SqlTableColumnValue, int NormSetID, int MappingNormSetID, int ProjectStageID)
        {
            decimal columnID = 0;
            try
            {
                string str = "SELECT CND.DistributionValue FROM NormsColumnsMaster NCM INNER JOIN ContractNormDistribution CND ON NCM.DBColPkID=CND.DesignationID AND CND.ProjectStageID=" + ProjectStageID;
                str = str + " WHERE NCM.NormSetID=" + NormSetID + " and " + SqlTableColumnName + "='" + SqlTableColumnValue + "'";
                string res = ExecuteSql(str);
                columnID = Convert.ToDecimal(res == "" ? "0" : res);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            }

            return columnID;
        }

        public decimal getValueFromMappingNormSet(int NormSetID, string word, int MappingNormSetID, int ContractNormID)
        {
            decimal distValue = 0;
            List<ContractNormDistribution> lst = null;
            List<string> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.NormsColumnsMasters.Where(a => a.NormSetID == NormSetID).Select(a => a.NameInDb).ToList<string>();
            //}
            //return result;


            try
            {
                //using(var context=new Cubicle_EntityEntities())
                //{                   

                //    var NormsColumnID = (from a in context.NormsColumnsMasters where a.NormSetID == MappingNormSetID && a.NameInDb == word select a.NormsColumnID);
                //    result = (from a in context.NormsDetails where a.NormsID == ContractNormID && NormsColumnID.Contains(a.NormsColumnID) select a.ColValue).ToList<string>();
                //    distValue = Convert.ToDecimal(result[0]);
                   

                //}
                
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            }

            return distValue;
        }

        //public T GetByPrimaryKey<T>(int id) where T : class
        //{
        //    using (var context = new Cubicle_EntityEntities())
        //    {
        //        var objectContext = (context as IObjectContextAdapter).ObjectContext;
        //        return (T)objectContext.GetObjectByKey(new EntityKey(objectContext.DefaultContainerName + "." + this.GetEntityName<T>(), GetPrimaryKeyInfo<T>().Name, id));
        //    }
        //}

        string GetEntityName<T>()
        {
            string name = typeof(T).Name;
            if (name.ToLower() == "person")
                return "People";
            else if (name.Substring(name.Length - 1, 1).ToLower() == "y")
                return name.Remove(name.Length - 1, 1) + "ies";
            else if (name.Substring(name.Length - 1, 1).ToLower() == "s")
                return name + "es";
            else
                return name + "s";
        }

        //private PropertyInfo GetPrimaryKeyInfo<T>()
        //{
        //    PropertyInfo[] properties = typeof(T).GetProperties();
        //    foreach (PropertyInfo pI in properties)
        //    {
        //        System.Object[] attributes = pI.GetCustomAttributes(true);
        //        foreach (object attribute in attributes)
        //        {
        //            if (attribute is EdmScalarPropertyAttribute)
        //            {
        //                if ((attribute as EdmScalarPropertyAttribute).EntityKeyProperty == true)
        //                    return pI;
        //            }
        //            //else if (attribute is ColumnAttribute)
        //            //{
        //            //    if ((attribute as ColumnAttribute).IsPrimaryKey == true)
        //            //        return pI;
        //            //}
        //        }
        //    }
        //    return null;
        //}



        public string changeNormsDisplayOrder(int NormsColumnID, int RowIndex)
        {
            string result = "";
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.usp_changeNormsDisplayOrder(NormsColumnID, RowIndex);
                //    result = "true";
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            }
            return result;
        }

        public int getMaxDisplayOrderByNormSet(int NormSetID)
        {
            int result = 0;
            IList<usp_getAllNormsColumnsMastersWithContractField_Result> list=null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    //result = context.NormsColumnsMasters.Where(a => a.NormSetID == NormSetID).Max(a => a.DisplayOrder) + 1;
                //    list = context.usp_getAllNormsColumnsMastersWithContractField(NormSetID).ToList<usp_getAllNormsColumnsMastersWithContractField_Result>();
                //    result = list.OrderByDescending(a => a.DisplayOrder).Select(b => b.DisplayOrder).Max()+1;
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            }
            return result;
        }

        
    }
}
