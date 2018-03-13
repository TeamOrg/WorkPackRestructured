using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectMilestoneRepository : IBLProjectMilestoneRepository
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectMilestone> _projectMilestoneRepository;

        public BLProjectMilestoneRepository(WorkpackDBContext context, IGenericDataRepository<ProjectMilestone> projectMilestoneRepository)
        {
            _context = context;
            _projectMilestoneRepository = projectMilestoneRepository;
        }




        public List<ProjectMilestone> GetMilestoneByProjectID(int projectID)
        {
            return _projectMilestoneRepository.GetList(a => a.ProjectID == projectID).ToList<ProjectMilestone>();
        }

        public List<ProjectMilestone> GetMilestoneByProjectID() {
          //  int compid = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            List<ProjectMilestone> lst = new List<ProjectMilestone>();
            //using (var context = new Cubicle_EntityEntities()) {

            //    lst = (from c in context.ProjectMilestones join a in context.Projects on c.ProjectID equals a.ProjectID where a.CompanyId == compid select c).ToList<ProjectMilestone>();
            //}

            return lst;
        }


        public ProjectMilestone GetMilestoneByID(int MileStoneId)
        { 
           

            return _projectMilestoneRepository.GetSingle(c => c.ProjectMilestoneID == MileStoneId);
        }


        public List<ProjectMilestone> GetAllMilestoneByProjectIDTaskTypeID(int projectID, int tasktypeid)
        {
            List<ProjectMilestone> lst = new List<ProjectMilestone>();           
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = (from td in context.ProjectMilestones
                //           join tdd in context.TaskTypeWiseProgresses
                //           on td.ProjectMilestoneID equals tdd.ProjectMilestoneID
                //           where td.ProjectID == projectID && tdd.TaskTypeID == tasktypeid 
                //           select td).ToList<ProjectMilestone>();
                //}
            
            return _projectMilestoneRepository.GetList(a => a.ProjectID == projectID).ToList<ProjectMilestone>();
        }


        public List<ProjectMilestone> GetAllMilestoneByTaskTypeID(int projectID, int tasktypeid)
        {
            List<ProjectMilestone> lst = new List<ProjectMilestone>();

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from td in context.ProjectMilestones
            //           join tdd in context.TaskTypeWiseProgresses
            //           on td.ProjectMilestoneID equals tdd.ProjectMilestoneID
            //           where td.ProjectID == projectID && tdd.TaskTypeID == tasktypeid && ((tdd.PercentWeitage != null && tdd.PercentWeitage > 0) || (tdd.TaskTypeChecked != null && tdd.TaskTypeChecked != false)) 
            //           select td).ToList<ProjectMilestone>();
            //}

            return lst;
        }




        public void AddMilestone(params ProjectMilestone[] projectMilestone)
        {
            try
            {
                _projectMilestoneRepository.Add(projectMilestone);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateMilestone(params ProjectMilestone[] projectMilestone)
        {
            try
            {
                _projectMilestoneRepository.Update(projectMilestone);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public string GetLatestedBookMilestonePer(int projectID, int TaskTypeID, int TaskID)
        {
            string bookPer = "";
            //TaskTypeWiseProgress Plst = null;
            //ProjectMilestone lst = null;
            //bookPer = Convert.ToString(0) + "#" + "Start";

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    Plst = (from pm in context.ProjectMilestones
            //            join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            //            join tm in context.TaskMilestoneTargetDates on pm.ProjectMilestoneID equals tm.MileStoneID
            //            where pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID && tm.TaskID == TaskID && mtty.PercentWeitage != null && tm.ActualTaskMilestoneTargetDates != null
            //            orderby mtty.PercentWeitage descending
            //            select mtty).FirstOrDefault();
            //}
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from pm in context.ProjectMilestones
            //           join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            //           join tm in context.TaskMilestoneTargetDates on pm.ProjectMilestoneID equals tm.MileStoneID
            //           where pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID && tm.TaskID == TaskID && mtty.PercentWeitage != null && tm.ActualTaskMilestoneTargetDates != null
            //           orderby mtty.PercentWeitage descending
            //           select pm).FirstOrDefault();
            //}

            //if (Plst != null)
            //{
            //    bookPer = Convert.ToString(Plst.PercentWeitage) + "#" + lst.ProjectMilestone1;
            //}

            return bookPer;
        }


        public int RemoveMilestone(params ProjectMilestone[] projectMilestone)
        {
            int result = 0;
            try
            {
                result = _projectMilestoneRepository.getRemove(projectMilestone);
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
            return result;
        }

        public class CopytabRevfile
        {
            public int TaskID { get; set; }
            public int MileStoneID { get; set; }
            public int? ProjectID { get; set; }
            public int RevisionID { get; set; }
            public int? TaskTypeID { get; set; }


        }

        public string GetRevisionNoByID(int rvsnID)
        {
            string lst = "";
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from RF in context.RevisionFiles
            //           where RF.RevisionID == rvsnID
            //           select RF.RevisionNo).FirstOrDefault();
            //}
            return lst;
        }
        public Int32 GetActivityTypeID(string strActivityType)
        {
            Int32 ActivityTypeID = 0;
            //try
            //{
            //    List<DominModel.ActivityType> list = null;

            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        ActivityTypeID = context.ActivityTypes.Where(a => a.Activity == strActivityType).ToList<DominModel.ActivityType>().FirstOrDefault().ActivityTypeID;
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
            return ActivityTypeID;
        }
        public List<CopytabRevfile> GetRevIdTaskIDofPreviousTab(int TaskID, int ProjectMilestoneID, int RevisionId)
        {
            List<CopytabRevfile> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{


                //    list = (from Rf in context.RevisionFiles
                //            join PM in context.ProjectMilestones
                //            on Rf.StatusID equals PM.ProjectMilestoneID
                //            join PT in context.ProjectTaskLists
                //            on PM.ProjectID equals PT.ProjectID
                //            where (int)Rf.DeliverableID == TaskID && Rf.RevisionID < RevisionId

                //            select new CopytabRevfile
                //            {
                //                TaskID = (int)Rf.DeliverableID,
                //                MileStoneID = (int)Rf.StatusID,
                //                ProjectID = PM.ProjectID,
                //                RevisionID = Rf.RevisionID,
                //                TaskTypeID = PT.TaskTypeID
                //            }).OrderByDescending(a => a.RevisionID).Take(1).Distinct().ToList<CopytabRevfile>();


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


        public int getProjectMileStoneIDByName(string projectMilestoneName, int projectID)
        {

            int result = 0;
            //select ProjectMilestoneID from ProjectMilestones where ProjectMilestone='SUB' and ProjectID=385

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var lst = (from pm in context.ProjectMilestones
            //               where pm.ProjectID == projectID && pm.ProjectMilestone1 == projectMilestoneName
            //               select pm.ProjectMilestoneID);


            //    result = lst.SingleOrDefault();
            //}


            return result;
        }

        public bool IsSubApproved(int MileStoneId, int TaskID)
        {
            var status = false;
            int? ProgrelvlID = MileStoneId;
            List<int> FileStatusID = null;
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    List<int?> list = (from u in context.UploadDeliverableFiles
            //                       join FS in context.FileStatus
            //                       on new { b = (int?)u.UploadDeliverableFileID, a = u.MilestoneID } equals new { b = FS.FileID, a = FS.ProgresslevelID }
            //                       where u.MilestoneID == ProgrelvlID && u.DeliverableListID == (int?)TaskID
            //                       select FS.FileID
            //                          ).ToList();
            //    //List<int> list = context.UploadDeliverableFiles.Where(a => a.MilestoneID == MileStoneId && a.DeliverableListID==TaskID).Select(a => a.UploadDeliverableFileID).ToList();
            //    FileStatusID = context.FileStatus.Where(a => a.ProgresslevelID == (int?)ProgrelvlID && a.StatusID != 3).Select(a => a.FileStatusID).ToList();
            //    if (list.Count > 0 && FileStatusID.Count() == 0)
            //    {
            //        status = true;
            //    }
            //    else
            //    {
            //        status = false;
            //    }


            //}
            return status;
        }

        public bool IsWorkflowpercentdefined(int MileStoneId)
        {
            var status = false;
            int count = 0;
            int? ProgrelvlID = MileStoneId;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    count = context.TaskTypeWiseProgresses.Where(a => a.ProjectMilestoneID == ProgrelvlID).ToList().Count();
            //}
            if (count > 0)
                status = true;
            return status;
        }

        public List<Copytabfile> GetMileStoneIdTaskIDofPrvTabFrmRvsnToVrsn(int TaskID, int ProjectMilestoneID) // getting these values in respect to highest percentage weightage
        {
            List<Copytabfile> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{

                //    int ProjectID = (from P in context.ProjectMilestones
                //                     where P.ProjectMilestoneID == ProjectMilestoneID
                //                     select (int)P.ProjectID).FirstOrDefault();

                //    //decimal? percentwt = (from TTWP in context.TaskTypeWiseProgresses
                //    //                      where TTWP.ProjectMilestoneID == ProjectMilestoneID && (int)TTWP.ProjectID == ProjectID
                //    //                      select (decimal)TTWP.PercentWeitage).FirstOrDefault();

                //    list = (from UF in context.UploadDeliverableFiles
                //            join TM in context.TaskMilestoneTargetDates on UF.DeliverableListID equals TM.TaskID
                //            join TtWP in context.TaskTypeWiseProgresses on new { b = (int?)TM.MileStoneID, a = (int?)TM.TaskTypeID } equals new { b = TtWP.ProjectMilestoneID, a = TtWP.TaskTypeID }
                //            where (int)UF.DeliverableListID == TaskID && (int)UF.MilestoneID > 0
                //            // && (decimal)TtWP.PercentWeitage > percentwt && TM.MileStoneID != ProjectMilestoneID

                //            select new Copytabfile
                //            {
                //                TaskID = TM.TaskID,
                //                MileStoneID = TM.MileStoneID,
                //                PercentWeitage = TtWP.PercentWeitage,
                //                ProjectID = TtWP.ProjectID,
                //                TaskTypeID = TM.TaskTypeID
                //            }).OrderByDescending(a => a.PercentWeitage).Take(1).Distinct().ToList<Copytabfile>();
                //    // select new { TM.TaskID,TM.MileStoneID, TtWP.PercentWeitage };



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


     

        public OperationResult AddCopyFiletoUploadFileDel(string TaskID, string ProjectMilestoneID, string RevisionID, string deptname)
        {
            OperationResult res = new OperationResult();
            //using (TransactionScope transaction = new TransactionScope())
            //{
              
            //    try
            //    {

            //        if (Convert.ToInt32(RevisionID) == 0)
            //        {
            //            List<BLProjectMilestoneRepository.Copytabfile> list = null;
            //            BLProjectMilestoneRepository objMileTaskid = new BLProjectMilestoneRepository();
            //            BLUploadDeliverableFile objupld = new BLUploadDeliverableFile();
            //            UploadDeliverableFile objfile = null;

            //            list = objMileTaskid.GetMileStoneIdTaskIDofPreviousTab(Convert.ToInt32(TaskID), Convert.ToInt32(ProjectMilestoneID));
            //            if (list.Count() > 0)
            //            {
            //                int delilstId = list[0].TaskID;
            //                int milestnID = list[0].MileStoneID;
            //                int? ProjectID = list[0].ProjectID;
            //                int? TaskTypeID = list[0].TaskTypeID;
            //                string filePath = "";
            //                string ProjectCode = "";
            //                string DeliverableNo = ""; ;
            //                int taskid = 0;
            //                taskid = Convert.ToInt32(TaskID);
            //                using (var newcontext = new Cubicle_EntityEntities())
            //                {
            //                    ProjectCode = newcontext.Projects.Where(a => a.ProjectID == ProjectID).Select(a => a.ProjectCode).FirstOrDefault();
            //                    DeliverableNo = newcontext.ProjectTaskLists.Where(a => a.TaskTypeID == TaskTypeID && a.ProjectID == ProjectID && a.ProjectTaskID == taskid).Select(a => a.DeliverableNo).FirstOrDefault();
            //                }
            //                string prevTab = null;
            //                string strCurrentTab = objMileTaskid.GetMilestoneByID(Convert.ToInt32(ProjectMilestoneID)).ProjectMilestone1;
            //                // filePath = "~/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab;
            //                // filePath = "~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;

            //                filePath = Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;

            //                List<UploadDeliverableFile> objcopyfiledata = null;
            //                List<UploadDeliverableFile> objuploadData = new List<UploadDeliverableFile>();
            //                using (var context = new Cubicle_EntityEntities())
            //                {
            //                    objcopyfiledata = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == delilstId && a.MilestoneID == milestnID).ToList<UploadDeliverableFile>();
            //                    bool HasFile = false;
            //                    if (Convert.ToInt32(RevisionID) > 0)
            //                    {
            //                        HasFile = objupld.CheckIfDuplicateFileInCurrentTab(Convert.ToInt32(TaskID), 0, Convert.ToInt32(RevisionID), objcopyfiledata);
            //                    }
            //                    else
            //                    {
            //                        HasFile = objupld.CheckIfDuplicateFileInCurrentTab(Convert.ToInt32(TaskID), Convert.ToInt32(ProjectMilestoneID), 0, objcopyfiledata);
            //                    }
            //                    if (HasFile)//don't copy any file file
            //                    {
            //                        res.Message = "Files with same file name can not be placed in same folder.";
            //                        res.MessageType = "F";
            //                        return res;
            //                    }
            //                    else
            //                    {
            //                        for (int i = 0; i < objcopyfiledata.Count(); i++)
            //                        {

            //                            objfile = new UploadDeliverableFile();
            //                            objfile.UploadDeliverableFileID = 0;
            //                            objfile.MilestoneID = Convert.ToInt32(ProjectMilestoneID);
            //                            objfile.DeliverableListID = Convert.ToInt32(TaskID);
            //                            objfile.FilePath = filePath + "/" + objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention;
            //                            objfile.FileName = objcopyfiledata[i].FileName;
            //                            objfile.FileSize = objcopyfiledata[i].FileSize;
            //                            objfile.FileExtention = objcopyfiledata[i].FileExtention;
            //                            objfile.CreatedOn = System.DateTime.Now;
            //                            objfile.RevisionID = 0;
            //                            objfile.EntityState = DominModel.EntityState.Added;
            //                            objfile.CreatedBy = Convert.ToString(HttpContext.Current.Session["UserId"]);
            //                            objuploadData.Add(objfile);
            //                            prevTab = objMileTaskid.GetMilestoneByID(Convert.ToInt32(objcopyfiledata[i].MilestoneID)).ProjectMilestone1;
            //                            //string srcDirectory = HttpContext.Current.Server.MapPath("~/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                            //string srcDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                            string srcDirectory = BasePage.networkdirectorypath + "\\" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + prevTab;
            //                            string sourceFile = System.IO.Path.Combine(srcDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                            //string destDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab);
            //                            string destDirectory = BasePage.networkdirectorypath + "\\" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;
            //                            string destFile = System.IO.Path.Combine(destDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                            // To copy a folder's contents to a new location:
            //                            // Create a new target folder, if necessary.
            //                            if (!System.IO.Directory.Exists(destDirectory))
            //                            {
            //                                System.IO.Directory.CreateDirectory(destDirectory);
            //                            }
            //                            // To copy a file to another location and 
            //                            // overwrite the destination file if it already exists.
            //                            if (System.IO.File.Exists(sourceFile))
            //                            {
            //                                System.IO.File.Copy(sourceFile, destFile, true);
            //                            }
            //                        }
            //                        objupld.AddUploadDeliverableFile(objuploadData.ToArray());
            //                        res.Message = "Success";
            //                        res.MessageType = "S";
            //                    }

            //                }
            //                //deliverable progress update
            //                int result = objupld.UpdateProgressDeliverable(Convert.ToInt32(ProjectMilestoneID), Convert.ToInt32(Common.DocStatusID.Upload), Convert.ToInt32(TaskID), Convert.ToInt32(RevisionID), 0, "U");

            //                //  transaction.Complete();
            //                // res = "1";
            //            }
            //        }
            //        else
            //        {

            //            List<BLProjectMilestoneRepository.CopytabRevfile> list1 = null;
            //            List<BLProjectMilestoneRepository.Copytabfile> list2 = null;
            //            BLProjectMilestoneRepository objMileTaskid = new BLProjectMilestoneRepository();
            //            BLUploadDeliverableFile objupld = new BLUploadDeliverableFile();
            //            UploadDeliverableFile objfile = null;
            //            list1 = objMileTaskid.GetRevIdTaskIDofPreviousTab(Convert.ToInt32(TaskID), Convert.ToInt32(ProjectMilestoneID), Convert.ToInt32(RevisionID));
            //            List<UploadDeliverableFile> objcopyfiledata = null;
            //            List<UploadDeliverableFile> objuploadData = new List<UploadDeliverableFile>();
            //            if (list1.Count() > 0)
            //            {
            //                using (var context = new Cubicle_EntityEntities())
            //                {
            //                    int delilstId = list1[0].TaskID;
            //                    int milestnID = list1[0].MileStoneID;
            //                    int? ProjectID = list1[0].ProjectID;
            //                    int? TaskTypeID = list1[0].TaskTypeID;
            //                    int rvsnID = list1[0].RevisionID;
            //                    int revisionid = Convert.ToInt32(RevisionID);
            //                    string rvsnNo = "";
            //                    string filePath = "";
            //                    string ProjectCode = "";
            //                    int? TaskNo = null;
            //                    int taskid = 0;
            //                    string DeliverableNo = ""; ;
            //                    taskid = Convert.ToInt32(TaskID);
            //                    if (rvsnID > 0)
            //                    {
            //                        ProjectCode = context.Projects.Where(a => a.ProjectID == ProjectID).Select(a => a.ProjectCode).FirstOrDefault();
            //                        DeliverableNo = context.ProjectTaskLists.Where(a => a.TaskTypeID == TaskTypeID && a.ProjectID == ProjectID && a.ProjectTaskID == taskid).Select(a => a.DeliverableNo).FirstOrDefault();
            //                        rvsnNo = context.RevisionFiles.Where(a => a.RevisionID == revisionid).Select(a => a.RevisionNo).FirstOrDefault();
            //                        string prevTab = null;
            //                        // string strCurrentTab = objMileTaskid.GetMilestoneByID(Convert.ToInt32(ProjectMilestoneID)).ProjectMilestone1;
            //                        string strCurrentTab = rvsnNo;
            //                        // filePath = "~/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab;
            //                        //filePath = "~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab;


            //                        // filePath = "~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;

            //                        filePath = Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;





            //                        objcopyfiledata = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == delilstId && a.RevisionID == rvsnID).ToList<UploadDeliverableFile>();
            //                        bool HasFile = false;
            //                        if (Convert.ToInt32(RevisionID) > 0)
            //                        {
            //                            HasFile = objupld.CheckIfDuplicateFileInCurrentTab(Convert.ToInt32(TaskID), 0, Convert.ToInt32(RevisionID), objcopyfiledata);
            //                        }
            //                        else
            //                        {
            //                            HasFile = objupld.CheckIfDuplicateFileInCurrentTab(Convert.ToInt32(TaskID), Convert.ToInt32(ProjectMilestoneID), 0, objcopyfiledata);
            //                        }
            //                        if (HasFile)//don't copy any file file
            //                        {
            //                            res.Message = "Files with same file name can not be placed in same folder";
            //                            res.MessageType = "F";
            //                            return res;
            //                        }
            //                        else
            //                        {
            //                            for (int i = 0; i < objcopyfiledata.Count(); i++)
            //                            {

            //                                objfile = new UploadDeliverableFile();
            //                                objfile.UploadDeliverableFileID = 0;
            //                                objfile.MilestoneID = 0;
            //                                objfile.DeliverableListID = Convert.ToInt32(TaskID);
            //                                objfile.FilePath = filePath + "/" + objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention;
            //                                objfile.FileName = objcopyfiledata[i].FileName;
            //                                objfile.FileSize = objcopyfiledata[i].FileSize;
            //                                objfile.FileExtention = objcopyfiledata[i].FileExtention;
            //                                objfile.CreatedOn = System.DateTime.Now;
            //                                objfile.RevisionID = Convert.ToInt32(RevisionID);
            //                                objfile.EntityState = DominModel.EntityState.Added;
            //                                objfile.CreatedBy = Convert.ToString(HttpContext.Current.Session["UserId"]);
            //                                objuploadData.Add(objfile);
            //                                prevTab = objMileTaskid.GetRevisionNoByID(Convert.ToInt32(objcopyfiledata[i].RevisionID));
                                       
                                            
            //                                ////string srcDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                                //string srcDirectory = BasePage.networkdirectorypath + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + prevTab;
            //                                //string sourceFile = System.IO.Path.Combine(srcDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                                ////string destDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab);

            //                                //string destDirectory = BasePage.networkdirectorypath + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;

            //                                //string destFile = System.IO.Path.Combine(destDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);



            //                                //string srcDirectory = HttpContext.Current.Server.MapPath("~/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                                //string srcDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                                string srcDirectory = BasePage.networkdirectorypath + "\\" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + prevTab;
            //                                string sourceFile = System.IO.Path.Combine(srcDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                                //string destDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab);
            //                                string destDirectory = BasePage.networkdirectorypath + "\\" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;
            //                                string destFile = System.IO.Path.Combine(destDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                                // To copy a folder's contents to a new location:
            //                                // Create a new target folder, if necessary.


                                            
                                            
                                            
            //                                if (!System.IO.Directory.Exists(destDirectory))
            //                                {
            //                                    System.IO.Directory.CreateDirectory(destDirectory);
            //                                }

            //                                if (System.IO.File.Exists(sourceFile))
            //                                {
            //                                    System.IO.File.Copy(sourceFile, destFile, true);
            //                                }
            //                            }
            //                            objupld.AddUploadDeliverableFile(objuploadData.ToArray());
            //                            res.Message = "Success";
            //                            res.MessageType = "S";
            //                        }
            //                    }
            //                }
            //                // transaction.Complete();
            //                // res = "1";
            //                //deliverable progress update
            //                int result = objupld.UpdateProgressDeliverable(Convert.ToInt32(ProjectMilestoneID), Convert.ToInt32(Common.DocStatusID.Upload), Convert.ToInt32(TaskID), Convert.ToInt32(RevisionID), 0, "U");

            //            }
            //            else
            //            {
            //                using (var context = new Cubicle_EntityEntities())
            //                {

            //                    int? promilestoneID = Convert.ToInt32(ProjectMilestoneID);
            //                    int? deltaskid = Convert.ToInt32(TaskID);
            //                    string rvsnNo = "";
            //                    string filePath = "";
            //                    string ProjectCode = "";
            //                    int? TaskNo = null;
            //                    int taskid = 0;
            //                    string DeliverableNo = ""; ;
            //                    int revisionid = Convert.ToInt32(RevisionID);
            //                    taskid = Convert.ToInt32(TaskID);
            //                    int? TaskTypeID = null;
            //                    int ProiD = 0;
            //                    string prevTab = null;
            //                    ProiD = context.ProjectMilestones.Where(a => a.ProjectMilestoneID == promilestoneID).Select(a => (int)a.ProjectID).FirstOrDefault();
            //                    ProjectCode = context.Projects.Where(a => a.ProjectID == ProiD).Select(a => a.ProjectCode).FirstOrDefault();
            //                    rvsnNo = context.RevisionFiles.Where(a => a.RevisionID == revisionid).Select(a => a.RevisionNo).FirstOrDefault();
            //                    int mlStoneId = objMileTaskid.getProjectMileStoneIDByName("SUB", (int)ProiD);
            //                    //bool approved = objMileTaskid.IsSubApproved(mlStoneId, Convert.ToInt32(RevisionID));
            //                    //if (approved)
            //                    {
            //                        list2 = objMileTaskid.GetMileStoneIdTaskIDofPrvTabFrmRvsnToVrsn(Convert.ToInt32(TaskID), Convert.ToInt32(ProjectMilestoneID));
            //                        if (list2.Count() > 0)
            //                        {
            //                            int delilstId = list2[0].TaskID;
            //                            int milestnID = list2[0].MileStoneID;
            //                            TaskTypeID = list2[0].TaskTypeID;
            //                            DeliverableNo = context.ProjectTaskLists.Where(a => a.TaskTypeID == TaskTypeID && a.ProjectID == ProiD && a.ProjectTaskID == taskid).Select(a => a.DeliverableNo).FirstOrDefault();
            //                            string strCurrentTab = rvsnNo;
            //                          //  filePath = "~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab;
            //                            filePath = Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;

                                        
            //                            objcopyfiledata = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == (int)delilstId && a.MilestoneID == milestnID).ToList<UploadDeliverableFile>();


            //                            bool HasFile = false;
            //                            if (Convert.ToInt32(RevisionID) > 0)
            //                            {
            //                                HasFile = objupld.CheckIfDuplicateFileInCurrentTab(Convert.ToInt32(TaskID), 0, Convert.ToInt32(RevisionID), objcopyfiledata);
            //                            }
            //                            else
            //                            {
            //                                HasFile = objupld.CheckIfDuplicateFileInCurrentTab(Convert.ToInt32(TaskID), Convert.ToInt32(ProjectMilestoneID), 0, objcopyfiledata);
            //                            }
            //                            if (HasFile)//don't copy any file file
            //                            {
            //                                res.Message = "Files with same file name can not be placed in same folder";
            //                                res.MessageType = "F";
            //                                return res;
            //                            }
            //                            else
            //                            {
            //                                for (int i = 0; i < objcopyfiledata.Count(); i++)
            //                                {
            //                                    objfile = new UploadDeliverableFile();
            //                                    objfile.UploadDeliverableFileID = 0;
            //                                    objfile.MilestoneID = 0;
            //                                    objfile.DeliverableListID = Convert.ToInt32(TaskID);
            //                                    objfile.FilePath = filePath + "/" + objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention;
            //                                    objfile.FileName = objcopyfiledata[i].FileName;
            //                                    objfile.FileSize = objcopyfiledata[i].FileSize;
            //                                    objfile.FileExtention = objcopyfiledata[i].FileExtention;
            //                                    objfile.CreatedOn = System.DateTime.Now;
            //                                    objfile.RevisionID = Convert.ToInt32(RevisionID);
            //                                    objfile.EntityState = DominModel.EntityState.Added;
            //                                    objfile.CreatedBy = Convert.ToString(HttpContext.Current.Session["UserId"]);
            //                                    objuploadData.Add(objfile);
            //                                    prevTab = objMileTaskid.GetMilestoneByID(Convert.ToInt32(objcopyfiledata[i].MilestoneID)).ProjectMilestone1;


            //                                    ////string srcDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                                    //string srcDirectory = BasePage.networkdirectorypath + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + prevTab;
            //                                    //string sourceFile = System.IO.Path.Combine(srcDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                                    ////string destDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab);
            //                                    //string destDirectory = BasePage.networkdirectorypath + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;
            //                                    //string destFile = System.IO.Path.Combine(destDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);



            //                                    //string srcDirectory = HttpContext.Current.Server.MapPath("~/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                                    //string srcDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                                    string srcDirectory = BasePage.networkdirectorypath + "\\" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + prevTab;
            //                                    string sourceFile = System.IO.Path.Combine(srcDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                                    //string destDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab);
            //                                    string destDirectory = BasePage.networkdirectorypath + "\\" + Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') + "\\" + ProjectCode + "/" + deptname + "/" + Convert.ToString(DeliverableNo) + "/" + strCurrentTab;
            //                                    string destFile = System.IO.Path.Combine(destDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                                    // To copy a folder's contents to a new location:
            //                                    // Create a new target folder, if necessary.
                                                
                                                
                                                
                                                
                                                
                                                
            //                                    if (!System.IO.Directory.Exists(destDirectory))
            //                                    {
            //                                        System.IO.Directory.CreateDirectory(destDirectory);
            //                                    }
            //                                    if (System.IO.File.Exists(sourceFile))
            //                                    {
            //                                        System.IO.File.Copy(sourceFile, destFile, true);
            //                                    }

            //                                }
            //                                objupld.AddUploadDeliverableFile(objuploadData.ToArray());
            //                                res.Message = "Success";
            //                                res.MessageType = "S";
            //                            }
            //                        }
            //                        // transaction.Complete();
            //                    }
            //                    //else
            //                    //{

            //                    //    TaskTypeID = context.ProjectTaskLists.Where(a => a.ProjectTaskID == taskid && a.ProjectID == ProiD).Select(a => (int?)a.TaskTypeID).FirstOrDefault();
            //                    //    TaskNo = context.ProjectTaskLists.Where(a => a.TaskTypeID == (int)TaskTypeID && a.ProjectID == ProiD && a.ProjectTaskID == taskid).Select(a => a.TaskNo).FirstOrDefault();
            //                    //    string strCurrentTab = rvsnNo;
            //                    //    filePath = "~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]) + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab;
            //                    //    objcopyfiledata = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == deltaskid && a.MilestoneID == mlStoneId).ToList<UploadDeliverableFile>();
            //                    //    for (int i = 0; i < objcopyfiledata.Count(); i++)
            //                    //    {
            //                    //        objfile = new UploadDeliverableFile();
            //                    //        objfile.UploadDeliverableFileID = 0;
            //                    //        objfile.MilestoneID = 0;
            //                    //        objfile.DeliverableListID = Convert.ToInt32(TaskID);
            //                    //        objfile.FilePath = filePath + "/" + objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention;
            //                    //        objfile.FileName = objcopyfiledata[i].FileName;
            //                    //        objfile.FileSize = objcopyfiledata[i].FileSize;
            //                    //        objfile.FileExtention = objcopyfiledata[i].FileExtention;
            //                    //        objfile.CreatedOn = System.DateTime.Now;
            //                    //        objfile.RevisionID = Convert.ToInt32(RevisionID);
            //                    //        objfile.EntityState = DominModel.EntityState.Added;
            //                    //        objfile.CreatedBy = Convert.ToString(HttpContext.Current.Session["UserId"]);
            //                    //        objuploadData.Add(objfile);
            //                    //        prevTab = objMileTaskid.GetMilestoneByID(Convert.ToInt32(mlStoneId)).ProjectMilestone1;
            //                    //        //prevTab = objMileTaskid.GetRevisionNoByID(Convert.ToInt32(objcopyfiledata[i].RevisionID));
            //                    //        string srcDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]) + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + prevTab);
            //                    //        string sourceFile = System.IO.Path.Combine(srcDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                    //        string destDirectory = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(HttpContext.Current.Session["ComanyName"]) + "/projectDocuments/" + ProjectCode + "/" + Convert.ToString(TaskNo) + "/" + strCurrentTab);
            //                    //        string destFile = System.IO.Path.Combine(destDirectory, objcopyfiledata[i].FileName + objcopyfiledata[i].FileExtention);
            //                    //        if (!System.IO.Directory.Exists(destDirectory))
            //                    //        {
            //                    //            System.IO.Directory.CreateDirectory(destDirectory);
            //                    //        }
            //                    //        if (System.IO.File.Exists(sourceFile))
            //                    //        {
            //                    //            System.IO.File.Copy(sourceFile, destFile, true);
            //                    //        }
            //                    //    }
            //                    //    objupld.AddUploadDeliverableFile(objuploadData.ToArray());
            //                    //    //transaction.Complete();
            //                    //}


            //                    //deliverable progress update
            //                    int result = objupld.UpdateProgressDeliverable(Convert.ToInt32(ProjectMilestoneID), Convert.ToInt32(Common.DocStatusID.Upload), Convert.ToInt32(TaskID), Convert.ToInt32(RevisionID), 0, "U");

            //                }
            //            }
            //        }
            //        transaction.Complete();
            //    }


            //    catch (Exception ex)
            //    {
            //        res.Message = "Error O";
            //        res.MessageType = "S";
            //        transaction.Dispose();
            //        throw ex;
                    
            //    }
                
                return res;

            //}
        }



        //public static IList<usp_IsPreviousProgressLevelApproved_Result> IsPreviousProgressLevelApproved(int TaskTypeID, int ProjectID, int ProjectMilestoneID)
        //{
        //    List<usp_IsPreviousProgressLevelApproved_Result> list = null;
        //    try
        //    {
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //            list = db.usp_IsPreviousProgressLevelApproved(TaskTypeID, ProjectID, ProjectMilestoneID).ToList<usp_IsPreviousProgressLevelApproved_Result>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return list;
        //}

        public class Copytabfile
        {
            public int TaskID { get; set; }
            public int MileStoneID { get; set; }
            public int? ProjectID { get; set; }
            public decimal? PercentWeitage { get; set; }
            public int RevisionID { get; set; }
            public int? TaskTypeID { get; set; }

        }

        public List<Copytabfile> GetMileStoneIdTaskIDofPreviousTab(int TaskID, int ProjectMilestoneID) // getting these values in respect to highest percentage weightage
        {
            List<Copytabfile> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{

                //    int ProjectID = (from P in context.ProjectMilestones
                //                     where P.ProjectMilestoneID == ProjectMilestoneID
                //                     select (int)P.ProjectID).FirstOrDefault();
                //    int? TaskTypeID = context.ProjectTaskLists.Where(a => a.ProjectTaskID == TaskID && a.ProjectID == ProjectID).Select(a => (int?)a.TaskTypeID).FirstOrDefault();

                //    decimal? percentwt = (from TTWP in context.TaskTypeWiseProgresses
                //                          where TTWP.ProjectMilestoneID == ProjectMilestoneID && (int)TTWP.ProjectID == ProjectID && TTWP.TaskTypeID == TaskTypeID
                //                          select TTWP.PercentWeitage).FirstOrDefault();

                //    list = (from UF in context.UploadDeliverableFiles
                //            join TM in context.TaskMilestoneTargetDates on UF.DeliverableListID equals TM.TaskID
                //            join TtWP in context.TaskTypeWiseProgresses on new { b = (int?)TM.MileStoneID, a = (int?)TM.TaskTypeID } equals new { b = TtWP.ProjectMilestoneID, a = TtWP.TaskTypeID }
                //            where (int)UF.DeliverableListID == TaskID && (int)UF.MilestoneID > 0
                //            && (decimal)TtWP.PercentWeitage <= percentwt && TM.MileStoneID < ProjectMilestoneID

                //            select new Copytabfile
                //            {
                //                TaskID = TM.TaskID,
                //                MileStoneID = TM.MileStoneID,
                //                PercentWeitage = TtWP.PercentWeitage,
                //                ProjectID = TtWP.ProjectID,
                //                TaskTypeID = TM.TaskTypeID
                //            }).OrderByDescending(a => a.PercentWeitage).Take(1).Distinct().ToList<Copytabfile>();
                //    // select new { TM.TaskID,TM.MileStoneID, TtWP.PercentWeitage };
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

        public List<ProjectMilestone> getDisplaypmvalInDb(int ProjectID, int activitytypeid)
        {
            List<ProjectMilestone> result = null;

            List<object> check = null;
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    check = (from b in context.EstimationTaskColumnsMasters where b.DisplayInGrid == "Y" && b.PermanentNameInDb != "TaskProgressLevels" select b).ToList<object>();

            //    if (check.Count() > 0)
            //    {
            //        result = (from a in context.ProjectMilestones
            //                  where a.ProjectID == ProjectID && a.ActivityTypeID == activitytypeid

            //                  select a).ToList<ProjectMilestone>(); ;

            //    }

            //}

            return result;
        }


        public List<usp_getProgressLevelTemplte_Result> getProgressLevelTemplte(int TemplateID)
        {
            List<usp_getProgressLevelTemplte_Result> list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.usp_getProgressLevelTemplte(TemplateID).ToList<usp_getProgressLevelTemplte_Result>();
            //}
            return list;
        }
        public List<ProjectProgressLevelTemplate> getAllProgressLevelTemplte()
        {
            List<ProjectProgressLevelTemplate> lst = new List<ProjectProgressLevelTemplate>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProjectProgressLevelTemplates.OrderByDescending(a => a.ProgressLevelTemplateName).ToList<ProjectProgressLevelTemplate>();
            //}
            return lst;
        }


        public List<ProjectProgressLevelTemplate> getAllProgressLevelTemplte(int CompanyId)
        {
            List<ProjectProgressLevelTemplate> lst = new List<ProjectProgressLevelTemplate>();
            //using (var context = new Cubicle_EntityEntities()){



            //    lst = context.ProjectProgressLevelTemplates.Where(c => c.CompanyId == CompanyId ).ToList<ProjectProgressLevelTemplate>();

                
            //}
            return lst;
        }
        public List<ProjectMilestone> GetMilestoneByProjectIDTaskTypeID(int projectID, int TaskTypeID)
        {
            List<ProjectMilestone> lst = null;
            //BLTaskTypeRepository blt = new BLTaskTypeRepository();
            //TaskType tt = blt.GetTaskTypeByID(TaskTypeID);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from pm in context.ProjectMilestones
            //           join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            //           where pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID && pm.ActivityTypeID == tt.ActivityType && mtty.PercentWeitage != null && mtty.PercentWeitage != 0
            //           orderby mtty.PercentWeitage
            //           select pm).ToList<ProjectMilestone>();
            //}
            return lst;
        }

        public List<ProjectMilestone> GetMilestoneByProjectIDTaskTypeID(int projectID, int TaskTypeID,int TaskSettingID,int WorkFlowTemplateID)
        {
            List<ProjectMilestone> lst = null;
            //BLTaskTypeRepository blt = new BLTaskTypeRepository();
            ////TaskType tt = blt.GetTaskTypeByID(TaskTypeID);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from pm in context.ProjectMilestones
            //           join mtty in context.TaskTypeWiseProgresses on pm.ProjectMilestoneID equals mtty.ProjectMilestoneID
            //           join up in context.UsedProgressLevelTemplateNPAs on pm.ProjectMilestoneID equals up.ProjectMilestoneID
            //           where up.TaskSettingID==TaskSettingID && up.ProgressLevelTemplateID==WorkFlowTemplateID && pm.ProjectID == projectID && mtty.TaskTypeID == TaskTypeID
            //           orderby mtty.PercentWeitage
            //           select pm).ToList<ProjectMilestone>();
            //}
            return lst;
        }

        public int saveProjectMileStoneNew(ProjectMilestone projectMilestone)
        {
            int result = 0;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        MileStoneTaskTypeRepository _mileStoneTaskTypeRepository = new MileStoneTaskTypeRepository();
            //        _projectMilestoneRepository.Add(projectMilestone);
            //        result = projectMilestone.ProjectMilestoneID;
            //        /*if (projectMilestone.ProjectMilestoneID > 0)
            //        {
            //            if (lstMileStoneTaskType.Count > 0)
            //            {
            //                lstMileStoneTaskType.Select(c => { c.MileStoneID = projectMilestone.ProjectMilestoneID; return c; }).ToList();
            //                result = _mileStoneTaskTypeRepository.getAdd(lstMileStoneTaskType.ToArray());
            //            }
            //            else
            //            {
            //                result = projectMilestone.ProjectMilestoneID;
            //            }
            //        }*/
            //        if (result > 0)
            //        {
            //            ts.Complete();
            //        }
            //        else
            //        {
            //            result = -1;
            //            ts.Dispose();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        result = -1;
            //        ts.Dispose();
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw ex;
            //    }
                return result;
            //}
        }
        public int saveProjectMileStone(List<MileStoneTaskType> lstMileStoneTaskType, ProjectMilestone projectMilestone)
        {
            int result = 0;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        MileStoneTaskTypeRepository _mileStoneTaskTypeRepository = new MileStoneTaskTypeRepository();
            //        _projectMilestoneRepository.Add(projectMilestone);
            //        if (projectMilestone.ProjectMilestoneID > 0)
            //        {
            //            if (lstMileStoneTaskType.Count > 0)
            //            {
            //                lstMileStoneTaskType.Select(c => { c.MileStoneID = projectMilestone.ProjectMilestoneID; return c; }).ToList();
            //                result = _mileStoneTaskTypeRepository.getAdd(lstMileStoneTaskType.ToArray());
            //            }
            //            else
            //            {
            //                result = projectMilestone.ProjectMilestoneID;
            //            }
            //        }
            //        if (result > 0)
            //        {
            //            ts.Complete();
            //        }
            //        else
            //        {
            //            result = -1;
            //            ts.Dispose();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        result = -1;
            //        ts.Dispose();
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw ex;
            //    }
                return result;
            //}
        }

        public List<MileStoneTaskType> getAllMileStoneTaskType()
        {

            List<MileStoneTaskType> lst = null;
            return lst;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    return context.MileStoneTaskTypes.ToList<MileStoneTaskType>();
            //}
        }

        public List<MileStoneTaskType> GetTaskTypeByMilestoneID(int MilestoneID)
        {
            List<MileStoneTaskType> fetchedTaskType = new List<MileStoneTaskType>();
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    IQueryable<MileStoneTaskType> query = Context.MileStoneTaskTypes.Where(p => p.MileStoneID == MilestoneID);
            //    fetchedTaskType = query.ToList<MileStoneTaskType>();
            //}
            return fetchedTaskType;
        }

        public int saveProgressLevelTemplate(ProjectProgressLevelTemplate progressTemplate)
        {
            int result = 0;

            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        BLProjectProgressLevelTemplate _projectProgressLevelTemplate = new BLProjectProgressLevelTemplate();
            //        result = _projectProgressLevelTemplate.getAddProjectProgressLevelTemplate(progressTemplate);
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

        public int ImportProgressLevelTemplate(int ProgressLevelTemplateDetailID, int ProjectID)
        {
            int result = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.usp_ImportProgressLevel(ProgressLevelTemplateDetailID, ProjectID, Convert.ToInt32(Common.UserSession.UserID));
            //}
            return result;
        }

        public int DeleteProgressLevelTemplate(int ProgressLevelTemplateDetailID)
        {
            int result = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.USP_DeleteWorkFlowTemplate(ProgressLevelTemplateDetailID);
            //}
            return result;
        }



        public static string LockUnLockStatus(int ProjectID)
        {
            string res = "";
            int Icount = 0;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        //res = (from a in context.ProjectMilestones where a.ProjectID == ProjectID select a).ToList().Min(p=>p.LOCK).GetValueOrDefault();
            //        int TaskCount = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && (a.SysGen == "N" || a.SysGen == null) select a).ToList().Count();
            //        if (TaskCount > 0)
            //        {
            //            Icount = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && (a.CurrentLockStatus == "L" || a.CurrentLockStatus == null) && (a.SysGen == "N" || a.SysGen == null) select a).ToList().Count();
            //            if (Icount > 0)
            //            {
            //                res = "L";
            //            }
            //            else
            //            {
            //                res = "U";
            //            }

            //        }
            //        else
            //        {
            //            res = "L";
            //        }
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
            return res;
        }





        public static Int32 LockUnLock(int ProjectID)
        {
            int res = 0;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        //res = (from a in context.ProjectMilestones where a.ProjectID == ProjectID select a).ToList().Min(p=>p.LOCK).GetValueOrDefault();
            //        int TaskCount = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && (a.SysGen == "N" || a.SysGen == null) select a).ToList().Count();
            //        if (TaskCount > 0)
            //        {
            //            res = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && a.LOCK == 1 && (a.SysGen == "N" || a.SysGen == null) select a).ToList().Count();
            //            if (res == TaskCount)
            //            {
            //                //unlock the task list
            //                res = 2;
            //            }
            //            else
            //            {
            //                //lock the task list
            //                res = 1;
            //            }
            //        }
            //        else
            //        {
            //            res = 1;
            //        }
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
            return res;
        }
        public static Boolean LockTask(int ProjectID, int UserID)
        {
            Boolean res = false;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        context.usp_LockTaskList(ProjectID, UserID);
            //        res = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    res = false;
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return res;
        }

        public static bool SetCurrentLockunLockStatus(int ProjectID, string lockmode)
        {
            Boolean res = false;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        var MilestoneList = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID select a).ToList<ProjectTaskList>();
            //        foreach (var m in MilestoneList)
            //        {
            //            m.CurrentLockStatus = lockmode;
            //            context.Entry(m).State = System.Data.EntityState.Modified;
            //        }
            //        context.SaveChanges();
            //        res = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    res = false;
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return res;
        }













        public static bool LockMilestone(int ProjectID, int lockmode)
        {
            Boolean res = false;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        var MilestoneList = (from a in context.ProjectMilestones where a.ProjectID == ProjectID select a).ToList<ProjectMilestone>();
            //        foreach (var m in MilestoneList)
            //        {
            //            m.LOCK = lockmode;
            //            if (lockmode == 1)
            //                m.RequestID = m.RequestID == null ? 1 : m.RequestID;
            //            else
            //            {
            //                m.RequestID = (m.RequestID == null ? 0 : m.RequestID) + 1;

            //            }
            //            context.Entry(m).State = System.Data.EntityState.Modified;
            //        }
            //        context.SaveChanges();
            //        //if (lockmode != 1)
            //        //{
            //        //    var maxReqid = (from a in context.ProjectMilestones where a.ProjectID == ProjectID select a.RequestID).ToList().Max().GetValueOrDefault(0);
            //        //    var TaskLists=(from t in context.ProjectTaskLists where t.ProjectID==ProjectID && t.RequestID==null select t).ToList();

            //        //    foreach (var t in TaskLists)
            //        //    {
            //        //        t.RequestID = maxReqid;
            //        //        context.Entry(t).State = System.Data.EntityState.Modified;
            //        //    }
            //        //    context.SaveChanges();
            //        //}
            //        res = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    res = false;
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return res;
        }

        public IList<usp_getEditMilestone_Result> getEditMilestone(int TaskID)
        {
            IList<usp_getEditMilestone_Result> list = null;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        int TaskstatusID = Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint);
            //        list = context.usp_getEditMilestone(TaskID).ToList<usp_getEditMilestone_Result>();
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
            return list;
        }


        public String IsPreviousProgressLevelApproved(int TaskID, int ProjectMilestoneID, int RevNumber)
        {
            string strPreviousProgressLevel = "";
            //int FileApprovedStatusID = Convert.ToInt32(Common.FileStatusID.Approved);
            //IList<usp_IsPreviousProgressLevelApproved_Result> list = null;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {

            //        list = context.usp_IsPreviousProgressLevelApproved(TaskID, ProjectMilestoneID, RevNumber, FileApprovedStatusID).ToList<usp_IsPreviousProgressLevelApproved_Result>();
            //        if (list.Count > 0)
            //        {
            //            foreach (var item in list)
            //            {
            //                strPreviousProgressLevel = strPreviousProgressLevel + item.ProgressLevel + ",";
            //            }
            //        }
            //        strPreviousProgressLevel = strPreviousProgressLevel.TrimEnd(',');
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
            return strPreviousProgressLevel;
        }











        public IList<usp_getProgressLevelByProjectID_Result> getProgressLevelByProjectID(int ProjectID)
        {
            IList<usp_getProgressLevelByProjectID_Result> list = null;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        int TaskstatusID = Convert.ToInt32(Common.TaskStatusID.SendToFocalPoint);
            //        list = context.usp_getProgressLevelByProjectID(ProjectID, TaskstatusID).ToList<usp_getProgressLevelByProjectID_Result>();
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
            return list;
        }

        public static int CheckValidation(int ProjectID)
        {
            int icoint = 0;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        var val = (from a in context.ProjectTaskLists
            //                   where (a.DepatmentID == 0 || a.DepatmentID == 0 || a.TaskTypeID == 0) && a.ProjectID == ProjectID
            //                   select a).Count();
            //        if (val == 0)
            //            icoint = 1;
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
            return icoint;
        }


        public static Boolean IsDuplicateProjectMileStone(int ProjectID, String Acronym, decimal Weightage, int PkID, String TaskTypeID)
        {
            Boolean res = true;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var list = context.uspIsDuplicateProjectMileStone(ProjectID, Acronym, Weightage, PkID, TaskTypeID).ToList<uspIsDuplicateProjectMileStone_Result>();
            //    if (list.Count > 0)
            //    {
            //        res = false;
            //    }
            //}
            return res;
        }

        public List<TaskMilestoneTargetDate> getTaskMilestoneTargetDatesByProjectID(int ProjectID)
        {
            List<TaskMilestoneTargetDate> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{

                //    var query = from q in context.TaskMilestoneTargetDates
                //                join
                //                    r in context.ProjectTaskLists on q.TaskID equals r.ProjectTaskID
                //                where r.ProjectID == ProjectID
                //                select q;

                //    list = query.ToList<TaskMilestoneTargetDate>();
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

        public List<usp_VOWD_Chart_Result> getVOWDChartData(DateTime FromDate, DateTime ToDate, int Dept, int Desgn, int ClientAsset, int Project, string GroupBy, string groupItem, int ClientID)
        {
            List<usp_VOWD_Chart_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_VOWD_Chart(FromDate, ToDate, Dept, Desgn, ClientAsset, Project, GroupBy, groupItem, ClientID).ToList<usp_VOWD_Chart_Result>();
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
        public List<SP_ProjectResourceOverLoading_Result> getProjectResourceLoadingData(DateTime FromDate, DateTime ToDate, int ProjectID, int UserID, string leveloverloading, string display)
        {
            List<SP_ProjectResourceOverLoading_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.SP_ProjectResourceOverLoading(FromDate, ToDate, ProjectID, UserID, leveloverloading, display).ToList<SP_ProjectResourceOverLoading_Result>();
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


        public List<usp_PT_VS_NPT_CHART_Result> getPTNPTCHART(DateTime FromDate, DateTime ToDate, int Dept, int Desgn, int ClientAsset, int Project, int ClientId)
        {
            List<usp_PT_VS_NPT_CHART_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_PT_VS_NPT_CHART(FromDate, ToDate, Dept, Desgn, ClientAsset, Project, ClientId).ToList<usp_PT_VS_NPT_CHART_Result>();
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

        public static Boolean IsDuplicateProjectMileStoneNew(int ProjectID, String Acronym, decimal Weightage, int PkID, String TaskTypeID)
        {
            Boolean res = true;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    List<ProjectMilestone> list = null;
            //    if (PkID == 0)
            //        list = context.ProjectMilestones.Where(c => c.ProjectMilestone1.ToUpper() == Acronym.ToUpper() && c.ProjectID == ProjectID).ToList<ProjectMilestone>();
            //    else
            //        list = context.ProjectMilestones.Where(c => c.ProjectMilestone1.ToUpper() == Acronym.ToUpper() && c.ProjectID == ProjectID && c.ProjectMilestoneID != PkID).ToList<ProjectMilestone>();
            //    //var list = context.uspIsDuplicateProjectMileStoneNew(ProjectID, Acronym, Weightage, PkID, TaskTypeID).ToList<uspIsDuplicateProjectMileStoneNew_Result>();
            //    if (list.Count > 0)
            //    {
            //        res = false;
            //    }
            //}
            return res;
        }

        public List<ProjectMilestone> GetProgressLevelDetailsByProjectID(int projectID)
        {
            List<ProjectMilestone> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.ProjectMilestones.Where(c => c.ProjectID == projectID).ToList<ProjectMilestone>();
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


        public int GetMilestoneIDFromRevisionID(int RevisionID)
        {
            int milestoneID = 0;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    int milestoneID = (int)context.RevisionFiles.Where(x => x.RevisionID == RevisionID).SingleOrDefault().StatusID;
            ////    return milestoneID;
            ////}
            return milestoneID;
        }
    }
}
