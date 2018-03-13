using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public class BLProgressSheetRepository : IBLProgressSheetRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProgressSheet> _progressSheet;

        public BLProgressSheetRepository(WorkpackDBContext context, IGenericDataRepository<ProgressSheet> progressSheet)
        {
            _context = context;
            _progressSheet = progressSheet;
        }
        public IList<ProgressSheet> GetAllprogressSheet()
        {
            return _progressSheet.GetAll();
        }
        public ProgressSheet GetprogressSheetByID(int progressSheetID)
        {
            return _progressSheet.GetSingle(d => d.ProgressSheetid == progressSheetID);
        }
        public void AddprogressSheet(params ProgressSheet[] progressSheet)
        {
            try
            {
                _progressSheet.Add(progressSheet);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateprogressSheet(params ProgressSheet[] progressSheet)
        {
            try
            {
                _progressSheet.Update(progressSheet);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveprogressSheet(params ProgressSheet[] progressSheet)
        {
            try
            {
                _progressSheet.Remove(progressSheet);
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
        public static IList<usp_getProgressSheetProject_Result> getProgressSheetProject(DateTime startDate, DateTime endDate, int userID)
        {
            IList<usp_getProgressSheetProject_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProgressSheetProject(startDate, endDate, userID, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner), Convert.ToInt32(Common.ProjectStatus.Archived)).ToList<usp_getProgressSheetProject_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;

        }
        public IList<ProgressSheet> GetProgressSheetRecordsByTaskIDMilestoneID(int TaskID, int Milestone)
        {
            IList<ProgressSheet> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        list = db.ProgressSheets.Where(c => c.TaskID == TaskID && c.MilestoneID == Milestone).ToList<ProgressSheet>();
            //    }
            //    catch (Exception ex)
            //    { throw ex; }
            //}
            return list;
        }
        public static IList<usp_getViewTargetMilestone_Result> getViewTargetMilestone(int userID, int ProjectID, DateTime startDate, DateTime endDate)
        {
            IList<usp_getViewTargetMilestone_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getViewTargetMilestone(userID, ProjectID, startDate, endDate, Convert.ToInt32(Common.TaskStatusID.AcceptedByTaskOwner)).ToList<usp_getViewTargetMilestone_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static IList<usp_getTaskMilestoneTargetDates_Result> getTaskMilestoneTargetDatesByProjectID(int ProjectID)
        {
            IList<usp_getTaskMilestoneTargetDates_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskMilestoneTargetDates(ProjectID).ToList<usp_getTaskMilestoneTargetDates_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static IList<usp_getProgressSheetDataUsingTaskID_Result> getProgressSheetDataUsingTaskID(int ProjectTaskID)
        {
            IList<usp_getProgressSheetDataUsingTaskID_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getProgressSheetDataUsingTaskID(ProjectTaskID).ToList<usp_getProgressSheetDataUsingTaskID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;

        }
        public void UpdateprogressSheetDormantUser(int User, int ProjectTaskID, int ProjectID, int ProgressID, DateTime ActualDate, int TaskType, string Deviation)
        {
            try
            {
                //BLProgressSheetRepository blprogress = new BLProgressSheetRepository();
                //List<ProgressSheet> lstprogresssheet = blprogress.GetProgressSheetRecordsByTaskIDMilestoneID(ProjectTaskID, ProgressID).ToList<ProgressSheet>();
                //if (lstprogresssheet.Count > 0)
                //{
                //    foreach (var item in lstprogresssheet)
                //    {
                //        item.DeviationJustifcation = Deviation;
                //        item.EntityState = DominModel.EntityState.Modified;
                //        UpdateprogressSheet(item);
                //    }
                //}
                //else
                //{
                //    ProgressSheet prg = new ProgressSheet();
                //    prg.TaskID = ProjectTaskID;
                //    prg.MilestoneID = ProgressID;
                //    prg.UserID = User;
                //    prg.ProjectID = ProjectID;
                //    prg.TaskType = TaskType;
                //    prg.DeviationJustifcation = Deviation;
                //    prg.ProgressSheetStatus = Deviation == "" ? "Approved" : "Submit";
                //    if (Deviation == "")
                //    {
                //        prg.ApprovedDate = DateTime.Now;
                //    }
                //    prg.EntityState = DominModel.EntityState.Added;
                //    AddprogressSheet(prg);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetMaxProgressgroupTask(string ProjectTaskID, string ProjectID)
        {
            string weitage = "";

            //BLProjectMilestoneRepository prmile = new BLProjectMilestoneRepository();
            //BLTaskListRepository bltaskl = new BLTaskListRepository();
            //ProjectTaskList Prtl = bltaskl.getTaskDetailsByTaskId(Convert.ToInt32(ProjectTaskID));
            //List<ProjectMilestone> lstmile = prmile.GetMilestoneByProjectID(Convert.ToInt32(ProjectID));
            //int TaskType = Convert.ToInt32(Prtl.TaskTypeID);
            //BLTaskTypeWiseProgressRepository bltasktypewise = new BLTaskTypeWiseProgressRepository();
            //List<TaskTypeWiseProgress> lsttasktypewise = bltasktypewise.GetAllTaskTypeWiseProgressByProjectID(Convert.ToInt32(ProjectID));

            //List<ProjectTaskList> lstsubtasks = bltaskl.GetAllTaskList().Where(c => c.GroupTaskID == Convert.ToInt32(ProjectTaskID)).ToList<ProjectTaskList>();
            //var totalManhr = (from t in lstsubtasks
            //                  group t by new { } into g
            //                  select new { TotalManHours = g.Sum(c => c.AllottedHours) });
            //decimal Total_mhrs = 0;
            //foreach (var i in totalManhr)
            //{
            //    Total_mhrs = Convert.ToDecimal(i.TotalManHours);
            //}

            //BLProgressSheetRepository blprogress = new BLProgressSheetRepository();
            //BLTaskMilestoneTargetDates bltarget = new BLTaskMilestoneTargetDates();
            //decimal max2 = 0;
            //decimal defaultgrtaskprogress = 0;
            //ProjectTaskList prtlgr = bltaskl.getTaskDetailsByTaskId(Convert.ToInt32(ProjectTaskID));
            //if (prtlgr.ActualStartDate != null && prtlgr.ActualEndDate == null)
            //{
            //    List<ProgressSheet> lstprogress = blprogress.GetAllprogressSheet().Where(c => c.TaskID == Convert.ToInt32(ProjectTaskID)).OrderByDescending(a => a.MilestoneID).ToList<ProgressSheet>();
            //    if (lstprogress.Count > 0 && lstmile.Count > 0)
            //    {
            //        List<ProjectMilestone> lstnextmiles = lstmile.Where(c => c.ProjectMilestoneID > lstprogress.FirstOrDefault().MilestoneID).ToList<ProjectMilestone>();

            //        decimal nextmilesweitage = lstnextmiles.Count > 0 ? lsttasktypewise.Where(c => c.ProjectMilestoneID == lstnextmiles.FirstOrDefault().ProjectMilestoneID && c.TaskTypeID == TaskType).SingleOrDefault().PercentWeitage == null ? 0 : lsttasktypewise.Where(c => c.ProjectMilestoneID == lstnextmiles.FirstOrDefault().ProjectMilestoneID && c.TaskTypeID == TaskType).SingleOrDefault().PercentWeitage.Value : 100;
            //        decimal currentmileweitage = lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage == null ? 0 : lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage.Value;
            //        max2 = Convert.ToDecimal(prtlgr.AllottedHours) / Convert.ToDecimal(Total_mhrs) * (nextmilesweitage - 1);
            //        defaultgrtaskprogress = Convert.ToDecimal(prtlgr.AllottedHours) / Convert.ToDecimal(Total_mhrs) * currentmileweitage;
            //    }
            //    else if (lstmile.Count > 0)
            //    {
            //        decimal nextmilesweitage = lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage == null ? 0 : lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage.Value;
            //        max2 = Convert.ToDecimal(prtlgr.AllottedHours) / Convert.ToDecimal(Total_mhrs) * (nextmilesweitage - 1);
            //        defaultgrtaskprogress = Convert.ToDecimal(prtlgr.AllottedHours) / Convert.ToDecimal(Total_mhrs) * 0;
            //    }
            //    else
            //    {
            //        max2 = 0;
            //        defaultgrtaskprogress = 0;
            //    }
            //}
            //else if (prtlgr.ActualStartDate == null)
            //{
            //    max2 = 0;
            //    defaultgrtaskprogress = 0;
            //}
            //else if (prtlgr.ActualEndDate != null)
            //{
            //    max2 = Convert.ToDecimal(prtlgr.AllottedHours) / Convert.ToDecimal(Total_mhrs) * 100;
            //    defaultgrtaskprogress = Convert.ToDecimal(prtlgr.AllottedHours) / Convert.ToDecimal(Total_mhrs) * 100;
            //}

            //foreach (var item in lstsubtasks)
            //{
            //    decimal eachtaskprogress = 0;
            //    decimal defaulttaskprogressgr = 0;
            //    ProjectTaskList prtl = bltaskl.getTaskDetailsByTaskId(Convert.ToInt32(item.ProjectTaskID));
            //    if (prtl.ActualStartDate != null && prtl.ActualEndDate == null)
            //    {
            //        List<ProgressSheet> lstprogress = blprogress.GetAllprogressSheet().Where(c => c.TaskID == Convert.ToInt32(item.ProjectTaskID)).OrderByDescending(a => a.MilestoneID).ToList<ProgressSheet>();
            //        if (lstprogress.Count > 0 && lstmile.Count > 0)
            //        {
            //            List<ProjectMilestone> lstnextmiles = lstmile.Where(c => c.ProjectMilestoneID > lstprogress.FirstOrDefault().MilestoneID).ToList<ProjectMilestone>();

            //            decimal nextmilesweitage = lstnextmiles.Count > 0 ? lsttasktypewise.Where(c => c.ProjectMilestoneID == lstnextmiles.FirstOrDefault().ProjectMilestoneID && c.TaskTypeID == TaskType).SingleOrDefault().PercentWeitage == null ? 0 : lsttasktypewise.Where(c => c.ProjectMilestoneID == lstnextmiles.FirstOrDefault().ProjectMilestoneID && c.TaskTypeID == TaskType).SingleOrDefault().PercentWeitage.Value : 100;

            //            decimal currentmileweitage = lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage == null ? 0 : lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage.Value;
            //            eachtaskprogress = Convert.ToDecimal(item.AllottedHours) / Convert.ToDecimal(Total_mhrs) * (nextmilesweitage - 1);
            //            defaulttaskprogressgr = Convert.ToDecimal(item.AllottedHours) / Convert.ToDecimal(Total_mhrs) * currentmileweitage;
            //        }
            //        else if (lstmile.Count > 0)
            //        {
            //            decimal nextmilesweitage = lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage == null ? 0 : lsttasktypewise.Where(c => c.ProjectMilestoneID == lstprogress.FirstOrDefault().MilestoneID && c.TaskTypeID == TaskType).FirstOrDefault().PercentWeitage.Value;
            //            eachtaskprogress = Convert.ToDecimal(item.AllottedHours) / Convert.ToDecimal(Total_mhrs) * (nextmilesweitage - 1);
            //            defaulttaskprogressgr = Convert.ToDecimal(item.AllottedHours) / Convert.ToDecimal(Total_mhrs) * 0;
            //        }
            //        else
            //        {
            //            eachtaskprogress = 0;
            //            defaulttaskprogressgr = 0;
            //        }
            //    }
            //    else if (prtl.ActualStartDate == null)
            //    {
            //        eachtaskprogress = 0;
            //        defaulttaskprogressgr = 0;
            //    }
            //    else if (prtl.ActualEndDate != null)
            //    {
            //        eachtaskprogress = Convert.ToDecimal(item.AllottedHours) / Convert.ToDecimal(Total_mhrs) * 100;
            //        defaulttaskprogressgr = Convert.ToDecimal(item.AllottedHours) / Convert.ToDecimal(Total_mhrs) * 100;
            //    }
            //    max2 = max2 + Math.Round(Convert.ToDecimal(eachtaskprogress), 2);

            //    defaultgrtaskprogress = defaultgrtaskprogress + Math.Round(Convert.ToDecimal(defaulttaskprogressgr), 2);
            //}
            //weitage = Convert.ToString(max2);
            return weitage;
        }
        public OperationResult AddUpdateProgressSheetResult(string ProjectID, string UserID, Dictionary<string, string[]> item, string ProjectTaskID, string DeviationJustification, string TaskTypeID, string TaskCancelledDate, string JoiningDate)
        {
            OperationResult result = new OperationResult();
            //Dictionary<string, string> dictReturnData = new Dictionary<string, string>();
            //CultureInfo ci = new CultureInfo("en-Gb");
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    DominModel.ProgressSheet objProgressSheet = null;
            //    DateTime TCancelledDate = DateTime.Now.Date;
            //    DateTime JoiningDt = DateTime.Now.Date;
            //    string resultMsg = "";
            //    var dateList = new List<DateTime>();
            //    int latestMilestoneID = 0;
            //    string MaxTimesheetDate = "";
            //    decimal MaxProgressValue = 0;
            //    int EnteredProgressValue = 0;
            //    string isGrouptask = "N";
            //    String isSysGen = "N";
            //    bool Devstatus = true, lessenddatestatus = true, maxProgressstatus = true, actualstartstatus = true, GreaterDateStatus = true, dateStatus = true, saveStatus = false, isFutureDate = false, isTaskTransferError = false, isCancelled = false, isJoiningDate = false, isTaskCancelledError = false;
            //    string isTaskTransferDatePeriod = "";
            //    try
            //    {
            //        BLTaskListRepository blTask = new BLTaskListRepository();
            //        BLTaskMilestoneTargetDates blTaskMile = new BLTaskMilestoneTargetDates();
            //        DataTable dt = new DataTable("Table");
            //        dt.Columns.Add("MilestoneID");
            //        dt.Columns.Add("PlanedTargetDate");
            //        dt.Columns.Add("ActualTargetDate");
            //        dt.Columns.Add("DeviationJustifcation");
            //        dt.Columns.Add("ProgressSheetID");
            //        dt.Columns.Add("ProgressSheetStatus");
            //        int taskid = Convert.ToInt32(ProjectTaskID);

            //        ProjectTaskList prtl = blTask.getTaskDetailsByTaskId(taskid);
            //        isGrouptask = Convert.ToString(prtl.IsgroupTask);
            //        DateTime startDate = Convert.ToDateTime(prtl.StartDate);
            //        DateTime endDate = Convert.ToDateTime(prtl.EndDate);
            //        isSysGen = prtl.SysGen;


            //        EnteredProgressValue = Convert.ToInt32(prtl.TaskProgress);
            //        IList<usp_getProgressSheetDataUsingTaskID_Result> dPre = null;

            //        IList<usp_getViewTargetMilestone_Result> dtMainGrid = null;
            //        dPre = BLProgressSheetRepository.getProgressSheetDataUsingTaskID(taskid);
            //        dtMainGrid = BLProgressSheetRepository.getViewTargetMilestone(Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), startDate, endDate).Where(c => c.ProjectTaskID == taskid).ToList<usp_getViewTargetMilestone_Result>();
            //        string strActualStartJustID = "";
            //        string strActualstartDeviation = "";
            //        string strActualstartApproveStatus = "";
            //        string strActualstartApprovalClass = "";
            //        string strActualstartRemark = "";
            //        string strActualEndJustID = "";
            //        string strActualEndDeviation = "";
            //        string strActualEndApproveStatus = "";
            //        string strActualEndApprovalClass = "";
            //        string strActualEndRemark = "";
            //        string startEnteredUser = "";

            //        if (dPre.Count > 0)
            //        {
            //            //MileStoneID=0 for startDate justification and Billing='Y' for isStart and Billing='N' for IsEnd
            //            usp_getProgressSheetDataUsingTaskID_Result drStart = dPre.FirstOrDefault(p => p.TaskID == taskid && p.MilestoneID == 0 && p.Billing == "Y");
            //            if (drStart != null)
            //            {
            //                strActualStartJustID = Convert.ToString(drStart.ProgressSheetid);
            //                strActualstartDeviation = Convert.ToString(drStart.DeviationJustifcation);
            //                strActualstartApproveStatus = Convert.ToString(drStart.ProgressSheetStatus);
            //                strActualstartApprovalClass = Convert.ToString(drStart.AcceptanceClass);
            //                strActualstartRemark = Convert.ToString(drStart.Remarks);
            //                //if (strActualstartApproveStatus.Trim() == "Approved")
            //                //{
            //                //    txtActualstart.Enabled = false;
            //                //    txtActualstart.ToolTip = Common.MessageConstants.CannotEditRecord.Replace("#SUBJECT#", "start date");
            //                //}
            //            }
            //            usp_getProgressSheetDataUsingTaskID_Result drEnd = dPre.FirstOrDefault(p => p.TaskID == taskid && p.MilestoneID == 0 && p.Billing == "N");
            //            if (drEnd != null)
            //            {
            //                strActualEndJustID = Convert.ToString(drEnd.ProgressSheetid);
            //                strActualEndDeviation = Convert.ToString(drEnd.DeviationJustifcation);
            //                strActualEndApproveStatus = Convert.ToString(drEnd.ProgressSheetStatus);
            //                strActualEndApprovalClass = Convert.ToString(drEnd.AcceptanceClass);
            //                strActualEndRemark = Convert.ToString(drEnd.Remarks);
            //                //if (hdnActualEndApproveStatus.Value.Trim() == "Approved")
            //                //{
            //                //    txtActualEndDate.Enabled = false;
            //                //    txtActualEndDate.ToolTip = Common.MessageConstants.CannotEditRecord.Replace("#SUBJECT#", "end date");
            //                //}
            //            }
            //        }
            //        ////// type == "TASK"
            //        string str = DeviationJustification;
            //        if (TaskCancelledDate != "")
            //        {
            //            isCancelled = true;
            //            TCancelledDate = Convert.ToDateTime(TaskCancelledDate, ci);
            //        }

            //        if (JoiningDate != "")
            //        {
            //            JoiningDt = Convert.ToDateTime(JoiningDate, ci);
            //        }

            //        ProjectTaskList task = new ProjectTaskList();

            //        var T = item
            //               .Where(i => i.Value[0] == "TASK").Select(a => a.Value);
            //        string txtStartID = "";
            //        Dictionary<string, string> dictTask = new Dictionary<string, string>();
            //        foreach (var t in T)
            //        {
            //            if (Convert.ToString(t[1]) == "ActualStartDate")
            //            {
            //                txtStartID = t[2];
            //            }
            //            dictTask.Add(t[1], t[2]);
            //        }

            //        if (txtStartID != null)
            //        {
            //            if (txtStartID != "" && strActualstartApproveStatus.Trim() != "Approved")
            //            {
            //                if (isCancelled)
            //                {
            //                    if (Convert.ToDateTime(TCancelledDate, ci) < Convert.ToDateTime(txtStartID, ci))
            //                    {
            //                        isTaskCancelledError = true;
            //                    }
            //                }
            //                //if (JoiningDt > Convert.ToDateTime(txtStartID, ci))
            //                //{
            //                //    isJoiningDate = true;
            //                //}
            //              //  if (!isTaskCancelledError && !isJoiningDate)
            //                  if (!isTaskCancelledError )
            //                {
            //                    //isJoiningDate = false;
            //                    startEnteredUser = dtMainGrid.Count > 0 ? Convert.ToString(dtMainGrid.SingleOrDefault().startEnteredUser) : "";
            //                    if (startEnteredUser == "" || startEnteredUser == UserID)
            //                    {

            //                        DataRow dr = dt.NewRow();
            //                        dr["MilestoneID"] = -1;
            //                        dr["PlanedTargetDate"] = Convert.ToDateTime(dictTask["PlannedStartDate"], ci);
            //                        dr["ActualTargetDate"] = Convert.ToDateTime(dictTask["ActualStartDate"], ci);
            //                        int ActualStartJustID = strActualStartJustID == "" ? 0 : Convert.ToInt32(strActualStartJustID);
            //                        dr["ProgressSheetID"] = ActualStartJustID;
            //                        //deviation justification not captured
            //                        dr["DeviationJustifcation"] = "";
            //                        dr["ProgressSheetStatus"] = Common.ProgressSheetStatus.Approved;
            //                        /* if (Convert.ToDateTime(dictTask["PlannedStartDate"], ci) >= Convert.ToDateTime(dictTask["ActualStartDate"], ci))
            //                         {
            //                             dr["DeviationJustifcation"] = "";
            //                             dr["ProgressSheetStatus"] = Common.ProgressSheetStatus.Approved;
            //                         }
            //                         else
            //                         {
            //                             dr["ProgressSheetStatus"] = Common.ProgressSheetStatus.Submit;
            //                             if (str.Contains("start"))
            //                             {
            //                                 var keyValuePairs1 = str.Split('$').Where(x => x.Contains("start")).First().Split('#');
            //                                 if (keyValuePairs1.Length > 1)
            //                                 {
            //                                     var keyValuePairs = str.Split('$').Where(x => x.Contains("start")).First().Split('#')[1];
            //                                     dr["DeviationJustifcation"] = Convert.ToString(keyValuePairs);
            //                                 }
            //                                 else
            //                                 {
            //                                     Devstatus = false;
            //                                     resultMsg = resultMsg + "Enter deviation justification for actual start.</br>";
            //                                 }
            //                             }
            //                             else
            //                             {
            //                                 if (strActualstartDeviation.Length > 0)
            //                                 {
            //                                     dr["DeviationJustifcation"] = strActualstartDeviation;
            //                                 }
            //                                 else
            //                                 {
            //                                     Devstatus = false;
            //                                     dr["DeviationJustifcation"] = "";
            //                                     resultMsg = resultMsg + "Enter deviation justification for actual start.</br> ";
            //                                 }
            //                             }
            //                         }
            //                         */
            //                        if (Convert.ToDateTime(txtStartID, ci).Date > DateTime.Now.Date)
            //                        {
            //                            isFutureDate = true;
            //                        }

            //                        dateList.Add(Convert.ToDateTime(txtStartID, ci));
            //                        dt.Rows.Add(dr);
            //                    }
            //                }
            //                else
            //                {
            //                    if (isTaskCancelledError)
            //                    {
            //                        string isTaskCancelMsg = MessageConstants.TaskCancelledError.Replace("#canceldate#", TaskCancelledDate);
            //                        resultMsg = resultMsg + isTaskCancelMsg + " </br>";
            //                    }
            //                    //if (isJoiningDate)
            //                    //{
            //                    //    string isJoiningDateMsg = MessageConstants.JoiningDateError.Replace("#joiningdate#", JoiningDate);
            //                    //    resultMsg = resultMsg + isJoiningDateMsg + " </br>";
            //                    //}
            //                }
            //            }
            //        }
            //        else
            //        {
            //            actualstartstatus = false;
            //            resultMsg = resultMsg + " Actual date can not be null.</br>";
            //        }
            //        //////////END//////For actual start date validation


            //        ///////////start for Progress//////////////
            //        var Prg = item
            //            .Where(i => i.Value[0] == "PROGRESS").Select(a => a.Value);
            //        Dictionary<string, string> dictTaskPrg = new Dictionary<string, string>();
            //        List<int> lstMilestoneIDs = new List<int>();
            //        foreach (var t in Prg)
            //        {
            //            dictTaskPrg.Add(t[1], t[2]);
            //        }

            //        BLProjectMilestoneRepository blmile = new BLProjectMilestoneRepository();
            //        List<ProjectMilestone> lstmilestones = null;
            //        lstmilestones = blmile.GetMilestoneByProjectIDTaskTypeID(Convert.ToInt32(ProjectID), Convert.ToInt32(TaskTypeID));

            //        BLTaskTypeWiseProgressRepository bltypewise = new BLTaskTypeWiseProgressRepository();
            //        List<TaskTypeWiseProgress> lstTypewise = null;

            //        if (isSysGen != "Y")
            //        {
            //            var bookedPer = blmile.GetLatestedBookMilestonePer(Convert.ToInt32(ProjectID), Convert.ToInt32(TaskTypeID), taskid);
            //            string perProgress = Convert.ToString(bookedPer.Split('#')[0]);
            //            string perProgressName = Convert.ToString(bookedPer.Split('#')[1]);

            //            if (Convert.ToDecimal(perProgress) > Convert.ToDecimal(dictTask["Progress"]))
            //            {
            //                maxProgressstatus = false;
            //                resultMsg = resultMsg + "% Progres must be greater or equal to " + perProgress + " as " + Convert.ToString(perProgressName) + " has  been achieved.";
            //            }



            //            var lsttargetmilestoleids = (from t in lstmilestones select t.ProjectMilestoneID).Distinct().ToList();
            //            foreach (var m in lsttargetmilestoleids)
            //            {
            //                lstMilestoneIDs.Add(m);
            //            }
            //            ///////////////////For progress level date validation
            //            bool ChkMaxmileVal = true;
            //            //lstMilestoneIDs.Sort();
            //            for (int i = 1; i <= lstMilestoneIDs.Count; i++)
            //            {
            //                string PlannedMilestone = dictTaskPrg.ContainsKey("Planned" + lstMilestoneIDs[i - 1].ToString()) ? dictTaskPrg["Planned" + lstMilestoneIDs[i - 1].ToString()] : "";
            //                string ActualMilestone = dictTaskPrg.ContainsKey("Actual" + lstMilestoneIDs[i - 1].ToString()) ? dictTaskPrg["Actual" + lstMilestoneIDs[i - 1].ToString()] : "";

            //                string hdnHandoverToAnotherPeriod = dtMainGrid.Count > 0 ? Convert.ToString(dtMainGrid.SingleOrDefault().HandoverToAnotherPeriod) == null ? "" : Convert.ToString(dtMainGrid.SingleOrDefault().HandoverToAnotherPeriod) : "";
            //                string HandoverPeriod = dtMainGrid.Count > 0 ? Convert.ToString(dtMainGrid.SingleOrDefault().HandoverPeriod) == null ? "" : Convert.ToString(dtMainGrid.SingleOrDefault().HandoverPeriod) : "";

            //                BLProjectMilestoneRepository blprojmile = new BLProjectMilestoneRepository();
            //                ProjectMilestone lstMiles = null;
            //                lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));
            //                usp_getProgressSheetDataUsingTaskID_Result dr = dPre.Count > 0 ? dPre.FirstOrDefault(p => p.TaskID == taskid && p.MilestoneID == lstMilestoneIDs[i - 1]) : null;
            //                string ApproveStatus = "";
            //                string strProgressSheetID = "";
            //                string strIsTransUser = "";
            //                string strActualSubmitUser = "";
            //                string strDeviationJust = "";
            //                string milestoneID = lstMilestoneIDs[i - 1].ToString();
            //                if (dr != null)
            //                {
            //                    ApproveStatus = Convert.ToString(dr.ProgressSheetStatus);
            //                    strProgressSheetID = Convert.ToString(dr.ProgressSheetid);
            //                    strIsTransUser = dtMainGrid.Count > 0 ? Convert.ToString(dtMainGrid.SingleOrDefault().IsTransUser) : "";
            //                    strActualSubmitUser = Convert.ToString(dr.UserID);
            //                    strDeviationJust = Convert.ToString(dr.DeviationJustifcation);
            //                }
            //                //if (isGrouptask != "Y")
            //                //{
            //                //if (PlannedMilestone != "" && ActualMilestone == "" && isGrouptask != "Y")
            //                //{
            //                //    lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));
            //                //    lstTypewise = bltypewise.GetAllTaskTypeWiseProgressByProjectIDandMilestoneIDandTaskTypeID(Convert.ToInt32(ProjectID), Convert.ToInt32(lstMilestoneIDs[i - 1]), Convert.ToInt32(TaskTypeID));
            //                //    decimal currentweitage =lstTypewise.Count>0?Convert.ToInt32(lstTypewise.FirstOrDefault().PercentWeitage):0;
            //                //    MaxProgressValue = currentweitage;
            //                //    if (Convert.ToDecimal(dictTask["Progress"]) >= MaxProgressValue && MaxProgressValue>0)
            //                //    {
            //                //        maxProgressstatus = false;
            //                //        resultMsg = resultMsg + "Maximum progress should be less than " + MaxProgressValue + " %, as " + Convert.ToString(lstMiles.ProjectMilestone1) + " has not been achieved.</br>";
            //                //    }
            //                //    else if (MaxProgressValue == 0)
            //                //    {
            //                //        maxProgressstatus = false;
            //                //        resultMsg = resultMsg + "Progress percentage is not defined for " + Convert.ToString(lstMiles.ProjectMilestone1) + " .</br>";                                    
            //                //    }
            //                //}
            //                //else if (txtStartID != "" && ActualMilestone == "" && ChkMaxmileVal && isGrouptask != "Y")
            //                //{

            //                //    lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));
            //                //    lstTypewise = bltypewise.GetAllTaskTypeWiseProgressByProjectIDandMilestoneIDandTaskTypeID(Convert.ToInt32(ProjectID), Convert.ToInt32(lstMilestoneIDs[i - 1]), Convert.ToInt32(TaskTypeID));
            //                //    decimal currentweitage = lstTypewise.Count > 0 ? Convert.ToInt32(lstTypewise.FirstOrDefault().PercentWeitage) : 0;

            //                //    MaxProgressValue = currentweitage;
            //                //    if (Convert.ToDecimal(dictTask["Progress"]) >= MaxProgressValue && MaxProgressValue > 0)
            //                //    {
            //                //        maxProgressstatus = false;
            //                //        ChkMaxmileVal = false;
            //                //        resultMsg = resultMsg + "Maximum progress should be less than " + MaxProgressValue + " %, as " + Convert.ToString(lstMiles.ProjectMilestone1) + " has not been achieved.</br>";
            //                //    }
            //                //    else if (MaxProgressValue == 0)
            //                //    {
            //                //        maxProgressstatus = false;
            //                //        resultMsg = resultMsg + "Progress percentage is not defined for " + Convert.ToString(lstMiles.ProjectMilestone1) + " .</br>";
            //                //    }
            //                //}
            //                //}
            //                //else
            //                //{
            //                //    string maxvalueusingsubtask = BLProgressSheetRepository.GetMaxProgressgroupTask(ProjectTaskID, ProjectID);
            //                //    if (PlannedMilestone != "" && ActualMilestone == "")
            //                //    {
            //                //        lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));
            //                //        lstTypewise = bltypewise.GetAllTaskTypeWiseProgressByProjectIDandMilestoneIDandTaskTypeID(Convert.ToInt32(ProjectID), Convert.ToInt32(lstMilestoneIDs[i - 1]), Convert.ToInt32(TaskTypeID));
            //                //        decimal currentweitage = lstTypewise.Count > 0 ? Convert.ToInt32(lstTypewise.FirstOrDefault().PercentWeitage) : 0;
            //                //        MaxProgressValue = Convert.ToDecimal(maxvalueusingsubtask) > currentweitage ? Convert.ToDecimal(maxvalueusingsubtask) : currentweitage;
            //                //        if (Convert.ToDecimal(dictTask["Progress"]) >= MaxProgressValue && MaxProgressValue > 0)
            //                //        {
            //                //            maxProgressstatus = false;
            //                //            resultMsg = resultMsg + "Maximum progress should be less than " + MaxProgressValue + " %, as " + Convert.ToString(lstMiles.ProjectMilestone1) + " has not been achieved.</br>";
            //                //        }
            //                //        else if (MaxProgressValue == 0)
            //                //        {
            //                //            maxProgressstatus = false;
            //                //            resultMsg = resultMsg + "Progress percentage is not defined for " + Convert.ToString(lstMiles.ProjectMilestone1) + " .</br>";
            //                //        }
            //                //    }
            //                //    else if (txtStartID != "" && ActualMilestone == "" && ChkMaxmileVal)
            //                //    {

            //                //        lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));
            //                //        lstTypewise = bltypewise.GetAllTaskTypeWiseProgressByProjectIDandMilestoneIDandTaskTypeID(Convert.ToInt32(ProjectID), Convert.ToInt32(lstMilestoneIDs[i - 1]), Convert.ToInt32(TaskTypeID));
            //                //        decimal currentweitage = lstTypewise.Count > 0 ? Convert.ToInt32(lstTypewise.FirstOrDefault().PercentWeitage) : 0;
            //                //        MaxProgressValue = Convert.ToDecimal(maxvalueusingsubtask) > currentweitage ? Convert.ToDecimal(maxvalueusingsubtask) : currentweitage;
            //                //        if (Convert.ToDecimal(dictTask["Progress"]) >= MaxProgressValue && MaxProgressValue > 0)
            //                //        {
            //                //            maxProgressstatus = false;
            //                //            ChkMaxmileVal = false;
            //                //            resultMsg = resultMsg + "Maximum progress should be less than " + MaxProgressValue + " %, as " + Convert.ToString(lstMiles.ProjectMilestone1) + " has not been achieved.</br>";
            //                //        }
            //                //        else if (MaxProgressValue == 0)
            //                //        {
            //                //            maxProgressstatus = false;
            //                //            ChkMaxmileVal = false;
            //                //            resultMsg = resultMsg + "Progress percentage is not defined for " + Convert.ToString(lstMiles.ProjectMilestone1) + " .</br>";
            //                //        }

            //                //    }
            //                //}
            //                if (ActualMilestone != null && lstMilestoneIDs[i - 1].ToString() != null)
            //                {

            //                    if ((ActualMilestone != "" && lstMilestoneIDs[i - 1].ToString() != "" && ApproveStatus != "Approved") || (ActualMilestone != "" && strProgressSheetID != null && strProgressSheetID != "" && Convert.ToInt32(strProgressSheetID) > 0))
            //                    {
            //                        if (isCancelled)
            //                        {
            //                            if (TCancelledDate < Convert.ToDateTime(PlannedMilestone, ci))
            //                            {
            //                                isTaskCancelledError = true;
            //                            }
            //                        }

            //                        //if (JoiningDt > Convert.ToDateTime(txtStartID, ci))
            //                        //{
            //                        //    isJoiningDate = true;
            //                        //}
            //                        if (i == 1)
            //                        {
            //                            string ActualStartdt = Convert.ToString(dictTask["ActualStartDate"]);
            //                            string ActMilestn = ActualMilestone;
            //                            if (Convert.ToDateTime(ActualStartdt, ci) > Convert.ToDateTime(ActMilestn, ci))
            //                            {
            //                                lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));
            //                                GreaterDateStatus = false;
            //                                resultMsg = resultMsg + "Actual " + Convert.ToString(lstMiles.ProjectMilestone1) + " can not be less than Actual start date.</br>";
            //                            }
            //                        }
            //                        else
            //                        {
            //                            string ActualMilestonePrevDate = dictTaskPrg.ContainsKey("Actual" + lstMilestoneIDs[i - 2].ToString()) ? dictTaskPrg["Actual" + lstMilestoneIDs[i - 2].ToString()] : "";
            //                            string ActMilestn = ActualMilestone;
            //                            if (ActualMilestonePrevDate != "")
            //                            {
            //                                if (Convert.ToDateTime(ActualMilestonePrevDate, ci) > Convert.ToDateTime(ActMilestn, ci))
            //                                {
            //                                    lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));

            //                                    GreaterDateStatus = false;
            //                                    resultMsg = resultMsg + "Actual " + Convert.ToString(lstMiles.ProjectMilestone1) + " can not be less than Actual " + blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 2])).ProjectMilestone1.ToString() + "</br>";
            //                                }
            //                            }
            //                        }
            //                       // if (!isTaskCancelledError && !isJoiningDate)
            //                         if (!isTaskCancelledError )
            //                        {
            //                            bool isValidEntry = true;
            //                       //     isJoiningDate = false;

            //                            //START//////////////////////// TO CHECK WHETHER USER IS OWNER OR NOT FOR ENTERED DATE////////////////////////////////////////////START//

            //                            // N MEANS USER IS ORIGINAL USER OF THE TASK
            //                            if (strIsTransUser == "N")
            //                            {
            //                                string[] dateCount_A = hdnHandoverToAnotherPeriod.Split(',');
            //                                string[] dateCount_O = HandoverPeriod.Split(',');
            //                                for (int m = 0; m < dateCount_A.Count(); m++)
            //                                {
            //                                    string[] n = dateCount_A[m].Split(':');
            //                                    if (n[0] != "")
            //                                    {
            //                                        DateTime ss = Convert.ToDateTime(n[0], ci);
            //                                        DateTime ee = Convert.ToDateTime(n[1], ci);
            //                                        try
            //                                        {
            //                                            if (Convert.ToDateTime(ActualMilestone, ci).Date >= ss && Convert.ToDateTime(ActualMilestone, ci).Date <= ee)
            //                                            {
            //                                                for (int o = 0; o < dateCount_O.Count(); o++)
            //                                                {
            //                                                    string[] n_o = dateCount_O[o].Split(':');
            //                                                    if (n_o[0] != "")
            //                                                    {
            //                                                        DateTime s_o = Convert.ToDateTime(n_o[0]);
            //                                                        DateTime e_o = Convert.ToDateTime(n_o[1]);
            //                                                        if (Convert.ToDateTime(ActualMilestone, ci).Date >= s_o.Date && Convert.ToDateTime(ActualMilestone, ci).Date <= e_o.Date
            //                                                            && ss.Date <= s_o.Date && e_o.Date <= ee.Date)
            //                                                        {
            //                                                            isValidEntry = true;
            //                                                        }
            //                                                        else
            //                                                        {
            //                                                            isValidEntry = false;
            //                                                            isTaskTransferDatePeriod = isTaskTransferDatePeriod + ss.ToString("dd/MM/yyyyy") + " and " + ee.ToString("dd/MM/yyyyy") + ",";
            //                                                        }
            //                                                    }//if n_o!=""
            //                                                    else
            //                                                    {
            //                                                        isValidEntry = false;
            //                                                        isTaskTransferDatePeriod = isTaskTransferDatePeriod + ss.ToString("dd/MM/yyyyy") + " and " + ee.ToString("dd/MM/yyyyy") + ",";
            //                                                    }
            //                                                }//for dateCount_O
            //                                            }//for d
            //                                        }//try
            //                                        catch (Exception ex) { }
            //                                    }
            //                                }//for m
            //                            }//N

            //                            // Y MEANS USER IS NOT ORIGINAL USER OF THE TASK.TASK IS TRANSFERED OR HANDOVERED TO USER.
            //                            if (strIsTransUser == "Y")
            //                            {
            //                                string[] dateCount_O = hdnHandoverToAnotherPeriod.Split(',');
            //                                string[] dateCount_A = HandoverPeriod.Split(',');
            //                                for (var m = 0; m < dateCount_A.Count(); m++)
            //                                {
            //                                    string[] n = dateCount_A[m].Split(':');
            //                                    if (n[0] != "")
            //                                    {
            //                                        DateTime ss = Convert.ToDateTime(n[0], ci);
            //                                        DateTime ee = Convert.ToDateTime(n[1], ci);
            //                                        try
            //                                        {
            //                                            if (Convert.ToDateTime(ActualMilestone, ci).Date >= ss && Convert.ToDateTime(ActualMilestone, ci).Date <= ee)
            //                                            {
            //                                                for (int o = 0; o < dateCount_O.Count(); o++)
            //                                                {
            //                                                    string[] n_o = dateCount_O[o].Split(':');
            //                                                    if (n_o[0] != "")
            //                                                    {
            //                                                        DateTime s_o = Convert.ToDateTime(n_o[0]);
            //                                                        DateTime e_o = Convert.ToDateTime(n_o[1]);

            //                                                        if (Convert.ToDateTime(ActualMilestone, ci).Date >= s_o && Convert.ToDateTime(ActualMilestone, ci).Date <= e_o
            //                                                            && ss <= s_o && e_o <= ee)
            //                                                        {
            //                                                            isValidEntry = false;
            //                                                            isTaskTransferDatePeriod = isTaskTransferDatePeriod + ss.ToString("dd/MM/yyyyy") + " and " + ee.ToString("dd/MM/yyyyy") + ",";
            //                                                        }
            //                                                        else
            //                                                        {
            //                                                            isValidEntry = true;
            //                                                        }
            //                                                    }

            //                                                }//for dateCount_O

            //                                            }//for d
            //                                            else
            //                                            {
            //                                                isValidEntry = false;
            //                                                isTaskTransferDatePeriod = isTaskTransferDatePeriod + ss.ToString("dd/MM/yyyyy") + " and " + ee.ToString("dd/MM/yyyyy") + ",";
            //                                            }

            //                                        }//try
            //                                        catch (Exception ex) { }
            //                                    }
            //                                }//for m
            //                            }


            //                            if (!isValidEntry && (strActualSubmitUser == "" || strActualSubmitUser == Convert.ToString(UserID)))
            //                            {
            //                                isTaskTransferError = true;
            //                                break;
            //                            }


            //                            //END ///////////////////////////////// TO CHECK WHETHER USER IS OWNER OR NOT FOR ENTERED DATE////////////////////////////////END//

            //                            if (strActualSubmitUser == "" || strActualSubmitUser == Convert.ToString(UserID) ||
            //                                (strActualSubmitUser != Convert.ToString(UserID) && ApproveStatus != "Approved"))
            //                            {
            //                                if (isValidEntry)
            //                                {
            //                                    if (Convert.ToDateTime(ActualMilestone, ci).Date > DateTime.Now.Date)
            //                                    {
            //                                        isFutureDate = true;
            //                                    }

            //                                    Nullable<DateTime> PlanedTargetDate;
            //                                    if (PlannedMilestone != "")
            //                                    {
            //                                        PlanedTargetDate = Convert.ToDateTime(PlannedMilestone, ci);
            //                                    }
            //                                    else
            //                                    {
            //                                        PlanedTargetDate = null;
            //                                    }

            //                                    DataRow dr1 = dt.NewRow();
            //                                    dr1["MilestoneID"] = Convert.ToInt32(lstMilestoneIDs[i - 1]);
            //                                    dr1["PlanedTargetDate"] = PlanedTargetDate;
            //                                    dr1["ActualTargetDate"] = ActualMilestone != "" ? Convert.ToDateTime(ActualMilestone, ci) : DateTime.MaxValue;

            //                                    if (ActualMilestone != "" && PlannedMilestone != "")
            //                                    {
            //                                        dr1["DeviationJustifcation"] = "";
            //                                        dr1["ProgressSheetStatus"] = Common.ProgressSheetStatus.Approved;
            //                                        /*if (Convert.ToDateTime(PlanedTargetDate, ci) >= Convert.ToDateTime(ActualMilestone, ci))
            //                                        {
            //                                            dr1["DeviationJustifcation"] = "";
            //                                            dr1["ProgressSheetStatus"] = Common.ProgressSheetStatus.Approved;
            //                                        }
            //                                        else
            //                                        {
            //                                            dr1["ProgressSheetStatus"] = Common.ProgressSheetStatus.Submit;
            //                                            if (str.Contains(lstMilestoneIDs[i - 1].ToString()))
            //                                            {
            //                                                var keyValuePairs1 = str.Split('$').Where(x => x.Contains(lstMilestoneIDs[i - 1].ToString())).First().Split('#');
            //                                                if (keyValuePairs1.Length > 1)
            //                                                {
            //                                                    var keyValuePairs = str.Split('$').Where(x => x.Contains(lstMilestoneIDs[i - 1].ToString())).First().Split('#')[1];
            //                                                    dr1["DeviationJustifcation"] = Convert.ToString(keyValuePairs);
            //                                                }
            //                                                else
            //                                                {
            //                                                    Devstatus = false;
            //                                                    resultMsg = resultMsg + "Enter deviation justification for " + lstMiles.ProjectMilestone1 + ".</br>";
            //                                                }
            //                                            }
            //                                            else
            //                                            {
            //                                                if (strDeviationJust.Length > 0)
            //                                                {
            //                                                    dr1["DeviationJustifcation"] = strDeviationJust;
            //                                                }
            //                                                else
            //                                                {
            //                                                    Devstatus = false;
            //                                                    resultMsg = resultMsg + "Enter deviation justification for " + lstMiles.ProjectMilestone1 + ".</br>";
            //                                                }
            //                                            }
            //                                        }
            //                                        */
            //                                        dateList.Add(Convert.ToDateTime(ActualMilestone, ci));
            //                                    }
            //                                    if (ActualMilestone != "" && PlannedMilestone == "")
            //                                    {
            //                                        dr1["DeviationJustifcation"] = "";
            //                                        dr1["ProgressSheetStatus"] = Common.ProgressSheetStatus.Approved;
            //                                        dateList.Add(Convert.ToDateTime(ActualMilestone, ci));
            //                                    }


            //                                    int ProgressSheetID = strProgressSheetID == "" ? 0 : Convert.ToInt32(strProgressSheetID);
            //                                    dr1["ProgressSheetID"] = ProgressSheetID;
            //                                    dt.Rows.Add(dr1);

            //                                    if (i == lstMilestoneIDs.Count)
            //                                    {
            //                                        latestMilestoneID = Convert.ToInt32(lstMilestoneIDs[i - 1]);
            //                                    }
            //                                }
            //                            }
            //                        }//TaskCancelled and joining date validation
            //                        else
            //                        {
            //                            if (isTaskCancelledError)
            //                            {
            //                                string cancelerr = Common.MessageConstants.TaskCancelledError.Replace("#canceldate#", TaskCancelledDate);
            //                                resultMsg = resultMsg + cancelerr + "</br>";
            //                            }
            //                            //if (isJoiningDate)
            //                            //{
            //                            //    string joinerr = Common.MessageConstants.JoiningDateError.Replace("#joiningdate#", JoiningDate);
            //                            //    resultMsg = resultMsg + joinerr + "</br>";
            //                            //}
            //                        }
            //                    }
            //                    else if (ActualMilestone == "" && dr != null && PlannedMilestone != "")
            //                    {
            //                        DataRow dr1 = dt.NewRow();
            //                        dr1["MilestoneID"] = Convert.ToInt32(lstMilestoneIDs[i - 1]);
            //                        dr1["PlanedTargetDate"] = Convert.ToDateTime(PlannedMilestone, ci);
            //                        dr1["ActualTargetDate"] = ActualMilestone != "" ? Convert.ToDateTime(ActualMilestone, ci) : DateTime.MaxValue;
            //                        dr1["DeviationJustifcation"] = strDeviationJust;
            //                        int ProgressSheetID = Convert.ToInt32(strProgressSheetID);
            //                        dr1["ProgressSheetID"] = ProgressSheetID;
            //                        dr1["ProgressSheetStatus"] = Common.ProgressSheetStatus.Submit;
            //                        dt.Rows.Add(dr1);
            //                    }
            //                }

            //            }//

            //            //////////END/////////For progress level date validation
            //        }



            //        bool MaxTimeSheetStaus = true;
            //        ///////////////////For actual End date validation
            //        string ActualEndDate = dictTask["ActualEndDate"];
            //        string PlannedEndDate = dictTask["PlannedEndDate"];
            //        if (PlannedEndDate == "01/01/0001")
            //        {
            //            PlannedEndDate = "01/01/1900";
            //        }
            //        string strMaxTimesheetDate = dtMainGrid.Count > 0 ? Convert.ToString(dtMainGrid.SingleOrDefault().MaxTimesheetDate) : "";
            //        if (ActualEndDate != null)
            //        {
            //            if (isCancelled)
            //            {
            //                if (ActualEndDate != "" && TCancelledDate < Convert.ToDateTime(ActualEndDate, ci))
            //                {
            //                    isTaskCancelledError = true;
            //                }
            //            }
            //            foreach (var miles in lstMilestoneIDs)
            //            {
            //                string actualmiledt = Convert.ToString(dictTaskPrg["Actual" + miles]);
            //                if (ActualEndDate != "" && actualmiledt != "" && Convert.ToDateTime(ActualEndDate, ci) < Convert.ToDateTime(actualmiledt, ci))
            //                {
            //                    BLProjectMilestoneRepository blprojmile = new BLProjectMilestoneRepository();
            //                    ProjectMilestone lstMiles = null;
            //                    lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(miles));
            //                    resultMsg = resultMsg + "Actual end date can not be less than " + lstMiles.ProjectMilestone1 + "</br>";
            //                    lessenddatestatus = false;
            //                }
            //            }
            //          //  if (JoiningDt > Convert.ToDateTime(txtStartID, ci))
            //           // {
            //             //   isJoiningDate = true;
            //            //}

            //            //if (!isTaskCancelledError && !isJoiningDate)
            //            if (!isTaskCancelledError) 
            //            {
            //                //isJoiningDate = false;
            //                if (ActualEndDate != "" && strActualEndApproveStatus.Trim() != "Approved")
            //                {
            //                    if (strMaxTimesheetDate != null && strMaxTimesheetDate != "")
            //                    {
            //                        MaxTimesheetDate = strMaxTimesheetDate;
            //                        if (Convert.ToDateTime(ActualEndDate, ci) < Convert.ToDateTime(strMaxTimesheetDate, ci))
            //                        {
            //                            MaxTimeSheetStaus = false;
            //                        }
            //                    }

            //                    if (MaxTimeSheetStaus)
            //                    {
            //                        DataRow dr = dt.NewRow();
            //                        dr["MilestoneID"] = -2;
            //                        dr["PlanedTargetDate"] = PlannedEndDate != "" ? Convert.ToDateTime(PlannedEndDate, ci) : Convert.ToDateTime(DateTime.MaxValue, ci);
            //                        dr["ActualTargetDate"] = Convert.ToDateTime(ActualEndDate, ci);
            //                        int ActualEndJustID = strActualEndJustID == "" ? 0 : Convert.ToInt32(strActualEndJustID);
            //                        dr["ProgressSheetID"] = ActualEndJustID;




            //                        //if (Convert.ToDateTime(PlannedEndDate, ci) >= Convert.ToDateTime(ActualEndDate, ci))
            //                        //{
            //                        //    dr["DeviationJustifcation"] = "";
            //                        //    dr["ProgressSheetStatus"] = Common.ProgressSheetStatus.Approved;
            //                        //}
            //                        //else
            //                        //{
            //                        //    dr["ProgressSheetStatus"] = Common.ProgressSheetStatus.Submit;

            //                        //    if (str.Contains("end"))
            //                        //    {
            //                        //        var keyValuePairs1 = str.Split('$').Where(x => x.Contains("end")).First().Split('#');
            //                        //        if (keyValuePairs1.Length > 1)
            //                        //        {
            //                        //            var keyValuePairs = str.Split('$').Where(x => x.Contains("end")).First().Split('#')[1];
            //                        //            dr["DeviationJustifcation"] = Convert.ToString(keyValuePairs);
            //                        //        }
            //                        //        else
            //                        //        {
            //                        //            Devstatus = false;
            //                        //            resultMsg = resultMsg + "Enter deviation justification for actual end.</br>";
            //                        //        }
            //                        //    }
            //                        //    else
            //                        //    {
            //                        //        if (strActualEndDeviation.Length > 0)
            //                        //        {
            //                        //            dr["DeviationJustifcation"] = strActualEndDeviation;
            //                        //        }
            //                        //        else
            //                        //        {
            //                        //            Devstatus = false;
            //                        //            resultMsg = resultMsg + "Enter deviation justification for actual end.</br>";
            //                        //        }
            //                        //    }
            //                        //}

            //                        if (Convert.ToDateTime(ActualEndDate, ci).Date > DateTime.Now.Date)
            //                        {
            //                            isFutureDate = true;
            //                        }

            //                        dateList.Add(Convert.ToDateTime(ActualEndDate, ci));
            //                        dt.Rows.Add(dr);
            //                    }
            //                }
            //                else if (PlannedEndDate != "")
            //                {
                               
            //                    DataRow dr = dt.NewRow();
            //                    dr["MilestoneID"] = -2;
            //                    dr["PlanedTargetDate"] = Convert.ToDateTime(PlannedEndDate, ci);
            //                    dr["ActualTargetDate"] = Convert.ToDateTime(DateTime.MaxValue, ci);
            //                    int ActualEndJustID = strActualEndJustID == "" ? 0 : Convert.ToInt32(strActualEndJustID);
            //                    dr["ProgressSheetID"] = ActualEndJustID;
            //                    dr["DeviationJustifcation"] = "";
            //                    dr["ProgressSheetStatus"] = Common.ProgressSheetStatus.Submit;
            //                    dt.Rows.Add(dr);
            //                }
            //            }
            //            else
            //            {
            //                if (isTaskCancelledError)
            //                {
            //                    string iscancell = Common.MessageConstants.TaskCancelledError.Replace("#canceldate#", TaskCancelledDate);
            //                    resultMsg = resultMsg + iscancell + "</br>";
            //                }
            //                //if (isJoiningDate)
            //                //{
            //                //    string isjoin = Common.MessageConstants.JoiningDateError.Replace("#joiningdate#", JoiningDate);
            //                //    resultMsg = resultMsg + isjoin + "</br>";
            //                //}
            //                //return;
            //            }
            //        }
            //        ///////////////END///For actual End date validation
            //        ////////////// Check for neccessary milestones to be updated/////////////
            //        bool neccessaryMiles = true;
            //        //if (ActualEndDate != null && ActualEndDate != "" && lstMilestoneIDs.Count > 0)
            //        //{
            //        //    for (int i = 1; i <= lstMilestoneIDs.Count; i++)
            //        //    {                            
            //        //        string ActualMilestonedate = dictTaskPrg.ContainsKey("Actual" + lstMilestoneIDs[i - 1].ToString()) ? dictTaskPrg["Actual" + lstMilestoneIDs[i - 1].ToString()] : "";
            //        //        if (ActualMilestonedate == "")
            //        //        {
            //        //            BLProjectMilestoneRepository blprojmile=new BLProjectMilestoneRepository();
            //        //            ProjectMilestone lstMiles = null;
            //        //            lstMiles = blprojmile.GetMilestoneByID(Convert.ToInt32(lstMilestoneIDs[i - 1]));
            //        //            neccessaryMiles = false;
            //        //            resultMsg = resultMsg + "Please enter actual" + Convert.ToString(lstMiles.ProjectMilestone1) + " date"; 
            //        //        }
            //        //    }

            //        //}
            //        ////////////// end Check for neccessary milestones to be updated/////////////
            //        for (int i = 0; i < dateList.Count - 1; i++)
            //        {
            //            if (dateList[i] > dateList[i + 1])
            //            {
            //                dateStatus = false;
            //            }
            //        }
            //        if (neccessaryMiles && dateStatus && Devstatus && MaxTimeSheetStaus && !isFutureDate && !isTaskTransferError && !isTaskCancelledError && GreaterDateStatus && maxProgressstatus && actualstartstatus && lessenddatestatus)
            //        {
            //            objProgressSheet = new DominModel.ProgressSheet();

            //            objProgressSheet.UserID = Convert.ToInt32(UserID);
            //            //BEProgressSheet.FromDate = Convert.ToDateTime(txtStartDate.Text, ci);
            //            //BEProgressSheet.ToDate = Convert.ToDateTime(txtEndDate.Text, ci);
            //            objProgressSheet.ProjectID = Convert.ToInt32(ProjectID);
            //            objProgressSheet.TaskID = Convert.ToInt32(ProjectTaskID);
            //            objProgressSheet.TaskType = Convert.ToInt32(TaskTypeID);
            //            objProgressSheet.ProgressSheetStatus = Common.ProgressSheetStatus.Submit.ToString();

            //            string xmlTargetDates = string.Empty;
            //            using (StringWriter sw = new StringWriter())
            //            {
            //                dt.WriteXml(sw);
            //                xmlTargetDates = sw.ToString();
            //            }
            //            ArrayList arr = new ArrayList();
            //            Decimal Progress = dictTask.ContainsKey("Progress") ? Convert.ToDecimal(dictTask["Progress"]) : 0;

            //            arr = BLProgressSheetRepository.saveProgressSheetNew(objProgressSheet, xmlTargetDates, latestMilestoneID, Progress);
            //            if (Convert.ToString(arr[2]) == "SUCCESS")
            //            {
            //                saveStatus = true;
            //                if (Convert.ToBoolean(arr[0]) == true || Convert.ToBoolean(arr[1]) == true)
            //                {
            //                    IList<usp_getTaskDependencyWithTaskOwner_Result> dtDep = BLProgressSheetRepository.getTaskDependency(objProgressSheet.TaskID.GetValueOrDefault());
            //                    if (dtDep.Count > 0)
            //                    {
            //                        //sendDependencyNotification(dtDep, TaskName, arr);
            //                    }
            //                }
            //                string Msg = "";
            //                if (Convert.ToString(arr[3]).Length > 0)
            //                {
            //                    Msg = Msg + "You are not authorized to enter details for selected date for " + Convert.ToString(arr[3]);
            //                    resultMsg = resultMsg + Msg + "</br>";
            //                }
            //                else
            //                {
            //                    if (saveStatus && resultMsg.Length <= 0)
            //                    {
            //                        ts.Complete();
            //                        result.Message = MessageConstants.OperationSuccess;
            //                        result.MessageType = "S";
            //                    }
            //                    else
            //                    {
            //                        ts.Dispose();
            //                        result.Message = resultMsg;
            //                        result.MessageType = "";
            //                    }
            //                }
            //            }
            //            else if (Convert.ToString(arr[2]) == "TRANSFERED/HANDOVER")
            //            {
            //                string hndover = "Task is HANDOVER/TRANSFERED for selected date for " + Convert.ToString(arr[3]);
            //                resultMsg = resultMsg + hndover + "</br>";
            //            }
            //            else if (Convert.ToString(arr[2]) == "TRANSFERED/HANDOVER_PERIOD")
            //            {
            //                string hndperiod = "You are not authorized to enter details for selected date for " + Convert.ToString(arr[3]);
            //                resultMsg = resultMsg + hndperiod + "</br>";
            //            }
            //            else
            //            {
            //                result.Message = MessageConstants.OperationFailure;
            //                result.MessageType = "E";
            //            }
            //        }
            //        else
            //        {
            //            if (!MaxTimeSheetStaus)
            //            {
            //                string maxtime = Common.MessageConstants.MaxTimeSheetDateStatus + MaxTimesheetDate;
            //                resultMsg = resultMsg + maxtime + "</br>";
            //            }
            //            else if (isFutureDate)
            //            {
            //                string futureerr = "You can not enter future date.";
            //                resultMsg = resultMsg + futureerr + "</br>";
            //            }
            //            else if (isTaskTransferError)
            //            {
            //                string tasktrans = "You are only authorize to enter task details between " + isTaskTransferDatePeriod;
            //                resultMsg = resultMsg + tasktrans + "</br>";
            //            }
            //            else if (isTaskCancelledError)
            //            {
            //                string cancelerr = "You can not enter date greater than " + TaskCancelledDate;
            //                resultMsg = resultMsg + cancelerr + "</br>";
            //            }
            //            else
            //            {
            //                string wrongdate = MessageConstants.wrongDateSequence;
            //                //resultMsg = resultMsg + wrongdate + "</br>";
            //            }

            //            //To avoid two time rearrange
            //            saveStatus = true;
            //            if (saveStatus && resultMsg.Length <= 0)
            //            {
            //                ts.Complete();
            //                result.Message = MessageConstants.OperationSuccess;
            //                result.MessageType = "S";
            //            }
            //            else
            //            {
            //                ts.Dispose();
            //                result.Message = resultMsg;
            //                result.MessageType = "";
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        result.Message = MessageConstants.OperationFailure + "</br>" + resultMsg;
            //        result.MessageType = "E";
            //    }

                return result;
            //}
        }

        //private void validateTaskEntry(int normId, bool isProjectLeader, string colValue, EstimationTaskColumnsMaster est, IEnumerable<NormDesDet> pEqVal, IEnumerable<NormDesDet> pEqValNorm,
        //    int UserID, int ProjectID, int ProjectTaskId, string DataMappingID, out OperationResult result)
        //{
        //    try
        //    {
        //        string message = "";
        //        result = new OperationResult();

        //        if (est.PermanentNameInDb == "Norm")
        //        {
        //            result.Message = "";
        //            result.MessageType = "S";
        //            return;
        //        }
        //        //No validation for norm dependent field if norm is not selected.
        //        if (normId == 0 && est.DependonNorms == "Y")
        //        {
        //            result.Message = "";
        //            result.MessageType = "S";
        //            return;
        //        }

        //        if (est.IsMandatory == "Y")
        //        {
        //            if (colValue == null || colValue.Length <= 0)
        //            {
        //                message += est.DisplayColName + " is required.<br />";
        //            }
        //        }

        //        if (est.DataType == "Number")
        //        {
        //            if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
        //            {
        //                decimal n;
        //                bool isNumeric = decimal.TryParse(colValue, out n);
        //                if (!isNumeric)
        //                {
        //                    message += est.DisplayColName + " must be a numeric value.<br />";
        //                }
        //            }
        //        }

        //        if (est.DataType == "DateTime")
        //        {
        //            string[] formats = { "dd/MM/yyyy" };
        //            DateTime dateValue;
        //            if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
        //            {
        //                if (!DateTime.TryParseExact(colValue, formats, new CultureInfo("en-Gb"), DateTimeStyles.None, out dateValue))
        //                {
        //                    message += est.DisplayColName + " must be a DateTime value.<br />";
        //                }
        //            }
        //        }

        //        if (Convert.ToString(est.DataType as object).ToLower().Contains("unique"))
        //        {
        //            NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
        //            if (!blObj.checkUniqueness(Convert.ToInt32(ProjectID), DataMappingID, colValue, Convert.ToInt32(ProjectTaskId)))
        //            {
        //                message += MessageConstants.Duplicate;
        //            }
        //        }

        //        if ((est.Equationvalidation != null && est.Equationvalidation.Length > 0) || (est.EquationID != null && est.EquationID.Length > 0))
        //        {
        //            string eqn = Convert.ToString(est.Equationvalidation as object).Length > 0 ? est.Equationvalidation : est.EquationID;
        //            string[] separators = { " ", "/", "*", "+", "-", "&", "|", ">", "<", "=" };
        //            string[] arr = eqn.Split(separators, StringSplitOptions.None);

        //            for (int i = 0; i < arr.Length; i++)
        //            {
        //                var vNormWord = pEqValNorm.Where(a => a.NameInDb == arr[i]);
        //                var vWord = pEqVal.Where(a => a.NameInDb == arr[i]);
        //                if (vNormWord.Count() > 0 || vWord.Count() > 0)
        //                {
        //                    string nameInDb = vWord.Count() > 0 ? vWord.SingleOrDefault().NameInDb : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().NameInDb : "");

        //                    arr[i] = vWord.Count() > 0 ? vWord.SingleOrDefault().ColValue : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().ColValue : "0");

        //                    if (est.ValidationMessage != null && Convert.ToString(est.ValidationMessage) != "")
        //                    {
        //                        est.ValidationMessage = est.ValidationMessage.Replace("#" + nameInDb + "#", Convert.ToString(arr[i] as object));
        //                        // est.ValidationMessage = Regex.Replace(est.ValidationMessage, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");

        //                    }
        //                    nameInDb = String.Format(@"\b{0}\b", nameInDb);
        //                    eqn = Regex.Replace(eqn, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");
        //                }
        //                else if (est.PermanentNameInDb == "TOTALHRS")
        //                {
        //                    eqn = eqn.Replace(arr[i], "0");
        //                }

        //            }

        //            if (Regex.Matches(eqn, @"[a-zA-Z]").Count <= 0)
        //            {
        //                string[] separatorValidation = { "&" };
        //                string[] arr1 = eqn.Split(separatorValidation, StringSplitOptions.None);
        //                if (arr1.Length > 1)
        //                {
        //                    for (int i = 0; i < arr1.Length; i++)
        //                    {
        //                        if (Convert.ToString(arr1[i].Trim()) != "")
        //                        {
        //                            if (!Convert.ToBoolean(new DataTable().Compute(Convert.ToString(arr1[i].Trim()), null)))
        //                            {
        //                                message += est.ValidationMessage + "<br />";
        //                            }
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    if (est.DBColPkID > 0)
        //                    {
        //                        result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
        //                        result.MessageType = "S";
        //                        return;
        //                    }
        //                    else if (est.PermanentNameInDb == "TOTALHRS")
        //                    {
        //                        result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
        //                        result.MessageType = "S";
        //                        return;
        //                    }
        //                    else if (!Convert.ToBoolean(new DataTable().Compute(eqn, null)))
        //                    {
        //                        message += est.ValidationMessage + "<br />";
        //                    }
        //                }

        //            }
        //        }

        //        if (!isProjectLeader && est.PermanentNameInDb == "Dept")
        //        {
        //            BLUserRepository bluser = new BLUserRepository();
        //            User user = bluser.GetuserByID(UserID);
        //            if (user.DepartmentID != Convert.ToInt32(colValue))
        //            {
        //                message += "You can not create task for other department.<br />";
        //            }
        //        }

        //        result.Message = message;
        //        result.MessageType = "S";
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static ArrayList saveProgressSheet(ProgressSheet objProgressSheet, string xmlTargetDates, int latestMilestoneID)
        {
            ArrayList arr = new ArrayList();
            //ObjectParameter isStartNotification = null;
            //ObjectParameter isEndNotification = null;
            //ObjectParameter sqlMsg = null;
            //ObjectParameter sqlMsg1 = null;
            //try
            //{
            //    isStartNotification = new ObjectParameter("isStartNotification", typeof(Boolean));
            //    isStartNotification.Value = false;
            //    isEndNotification = new ObjectParameter("isEndNotification", typeof(Boolean));
            //    isEndNotification.Value = false;
            //    sqlMsg = new ObjectParameter("SqlMsg", typeof(string));
            //    sqlMsg.Value = string.Empty;
            //    sqlMsg1 = new ObjectParameter("SqlMsg1", typeof(string));
            //    sqlMsg1.Value = string.Empty;
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        context.usp_saveProgressSheet(objProgressSheet.UserID, objProgressSheet.ProjectID, objProgressSheet.TaskID,
            //            objProgressSheet.TaskType, objProgressSheet.Billing, xmlTargetDates, objProgressSheet.ProgressSheetStatus, isStartNotification, isEndNotification,
            //            sqlMsg, sqlMsg1, Convert.ToInt32(Common.TaskStatusID.TaskStarted), Convert.ToInt32(Common.TaskStatusID.Closed), latestMilestoneID);
            //        arr.Add(isStartNotification.Value);
            //        arr.Add(isEndNotification.Value);
            //        arr.Add(sqlMsg.Value);
            //        arr.Add(sqlMsg1.Value);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            //finally
            //{
            //    if ((isStartNotification == null) == false)
            //        isStartNotification = null;
            //    if ((isEndNotification == null) == false)
            //        isEndNotification = null;
            //    if ((sqlMsg == null) == false)
            //        sqlMsg = null;
            //    if ((sqlMsg1 == null) == false)
            //        sqlMsg1 = null;
            //}
            return arr;
        }

        public static ArrayList saveProgressSheetNew(ProgressSheet objProgressSheet, string xmlTargetDates, int latestMilestoneID, Decimal Progress)
        {
            ArrayList arr = new ArrayList();
            //ObjectParameter isStartNotification = null;
            //ObjectParameter isEndNotification = null;
            //ObjectParameter sqlMsg = null;
            //ObjectParameter sqlMsg1 = null;
            //try
            //{
            //    isStartNotification = new ObjectParameter("isStartNotification", typeof(Boolean));
            //    isStartNotification.Value = false;
            //    isEndNotification = new ObjectParameter("isEndNotification", typeof(Boolean));
            //    isEndNotification.Value = false;
            //    sqlMsg = new ObjectParameter("SqlMsg", typeof(string));
            //    sqlMsg.Value = string.Empty;
            //    sqlMsg1 = new ObjectParameter("SqlMsg1", typeof(string));
            //    sqlMsg1.Value = string.Empty;
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        context.usp_saveProgressSheetNew(objProgressSheet.UserID, objProgressSheet.ProjectID, objProgressSheet.TaskID,
            //            objProgressSheet.TaskType, objProgressSheet.Billing, xmlTargetDates, objProgressSheet.ProgressSheetStatus, isStartNotification, isEndNotification,
            //            sqlMsg, sqlMsg1, Convert.ToInt32(Common.TaskStatusID.TaskStarted), Convert.ToInt32(Common.TaskStatusID.Closed), latestMilestoneID, Progress);
            //        arr.Add(isStartNotification.Value);
            //        arr.Add(isEndNotification.Value);
            //        arr.Add(sqlMsg.Value);
            //        arr.Add(sqlMsg1.Value);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            //finally
            //{
            //    if ((isStartNotification == null) == false)
            //        isStartNotification = null;
            //    if ((isEndNotification == null) == false)
            //        isEndNotification = null;
            //    if ((sqlMsg == null) == false)
            //        sqlMsg = null;
            //    if ((sqlMsg1 == null) == false)
            //        sqlMsg1 = null;
            //}
            return arr;
        }
        public static IList<usp_getTaskDependencyWithTaskOwner_Result> getTaskDependency(int TaskID)
        {
            IList<usp_getTaskDependencyWithTaskOwner_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskDependencyWithTaskOwner(TaskID).ToList<usp_getTaskDependencyWithTaskOwner_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static IList<usp_getApproveProgressSheetRecord_Result> getApproveProgressSheetRecord(int UserID)
        {
            IList<usp_getApproveProgressSheetRecord_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    ObjectParameter sqlOutPut = new ObjectParameter("SqlCountOutput", typeof(int));
                //    list = context.usp_getApproveProgressSheetRecord(UserID, sqlOutPut).ToList<usp_getApproveProgressSheetRecord_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static Boolean saveApproveProgressSheet(String xmlTarget)
        {
            Boolean res = false;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    var val = Context.usp_editApproveProgressSheet(xmlTarget, Common.ProgressSheetStatus.Approved.ToString()).FirstOrDefault();
                //    if (val.GetValueOrDefault() > 0)
                //        res = true;
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }

        public static Boolean TrialPeriod()
        {
            Boolean res = false;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    if (System.DateTime.Now > Common.MessageConstants.TrialDate)
                //    {
                //        res = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
    }
}
