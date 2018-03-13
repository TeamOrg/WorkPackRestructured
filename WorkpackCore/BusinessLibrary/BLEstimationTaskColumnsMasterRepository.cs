using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public class BLEstimationTaskColumnsMasterRepository : IBLEstimationTaskColumnsMasterRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EstimationTaskColumnsMaster> _estimationTaskColumnsMaster;

        public BLEstimationTaskColumnsMasterRepository(WorkpackDBContext context, IGenericDataRepository<EstimationTaskColumnsMaster> estimationTaskColumnsMaster)
        {
            _context = context;
            _estimationTaskColumnsMaster = estimationTaskColumnsMaster;
        }
        public IList<EstimationTaskColumnsMaster> GetAllEstimationTaskColumnsMasters()
        {
            return _estimationTaskColumnsMaster.GetAll();
        }
        public IList<EstimationTaskColumnsMaster> GetAllEstimationTaskColumnsMastersByProjectID(int ProjectID, int MasterTaskType)
        {
            IList<EstimationTaskColumnsMaster> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.EstimationTaskColumnsMasters.Where(a => a.ProjectID == ProjectID && a.MasterTaskTypeID == MasterTaskType).ToList<EstimationTaskColumnsMaster>();
                //}
            }
            catch (Exception ex)
            {
            }

            return list;
        }



        public IList<EstimationTaskColumnsMaster> GetAllEstimationTaskColumnsMastersByProjectID(int ProjectID)
        {
            IList<EstimationTaskColumnsMaster> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.EstimationTaskColumnsMasters.Where(a => a.ProjectID == ProjectID).ToList<EstimationTaskColumnsMaster>();
                //}
            }
            catch (Exception ex)
            {
            }

            return list;
        }

        public IList<EstimationColSettingTemplateDetail> GetAllEstimationTaskColumnsByTemplateID(int TemplateId)
        {
            IList<EstimationColSettingTemplateDetail> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.EstimationColSettingTemplateDetails.Where(a => a.EstimationColSettingTemplateID == TemplateId && a.DisplayInGrid== "Y").ToList();
                //}
            }
            catch (Exception ex)
            {
            }

            return list;
        }



        public DataTable GetAllDesignationEstimationTaskColumnsMastersByProjectID(int ProjectID, string IsManHoursDisable)
        {
            IList<EstimationTaskColumnsMaster> list = null;
            DataTable dt = null;

            try
            {

                //dt.TableName = "SubmitEstimationTask";
                //dt.Columns.Add("id");
                //dt.Columns.Add("Department");
                //if (IsManHoursDisable == "Y")
                //{
                //    dt.Columns.Add("StartDate");
                //    dt.Columns.Add("EndDate");
                //}
                //DataRow dr;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    if (IsManHoursDisable != "Y")
                //    {
                //        list = context.EstimationTaskColumnsMasters.Where(a => a.ProjectID == ProjectID && a.DBColPkID > 0).ToList<EstimationTaskColumnsMaster>();
                //        foreach (var item in list)
                //        {
                //            dt.Columns.Add(item.DisplayColName);
                //        }
                //        dt.Columns.Add("Total");
                //    }
                //    using (var Context = new Cubicle_EntityEntities())
                //    {



                //        var deptList = (from TD in context.TaskDesignations
                //                        join D in context.Departments on TD.DepartmentID equals D.DepartmentID
                //                        where TD.ProjectID == ProjectID
                //                        select new { DeptID = TD.DepartmentID, DeptName = D.DepartmentName }).Distinct();




                //        var DesigList = (from t in context.TaskDesignations.Where(a => a.ProjectID == ProjectID)
                //                         where !(from b in context.ProjectTaskLists
                //                                 where b.ProjectID == ProjectID && b.SysGen == "Y"
                //                                 select b.ProjectTaskID)
                //        .Contains(t.ProjectTaskID)
                //                         select new { DesignationID = t.DesignationID, Hours = t.Hours == null ? 0 : t.Hours, Dept = t.DepartmentID });

                //        //dept Wise looo
                //        foreach (var itemdept in deptList)
                //        {
                //            decimal Total = 0;
                //            dr = dt.NewRow();
                //            dr["id"] = itemdept.DeptID;
                //            dr["Department"] = itemdept.DeptName;

                //            if (IsManHoursDisable == "Y")
                //            {
                //                var DeptDates = (from pt in context.ProjectTaskLists
                //                                 where pt.DepatmentID == itemdept.DeptID && pt.ProjectID == ProjectID
                //                                 select new { StartDate = pt.StartDate, EndDate = pt.EndDate });
                //                if (DeptDates.Count() > 0)
                //                {
                //                    dr["StartDate"] = Convert.ToDateTime(DeptDates.Min(c => c.StartDate)).ToString("dd/MM/yyyy");
                //                    dr["EndDate"] = Convert.ToDateTime(DeptDates.Max(c => c.EndDate)).ToString("dd/MM/yyyy");
                //                }
                //            }
                //            else
                //            {   //Desig wise loop                          
                //                foreach (var item in list)
                //                {
                //                    var desighour = (from t in DesigList where t.Dept == itemdept.DeptID && t.DesignationID == item.DBColPkID select t.Hours).DefaultIfEmpty().Sum();
                //                    Total = Total + Convert.ToDecimal(desighour);
                //                    dr[item.DisplayColName] = desighour;
                //                }
                //                dr["Total"] = Total;
                //            }
                //            dt.Rows.Add(dr);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
            }

            return dt;
        }

        public dynamic rearrengebuffercoloummapping(int vid, int TemplateID, int MasterTaskTypeR)
        {
            dynamic i;

            //if (TemplateID == 0 && MasterTaskTypeR==0)
            //{

            //    BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //    EstimationTaskColumnsMaster item = blObj.GetEstimationTaskColumnsMasterByID(vid);
            //    string data = "";
            //    if (item.DataType.Contains("Unique"))
            //    {

            //        data = item.DataType.Substring(6);
            //    }
            //    else
            //    {

            //        data = item.DataType;
            //    }
            //    List<EstimationTaskColumnsMaster> lst = blObj.GetLastUsedBufferColoumnETCM(item.ProjectID, data, item.MasterTaskTypeID);
            //    string[] name = item.ProjectTaskListColumn.Split('_');
            //    foreach (EstimationTaskColumnsMaster a in lst)
            //    {
            //        if (name.Length > 1)
            //        {
            //            if (Convert.ToInt32(a.ProjectTaskListColumn.Split('_')[1]) > Convert.ToInt32(item.ProjectTaskListColumn.Split('_')[1]))
            //            {

            //                a.ProjectTaskListColumn = a.ProjectTaskListColumn.Split('_')[0] + "_" + Convert.ToString((Convert.ToInt32(a.ProjectTaskListColumn.Split('_')[1]) - 1));
            //                a.PermanentNameInDb = a.PermanentNameInDb.Split('_')[0] + "_" + Convert.ToString((Convert.ToInt32(a.PermanentNameInDb.Split('_')[1]) - 1));

            //                a.EntityState = DominModel.EntityState.Modified;
            //                blObj.UpdateEstimationTaskColumnsMasters(a);
            //            }
            //        }


            //    }

            //    i = item;
            //    return i;
            //}

            //else  //id is EstimationColSettingTemplateDetailID
            //{


            //    BLEstimationTaskColumnsMasterRepository blObj1 = new BLEstimationTaskColumnsMasterRepository();
            //    BLEstimationColSettingTemplateDetail blObj = new BLEstimationColSettingTemplateDetail();
            //    EstimationColSettingTemplateDetail item = blObj.getEstimationColSettingTemplateDetailByID(vid);
            //    string data = "";
            //    if (item.DataType.Contains("Unique"))
            //    {

            //        data = item.DataType.Substring(6);
            //    }
            //    else
            //    {

            //        data = item.DataType;
            //    }
            //    string[] name = item.ProjectTaskListColumn.Split('_');
            //    List<EstimationColSettingTemplateDetail> lst = blObj.GetLastUsedBufferColoumnByTemplateID(GeneralFuntions.ToNullableInt32(Convert.ToString(TemplateID)), data, MasterTaskTypeR);

            //    foreach (EstimationColSettingTemplateDetail a in lst)
            //    {
            //        if (name.Length > 1)
            //        {
            //            if (Convert.ToInt32(a.ProjectTaskListColumn.Split('_')[1]) > Convert.ToInt32(name[1]))
            //            {

            //                a.ProjectTaskListColumn = a.ProjectTaskListColumn.Split('_')[0] + "_" + Convert.ToString((Convert.ToInt32(a.ProjectTaskListColumn.Split('_')[1]) - 1));
            //                a.PermanentNameInDb = a.PermanentNameInDb.Split('_')[0] + "_" + Convert.ToString((Convert.ToInt32(a.PermanentNameInDb.Split('_')[1]) - 1));

            //                a.EntityState = DominModel.EntityState.Modified;
            //                blObj.UpdateEstimationColSettingTemplate(a);
            //            }
            //        }



            //    }

            //    i = item;
            //    return i;
            //}
            return i=0;
        }
        public EstimationTaskColumnsMaster GetEstimationTaskColumnsMasterByName(string EstimationTaskColumnsMasterName)
        {
            return _estimationTaskColumnsMaster.GetSingle(d => d.DisplayColName == EstimationTaskColumnsMasterName);
        }


        public EstimationTaskColumnsMaster GetEstimationTaskColumnsMasterByID(int EstimationTaskColumnsMasterID)
        {
            return _estimationTaskColumnsMaster.GetSingle(d => d.EstimationTaskColumnID == EstimationTaskColumnsMasterID);
        }
        public void AddEstimationTaskColumnsMasters(params EstimationTaskColumnsMaster[] EstimationTaskColumnsMaster)
        {
            try
            {
                _estimationTaskColumnsMaster.Add(EstimationTaskColumnsMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateEstimationTaskColumnsMasters(params EstimationTaskColumnsMaster[] EstimationTaskColumnsMaster)
        {
            try
            {
                _estimationTaskColumnsMaster.Update(EstimationTaskColumnsMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveEstimationTaskColumnsMasters(params EstimationTaskColumnsMaster[] EstimationTaskColumnsMaster)
        {
            try
            {
                _estimationTaskColumnsMaster.Remove(EstimationTaskColumnsMaster);
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
        public void ReArrangeDisplayOrderEstimationTaskColumnsMaster(int EstimationColID, int DisplayOrder, int vTemplateID, int ProjectID)
        {
            try
            {
                //List<EstimationTaskColumnsMaster> lst = null;
                //List<EstimationColSettingTemplateDetail> lsttemp = null;
                //BLEstimationColSettingTemplateDetail blcoltemp = new BLEstimationColSettingTemplateDetail();

                //if (vTemplateID == 0)
                //{
                //    lst = GetAllEstimationTaskColumnsMasters().Where(a => a.ProjectID == ProjectID && a.DisplayOrder == DisplayOrder).ToList();
                //}
                //else
                //{
                //    lsttemp = blcoltemp.GetAllEstimationColSettingTemplateDetail().Where(a => a.ProjectID == ProjectID && a.DisplayOrder == DisplayOrder).ToList();
                //}

                //if (lst != null)
                //{
                //    foreach (var ecol in lst)
                //    {
                //        ecol.DisplayOrder = Convert.ToInt32(ecol.DisplayOrder) - 1;
                //        ecol.EntityState = DominModel.EntityState.Modified;
                //    }

                //    _estimationTaskColumnsMaster.Update(lst.ToArray());

                //}
                //else if (lsttemp != null)
                //{
                //    foreach (var t in lsttemp)
                //    {
                //        t.DisplayOrder = Convert.ToInt32(t.DisplayOrder) - 1;
                //        t.EntityState = EntityState.Modified;
                //    }

                //    blcoltemp.UpdateEstimationColSettingTemplate(lsttemp.ToArray());
                //}

            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
        public bool checkDuplicateFieldName(string FieldName, int NormsColumnID)
        {
            int cnt = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    cnt = context.EstimationTaskColumnsMasters.Where(a => a.DisplayColName.StartsWith(FieldName) && a.DisplayColName.EndsWith(FieldName) && a.EstimationTaskColumnID != NormsColumnID).Count();
            //}
            if (cnt > 0)
                return true;
            else
                return false;
        }
        public int GetMaxDiplayNumber(int ProjectID)
        {
            int maxdisplay = 0;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    maxdisplay = (from t in context.EstimationTaskColumnsMasters
            //                  where t.ProjectID == ProjectID
            //                  orderby t.DisplayOrder descending
            //                  select (t.DisplayOrder)).FirstOrDefault();
            //}
            return maxdisplay + 1;
        }

        public int GetInvolvedDesignationEstimationSettingByProjectID(int ProjectID)
        {
            int RecordCount = 0;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    RecordCount = (from t in context.EstimationTaskColumnsMasters
            //                   where t.ProjectID == ProjectID && t.DBColPkID > 0
            //                   select (t.DBColPkID)).Count();
            //}
            return RecordCount;
        }
        public bool checkDuplicateNameInDb(string NameInDb, int EstimationTaskColumnID)
        {
            int cnt = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    cnt = context.EstimationTaskColumnsMasters.Where(a => a.NameInDb.StartsWith(NameInDb) && a.NameInDb.EndsWith(NameInDb) && a.EstimationTaskColumnID != EstimationTaskColumnID).Count();
            //    cnt = cnt + context.NormsColumnsMasters.Where(a => a.NameInDb.StartsWith(NameInDb) && a.NameInDb.EndsWith(NameInDb)).Count();
            //}
            if (cnt > 0)
                return true;
            else
                return false;
        }

        public List<string> getAllNameInDb(int ProjectID)
        {
            List<string> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.EstimationTaskColumnsMasters.Where(a => a.ProjectID == ProjectID).Select(a => a.NameInDb).ToList<string>();
            //}

            return result;
        }

        public List<EstimationTaskColumnsMaster> getDisplayColNameInDb(int ProjectID, int MasterTaskTypeID)
        {
            List<EstimationTaskColumnsMaster> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = (from a in context.EstimationTaskColumnsMasters
            //              where a.DisplayInGrid == "Y" && a.PermanentNameInDb != "TaskProgressLevels" && a.ProjectID == ProjectID && a.MasterTaskTypeID == MasterTaskTypeID
            //              orderby a.DisplayOrder

            //              select a).ToList<EstimationTaskColumnsMaster>();

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

        public int getEstimationTaskColumnIdbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int ProjectID)
        {
            int columnID = 0;
            try
            {
                string str = "SELECT EstimationTaskColumnID FROM EstimationTaskColumnsMaster WHERE " + SqlTableColumnName + "='" + SqlTableColumnValue + "' and ProjectID=" + ProjectID;
                columnID = Convert.ToInt32(ExecuteSql(str));
            }
            catch (Exception ex)
            {
            }

            return columnID;
        }




        public List<usp_GetAllEstimationTaskColumnsMasters_Result> GetAllEstimationTaskColumnsMastersWithNormColumnName(int ProjectID)
        {
            List<usp_GetAllEstimationTaskColumnsMasters_Result> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.usp_GetAllEstimationTaskColumnsMasters(ProjectID).ToList<usp_GetAllEstimationTaskColumnsMasters_Result>();
            //}

            return result;
        }

        public int saveEstimationColSettingTemplate(EstimationColSettingTemplate EstimationColSettingTemplate)
        {
            int result = 0;

            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        BLEstimationColSettingTemplate _EstimationColSettingTemplate = new BLEstimationColSettingTemplate();
            //        result = _EstimationColSettingTemplate.getAddEstimationColSettingTemplate(EstimationColSettingTemplate);
            //        ts.Complete();
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}

            return result;
        }

        public int getDbColPkIDbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int ProjectID)
        {
            int columnID = 0;
            try
            {
                string str = "SELECT DBColPkID FROM EstimationTaskColumnsMaster WHERE " + SqlTableColumnName + "='" + SqlTableColumnValue + "' and ProjectID=" + ProjectID;
                string res = ExecuteSql(str);
                columnID = Convert.ToInt32(res == "" ? "0" : res);
            }
            catch (Exception ex)
            {
            }

            return columnID;
        }

        //public void AddProcurementDocumentColumnsMaster(params ProcurementDocumentColumnsMaster[] EstimationTaskColumnsMaster)
        //{
        //    try
        //    {
        //        _estimationTaskColumnsMaster.Add(EstimationTaskColumnsMaster);
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        throw new Exception("Record not added.");
        //    }
        //}


        #region "Method added for slick implementation"


        public List<object> GetEstimationTemplateDetailByTemplateID(int TemplateID)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.EstimationColSettingTemplateDetails
            //           join r in context.Designations on q.DBColPkID equals r.DesignationID into dt
            //           from s in dt.DefaultIfEmpty()
            //           where q.EstimationColSettingTemplateID == TemplateID
            //           select new
            //           {
            //               id = q.EstimationColSettingTemplateDetailID,
            //               q.EstimationColSettingTemplateDetailID,
            //               q.EstimationColSettingTemplateID,
            //               q.EstimationTaskColumnID,
            //               q.IsDbField,
            //               IsDbFieldName = q.IsDbField == "Y" ? "Yes" : "No",
            //               q.DisplayColName,
            //               q.DBColName,
            //               q.DBFKID,
            //               q.TableName,
            //               q.DisplayOrder,
            //               //q.DataType,
            //               DataType = q.InputOutput == "Output" ? "Output" : q.IsDropDown == "Y" ? "Dropdown" : q.DBColPkID > 0 ? "Desg.ManHours" : q.DataType,
            //               q.InputOutput,
            //               q.EquationID,
            //               q.DisplayInGrid,
            //               DisplayInGridName = q.DisplayInGrid == "Y" ? "Yes" : "No",
            //               q.IsDropDown,
            //               IsDropDownName = q.IsDropDown == "Y" ? "Yes" : "No",
            //               q.NameInDb,
            //               q.IsMandatory,
            //               IsMandatoryName = q.IsMandatory == "Y" ? "Yes" : "No",
            //               q.IsPkField,
            //               q.IsSearchField,
            //               q.DBColPkID,
            //               NormsDisplayColName = s.DesignationName,
            //               q.AllowDelete,
            //               q.FilterColumn,
            //               q.ProjectTaskListColumn,
            //               q.ValidationMessage,
            //               q.DefaultValue,
            //               q.DependonNorms,
            //               DependonNormsName = q.DependonNorms == "Y" ? "Yes" : "No",
            //               q.ProjectID
            //           }).OrderBy(c => c.DisplayOrder).ToList<object>();

            //}
            return lst;
        }


        public List<object> GetEstimationTemplateDetailByTemplateID(int TemplateID, int companyid)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.EstimationColSettingTemplateDetails
            //           join r in context.Designations on q.DBColPkID equals r.DesignationID into dt
            //           from s in dt.DefaultIfEmpty()
            //           where q.EstimationColSettingTemplateID == TemplateID && (companyid==0?q.CompanyId==null:q.CompanyId==companyid)
            //           select new
            //           {
            //               id = q.EstimationColSettingTemplateDetailID,
            //               q.EstimationColSettingTemplateDetailID,
            //               q.EstimationColSettingTemplateID,
            //               q.EstimationTaskColumnID,
            //               q.IsDbField,
            //               IsDbFieldName = q.IsDbField == "Y" ? "Yes" : "No",
            //               q.DisplayColName,
            //               q.DBColName,
            //               q.DBFKID,
            //               q.TableName,
            //               q.DisplayOrder,
            //               //q.DataType,
            //               DataType = q.InputOutput == "Output" ? "Output" : q.IsDropDown == "Y" ? "Dropdown" : q.DBColPkID > 0 ? "Desg.ManHours" : q.DataType,
            //               q.InputOutput,
            //               q.EquationID,
            //               q.DisplayInGrid,
            //               DisplayInGridName = q.DisplayInGrid == "Y" ? "Yes" : "No",
            //               q.IsDropDown,
            //               IsDropDownName = q.IsDropDown == "Y" ? "Yes" : "No",
            //               q.NameInDb,
            //               q.IsMandatory,
            //               IsMandatoryName = q.IsMandatory == "Y" ? "Yes" : "No",
            //               q.IsPkField,
            //               q.IsSearchField,
            //               q.DBColPkID,
            //               NormsDisplayColName = s.DesignationName,
            //               q.AllowDelete,
            //               q.FilterColumn,
            //               q.ProjectTaskListColumn,
            //               q.ValidationMessage,
            //               q.DefaultValue,
            //               q.DependonNorms,
            //               DependonNormsName = q.DependonNorms == "Y" ? "Yes" : "No",
            //               q.ProjectID
            //           }).OrderBy(c => c.DisplayOrder).ToList<object>();

             

            //}
            return lst;
        }

        public List<object> GetAllEstTaskColMastersByProjectID(int projectID, int MasterTaskType)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.EstimationTaskColumnsMasters
            //           join r in context.Designations on q.DBColPkID equals r.DesignationID into dt
            //           from s in dt.DefaultIfEmpty()
            //           where q.ProjectID == projectID && q.MasterTaskTypeID == MasterTaskType
            //           select new
            //           {
            //               id = q.EstimationTaskColumnID,
            //               q.IsDbField,
            //               IsDbFieldName = q.IsDbField == "Y" ? "Yes" : "No",
            //               q.DisplayColName,
            //               q.DBColName,
            //               q.DBFKID,
            //               q.TableName,
            //               q.DisplayOrder,
            //               DataType = q.InputOutput == "Output" ? "Output" : q.IsDropDown == "Y" ? "Dropdown" : q.DBColPkID > 0 ? "Desg.ManHours" : q.DataType,
            //               q.InputOutput,
            //               q.EquationID,
            //               q.DisplayInGrid,
            //               DisplayInGridName = q.DisplayInGrid == "Y" ? "Yes" : "No",
            //               q.IsDropDown,
            //               IsDropDownName = q.IsDropDown == "Y" ? "Yes" : "No",
            //               q.NameInDb,
            //               q.IsMandatory,
            //               IsMandatoryName = q.IsMandatory == "Y" ? "Yes" : "No",
            //               q.IsPkField,
            //               q.IsSearchField,
            //               q.DBColPkID,
            //               NormsDisplayColName = s.DesignationName,
            //               q.AllowDelete,
            //               q.FilterColumn,
            //               q.ProjectTaskListColumn,
            //               q.ValidationMessage,
            //               q.DefaultValue,
            //               q.DependonNorms,
            //               DependonNormsName = q.DependonNorms == "Y" ? "Yes" : "No",
            //               q.ProjectID,
            //               q.Equationvalidation,
            //               q.PermanentNameInDb
            //           }).OrderBy(x => x.DisplayOrder).ToList<object>();

            //}
            return lst;
        }

        public List<object> GetAllEstTaskColMastersByProjectID(int projectID)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.EstimationTaskColumnsMasters
            //           join r in context.Designations on q.DBColPkID equals r.DesignationID into dt
            //           from s in dt.DefaultIfEmpty()
            //           where q.ProjectID == projectID 
            //           select new
            //           {
            //               id = q.EstimationTaskColumnID,
            //               q.IsDbField,
            //               IsDbFieldName = q.IsDbField == "Y" ? "Yes" : "No",
            //               q.DisplayColName,
            //               q.DBColName,
            //               q.DBFKID,
            //               q.TableName,
            //               q.DisplayOrder,
            //               DataType = q.InputOutput == "Output" ? "Output" : q.IsDropDown == "Y" ? "Dropdown" : q.DBColPkID > 0 ? "Desg.ManHours" : q.DataType,
            //               q.InputOutput,
            //               q.EquationID,
            //               q.DisplayInGrid,
            //               DisplayInGridName = q.DisplayInGrid == "Y" ? "Yes" : "No",
            //               q.IsDropDown,
            //               IsDropDownName = q.IsDropDown == "Y" ? "Yes" : "No",
            //               q.NameInDb,
            //               q.IsMandatory,
            //               IsMandatoryName = q.IsMandatory == "Y" ? "Yes" : "No",
            //               q.IsPkField,
            //               q.IsSearchField,
            //               q.DBColPkID,
            //               NormsDisplayColName = s.DesignationName,
            //               q.AllowDelete,
            //               q.FilterColumn,
            //               q.ProjectTaskListColumn,
            //               q.ValidationMessage,
            //               q.DefaultValue,
            //               q.DependonNorms,
            //               DependonNormsName = q.DependonNorms == "Y" ? "Yes" : "No",
            //               q.ProjectID,
            //               q.Equationvalidation,
            //               q.PermanentNameInDb
            //           }).OrderBy(x => x.DisplayOrder).ToList<object>();

            //}
            return lst;
        }

        public bool applySettingTaskTemplate(List<EstimationTaskColumnsMaster> TemplateData, int ProjectID, int UserID, int MasterTaskType = 1)
        {
            bool status = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //        List<EstimationTaskColumnsMaster> lstPrev = ((from q in blObj.GetAllEstimationTaskColumnsMastersByProjectID(ProjectID, MasterTaskType)
            //                                                      where q.ProjectID == ProjectID
            //                                                      select q).Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; })).ToList<EstimationTaskColumnsMaster>();
            //        blObj.RemoveEstimationTaskColumnsMasters(lstPrev.ToArray());

            //        //TemplateData = TemplateData.Select(x => { x.EntityState = DominModel.EntityState.Added; return x; }).ToList<EstimationTaskColumnsMaster>();
            //        blObj.AddEstimationTaskColumnsMasters(TemplateData.ToArray());

            //        ts.Complete();
            //        status = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        status = false;
            //        ts.Dispose();
            //    }

            //}

            return status;
        }

        public List<object> GetEqnEstTaskColMastersByProjectID(int projectID)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.EstimationTaskColumnsMasters
            //           where q.ProjectID == projectID && (q.EquationID != null || q.Equationvalidation != null)
            //           select new
            //           {
            //               id = q.EstimationTaskColumnID,
            //               q.EquationID,
            //               q.NameInDb,
            //               q.DBColPkID,
            //               q.ValidationMessage,
            //               q.DefaultValue,
            //               q.Equationvalidation,
            //           }).ToList<object>();

            //}
            return lst;
        }


        public EstimationTaskColumnsMaster GetLastUsedBufferColoumnETCM(int projectid, string datatype, int? MasterTaskTypeID)
        {

            EstimationTaskColumnsMaster estcol = new EstimationTaskColumnsMaster();

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    estcol = context.EstimationTaskColumnsMasters.Where(a => a.ProjectID == projectid && a.ProjectTaskListColumn.Contains(datatype) && a.MasterTaskTypeID == MasterTaskTypeID).OrderByDescending(x => x.EstimationTaskColumnID).FirstOrDefault();
            //}

            return estcol;
        }

        public List<EstimationTaskColumnsMaster> GetLastUsedBufferColoumnETCM(int? projectid, string datatype, int? MasterTaskTypeID)
        {

            List<EstimationTaskColumnsMaster> estcol = new List<EstimationTaskColumnsMaster>();

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    estcol = context.EstimationTaskColumnsMasters.Where(x => x.ProjectID == projectid && x.ProjectTaskListColumn.Contains(datatype) && x.MasterTaskTypeID == MasterTaskTypeID).ToList();
            //}

            return estcol;


        }


        public List<object> GetAllProcurementColMastersByProjectID(int projectID, int MilestoneID)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.ProcurementDocumentColumnsMasters
            //           where q.ProjectID == projectID && q.MilestoneID == MilestoneID
            //           select new
            //           {
            //               id = q.ProcurementDocumentColumnID,
            //               q.IsDbField,
            //               IsDbFieldName = q.IsDbField == "Y" ? "Yes" : "No",
            //               q.DisplayColName,
            //               q.DBColName,
            //               q.DBFKID,
            //               q.TableName,
            //               q.DisplayOrder,
            //               DataType = q.InputOutput == "Output" ? "Output" : q.IsDropDown == "Y" ? "Dropdown" : q.DBColPkID > 0 ? "Desg.ManHours" : q.DataType,
            //               q.InputOutput,
            //               q.EquationID,
            //               q.DisplayInGrid,
            //               DisplayInGridName = q.DisplayInGrid == "Y" ? "Yes" : "No",
            //               q.IsDropDown,
            //               IsDropDownName = q.IsDropDown == "Y" ? "Yes" : "No",
            //               q.NameInDb,
            //               q.IsMandatory,
            //               IsMandatoryName = q.IsMandatory == "Y" ? "Yes" : "No",
            //               q.IsPkField,
            //               q.IsSearchField,
            //               q.DBColPkID,
            //               q.AllowDelete,
            //               q.FilterColumn,
            //               q.ProjectTaskListColumn,
            //               q.ValidationMessage,
            //               q.DefaultValue,
            //               q.DependonNorms,
            //               DependonNormsName = q.DependonNorms == "Y" ? "Yes" : "No",
            //               q.ProjectID,
            //               q.MilestoneID,
            //               q.Equationvalidation,
            //               q.PermanentNameInDb
            //           }).OrderBy(x => x.DisplayOrder).ToList<object>();

            //}
            return lst;
        }       

        #endregion





    }
}
