using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{

    public class BLEstimationTaskDetailRepository : IBLEstimationTaskDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EstimationTaskDetail> _estimationTaskDetail;

        public BLEstimationTaskDetailRepository(WorkpackDBContext context, IGenericDataRepository<EstimationTaskDetail> estimationTaskDetail)
        {
            _context = context;
            _estimationTaskDetail = estimationTaskDetail;
        }


        public IList<EstimationTaskDetail> GetAllEstimationTaskDetail()
        {
            return _estimationTaskDetail.GetAll();
        }

        public void AddEstimationTaskDetails(params EstimationTaskDetail[] EstimationTaskDetail)
        {
            try
            {
                _estimationTaskDetail.Add(EstimationTaskDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateEstimationTaskDetails(params EstimationTaskDetail[] EstimationTaskDetail)
        {
            try
            {
                _estimationTaskDetail.Update(EstimationTaskDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveEstimationTaskDetails(params EstimationTaskDetail[] EstimationTaskDetail)
        {
            try
            {
                _estimationTaskDetail.Remove(EstimationTaskDetail);
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



        public List<NormsManageTable> getNormsManageTable()
        {
            List<NormsManageTable> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.NormsManageTables.Where(p => p.IsActive == "Y").ToList<NormsManageTable>();
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


        public List<NormsManageTableColumnData> getNormsManageTableColumn()
        {
            List<NormsManageTableColumnData> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from ntc in context.NormsManageTableColumns
            //           join ntm in context.NormsManageTables on ntc.NormsManageTableID equals ntm.NormsManageTableID
            //           select new NormsManageTableColumnData
            //           {
            //               NormsManageTableColId = ntc.NormsManageTableColId,
            //               NormsManageTableID = ntc.NormsManageTableID,
            //               NormsManageTableName = ntm.NormsManageTableName,
            //               NormsManageTableColName = ntc.NormsManageTableColName,
            //               NormsManageMasterTable = ntc.NormsManageMasterTable,
            //               NormsManageMasterTableColumn = ntc.NormsManageMasterTableColumn
            //           }).ToList();
            //    //context.NormsManageTableColumns.Where(a => a.NormsManageTableID == NormManageTableID).ToList<NormsManageTableColumn>();
            //}
            return lst;
        }


        public static List<int> GetUsersForSubmitEstimationNotification(int ProjectID)
        {
            List<int> users = null;
            //int TaskAcceptStatus = Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    List<int?> lst = context.ProjectsDepartments.Where(a => a.ProjectID == ProjectID).Select(a => a.DepartmentID).ToList().ConvertAll<int?>(a => a);
            //    List<int?> lstAccept = context.ProjectTaskLists.Where(a => a.ProjectID == ProjectID && a.TaskStatus >= TaskAcceptStatus).Select(a => a.TaskOwner).ToList().ConvertAll<int?>(a => a);
            //    users = (from u in context.Projects
            //             where u.ProjectID == ProjectID
            //             select u.ProjectLeader)
            //              .Union(from u in context.AssignResourceForEstimations
            //                     where u.ProjectID == ProjectID && lstAccept.Contains(u.UserID) && lst.Contains(u.DepartmentID)
            //                     select u.UserID)
            //              .Union(from u in context.Users
            //                     where lst.Contains(u.DepartmentID) && u.FocalPoint == "1"
            //                     select u.UserID).ToList();

            //    List<ProjectsAdmin> lstPlanningEng = (from u in context.ProjectsAdmins
            //                                          where u.ProjectID == ProjectID
            //                                          select u).ToList<ProjectsAdmin>();

            //    foreach (var item in lstPlanningEng)
            //    {
            //        if (item != null)
            //        {
            //            if (Convert.ToInt32(item.UserID) != 0)
            //            {
            //                users.Add(Convert.ToInt32(item.UserID));
            //            }
            //        }
            //    }

            //}

            return users;
        }

        public static List<int?> getAllTaskOwnerForAllTaskByProjectID(int ProjectID)
        {
            List<int?> lstAccept = null;
            //int TaskAcceptStatus = Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lstAccept = context.ProjectTaskLists.Where(a => a.ProjectID == ProjectID && a.TaskStatus >= TaskAcceptStatus).Select(a => a.TaskOwner).ToList<int?>();
            //}
            return lstAccept;
        }




        #region " After Slick grid"

        public List<object> getEstimationDetail(int ProjectID)
        {
            List<TaskDetail> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskDetails
            //           join r in context.EstimationTaskColumnsMasters on q.EstimationTaskColumnID equals r.EstimationTaskColumnID
            //           where r.ProjectID == ProjectID
            //           select q).ToList<TaskDetail>();

            //    query = (lst
            //                .GroupBy(c => c.ProjectTaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    EstimationTaskColumnID = g.Select(r => r.EstimationTaskColumnID),
            //                    value = g.Select(r => r.ColValue)
            //                })).ToList<object>();
            //}

            return query;
        }

        public List<object> getEstimationDetail_Contract(int ProjectID, int ProjectContractID)
        {
            List<TaskDetail_Contract> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    List<int> lstTask = (from q in context.ProjectTaskList_Contract where q.ProjectContractID == ProjectContractID && q.ProjectID == ProjectID select q.ProjectTaskID).ToList<int>();

            //    lst = (from q in context.TaskDetail_Contract
            //           join r in context.EstimationTaskColumnsMasters on q.EstimationTaskColumnID equals r.EstimationTaskColumnID
            //           where lstTask.Contains(q.ProjectTaskID) && r.ProjectID == ProjectID
            //           select q).ToList<TaskDetail_Contract>();

            //    query = (lst
            //                .GroupBy(c => c.ProjectTaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    EstimationTaskColumnID = g.Select(r => r.EstimationTaskColumnID),
            //                    value = g.Select(r => r.ColValue)
            //                })).ToList<object>();
            //}

            return query;
        }

        public List<object> getSearchTaskDetail(int ProjectID, List<ProjectTaskList> lstFilteredProjectTask)
        {
            List<TaskDetail> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskDetails
            //           join r in context.EstimationTaskColumnsMasters on q.EstimationTaskColumnID equals r.EstimationTaskColumnID
            //           where r.ProjectID == ProjectID
            //           select q).ToList<TaskDetail>();

            //    lst = (from l in lst join r in lstFilteredProjectTask on l.ProjectTaskID equals r.ProjectTaskID select l).ToList<TaskDetail>();

            //    query = (lst
            //                .GroupBy(c => c.ProjectTaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    EstimationTaskColumnID = g.Select(r => r.EstimationTaskColumnID),
            //                    value = g.Select(r => r.ColValue)
            //                })).ToList<object>();
            //}

            return query;
        }

        public List<object> getProjectMilestone(int ProjectID, int MasterTaskType)
        {
            List<TaskMilestoneTargetDate> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskMilestoneTargetDates
            //           join r in context.ProjectMilestones on q.MileStoneID equals r.ProjectMilestoneID
            //           where r.ProjectID == ProjectID
            //           select q).ToList<TaskMilestoneTargetDate>();

            //    query = (lst
            //                .GroupBy(c => c.TaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    MileStoneID = g.Select(r => r.MileStoneID),
            //                    TaskMilestoneTargetDates = g.Select(r => r.TaskMilestoneTargetDates == null ? "" : Convert.ToDateTime(r.TaskMilestoneTargetDates).ToString("dd/MM/yyyy")),
            //                    ActualTaskMilestoneTargetDates = g.Select(r => Convert.ToString(r.ActualTaskMilestoneTargetDates)),
            //                    TaskTypeID = g.Select(r => r.TaskTypeID)
            //                })).ToList<object>();
            //}

            return query;
        }
        public List<object> getProjectMilestoneProgressUpdate(int ProjectID, int ProjectTaskID)
        {
            List<TaskMilestoneTargetDate> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskMilestoneTargetDates
            //           join r in context.ProjectMilestones on q.MileStoneID equals r.ProjectMilestoneID
            //           where r.ProjectID == ProjectID && q.TaskID == ProjectTaskID
            //           select q).ToList<TaskMilestoneTargetDate>();

            //    query = (lst
            //                .GroupBy(c => c.TaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    MileStoneID = g.Select(r => r.MileStoneID),
            //                    TaskMilestoneTargetDates = g.Select(r => r.TaskMilestoneTargetDates == null ? "" : Convert.ToDateTime(r.TaskMilestoneTargetDates).ToString("dd/MM/yyyy")),
            //                    ActualTaskMilestoneTargetDates = g.Select(r => Convert.ToString(r.ActualTaskMilestoneTargetDates) == "" ? Convert.ToString(r.ActualTaskMilestoneTargetDates) : Convert.ToDateTime(r.ActualTaskMilestoneTargetDates).ToString("dd/MM/yyyy")),
            //                    TaskTypeID = g.Select(r => r.TaskTypeID)
            //                })).ToList<object>();
            //}

            return query;
        }

        public List<object> getProjectTaskByProjectIDTaskID(int ProjectID, int ProjectTaskID)
        {
            List<ProjectTaskList> lst = null;
            List<object> list = null;
            //using (var ctext = new Cubicle_EntityEntities())
            //{

            //    lst = (from q in ctext.ProjectTaskLists.ToList()
            //           where q.ProjectID == ProjectID && q.ProjectTaskID == ProjectTaskID
            //           select q).ToList();

            //    list = lst.Select(g => new
            //    {
            //        id = g.ProjectTaskID,
            //        PlannedStartDate = Convert.ToDateTime(g.StartDate).ToString("dd/MM/yyyy"),
            //        ActualStartDate = Convert.ToString(g.ActualStartDate) == "" ? "" : Convert.ToDateTime(g.ActualStartDate).ToString("dd/MM/yyyy"),
            //        PlannedEndDate = Convert.ToDateTime(g.EndDate).ToString("dd/MM/yyyy"),
            //        ActualEndDate = Convert.ToString(g.ActualEndDate) == "" ? "" : Convert.ToDateTime(g.ActualEndDate).ToString("dd/MM/yyyy"),
            //        Progress = Convert.ToString(g.TaskProgress) == "" ? 0 : Convert.ToInt32(g.TaskProgress)
            //    }).ToList<object>();

            //}

            return list;
        }

        public List<object> getSubTaskByProjectIDTaskID(int ProjectID, int ProjectTaskID)
        {

            List<object> list = null;
            //using (var ctext = new Cubicle_EntityEntities())
            //{



            //    list = (from pt in ctext.ProjectTaskLists.ToList()
            //            join dg in ctext.Designations on pt.DesignationID equals dg.DesignationID
            //            join tt in ctext.TaskTypes on pt.TaskTypeID equals tt.TaskTypeID
            //            join u in ctext.Users on pt.TaskOwner equals u.UserID
            //            join pw in ctext.ProjectWBS.ToList() on pt.WBSID equals pw.WBSID.ToString()
            //            where pt.ParentTaskID == ProjectTaskID
            //            select new
            //            {
            //                id = pt.ProjectTaskID,
            //                TaskName = pt.TaskName,
            //                TaskNo = pt.TaskNo + "." + pt.SubTaskNo,
            //                TaskTypeID = pt.TaskTypeID,
            //                TaskType = tt.TaskType1,
            //                DesignationID = pt.DesignationID,
            //                Designation = dg.DesignationName,
            //                IsDeliverable = pt.IsDeliverable,
            //                AllottedHours = pt.AllottedHours,
            //                AssignOwner = pt.TaskOwner,
            //                OwnerName = u.FirstName + " " + u.LastName,
            //                WBSID = pt.WBSID,
            //                WBSCode = pw.WBSCode,
            //                StartDate = Convert.ToDateTime(pt.StartDate).ToString("dd/MM/yyyy"),
            //                EndDate = Convert.ToDateTime(pt.EndDate).ToString("dd/MM/yyyy"),
            //                Remarks = pt.Remarks

            //            }).ToList<object>();
            //}

            return list;
        }
        public List<object> getSearchProjectMilestone(int ProjectID, List<ProjectTaskList> lstFilteredProjectTask)
        {
            List<TaskMilestoneTargetDate> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskMilestoneTargetDates
            //           join r in context.ProjectMilestones on q.MileStoneID equals r.ProjectMilestoneID
            //           where r.ProjectID == ProjectID
            //           select q).ToList<TaskMilestoneTargetDate>();
            //    lst = (from l in lst join r in lstFilteredProjectTask on l.TaskID equals r.ProjectTaskID select l).ToList<TaskMilestoneTargetDate>();
            //    query = (lst
            //                .GroupBy(c => c.TaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    MileStoneID = g.Select(r => r.MileStoneID),
            //                    TaskMilestoneTargetDates = g.Select(r => r.TaskMilestoneTargetDates == null ? "" : Convert.ToDateTime(r.TaskMilestoneTargetDates).ToString("dd/MM/yyyy")),
            //                    ActualTaskMilestoneTargetDates = g.Select(r => Convert.ToString(r.ActualTaskMilestoneTargetDates)),
            //                    TaskTypeID = g.Select(r => r.TaskTypeID)
            //                })).ToList<object>();
            //}

            return query;
        }

        public List<object> getTaskDesnByProjectID(int ProjectID)
        {
            List<TaskDesignation> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskDesignations
            //           where q.ProjectID == ProjectID
            //           select q).ToList<TaskDesignation>();

            //    query = (lst
            //                .GroupBy(c => c.ProjectTaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    DesignationID = g.Select(r => r.DesignationID),
            //                    Hours = g.Select(r => r.Hours)
            //                })).ToList<object>();
            //}

            return query;
        }

        public List<object> getTaskDesnByProjectID_Contract(int ProjectID, int ProjectContractID)
        {
            List<TaskDesignation_Contract> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    List<int> lstTask = (from q in context.ProjectTaskList_Contract where q.ProjectContractID == ProjectContractID && q.ProjectID == ProjectID select q.ProjectTaskID).ToList<int>();

            //    lst = (from q in context.TaskDesignation_Contract
            //           where lstTask.Contains(q.ProjectTaskID) && q.ProjectID == ProjectID
            //           select q).ToList<TaskDesignation_Contract>();

            //    query = (lst
            //                .GroupBy(c => c.ProjectTaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    DesignationID = g.Select(r => r.DesignationID),
            //                    Hours = g.Select(r => r.Hours)
            //                })).ToList<object>();
            //}

            return query;
        }

        public List<object> getSearchTaskDesnByProjectID(int ProjectID, List<ProjectTaskList> lstFilteredProjectTask)
        {
            List<TaskDesignation> lst = null;
            List<object> query = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskDesignations
            //           where q.ProjectID == ProjectID
            //           select q).ToList<TaskDesignation>();
            //    lst = (from l in lst join r in lstFilteredProjectTask on l.ProjectTaskID equals r.ProjectTaskID select l).ToList<TaskDesignation>();
            //    query = (lst
            //                .GroupBy(c => c.ProjectTaskID)
            //                .Select(g => new
            //                {
            //                    ProjectTaskID = g.Key,
            //                    DesignationID = g.Select(r => r.DesignationID),
            //                    Hours = g.Select(r => r.Hours)
            //                })).ToList<object>();
            //}

            return query;
        }

        class Books
        {
            public string title;
            public string author;
            public string subject;
        };

        public OperationResult editEstimationTask(string PrimaryId, string ProjectID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string IsManHoursDisable, int ScopeChangeID = 0, string MasterTaskType = "1")
        {
            OperationResult result = new OperationResult();
            //CultureInfo ci = new CultureInfo("en-Gb");
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        string resultMsg = "";
            //        bool isPriojectLeader = false;

            //        BLTaskListRepository blTask = new BLTaskListRepository();
            //        ProjectTaskList task = blTask.getTaskDetailsByTaskId(Convert.ToInt32(PrimaryId));
            //        List<ProjectTaskList> lstSubTask = blTask.getSubTaskDetailsByParentTaskId(Convert.ToInt32(PrimaryId)); ;

            //        BLProjectCreationRepository blproject = new BLProjectCreationRepository();
            //        Project objProject = blproject.GetProjectByID(Convert.ToInt32(ProjectID));


            //        string orgTaskOwner = "";
            //        bool bSendNotificationToOwner = false;




            //        List<ProjectTaskList> lsttaskupdate = new List<ProjectTaskList>();
            //        Dictionary<string, string> originalGrTaskVal = new Dictionary<string, string>();
            //        originalGrTaskVal["Duration"] = Convert.ToString(task.Duration);
            //        originalGrTaskVal["StartDate"] = Convert.ToString(task.StartDate);
            //        originalGrTaskVal["EndDate"] = Convert.ToString(task.EndDate);

            //        originalGrTaskVal["DepatmentID"] = Convert.ToString(task.DepatmentID);

            //        BLTaskDesignationRepository blTaskDesn = new BLTaskDesignationRepository();
            //        BLTaskMilestoneTargetDates blTaskMile = new BLTaskMilestoneTargetDates();
            //        BLTaskDeatilsRepository blTaskDet = new BLTaskDeatilsRepository();

            //        List<TaskDesignation> lstDesgn = blTaskDesn.GetTaskDesignationByProjectTaskID(Convert.ToInt32(PrimaryId));
            //        lstDesgn = lstDesgn.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskDesignation>();
            //        List<TaskDetail> lstDet = BLTaskDeatilsRepository.GetAllDetailsByTaskID(Convert.ToInt32(PrimaryId));
            //        lstDet = lstDet.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskDetail>();

            //        List<TaskMilestoneTargetDate> lstTmt = BLTaskMilestoneTargetDates.GetAllTaskMilestoneTargetDatesByTaskID(Convert.ToInt32(PrimaryId));
            //        List<List<TaskMilestoneTargetDate>> lstTmtSubTaskRemove = new List<List<TaskMilestoneTargetDate>>();
            //        List<TaskMilestoneTargetDate> lstTmtSubTaskAdd = new List<TaskMilestoneTargetDate>();




            //        Dictionary<string, string> dictTask = new Dictionary<string, string>();

            //        BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //        List<EstimationTaskColumnsMaster> lstColMaster = blObj.GetAllEstimationTaskColumnsMastersByProjectID(Convert.ToInt32(ProjectID), Convert.ToInt32(MasterTaskType)).ToList<EstimationTaskColumnsMaster>();

            //        var normId = item
            //               .Where(i => i.Value[1] == "Norm").Select(a => a.Value[2]).SingleOrDefault();

            //        BLNormsDetailRepository blNormDet = new BLNormsDetailRepository();
            //        List<NormDesDet> lstNormDet = blNormDet.getNormsDesDetailsByNormIDCls(Convert.ToInt32(normId));

            //        var eq = lstColMaster.Where(a => Convert.ToString(a.EquationID as object) != "" || Convert.ToString(a.Equationvalidation as object) != "").Select(a => Convert.ToString(a.EquationID as object) != "" ? a.EquationID : a.Equationvalidation);
            //        string[] separators = { "/", "*", "+", "-", "&", "|", " ", ">", "<", "=" };
            //        List<string> eqLst = new List<string>();
            //        foreach (var vEq in eq)
            //        {
            //            string[] arr = vEq.Split(separators, StringSplitOptions.None);
            //            eqLst.AddRange(arr.ToList());
            //        }

            //        eqLst = eqLst.Distinct().ToList<string>();
            //        var pEqVal = item
            //               .Where(i => i.Value[4] != "" && i.Value[4] != null && eqLst.Contains(i.Value[4])).Select(a => new NormDesDet { NameInDb = a.Value[4], ColValue = a.Value[2] });

            //        var pEqValNorm = lstNormDet.Where(i => eqLst.Contains(i.NameInDb));


            //        BLProjectCreationRepository blObjPr = new BLProjectCreationRepository();
            //        Project pr = blObjPr.GetProjectByID(Convert.ToInt32(ProjectID));
            //        if (pr.ProjectLeader == Convert.ToInt32(UserID))
            //        {
            //            isPriojectLeader = true;
            //        }
            //        else
            //        {
            //            List<ProjectsAdmin> lst = blObjPr.getProjectAdmin(Convert.ToInt32(ProjectID));
            //            if (lst.Select(a => a.UserID).Contains(Convert.ToInt32(UserID)))
            //            {
            //                isPriojectLeader = true;
            //            }
            //        }


            //        ////// TYPE== "VAR"
            //        Dictionary<string, string> dictVar = new Dictionary<string, string>();
            //        var pV = item
            //               .Where(i => i.Value[0] == "VAR").Select(a => a.Value);
            //        foreach (var t in pV)
            //        {
            //            dictVar.Add(t[1], t[2]);
            //        }



            //        ////// type == "TASK"

            //        var p = item
            //               .Where(i => i.Value[0] == "TASK").Select(a => a.Value);
            //        foreach (var t in p)
            //        {
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t[3])).SingleOrDefault();
            //            if (est != null)
            //            {
            //                validateTaskEntry(Convert.ToInt32(normId), isPriojectLeader, t[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), Convert.ToInt32(PrimaryId), t[1], out result, null);
            //                if (est.PermanentNameInDb == "TOTALHRS")
            //                {
            //                    decimal n;
            //                    bool isDecimal = decimal.TryParse(result.Message, out n);
            //                    if (isDecimal)
            //                    {
            //                        t[2] = result.Message;
            //                    }
            //                }
            //                else if (est.PermanentNameInDb != "TOTALHRS")
            //                {
            //                    resultMsg += result.Message;
            //                }
            //            }
            //            dictTask.Add(t[1], t[2]);
            //        }

            //        bool isTaskNoInt = false;
            //        bool isTaskNoDecimal = false;
            //        int TaskNo = 0;
            //        if (resultMsg.Length <= 0)
            //        {
            //            if (vTaskNo != "")
            //            {

            //                TaskNo = getNextTaskNumberByProjectID(Convert.ToInt32(ProjectID), Convert.ToInt32(MasterTaskType));
            //                int t;
            //                decimal t1;
            //                isTaskNoDecimal = decimal.TryParse(vTaskNo, out t1);
            //                isTaskNoInt = int.TryParse(vTaskNo, out t);

            //                if (isTaskNoInt)
            //                {
            //                    if ((t % 1) == 0)
            //                    {
            //                        if (t < TaskNo)
            //                        {
            //                            TaskNo = Convert.ToInt32(t);
            //                            blTaskDet.updateTaskNo(Convert.ToInt32(ProjectID), TaskNo, 0, Convert.ToInt32(task.TaskNo));
            //                        }
            //                    }
            //                    else
            //                    {
            //                        result.Message = "Task Number cannot be decimal";
            //                        result.MessageType = "E";
            //                        return result;
            //                    }
            //                    //else
            //                    //{
            //                    //    string[] arr = t.ToString().Split('.');
            //                    //    int vDecPart = Convert.ToInt32(arr[1]);
            //                    //    TaskNo = Convert.ToInt32(arr[0]);
            //                    //    if (Convert.ToInt32(arr[0]) > TaskNo)
            //                    //    {
            //                    //        vDecPart = 0;
            //                    //    }
            //                    //    else
            //                    //    {
            //                    //        task.SubTaskNo = vDecPart;
            //                    //    }
            //                    //    blTaskDet.updateTaskNo(Convert.ToInt32(ProjectID), TaskNo, vDecPart, Convert.ToInt32(task.TaskNo));
            //                    //}

            //                    task.TaskNo = TaskNo;
            //                }
            //            }


            //            int oldParentID = task.ParentTaskID == null ? 0 : (int)task.ParentTaskID;

            //            task.ParentTaskID = dictTask.ContainsKey("ParentTaskID") ? Convert.ToInt32(dictTask["ParentTaskID"]) : 0;

            //            //if (task.ParentTaskID > 0 && oldParentID == 0)
            //            //{

            //            //    task.TaskNo = blTask.GetTaskListByProjectTaskID(Convert.ToInt32(dictTask["ParentTaskID"])).FirstOrDefault().TaskNo;
            //            //    task.SubTaskNo = blTask.GetNextChildCountNoByProjectTaskID(Convert.ToInt32(dictTask["ParentTaskID"]));

            //            //    task.IsgroupTask = "N";
            //            //    task.GroupTaskID = Convert.ToInt32(dictTask["ParentTaskID"]);

            //            //}
            //            //else
            //            //{
            //            //    if (task.SubTaskNo > 0)
            //            //    {
            //            //        task.IsgroupTask = "N";
            //            //        task.GroupTaskID = Convert.ToInt32(dictTask["ParentTaskID"]);
            //            //    }
            //            //    else
            //            //    {
            //            //        task.IsgroupTask = "Y";
            //            //    }
            //            //}

            //            ProjectTaskList tasknew = null;
            //            if (task.ParentTaskID != oldParentID)
            //            {
            //                blTaskDet.UpdateTaskNoByParentID(task.ProjectTaskID, Convert.ToInt32(task.ParentTaskID), oldParentID, Convert.ToInt32(ProjectID));
            //                tasknew = blTask.getTaskDetailsByTaskId(Convert.ToInt32(PrimaryId));

            //                task.TaskNo = tasknew.TaskNo;
            //                task.SubTaskNo = tasknew.SubTaskNo;
            //                task.GroupTaskID = tasknew.GroupTaskID;
            //                task.IsgroupTask = tasknew.IsgroupTask;
            //            }

            //            //if (task.SubTaskNo > 0)
            //            //{
            //            //    task.IsgroupTask = "N";
            //            //    task.GroupTaskID = Convert.ToInt32(dictTask["ParentTaskID"]);
            //            //}
            //            //else
            //            //{
            //            //    task.IsgroupTask = "Y";
            //            //}










            //            task.NormsID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //            task.Number_1 = dictTask.ContainsKey("Number_1") ? Convert.ToDouble(dictTask["Number_1"]) : 0;
            //            task.Number_2 = dictTask.ContainsKey("Number_2") ? Convert.ToDouble(dictTask["Number_2"]) : 0;
            //            task.Number_3 = dictTask.ContainsKey("Number_3") ? Convert.ToDouble(dictTask["Number_3"]) : 0;
            //            task.Number_4 = dictTask.ContainsKey("Number_4") ? Convert.ToDouble(dictTask["Number_4"]) : 0;
            //            task.Number_5 = dictTask.ContainsKey("Number_5") ? Convert.ToDouble(dictTask["Number_5"]) : 0;
            //            task.Number_6 = dictTask.ContainsKey("Number_6") ? Convert.ToDouble(dictTask["Number_6"]) : 0;
            //            task.Number_7 = dictTask.ContainsKey("Number_7") ? Convert.ToDouble(dictTask["Number_7"]) : 0;
            //            task.Number_8 = dictTask.ContainsKey("Number_8") ? Convert.ToDouble(dictTask["Number_8"]) : 0;
            //            task.Number_9 = dictTask.ContainsKey("Number_9") ? Convert.ToDouble(dictTask["Number_9"]) : 0;
            //            task.Number_10 = dictTask.ContainsKey("Number_10") ? Convert.ToDouble(dictTask["Number_10"]) : 0;
            //            if (dictTask.ContainsKey("DateTime_1"))
            //            {
            //                task.DateTime_1 = dictTask["DateTime_1"] != "" ? Convert.ToDateTime(dictTask["DateTime_1"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_2"))
            //            {
            //                task.DateTime_2 = dictTask["DateTime_2"] != "" ? Convert.ToDateTime(dictTask["DateTime_2"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_3"))
            //            {
            //                task.DateTime_3 = dictTask["DateTime_3"] != "" ? Convert.ToDateTime(dictTask["DateTime_3"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_4"))
            //            {
            //                task.DateTime_4 = dictTask["DateTime_4"] != "" ? Convert.ToDateTime(dictTask["DateTime_4"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_5"))
            //            {
            //                task.DateTime_5 = dictTask["DateTime_5"] != "" ? Convert.ToDateTime(dictTask["DateTime_5"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_6"))
            //            {
            //                task.DateTime_6 = dictTask["DateTime_6"] != "" ? Convert.ToDateTime(dictTask["DateTime_6"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_7"))
            //            {
            //                task.DateTime_7 = dictTask["DateTime_7"] != "" ? Convert.ToDateTime(dictTask["DateTime_7"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_8"))
            //            {
            //                task.DateTime_8 = dictTask["DateTime_8"] != "" ? Convert.ToDateTime(dictTask["DateTime_8"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_9"))
            //            {
            //                task.DateTime_9 = dictTask["DateTime_9"] != "" ? Convert.ToDateTime(dictTask["DateTime_9"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_10"))
            //            {
            //                task.DateTime_10 = dictTask["DateTime_10"] != "" ? Convert.ToDateTime(dictTask["DateTime_10"], ci) : (DateTime?)null;
            //            }
            //            task.String_1 = dictTask.ContainsKey("String_1") ? (dictTask["String_1"]) : null;
            //            task.String_2 = dictTask.ContainsKey("String_2") ? (dictTask["String_2"]) : null;
            //            task.String_3 = dictTask.ContainsKey("String_3") ? (dictTask["String_3"]) : null;
            //            task.String_4 = dictTask.ContainsKey("String_4") ? (dictTask["String_4"]) : null;
            //            task.String_5 = dictTask.ContainsKey("String_5") ? (dictTask["String_5"]) : null;
            //            task.String_6 = dictTask.ContainsKey("String_6") ? (dictTask["String_6"]) : null;
            //            task.String_7 = dictTask.ContainsKey("String_7") ? (dictTask["String_7"]) : null;
            //            task.String_8 = dictTask.ContainsKey("String_8") ? (dictTask["String_8"]) : null;
            //            task.String_9 = dictTask.ContainsKey("String_9") ? (dictTask["String_9"]) : null;
            //            task.String_10 = dictTask.ContainsKey("String_10") ? (dictTask["String_10"]) : null;
            //            //if (ScopeChangeID == 0)
            //            //{
            //            //    //if (Convert.ToInt32(dictTask["Dept"]) == 0)
            //            //    //{
            //            //    //    BLDepartmentRepository blDept = new BLDepartmentRepository();
            //            //    //    task.DepatmentID = blDept.GetAllDepartments().Where(x => x.DepartmentCode == "Not Selected").Select(x => x.DepartmentID).FirstOrDefault();
            //            //    //}
            //            //    //else
            //            //    task.DepatmentID = dictTask.ContainsKey("String_10")?Convert.ToInt32(dictTask["Dept"]):0;
            //            //}

            //            BLDepartmentRepository blDept = new BLDepartmentRepository();
            //            task.DepatmentID = dictTask.ContainsKey("Dept") ? Convert.ToInt32(dictTask["Dept"]) : blDept.GetDepartmentByName("Not Selected");


            //            task.TaskName = Convert.ToString(dictTask["TaskName"]);
            //            //task.DeliverableNo = dictTask.ContainsKey("DeliverableNo") ? Convert.ToString(dictTask["DeliverableNo"]) : "";
            //            task.DeliverableNo = dictTask.ContainsKey("DeliverableNo") ? dictTask["DeliverableNo"] != null ? Convert.ToString(dictTask["DeliverableNo"]).Trim() : "" : "";

            //            if (dictTask.ContainsKey("DeliverableNo") && dictTask["DeliverableNo"] != null)
            //            {
            //                BLTaskListRepository bltask = new BLTaskListRepository();
            //                BLUserRepository blUsr = new BLUserRepository();
            //                User user = blUsr.GetuserByID(Convert.ToInt32(UserID));

            //              var  iCompanyID = Convert.ToInt32(user.CompanyId);
            //                List<ProjectTaskList> lst = bltask.GetAllTaskListWithCompanyID(Convert.ToInt32(user.CompanyId)).Where(c => !string.IsNullOrEmpty(c.DeliverableNo)).ToList<ProjectTaskList>();
            //                if (lst.Count > 0)
            //                {
            //                    bool delno = lst.AsEnumerable().Any(c => task.DeliverableNo.ToUpper() == c.DeliverableNo.ToUpper() && c.ProjectTaskID!= Convert.ToInt32(PrimaryId) && c.ProjectID == Convert.ToInt32(ProjectID));
            //                    if (delno)
            //                    {
            //                        result.Message = "Deliverable number already exists.";
            //                        result.MessageType = "E";
            //                        return result;
            //                    }
            //                }
            //            }




            //            task.TaskTypeID = dictTask.ContainsKey("Type") ? Convert.ToInt32(dictTask["Type"]) : task.TaskTypeID;

            //            if (!dictTask.ContainsKey("Duration"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDate(Convert.ToString(dictTask["StartDate"]), Convert.ToString(dictTask["EndDate"]), 0, Convert.ToInt32(ProjectID));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("Duration", d1["Duration"]);
            //                //dictTask.Add("Duration", "1");
            //            }
            //            task.Duration = Convert.ToInt32(dictTask["Duration"]);
            //            if (dictTask.ContainsKey("Owner"))
            //            {
            //                orgTaskOwner = Convert.ToString(task.TaskOwner) == "0" ? "0" : Convert.ToString(task.TaskOwner);
            //                if (Convert.ToString(dictTask["Owner"]) != "0" && (orgTaskOwner != Convert.ToString(dictTask["Owner"])))
            //                {

            //                    int TaskOwner = Convert.ToInt32(dictTask["Owner"]);
            //                    if (lstSubTask.Count() > 0)
            //                        lstSubTask.ForEach(x => { x.TaskOwner = TaskOwner; x.EntityState = DominModel.EntityState.Modified; });

            //                    bSendNotificationToOwner = true;
            //                }
            //                task.TaskOwner = Convert.ToString(dictTask["Owner"]) == "" ? Convert.ToInt32(0) : Convert.ToInt32(dictTask["Owner"]);

            //            }
            //            if (!dictTask.ContainsKey("StartDate"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDuration(Convert.ToInt32(ProjectID), Convert.ToInt32(task.Duration));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("StartDate", d1["StartDate"]);
            //                dictTask.Add("EndDate", d1["EndDate"]);
            //            }


            //            task.TOTALHRS = IsManHoursDisable == "N" && dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : task.TOTALHRS;// IsManHoursDisable == "N" ? Convert.ToDecimal(dictTask["TOTALHRS"]) : 0;

            //            //task.TaskWeight = dictTask.ContainsKey("TaskWeight") ? Convert.ToDecimal(dictTask["TaskWeight"]) : task.TaskWeight;
            //            task.TaskCost = dictTask.ContainsKey("TaskCost") ? Convert.ToDecimal(dictTask["TaskCost"]) : task.TaskCost;

            //            task.AllottedHours = IsManHoursDisable == "N" && dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : task.AllottedHours;
            //            task.WBSID = dictTask.ContainsKey("WBSCode") ? Convert.ToString(dictTask["WBSCode"]) : task.WBSID;
            //            task.Priority = dictTask.ContainsKey("Priority") ? Convert.ToInt32(dictTask["Priority"]) : task.Priority;
            //            task.StartDate = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : task.StartDate;
            //            if (dictTask.ContainsKey("StartDate") && dictTask["StartDate"] != "" && dictTask["StartDate"] != null)
            //            {
            //                if (lstSubTask.Count() > 0)
            //                    lstSubTask.ForEach(x => { x.StartDate = task.StartDate; x.EntityState = DominModel.EntityState.Modified; });
            //            }
            //            if (dictTask.ContainsKey("EndDate") && dictTask["EndDate"] != "" && dictTask["EndDate"] != null)
            //            {
            //                task.EndDate = Convert.ToDateTime(dictTask["EndDate"], ci);
            //                task.EndDateOrg = Convert.ToDateTime(dictTask["EndDate"], ci);

            //                if (lstSubTask.Count() > 0)
            //                    lstSubTask.ForEach(x => { x.EndDate = task.EndDate; x.EntityState = DominModel.EntityState.Modified; });
            //            }
            //            //task.EndDate = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : task.EndDate;
            //            task.StartDateOrg = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : task.StartDate;
            //            //task.EndDateOrg = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : task.EndDate;

            //            task.Remarks = dictTask.ContainsKey("Remarks") ? Convert.ToString(dictTask["Remarks"]) : task.Remarks;
            //            task.CreatedBy = Convert.ToInt32(UserID);
            //            task.CreatedOn = DateTime.Now;
            //            task.IsScheduled = "N";
            //            task.Cost = dictTask.ContainsKey("Cost") ? Convert.ToDecimal(dictTask["Cost"]) : 0;
            //            task.TotalCost = dictTask.ContainsKey("TotalCost") ? Convert.ToDecimal(dictTask["TotalCost"]) : 0;
            //            task.Quantity = dictTask.ContainsKey("Quantity") ? Convert.ToDecimal(dictTask["Quantity"]) : 0;
            //            task.CurrencyID = dictTask.ContainsKey("Currency") ? Convert.ToInt32(dictTask["Currency"]) : 0;
            //            task.ParentTaskID = dictTask.ContainsKey("ParentTaskID") ? Convert.ToInt32(dictTask["ParentTaskID"]) : task.ParentTaskID;
            //            task.MasterTaskType = Convert.ToInt32(MasterTaskType);
            //            task.IsDeliverable = true;// dictTask.ContainsKey("vIsDeliverable") && dictTask["vIsDeliverable"] != "" ? Convert.ToBoolean(dictTask["vIsDeliverable"]) : false;

            //            task.TaskWeight = dictTask.ContainsKey("TaskWeight") ? Convert.ToDecimal(dictTask["TaskWeight"]) : 100;
            //            task.EntityState = DominModel.EntityState.Modified;
            //            if (Convert.ToString(task.IsgroupTask) == "Y")
            //            {
            //                IList<ProjectTaskList> lstSubtask = blTask.GetAllSubtasksByGroupTaskID(Convert.ToInt32(PrimaryId));

            //                if (lstSubtask.Count > 0)
            //                {
            //                    foreach (var t in lstSubtask)
            //                    {
            //                        t.WBSID = dictTask.ContainsKey("WBSCode") ? Convert.ToString(dictTask["WBSCode"]) : task.WBSID;
            //                        t.EntityState = DominModel.EntityState.Modified;
            //                        lsttaskupdate.Add(t);
            //                    }
            //                }
            //            }
            //        }

            //        if (Convert.ToInt32(originalGrTaskVal["Duration"]) != task.Duration || (originalGrTaskVal["StartDate"] != "" && Convert.ToDateTime(originalGrTaskVal["StartDate"]) != task.StartDate) || (originalGrTaskVal["EndDate"] != "" && Convert.ToDateTime(originalGrTaskVal["EndDate"]) != task.EndDate))
            //        {
            //            List<ProjectTaskList> groupTasks = editGroupTaskLogic(task);
            //            if (groupTasks != null)
            //            {
            //                if (Convert.ToInt32(ScopeChangeID) > 0)
            //                {
            //                    foreach (var v in groupTasks)
            //                    {
            //                        blTask.TaskUnderScopeChangeGrTask(UserID, v, "E", ScopeChangeID.ToString());
            //                    }
            //                }
            //                groupTasks = groupTasks.Select(x => { x.EntityState = DominModel.EntityState.Modified; x.StartDate = task.StartDate; x.EndDate = task.EndDate; x.Duration = task.Duration; x.TaskNo = task.TaskNo; return x; }).ToList<ProjectTaskList>();
            //                blTask.UpdateTaskList(groupTasks.ToArray());
            //            }
            //        }
            //        else if (isTaskNoDecimal)
            //        {
            //            List<ProjectTaskList> groupTasks = editGroupTaskLogic(task);
            //            if (groupTasks != null)
            //            {
            //                groupTasks = groupTasks.Select(x => { x.EntityState = DominModel.EntityState.Modified; x.TaskNo = task.TaskNo; return x; }).ToList<ProjectTaskList>();
            //                blTask.UpdateTaskList(groupTasks.ToArray());
            //            }
            //        }

            //        //if (task.IsgroupTask != "Y" && task.GroupTaskID > 0)
            //        //{
            //        //    ProjectTaskList prGroupTask = blTask.GetTaskListByID(Convert.ToInt32(task.GroupTaskID));
            //        //    if (!(task.StartDate >= prGroupTask.StartDate && task.EndDate <= prGroupTask.EndDate))
            //        //    {
            //        //        resultMsg += "Subtask duration must be between parent task.";
            //        //    }
            //        //}

            //        ////// type == "PROGRESS"

            //        List<TaskMilestoneTargetDate> lstAddTaskMile = new List<TaskMilestoneTargetDate>();

            //        if (lstSubTask.Count() > 0)
            //        {
            //            foreach (var subTask in lstSubTask)
            //            {
            //                List<TaskMilestoneTargetDate> lstTmtSubTask = BLTaskMilestoneTargetDates.GetAllTaskMilestoneTargetDatesByTaskID(Convert.ToInt32(subTask.ProjectTaskID));
            //                lstTmtSubTask.ForEach(x => x.EntityState = DominModel.EntityState.Deleted);
            //                lstTmtSubTaskRemove.Add(lstTmtSubTask);
            //            }
            //        }


            //        var q = item
            //               .Where(i => i.Value[0] == "PROGRESS");



            //        NewBLEstimationTaskListRepository blObjEst = new NewBLEstimationTaskListRepository();
            //        var lstMilestoneReq = blObjEst.getMilestoneIdByTaskTypeID(Convert.ToInt32(ProjectID), Convert.ToInt32(task.NormsID), Convert.ToInt32(task.TaskTypeID));

            //        foreach (var x in lstMilestoneReq)
            //        {
            //            bool notExists = true;
            //            foreach (var t in q)
            //            {

            //                if (t.Key == x.ProjectMilestoneID.ToString())
            //                {
            //                    notExists = false;
            //                    ////Validation
            //                    Nullable<DateTime> dt = null;
            //                    //EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //                    //validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, Convert.ToInt32(t.Key), "", out result, lstMilestoneReq);
            //                    // resultMsg += result.Message;
            //                    //////////////
            //                    //if (result.Message.Length <= 0)
            //                    //{

            //                    if (blObjEst.IsValidMilestone(Convert.ToInt32(ProjectID), Convert.ToInt32(task.TaskTypeID), Convert.ToInt32(t.Key)))
            //                    {


            //                        TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //                        tmt.MileStoneID = Convert.ToInt32(x.ProjectMilestoneID);

            //                        tmt.TaskMilestoneTargetDates = Convert.ToString(t.Value[2] as object) != "" ? Convert.ToDateTime(t.Value[2], ci) : dt;
            //                        tmt.TaskTypeID = Convert.ToInt32(task.TaskTypeID);//Convert.ToInt32(dictTask["Type"]);
            //                        tmt.EntityState = DominModel.EntityState.Added;
            //                        lstAddTaskMile.Add(tmt);
            //                    }
            //                    //}


            //                }
            //            }
            //            if (notExists == true)
            //            {
            //                TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //                tmt.MileStoneID = Convert.ToInt32(x.ProjectMilestoneID);
            //                tmt.TaskMilestoneTargetDates = null;
            //                tmt.TaskTypeID = Convert.ToInt32(task.TaskTypeID);//Convert.ToInt32(dictTask["Type"]);
            //                tmt.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskMile.Add(tmt);
            //            }

            //        }

            //        if (lstMilestoneReq.Count() == 0)
            //        {
            //            List<TaskTypeWiseProgress> reqMilestone = blObjEst.getMilestoneRequired(Convert.ToInt32(ProjectID), Convert.ToInt32(task.TaskTypeID));
            //            List<TaskMilestoneTargetDate> lstTmtTask = BLTaskMilestoneTargetDates.GetAllTaskMilestoneTargetDatesByTaskID(Convert.ToInt32(PrimaryId));

            //            lstTmt = lstTmt.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskMilestoneTargetDate>();
            //        }
















            //        //if (q.Count() > 0)
            //        //{
            //        //    lstTmt = lstTmt.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskMilestoneTargetDate>();

            //        //    foreach (var t in q)
            //        //    {
            //        //        ////Validation
            //        //        EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //        //        validateTaskEntry(Convert.ToInt32(normId), isPriojectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, 0, "", out result, null);
            //        //        resultMsg += result.Message;
            //        //        //////////////


            //        //        if (result.Message.Length <= 0)
            //        //        {
            //        //            Nullable<DateTime> dt = null;
            //        //            if (blObjEst.IsValidMilestone(Convert.ToInt32(ProjectID), Convert.ToInt32(task.TaskTypeID), Convert.ToInt32(t.Key)))
            //        //            {
            //        //                TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //        //                tmt.TaskID = Convert.ToInt32(PrimaryId);
            //        //                tmt.MileStoneID = Convert.ToInt32(t.Key);
            //        //                tmt.TaskMilestoneTargetDates = Convert.ToString(t.Value[2] as object) != "" ? Convert.ToDateTime(t.Value[2], ci) : dt;
            //        //                tmt.TaskTypeID = Convert.ToInt32(task.TaskTypeID);//Convert.ToInt32(dictTask["Type"]);
            //        //                tmt.EntityState = DominModel.EntityState.Added;
            //        //                lstAddTaskMile.Add(tmt);

            //        //                //lstSubTask = blTask.getSubTaskDetailsByParentTaskId(Convert.ToInt32(PrimaryId));
            //        //                if (lstSubTask.Count() > 0)
            //        //                {
            //        //                    foreach (var subTask in lstSubTask)
            //        //                    {
            //        //                        TaskMilestoneTargetDate tmtSubTask = new TaskMilestoneTargetDate();
            //        //                        tmtSubTask.TaskID = Convert.ToInt32(subTask.ProjectTaskID);
            //        //                        tmtSubTask.MileStoneID = Convert.ToInt32(t.Key);
            //        //                        tmtSubTask.TaskMilestoneTargetDates = Convert.ToString(t.Value[2] as object) != "" ? Convert.ToDateTime(t.Value[2], ci) : dt;
            //        //                        tmtSubTask.TaskTypeID = Convert.ToInt32(task.TaskTypeID);//Convert.ToInt32(dictTask["Type"]);
            //        //                        tmtSubTask.EntityState = DominModel.EntityState.Added;

            //        //                        lstTmtSubTaskAdd.Add(tmtSubTask);
            //        //                    }

            //        //                }
            //        //            }



            //        //        }
            //        //    }
            //        //}
            //        //else
            //        //{

            //        //    List<TaskTypeWiseProgress> reqMilestone = blObjEst.getMilestoneRequired(Convert.ToInt32(ProjectID), Convert.ToInt32(task.TaskTypeID));
            //        //    List<TaskMilestoneTargetDate> lstTmtTask = BLTaskMilestoneTargetDates.GetAllTaskMilestoneTargetDatesByTaskID(Convert.ToInt32(PrimaryId));

            //        //    lstTmt = lstTmt.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskMilestoneTargetDate>();
            //        //    //foreach (var mileItem in reqMilestone)
            //        //    //{

            //        //    //    if (lstSubTask.Count() > 0)
            //        //    //    {
            //        //    //        foreach (var subTask in lstSubTask)
            //        //    //        {
            //        //    //            TaskMilestoneTargetDate tmtSubTask = new TaskMilestoneTargetDate();
            //        //    //            tmtSubTask.TaskID = Convert.ToInt32(subTask.ProjectTaskID);
            //        //    //            tmtSubTask.MileStoneID = Convert.ToInt32(mileItem.ProjectMilestoneID);
            //        //    //            tmtSubTask.TaskMilestoneTargetDates = lstTmtTask.Where(x => x.MileStoneID == mileItem.ProjectMilestoneID).Select(x=>x.TaskMilestoneTargetDates).FirstOrDefault();
            //        //    //            tmtSubTask.TaskTypeID = Convert.ToInt32(dictTask["Type"]);
            //        //    //            tmtSubTask.EntityState = DominModel.EntityState.Added;
            //        //    //            lstTmtSubTaskAdd.Add(tmtSubTask);
            //        //    //        }

            //        //    //    }
            //        //    //}

            //        //}

              

            //        BLTaskMilestoneTargetDates blTaskMileTD = new BLTaskMilestoneTargetDates();
            //        BLProjectMilestoneRepository blPrMilestone = new BLProjectMilestoneRepository();
            //        int msgMileCnt = 0;
            //        string strMileStoneCode = "", strMilestoneOldDate = "", strMilestoneNewDate = "";
            //        List<TaskMilestoneTargetDate> lstTarget = blTaskMileTD.GetAllTaskMilestoneTargetDateByDeliverableID(task.ProjectTaskID);
            //        List<ProjectMilestone> lstPm = blPrMilestone.GetMilestoneByProjectID(task.ProjectID);
            //        foreach (var t in lstAddTaskMile)
            //        {
            //            List<TaskMilestoneTargetDate> ttd = lstTarget.Where(a => a.MileStoneID == t.MileStoneID).ToList<TaskMilestoneTargetDate>();
            //            if (ttd.Count() > 0)
            //            {
            //                if (t.TaskMilestoneTargetDates != ttd[0].TaskMilestoneTargetDates)
            //                {
            //                    List<ProjectMilestone> lstM = lstPm.Where(a => a.ProjectMilestoneID == t.MileStoneID).ToList<ProjectMilestone>();
            //                    if (lstM.Count() > 0)
            //                    {
            //                        msgMileCnt = msgMileCnt + 1;
            //                        strMileStoneCode = strMileStoneCode + lstM[0].MileStone + ",";
            //                        strMilestoneNewDate = t.TaskMilestoneTargetDates == null ? "Nothing" : Convert.ToDateTime(t.TaskMilestoneTargetDates).ToString("dd/MM/yyyy");
            //                        strMilestoneOldDate = ttd[0].TaskMilestoneTargetDates == null ? "Nothing" : Convert.ToDateTime(ttd[0].TaskMilestoneTargetDates).ToString("dd/MM/yyyy");
            //                    }
            //                }
            //            }
            //        }


            //        ////// type == "DESN"
            //        bool DesnHrsRequired = false;
            //        List<TaskDesignation> lstAddTaskDesn = new List<TaskDesignation>();
            //        var r = item
            //               .Where(i => i.Value[0] == "DESN");
            //        foreach (var t in r)
            //        {
            //            if (Convert.ToString(t.Value[2]) != "" && Convert.ToDecimal(t.Value[2]) > 0)
            //            {
            //                ////Validation
            //                EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //                validateTaskEntry(Convert.ToInt32(normId), isPriojectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, 0, "", out result, null);
            //                //////////////
            //                decimal n;
            //                bool isMesNumeric = decimal.TryParse(result.Message, out n);
            //                if (isMesNumeric)
            //                {
            //                    if (Convert.ToDecimal(t.Value[2]) != n)
            //                    {
            //                        t.Value[2] = Convert.ToString(n);
            //                    }
            //                }

            //                TaskDesignation desgn = new TaskDesignation();
            //                desgn.ProjectTaskID = Convert.ToInt32(PrimaryId);
            //                desgn.DesignationID = Convert.ToInt32(t.Key);
            //                desgn.Hours = Convert.ToDecimal(t.Value[2]);
            //                desgn.ProjectID = Convert.ToInt32(ProjectID);
            //                desgn.DepartmentID = Convert.ToInt32(dictTask["Dept"]);
            //                desgn.NormID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //                desgn.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskDesn.Add(desgn);
            //                DesnHrsRequired = true;
            //            }
            //        }

            //        //For Milestone task type
            //        BLTaskTypeRepository blTaskType = new BLTaskTypeRepository();
            //        //TaskType tt = blTaskType.getTaskTypeByMilestoneGroup();
            //        //if (tt != null && task.TaskTypeID == tt.TaskTypeID)
            //        //{
            //        //    task.TaskOwner = pr.ProjectLeader;
            //        //    //IsManHoursDisable = "Y";
            //        //}

            //        //if (IsManHoursDisable == "Y")
            //        //{
            //        //    DesnHrsRequired = true;
            //        //}
            //        //if (!DesnHrsRequired)
            //        //{
            //        //    if (dictVar["GroupTaskTypeId"] == Convert.ToString(task.TaskTypeID))
            //        //    {
            //        //    }
            //        //    else
            //        //    {
            //        //        resultMsg += "Please enter atleast one designation hour.";
            //        //    }
            //        //}

            //        ////// type == "DETAIL"

            //        List<TaskDetail> lstAddTaskDet = new List<TaskDetail>();
            //        var s = item
            //               .Where(i => i.Value[0] == "DETAIL");
            //        foreach (var t in s)
            //        {
            //            ////Validation
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //            validateTaskEntry(Convert.ToInt32(normId), isPriojectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), Convert.ToInt32(PrimaryId), t.Value[3], out result, null);
            //            resultMsg += result.Message;
            //            //////////////
            //            if (result.Message.Length <= 0 && Convert.ToString(t.Value[2] as object) != "")
            //            {
            //                if (est.DependonNorms == "N" || (est.DependonNorms == "Y" && Convert.ToInt32(normId) != 0))
            //                {
            //                    TaskDetail det = new TaskDetail();
            //                    det.ProjectTaskID = Convert.ToInt32(PrimaryId);
            //                    det.EstimationTaskColumnID = Convert.ToInt32(t.Key);
            //                    det.ColValue = t.Value[2];
            //                    det.EntityState = DominModel.EntityState.Added;
            //                    lstAddTaskDet.Add(det);
            //                }
            //            }
            //        }



            //        if (resultMsg.Length == 0)
            //        {

            //            if (originalGrTaskVal["DepatmentID"] != Convert.ToString(task.DepatmentID) || Convert.ToInt32(originalGrTaskVal["Duration"]) != task.Duration || (originalGrTaskVal["StartDate"] != "" && Convert.ToDateTime(originalGrTaskVal["StartDate"]) != task.StartDate) || (originalGrTaskVal["EndDate"] != "" && Convert.ToDateTime(originalGrTaskVal["EndDate"]) != task.EndDate))
            //            {
            //                task.LOCK = 0;
            //            }

            //            if (lstAddTaskDesn.Count() != 0)
            //            {
            //                if (lstDesgn.Count() == lstAddTaskDesn.Count())
            //                {
            //                    decimal lstDesgnHrs = lstDesgn.Sum(x => x.Hours);
            //                    decimal lstAddTaskDesnHrs = lstAddTaskDesn.Sum(x => x.Hours);
            //                    if (lstDesgnHrs != lstAddTaskDesnHrs)
            //                    {
            //                        task.LOCK = 0;
            //                    }
            //                    else
            //                    {
            //                        foreach (var itemDesn in lstDesgn)
            //                        {
            //                            var tt = (from dq in lstAddTaskDesn where dq.DesignationID == itemDesn.DesignationID select dq).FirstOrDefault();
            //                            if (tt == null || tt.Hours != itemDesn.Hours)
            //                            {
            //                                task.LOCK = 0;
            //                            }
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    task.LOCK = 0;
            //                }
            //            }

            //            lstAddTaskMile = lstAddTaskMile.Select(x => { x.TaskID = Convert.ToInt32(PrimaryId); return x; }).ToList<TaskMilestoneTargetDate>();

            //            blTask.UpdateTaskList(task);
            //            blTask.UpdateTaskList(lsttaskupdate.ToArray());
            //            blTask.UpdateTaskList(lstSubTask.ToArray());
            //            //foreach (var itemRemove in lstTmtSubTaskRemove)
            //            //{
            //            //    blTaskMile.RemoveTaskMilestoneTargetDates(itemRemove.ToArray());
            //            //}
            //            //blTaskMile.AddTaskMilestoneTargetDates(lstTmtSubTaskAdd.ToArray());



            //            lstTmt = lstTmt.Select(x => { x.EntityState = DominModel.EntityState.Deleted; ; return x; }).ToList<TaskMilestoneTargetDate>();
            //            blTaskMile.RemoveTaskMilestoneTargetDates(lstTmt.ToArray());
            //            blTaskMile.AddTaskMilestoneTargetDates(lstAddTaskMile.ToArray());
            //            if (lstAddTaskDesn.Count() != 0)
            //                blTaskDesn.RemoveTaskDesignation(lstDesgn.ToArray());

            //            blTaskDesn.AddTaskDesignation(lstAddTaskDesn.ToArray());
            //            blTaskDet.RemoveTaskDetails(lstDet.ToArray());
            //            blTaskDet.AddTaskDetails(lstAddTaskDet.ToArray());

            //            BLUserRepository blUsers = new BLUserRepository();
            //            User objuser = blUsers.GetuserByID(Convert.ToInt32(UserID));
            //            List<Message> lstMessage = new List<Message>();
            //            if (msgMileCnt > 0)
            //            {
            //                string MMsg = "";
            //                string orMessage = "";
            //                if (msgMileCnt == 1)
            //                {
            //                    orMessage = MessageConstants.progressLevelDateChangeSingle;
            //                    //MessageConstants.progressLevelDateChangeSingle.Replace("#TPLAbbreviation#", strMileStoneCode.TrimEnd(',')).Replace("#OldDate#", strMilestoneOldDate).Replace("#NewDate#", strMilestoneNewDate).Replace("#DeliverableName#", Convert.ToString(task.TaskName));
            //                    MMsg = MessageConstants.progressLevelDateChangeSingle.Replace("#TPLAbbreviation#", strMileStoneCode.TrimEnd(',')).Replace("#OldDate#", strMilestoneOldDate).Replace("#NewDate#", strMilestoneNewDate).Replace("#DeliverableName#", Convert.ToString(task.TaskName));

            //                }
            //                else
            //                {
            //                    orMessage = MessageConstants.progressLevelDateChange;
            //                    MMsg = MessageConstants.progressLevelDateChange.Replace("#TPLAbbreviation#", strMileStoneCode.TrimEnd(',')).Replace("#DeliverableName#", Convert.ToString(task.TaskName));
            //                }

            //                BLProjectsAdminRepository blAdmin = new BLProjectsAdminRepository();


            //                List<User> PAdm = blAdmin.GetProjectAdminByProjectID(task.ProjectID).ToList<User>();
            //                foreach (var u in PAdm)
            //                {
            //                    Message ms = new Message();
            //                    ms.FromUserID = Convert.ToString(UserID);
            //                    ms.ToUserID = Convert.ToString(u.UserID);
            //                    ms.RedirectURL = "EstimationSlickTaskCreation.aspx";
            //                    ms.QueryString = "ProjectID=" + Convert.ToString(task.ProjectID);
            //                    ms.MessageFor = "EstimationSlickTaskCreation";
            //                    ms.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //                    ms.MessageType = "N";
            //                    ms.Message1 = MMsg;
            //                    ms.Active = "Y";
            //                    ms.Date = DateTime.Now;
            //                    ms.EntityState = DominModel.EntityState.Added;
            //                    lstMessage.Add(ms);
            //                    BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();
            //                    MessageTemplate mst = new MessageTemplate();
            //                    mst = blmt.GetMessageTemplateByMessage(orMessage);

            //                    if (mst != null && mst.IsEmail == true)
            //                    {

            //                        blmt.SendNotification(Convert.ToInt32(UserID), MMsg, Convert.ToInt32(u.UserID));
            //                    }
            //                }

            //                if (task.TaskOwner != null && task.TaskOwner > 0 && !lstMessage.Select(a => a.ToUserID).Contains(Convert.ToString(task.TaskOwner)))
            //                {
            //                    Message ms = new Message();
            //                    ms.FromUserID = Convert.ToString(UserID);
            //                    ms.ToUserID = Convert.ToString(task.TaskOwner);
            //                    ms.RedirectURL = "EstimationSlickTaskCreation.aspx";
            //                    ms.QueryString = "ProjectID=" + Convert.ToString(task.ProjectID);
            //                    ms.MessageFor = "EstimationSlickTaskCreation";
            //                    ms.MessageType = "N";
            //                    ms.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //                    ms.Message1 = MMsg;
            //                    ms.Active = "Y";
            //                    ms.Date = DateTime.Now;
            //                    ms.EntityState = DominModel.EntityState.Added;
            //                    lstMessage.Add(ms);
            //                    BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();
            //                    MessageTemplate mst = new MessageTemplate();
            //                    mst = blmt.GetMessageTemplateByMessage(orMessage);

            //                    if (mst != null && mst.IsEmail == true)
            //                    {

            //                        blmt.SendNotification(Convert.ToInt32(UserID), MMsg, Convert.ToInt32(task.TaskOwner));
            //                    }
            //                }

            //                if (pr.ProjectLeader != null && pr.ProjectLeader > 0 && !lstMessage.Select(a => a.ToUserID).Contains(Convert.ToString(pr.ProjectLeader)))
            //                {
            //                    Message ms = new Message();
            //                    ms.FromUserID = Convert.ToString(UserID);
            //                    ms.ToUserID = Convert.ToString(pr.ProjectLeader);
            //                    ms.RedirectURL = "EstimationSlickTaskCreation.aspx";
            //                    ms.QueryString = "ProjectID=" + Convert.ToString(task.ProjectID);
            //                    ms.MessageFor = "EstimationSlickTaskCreation";
            //                    ms.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //                    ms.MessageType = "N";
            //                    ms.Message1 = MMsg;
            //                    ms.Active = "Y";
            //                    ms.Date = DateTime.Now;
            //                    ms.EntityState = DominModel.EntityState.Added;
            //                    lstMessage.Add(ms);
            //                    BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();
            //                    MessageTemplate mst = new MessageTemplate();
            //                    mst = blmt.GetMessageTemplateByMessage(orMessage);

            //                    if (mst != null && mst.IsEmail == true)
            //                    {

            //                        blmt.SendNotification(Convert.ToInt32(UserID), MMsg, Convert.ToInt32(pr.ProjectLeader));
            //                    }
            //                }

            //            }
            //            if (bSendNotificationToOwner == true)
            //            {
            //                Message ms = new Message();
            //                ms.FromUserID = Convert.ToString(UserID);
            //                ms.ToUserID = Convert.ToString(task.TaskOwner);

            //                //ms.RedirectURL = "EstimationSlickTaskCreation.aspx";
            //                //ms.QueryString = "ProjectID=" + Convert.ToString(task.ProjectID);
            //                //ms.MessageFor = "EstimationSlickTaskCreation";

            //                TaskType ttype = blTaskType.GetTaskTypeByID(task.TaskTypeID);
            //                if (ttype.ActivityType == Convert.ToInt32(Common.ActivityType.General))
            //                    ms.RedirectURL = "UploadDeliverablesGeneralActivity.aspx";
            //                else
            //                    ms.RedirectURL = "UploadDeliverables.aspx";

            //                //ms.RedirectURL = "UploadDeliverables.aspx";
            //                ms.MessageFor = "UploadDeliverables";
            //                ms.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //                ms.QueryString = "DeliverableID=" + Convert.ToString(task.ProjectTaskID);

            //                ms.MessageType = "N";
            //                ms.Message1 = Common.MessageConstants.SendNotificationToDeliverableOwner.Replace("#AssigneeName#", Convert.ToString(objuser.FirstName) + " " + Convert.ToString(objuser.LastName)).Replace("#ProjectName#", Convert.ToString(objProject.ProjectName)).Replace("#DeliverableName#", Convert.ToString(task.TaskName));


            //                ms.Active = "Y";
            //                ms.Date = DateTime.Now;
            //                ms.EntityState = DominModel.EntityState.Added;
            //                lstMessage.Add(ms);
            //                BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();
            //                MessageTemplate mst = new MessageTemplate();
            //                mst = blmt.GetMessageTemplateByMessage(Common.MessageConstants.SendNotificationToDeliverableOwner);

            //                if (mst != null && mst.IsEmail == true)
            //                {

            //                    blmt.SendNotification(Convert.ToInt32(UserID), ms.Message1, Convert.ToInt32(task.TaskOwner));
            //                }
            //            }
            //            if (lstMessage.Count() > 0)
            //            {
            //                BLMessageRepository blMsg = new BLMessageRepository();
            //                blMsg.AddMessage(lstMessage.ToArray());
            //            }
            //            ts.Complete();



            //            result.Message = MessageConstants.OperationSuccess;
            //            result.MessageType = "S";
            //        }
            //        else
            //        {
            //            ts.Dispose();
            //            result.Message = resultMsg;
            //            result.MessageType = "E";
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        result.Message = "Error";
            //        result.MessageType = "E";
            //    }

            //    return result;
            //}
            return result;
        }

        private List<ProjectTaskList> editGroupTaskLogic(ProjectTaskList vTasK)
        {
            List<ProjectTaskList> groupTasks = null;
            if (vTasK.IsgroupTask == "Y")
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    groupTasks = context.ProjectTaskLists.Where(a => a.GroupTaskID == vTasK.ProjectTaskID).ToList<ProjectTaskList>();
                //}
            }
            return groupTasks;
        }

        public OperationResult editEstimationTask_Contract(string PrimaryId, string ProjectID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string MasterTaskType = "1")
        {
            OperationResult result = new OperationResult();
            //CultureInfo ci = new CultureInfo("en-Gb");
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        string resultMsg = "";
            //        bool isProjectLeader = false;

            //        BLTaskListRepository_Contract blTask = new BLTaskListRepository_Contract();
            //        ProjectTaskList_Contract task = blTask.getTaskDetailsByTaskId(Convert.ToInt32(PrimaryId));

            //        BLTaskDesignationRepository_Contract blTaskDesn = new BLTaskDesignationRepository_Contract();
            //        BLTaskMilestoneTargetDates_Contract blTaskMile = new BLTaskMilestoneTargetDates_Contract();
            //        BLTaskDeatilsRepository_Contract blTaskDet = new BLTaskDeatilsRepository_Contract();

            //        List<TaskDesignation_Contract> lstDesgn = blTaskDesn.GetTaskDesignationByProjectTaskID(Convert.ToInt32(PrimaryId));
            //        lstDesgn = lstDesgn.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskDesignation_Contract>();
            //        List<TaskDetail_Contract> lstDet = BLTaskDeatilsRepository_Contract.GetAllDetailsByTaskID(Convert.ToInt32(PrimaryId));
            //        lstDet = lstDet.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskDetail_Contract>();
            //        List<TaskMilestoneTargetDates_Contract> lstTmt = BLTaskMilestoneTargetDates_Contract.GetAllTaskMilestoneTargetDatesByTaskID(Convert.ToInt32(PrimaryId));
            //        lstTmt = lstTmt.Select(x => { x.EntityState = DominModel.EntityState.Deleted; return x; }).ToList<TaskMilestoneTargetDates_Contract>();

            //        Dictionary<string, string> dictTask = new Dictionary<string, string>();

            //        BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //        List<EstimationTaskColumnsMaster> lstColMaster = blObj.GetAllEstimationTaskColumnsMastersByProjectID(Convert.ToInt32(ProjectID), Convert.ToInt32(MasterTaskType)).ToList<EstimationTaskColumnsMaster>();

            //        var normId = item
            //               .Where(i => i.Value[1] == "Norm").Select(a => a.Value[2]).SingleOrDefault();

            //        BLNormsDetailRepository blNormDet = new BLNormsDetailRepository();
            //        List<NormDesDet> lstNormDet = blNormDet.getNormsDesDetailsByNormIDCls(Convert.ToInt32(normId));

            //        var eq = lstColMaster.Where(a => Convert.ToString(a.EquationID as object) != "" || Convert.ToString(a.Equationvalidation as object) != "").Select(a => Convert.ToString(a.EquationID as object) != "" ? a.EquationID : a.Equationvalidation);
            //        string[] separators = { "/", "*", "+", "-", "&", "|", " ", ">", "<", "=" };
            //        List<string> eqLst = new List<string>();
            //        foreach (var vEq in eq)
            //        {
            //            string[] arr = vEq.Split(separators, StringSplitOptions.None);
            //            eqLst.AddRange(arr.ToList());
            //        }

            //        eqLst = eqLst.Distinct().ToList<string>();
            //        var pEqVal = item
            //               .Where(i => eqLst.Contains(i.Value[4])).Select(a => new NormDesDet { NameInDb = a.Value[4], ColValue = a.Value[2] });

            //        var pEqValNorm = lstNormDet.Where(i => eqLst.Contains(i.NameInDb));


            //        BLProjectCreationRepository blObjPr = new BLProjectCreationRepository();
            //        Project pr = blObjPr.GetProjectByID(Convert.ToInt32(ProjectID));
            //        if (pr.ProjectLeader == Convert.ToInt32(UserID))
            //        {
            //            isProjectLeader = true;
            //        }
            //        else
            //        {
            //            List<ProjectsAdmin> lst = blObjPr.getProjectAdmin(Convert.ToInt32(ProjectID));
            //            if (lst.Select(a => a.UserID).Contains(Convert.ToInt32(UserID)))
            //            {
            //                isProjectLeader = true;
            //            }
            //        }


            //        ////// TYPE== "VAR"
            //        Dictionary<string, string> dictVar = new Dictionary<string, string>();
            //        var pV = item
            //               .Where(i => i.Value[0] == "VAR").Select(a => a.Value);
            //        foreach (var t in pV)
            //        {
            //            dictVar.Add(t[1], t[2]);
            //        }


            //        ////// type == "TASK"

            //        var p = item
            //               .Where(i => i.Value[0] == "TASK").Select(a => a.Value);
            //        foreach (var t in p)
            //        {
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t[3])).SingleOrDefault();
            //            if (est != null)
            //            {
            //                validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), Convert.ToInt32(PrimaryId), t[1], out result, null);
            //                if (est.PermanentNameInDb == "TOTALHRS")
            //                {
            //                    decimal n;
            //                    bool isDecimal = decimal.TryParse(result.Message, out n);
            //                    if (isDecimal)
            //                    {
            //                        t[2] = result.Message;
            //                    }
            //                }
            //                else if (est.PermanentNameInDb != "TOTALHRS")
            //                {
            //                    resultMsg += result.Message;
            //                }
            //            }
            //            dictTask.Add(t[1], t[2]);
            //        }

            //        if (resultMsg.Length <= 0)
            //        {
            //            if (vTaskNo != "")
            //            {
            //                int TaskNo = getNextTaskNumberByProjectID_Contract(Convert.ToInt32(ProjectID));
            //                decimal t;
            //                bool isTaskNoDecimal = decimal.TryParse(vTaskNo, out t);
            //                if (isTaskNoDecimal)
            //                {
            //                    if ((t % 1) == 0)
            //                    {
            //                        if (t < TaskNo)
            //                        {
            //                            TaskNo = Convert.ToInt32(t);
            //                            blTaskDet.updateTaskNo_Contract(Convert.ToInt32(ProjectID), TaskNo, 0, Convert.ToInt32(task.TaskNo));
            //                        }
            //                    }
            //                    else
            //                    {
            //                        string[] arr = t.ToString().Split('.');
            //                        int vDecPart = Convert.ToInt32(arr[1]);
            //                        TaskNo = Convert.ToInt32(arr[0]);
            //                        if (Convert.ToInt32(arr[0]) > TaskNo)
            //                        {
            //                            vDecPart = 0;
            //                        }
            //                        else
            //                        {
            //                            task.SubTaskNo = vDecPart;
            //                        }
            //                        blTaskDet.updateTaskNo_Contract(Convert.ToInt32(ProjectID), TaskNo, vDecPart, Convert.ToInt32(task.TaskNo));
            //                    }

            //                    task.TaskNo = TaskNo;
            //                }
            //            }

            //            task.NormsID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;



            //            task.DepatmentID = Convert.ToInt32(dictTask["Dept"]);
            //            task.TaskName = Convert.ToString(dictTask["TaskName"]);
            //            task.TaskTypeID = dictTask.ContainsKey("Type") ? Convert.ToInt32(dictTask["Type"]) : task.TaskTypeID;
            //            if (!dictTask.ContainsKey("Duration"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDate(Convert.ToString(dictTask["StartDate"]), Convert.ToString(dictTask["EndDate"]), 0, Convert.ToInt32(ProjectID));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("Duration", d1["Duration"]);
            //            }
            //            task.Duration = Convert.ToInt32(dictTask["Duration"]);

            //            if (!dictTask.ContainsKey("StartDate"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDuration(Convert.ToInt32(ProjectID), Convert.ToInt32(task.Duration));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("StartDate", d1["StartDate"]);
            //                dictTask.Add("EndDate", d1["EndDate"]);
            //            }

            //            task.TOTALHRS = dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : task.TOTALHRS;
            //            task.AllottedHours = dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : task.AllottedHours;
            //            task.WBSID = dictTask.ContainsKey("WBSCode") ? Convert.ToString(dictTask["WBSCode"]) : task.WBSID;
            //            task.Priority = dictTask.ContainsKey("Priority") ? Convert.ToInt32(dictTask["Priority"]) : task.Priority;
            //            task.StartDate = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : task.StartDate;
            //            task.EndDate = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : task.EndDate;
            //            task.StartDateOrg = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : task.StartDate;
            //            task.EndDateOrg = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : task.EndDate;



            //            task.Remarks = dictTask.ContainsKey("Remarks") ? Convert.ToString(dictTask["Remarks"]) : task.Remarks;
            //            task.CreatedBy = Convert.ToInt32(UserID);
            //            task.CreatedOn = DateTime.Now;
            //            task.IsScheduled = "N";

            //            task.IsDeliverable = true;// dictTask.ContainsKey("vIsDeliverable") && dictTask["vIsDeliverable"] != "" ? Convert.ToBoolean(dictTask["vIsDeliverable"]) : false;
            //            task.EntityState = DominModel.EntityState.Modified;
            //        }


            //        ////// type == "PROGRESS"

            //        List<TaskMilestoneTargetDates_Contract> lstAddTaskMile = new List<TaskMilestoneTargetDates_Contract>();
            //        var q = item
            //               .Where(i => i.Value[0] == "PROGRESS");
            //        List<object> lstMilestoneReq = null;
            //        if (q.Count() > 0)
            //        {
            //            NewBLEstimationTaskListRepository blObjEst = new NewBLEstimationTaskListRepository();
            //            int n;
            //            bool isNormIDNumeric = int.TryParse(Convert.ToString(task.NormsID), out n);
            //            if (isNormIDNumeric)
            //            {
            //                lstMilestoneReq = blObjEst.getMilestoneNotRequired(Convert.ToInt32(ProjectID), Convert.ToInt32(task.NormsID), Convert.ToInt32(task.TaskTypeID));
            //            }
            //        }
            //        foreach (var t in q)
            //        {
            //            ////Validation
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //            validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, 0, "", out result, null);
            //            resultMsg += result.Message;
            //            //////////////
            //            if (result.Message.Length <= 0 && Convert.ToString(t.Value[2] as object) != "")
            //            {
            //                TaskMilestoneTargetDates_Contract tmt = new TaskMilestoneTargetDates_Contract();
            //                tmt.TaskID = Convert.ToInt32(PrimaryId);
            //                tmt.MileStoneID = Convert.ToInt32(t.Key);
            //                tmt.TaskMilestoneTargetDates = Convert.ToDateTime(t.Value[2], ci);
            //                tmt.TaskTypeID = Convert.ToInt32(dictTask["Type"]);
            //                tmt.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskMile.Add(tmt);
            //            }
            //        }


            //        ////// type == "DESN"
            //        bool DesnHrsRequired = false;
            //        List<TaskDesignation_Contract> lstAddTaskDesn = new List<TaskDesignation_Contract>();
            //        var r = item
            //               .Where(i => i.Value[0] == "DESN");
            //        foreach (var t in r)
            //        {
            //            if (Convert.ToDecimal(t.Value[2]) > 0)
            //            {
            //                ////Validation
            //                EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //                validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, 0, "", out result, null);
            //                //////////////
            //                decimal n;
            //                bool isMesNumeric = decimal.TryParse(result.Message, out n);
            //                if (isMesNumeric)
            //                {
            //                    if (Convert.ToDecimal(t.Value[2]) != n)
            //                    {
            //                        t.Value[2] = Convert.ToString(n);
            //                    }
            //                }

            //                TaskDesignation_Contract desgn = new TaskDesignation_Contract();
            //                desgn.ProjectTaskID = Convert.ToInt32(PrimaryId);
            //                desgn.DesignationID = Convert.ToInt32(t.Key);
            //                desgn.Hours = Convert.ToDecimal(t.Value[2]);
            //                desgn.ProjectID = Convert.ToInt32(ProjectID);
            //                desgn.DepartmentID = Convert.ToInt32(dictTask["Dept"]);
            //                desgn.NormID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //                desgn.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskDesn.Add(desgn);
            //                DesnHrsRequired = true;
            //            }
            //        }

            //        //For Milestone task type
            //        BLTaskTypeRepository blTaskType = new BLTaskTypeRepository();
            //        TaskType tt = blTaskType.getTaskTypeByMilestoneGroup();
            //        if (task.TaskTypeID == tt.TaskTypeID)
            //        {
            //            task.TaskOwner = pr.ProjectLeader;
            //            DesnHrsRequired = true;
            //        }

            //        if (!DesnHrsRequired)
            //        {
            //            if (dictVar["GroupTaskTypeId"] == Convert.ToString(task.TaskTypeID))
            //            {
            //            }
            //            else
            //            {
            //                resultMsg += "Please enter atleast one designation hour.";
            //            }
            //        }

            //        ////// type == "DETAIL"

            //        List<TaskDetail_Contract> lstAddTaskDet = new List<TaskDetail_Contract>();
            //        var s = item
            //               .Where(i => i.Value[0] == "DETAIL");
            //        foreach (var t in s)
            //        {
            //            ////Validation
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //            validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), Convert.ToInt32(PrimaryId), t.Value[3], out result, null);
            //            resultMsg += result.Message;
            //            //////////////
            //            if (result.Message.Length <= 0 && Convert.ToString(t.Value[2] as object) != "")
            //            {
            //                if (est.DependonNorms == "N" || (est.DependonNorms == "Y" && Convert.ToInt32(normId) != 0))
            //                {
            //                    TaskDetail_Contract det = new TaskDetail_Contract();
            //                    det.ProjectTaskID = Convert.ToInt32(PrimaryId);
            //                    det.EstimationTaskColumnID = Convert.ToInt32(t.Key);
            //                    det.ColValue = t.Value[2];
            //                    det.EntityState = DominModel.EntityState.Added;
            //                    lstAddTaskDet.Add(det);
            //                }
            //            }
            //        }



            //        if (resultMsg.Length == 0)
            //        {
            //            blTask.UpdateTaskList(task);
            //            blTaskMile.RemoveTaskMilestoneTargetDates(lstTmt.ToArray());
            //            blTaskMile.AddTaskMilestoneTargetDates(lstAddTaskMile.ToArray());
            //            blTaskDesn.RemoveTaskDesignation(lstDesgn.ToArray());
            //            blTaskDesn.AddTaskDesignation(lstAddTaskDesn.ToArray());
            //            blTaskDet.RemoveTaskDetails(lstDet.ToArray());
            //            blTaskDet.AddTaskDetails(lstAddTaskDet.ToArray());

            //            ts.Complete();

            //            result.Message = MessageConstants.OperationSuccess;
            //            result.MessageType = "S";
            //        }
            //        else
            //        {
            //            ts.Dispose();
            //            result.Message = resultMsg;
            //            result.MessageType = "E";
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //    }

            //    return result;
            //}
            return result;
        }

        public OperationResult addEstimationTask(string ProjectID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string IsManHoursDisable, string MasterTaskType = "1")
        {
            OperationResult result = new OperationResult();
            Dictionary<string, string> dictReturnData = new Dictionary<string, string>();
            //CultureInfo ci = new CultureInfo("en-Gb");
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        string resultMsg = "";
            //        bool isProjectLeader = false;
            //        bool bSendNotificationToOwner = false;
            //        int iCompanyID = 0;
            //        BLTaskListRepository blTask = new BLTaskListRepository();
            //        BLTaskDesignationRepository blTaskDesn = new BLTaskDesignationRepository();
            //        BLTaskMilestoneTargetDates blTaskMile = new BLTaskMilestoneTargetDates();
            //        BLTaskDeatilsRepository blTaskDet = new BLTaskDeatilsRepository();
            //        Dictionary<string, string> dictTask = new Dictionary<string, string>();
            //        BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //        List<EstimationTaskColumnsMaster> lstColMaster = blObj.GetAllEstimationTaskColumnsMastersByProjectID(Convert.ToInt32(ProjectID), Convert.ToInt32(MasterTaskType)).ToList<EstimationTaskColumnsMaster>();
            //        var normId = item
            //               .Where(i => i.Value[1] == "Norm").Select(a => a.Value[2]).SingleOrDefault();

            //        BLNormsDetailRepository blNormDet = new BLNormsDetailRepository();
            //        List<NormDesDet> lstNormDet = blNormDet.getNormsDesDetailsByNormIDCls(Convert.ToInt32(normId));

            //        var eq = lstColMaster.Where(a => Convert.ToString(a.EquationID as object) != "" || Convert.ToString(a.Equationvalidation as object) != "").Select(a => Convert.ToString(a.EquationID as object) != "" ? a.EquationID : a.Equationvalidation);
            //        string[] separators = { "/", "*", "+", "-", "&", "|", " ", ">", "<", "=" };
            //        List<string> eqLst = new List<string>();
            //        foreach (var vEq in eq)
            //        {
            //            string[] arr = vEq.Split(separators, StringSplitOptions.None);
            //            eqLst.AddRange(arr.ToList());
            //        }
            //        eqLst = eqLst.Distinct().ToList<string>();
            //        var pEqVal = item
            //               .Where(i => eqLst.Contains(i.Value[4])).Select(a => new NormDesDet { NameInDb = a.Value[4], ColValue = a.Value[2] });

            //        var pEqValNorm = lstNormDet.Where(i => eqLst.Contains(i.NameInDb));
            //        BLProjectCreationRepository blObjPr = new BLProjectCreationRepository();
            //        Project pr = blObjPr.GetProjectByID(Convert.ToInt32(ProjectID));
            //        if (pr.ProjectLeader == Convert.ToInt32(UserID))
            //        {
            //            isProjectLeader = true;
            //        }
            //        else
            //        {
            //            List<ProjectsAdmin> lst = blObjPr.getProjectAdmin(Convert.ToInt32(ProjectID));
            //            if (lst.Select(a => a.UserID).Contains(Convert.ToInt32(UserID)))
            //            {
            //                isProjectLeader = true;
            //            }
            //        }


            //        ////// type == "TASK"
            //        ProjectTaskList task = new ProjectTaskList();
            //        var p = item
            //               .Where(i => i.Value[0] == "TASK").Select(a => a.Value);
            //        foreach (var t in p)
            //        {
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t[3])).SingleOrDefault();
            //            if (est != null)
            //            {
            //                validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), 0, t[1], out result, null);
            //                if (est.PermanentNameInDb == "TOTALHRS")
            //                {
            //                    decimal n;
            //                    bool isDecimal = decimal.TryParse(result.Message, out n);
            //                    if (isDecimal)
            //                    {
            //                        t[2] = result.Message;
            //                    }
            //                }
            //                else
            //                {
            //                    resultMsg += result.Message;
            //                }
            //            }
            //            dictTask.Add(t[1], t[2]);
            //        }

            //        if (resultMsg.Length <= 0)
            //        {
            //            int TaskNo = getNextTaskNumberByProjectID(Convert.ToInt32(ProjectID), Convert.ToInt32(MasterTaskType));



            //            if (vTaskNo != "")
            //            {
            //                decimal t;
            //                bool isTaskNoDecimal = decimal.TryParse(vTaskNo, out t);
            //                if (isTaskNoDecimal)
            //                {
            //                    if ((t % 1) == 0)
            //                    {
            //                        if (t < TaskNo)
            //                        {
            //                            blTaskDet.updateTaskNo(Convert.ToInt32(ProjectID), Convert.ToInt32(t), 0, TaskNo);
            //                            TaskNo = Convert.ToInt32(t);
            //                        }
            //                    }
            //                    else
            //                    {
            //                        string[] arr = t.ToString().Split('.');
            //                        int vDecPart = Convert.ToInt32(arr[1]);
            //                        if (Convert.ToInt32(arr[0]) > TaskNo)
            //                        {
            //                            vDecPart = 0;
            //                        }
            //                        else
            //                        {
            //                            task.SubTaskNo = vDecPart;
            //                        }
            //                        blTaskDet.updateTaskNo(Convert.ToInt32(ProjectID), Convert.ToInt32(arr[0]), vDecPart, TaskNo);
            //                        TaskNo = Convert.ToInt32(arr[0]);
            //                    }
            //                }
            //            }


            //            task.ParentTaskID = dictTask.ContainsKey("ParentTaskID") ? Convert.ToInt32(dictTask["ParentTaskID"]) : 0;
            //            if (task.ParentTaskID > 0)
            //            {
            //                // ProjectTaskList GetTaskListByID(Int32 TaskID)
            //                task.TaskNo = blTask.GetTaskListByProjectTaskID(Convert.ToInt32(dictTask["ParentTaskID"])).FirstOrDefault().TaskNo;
            //                task.IsgroupTask = "N";
            //                task.SubTaskNo = blTask.GetNextChildCountNoByProjectTaskID(Convert.ToInt32(dictTask["ParentTaskID"]));
            //                task.GroupTaskID = Convert.ToInt32(dictTask["ParentTaskID"]);

            //            }
            //            else
            //            {
            //                task.TaskNo = TaskNo;
            //                task.IsgroupTask = "Y";
            //            }






            //            task.NormsID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //            task.Number_1 = dictTask.ContainsKey("Number_1") ? Convert.ToDouble(dictTask["Number_1"]) : 0;
            //            task.Number_2 = dictTask.ContainsKey("Number_2") ? Convert.ToDouble(dictTask["Number_2"]) : 0;
            //            task.Number_3 = dictTask.ContainsKey("Number_3") ? Convert.ToDouble(dictTask["Number_3"]) : 0;
            //            task.Number_4 = dictTask.ContainsKey("Number_4") ? Convert.ToDouble(dictTask["Number_4"]) : 0;
            //            task.Number_5 = dictTask.ContainsKey("Number_5") ? Convert.ToDouble(dictTask["Number_5"]) : 0;
            //            task.Number_6 = dictTask.ContainsKey("Number_6") ? Convert.ToDouble(dictTask["Number_6"]) : 0;
            //            task.Number_7 = dictTask.ContainsKey("Number_7") ? Convert.ToDouble(dictTask["Number_7"]) : 0;
            //            task.Number_8 = dictTask.ContainsKey("Number_8") ? Convert.ToDouble(dictTask["Number_8"]) : 0;
            //            task.Number_9 = dictTask.ContainsKey("Number_9") ? Convert.ToDouble(dictTask["Number_9"]) : 0;
            //            task.Number_10 = dictTask.ContainsKey("Number_10") ? Convert.ToDouble(dictTask["Number_10"]) : 0;
            //            if (dictTask.ContainsKey("DateTime_1"))
            //            {
            //                task.DateTime_1 = dictTask["DateTime_1"] != "" ? Convert.ToDateTime(dictTask["DateTime_1"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_2"))
            //            {
            //                task.DateTime_2 = dictTask["DateTime_2"] != "" ? Convert.ToDateTime(dictTask["DateTime_2"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_3"))
            //            {
            //                task.DateTime_3 = dictTask["DateTime_3"] != "" ? Convert.ToDateTime(dictTask["DateTime_3"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_4"))
            //            {
            //                task.DateTime_4 = dictTask["DateTime_4"] != "" ? Convert.ToDateTime(dictTask["DateTime_4"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_5"))
            //            {
            //                task.DateTime_5 = dictTask["DateTime_5"] != "" ? Convert.ToDateTime(dictTask["DateTime_5"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_6"))
            //            {
            //                task.DateTime_6 = dictTask["DateTime_6"] != "" ? Convert.ToDateTime(dictTask["DateTime_6"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_7"))
            //            {
            //                task.DateTime_7 = dictTask["DateTime_7"] != "" ? Convert.ToDateTime(dictTask["DateTime_7"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_8"))
            //            {
            //                task.DateTime_8 = dictTask["DateTime_8"] != "" ? Convert.ToDateTime(dictTask["DateTime_8"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_9"))
            //            {
            //                task.DateTime_9 = dictTask["DateTime_9"] != "" ? Convert.ToDateTime(dictTask["DateTime_9"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_10"))
            //            {
            //                task.DateTime_10 = dictTask["DateTime_10"] != "" ? Convert.ToDateTime(dictTask["DateTime_10"], ci) : (DateTime?)null;
            //            }




            //            //    task.DateTime_2 = dictTask.ContainsKey("DateTime_2") ? Convert.ToDateTime(dictTask["DateTime_2"], ci) : null;
            //            //task.DateTime_3 = dictTask.ContainsKey("DateTime_3") ? Convert.ToDateTime(dictTask["DateTime_3"], ci) : null;
            //            //task.DateTime_4 = dictTask.ContainsKey("DateTime_4") ? Convert.ToDateTime(dictTask["DateTime_4"], ci) :null;
            //            //task.DateTime_5 = dictTask.ContainsKey("DateTime_5") ? Convert.ToDateTime(dictTask["DateTime_5"], ci) : null;
            //            task.String_1 = dictTask.ContainsKey("String_1") ? (dictTask["String_1"]) : null;
            //            task.String_2 = dictTask.ContainsKey("String_2") ? (dictTask["String_2"]) : null;
            //            task.String_3 = dictTask.ContainsKey("String_3") ? (dictTask["String_3"]) : null;
            //            task.String_4 = dictTask.ContainsKey("String_4") ? (dictTask["String_4"]) : null;
            //            task.String_5 = dictTask.ContainsKey("String_5") ? (dictTask["String_5"]) : null;
            //            task.String_6 = dictTask.ContainsKey("String_6") ? (dictTask["String_6"]) : null;
            //            task.String_7 = dictTask.ContainsKey("String_7") ? (dictTask["String_7"]) : null;
            //            task.String_8 = dictTask.ContainsKey("String_8") ? (dictTask["String_8"]) : null;
            //            task.String_9 = dictTask.ContainsKey("String_9") ? (dictTask["String_9"]) : null;
            //            task.String_10 = dictTask.ContainsKey("String_10") ? (dictTask["String_10"]) : null;
            //            task.ProjectID = Convert.ToInt32(ProjectID);

            //            BLDepartmentRepository blDept = new BLDepartmentRepository();
            //            task.DepatmentID = dictTask.ContainsKey("Dept") && Convert.ToInt32(dictTask["Dept"]) != 0 ? Convert.ToInt32(dictTask["Dept"]) : blDept.GetDepartmentByName("Not Selected");

            //            task.TaskName = Convert.ToString(dictTask["TaskName"]).Trim();
            //            task.DeliverableNo = dictTask.ContainsKey("DeliverableNo") ? dictTask["DeliverableNo"] != null ? Convert.ToString(dictTask["DeliverableNo"]).Trim() : "" : "";

            //            if (dictTask.ContainsKey("DeliverableNo") && dictTask["DeliverableNo"] != null)
            //            {
            //                BLTaskListRepository bltask = new BLTaskListRepository();
            //                BLUserRepository blUsr = new BLUserRepository();
            //                User user = blUsr.GetuserByID(Convert.ToInt32(UserID));

            //                iCompanyID = Convert.ToInt32(user.CompanyId);
            //                List<ProjectTaskList> lst = bltask.GetAllTaskListWithCompanyID(Convert.ToInt32(user.CompanyId)).Where(c => !string.IsNullOrEmpty(c.DeliverableNo)).ToList<ProjectTaskList>();
            //                if (lst.Count > 0)
            //                {
            //                    bool delno = lst.AsEnumerable().Any(c => task.DeliverableNo.ToUpper() == c.DeliverableNo.ToUpper() && c.ProjectID == Convert.ToInt32(ProjectID));
            //                    if (delno)
            //                    {
            //                        result.Message = "Deliverable number already exists.";
            //                        result.MessageType = "E";
            //                        return result;
            //                    }
            //                }
            //            }

            //            if (dictTask.ContainsKey("Owner"))
            //            {
            //                task.TaskOwner = Convert.ToString(dictTask["Owner"]) == "" ? 0 : Convert.ToInt32(dictTask["Owner"]);
            //                bSendNotificationToOwner = Convert.ToString(task.TaskOwner) == "0" ? false : true;
            //            }

            //            TaskType taskType = null;
            //            if (Convert.ToInt32(MasterTaskType) != Convert.ToInt32(Common.MasterTaskType.Task))
            //            {
            //                int ActivityType = Convert.ToInt32(MasterTaskType) == Convert.ToInt32(Common.MasterTaskType.Document) ? Convert.ToInt32(Common.ActivityType.Deliverable) : Convert.ToInt32(Common.ActivityType.Procurement);
            //                taskType = new BLTaskTypeRepository().GetAllTaskTypes().Where(x => x.IsDefault == "Y" && x.ActivityType == ActivityType).FirstOrDefault();

            //                if (taskType != null)
            //                    task.TaskTypeID = dictTask.ContainsKey("Type") && Convert.ToInt32(dictTask["Type"]) != 0 ? Convert.ToInt32(dictTask["Type"]) : taskType.TaskTypeID;
            //            }
            //            else
            //                task.TaskTypeID = dictTask.ContainsKey("Type") ? Convert.ToInt32(dictTask["Type"]) : 0;

            //            if (!dictTask.ContainsKey("Duration"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDate(Convert.ToString(dictTask["StartDate"]), Convert.ToString(dictTask["EndDate"]), 0, Convert.ToInt32(ProjectID));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("Duration", d1["Duration"]);


            //                // dictTask.Add("Duration", "1");
            //            }

            //            task.Duration = dictTask.ContainsKey("Duration") ? Convert.ToInt32(dictTask["Duration"]) : 1;




            //            task.AllottedHours = dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : 0;

            //            task.TOTALHRS = dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : 0;

            //            //task.TaskWeight = dictTask.ContainsKey("TaskWeight") ? Convert.ToDecimal(dictTask["TaskWeight"]) : 0;
            //            task.TaskCost = dictTask.ContainsKey("TaskCost") ? Convert.ToDecimal(dictTask["TaskCost"]) : 0;

            //            string defaultWbsId = "0";
            //            if (!dictTask.ContainsKey("WBSCode") || dictTask["WBSCode"] == null)
            //            {
            //                BLProjectWBSRepository blWbs = new BLProjectWBSRepository();
            //                ProjectWB wb = blWbs.getDefaultWbsByProjectID(pr.ProjectID, pr.ProjectCode);
            //                defaultWbsId = Convert.ToString(wb.WBSID);
            //            }
            //            task.WBSID = dictTask.ContainsKey("WBSCode") && dictTask["WBSCode"] != null ? Convert.ToString(dictTask["WBSCode"]) : defaultWbsId;

            //            Priority priority = new BLPriorityRepository().getDefaultPriority();
            //            task.Priority = dictTask.ContainsKey("Priority") ? Convert.ToInt32(dictTask["Priority"]) : priority.PriorityID;

            //            task.IsImposed = "Y";
            //            if (!dictTask.ContainsKey("StartDate"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDuration(Convert.ToInt32(ProjectID), Convert.ToInt32(task.Duration));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("StartDate", d1["StartDate"]);
            //                dictTask.Add("EndDate", d1["EndDate"]);
            //            }
            //            task.StartDate = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : Convert.ToDateTime(pr.ProjectStartDate);
            //            if (dictTask.ContainsKey("EndDate") && dictTask["EndDate"] != "" && dictTask["EndDate"] != null)
            //            {
            //                task.EndDate = Convert.ToDateTime(dictTask["EndDate"], ci);
            //                task.EndDateOrg = Convert.ToDateTime(dictTask["EndDate"], ci);
            //            }
            //            //task.EndDate = dictTask.ContainsKey("EndDate") && dictTask["EndDate"] != "" ? Convert.ToDateTime(dictTask["EndDate"], ci) : Convert.ToDateTime(pr.ProjectEndDate);
            //            task.StartDateOrg = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : Convert.ToDateTime(pr.ProjectStartDate);
            //            //task.EndDateOrg = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : Convert.ToDateTime(pr.ProjectEndDate);


            //            task.Remarks = dictTask.ContainsKey("Remarks") ? Convert.ToString(dictTask["Remarks"]) : "";
            //            task.CreatedBy = Convert.ToInt32(UserID);
            //            task.CreatedOn = DateTime.Now;
            //            task.IsScheduled = "N";

            //            task.Cost = dictTask.ContainsKey("Cost") ? Convert.ToDecimal(dictTask["Cost"]) : 0;
            //            task.TotalCost = dictTask.ContainsKey("TotalCost") ? Convert.ToDecimal(dictTask["TotalCost"]) : 0;
            //            task.Quantity = dictTask.ContainsKey("Quantity") ? Convert.ToDecimal(dictTask["Quantity"]) : 0;
            //            task.CurrencyID = dictTask.ContainsKey("Currency") ? Convert.ToInt32(dictTask["Currency"]) : 0; ;
            //            task.MasterTaskType = Convert.ToInt32(MasterTaskType);
            //            task.IsDeliverable = true;// dictTask.ContainsKey("vIsDeliverable") && dictTask["vIsDeliverable"] != "" ? Convert.ToBoolean(dictTask["vIsDeliverable"]) : false;
            //            //task.TaskWeight = 100;

            //            task.TaskWeight = dictTask.ContainsKey("TaskWeight") ? Convert.ToDecimal(dictTask["TaskWeight"]) : 100;
            //            task.LOCK = 0;

            //            task.EntityState = DominModel.EntityState.Added;
            //        }

            //        ////// type == "PROGRESS"

            //        List<TaskMilestoneTargetDate> lstAddTaskMile = new List<TaskMilestoneTargetDate>();
            //        var q = item
            //               .Where(i => i.Value[0] == "PROGRESS");

            //        NewBLEstimationTaskListRepository blObjEst = new NewBLEstimationTaskListRepository();

            //        var lstMilestoneReq = blObjEst.getMilestoneIdByTaskTypeID(Convert.ToInt32(ProjectID), Convert.ToInt32(task.NormsID), Convert.ToInt32(task.TaskTypeID));

            //        foreach (var x in lstMilestoneReq)
            //        {
            //            bool notExists = true;
            //            foreach (var t in q)
            //            {

            //                if (t.Key == x.ProjectMilestoneID.ToString())
            //                {
            //                    notExists = false;
            //                    ////Validation
            //                    Nullable<DateTime> dt = null;
            //                    //EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //                   //validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, Convert.ToInt32(t.Key), "", out result, lstMilestoneReq);
            //                   // resultMsg += result.Message;
            //                    //////////////
            //                    //if (result.Message.Length <= 0)
            //                    //{

            //                        if (blObjEst.IsValidMilestone(Convert.ToInt32(ProjectID), Convert.ToInt32(task.TaskTypeID), Convert.ToInt32(t.Key)))
            //                        {


            //                            TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //                            tmt.MileStoneID = Convert.ToInt32(x.ProjectMilestoneID);
            //                            tmt.TaskMilestoneTargetDates = Convert.ToString(t.Value[2] as object) != "" ? Convert.ToDateTime(t.Value[2], ci) : dt;
            //                            tmt.TaskTypeID = Convert.ToInt32(task.TaskTypeID);//Convert.ToInt32(dictTask["Type"]);
            //                            tmt.EntityState = DominModel.EntityState.Added;
            //                            lstAddTaskMile.Add(tmt);
            //                        }
            //                    //}


            //                }
            //            }
            //            if (notExists == true)
            //            {
            //                TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //                tmt.MileStoneID = Convert.ToInt32(x.ProjectMilestoneID);
            //                tmt.TaskMilestoneTargetDates =null;
            //                tmt.TaskTypeID = Convert.ToInt32(task.TaskTypeID);//Convert.ToInt32(dictTask["Type"]);
            //                tmt.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskMile.Add(tmt);
            //            }




            //        }

            //        //Added for Activity Type - General ---- Start 
            //        BLProjectMilestoneRepository blMilestone = new BLProjectMilestoneRepository();
            //        int ActTypeId = Convert.ToInt32(Common.ActivityType.General);
            //        List<ProjectMilestone> lstMilestoneGeneralActivity = blMilestone.GetMilestoneByProjectID(Convert.ToInt32(ProjectID)).Where(a => a.ActivityTypeID == ActTypeId).ToList<ProjectMilestone>();

            //        foreach (var t in lstMilestoneGeneralActivity)
            //        {
            //            if (blObjEst.IsValidMilestone(Convert.ToInt32(ProjectID), Convert.ToInt32(task.TaskTypeID), Convert.ToInt32(t.ProjectMilestoneID)))
            //            {

            //                TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //                tmt.MileStoneID = Convert.ToInt32(t.ProjectMilestoneID);
            //                tmt.TaskMilestoneTargetDates = null;
            //                tmt.TaskTypeID = Convert.ToInt32(task.TaskTypeID);//Convert.ToInt32(dictTask["Type"]);
            //                tmt.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskMile.Add(tmt);
            //            }
            //        }
            //        //Added for Activity Type - General ---- End

            //        //Added for MasterTaskType - DocumentList,MaterialItem ---- Start 
            //        //if (Convert.ToInt32(MasterTaskType) != Convert.ToInt32(Common.MasterTaskType.Task) && Convert.ToInt32(dictTask["ParentTaskID"]) != 0)
            //        //{ 
            //        //    BLTaskMilestoneTargetDates blObjTMT = new BLTaskMilestoneTargetDates();
            //        //    List<TaskMilestoneTargetDate> lst = blObjTMT.GetAllTaskMilestoneTargetDateByDeliverableID(Convert.ToInt32(dictTask["ParentTaskID"]));
            //        //    foreach (var t in lst)
            //        //    {
            //        //        TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //        //        tmt.MileStoneID = t.MileStoneID;
            //        //        tmt.TaskMilestoneTargetDates = t.TaskMilestoneTargetDates;
            //        //        tmt.TaskTypeID = t.TaskTypeID;
            //        //        tmt.EntityState = DominModel.EntityState.Added;
            //        //        lstAddTaskMile.Add(tmt);
            //        //    }  
            //        //}




            //        BLMileStoneTaskTypeRepository blTT = new BLMileStoneTaskTypeRepository();
            //        List<ProjectMilestone> lstMile = blTT.GetMileStoneByProjectIDAndTaskTypeID(Convert.ToInt32(ProjectID), task.TaskTypeID);
            //        List<ProjectMilestone> lstRem = (from u in lstMile where !lstAddTaskMile.Select(a => a.MileStoneID).Contains(u.ProjectMilestoneID) select u).ToList<ProjectMilestone>();
            //        foreach (var t in lstRem)
            //        {
            //            TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //            tmt.MileStoneID = Convert.ToInt32(t.ProjectMilestoneID);
            //            tmt.TaskTypeID = Convert.ToInt32(task.TaskTypeID);
            //            tmt.EntityState = DominModel.EntityState.Added;
            //            lstAddTaskMile.Add(tmt);
            //        }

            //        ////// type == "DESN"
            //        bool DesnHrsRequired = false;
            //        List<TaskDesignation> lstAddTaskDesn = new List<TaskDesignation>();
            //        var r = item
            //               .Where(i => i.Value[0] == "DESN");
            //        foreach (var t in r)
            //        {
            //            if (Convert.ToString(t.Value[2] as object) != "" && Convert.ToDecimal(t.Value[2]) > 0)
            //            {
            //                ////Validation
            //                EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //                validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, 0, "", out result, null);
            //                //////////////
            //                decimal n;
            //                bool isMesNumeric = decimal.TryParse(result.Message, out n);
            //                if (isMesNumeric)
            //                {
            //                    if (Convert.ToDecimal(t.Value[2]) != n)
            //                    {
            //                        t.Value[2] = Convert.ToString(n);
            //                    }
            //                }

            //                TaskDesignation desgn = new TaskDesignation();
            //                desgn.DesignationID = Convert.ToInt32(t.Key);
            //                desgn.Hours = Convert.ToDecimal(t.Value[2]);
            //                desgn.ProjectID = Convert.ToInt32(ProjectID);
            //                desgn.DepartmentID = Convert.ToInt32(dictTask["Dept"]);
            //                desgn.ProjectStageID = pr.ProjectStage;
            //                desgn.NormID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //                desgn.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskDesn.Add(desgn);

            //                dictReturnData[t.Key] = t.Value[2];
            //                DesnHrsRequired = true;
            //            }
            //        }
            //        ////// type == "DETAIL"
            //        List<TaskDetail> lstAddTaskDet = new List<TaskDetail>();
            //        var s = item
            //               .Where(i => i.Value[0] == "DETAIL");
            //        foreach (var t in s)
            //        {
            //            ////Validation
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //            validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), 0, t.Value[3], out result, null);
            //            resultMsg += result.Message;
            //            //////////////
            //            if (result.Message.Length <= 0 && Convert.ToString(t.Value[2] as object) != "")
            //            {
            //                if (est.DependonNorms == "N" || (est.DependonNorms == "Y" && Convert.ToInt32(normId) != 0))
            //                {
            //                    TaskDetail det = new TaskDetail();
            //                    det.EstimationTaskColumnID = Convert.ToInt32(t.Key);
            //                    det.ColValue = t.Value[2];
            //                    det.EntityState = DominModel.EntityState.Added;
            //                    lstAddTaskDet.Add(det);
            //                }
            //            }
            //        }


            //        if (resultMsg.Length == 0)
            //        {
            //            blTask.AddTaskList(task);
            //            int TaskID = task.ProjectTaskID;
            //            string taskname = '"' + task.TaskName + '"'; ;
            //            int projectID = task.ProjectID;
            //            int DeliverableOwner = Convert.ToInt32(task.TaskOwner);
            //            int AssigneeID = Convert.ToInt32(UserID);
            //            //Update Task id
            //            lstAddTaskMile = lstAddTaskMile.Select(x => { x.TaskID = TaskID; return x; }).ToList<TaskMilestoneTargetDate>();
            //            lstAddTaskDesn = lstAddTaskDesn.Select(x => { x.ProjectTaskID = TaskID; return x; }).ToList<TaskDesignation>();
            //            lstAddTaskDet = lstAddTaskDet.Select(x => { x.ProjectTaskID = TaskID; return x; }).ToList<TaskDetail>();
            //            blTaskMile.AddTaskMilestoneTargetDates(lstAddTaskMile.ToArray());
            //            blTaskDesn.AddTaskDesignation(lstAddTaskDesn.ToArray());
            //            blTaskDet.AddTaskDetails(lstAddTaskDet.ToArray());


            //            //Send Notification to task owner
            //            BLUserRepository blObjUsers = new BLUserRepository();
            //            String strUserName = blObjUsers.GetUserFullName(AssigneeID);
            //            BLProjectCreationRepository blObjProject = new BLProjectCreationRepository();
            //            usp_getProjectDataByprojectID_Result project = null;
            //            project = blObjProject.GetAllProjectRelatedDataByID(Convert.ToInt32(ProjectID));
            //            string ProjectName = '"' + project.ProjectName.ToString() + " - " + project.ProjectCode.ToString() + '"';
            //            //Activity Tracker log
            //            ActivityTracker("Task added to - " + ProjectName, "Task List", UserID, "Task Added");


            //            Message objMessage = new Message();
            //            BLMessageRepository BLobjMessage = new BLMessageRepository();
            //            if (bSendNotificationToOwner == true)
            //            {

            //                //Activity Tracker log
            //                ActivityTracker("Task assigned to - " + Convert.ToString(strUserName) + " for " + ProjectName, "Task List", UserID, "Task Assigned");
            //                objMessage.MessageID = 0;
            //                objMessage.FromUserID = Convert.ToString(UserID);
            //                objMessage.ToUserID = Convert.ToString(DeliverableOwner);
            //                objMessage.Message1 = Common.MessageConstants.SendNotificationToDeliverableOwner.Replace("#AssigneeName#", strUserName).Replace("#ProjectName#", Convert.ToString(ProjectName)).Replace("#DeliverableName#", Convert.ToString(taskname));

            //                TaskType ttype = new BLTaskTypeRepository().GetTaskTypeByID(task.TaskTypeID);
            //                if (ttype.ActivityType == Convert.ToInt32(Common.ActivityType.General))
            //                    objMessage.RedirectURL = "UploadDeliverablesGeneralActivity.aspx";
            //                else
            //                    objMessage.RedirectURL = "UploadDeliverables.aspx";
            //                //objMessage.RedirectURL = "UploadDeliverables.aspx";
            //                objMessage.MessageFor = "UploadDeliverables";
            //                objMessage.CompanyId = iCompanyID; //Convert.ToInt32(HttpContext.Current.Session["CompanyId"]); //iCompanyID;
            //                objMessage.QueryString = "DeliverableID=" + TaskID;
            //                objMessage.Active = "Y";
            //                objMessage.MessageType = "N";
            //                objMessage.EntityState = DominModel.EntityState.Added;
            //                BLobjMessage.AddMessage(objMessage);
            //                BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();

            //                MessageTemplate mst = blmt.GetMessageTemplateByMessage(Common.MessageConstants.SendNotificationToDeliverableOwner);

            //                if (mst.IsEmail == true)
            //                {

            //                    blmt.SendNotification(Convert.ToInt32(UserID), objMessage.Message1, Convert.ToInt32(DeliverableOwner));
            //                }

            //            }
            //            //

            //            BLDeliverableListRepository bldel = new BLDeliverableListRepository();
            //            List<usp_getAllRevisionByProjectID_Result> lstMilestone = bldel.getAllRevisionByDeliverableID(task.ProjectTaskID, task.TaskTypeID);
            //            BLDepartmentRepository blDept = new BLDepartmentRepository();
            //            Department dept = blDept.GetDepartmentByID(task.DepatmentID);

            //            Company Company = null;

            //            if (!UserSession.UserID.Contains("@"))
            //            {
            //                BLUserRepository blUser = new BLUserRepository();
            //                User user = blUser.GetuserByID(Convert.ToInt32(UserID));
            //                BLCompanyRepository blCom = new BLCompanyRepository();
            //                Company = blCom.GetCompanyByCompanyID(Convert.ToInt32(user.CompanyId));
            //            }

            //            string bUrl = BasePage.networkdirectorypath +"\\"+ Convert.ToString(Company.ComanyName).Trim('.') + "\\" + project.ProjectCode + "\\" + dept.DepartmentName + "\\" + task.DeliverableNo;
            //            foreach (var vpm in lstMilestone)
            //            {
            //                string fileUploadDir = bUrl + "\\" + vpm.TabName;
            //                if (!Directory.Exists(fileUploadDir))
            //                {
            //                    Directory.CreateDirectory(fileUploadDir);
            //                    addCustomPropertiesToFile(bUrl, fileUploadDir, task.ProjectTaskID, Convert.ToInt32(vpm.MilestoneID));
            //                }
            //            }
            //            string TaskNo = getTaskSequenceNumber(Convert.ToInt32(task.ParentTaskID));

            //            BLTaskTypeRepository blTaskType = new BLTaskTypeRepository();
            //            TaskType tt = blTaskType.GetTaskTypeByID(task.TaskTypeID);

            //            ts.Complete();
                        

            //            dictReturnData["id"] = Convert.ToString(TaskID);
            //            dictReturnData["TaskNo"] = TaskNo != "" ? Convert.ToString(TaskNo.TrimEnd('.')) : Convert.ToString(task.TaskNo);
            //            dictReturnData["TaskStatus"] = Convert.ToString(Convert.ToInt32(Common.TaskStatusID.Draft));
            //            dictReturnData["TaskStatusName"] = Convert.ToString(Common.TaskStatusID.Draft);
            //            dictReturnData["SubTaskNo"] = Convert.ToString(task.SubTaskNo);
            //            dictReturnData["ActivityType"] = Convert.ToString(tt.ActivityType);                      



            //            result.lstDict.Add(dictReturnData);
            //            result.Message = MessageConstants.OperationSuccess;
            //            result.MessageType = "S";
            //        }
            //        else
            //        {
            //            ts.Dispose();
            //            result.Message = resultMsg;
            //            result.MessageType = "E";
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        result.Message = ex.Message;
            //        result.MessageType = "E";
            //    }

            //    return result;
            //}
            return result;
        }

        public void addCustomPropertiesToFile(string deliverableFolderUrl, string fileUploadDir, int ProjectTaskID, int MilestoneID,int RevisionID=0)
        {
            //string myPath = deliverableFolderUrl;
            //OleDocumentProperties myFile = new DSOFile.OleDocumentProperties();
            //myFile.Open(myPath, false, DSOFile.dsoFileOpenOptions.dsoOptionDefault);
            //myFile.SummaryProperties.Keywords = "DeliverableId:" + Convert.ToString(ProjectTaskID) + ";";

            //myFile.Save();
            //myFile.Close(true);

            //myPath = fileUploadDir;
            //myFile.Open(myPath, false, DSOFile.dsoFileOpenOptions.dsoOptionDefault);
            //myFile.SummaryProperties.Keywords = "DeliverableId:" + Convert.ToString(ProjectTaskID) + ";MilestoneID:" + Convert.ToString(MilestoneID) + ";RevisionID:"+ Convert.ToString(RevisionID);

            //myFile.Save();
            //myFile.Close(true);

        }
        public void ActivityTracker(string Message, string strPage, string userID, string eventname)
        {
            //BLUserActivityTrackerRepository tracker = new BLUserActivityTrackerRepository();
            //UserActivityTracker useractivity = new UserActivityTracker();
            //useractivity.CreatedBy = Convert.ToString(userID);
            //useractivity.CreatedOn = DateTime.Now;
            //useractivity.Page = strPage;
            //useractivity.Event = eventname;
            //useractivity.Text = Message;
            //useractivity.EntityState = EntityState.Added;
            //tracker.AddUserActivityTracker(useractivity);
        }




        public OperationResult addEstimationTask_Contract(string ProjectID, string ProjectContractID, string UserID, Dictionary<string, string[]> item, string vTaskNo, string MasterTaskType = "1")
        {
            OperationResult result = new OperationResult();
            Dictionary<string, string> dictReturnData = new Dictionary<string, string>();
            //CultureInfo ci = new CultureInfo("en-Gb");
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        string resultMsg = "";
            //        bool isProjectLeader = false;

            //        BLTaskListRepository_Contract blTask = new BLTaskListRepository_Contract();
            //        BLTaskDesignationRepository_Contract blTaskDesn = new BLTaskDesignationRepository_Contract();
            //        BLTaskMilestoneTargetDates_Contract blTaskMile = new BLTaskMilestoneTargetDates_Contract();
            //        BLTaskDeatilsRepository_Contract blTaskDet = new BLTaskDeatilsRepository_Contract();

            //        Dictionary<string, string> dictTask = new Dictionary<string, string>();

            //        BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //        List<EstimationTaskColumnsMaster> lstColMaster = blObj.GetAllEstimationTaskColumnsMastersByProjectID(Convert.ToInt32(ProjectID), Convert.ToInt32(MasterTaskType)).ToList<EstimationTaskColumnsMaster>();

            //        var normId = item
            //               .Where(i => i.Value[1] == "Norm").Select(a => a.Value[2]).SingleOrDefault();

            //        BLNormsDetailRepository blNormDet = new BLNormsDetailRepository();
            //        List<NormDesDet> lstNormDet = blNormDet.getNormsDesDetailsByNormIDCls(Convert.ToInt32(normId));

            //        var eq = lstColMaster.Where(a => Convert.ToString(a.EquationID as object) != "" || Convert.ToString(a.Equationvalidation as object) != "").Select(a => Convert.ToString(a.EquationID as object) != "" ? a.EquationID : a.Equationvalidation);
            //        string[] separators = { "/", "*", "+", "-", "&", "|", " ", ">", "<", "=" };
            //        List<string> eqLst = new List<string>();
            //        foreach (var vEq in eq)
            //        {
            //            string[] arr = vEq.Split(separators, StringSplitOptions.None);
            //            eqLst.AddRange(arr.ToList());
            //        }

            //        eqLst = eqLst.Distinct().ToList<string>();
            //        var pEqVal = item
            //               .Where(i => eqLst.Contains(i.Value[4])).Select(a => new NormDesDet { NameInDb = a.Value[4], ColValue = a.Value[2] });

            //        var pEqValNorm = lstNormDet.Where(i => eqLst.Contains(i.NameInDb));


            //        BLProjectCreationRepository blObjPr = new BLProjectCreationRepository();
            //        Project pr = blObjPr.GetProjectByID(Convert.ToInt32(ProjectID));
            //        if (pr.ProjectLeader == Convert.ToInt32(UserID))
            //        {
            //            isProjectLeader = true;
            //        }
            //        else
            //        {
            //            List<ProjectsAdmin> lst = blObjPr.getProjectAdmin(Convert.ToInt32(ProjectID));
            //            if (lst.Select(a => a.UserID).Contains(Convert.ToInt32(UserID)))
            //            {
            //                isProjectLeader = true;
            //            }
            //        }


            //        ////// type == "TASK"

            //        ProjectTaskList_Contract task = new ProjectTaskList_Contract();

            //        var p = item
            //               .Where(i => i.Value[0] == "TASK").Select(a => a.Value);
            //        foreach (var t in p)
            //        {
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t[3])).SingleOrDefault();
            //            if (est != null)
            //            {
            //                validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), 0, t[1], out result, null);
            //                if (est.PermanentNameInDb == "TOTALHRS")
            //                {
            //                    decimal n;
            //                    bool isDecimal = decimal.TryParse(result.Message, out n);
            //                    if (isDecimal)
            //                    {
            //                        t[2] = result.Message;
            //                    }
            //                }
            //                else
            //                {
            //                    resultMsg += result.Message;
            //                }
            //            }
            //            dictTask.Add(t[1], t[2]);
            //        }

            //        if (resultMsg.Length <= 0)
            //        {
            //            int TaskNo = getNextTaskNumberByProjectID_Contract(Convert.ToInt32(ProjectID));
            //            if (vTaskNo != "")
            //            {
            //                decimal t;
            //                bool isTaskNoDecimal = decimal.TryParse(vTaskNo, out t);
            //                if (isTaskNoDecimal)
            //                {
            //                    if ((t % 1) == 0)
            //                    {
            //                        if (t < TaskNo)
            //                        {
            //                            blTaskDet.updateTaskNo_Contract(Convert.ToInt32(ProjectID), Convert.ToInt32(t), 0, TaskNo);
            //                            TaskNo = Convert.ToInt32(t);
            //                        }
            //                    }
            //                    else
            //                    {
            //                        string[] arr = t.ToString().Split('.');
            //                        int vDecPart = Convert.ToInt32(arr[1]);
            //                        if (Convert.ToInt32(arr[0]) > TaskNo)
            //                        {
            //                            vDecPart = 0;
            //                        }
            //                        else
            //                        {
            //                            task.SubTaskNo = vDecPart;
            //                        }
            //                        blTaskDet.updateTaskNo_Contract(Convert.ToInt32(ProjectID), Convert.ToInt32(arr[0]), vDecPart, TaskNo);
            //                        TaskNo = Convert.ToInt32(arr[0]);
            //                    }
            //                }
            //            }

            //            task.NormsID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //            task.ProjectID = Convert.ToInt32(ProjectID);
            //            task.DepatmentID = Convert.ToInt32(dictTask["Dept"]);
            //            task.TaskNo = TaskNo;
            //            task.TaskName = Convert.ToString(dictTask["TaskName"]);
            //            task.TaskTypeID = dictTask.ContainsKey("Type") ? Convert.ToInt32(dictTask["Type"]) : 0;
            //            if (!dictTask.ContainsKey("Duration"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDate(Convert.ToString(dictTask["StartDate"]), Convert.ToString(dictTask["EndDate"]), 0, Convert.ToInt32(ProjectID));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("Duration", d1["Duration"]);
            //            }
            //            task.Duration = dictTask.ContainsKey("Duration") ? Convert.ToInt32(dictTask["Duration"]) : 1;
            //            task.AllottedHours = dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : 1;
            //            task.TOTALHRS = dictTask.ContainsKey("TOTALHRS") ? Convert.ToDecimal(dictTask["TOTALHRS"]) : 1;
            //            task.WBSID = dictTask.ContainsKey("WBSCode") ? Convert.ToString(dictTask["WBSCode"]) : null;
            //            task.Priority = Convert.ToInt32(dictTask["Priority"]);
            //            if (!dictTask.ContainsKey("StartDate"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDuration(Convert.ToInt32(ProjectID), Convert.ToInt32(task.Duration));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("StartDate", d1["StartDate"]);
            //                dictTask.Add("EndDate", d1["EndDate"]);
            //            }
            //            task.StartDate = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : Convert.ToDateTime(pr.ProjectStartDate);
            //            task.EndDate = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : Convert.ToDateTime(pr.ProjectEndDate);
            //            task.StartDateOrg = dictTask.ContainsKey("StartDate") ? Convert.ToDateTime(dictTask["StartDate"], ci) : Convert.ToDateTime(pr.ProjectStartDate);
            //            task.EndDateOrg = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : Convert.ToDateTime(pr.ProjectEndDate);


            //            task.Remarks = dictTask.ContainsKey("Remarks") ? Convert.ToString(dictTask["Remarks"]) : "";
            //            task.CreatedBy = Convert.ToInt32(UserID);
            //            task.CreatedOn = DateTime.Now;
            //            task.IsScheduled = "N";
            //            task.IsDeliverable = true;// dictTask.ContainsKey("vIsDeliverable") && dictTask["vIsDeliverable"] != "" ? Convert.ToBoolean(dictTask["vIsDeliverable"]) : false;
            //            task.ProjectContractID = Convert.ToInt32(ProjectContractID);
            //            task.EntityState = DominModel.EntityState.Added;
            //        }

            //        ////// type == "PROGRESS"

            //        List<TaskMilestoneTargetDates_Contract> lstAddTaskMile = new List<TaskMilestoneTargetDates_Contract>();
            //        var q = item
            //               .Where(i => i.Value[0] == "PROGRESS");

            //        List<object> lstMilestoneReq = null;
            //        if (q.Count() > 0)
            //        {
            //            NewBLEstimationTaskListRepository blObjEst = new NewBLEstimationTaskListRepository();
            //            int n;
            //            bool isNormIDNumeric = int.TryParse(Convert.ToString(task.NormsID), out n);
            //            if (isNormIDNumeric)
            //            {
            //                lstMilestoneReq = blObjEst.getMilestoneNotRequired(Convert.ToInt32(ProjectID), Convert.ToInt32(task.NormsID), Convert.ToInt32(task.TaskTypeID));
            //            }
            //        }

            //        foreach (var t in q)
            //        {
            //            ////Validation
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //            validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, 0, "", out result, lstMilestoneReq);
            //            resultMsg += result.Message;
            //            //////////////
            //            if (result.Message.Length <= 0 && Convert.ToString(t.Value[2] as object) != "")
            //            {
            //                TaskMilestoneTargetDates_Contract tmt = new TaskMilestoneTargetDates_Contract();
            //                tmt.MileStoneID = Convert.ToInt32(t.Key);
            //                tmt.TaskMilestoneTargetDates = Convert.ToDateTime(t.Value[2], ci);
            //                tmt.TaskTypeID = Convert.ToInt32(dictTask["Type"]);
            //                tmt.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskMile.Add(tmt);
            //            }
            //        }


            //        ////// type == "DESN"
            //        bool DesnHrsRequired = false;
            //        List<TaskDesignation_Contract> lstAddTaskDesn = new List<TaskDesignation_Contract>();
            //        var r = item
            //               .Where(i => i.Value[0] == "DESN");
            //        foreach (var t in r)
            //        {
            //            if (Convert.ToString(t.Value[2] as object) != "" && Convert.ToDecimal(t.Value[2]) > 0)
            //            {
            //                ////Validation
            //                EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //                validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, 0, "", out result, null);
            //                //////////////
            //                decimal n;
            //                bool isMesNumeric = decimal.TryParse(result.Message, out n);
            //                if (isMesNumeric)
            //                {
            //                    if (Convert.ToDecimal(t.Value[2]) != n)
            //                    {
            //                        t.Value[2] = Convert.ToString(n);
            //                    }
            //                }

            //                TaskDesignation_Contract desgn = new TaskDesignation_Contract();
            //                desgn.DesignationID = Convert.ToInt32(t.Key);
            //                desgn.Hours = Convert.ToDecimal(t.Value[2]);
            //                desgn.ProjectID = Convert.ToInt32(ProjectID);
            //                desgn.DepartmentID = Convert.ToInt32(dictTask["Dept"]);
            //                desgn.ProjectStageID = pr.ProjectStage;
            //                desgn.NormID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //                desgn.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskDesn.Add(desgn);

            //                dictReturnData[t.Key] = t.Value[2];
            //                DesnHrsRequired = true;
            //            }
            //        }

            //        string IsManHoursDisable = "N";
            //        //For Milestone task type
            //        BLTaskTypeRepository blTaskType = new BLTaskTypeRepository();
            //        TaskType tt = blTaskType.getTaskTypeByMilestoneGroup();
            //        if (task.TaskTypeID == tt.TaskTypeID)
            //        {
            //            task.TaskOwner = pr.ProjectLeader;
            //            IsManHoursDisable = "Y";
            //        }
            //        /////Task designation for Milestone
            //        if (IsManHoursDisable == "Y")
            //        {
            //            BLDesignationRepository bluser = new BLDesignationRepository();
            //            List<Designation> lstdesg = bluser.GetDistinctDesignationByDepartment(Convert.ToInt32(dictTask["Dept"]));
            //            if (lstdesg.Count > 0)
            //            {
            //                foreach (var t in lstdesg)
            //                {
            //                    TaskDesignation_Contract desgn = new TaskDesignation_Contract();
            //                    desgn.DesignationID = Convert.ToInt32(t.DesignationID);
            //                    desgn.Hours = 0;
            //                    desgn.ProjectID = Convert.ToInt32(ProjectID);
            //                    desgn.DepartmentID = Convert.ToInt32(dictTask["Dept"]);
            //                    desgn.ProjectStageID = pr.ProjectStage;
            //                    desgn.NormID = dictTask.ContainsKey("Norm") ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //                    desgn.EntityState = DominModel.EntityState.Added;
            //                    lstAddTaskDesn.Add(desgn);
            //                    DesnHrsRequired = true;
            //                }
            //            }
            //        }


            //        if (!DesnHrsRequired)
            //        {
            //            resultMsg = "Please enter atleast one designation hour.";
            //        }

            //        ////// type == "DETAIL"

            //        List<TaskDetail_Contract> lstAddTaskDet = new List<TaskDetail_Contract>();
            //        var s = item
            //               .Where(i => i.Value[0] == "DETAIL");
            //        foreach (var t in s)
            //        {
            //            ////Validation
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //            validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), 0, t.Value[3], out result, null);
            //            resultMsg += result.Message;
            //            //////////////
            //            if (result.Message.Length <= 0 && Convert.ToString(t.Value[2] as object) != "")
            //            {
            //                if (est.DependonNorms == "N" || (est.DependonNorms == "Y" && Convert.ToInt32(normId) != 0))
            //                {
            //                    TaskDetail_Contract det = new TaskDetail_Contract();
            //                    det.EstimationTaskColumnID = Convert.ToInt32(t.Key);
            //                    det.ColValue = t.Value[2];
            //                    det.EntityState = DominModel.EntityState.Added;
            //                    lstAddTaskDet.Add(det);
            //                }
            //            }
            //        }


            //        if (resultMsg.Length == 0)
            //        {
            //            blTask.AddTaskList(task);
            //            int TaskID = task.ProjectTaskID;
            //            //Update Task id
            //            lstAddTaskMile = lstAddTaskMile.Select(x => { x.TaskID = TaskID; return x; }).ToList<TaskMilestoneTargetDates_Contract>();
            //            lstAddTaskDesn = lstAddTaskDesn.Select(x => { x.ProjectTaskID = TaskID; return x; }).ToList<TaskDesignation_Contract>();
            //            lstAddTaskDet = lstAddTaskDet.Select(x => { x.ProjectTaskID = TaskID; return x; }).ToList<TaskDetail_Contract>();

            //            blTaskMile.AddTaskMilestoneTargetDates(lstAddTaskMile.ToArray());
            //            blTaskDesn.AddTaskDesignation(lstAddTaskDesn.ToArray());
            //            blTaskDet.AddTaskDetails(lstAddTaskDet.ToArray());

            //            ts.Complete();

            //            dictReturnData["id"] = Convert.ToString(TaskID);
            //            dictReturnData["TaskNo"] = Convert.ToString(task.TaskNo);
            //            dictReturnData["TaskStatus"] = Convert.ToString(Convert.ToInt32(Common.TaskStatusID.Draft));
            //            dictReturnData["TaskStatusName"] = Convert.ToString(Common.TaskStatusID.Draft);
            //            result.lstDict.Add(dictReturnData);
            //            result.Message = MessageConstants.OperationSuccess;
            //            result.MessageType = "S";
            //        }
            //        else
            //        {
            //            ts.Dispose();
            //            result.Message = resultMsg;
            //            result.MessageType = "E";
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        result.Message = ex.Message + "- " + ex.InnerException.Message;
            //        result.MessageType = "E";
            //        ts.Dispose();
            //    }

            //    return result;
            //}
            return result;
        }

        public void validateTaskEntry(int normId, bool isProjectLeader, string colValue, EstimationTaskColumnsMaster est, IEnumerable<NormDesDet> pEqVal, IEnumerable<NormDesDet> pEqValNorm,
            int UserID, int ProjectID, int ProjectTaskId, string DataMappingID, out OperationResult result, List<object> lstMilestoneReq)
        {
            result = new OperationResult();
            //try
            //{
            //    string message = "";
            //    result = new OperationResult();

            //    if (est.PermanentNameInDb == "Norm" || est.PermanentNameInDb == "Dept")
            //    {
            //        result.Message = "";
            //        result.MessageType = "S";
            //        return;
            //    }
            //    //No validation for norm dependent field if norm is not selected.
            //    if (normId == 0 && est.DependonNorms == "Y")
            //    {
            //        result.Message = "";
            //        result.MessageType = "S";
            //        return;
            //    }

            //    if (est.IsMandatory == "Y")
            //    {
            //        if (est.PermanentNameInDb == "TaskProgressLevels")
            //        {
            //            if (lstMilestoneReq != null && lstMilestoneReq.Count() > 0)
            //            {
            //                foreach (var m in lstMilestoneReq)
            //                {

            //                }
            //            }
            //        }
            //        else if (colValue == null || colValue.Length <= 0)
            //        {
            //            message += est.DisplayColName + " is required.";
            //        }
            //    }

            //    if (est.DataType == "Number")
            //    {
            //        if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
            //        {
            //            decimal n;
            //            bool isNumeric = decimal.TryParse(colValue, out n);
            //            if (!isNumeric)
            //            {
            //                message += est.DisplayColName + " must be a numeric value.";
            //            }
            //        }
            //    }

            //    if (est.DataType == "DateTime")
            //    {
            //        string[] formats = { "dd/MM/yyyy" };
            //        DateTime dateValue;
            //        if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
            //        {
            //            if (est.PermanentNameInDb == "TaskProgressLevels")
            //            {
            //            }
            //            else if (!DateTime.TryParseExact(colValue, formats, new CultureInfo("en-Gb"), DateTimeStyles.None, out dateValue))
            //            {
            //                message += est.DisplayColName + " must be a DateTime value of dd/MM/yyyy format.";
            //            }


            //        }
            //    }

            //    if (Convert.ToString(est.DataType as object).ToLower().Contains("unique"))
            //    {
            //        NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
            //        if (!blObj.checkUniqueness(Convert.ToInt32(ProjectID), est.ProjectTaskListColumn, colValue, Convert.ToInt32(ProjectTaskId)))
            //        {
            //            message += MessageConstants.Duplicate;
            //        }
            //    }

            //    //// 1==2 so that it will not get executed.As we have changed equation to javascript function.

            //    if (1 == 2 && ((est.Equationvalidation != null && est.Equationvalidation.Length > 0) || (est.EquationID != null && est.EquationID.Length > 0)))
            //    {
            //        string eqn = Convert.ToString(est.Equationvalidation as object).Length > 0 ? est.Equationvalidation : est.EquationID;
            //        string[] separators = { " ", "/", "*", "+", "-", "&", "|", ">", "<", "=" };
            //        string[] arr = eqn.Split(separators, StringSplitOptions.None);

            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            var vNormWord = pEqValNorm.Where(a => a.NameInDb == arr[i]);
            //            var vWord = pEqVal.Where(a => a.NameInDb == arr[i]);
            //            if (vNormWord.Count() > 0 || vWord.Count() > 0)
            //            {
            //                string nameInDb = vWord.Count() > 0 ? vWord.SingleOrDefault().NameInDb : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().NameInDb : "");

            //                arr[i] = vWord.Count() > 0 ? vWord.SingleOrDefault().ColValue : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().ColValue : "0");

            //                if (est.ValidationMessage != null && Convert.ToString(est.ValidationMessage) != "")
            //                {
            //                    est.ValidationMessage = est.ValidationMessage.Replace("#" + nameInDb + "#", Convert.ToString(arr[i] as object));
            //                    // est.ValidationMessage = Regex.Replace(est.ValidationMessage, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");

            //                }
            //                nameInDb = String.Format(@"\b{0}\b", nameInDb);
            //                eqn = Regex.Replace(eqn, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");
            //            }
            //            else if (est.PermanentNameInDb == "TOTALHRS")
            //            {
            //                eqn = eqn.Replace(arr[i], "0");
            //            }

            //        }

            //        if (Regex.Matches(eqn, @"[a-zA-Z]").Count <= 0)
            //        {
            //            string[] separatorValidation = { "&" };
            //            string[] arr1 = eqn.Split(separatorValidation, StringSplitOptions.None);
            //            if (arr1.Length > 1)
            //            {
            //                for (int i = 0; i < arr1.Length; i++)
            //                {
            //                    if (Convert.ToString(arr1[i].Trim()) != "")
            //                    {
            //                        if (!Convert.ToBoolean(new DataTable().Compute(Convert.ToString(arr1[i].Trim()), null)))
            //                        {
            //                            message += est.ValidationMessage + "";
            //                        }
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                if (est.DBColPkID > 0)
            //                {
            //                    result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
            //                    result.MessageType = "S";
            //                    return;
            //                }
            //                else if (est.PermanentNameInDb == "TOTALHRS")
            //                {
            //                    result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
            //                    result.MessageType = "S";
            //                    return;
            //                }
            //                else if (!Convert.ToBoolean(new DataTable().Compute(eqn, null)))
            //                {
            //                    message += est.ValidationMessage + "";
            //                }
            //            }

            //        }
            //    }

            //    if (!isProjectLeader && est.PermanentNameInDb == "Dept")
            //    {
            //        BLUserRepository bluser = new BLUserRepository();
            //        User user = bluser.GetuserByID(UserID);
            //        if (user.DepartmentID != Convert.ToInt32(colValue))
            //        {
            //            message += "You can not create task for other department.";
            //        }
            //    }

            //    result.Message = message;
            //    result.MessageType = "S";
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }


        public void validateTaskEntry(int normId, bool isProjectLeader, string colValue, EstimationTaskColumnsMaster est, IEnumerable<NormDesDet> pEqVal, IEnumerable<NormDesDet> pEqValNorm,
            int UserID, int ProjectID, int ProjectTaskId, out OperationResult result, List<DateTime> milestonedates = null, ProjectTaskList ptl = null)
        {
            result = new OperationResult();
            //try
            //{
            //    string message = "";
            //    result = new OperationResult();

            //    if (est.PermanentNameInDb == "Norm")
            //    {
            //        result.Message = "";
            //        result.MessageType = "S";
            //        return;
            //    }
            //    //No validation for norm dependent field if norm is not selected.
            //    if (normId == 0 && est.DependonNorms == "Y")
            //    {
            //        result.Message = "";
            //        result.MessageType = "S";
            //        return;
            //    }

            //    if (est.IsMandatory == "Y")
            //    {
            //        if (colValue == null || colValue.Length <= 0)
            //        {
            //            message += est.DisplayColName + " is a mandatory field.";
            //        }
            //    }

            //    if ((est.DataType == "Number" || est.DataType == "UniqueNumber") && est.IsDropDown != "Y")
            //    {
            //        if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
            //        {
            //            decimal n;
            //            bool isNumeric = decimal.TryParse(colValue, out n);
            //            if (!isNumeric)
            //            {
            //                message += est.DisplayColName + " must be a numeric value.";
            //            }

            //            //else
            //            //{
            //            //    if (est.IsDbField != null)
            //            //        result.data = Convert.ToInt32(colValue);
            //            //    else
            //            //        result.data = Convert.ToDouble(colValue);

            //            //}

            //        }
            //    }

            //    if (est.DataType == "DateTime")
            //    {
            //        string[] formats = { "M/d/yyyy" };
            //        DateTime dateValue;
            //        if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
            //        {
            //            //if (est.PermanentNameInDb == "TaskProgressLevels")
            //            //{
            //            //}
            //            //else 
            //            string[] s = colValue.Split(' ');

            //            if (!DateTime.TryParseExact(s[0], formats, System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
            //            {
            //                message += " Date format must be - mm/dd/yyyy";
            //            }

            //            //else
            //            //{

            //            //    result.data = dateValue;

            //            //}

            //            if (est.PermanentNameInDb == "StartDate" && result.data != null)
            //            {
            //                BLProjectCreationRepository blp = new BLProjectCreationRepository();

            //                DateTime? psta = blp.GetProjectByID(ProjectID).ProjectStartDate;

            //                DateTime sta = Convert.ToDateTime(colValue);

            //                if (psta > sta)
            //                {
            //                    message += "Task start should be after the project start date.";
            //                }



            //            }


            //            if (est.PermanentNameInDb == "TaskProgressLevels" && result.data != null)
            //            {

            //                DateTime sta = Convert.ToDateTime(colValue);
            //                //milestonedates= milestonedates.Where(a=> a!= DateTime.MinValue).ToList();
            //                if (milestonedates.Any(a => a > sta) || !sta.IsBetween(ptl.StartDate, ptl.EndDate))
            //                    message += "Please enter the task milestone dates in correct sequence.";




            //            }
            //        }
            //    }
            //    if (Convert.ToString(est.DataType as object).ToLower().Contains("unique"))
            //    {
            //        NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
            //        if (!blObj.checkUniqueness(Convert.ToInt32(ProjectID), est.ProjectTaskListColumn, colValue, Convert.ToInt32(ProjectTaskId)))
            //        {
            //            message += MessageConstants.Duplicate;
            //        }
            //    }


            //    if (est.IsDropDown == "Y" && !String.IsNullOrEmpty(colValue))
            //    {

            //        Nullable<int> a = 0;
            //        Dictionary<string, string> dict = new Dictionary<string, string>();
            //        if (est.TableName.ToUpper() == "Users".ToUpper())
            //        {
            //            BLUserRepository blu = new BLUserRepository();
            //            List<User> u = blu.GetuserByName(colValue);
            //            if (u.Count() > 0)
            //            {

            //                a = u.FirstOrDefault().UserID;
            //                result.data = a;
            //            }
            //            else
            //            {

            //                message += MessageConstants.Notfoundinmaster.Replace("#ColValue#", colValue).Replace("#Tablename#", est.TableName);
            //            }


            //        }

            //        else
            //        {

            //            a = CheckifDDvalueExists(est.TableName, est.DBColName, colValue, ProjectID);

            //            if (a == 0)
            //            {

            //                message += MessageConstants.Notfoundinmaster.Replace("#ColValue#", colValue).Replace("#Tablename#", est.TableName);

            //            }

            //            else
            //            {

            //                //if (est.IsDbField != null)
            //                //    result.data = Convert.ToInt32(a);
            //                //else
            //                result.data = a;
            //            }


            //        }
            //    }
            //    //if ((est.Equationvalidation != null && est.Equationvalidation.Length > 0) || (est.EquationID != null && est.EquationID.Length > 0))
            //    //{
            //    //    string eqn = Convert.ToString(est.Equationvalidation as object).Length > 0 ? est.Equationvalidation : est.EquationID;
            //    //    string[] separators = { " ", "/", "*", "+", "-", "&", "|", ">", "<", "=" };
            //    //    string[] arr = eqn.Split(separators, StringSplitOptions.None);

            //    //    for (int i = 0; i < arr.Length; i++)
            //    //    {
            //    //        var vNormWord = pEqValNorm.Where(a => a.NameInDb == arr[i]);
            //    //        var vWord = pEqVal.Where(a => a.NameInDb == arr[i]);
            //    //        if (vNormWord.Count() > 0 || vWord.Count() > 0)
            //    //        {
            //    //            string nameInDb = vWord.Count() > 0 ? vWord.SingleOrDefault().NameInDb : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().NameInDb : "");

            //    //            arr[i] = vWord.Count() > 0 ? vWord.SingleOrDefault().ColValue : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().ColValue : "0");

            //    //            if (est.ValidationMessage != null && Convert.ToString(est.ValidationMessage) != "")
            //    //            {
            //    //                est.ValidationMessage = est.ValidationMessage.Replace("#" + nameInDb + "#", Convert.ToString(arr[i] as object));
            //    //                // est.ValidationMessage = Regex.Replace(est.ValidationMessage, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");

            //    //            }
            //    //            nameInDb = String.Format(@"\b{0}\b", nameInDb);
            //    //            eqn = Regex.Replace(eqn, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");
            //    //        }
            //    //        else if (est.PermanentNameInDb == "TOTALHRS")
            //    //        {
            //    //            eqn = eqn.Replace(arr[i], "0");
            //    //        }

            //    //    }

            //    //    if (Regex.Matches(eqn, @"[a-zA-Z]").Count <= 0)
            //    //    {
            //    //        string[] separatorValidation = { "&" };
            //    //        string[] arr1 = eqn.Split(separatorValidation, StringSplitOptions.None);
            //    //        if (arr1.Length > 1)
            //    //        {
            //    //            for (int i = 0; i < arr1.Length; i++)
            //    //            {
            //    //                if (Convert.ToString(arr1[i].Trim()) != "")
            //    //                {
            //    //                    if (!Convert.ToBoolean(new DataTable().Compute(Convert.ToString(arr1[i].Trim()), null)))
            //    //                    {
            //    //                        message += est.ValidationMessage + "";
            //    //                    }
            //    //                }
            //    //            }
            //    //        }
            //    //        else
            //    //        {
            //    //            if (est.DBColPkID > 0)
            //    //            {
            //    //                result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
            //    //                result.MessageType = "S";
            //    //                return;
            //    //            }
            //    //            else if (est.PermanentNameInDb == "TOTALHRS")
            //    //            {
            //    //                result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
            //    //                result.MessageType = "S";
            //    //                return;
            //    //            }
            //    //            else if (!Convert.ToBoolean(new DataTable().Compute(eqn, null)))
            //    //            {
            //    //                message += est.ValidationMessage + "";
            //    //            }
            //    //        }

            //    //    }
            //    //}

            //    if (!isProjectLeader && est.PermanentNameInDb == "Dept")
            //    {
            //        BLUserRepository bluser = new BLUserRepository();
            //        User user = bluser.GetuserByID(UserID);
            //        if (user.DepartmentID != Convert.ToInt32(colValue))
            //        {
            //            message += "You can not create task for other department.";
            //        }
            //    }

            //    result.Message = message;
            //    result.MessageType = "S";
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        private int getNextTaskNumberByProjectID(int ProjectID, int masterTaskTypeID)
        {
            int TaskNumber = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    // var res = context.ProjectTaskLists.Where(a => a.ProjectID == ProjectID && a.MasterTaskType==masterTaskTypeID).Max(a => a.TaskNo);
            //    var res = context.ProjectTaskLists.Where(a => a.ProjectID == ProjectID).Max(a => a.TaskNo);
            //    TaskNumber = Convert.ToInt32(res) + 1;
            //}
            return TaskNumber;
        }


        private Nullable<int> CheckifDDvalueExists(string tablename, string tablecolname, string value, int projectid)
        {
            Usp_CheckifDDvalueExists_Result i = null; ;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    i = context.Usp_CheckifDDvalueExists(tablename, tablecolname, value, projectid).ToList<Usp_CheckifDDvalueExists_Result>().FirstOrDefault();

            //}
            return i.PK_ID;


        }

        private int getNextTaskNumberByProjectID_Contract(int ProjectID)
        {
            int TaskNumber = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var res = context.ProjectTaskList_Contract.Where(a => a.ProjectID == ProjectID).Max(a => a.TaskNo);
            //    TaskNumber = Convert.ToInt32(res) + 1;
            //}
            return TaskNumber;
        }



        public string getTaskSequenceNumber(int ParentTaskID)
        {
            string TaskNo = "";
            try
            {

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    TaskNo = context.usp_getTaskSequenceNumber(ParentTaskID).ToList<usp_getTaskSequenceNumber_Result>().Select(x => x.TaskNo).FirstOrDefault();
                //    return TaskNo;
                //}
                return TaskNo;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
                return TaskNo;
            }


        }


        #endregion




    }
}
