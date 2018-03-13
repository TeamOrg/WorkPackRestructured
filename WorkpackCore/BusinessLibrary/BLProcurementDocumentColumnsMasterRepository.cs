using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public class BLProcurementDocumentColumnsMasterRepository : IBLProcurementDocumentColumnsMasterRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProcurementDocumentColumnsMaster> _procurementDocumentColumnsMaster;

        public BLProcurementDocumentColumnsMasterRepository(WorkpackDBContext context, IGenericDataRepository<ProcurementDocumentColumnsMaster> procurementDocumentColumnsMaster)
        {
            _context = context;
            _procurementDocumentColumnsMaster = procurementDocumentColumnsMaster;
        }
        public IList<ProcurementDocumentColumnsMaster> GetAllProcurementDocumentColumnsMasters()
        {
            return _procurementDocumentColumnsMaster.GetAll();
        }
        public IList<ProcurementDocumentColumnsMaster> GetAllProcurementDocumentColumnsMastersByProjectID(int ProjectID, int Milestoneid)
        {
            IList<ProcurementDocumentColumnsMaster> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.ProcurementDocumentColumnsMasters.Where(a => a.ProjectID == ProjectID && a.MilestoneID == Milestoneid).ToList<ProcurementDocumentColumnsMaster>();
                //}
            }
            catch (Exception ex)
            {
            }

            return list;
        }

        public IList<EstimationColSettingTemplateDetail> GetAllProcurementDocumentColumnsByTemplateID(int TemplateId)
        {
            IList<EstimationColSettingTemplateDetail> list = null;
            try
            {
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        list = context.EstimationColSettingTemplateDetails.Where(a => a.EstimationColSettingTemplateID == TemplateId && a.DisplayInGrid == "Y").ToList();
            //    }
            }
            catch (Exception ex)
            {
            }

            return list;
        }



        public DataTable GetAllDesignationProcurementDocumentColumnsMastersByProjectID(int ProjectID, string IsManHoursDisable)
        {
            IList<ProcurementDocumentColumnsMaster> list = null;
            DataTable dt = null;
            try
            {
                //dt.TableName = "SubmitProcurementDocument";
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
                //        list = context.ProcurementDocumentColumnsMasters.Where(a => a.ProjectID == ProjectID && a.DBColPkID > 0).ToList<ProcurementDocumentColumnsMaster>();
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

        public dynamic rearrengebuffercoloummapping(int vid)
        {
            dynamic i = 0;


            //BLProcurementDocumentColumnsMasterRepository blObj = new BLProcurementDocumentColumnsMasterRepository();
            //ProcurementDocumentColumnsMaster item = blObj.GetProcurementDocumentColumnsMasterByID(vid);
            //string data = "";
            //if (item.DataType.Contains("Unique"))
            //{

            //    data = item.DataType.Substring(6);
            //}
            //else
            //{

            //    data = item.DataType;
            //}
            //List<ProcurementDocumentColumnsMaster> lst = blObj.GetLastUsedBufferColoumnETCM(GeneralFuntions.ToNullableInt32(Convert.ToString(item.ProjectID)), GeneralFuntions.ToNullableInt32(Convert.ToString(item.MilestoneID)), data);
            //string[] name = item.ProjectTaskListColumn.Split('_');
            //foreach (ProcurementDocumentColumnsMaster a in lst)
            //{
            //    if (name.Length > 1)
            //    {
            //        if (Convert.ToInt32(a.ProjectTaskListColumn.Split('_')[1]) > Convert.ToInt32(item.ProjectTaskListColumn.Split('_')[1]))
            //        {

            //            a.ProjectTaskListColumn = a.ProjectTaskListColumn.Split('_')[0] + "_" + Convert.ToString((Convert.ToInt32(a.ProjectTaskListColumn.Split('_')[1]) - 1));
            //            a.PermanentNameInDb = a.PermanentNameInDb.Split('_')[0] + "_" + Convert.ToString((Convert.ToInt32(a.PermanentNameInDb.Split('_')[1]) - 1));

            //            a.EntityState = DominModel.EntityState.Modified;
            //            blObj.UpdateProcurementDocumentColumnsMasters(a);
            //        }
            //    }
            //}

            //i = item;
            return i;


        }
        public ProcurementDocumentColumnsMaster GetProcurementDocumentColumnsMasterByName(string ProcurementDocumentColumnsMasterName)
        {
            return _procurementDocumentColumnsMaster.GetSingle(d => d.DisplayColName == ProcurementDocumentColumnsMasterName);
        }


        public ProcurementDocumentColumnsMaster GetProcurementDocumentColumnsMasterByID(int ProcurementDocumentColumnsMasterID)
        {
            return _procurementDocumentColumnsMaster.GetSingle(d => d.ProcurementDocumentColumnID == ProcurementDocumentColumnsMasterID);
        }
        public void AddProcurementDocumentColumnsMasters(params ProcurementDocumentColumnsMaster[] ProcurementDocumentColumnsMaster)
        {
            try
            {
                _procurementDocumentColumnsMaster.Add(ProcurementDocumentColumnsMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProcurementDocumentColumnsMasters(params ProcurementDocumentColumnsMaster[] ProcurementDocumentColumnsMaster)
        {
            try
            {
                _procurementDocumentColumnsMaster.Update(ProcurementDocumentColumnsMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProcurementDocumentColumnsMasters(params ProcurementDocumentColumnsMaster[] ProcurementDocumentColumnsMaster)
        {
            try
            {
                _procurementDocumentColumnsMaster.Remove(ProcurementDocumentColumnsMaster);
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
        public void ReArrangeDisplayOrderProcurementDocumentColumnsMaster(int EstimationColID, int DisplayOrder, int ProjectID, int MilestoneID)
        {
            try
            {
                //List<ProcurementDocumentColumnsMaster> lst = null;
                //List<EstimationColSettingTemplateDetail> lsttemp = null;
                //BLEstimationColSettingTemplateDetail blcoltemp = new BLEstimationColSettingTemplateDetail();


                //lst = GetAllProcurementDocumentColumnsMasters().Where(a => a.ProjectID == ProjectID && a.MilestoneID == MilestoneID && a.DisplayOrder > DisplayOrder).ToList();


                //if (lst != null)
                //{
                //    foreach (var ecol in lst)
                //    {
                //        ecol.DisplayOrder = Convert.ToInt32(ecol.DisplayOrder) - 1;
                //        ecol.EntityState = EntityState.Modified;
                //    }

                //    _procurementDocumentColumnsMaster.Update(lst.ToArray());

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
            //    cnt = context.ProcurementDocumentColumnsMasters.Where(a => a.DisplayColName.StartsWith(FieldName) && a.DisplayColName.EndsWith(FieldName) && a.ProcurementDocumentColumnID != NormsColumnID).Count();
            //}
            if (cnt > 0)
                return true;
            else
                return false;
        }
        public int GetMaxDiplayNumber(int ProjectID)
        {
            int? maxdisplay = 0;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    maxdisplay = (from t in context.ProcurementDocumentColumnsMasters
            //                  where t.ProjectID == ProjectID
            //                  orderby t.DisplayOrder descending
            //                  select (t.DisplayOrder)).FirstOrDefault();
            //}
            return Convert.ToInt32(maxdisplay) + 1;
        }

        public int GetInvolvedDesignationEstimationSettingByProjectID(int ProjectID)
        {
            int RecordCount = 0;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    RecordCount = (from t in context.ProcurementDocumentColumnsMasters
            //                   where t.ProjectID == ProjectID && t.DBColPkID > 0
            //                   select (t.DBColPkID)).Count();
            //}
            return RecordCount;
        }
        public bool checkDuplicateNameInDb(string NameInDb, int ProcurementDocumentColumnID)
        {
            int cnt = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    cnt = context.ProcurementDocumentColumnsMasters.Where(a => a.NameInDb.StartsWith(NameInDb) && a.NameInDb.EndsWith(NameInDb) && a.ProcurementDocumentColumnID != ProcurementDocumentColumnID).Count();
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
            //    result = context.ProcurementDocumentColumnsMasters.Where(a => a.ProjectID == ProjectID).Select(a => a.NameInDb).ToList<string>();
            //}

            return result;
        }

        public List<ProcurementDocumentColumnsMaster> getDisplayColNameInDb(int ProjectID, int MasterTaskTypeID)
        {
            List<ProcurementDocumentColumnsMaster> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = (from a in context.ProcurementDocumentColumnsMasters
            //              where a.DisplayInGrid == "Y" && a.PermanentNameInDb != "TaskProgressLevels" && a.ProjectID == ProjectID && a.MasterTaskTypeID == MasterTaskTypeID
            //              orderby a.DisplayOrder

            //              select a).ToList<ProcurementDocumentColumnsMaster>();

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

        public int getProcurementDocumentColumnIdbySqlTableFieldNameAndValue(string SqlTableColumnName, string SqlTableColumnValue, int ProjectID)
        {
            int columnID = 0;
            try
            {
                string str = "SELECT ProcurementDocumentColumnID FROM ProcurementDocumentColumnsMaster WHERE " + SqlTableColumnName + "='" + SqlTableColumnValue + "' and ProjectID=" + ProjectID;
                columnID = Convert.ToInt32(ExecuteSql(str));
            }
            catch (Exception ex)
            {
            }

            return columnID;
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
                string str = "SELECT DBColPkID FROM ProcurementDocumentColumnsMaster WHERE " + SqlTableColumnName + "='" + SqlTableColumnValue + "' and ProjectID=" + ProjectID;
                string res = ExecuteSql(str);
                columnID = Convert.ToInt32(res == "" ? "0" : res);
            }
            catch (Exception ex)
            {
            }

            return columnID;
        }

        //public void AddProcurementDocumentColumnsMaster(params ProcurementDocumentColumnsMaster[] ProcurementDocumentColumnsMaster)
        //{
        //    try
        //    {
        //        _procurementDocumentColumnsMaster.Add(ProcurementDocumentColumnsMaster);
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        throw new Exception("Record not added.");
        //    }
        //}


        #region "Method added for slick implementation"




        public List<object> GetAllEstTaskColMastersByProjectID(int projectID, int MasterTaskType)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.ProcurementDocumentColumnsMasters
            //           join r in context.Designations on q.DBColPkID equals r.DesignationID into dt
            //           from s in dt.DefaultIfEmpty()
            //           where q.ProjectID == projectID && q.MasterTaskTypeID == MasterTaskType
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
            //    lst = (from q in context.ProcurementDocumentColumnsMasters
            //           join r in context.Designations on q.DBColPkID equals r.DesignationID into dt
            //           from s in dt.DefaultIfEmpty()
            //           where q.ProjectID == projectID
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

        public bool applySettingTaskTemplate(List<ProcurementDocumentColumnsMaster> TemplateData, int ProjectID, int UserID, int MasterTaskType = 1)
        {
            bool status = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        BLProcurementDocumentColumnsMasterRepository blObj = new BLProcurementDocumentColumnsMasterRepository();
            //        List<ProcurementDocumentColumnsMaster> lstPrev = ((from q in blObj.GetAllProcurementDocumentColumnsMastersByProjectID(ProjectID, MasterTaskType)
            //                                                           where q.ProjectID == ProjectID
            //                                                           select q).Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; })).ToList<ProcurementDocumentColumnsMaster>();
            //        blObj.RemoveProcurementDocumentColumnsMasters(lstPrev.ToArray());

            //        //TemplateData = TemplateData.Select(x => { x.EntityState = DominModel.EntityState.Added; return x; }).ToList<ProcurementDocumentColumnsMaster>();
            //        blObj.AddProcurementDocumentColumnsMasters(TemplateData.ToArray());

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
            //    lst = (from q in context.ProcurementDocumentColumnsMasters
            //           where q.ProjectID == projectID && (q.EquationID != null || q.Equationvalidation != null)
            //           select new
            //           {
            //               id = q.ProcurementDocumentColumnID,
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


        public ProcurementDocumentColumnsMaster GetLastUsedBufferColoumnETCM(int projectid, int? MilestoneID, string datatype)
        {

            ProcurementDocumentColumnsMaster estcol = new ProcurementDocumentColumnsMaster();

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    estcol = context.ProcurementDocumentColumnsMasters.Where(a => a.ProjectID == projectid && a.MilestoneID == MilestoneID && a.ProjectTaskListColumn.Contains(datatype)).OrderByDescending(x => x.ProcurementDocumentColumnID).FirstOrDefault();
            //}

            return estcol;
        }

        public List<ProcurementDocumentColumnsMaster> GetLastUsedBufferColoumnETCM(int? projectid, int? MilestoneID, string datatype)
        {

            List<ProcurementDocumentColumnsMaster> estcol = new List<ProcurementDocumentColumnsMaster>();

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    estcol = context.ProcurementDocumentColumnsMasters.Where(x => x.ProjectID == projectid && x.MilestoneID == MilestoneID && x.ProjectTaskListColumn.Contains(datatype)).ToList();
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


        public OperationResult getMaterialTrackingData(int ProjectID, int DeliverableID, int MilestoneID, int RevisionID)
        {
            OperationResult obj = new OperationResult();
            List<object> list = null;
            int nProjectID = Convert.ToInt32(ProjectID);
            int nMilestoneID = Convert.ToInt32(MilestoneID);
            int nDeliverableID = Convert.ToInt32(DeliverableID);

            ////BLTaskListRepository blTask = new BLTaskListRepository();
            ////nProjectID = blTask.GetTaskListByProjectTaskID(Convert.ToInt32(DeliverableID)).Select(x => x.ProjectID).FirstOrDefault();

            try
            {



                //using (var con = new Cubicle_EntityEntities())
                //{

                //    int UserID = 0, ProjectLeader = 0, ProjectAdmin = 0, TaskOwner = 0;
                //    if (!UserSession.UserID.Contains("@"))
                //    {

                //        UserID = Convert.ToInt32(UserSession.UserID);

                //        ProjectLeader = (from n in con.Projects
                //                         where n.ProjectID == nProjectID && n.ProjectLeader == UserID
                //                         select n.ProjectLeader).Count();

                //        ProjectAdmin = (from n in con.ProjectsAdmins
                //                        where n.ProjectID == nProjectID && n.UserID == UserID
                //                        select n.UserID).Count();

                //        TaskOwner = (from n in con.ProjectTaskLists
                //                     where n.ProjectTaskID == nDeliverableID && n.TaskOwner == UserID
                //                     select n.TaskOwner).Count();
                //    }


                //    int FileChecker = (from n in con.UploadDeliverableFiles
                //                       join m in con.FileCheckers on n.UploadDeliverableFileID equals m.UploadDeliverableFileID
                //                       where n.DeliverableListID == nDeliverableID && n.MilestoneID == nMilestoneID && m.UserID == UserSession.UserID
                //                       select m.UserID
                //                           ).Count();

                //    int StakeHolder = (from n in con.MilestonesStakeHolders
                //                       where n.UserID == UserSession.UserID && (n.MilestoneID == nMilestoneID && n.Flag == "MS") || (n.TaskID == nDeliverableID && n.MilestoneID == nMilestoneID && n.Flag == "DS")
                //                       select n
                //                           ).Count();


                //    var lstTaskList = (from n in con.ProjectTaskLists
                //                       where n.ProjectID == nProjectID
                //                       select new
                //                       {
                //                           TaskID = n.ProjectTaskID,
                //                           TaskName = n.TaskName
                //                       }).ToList();
                //    obj.list.Add(lstTaskList.ToList<object>());



                //    //var lstColumnSetting = (from n in con.EstimationTaskColumnsMasters
                //    //                        join m in con.MaterialdetailsColumns on n.EstimationTaskColumnID equals m.EstimationTaskColumnID
                //    //                        where m.ProjectID == nProjectID && m.MilestoneID == nMilestoneID
                //    //                        && ((ProjectLeader > 0 || ProjectAdmin > 0 ? m.ProjectAdminRights != "Hide" : 1 != 1)
                //    //                        || (TaskOwner > 0 || StakeHolder > 0 ? m.OwnerRights != "Hide" : 1 != 1)
                //    //                        || (FileChecker > 0 ? m.RecipientRights != "Hide" : 1 != 1))
                //    //                        select n).ToList();


                //    var lstColumnSetting = (from n in con.EstimationTaskColumnsMasters
                //                            join m in con.MaterialdetailsColumns on new { a = n.EstimationTaskColumnID, b = n.ProjectID } equals new { a = (int)m.EstimationTaskColumnID, b = m.ProjectID }
                //                            where ((ProjectLeader > 0 || ProjectAdmin > 0 ? m.ProjectAdminRights != "Hide" : 1 != 1)
                //                                    || (TaskOwner > 0 || StakeHolder > 0 ? m.OwnerRights != "Hide" : 1 != 1)
                //                                    || (FileChecker > 0 ? m.RecipientRights != "Hide" : 1 != 1))
                //                            select n).ToList();

                //    var lstMaterialdetailsColumns = (from n in con.EstimationTaskColumnsMasters
                //                                     join m in con.MaterialdetailsColumns on new { a = n.EstimationTaskColumnID, b = n.ProjectID } equals new { a = (int)m.EstimationTaskColumnID, b = m.ProjectID }
                //                                     where ((ProjectLeader > 0 || ProjectAdmin > 0 ? m.ProjectAdminRights != "Hide" : 1 != 1)
                //                                             || (TaskOwner > 0 || StakeHolder > 0 ? m.OwnerRights != "Hide" : 1 != 1)
                //                                             || (FileChecker > 0 ? m.RecipientRights != "Hide" : 1 != 1))
                //                                     select m).ToList();


                //    BLEstimationTaskDetailRepository blEstimationTaskDet = new BLEstimationTaskDetailRepository();

                //    List<NormsManageTableColumnData> lstNormsManageTableColumn = blEstimationTaskDet.getNormsManageTableColumn().ToList<NormsManageTableColumnData>();

                //    var ch = lstColumnSetting.Where(x => x.EstimationTaskColumnID == 19690);
                //    List<SlickGridMaterialTrackingColumns> lstcolumn = new List<SlickGridMaterialTrackingColumns>();
                //    foreach (var item in lstColumnSetting)
                //    {

                //        // commented for error in populatimg form of edit material details
                //        //if (item.DisplayInGrid == "Y")
                //        //{
                //        int EditRight = 0;

                //        //if (ProjectLeader > 0 || ProjectAdmin > 0)
                //        //{
                //        //    EditRight = (from n in con.MaterialdetailsColumns
                //        //                 where n.EstimationTaskColumnID == item.EstimationTaskColumnID && n.MilestoneID == nMilestoneID && n.ProjectAdminRights == "Edit"
                //        //                 select n).Count();
                //        //}
                //        //if ((TaskOwner > 0 || StakeHolder > 0) && EditRight == 0)
                //        //{
                //        //    EditRight = (from n in con.MaterialdetailsColumns
                //        //                 where n.EstimationTaskColumnID == item.EstimationTaskColumnID && n.MilestoneID == nMilestoneID && n.OwnerRights == "Edit"
                //        //                 select n).Count();
                //        //}
                //        //if (FileChecker > 0 && EditRight == 0)
                //        //{
                //        //    EditRight = (from n in con.MaterialdetailsColumns
                //        //                 where n.EstimationTaskColumnID == item.EstimationTaskColumnID && n.MilestoneID == nMilestoneID && n.RecipientRights == "Edit"
                //        //                 select n).Count();
                //        //}

                //        //var InputOutputType = (from n in con.MaterialdetailsColumns
                //        //                       where n.EstimationTaskColumnID == item.EstimationTaskColumnID && n.MilestoneID == nMilestoneID
                //        //                       select n.Type).FirstOrDefault();



                //        if (ProjectLeader > 0 || ProjectAdmin > 0)
                //        {
                //            EditRight = (from n in con.MaterialdetailsColumns
                //                         where n.EstimationTaskColumnID == item.EstimationTaskColumnID && n.ProjectAdminRights == "Edit"
                //                         select n).Count();
                //        }
                //        if ((TaskOwner > 0 || StakeHolder > 0) && EditRight == 0)
                //        {
                //            EditRight = (from n in con.MaterialdetailsColumns
                //                         where n.EstimationTaskColumnID == item.EstimationTaskColumnID && n.OwnerRights == "Edit"
                //                         select n).Count();
                //        }
                //        if (FileChecker > 0 && EditRight == 0)
                //        {
                //            EditRight = (from n in con.MaterialdetailsColumns
                //                         where n.EstimationTaskColumnID == item.EstimationTaskColumnID && n.RecipientRights == "Edit"
                //                         select n).Count();
                //        }

                //        var InputOutputType = (from n in con.MaterialdetailsColumns
                //                               where n.EstimationTaskColumnID == item.EstimationTaskColumnID
                //                               select n.Type).FirstOrDefault();



                //        SlickGridMaterialTrackingColumns column = new SlickGridMaterialTrackingColumns();
                //        List<object> lst = new List<object>();
                //        NormsManageTableColumnData masterColumnDetail = new NormsManageTableColumnData();
                //        if (item.DataType == "String" && (item.TableName != "" && item.TableName != null))
                //        {
                //            //Group = "group";
                //            masterColumnDetail = lstNormsManageTableColumn.Where(x => x.NormsManageTableName == item.TableName && x.NormsManageTableColName == item.DBColName).FirstOrDefault();

                //            if (masterColumnDetail != null && masterColumnDetail.NormsManageMasterTable != null)
                //            {
                //                string FilterColumn = "";
                //                string FilterValue = "";
                //                NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
                //                if (masterColumnDetail.NormsManageMasterTable == "TaskType" || masterColumnDetail.NormsManageMasterTable == "MaterialUnits" || masterColumnDetail.NormsManageMasterTable == "Currency")
                //                {
                //                    FilterColumn = "CompanyId";
                //                    FilterValue = Convert.ToString(HttpContext.Current.Session["CompanyId"]);

                //                }


                //                lst = blObj.getDynamicDropdownData1(Convert.ToString(masterColumnDetail.NormsManageMasterTable), Convert.ToString(masterColumnDetail.NormsManageMasterTableColumn), FilterColumn, FilterValue).ToList<object>();
                //            }
                //        }


                //        //Default values for validation on client side
                //        List<object> lstObj = (from q in lstColumnSetting
                //                               where q.EstimationTaskColumnID == item.EstimationTaskColumnID
                //                               select new
                //                               {
                //                                   q.DataType,
                //                                   q.EquationID,
                //                                   q.Equationvalidation,
                //                                   q.InputOutput,
                //                                   q.IsMandatory,
                //                                   q.DefaultValue,
                //                                   q.NameInDb,
                //                                   q.ProjectTaskListColumn,
                //                                   EquationCalculation = "",
                //                                   q.ValidationMessage,
                //                                   colId = q.EstimationTaskColumnID,
                //                                   HideColSetting = false,
                //                                   EditRight = EditRight,
                //                                   InputOutputType = InputOutputType,
                //                                   autoCompleteOption = lst,
                //                                   //HideColSetting = lstHideColSetting.Where(a => a.ProjectItemColumnID == q.ProjectItemColumnsSettingID && a.IsHide == true).Count() > 0 ? true : false
                //                               }).ToList<object>();
                //        column.columnDefaultValues = lstObj;

                //        if (Convert.ToString(item.ProjectTaskListColumn as object) != "")
                //        {

                //            column.id = item.ProjectTaskListColumn;
                //            column.name = item.DisplayColName;
                //            column.columnType = "TASK";
                //            //column.field = "NormName";
                //            column.field = item.ProjectTaskListColumn;
                //            column.DataMappingID = item.ProjectTaskListColumn;
                //            column.cssClass = "cell-title";
                //            column.width = 100;
                //            if (Convert.ToString(item.DataType as object) == "Date")
                //                column.editor = "Slick.Editors.Date";
                //            else if (Convert.ToString(item.IsDropDown as object) == "Y")
                //            {
                //                column.editor = "Slick.Editors.YesNoSelect";
                //                column.IsDropDown = "Y";
                //                string FilterValue = "";
                //                string FilterColumn = "";
                //                //FilterColumn = item.TableName + "ID";
                //                bindDropdownForMaterialTracking(item, ref column, FilterColumn, FilterValue);

                //            }
                //            else if (item.DataType == "EditableDropdown" && (item.TableName != "" && item.TableName != null))
                //            {
                //                //Group = "group";
                //                masterColumnDetail = lstNormsManageTableColumn.Where(x => x.NormsManageTableName == item.TableName && x.NormsManageTableColName == item.DBColName).FirstOrDefault();

                //                if (masterColumnDetail != null && masterColumnDetail.NormsManageMasterTable != null)
                //                {
                //                    string FilterColumn = "";
                //                    string FilterValue = "";
                //                    NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
                //                    if (masterColumnDetail.NormsManageMasterTable == "TaskType" || masterColumnDetail.NormsManageMasterTable == "MaterialUnits" || masterColumnDetail.NormsManageMasterTable == "Currency")
                //                    {
                //                        FilterColumn = "CompanyId";
                //                        FilterValue = Convert.ToString(HttpContext.Current.Session["CompanyId"]);

                //                    }
                //                    column.editor = "Slick.Editors.YesNoSelect";
                //                    column.IsDropDown = "Y";
                //                    bindDropdownFromMNForMaterialTracking(item, ref column, masterColumnDetail.NormsManageMasterTable, masterColumnDetail.NormsManageMasterTableColumn, FilterColumn, FilterValue);
                //                }
                //                else
                //                {
                //                    column.editor = "Slick.Editors.Text";

                //                }


                //            }
                //            else
                //            {
                //                if (Convert.ToString(item.InputOutput as object).ToLower() != "output" || Convert.ToString(InputOutputType as object).ToLower() != "output")
                //                {
                //                    if (Convert.ToString(item.DataType as object).ToLower().Contains("number"))
                //                        column.editor = "Slick.Editors.Integer";
                //                    else
                //                        column.editor = "Slick.Editors.Text";
                //                }
                //            }
                //            //Dont display norms column if NormSetID is zero

                //            lstcolumn.Add(column);

                //        }

                //        //}
                //    }

                //    BLProcurementDocumentColumnsMasterRepository blpcdcm = new BLProcurementDocumentColumnsMasterRepository();
                //    IList<ProcurementDocumentColumnsMaster> lstpcdcm = blpcdcm.GetAllProcurementDocumentColumnsMastersByProjectID(nProjectID, nMilestoneID);

                //    int? companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //    int ActivityType = Convert.ToInt32(Common.ActivityType.Procurement);

                //    var lstTask = (from q in con.ProjectTaskLists
                //                   join r in con.Projects on q.ProjectID equals r.ProjectID
                //                   join ttwp in con.TaskTypeWiseProgresses on new { a = q.TaskTypeID, b = q.ProjectID } equals new { a = (int)ttwp.TaskTypeID, b = (int)ttwp.ProjectID }
                //                   join pm in con.ProjectMilestones on ttwp.ProjectMilestoneID equals pm.ProjectMilestoneID
                //                   join tt in con.TaskTypes on q.TaskTypeID equals tt.TaskTypeID
                //                   where r.CompanyId == companyId && tt.ActivityType == ActivityType && ttwp.PercentWeitage != null && ttwp.PercentWeitage > 0
                //                   select new
                //                   {
                //                       TaskName = q.TaskName,
                //                       TaskNameProjectName = q.TaskName + " (" + r.ProjectName + ")",
                //                       TaskMileStone = (r.ProjectName + "-" + q.TaskName + "-" + pm.MileStone),
                //                       TaskID = q.ProjectTaskID,
                //                       MilestoneID = pm.ProjectMilestoneID,
                //                       ProjectID = q.ProjectID
                //                   });

                //    var lstTaskID = lstTask.Select(x => x.TaskID).ToList();
                //    var lstRelatedDoc = (from udf in con.UploadDeliverableFiles
                //                         where lstTaskID.Contains((int)udf.DeliverableListID)
                //                         //select udf).ToList();
                //                         select new
                //                         {
                //                             FileID = udf.UploadDeliverableFileID,
                //                             FileName = udf.FileName,
                //                             TaskID = udf.DeliverableListID,
                //                             MilestoneID = udf.MilestoneID
                //                         });

                //    var lstUDFDoc = (from udf in con.UploadDeliverableFiles
                //                     where udf.DeliverableListID == nDeliverableID && udf.MilestoneID == nMilestoneID
                //                     select udf).ToList();

                //    var lstBookedQtyFile = (from tm in con.TaskMilestoneBookedQties
                //                            join udf in con.UploadDeliverableFiles on new { a = tm.FileID } equals new { a = udf.UploadDeliverableFileID }
                //                            where tm.TaskID == nDeliverableID && tm.MileStoneID == nMilestoneID
                //                            select udf).ToList();

                //    var lstUploadedDoc = lstUDFDoc.Union(lstBookedQtyFile).Select(x => new
                //    {
                //        FileID = x.UploadDeliverableFileID,
                //        FileName = x.FileName,
                //        TaskID = x.DeliverableListID,
                //        MilestoneID = x.MilestoneID
                //    }).ToList();

                //    BLTaxCodeRepository blTaxCode = new BLTaxCodeRepository();
                //    BLTaxCodesDetailRepository blTaxCodesDetail = new BLTaxCodesDetailRepository();
                //    BLTaxTypeRepository blTaxType = new BLTaxTypeRepository();

                //    List<TaxCode> lstTaxCode = blTaxCode.GetAllTaxCode().ToList();
                //    List<TaxCodesDetail> lstTaxCodesDetail = blTaxCodesDetail.GetAllTaxCodesDetail().ToList();
                //    List<TaxType> lstTaxType = blTaxType.GetAllTaxType().ToList();

                //    obj.list.Add(lstcolumn.ToList<object>());
                //    obj.list.Add(lstTask.ToList<object>());
                //    obj.list.Add(lstUploadedDoc.ToList<object>());
                //    obj.list.Add(lstRelatedDoc.ToList<object>());
                //    obj.list.Add(lstMaterialdetailsColumns.ToList<object>());
                //    obj.list.Add(lstpcdcm.ToList<object>());

                //    obj.list.Add(lstTaxCode.ToList<object>());
                //    obj.list.Add(lstTaxCodesDetail.ToList<object>());
                //    obj.list.Add(lstTaxType.ToList<object>());

                //}
            }
            catch (Exception ex)
            {

                throw ex;

            }
            return obj;
        }


        private void bindDropdownForMaterialTracking(EstimationTaskColumnsMaster item, ref SlickGridMaterialTrackingColumns column, string FilterColumn, string FilterValue)  // FilterValue in '' if string
        {
            DropdownBinding drp = new DropdownBinding();

            //NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
                    
            //List<usp_getDynamicDropdownData_Result> lst = blObj.getDynamicDropdownData1(Convert.ToString(item.TableName), Convert.ToString(item.DBColName), FilterColumn, FilterValue).ToList<usp_getDynamicDropdownData_Result>();

            //drp.options = lst.ToList<object>();

            //if (item.TableName != "ProjectWBS" && item.TableName != "Priority")
            //{
            //    drp.optionSelect = true;
            //}

            ////column.DataMappingID = item.NameInDb;
            ////column.field = item.DBColName;
            //column.DataMappingID = item.ProjectTaskListColumn;
            //column.field = item.NameInDb;


            //drp.Id = "Id";
            //drp.Name = "Name";
            //column.options = drp;
        }

        private void bindDropdownFromMNForMaterialTracking(EstimationTaskColumnsMaster item, ref SlickGridMaterialTrackingColumns column, string TableName, string DBColName, string FilterColumn, string FilterValue)  // FilterValue in '' if string
        {
            DropdownBinding drp = new DropdownBinding();

            //NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
                    
            //List<usp_getDynamicDropdownData_Result> lst = blObj.getDynamicDropdownData1(Convert.ToString(TableName), Convert.ToString(DBColName), FilterColumn, FilterValue).ToList<usp_getDynamicDropdownData_Result>();

            //drp.options = lst.ToList<object>();

            //if (item.TableName != "ProjectWBS" && item.TableName != "Priority")
            //{
            //    drp.optionSelect = true;
            //}

            
            //column.DataMappingID = item.ProjectTaskListColumn;
            //column.field = item.NameInDb;


            //drp.Id = "Id";
            //drp.Name = "Name";
            //column.options = drp;
        }


        #endregion





    }
}
