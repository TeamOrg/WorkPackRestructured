using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNewActivityMasterRepository : IBLNewActivityMasterRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NewActivityMaster> _NewActivityMaster;

        public BLNewActivityMasterRepository(WorkpackDBContext context, IGenericDataRepository<NewActivityMaster> NewActivityMaster)
        {
            _context = context;
            _NewActivityMaster = NewActivityMaster;
        }
        
        public IList<NewActivityMaster> GetAllNewActivityMaster()
        {
            return _NewActivityMaster.GetAll();
        }
        public NewActivityMaster GetNewActivityMasterByID(int NewActivityMasterID)
        {
            return _NewActivityMaster.GetSingle(d => d.NewActivityMasterID == NewActivityMasterID);
        }
        public void AddNewActivityMaster(params NewActivityMaster[] NewActivityMaster)
        {
            try
            {
                _NewActivityMaster.Add(NewActivityMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNewActivities(params NewActivityMaster[] NewActivityMaster)
        {
            try
            {
                _NewActivityMaster.Update(NewActivityMaster);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNewActivities(params NewActivityMaster[] NewActivityMaster)
        {
            try
            {
                _NewActivityMaster.Remove(NewActivityMaster);
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

        public List<usp_getNewActivityMasterRecord_Result> GetNewActivityMasterByUserID(int UserID)
        {
            List<usp_getNewActivityMasterRecord_Result> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_getNewActivityMasterRecord(UserID).ToList<usp_getNewActivityMasterRecord_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
            return lst;
        }






        public OperationResult AddNewActivityTask(string ProjectID, string UserID, Dictionary<string, string[]> item, string SetID)
        {
            OperationResult result = new OperationResult();
            Dictionary<string, string> dictReturnData = new Dictionary<string, string>();
           // CultureInfo ci = new CultureInfo("en-Gb");

            try
            {
                //BLEstimationColSettingTemplateDetail blestcoltempDetail = new BLEstimationColSettingTemplateDetail();
                //BLEstimationTaskColumnsMasterRepository blestcolmaster = new BLEstimationTaskColumnsMasterRepository();
                //List<EstimationTaskColumnsMaster> lstColMaster = blestcolmaster.GetAllEstimationTaskColumnsMastersByProjectID(Convert.ToInt32(ProjectID), Convert.ToInt32(SetID)).ToList<EstimationTaskColumnsMaster>();
                //if (lstColMaster.Count() > 0)
                //{
                //    //add activity
                //    BLNewActivityMasterRepository bl = new BLNewActivityMasterRepository();
                // result=   bl.addEstimationTask(ProjectID, UserID, item, SetID);
                //}
                
            }
            catch (Exception ex)
            {
                //bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
                result.Message = ex.Message;
                result.MessageType = "E";
            }

            return result;

        }


        public OperationResult addEstimationTask(string ProjectID, string UserID, Dictionary<string, string[]> item, string MasterTaskType = "1")
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
            //        var normId = item.Where(i => i.Value[1] == "Norm").Select(a => a.Value[2]).SingleOrDefault();
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
            //        var pEqVal = item.Where(i => eqLst.Contains(i.Value[4])).Select(a => new NormDesDet { NameInDb = a.Value[4], ColValue = a.Value[2] });
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
            //        var p = item.Where(i => i.Value[0] == "TASK").Select(a => a.Value);
            //        foreach (var t in p)
            //        {
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t[3])).SingleOrDefault();
            //            if (est != null)
            //            {
            //                //validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), Convert.ToInt32(ProjectID), 0, t[1], out result, null);
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
            //            int TaskNo =  getNextTaskNumberByProjectID(Convert.ToInt32(ProjectID));

            //            task.ParentTaskID = dictTask.ContainsKey("ParentTaskID") && !string.IsNullOrEmpty(dictTask["ParentTaskID"]) ? Convert.ToInt32(dictTask["ParentTaskID"]) : 0;
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


            //            task.NormsID = dictTask.ContainsKey("Norm") && !string.IsNullOrEmpty(dictTask["Norm"]) ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //            task.Number_1 = dictTask.ContainsKey("Number_1") && !string.IsNullOrWhiteSpace(dictTask["Number_1"]) ? Convert.ToDouble(dictTask["Number_1"]) : 0;
            //            task.Number_2 = dictTask.ContainsKey("Number_2") && !string.IsNullOrWhiteSpace(dictTask["Number_2"]) ? Convert.ToDouble(dictTask["Number_2"]) : 0;
            //            task.Number_3 = dictTask.ContainsKey("Number_3") && !string.IsNullOrWhiteSpace(dictTask["Number_3"]) ? Convert.ToDouble(dictTask["Number_3"]) : 0;
            //            task.Number_4 = dictTask.ContainsKey("Number_4") && !string.IsNullOrWhiteSpace(dictTask["Number_4"]) ? Convert.ToDouble(dictTask["Number_4"]) : 0;
            //            task.Number_5 = dictTask.ContainsKey("Number_5") && !string.IsNullOrWhiteSpace(dictTask["Number_5"]) ? Convert.ToDouble(dictTask["Number_5"]) : 0;
            //            task.Number_6 = dictTask.ContainsKey("Number_6") && !string.IsNullOrWhiteSpace(dictTask["Number_6"]) ? Convert.ToDouble(dictTask["Number_6"]) : 0;
            //            task.Number_7 = dictTask.ContainsKey("Number_7") && !string.IsNullOrWhiteSpace(dictTask["Number_7"]) ? Convert.ToDouble(dictTask["Number_7"]) : 0;
            //            task.Number_8 = dictTask.ContainsKey("Number_8") && !string.IsNullOrWhiteSpace(dictTask["Number_8"]) ? Convert.ToDouble(dictTask["Number_8"]) : 0;
            //            task.Number_9 = dictTask.ContainsKey("Number_9") && !string.IsNullOrWhiteSpace(dictTask["Number_9"]) ? Convert.ToDouble(dictTask["Number_9"]) : 0;
            //            task.Number_10 = dictTask.ContainsKey("Number_10") && !string.IsNullOrWhiteSpace(dictTask["Number_10"]) ? Convert.ToDouble(dictTask["Number_10"]) : 0;
            //            if (dictTask.ContainsKey("DateTime_1"))
            //            {
            //                task.DateTime_1 = !string.IsNullOrEmpty(dictTask["DateTime_1"]) ? Convert.ToDateTime(dictTask["DateTime_1"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_2"))
            //            {
            //                task.DateTime_2 = !string.IsNullOrEmpty(dictTask["DateTime_2"]) ? Convert.ToDateTime(dictTask["DateTime_2"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_3"))
            //            {
            //                task.DateTime_3 = !string.IsNullOrEmpty(dictTask["DateTime_3"]) ? Convert.ToDateTime(dictTask["DateTime_3"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_4"))
            //            {
            //                task.DateTime_4 = !string.IsNullOrEmpty(dictTask["DateTime_4"]) ? Convert.ToDateTime(dictTask["DateTime_4"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_5"))
            //            {
            //                task.DateTime_5 = !string.IsNullOrEmpty(dictTask["DateTime_5"]) ? Convert.ToDateTime(dictTask["DateTime_5"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_6"))
            //            {
            //                task.DateTime_6 = !string.IsNullOrEmpty(dictTask["DateTime_6"]) ? Convert.ToDateTime(dictTask["DateTime_6"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_7"))
            //            {
            //                task.DateTime_7 = !string.IsNullOrEmpty(dictTask["DateTime_7"]) ? Convert.ToDateTime(dictTask["DateTime_7"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_8"))
            //            {
            //                task.DateTime_8 = !string.IsNullOrEmpty(dictTask["DateTime_8"]) ? Convert.ToDateTime(dictTask["DateTime_8"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_9"))
            //            {
            //                task.DateTime_9 = !string.IsNullOrEmpty(dictTask["DateTime_9"]) ? Convert.ToDateTime(dictTask["DateTime_9"], ci) : (DateTime?)null;
            //            }
            //            if (dictTask.ContainsKey("DateTime_10"))
            //            {
            //                task.DateTime_10 = !string.IsNullOrEmpty(dictTask["DateTime_10"]) ? Convert.ToDateTime(dictTask["DateTime_10"], ci) : (DateTime?)null;
            //            }
            //            task.String_1 = dictTask.ContainsKey("String_1") && !string.IsNullOrEmpty(dictTask["String_1"]) ? (dictTask["String_1"]) : null;
            //            task.String_2 = dictTask.ContainsKey("String_2") && !string.IsNullOrEmpty(dictTask["String_2"]) ? (dictTask["String_2"]) : null;
            //            task.String_3 = dictTask.ContainsKey("String_3") && !string.IsNullOrEmpty(dictTask["String_3"]) ? (dictTask["String_3"]) : null;
            //            task.String_4 = dictTask.ContainsKey("String_4") && !string.IsNullOrEmpty(dictTask["String_4"]) ? (dictTask["String_4"]) : null;
            //            task.String_5 = dictTask.ContainsKey("String_5") && !string.IsNullOrEmpty(dictTask["String_5"]) ? (dictTask["String_5"]) : null;
            //            task.String_6 = dictTask.ContainsKey("String_6") && !string.IsNullOrEmpty(dictTask["String_6"]) ? (dictTask["String_6"]) : null;
            //            task.String_7 = dictTask.ContainsKey("String_7") && !string.IsNullOrEmpty(dictTask["String_7"]) ? (dictTask["String_7"]) : null;
            //            task.String_8 = dictTask.ContainsKey("String_8") && !string.IsNullOrEmpty(dictTask["String_8"]) ? (dictTask["String_8"]) : null;
            //            task.String_9 = dictTask.ContainsKey("String_9") && !string.IsNullOrEmpty(dictTask["String_9"]) ? (dictTask["String_9"]) : null;
            //            task.String_10 = dictTask.ContainsKey("String_10") && !string.IsNullOrEmpty(dictTask["String_10"]) ? (dictTask["String_10"]) : null;
            //            task.ProjectID = Convert.ToInt32(ProjectID);

            //            BLDepartmentRepository blDept = new BLDepartmentRepository();

            //            task.DepatmentID = dictTask.ContainsKey("Dept") && Convert.ToInt32(dictTask["Dept"]) > 0 ? Convert.ToInt32(dictTask["Dept"]) : blDept.GetDepartmentByName("Not Selected");

            //            task.TaskName = Convert.ToString(dictTask["TaskName"]).Trim();
            //            task.DeliverableNo = dictTask.ContainsKey("DeliverableNo") ? Convert.ToString(dictTask["DeliverableNo"]).Trim() : "";

            //            if (dictTask.ContainsKey("DeliverableNo"))
            //            {
            //                BLTaskListRepository bltask = new BLTaskListRepository();
            //                BLUserRepository blUsr = new BLUserRepository();
            //                User user = blUsr.GetuserByID(Convert.ToInt32(UserID));

            //                iCompanyID = Convert.ToInt32(user.CompanyId);
            //                List<ProjectTaskList> lst = bltask.GetAllTaskListWithCompanyID(Convert.ToInt32(user.CompanyId)).Where(c => !string.IsNullOrEmpty(c.DeliverableNo)).ToList<ProjectTaskList>();
            //                if (lst.Count > 0)
            //                {
            //                    bool delno = lst.AsEnumerable().Any(c => task.DeliverableNo.ToUpper() == c.DeliverableNo.ToUpper());
            //                    if (delno)
            //                    {
            //                        //result.Message = "Deliverable number already exists.";
            //                        //result.MessageType = "E";
            //                        //return result;
            //                    }
            //                }
            //            }

            //            if (dictTask.ContainsKey("Owner"))
            //            {
            //                task.TaskOwner = string.IsNullOrEmpty(dictTask["Owner"]) ? 0 : Convert.ToInt32(dictTask["Owner"]);
            //                bSendNotificationToOwner = Convert.ToString(task.TaskOwner) == "0" ? false : true;
            //            }


            //            task.TaskTypeID = dictTask.ContainsKey("Type") ? Convert.ToInt32(dictTask["Type"]) : 0;
            //            if (!dictTask.ContainsKey("Duration"))
            //            {
            //                OperationResult r1 = new OperationResult();
            //                r1 = blTask.SetStartEndDateUsingDate(Convert.ToString(dictTask["StartDate"]), Convert.ToString(dictTask["EndDate"]), 0, Convert.ToInt32(ProjectID));
            //                Dictionary<string, string> d1 = new Dictionary<string, string>();
            //                d1 = r1.lstDict[0];
            //                dictTask.Add("Duration", d1["Duration"]);


            //                // dictTask.Add("Duration", "1");
            //            }

            //            task.Duration = dictTask.ContainsKey("Duration") && !string.IsNullOrEmpty(dictTask["Duration"]) ? Convert.ToInt32(dictTask["Duration"]) : 1;




            //            task.AllottedHours = dictTask.ContainsKey("TOTALHRS") && !string.IsNullOrEmpty(dictTask["TOTALHRS"]) ? Convert.ToDecimal(dictTask["TOTALHRS"]) : 1;
            //            if (task.AllottedHours == 0)
            //            {
            //                task.AllottedHours = 1;
            //            }
            //            task.TOTALHRS = dictTask.ContainsKey("TOTALHRS") && !string.IsNullOrEmpty(dictTask["TOTALHRS"]) ? Convert.ToDecimal(dictTask["TOTALHRS"]) : 1;
            //            if (task.TOTALHRS == 0)
            //            {
            //                task.TOTALHRS = 1;
            //            }
            //            //task.TaskWeight = dictTask.ContainsKey("TaskWeight") ? Convert.ToDecimal(dictTask["TaskWeight"]) : 0;
            //            task.TaskCost = dictTask.ContainsKey("TaskCost") ? Convert.ToDecimal(dictTask["TaskCost"]) : 0;

            //            string defaultWbsId = "0";
            //            if (!dictTask.ContainsKey("WBSCode") || dictTask["WBSCode"] == null)
            //            {
            //                BLProjectWBSRepository blWbs = new BLProjectWBSRepository();
            //                ProjectWB wb = blWbs.getDefaultWbsByProjectID(pr.ProjectID, pr.ProjectCode);
            //                defaultWbsId = Convert.ToString(wb.WBSID);
            //            }

            //            task.WBSID = dictTask.ContainsKey("WBSCode") && !string.IsNullOrEmpty(dictTask["WBSCode"]) ? Convert.ToString(dictTask["WBSCode"]) : defaultWbsId;


            //            task.Priority = dictTask.ContainsKey("Priority") && !string.IsNullOrEmpty(dictTask["Priority"]) ? Convert.ToInt32(dictTask["Priority"]) : Convert.ToInt32(Common.PriorityID.Medium);
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
            //            task.StartDate = (dictTask.ContainsKey("StartDate") && Convert.ToString(dictTask["StartDate"]) != "" &&dictTask["StartDate"] != null) ? Convert.ToDateTime(dictTask["StartDate"], ci) : Convert.ToDateTime(pr.ProjectStartDate);
            //            if (dictTask.ContainsKey("EndDate") && dictTask["EndDate"] != "" && dictTask["EndDate"] != null)
            //            {
            //                task.EndDate = Convert.ToDateTime(dictTask["EndDate"], ci);
            //                task.EndDateOrg = Convert.ToDateTime(dictTask["EndDate"], ci);
            //            }
            //            //task.EndDate = dictTask.ContainsKey("EndDate") && dictTask["EndDate"] != "" ? Convert.ToDateTime(dictTask["EndDate"], ci) : Convert.ToDateTime(pr.ProjectEndDate);
            //            task.StartDateOrg = (dictTask.ContainsKey("StartDate") && Convert.ToString(dictTask["StartDate"]) != "" && dictTask["StartDate"] != null) ? Convert.ToDateTime(dictTask["StartDate"], ci) : Convert.ToDateTime(pr.ProjectStartDate);
            //            //task.EndDateOrg = dictTask.ContainsKey("EndDate") ? Convert.ToDateTime(dictTask["EndDate"], ci) : Convert.ToDateTime(pr.ProjectEndDate);


            //            task.Remarks = dictTask.ContainsKey("Remarks") ? Convert.ToString(dictTask["Remarks"]) : "";
            //            task.CreatedBy = Convert.ToInt32(UserID);
            //            task.CreatedOn = DateTime.Now;
            //            task.IsScheduled = "N";

            //            task.Cost = dictTask.ContainsKey("Cost") && dictTask["Cost"] != null ? Convert.ToDecimal(dictTask["Cost"]) : 0;
            //            task.TotalCost = dictTask.ContainsKey("TotalCost") &&!string.IsNullOrEmpty(dictTask["TotalCost"]) ? Convert.ToDecimal(dictTask["TotalCost"]) : 0;
            //            task.Quantity = dictTask.ContainsKey("Quantity") && !string.IsNullOrEmpty(dictTask["Quantity"]) ? Convert.ToDecimal(dictTask["Quantity"]) : 0;
            //            task.CurrencyID = dictTask.ContainsKey("Currency") && !string.IsNullOrEmpty(dictTask["Currency"]) ? Convert.ToInt32(dictTask["Currency"]) : 0; ;
            //            task.MasterTaskType = Convert.ToInt32(MasterTaskType);
            //            task.IsDeliverable = true;// dictTask.ContainsKey("vIsDeliverable") && dictTask["vIsDeliverable"] != "" ? Convert.ToBoolean(dictTask["vIsDeliverable"]) : false;
            //            task.TaskWeight = 100;
            //            task.EntityState = DominModel.EntityState.Added;
            //        }



            //        ////// type == "PROGRESS"
            //        List<TaskMilestoneTargetDate> lstAddTaskMile = new List<TaskMilestoneTargetDate>();
            //        var q = item.Where(i => i.Value[0] == "PROGRESS");
            //        List<object> lstMilestoneReq = null;
            //        NewBLEstimationTaskListRepository blObjEst = new NewBLEstimationTaskListRepository();
            //        if (q.Count() > 0)
            //        {

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
            //            Nullable<DateTime> dt = null;
            //            EstimationTaskColumnsMaster est = lstColMaster.Where(a => a.EstimationTaskColumnID == Convert.ToInt32(t.Value[3])).SingleOrDefault();
            //            validateTaskEntry(Convert.ToInt32(normId), isProjectLeader, t.Value[2], est, pEqVal, pEqValNorm, Convert.ToInt32(UserID), 0, Convert.ToInt32(t.Key), "", out result, lstMilestoneReq);
            //            resultMsg += result.Message;
            //            //////////////
            //            if (result.Message.Length <= 0)
            //            {

            //                if (blObjEst.IsValidMilestone(Convert.ToInt32(ProjectID), Convert.ToInt32(task.TaskTypeID), Convert.ToInt32(t.Key)))
            //                {

            //                    TaskMilestoneTargetDate tmt = new TaskMilestoneTargetDate();
            //                    tmt.MileStoneID = Convert.ToInt32(t.Key);
            //                    tmt.TaskMilestoneTargetDates = Convert.ToString(t.Value[2] as object) != "" ? Convert.ToDateTime(t.Value[2], ci) : dt;
            //                    tmt.TaskTypeID = Convert.ToInt32(dictTask["Type"]);
            //                    tmt.EntityState = DominModel.EntityState.Added;
            //                    lstAddTaskMile.Add(tmt);
            //                }
            //            }
            //        }



            //        ////// type == "DESN"
            //        bool DesnHrsRequired = false;
            //        List<TaskDesignation> lstAddTaskDesn = new List<TaskDesignation>();
            //        var r = item.Where(i => i.Value[0] == "DESN");
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
            //                desgn.NormID = dictTask.ContainsKey("Norm") && !string.IsNullOrEmpty(dictTask["Norm"]) ? Convert.ToInt32(dictTask["Norm"]) : 0;
            //                desgn.EntityState = DominModel.EntityState.Added;
            //                lstAddTaskDesn.Add(desgn);
            //                dictReturnData[t.Key] = t.Value[2];
            //                DesnHrsRequired = true;
            //            }
            //        }
            //        ////// type == "DETAIL"
            //        List<TaskDetail> lstAddTaskDet = new List<TaskDetail>();
            //        var s = item.Where(i => i.Value[0] == "DETAIL");
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
            //           // ActivityTracker("Task added to - " + ProjectName, "Task List", UserID, "Task Added");


            //            Message objMessage = new Message();
            //            BLMessageRepository BLobjMessage = new BLMessageRepository();
            //            if (bSendNotificationToOwner == true)
            //            {

            //                //Activity Tracker log
            //                //ActivityTracker("Task assigned to - " + Convert.ToString(strUserName) + " for " + ProjectName, "Task List", UserID, "Task Assigned");
            //                objMessage.MessageID = 0;
            //                objMessage.FromUserID = Convert.ToString(UserID);
            //                objMessage.ToUserID = Convert.ToString(DeliverableOwner);
            //                objMessage.Message1 = Common.MessageConstants.SendNotificationToDeliverableOwner.Replace("#AssigneeName#", strUserName).Replace("#ProjectName#", Convert.ToString(ProjectName)).Replace("#DeliverableName#", Convert.ToString(taskname));
            //                objMessage.RedirectURL = "UploadDeliverables.aspx";
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

            //                  //  blmt.SendNotification(Convert.ToInt32(UserID), objMessage.Message1, Convert.ToInt32(DeliverableOwner));
            //                }

            //            }
            //            //

            //            BLProjectMilestoneRepository pm = new BLProjectMilestoneRepository();
            //            List<ProjectMilestone> lstMilestone = pm.GetMilestoneByProjectID(project.ProjectID);
            //            BLDepartmentRepository blDept = new BLDepartmentRepository();
            //            Department dept = blDept.GetDepartmentByID(task.DepatmentID);

            //            string bUrl = BasePage.networkdirectorypath + "\\" + project.ProjectCode + "\\" + dept.DepartmentName + "\\" + task.DeliverableNo;
            //            foreach (ProjectMilestone vpm in lstMilestone)
            //            {
            //                string fileUploadDir = bUrl + "\\" + vpm.ProjectMilestone1;
            //                if (!Directory.Exists(fileUploadDir))
            //                {
            //                    Directory.CreateDirectory(fileUploadDir);
            //                    ////addCustomPropertiesToFile(bUrl, fileUploadDir, task.ProjectTaskID, vpm.ProjectMilestoneID);
            //                }
            //            }
            //            ts.Complete();
            //            dictReturnData["id"] = Convert.ToString(TaskID);
            //            dictReturnData["TaskNo"] = Convert.ToString(task.TaskNo);
            //            dictReturnData["TaskStatus"] = Convert.ToString(Convert.ToInt32(Common.TaskStatusID.Draft));
            //            dictReturnData["TaskStatusName"] = Convert.ToString(Common.TaskStatusID.Draft);
            //            dictReturnData["SubTaskNo"] = Convert.ToString(task.SubTaskNo);
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
            //        bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //        ts.Dispose();
            //        result.Message = ex.Message;
            //        result.MessageType = "E";
            //    }

            //    return result;
            //}
            return result;
        }

        private int getNextTaskNumberByProjectID(int ProjectID)
        {
            int TaskNumber = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var res = context.ProjectTaskLists.Where(a =>a.ProjectID == ProjectID).Max(a => a.TaskNo);
            //    TaskNumber = Convert.ToInt32(res) + 1;
            //}
            return TaskNumber;
        }





        public void validateTaskEntry(int normId, bool isProjectLeader, string colValue, EstimationTaskColumnsMaster est, IEnumerable<NormDesDet> pEqVal, IEnumerable<NormDesDet> pEqValNorm,
          int UserID, int ProjectID, int ProjectTaskId, string DataMappingID, out OperationResult result, List<object> lstMilestoneReq)
        {
            try
            {
                //string message = "";
                result = new OperationResult();

                //if (est.PermanentNameInDb == "Norm" || est.PermanentNameInDb == "Dept")
                //{
                //    result.Message = "";
                //    result.MessageType = "S";
                //    return;
                //}
                ////No validation for norm dependent field if norm is not selected.
                //if (normId == 0 && est.DependonNorms == "Y")
                //{
                //    result.Message = "";
                //    result.MessageType = "S";
                //    return;
                //}

                //if (est.IsMandatory == "Y")
                //{
                //    if (est.PermanentNameInDb == "TaskProgressLevels")
                //    {
                //        if (lstMilestoneReq != null && lstMilestoneReq.Count() > 0)
                //        {
                //            foreach (var m in lstMilestoneReq)
                //            {

                //            }
                //        }
                //    }
                //    else if (colValue == null || colValue.Length <= 0)
                //    {
                //        message += est.DisplayColName + " is required.";
                //    }
                //}

                //if (est.DataType == "Number")
                //{
                //    if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
                //    {
                //        decimal n;
                //        bool isNumeric = decimal.TryParse(colValue, out n);
                //        if (!isNumeric)
                //        {
                //            message += est.DisplayColName + " must be a numeric value.";
                //        }
                //    }
                //}

                //if (est.DataType == "DateTime")
                //{
                //    string[] formats = { "dd/MM/yyyy" };
                //    DateTime dateValue;
                //    if (est.IsMandatory == "Y" || Convert.ToString(colValue as object) != "")
                //    {
                //        if (est.PermanentNameInDb == "TaskProgressLevels")
                //        {
                //        }
                //        else if (!DateTime.TryParseExact(colValue, formats, new CultureInfo("en-Gb"), DateTimeStyles.None, out dateValue))
                //        {
                //            message += est.DisplayColName + " must be a DateTime value of dd/MM/yyyy format.";
                //        }


                //    }
                //}

                //if (Convert.ToString(est.DataType as object).ToLower().Contains("unique"))
                //{
                //    NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();
                //    if (!blObj.checkUniqueness(Convert.ToInt32(ProjectID), est.ProjectTaskListColumn, colValue, Convert.ToInt32(ProjectTaskId)))
                //    {
                //        message += MessageConstants.Duplicate;
                //    }
                //}

                ////// 1==2 so that it will not get executed.As we have changed equation to javascript function.

                //if (1 == 2 && ((est.Equationvalidation != null && est.Equationvalidation.Length > 0) || (est.EquationID != null && est.EquationID.Length > 0)))
                //{
                //    string eqn = Convert.ToString(est.Equationvalidation as object).Length > 0 ? est.Equationvalidation : est.EquationID;
                //    string[] separators = { " ", "/", "*", "+", "-", "&", "|", ">", "<", "=" };
                //    string[] arr = eqn.Split(separators, StringSplitOptions.None);

                //    for (int i = 0; i < arr.Length; i++)
                //    {
                //        var vNormWord = pEqValNorm.Where(a => a.NameInDb == arr[i]);
                //        var vWord = pEqVal.Where(a => a.NameInDb == arr[i]);
                //        if (vNormWord.Count() > 0 || vWord.Count() > 0)
                //        {
                //            string nameInDb = vWord.Count() > 0 ? vWord.SingleOrDefault().NameInDb : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().NameInDb : "");

                //            arr[i] = vWord.Count() > 0 ? vWord.SingleOrDefault().ColValue : (vNormWord.Count() > 0 ? vNormWord.SingleOrDefault().ColValue : "0");

                //            if (est.ValidationMessage != null && Convert.ToString(est.ValidationMessage) != "")
                //            {
                //                est.ValidationMessage = est.ValidationMessage.Replace("#" + nameInDb + "#", Convert.ToString(arr[i] as object));
                //                // est.ValidationMessage = Regex.Replace(est.ValidationMessage, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");

                //            }
                //            nameInDb = String.Format(@"\b{0}\b", nameInDb);
                //            eqn = Regex.Replace(eqn, nameInDb, Convert.ToString(arr[i] as object) != "" ? arr[i] : "0");
                //        }
                //        else if (est.PermanentNameInDb == "TOTALHRS")
                //        {
                //            eqn = eqn.Replace(arr[i], "0");
                //        }

                //    }

                //    if (Regex.Matches(eqn, @"[a-zA-Z]").Count <= 0)
                //    {
                //        string[] separatorValidation = { "&" };
                //        string[] arr1 = eqn.Split(separatorValidation, StringSplitOptions.None);
                //        if (arr1.Length > 1)
                //        {
                //            for (int i = 0; i < arr1.Length; i++)
                //            {
                //                if (Convert.ToString(arr1[i].Trim()) != "")
                //                {
                //                    if (!Convert.ToBoolean(new DataTable().Compute(Convert.ToString(arr1[i].Trim()), null)))
                //                    {
                //                        message += est.ValidationMessage + "";
                //                    }
                //                }
                //            }
                //        }
                //        else
                //        {
                //            if (est.DBColPkID > 0)
                //            {
                //                result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
                //                result.MessageType = "S";
                //                return;
                //            }
                //            else if (est.PermanentNameInDb == "TOTALHRS")
                //            {
                //                result.Message = Convert.ToString(new DataTable().Compute(eqn, null));
                //                result.MessageType = "S";
                //                return;
                //            }
                //            else if (!Convert.ToBoolean(new DataTable().Compute(eqn, null)))
                //            {
                //                message += est.ValidationMessage + "";
                //            }
                //        }

                //    }
                //}

                //if (!isProjectLeader && est.PermanentNameInDb == "Dept")
                //{
                //    //BLUserRepository bluser = new BLUserRepository();
                //    //User user = bluser.GetuserByID(UserID);
                //    //if (user.DepartmentID != Convert.ToInt32(colValue))
                //    //{
                //    //    message += "You can not create task for other department.";
                //    //}
                //}

                //result.Message = message;
                //result.MessageType = "S";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }




}
