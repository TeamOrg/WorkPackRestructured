//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Dynamic;
//using System.Text;
//using System.Threading.Tasks;
//using Utilities;
//using DomainModelLibrary;
//using DAL;
//using System.Data.Objects;
//using System.Data.Entity.Infrastructure;
//using System.Web.Configuration;
//using System.Configuration;
//using System.Data.SqlClient;
//using System.Data;
//using Common;

//namespace BusinessLogic
//{
//    public class NewBLEstimationTaskListRepository
//    {
//        private readonly IEstimationTaskListRepository _EstimationTaskList;

//        public NewBLEstimationTaskListRepository()
//        {
//            _EstimationTaskList = new EstimationTaskListRepository();
//        }
//        public NewBLEstimationTaskListRepository(IEstimationTaskListRepository EstimationTaskList)
//        {
//            _EstimationTaskList = EstimationTaskList;
//        }
//        public IList<EstimationTaskList> GetAllEstimationTaskList()
//        {
//            return _EstimationTaskList.GetAll();
//        }

//        public void AddEstimationTaskList(params EstimationTaskList[] EstimationTaskList)
//        {
//            try
//            {
//                _EstimationTaskList.Add(EstimationTaskList);
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                throw new Exception("Record not added.");
//            }
//        }
//        public void UpdateEstimationTaskList(params EstimationTaskList[] EstimationTaskList)
//        {
//            try
//            {
//                _EstimationTaskList.Update(EstimationTaskList);
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                throw new Exception("Record not updated.");
//            }
//        }
//        public void RemoveEstimationTaskList(params EstimationTaskList[] EstimationTaskList)
//        {
//            try
//            {
//                _EstimationTaskList.Remove(EstimationTaskList);
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                throw new Exception("Record not deleted.");
//            }
//        }









//        public List<usp_getWorkingDateDuration_Result> getWorkingDateDuration(DateTime startdate, DateTime enddate)
//        {
//            List<usp_getWorkingDateDuration_Result> result = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    result = context.usp_getWorkingDateDuration(startdate, enddate).ToList<usp_getWorkingDateDuration_Result>();
//                }
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                if (false)
//                {
//                    throw ex;
//                }
//            }
//            return result;
//        }

//        public List<usp_getDynamicDropdownData_Result> getDynamicDropdownData1(string TableName, string DBColName, string FilterColumn, string FilterValue)
//        {
//            List<usp_getDynamicDropdownData_Result> result = new List<usp_getDynamicDropdownData_Result>();
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())

//                {
//                   // if (TableName != "")
//                    result = context.usp_getDynamicDropdownData(TableName, DBColName, Convert.ToString(FilterColumn as object), FilterValue).ToList<usp_getDynamicDropdownData_Result>();
//                }
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                if (false)
//                {
//                    throw ex;
//                }
//            }
//            return result;
//        }

//        public List<usp_getDynamicAutocompleteData_Result> getDynamicAutocompleteData(string key, string TableName, string DBColName, string FilterColumn, string FilterValue, string CompanyId)
//        {
//            List<usp_getDynamicAutocompleteData_Result> result = new List<usp_getDynamicAutocompleteData_Result>();
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    // if (TableName != "")
//                    result = context.usp_getDynamicAutocompleteData(TableName, DBColName, FilterColumn, FilterValue, CompanyId).ToList<usp_getDynamicAutocompleteData_Result>();
//                }
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                if (false)
//                {
//                    throw ex;
//                }
//            }
//            return result;
//        }

//        //public List<object> getDynamicAutocompleteData(string key, string TableName, string DBColName, string FilterColumn, string FilterValue)
//        //{
//        //    List<object> result = new List<object>();
//        //    try
//        //    {
//        //        DataTable dt = new DataTable();
//        //        ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["Cubicle_EntityEntities_ADONet"];
//        //        using (SqlConnection con = new SqlConnection(cs.ConnectionString))
//        //        {
//        //            using (SqlCommand cmd = new SqlCommand("usp_getDynamicAutocompleteData", con))
//        //            {
//        //                cmd.CommandType = CommandType.StoredProcedure;
//        //                cmd.Parameters.Add("@TableName", SqlDbType.VarChar).Value = TableName;
                        
//        //                con.Open();
//        //                SqlDataAdapter da = new SqlDataAdapter(cmd);
//        //                da.Fill(dt);
//        //                result = GeneralFuntions.ConvertDTtoList(dt);
//        //                //list.Add(list);

//        //            }
//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//        //        if (false)
//        //        {
//        //            throw ex;
//        //        }
//        //    }
//        //    return result;
//        //}
//        public List<usp_BindNormAsPerUser_Result> bindNormsDropdown(int deptID, int NormSetID, string isProjectleader, string IsOtherClient)
//        {
//            List<usp_BindNormAsPerUser_Result> result = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    result = context.usp_BindNormAsPerUser(deptID, NormSetID, isProjectleader, IsOtherClient).ToList<usp_BindNormAsPerUser_Result>(); ;
//                }
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                if (false)
//                {
//                    throw ex;
//                }
//            }
//            return result;
//        }

//        public List<usp_BindNormAsPerUser_Contract_Result> bindNormsDropdown_Contract(int deptID, int NormSetID, string isProjectleader)
//        {
//            List<usp_BindNormAsPerUser_Contract_Result> result = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    result = context.usp_BindNormAsPerUser_Contract(deptID, NormSetID, isProjectleader).ToList<usp_BindNormAsPerUser_Contract_Result>(); ;
//                }
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                if (false)
//                {
//                    throw ex;
//                }
//            }
//            return result;
//        }

//        public List<object> bindTaskDropdown(int ProjectID, int CompanyID, int MasterTaskTypeID, int ActivityTypeID)
//        {
//            List<object> result = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    result = (from pt in context.ProjectTaskLists
//                              join tt in context.TaskTypes on pt.TaskTypeID equals tt.TaskTypeID
//                              where pt.ProjectID == ProjectID && tt.CompanyId == CompanyID && pt.MasterTaskType == MasterTaskTypeID //&& tt.ActivityType == ActivityTypeID
//                              select new 
//                              {
//                                  Id = pt.ProjectTaskID,
//                                  Name = pt.TaskName + " - "+pt.DeliverableNo
//                              }).ToList<object>();
//                }
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                if (false)
//                {
//                    throw ex;
//                }
//            }
//            return result;
//        }


//        public List<object> bindTaskTypeDropdown(int CompanyID, int MasterTaskTypeID)
//        {
//            List<object> result = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    result = (from tt in context.TaskTypes 
//                              join at in context.ActivityTypes on tt.ActivityType equals at.ActivityTypeID
//                              where tt.CompanyId == CompanyID && at.MasterTaskTypeID == (MasterTaskTypeID != 1 ? MasterTaskTypeID : at.MasterTaskTypeID )
//                              select new
//                              {
//                                  Id = tt.TaskTypeID,
//                                  Name = tt.TaskType1
//                              }).ToList<object>();
//                }
//            }
//            catch (Exception ex)
//            {
//                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//                if (false)
//                {
//                    throw ex;
//                }
//            }
//            return result;
//        }

//        #region "After Slick grid"

//        public bool checkUniqueness(int ProjectID, string DataMappingID, string code, int id)
//        {
//            bool result = true;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    //DataMappingID = DataMappingID + " ,ProjectID";
//                    string selectStatement = "new ( " + DataMappingID + ")";
//                    var lst = new List<string>();
//                    //bool isDataMappingIdNumeric = int.TryParse(DataMappingID, out n);
//                    if(id > 0)
//                        lst = context.ProjectTaskLists.Where(a => a.ProjectID == ProjectID && a.ProjectTaskID != id).Select(DataMappingID).Cast<string>().ToList();
//                    else
//                        lst = context.ProjectTaskLists.Where(a => a.ProjectID == ProjectID).Select(DataMappingID).Cast<string>().ToList();



//                    //lst= lst.Where(a=> a.)
//                    //lst = lst.Where(a => a.DataMappingID == code && a.ProjectID == ProjectID);
//                    if (lst.Contains(code))


//                        result = false;


//                    else
//                        result = true;
//                }
//            }
//            catch (Exception ex)
//            {
//                return true;
//            }

//            return result;
//        }

//        #endregion


//        public List<List<object>> getNormsDetailForTask(int NormID, int NormsetID, int ProjectID = 0)
//        {
//            List<List<object>> lst = new List<List<object>>();
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    List<object> lstItem = (from q in context.NormsDetails
//                                            join r in context.NormsColumnsMasters on q.NormsColumnID equals r.NormsColumnID
//                                            where q.NormsID == NormID
//                                            select new
//                                            {
//                                                q.ColValue,
//                                                r.NameInDb,
//                                                r.TableName
//                                            }).ToList<object>();

//                    //List<object> taskName = (from q in context.Norms
//                    //                         join r in context.Departments on q.DepartmentID equals r.DepartmentID into dpt
//                    //                         from s in dpt.DefaultIfEmpty()
//                    //                         join t in context.ProjectStages on q.ProjectStage equals t.ProjectStageID into pst
//                    //                         from u in pst.DefaultIfEmpty()
//                    //                         where q.NormsID == NormID
//                    //                         select new
//                    //                         {
//                    //                             taskName = (s == null ? "All" : s.DepartmentCode) + "-" + q.NormsName + "-" + (u == null ? "All" : u.StageCode)
//                    //                         }).ToList<object>();                   
//                    List<object> taskName = (from q in context.Norms
//                                             join nd in context.NormsDetails
//                                                 on q.NormsID equals nd.NormsID
//                                             join nm in context.NormsColumnsMasters on nd.NormsColumnID equals nm.NormsColumnID
//                                             where q.NormsID == NormID && nm.NormSetID == NormsetID && nm.NameInDb == "NormName"
//                                             select new { taskName = nd.ColValue }).ToList<object>();

//                    var d = from q in context.NormsDetails
//                            join r in context.NormsColumnsMasters on q.NormsColumnID equals r.NormsColumnID
//                            where q.NormsID == NormID && r.TableName == "TaskType"
//                            select q;
//                    int taskTypeId = 0;
//                    if (d.Count() > 0)
//                        taskTypeId = Convert.ToInt32(d.SingleOrDefault().ColValue);

//                    List<object> lstMilestoneReq = (from q in context.ProjectMilestones
//                                                    join r in context.MileStoneTaskTypes on q.ProjectMilestoneID equals r.MileStoneID
//                                                    where q.ProjectID == ProjectID && r.TaskTypeID == taskTypeId
//                                                    select new { row = -1, MilestoneID = q.ProjectMilestoneID }).Distinct().ToList<object>();

//                    lst.Add(lstItem);
//                    lst.Add(taskName);
//                    lst.Add(lstMilestoneReq);

//                }
//            }
//            catch (Exception ex)
//            {
//                return lst;
//            }

//            return lst;
//        }

//        public List<List<object>> getNormsDetailForTask_Contract(int NormID, int NormsetID, int ProjectID = 0)
//        {
//            List<List<object>> lst = new List<List<object>>();
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
//                    List<object> lstItem = (from q in context.NormsDetails
//                                            join r in context.NormsColumnsMasters on q.NormsColumnID equals r.NormsColumnID
//                                            where q.NormsID == NormID
//                                            select new
//                                            {
//                                                q.ColValue,
//                                                r.NameInDb,
//                                                r.TableName
//                                            }).ToList<object>();

//                    BLProjectCreationRepository blPr = new BLProjectCreationRepository();
//                    Project pr = blPr.GetProjectByID(ProjectID);

//                    List<object> lstDesn = (from q in context.NormsColumnsMasters
//                                            join r in context.ContractNormDistributions on q.DBColPkID equals r.DesignationID
//                                            where q.NormSetID == pr.NormSetID && q.TableName == "Designation" && r.ProjectStageID == pr.ProjectStage
//                                            select new
//                                            {
//                                                ColValue = r.DistributionValue,
//                                                NameInDb = q.NameInDb,
//                                                TableName = q.TableName
//                                            }).ToList<object>();

//                    lstItem = lstItem.Union(lstDesn).ToList<object>();

//                    //List<object> taskName = (from q in context.Norms
//                    //                         join r in context.Departments on q.DepartmentID equals r.DepartmentID into dpt
//                    //                         from s in dpt.DefaultIfEmpty()
//                    //                         join t in context.ProjectStages on q.ProjectStage equals t.ProjectStageID into pst
//                    //                         from u in pst.DefaultIfEmpty()
//                    //                         where q.NormsID == NormID
//                    //                         select new
//                    //                         {
//                    //                             taskName = (s == null ? "All" : s.DepartmentCode) + "-" + q.NormsName + "-" + (u == null ? "All" : u.StageCode)
//                    //                         }).ToList<object>();                   
//                    List<object> taskName = (from q in context.Norms
//                                             join nd in context.NormsDetails
//                                                 on q.NormsID equals nd.NormsID
//                                             join nm in context.NormsColumnsMasters on nd.NormsColumnID equals nm.NormsColumnID
//                                             where q.NormsID == NormID && nm.NormSetID == NormsetID && nm.NameInDb == "NormName"
//                                             select new { taskName = nd.ColValue }).ToList<object>();

//                    var d = from q in context.NormsDetails
//                            join r in context.NormsColumnsMasters on q.NormsColumnID equals r.NormsColumnID
//                            where q.NormsID == NormID && r.TableName == "TaskType"
//                            select q;
//                    string taskTypeId = "0";
//                    if (d.Count() > 0)
//                        taskTypeId = d.SingleOrDefault().ColValue;

//                    List<object> lstMilestoneReq = (from q in context.ProjectMilestones
//                                                    join r in context.MileStoneTaskTypes on q.ProjectMilestoneID equals r.MileStoneID
//                                                    where q.ProjectID == ProjectID
//                                                    select new { MilestoneID = q.ProjectMilestoneID }).Distinct().ToList<object>();

//                    lst.Add(lstItem);
//                    lst.Add(taskName);
//                    lst.Add(lstMilestoneReq);

//                }
//            }
//            catch (Exception ex)
//            {
//                return lst;
//            }

//            return lst;
//        }


//        public List<object> getMilestoneNotRequired(int ProjectID, int NormId, int TaskTypeID)
//        {
//            List<object> lstMilestoneReq = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {                    

//                    lstMilestoneReq = (from q in context.ProjectMilestones
//                                       join r in context.TaskTypeWiseProgresses on q.ProjectMilestoneID equals r.ProjectMilestoneID
//                                       where q.ProjectID == ProjectID && r.TaskTypeID == TaskTypeID && ((r.PercentWeitage != null && r.PercentWeitage != 0) || (r.TaskTypeChecked != null && r.TaskTypeChecked == true))
//                                       select new { row = -1, MilestoneID = q.ProjectMilestoneID, Weightage = r.PercentWeitage, Order = 0 }).Distinct().OrderBy(c => c.Weightage).ToList<object>();

//                }
//            }
//            catch (Exception ex)
//            {

//            }

//            return lstMilestoneReq;
//        }

//        public List<ProjectMilestone> getMilestoneIdByTaskTypeID(int ProjectID, int NormId, int TaskTypeID)
//        {
//            List<ProjectMilestone> lstMilestoneReq = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {

//                    lstMilestoneReq = (from q in context.ProjectMilestones
//                                       join r in context.TaskTypeWiseProgresses on q.ProjectMilestoneID equals r.ProjectMilestoneID
//                                       where q.ProjectID == ProjectID && r.TaskTypeID == TaskTypeID && ((r.PercentWeitage != null && r.PercentWeitage != 0) || (r.TaskTypeChecked != null && r.TaskTypeChecked == true))
//                                       select q).Distinct().ToList<ProjectMilestone>();

//                }
//            }
//            catch (Exception ex)
//            {

//            }

//            return lstMilestoneReq;
//        }
//        public bool IsValidMilestone(int ProjectID, int TaskTypeID,int MilestoneID)
//        {
//            bool validMilestone = false;
//            List<object> lstMilestoneReq = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {
                    
//                    lstMilestoneReq = (from q in context.ProjectMilestones
//                                       join r in context.TaskTypeWiseProgresses on q.ProjectMilestoneID equals r.ProjectMilestoneID
//                                       where q.ProjectID == ProjectID && r.TaskTypeID == TaskTypeID && r.ProjectMilestoneID==MilestoneID && ((r.PercentWeitage != null && r.PercentWeitage != 0) || r.TaskTypeChecked == true)
//                                       select new { row = -1, MilestoneID = q.ProjectMilestoneID, Weightage = r.PercentWeitage, Order = 0 }).Distinct().OrderBy(c => c.Weightage).ToList<object>();

//                    if (lstMilestoneReq.Count > 0)
//                    {
//                        validMilestone = true;
//                    }

//                }
//            }
//            catch (Exception ex)
//            {

//            }

//            return validMilestone;
//        }

//        public List<TaskTypeWiseProgress> getMilestoneRequired(int ProjectID, int TaskTypeID)
//        {
//            bool validMilestone = false;
//            List<TaskTypeWiseProgress> lstMilestoneReq = null;
//            try
//            {
//                using (var context = new Cubicle_EntityEntities())
//                {

//                    lstMilestoneReq = (from q in context.ProjectMilestones
//                                       join r in context.TaskTypeWiseProgresses on q.ProjectMilestoneID equals r.ProjectMilestoneID
//                                       where q.ProjectID == ProjectID && r.TaskTypeID == TaskTypeID && ((r.PercentWeitage != null && r.PercentWeitage != 0) || r.TaskTypeChecked == true)
//                                       select r).ToList();

//                }
//            }
//            catch (Exception ex)
//            {

//            }

//            return lstMilestoneReq;
//        }

//    }

//    public class MilestoneWeightage
//    { 
//        public int row { get; set; }
//        public int MilestoneID { get; set; }
//        public decimal? Weightage { get; set; }
//        public int Order { get; set; }
//    }
//}
