using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public class BLUploadDeliverableFile : IBLUploadDeliverableFile
    {


        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<UploadDeliverableFile> _uploadDeliverableFile;

        public BLUploadDeliverableFile(WorkpackDBContext context, IGenericDataRepository<UploadDeliverableFile> uploadDeliverableFile)
        {
            _context = context;
            _uploadDeliverableFile = uploadDeliverableFile;
        }








        public IList<UploadDeliverableFile> GetAllUploadDeliverableFile()
        {
            return _uploadDeliverableFile.GetAll();
        }



        public string GetUploaderInfo(int uploadDeliverableFileID, DateTime? createdon = null)
        {
            string str = "";
            ////UploadDeliverableFile lst = null;
            ////BLUserRepository objuser = new BLUserRepository();
            ////dynamic Userlst = null;
            ////try
            ////{

            ////    lst = GetUploadDeliverableFileByID(uploadDeliverableFileID);
            ////    if (lst != null)
            ////    {
            ////        string create = createdon != null ? Convert.ToDateTime(createdon).ToString("dd/MM/yyyy") : Convert.ToDateTime(lst.CreatedOn).ToString("dd/MM/yyyy");


            ////        if (lst.CreatedBy.Contains("@"))
            ////        {
            ////            Userlst = objuser.GetExuserByeEmailID(lst.CreatedBy);
            ////            str = "Uploaded By - " + Userlst.ExUser1 + " On - " + create;
            ////        }
            ////        else
            ////        {
            ////            Userlst = objuser.GetuserByID(Convert.ToInt32(lst.CreatedBy));
            ////            str = "Uploaded By - " + Userlst.FirstName + " " + Userlst.LastName + " On - " + create;
            ////        }
            ////    }
            ////    return str;
            ////}
            ////catch (Exception ex)
            ////{
            ////    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            ////    throw new Exception("Record not added.");
            ////}
            return str;

        }

        public class ListCreatedOnRevision
        {
            public DateTime? CreatedOn { get; set; }
            public int? RevisionID { get; set; }


        }
        public OperationResult GetLatesRevisionTabFilesAtSUBStage(int FileID, int RevNo)
        {
            List<UploadDeliverableFile> lst = null;
            OperationResult result = new OperationResult();
            //using (var context = new Cubicle_EntityEntities())
            //{

                
            //    int? delID = context.UploadDeliverableFiles.Where(a => a.UploadDeliverableFileID == FileID).Select(a => a.DeliverableListID).FirstOrDefault();
            //    List<ListCreatedOnRevision> list = null;
            //    list = (from RF in context.RevisionFiles
            //            join UF in context.UploadDeliverableFiles
            //            on RF.RevisionID equals UF.RevisionID
            //            where RF.DeliverableID == delID && RF.RevNumber == RevNo
            //            select new ListCreatedOnRevision
            //            {
            //                RevisionID = UF.RevisionID,
            //                CreatedOn = UF.CreatedOn
            //            }).ToList();
            //    var revid = (from li in list
            //                 group li by li.RevisionID into g
            //                 select new { RevisionID = g.Key, CreatedOn = g.Max(x => x.CreatedOn) }).OrderByDescending(a => a.CreatedOn).Select(a => a.RevisionID).FirstOrDefault();

            //    lst = (from UF in context.UploadDeliverableFiles
            //           where UF.RevisionID == revid
            //           select (UF)).ToList<UploadDeliverableFile>();

            //    List<object> data = (from li in lst
            //                         select new { li.FileName, li.FilePath, li.FileSize, li.UploadDeliverableFileID }).ToList<object>();

            //    result.list.Add(data);

            //}

            return result;
        }
        public OperationResult GetLatestRevisionTabFilesAtSUBStage(int FileID)
        {


            OperationResult objcopyfiledata = null;
            //BLUploadDeliverableFile objbl = new BLUploadDeliverableFile();
            //IList<SP_GENERATE_TABS_Result> ObjTabs = BLPageCommentDetailRepository.GenerateTabs(Convert.ToString(HttpContext.Current.Session["UserID"]), "", FileID).ToList<SP_GENERATE_TABS_Result>();
            //var tabs = ObjTabs.Select(p => p.Tabs).Distinct().ToArray();
            //var activetab = ObjTabs.Where(c => c.FileID == FileID).SingleOrDefault().Tabs;
            //string[] actTab = null;
            //actTab = activetab.Split('_');
            //if (actTab.Count() == 1)
            //{
            //    string Stage = actTab[0];
            //    if (Stage == "SUB")
            //    {

            //        objcopyfiledata = objbl.GetLatesRevisionTabFilesAtSUBStage(FileID, 1);
            //    }
            //}
            //else if (actTab.Count() == 2)
            //{
            //    string Stage = actTab[0];
            //    string RevNo = actTab[1];
            //    if (Stage == "SUB")
            //    {
            //        int RevisionNo = Convert.ToInt32(RevNo) + 1;
            //        objcopyfiledata = objbl.GetLatesRevisionTabFilesAtSUBStage(FileID, RevisionNo);
            //    }
            //}
            return objcopyfiledata;
        }

        public List<object> GetAllFilesofsameTaskbyFileid(int fileId)
        {

            List<object> udf1 = null;
            List<object> udf2 = null;
            List<object> udf = null;


            ////int? delid = null;
            ////int? CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);


            ////using (var context = new Cubicle_EntityEntities())
            ////{

            ////    try
            ////    {



            ////        var projectid = context.Projects.Where(a => a.CompanyId == CompanyId).Select(a => a.ProjectID).ToList();
            ////        udf1 = (from udfl in context.UploadDeliverableFiles
            ////                join PT in context.ProjectTaskLists
            ////                on udfl.DeliverableListID equals PT.ProjectTaskID
            ////                join PM in context.ProjectMilestones
            ////                on udfl.MilestoneID equals PM.ProjectMilestoneID
            ////                where projectid.Contains(PT.ProjectID) && udfl.MilestoneID > 0
            ////                select new
            ////                {
            ////                    UploadDeliverableFileID = udfl.UploadDeliverableFileID,
            ////                    FileName = udfl.FileName,
            ////                    result = udfl.FileName + " - " + PM.ProjectMilestone1 + " - " + PT.TaskName
            ////                }
            ////               ).ToList<object>();

            ////        udf2 = (from udfl in context.UploadDeliverableFiles
            ////                join PT in context.ProjectTaskLists
            ////                on udfl.DeliverableListID equals PT.ProjectTaskID
            ////                join RF in context.RevisionFiles
            ////                on udfl.RevisionID equals RF.RevisionID
            ////                where projectid.Contains(PT.ProjectID) && udfl.RevisionID > 0
            ////                select new
            ////                {
            ////                    UploadDeliverableFileID = udfl.UploadDeliverableFileID,
            ////                    FileName = udfl.FileName,
            ////                    result = udfl.FileName + " - " + RF.RevisionNo + " - " + PT.TaskName
            ////                }
            ////               ).ToList<object>();

            ////        udf = udf1.Union(udf2).ToList<object>();


            ////    }

            ////    catch (Exception ex)
            ////    {
            ////    }

            ////}
            return udf;


        }

        public int UploadFiledata(string DocumentTitle, string ProjectNo, string ProjectName, int CompanyID, string DocType, string Revision, string Version, string DocNo, string UploadFilePath, string FileName, string FileExt, int FileSize, int UserID)
        {
            int FileID = 0;

            try
            {

                ////using (var Context = new Cubicle_EntityEntities())
                ////{
                ////    using (var context = new Cubicle_EntityEntities())
                ////    {
                ////        ObjectParameter uploadFileID = new ObjectParameter("uploadFileID", typeof(int));
                ////        var UploadDeliverableFileID = context.SP_QuickUpload_Send_File(DocumentTitle, ProjectNo, ProjectName, CompanyID, DocType, Revision, Version, DocNo, UploadFilePath, FileName, FileExt, FileSize, UserID, uploadFileID);
                ////        FileID = Convert.ToInt32(uploadFileID.Value);
                ////    }
                ////}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return FileID;
        }

        public static string GetProgressLevelByFileID(int FileID)
        {
            string res = "";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var file = (from f in db.UploadDeliverableFiles where f.UploadDeliverableFileID == FileID select f).FirstOrDefault();
                //    if (file != null)
                //    {
                //        if (file.RevisionID == 0)
                //        {
                //            res = (from r in db.ProjectMilestones where r.ProjectMilestoneID == file.MilestoneID select r.MileStone).FirstOrDefault();
                //        }
                //        else
                //        {
                //            res = (from r in db.RevisionFiles where r.RevisionID == file.RevisionID select r.RevisionNo).FirstOrDefault();
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }
        public static string GetProgressLevelByMileStoneID(int MilestoneID, int RevisionID)
        {
            string res = "";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{

                //    if (RevisionID == 0)
                //    {
                //        res = (from r in db.ProjectMilestones where r.ProjectMilestoneID == MilestoneID select r.MileStone).FirstOrDefault();
                //    }
                //    else
                //    {
                //        res = (from r in db.RevisionFiles where r.RevisionID == RevisionID select r.RevisionNo).FirstOrDefault();
                //    }

                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }
        public static string GetProgressLevelByMilestoneID(int MilestoneID)
        {
            string res = "";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{

                //    res = (from r in db.ProjectMilestones where r.ProjectMilestoneID == MilestoneID select r.MileStone).FirstOrDefault();

                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }
        public static string GetProgressLevelByRevisionID(int RevisionID)
        {
            string res = "";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{

                //    res = (from r in db.RevisionFiles where r.RevisionID == RevisionID select r.RevisionNo).FirstOrDefault();

                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }


        public bool CheckIfDuplicateFileInCurrentTab(int DeliverableID, int MilestoneID, int RevisionID, string FileName, string FileExtension)
        {
            bool result = false;
            List<UploadDeliverableFile> lstfile = new List<UploadDeliverableFile>();
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    if (Convert.ToInt32(RevisionID) > 0)
            ////    {
            ////        lstfile = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.MilestoneID == 0 && a.RevisionID == RevisionID && a.FileExtention.ToUpper() == FileExtension.ToUpper()).ToList();
            ////    }
            ////    else
            ////    {
            ////        lstfile = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.MilestoneID == MilestoneID && a.RevisionID == 0 && a.FileExtention.ToUpper() == FileExtension.ToUpper()).ToList();
            ////    }
            ////}

            if (lstfile.Where(a => a.FileName == FileName).Count() > 0)
                result = true;
            return result;

        }

        public bool CheckIfDuplicateFileInCurrentTab(int DeliverableID, int MilestoneID, int RevisionID, List<UploadDeliverableFile> UploadDeliverableFile)
        {
            bool result = false;
            List<UploadDeliverableFile> lstfile = new List<UploadDeliverableFile>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (Convert.ToInt32(RevisionID) > 0)
            //    {
            //        lstfile = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.MilestoneID == 0 && a.RevisionID == RevisionID).ToList();
            //    }
            //    else
            //    {
            //        lstfile = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.MilestoneID == MilestoneID).ToList();
            //    }
            //}

            var test2NotInTest1 = lstfile.Where(t2 => UploadDeliverableFile.Any(t1 => t2.FileName.Contains(t1.FileName) && t2.FileExtention.Contains(t1.FileExtention)));

            if (test2NotInTest1.Count() > 0)
                result = true;
            return result;

        }


        public int GetFileCountInCurrentTab(int DeliverableID, int MilestoneID, int RevisionID, string FileName, string FileExtension)
        {
            int count = 0;
            List<UploadDeliverableFile> lstfile = new List<UploadDeliverableFile>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (Convert.ToInt32(RevisionID) > 0)
            //    {
            //        lstfile = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.MilestoneID == 0 && a.RevisionID == RevisionID && a.FileExtention.ToUpper() == FileExtension.ToUpper()).ToList();
            //    }
            //    else
            //    {
            //        lstfile = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.MilestoneID == MilestoneID && a.RevisionID == 0 && a.FileExtention.ToUpper() == FileExtension.ToUpper()).ToList();
            //    }
            //}

            if (lstfile.Where(a => a.FileName == FileName).Count() > 0)
            {
                for (int i = 0; i < lstfile.Count; i++)
                {
                    string namestring = lstfile[i].FileName;
                    int lastIndexofOpenParenth = namestring.LastIndexOfAny(new char[] { '(' });
                    int lastIndexofCloseParenth = namestring.LastIndexOfAny(new char[] { ')' });
                    if (lastIndexofOpenParenth != -1 && lastIndexofCloseParenth != -1)
                    {
                        string _fname = namestring.Substring(0, lastIndexofOpenParenth);
                        string _fcount = namestring.Substring(lastIndexofOpenParenth + 1, lastIndexofCloseParenth - lastIndexofOpenParenth - 1);
                        int n;
                        bool isNumeric = int.TryParse(_fcount, out n);
                        if (_fname == FileName && isNumeric)
                        {
                            count = n + 1;
                        }
                    }
                    else
                    {
                        if (namestring == FileName)
                        {
                            count++;

                        }

                    }
                }
            }
            else
            {
                count = 0;
            }

            return count;
        }


        public UploadDeliverableFile GetUploadDeliverableFileByID(int uploadDeliverableFileID)
        {
            try
            {
                return _uploadDeliverableFile.GetSingle(d => d.UploadDeliverableFileID == uploadDeliverableFileID);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public UploadDeliverableFile GetUploadDeliverableDwgfileid(int Dwgfileid)
        {
            UploadDeliverableFile udf = null;
            
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    return context.UploadDeliverableFiles.Where(c => c.Dwgfileid == Dwgfileid).OrderByDescending(c => c.CreatedOn).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return udf;
        }

        public List<UploadDeliverableFile> GetUploadDeliverableListByDeliverableID(int DeliverableID)
        {
            List<UploadDeliverableFile> lst = null;
            //List<UploadDeliverableFile> lstBookedQtyFile = null;
            try
            {
                //////using (var context = new Cubicle_EntityEntities())
                //////{
                   


                //////    lst = context.UploadDeliverableFiles.Where(c => c.DeliverableListID == DeliverableID).OrderByDescending(c => c.CreatedOn).ToList<UploadDeliverableFile>();
                    

                //////}
                return lst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public void AddUploadDeliverableFile(params UploadDeliverableFile[] UploadDeliverableFile)
        {
            try
            {
                _uploadDeliverableFile.Add(UploadDeliverableFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateUploadDeliverableFile(params UploadDeliverableFile[] uploadDeliverableFile)
        {
            try
            {
                _uploadDeliverableFile.Update(uploadDeliverableFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public ProjectTaskList GetDeliverableListByFileID(int FileID)
        {
            ProjectTaskList Dellist = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    Dellist = (from d in db.ProjectTaskLists where d.ProjectTaskID == (from f in db.UploadDeliverableFiles where f.UploadDeliverableFileID == FileID select f.DeliverableListID).FirstOrDefault() select d).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
            }
            return Dellist;
        }


        public List<UploadDeliverableFile> checkuploaddelivarablefilesifexistes(int projectid)
        {
            List<UploadDeliverableFile> udf = null;

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    try
            //    {

            //        udf = (from udfl in context.UploadDeliverableFiles
            //               join pl in context.ProjectTaskLists
            //                   on udfl.DeliverableListID equals pl.ProjectTaskID
            //               where pl.ProjectID == projectid
            //               select udfl).ToList<UploadDeliverableFile>();

            //    }

            //    catch (Exception ex)
            //    {
            //    }

            //}
            return udf;


        }
        public void RemoveUploadDeliverableFile(params UploadDeliverableFile[] uploadDeliverableFile)
        {
            try
            {
                _uploadDeliverableFile.Remove(uploadDeliverableFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public List<UploadDeliverableFile> GetUploadDeliverableFileByRevMilID(string Rtype, int MileStoneID, int DeliverableID)
        {
            List<UploadDeliverableFile> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    if (Rtype == "R")
            //    {
            //        lst = context.UploadDeliverableFiles.Where(a => a.RevisionID == MileStoneID && a.DeliverableListID == DeliverableID).ToList<UploadDeliverableFile>();
            //    }
            //    else if (MileStoneID != 0)
            //    {
            //        lst = context.UploadDeliverableFiles.Where(a => a.MilestoneID == MileStoneID && a.DeliverableListID == DeliverableID).ToList<UploadDeliverableFile>();
            //    }
            //}

            return lst;
        }

        public List<UploadDeliverableFile> GetAllUploadDeliverableFileByRevMilID(int RevisionID, int MileStoneID, int DeliverableID)
        {
            List<UploadDeliverableFile> lst = null;
            //List<PageCommentDetail> lstPageCommentDetail = null;
            //List<UploadDeliverableFile> lstBookedQtyFile = null;
            //string UserID = Convert.ToString(HttpContext.Current.Session["UserID"]);
            //using (var context = new Cubicle_EntityEntities())
            //{


            //    BLTaskListRepository blObj = new BLTaskListRepository();
            //    int ProjectID = blObj.getTaskDetailsByTaskId(DeliverableID).ProjectID;

            //    if (RevisionID != 0)
            //    {
            //        lst = context.UploadDeliverableFiles.Where(a => a.RevisionID == RevisionID && a.DeliverableListID == DeliverableID).ToList<UploadDeliverableFile>();
            //    }
            //    else if (MileStoneID != 0)
            //    {
            //        lstBookedQtyFile = (from tm in context.TaskMilestoneBookedQties
            //                            join udf in context.UploadDeliverableFiles on new { a = tm.FileID } equals new { a = udf.UploadDeliverableFileID }
            //                            where tm.TaskID == DeliverableID && tm.MileStoneID == MileStoneID
            //                            select udf).ToList();



            //        lst = context.UploadDeliverableFiles.Where(a => a.MilestoneID == MileStoneID && a.DeliverableListID == DeliverableID).ToList<UploadDeliverableFile>();

            //        lst = lst.Union(lstBookedQtyFile).ToList();
            //    }

            //    lst.Where(w => w.Version > 0).ToList().ForEach(s => s.FileName = s.FileName + "_" + s.Version);
            //    //lst= lst.Union(blupdwg.GetDwgfilesonUploadeliveravlefileid(lst.Select(a => a.UploadDeliverableFileID).ToArray())).ToList<UploadDeliverableFile>();

            //    foreach (var l in lst)
            //    {
            //        string f = "";
            //        //l.IssystemGenerated = false;
            //        //l.Dwgpdffileid = 0;
            //        int count = 0;
            //        BLMilestoneStakeholder bms = new BLMilestoneStakeholder();
            //        List<MilestonesStakeHolder> lstStakeholder = bms.GetStakeHolderByMilestoneID(UserID, ProjectID, Convert.ToInt32(MileStoneID), RevisionID, Convert.ToInt32(DeliverableID));
            //        int stkCount = 0;
            //        stkCount = lstStakeholder.Count();

            //        if (stkCount > 0)
            //            l.flag = "SH";
            //        else
            //        {
            //            count = 0;
            //            count = context.FileCheckers.Where(p => p.UploadDeliverableFileID == l.UploadDeliverableFileID && p.UserID == UserID && p.flag == "CH").Count();
            //            if (count > 0)
            //                l.flag = "CH";
            //        }

            //        lstPageCommentDetail = context.PageCommentDetails.Where(a => a.UploadDeliverableFileID == l.UploadDeliverableFileID).ToList<PageCommentDetail>();
            //        if (lstPageCommentDetail.Count > 0)
            //        {
            //            var varstatust = lstPageCommentDetail.Min(c => c.CommentStatus);
            //            l.Status = Convert.ToInt32(varstatust); ;
            //        }
            //        else
            //        {
            //            l.Status = 0;
            //        }


            //    }
            //}
            return lst;
        }

        public bool IsStakeHolder(int DeliverableID, int MilestoneID, int RevisionID, int ProjectId)
        {
            //List<UploadDeliverableFile> lst = null;
            //bool IsStakeHolder = false;
            //string UserID = Convert.ToString(HttpContext.Current.Session["UserID"]);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int count = 0;
            //    if (RevisionID > 0)
            //    {
            //        count = context.MilestonesStakeHolders.Where(p => p.TaskID == (int)DeliverableID && p.UserID == UserID && p.RevisionID == RevisionID).Count();
            //        if (count > 0)
            //        {
            //            IsStakeHolder = true;
            //        }
            //    }
            //    else
            //    {
            //        count = context.MilestonesStakeHolders.Where(p => p.TaskID == (int)DeliverableID && p.UserID == UserID && p.MilestoneID == MilestoneID).Count();
            //        if (count > 0)
            //        {
            //            IsStakeHolder = true;
            //        }
            //    }
            //}
            //return IsStakeHolder;











            List<MilestonesStakeHolder> lst = null;
            bool IsStakeHolder = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    string UserID = Convert.ToString(HttpContext.Current.Session["UserID"]);
            //    if (RevisionID > 0)
            //    {
            //        lst = context.MilestonesStakeHolders.Where(a => a.UserID == UserID && a.ProjectID == ProjectId && a.RevisionID == RevisionID).ToList<MilestonesStakeHolder>();
            //    }
            //    else
            //    {
            //        lst = context.MilestonesStakeHolders.Where(a => a.UserID == UserID && a.ProjectID == ProjectId && a.MilestoneID == MilestoneID).ToList<MilestonesStakeHolder>();
            //    }
            //    if (lst.Count() > 0 && (lst.Where(a => a.Flag.Trim() == "MS").Count() > 0 || lst.Where(a => (a.Flag.Trim() == "DS") && a.TaskID == (int)DeliverableID).Count() > 0))
            //    {
            //        return IsStakeHolder = true;
            //    }
            //    else
            //    {
            //        IsStakeHolder = false;
            //    }
            //}
            return IsStakeHolder;






        }

        public List<string> ListOftakeHolder(int DeliverableID, int MilestoneID, int RevisionID, int ProjectId)
        {
           
            List<MilestonesStakeHolder> lst = null;
            List<string> listuserid = new List<string>();
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    string UserID = Convert.ToString(HttpContext.Current.Session["UserID"]);
            ////    if (RevisionID > 0)
            ////    {
            ////        lst = context.MilestonesStakeHolders.Where(a => a.UserID == UserID && a.ProjectID == ProjectId && a.RevisionID == RevisionID).ToList<MilestonesStakeHolder>();
            ////    }
            ////    else
            ////    {
            ////        lst = context.MilestonesStakeHolders.Where(a => a.UserID == UserID && a.ProjectID == ProjectId && a.MilestoneID == MilestoneID).ToList<MilestonesStakeHolder>();
            ////    }
            ////    if (lst.Count() > 0 && (lst.Where(a => a.Flag.Trim() == "MS").Count() > 0 || lst.Where(a => (a.Flag.Trim() == "DS") && a.TaskID == (int)DeliverableID).Count() > 0))
            ////    {
            ////        foreach (var stakeholeder in lst)
            ////        {
            ////            listuserid.Add(stakeholeder.UserID);
            ////        }

            ////    }
            ////    else
            ////    {
            ////        listuserid = new List<string>();
            ////    }
            ////}

            return listuserid.ToList();


        }

        public bool IsDeliverableChecker(int DeliverableID)
        {

            List<UploadDeliverableFile> lst = null;
            bool IsDeliverableChecker = false;
            ////string UserID = Convert.ToString(HttpContext.Current.Session["UserID"]);



            ////using (var context = new Cubicle_EntityEntities())
            ////{

            ////    lst = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID).ToList<UploadDeliverableFile>();

            ////    foreach (var l in lst)
            ////    {

            ////        int count = 0;
            ////        count = context.FileCheckers.Where(p => p.UploadDeliverableFileID == l.UploadDeliverableFileID && p.UserID == UserID && p.flag == "CH").Count();
            ////        if (count > 0)
            ////        {
            ////            IsDeliverableChecker = true;
            ////        }
            ////    }
            ////}
            return IsDeliverableChecker;
        }


        public int Getcountof_dwgpdffileVersion(int Uploadeliverablefileid)
        {
            ////using (var Context = new Cubicle_EntityEntities())
            ////{
            ////    int count;
            ////    count = Context.UploadDeliverableFiles.Where(a => a.Dwgfileid == Uploadeliverablefileid).Count();

            ///    return count;

            ////}
            int count=0;
            return count;
        }

        public bool IsCheckerRevision(int DeliverableID, int MileStoneID, int RevisionID)
        {

            List<UploadDeliverableFile> lst = null;
            bool IsDeliverableChecker = false;
            //string UserID = Convert.ToString(HttpContext.Current.Session["UserID"]);



            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (RevisionID == 0)
            //    {
            //        lst = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.MilestoneID == (int?)MileStoneID).ToList<UploadDeliverableFile>();
            //    }
            //    else
            //    {
            //        lst = context.UploadDeliverableFiles.Where(a => a.DeliverableListID == DeliverableID && a.RevisionID == (int?)RevisionID).ToList<UploadDeliverableFile>();

            //    }
            //    foreach (var l in lst)
            //    {

            //        int count = 0;
            //        count = context.FileCheckers.Where(p => p.UploadDeliverableFileID == l.UploadDeliverableFileID && p.UserID == UserID && p.flag == "CH").Count();
            //        if (count > 0)
            //        {
            //            IsDeliverableChecker = true;
            //        }
            //    }
            //}
            return IsDeliverableChecker;
        }




        public List<usp_fetchattachmentasperfileid_Result> Getusp_fetchattachmentasperfileid_Result(string uploaddeliverableid, int DeliverableID, int MilestoneId, int RevisionId, string UserID)
        {
            List<usp_fetchattachmentasperfileid_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_fetchattachmentasperfileid(uploaddeliverableid, DeliverableID, MilestoneId, RevisionId, UserID).ToList<usp_fetchattachmentasperfileid_Result>();
            //}
            return lst;
        }
        public List<usp_FetchCheckerAttachment_Result> Getusp_FetchCheckerAttachment_Result(int DeliverableID, int MilestoneId, int RevisionId, String UserID)
        {
            List<usp_FetchCheckerAttachment_Result> lst = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    lst = context.usp_FetchCheckerAttachment(DeliverableID, MilestoneId, RevisionId, UserID).ToList<usp_FetchCheckerAttachment_Result>();
            ////}
            return lst;
        }
        public List<USP_GetUsersDeliverableFileByRevMilID_Result> GetUsersDeliverableFileByRevMilID(int RevisionID, int MileStoneID, string UserID, int DelID)
        {
            List<USP_GetUsersDeliverableFileByRevMilID_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.USP_GetUsersDeliverableFileByRevMilID(RevisionID, MileStoneID, DelID, UserID).ToList<USP_GetUsersDeliverableFileByRevMilID_Result>();
            //}
            return lst;
        }

        //public List<usp_getAllAttachedFiles_Result> GetAllAttachedFileByID(int MilestoneID,int MileStoneID_Or_RevisionID,int DeliverableListID)
        //{
        //    List<usp_getAllAttachedFiles_Result> lst = null;
        //    try
        //    {
        //       using (var context = new Cubicle_EntityEntities())
        //        {
        //            lst = context.usp_getAllAttachedFiles(MilestoneID, MileStoneID_Or_RevisionID, DeliverableListID).ToList<usp_getAllAttachedFiles_Result>();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
        //    }
        //    return lst;
        //}

        public Project getProjectByDeliverableID(int DeliverableID)
        {
            Project prj = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int ProjectID = context.ProjectTaskLists.Where(a => a.ProjectTaskID == DeliverableID).SingleOrDefault().ProjectID;
            //    prj = context.Projects.Where(a => a.ProjectID == ProjectID).SingleOrDefault();
            //}
            return prj;
        }

        public Project getProjectWithCompanyByDeliverableID(int DeliverableID)
        {
            Project prj = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int ProjectID = context.ProjectTaskLists.Where(a => a.ProjectTaskID == DeliverableID).SingleOrDefault().ProjectID;
            //    prj = context.Projects.Include("Company").Where(a => a.ProjectID == ProjectID).SingleOrDefault();
            //}
            return prj;
        }

        public IList<UploadDeliverableFile> GetFilesByDeliverableID(int DeliverableID)
        {
            return _uploadDeliverableFile.GetList(p => p.DeliverableListID == DeliverableID);
        }

        public List<usp_getDeliverablesByID_Result> getDeliverablesByID1(int DeliverableID)
        {
            List<usp_getDeliverablesByID_Result> lst = null;

            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_getDeliverablesByID(DeliverableID).ToList<usp_getDeliverablesByID_Result>();
                //}

            }
            catch (Exception ex)
            {
              //  bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lst;
        }

        public List<usp_getDeliverablesByDeliverableID_Result> getDeliverablesByDelID(int DeliverableID)
        {
            List<usp_getDeliverablesByDeliverableID_Result> lst = null;

            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    lst = context.usp_getDeliverablesByDeliverableID(DeliverableID).ToList<usp_getDeliverablesByDeliverableID_Result>();
                ////}

            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lst;
        }

        public List<usp_getScheduleDetailsByDelID_Result> getScheduleDetails(int DeliverableID)
        {
            List<usp_getScheduleDetailsByDelID_Result> lst = null;

            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_getScheduleDetailsByDelID(DeliverableID).ToList<usp_getScheduleDetailsByDelID_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }

            return lst;
        }

        public static int getLatestFileIDByDeliverableListID(int DeliverableListID)
        {
            int Fileid = 0;

            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    Fileid = (from f in context.UploadDeliverableFiles where f.DeliverableListID == DeliverableListID orderby f.CreatedOn descending select f.UploadDeliverableFileID).FirstOrDefault();   //context.usp_getScheduleDetailsByDelID(DeliverableID).ToList<usp_getScheduleDetailsByDelID_Result>();
                ////}

            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return Fileid;
        }

        public static int getDeliverableListIdByFileID(int FileID)
        {
            int? DeliverableListId = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    DeliverableListId = (from f in context.UploadDeliverableFiles where f.UploadDeliverableFileID == FileID orderby f.CreatedOn descending select f.DeliverableListID).FirstOrDefault();   //context.usp_getScheduleDetailsByDelID(DeliverableID).ToList<usp_getScheduleDetailsByDelID_Result>();
                //}

            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return Convert.ToInt32(DeliverableListId);
        }
        public string GetUploadDeliverableFilePathByID(int uploadDeliverableFileID)
        {
            string path = String.Empty;
            try
            {
                UploadDeliverableFile lst = _uploadDeliverableFile.GetSingle(d => d.UploadDeliverableFileID == uploadDeliverableFileID);
                path = lst.FilePath.Substring(lst.FilePath.IndexOf("projectDocuments"));

            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return "~/" + path;
        }
        public string CheckUserRoleOnFile(string CurrentUserId, string taskOwner, int FileID)
        {
            string res = "";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    if (CurrentUserId == taskOwner)
                //        res = "O";
                //    else
                //    {
                //        int count = db.FileCheckers.Count(p => p.UploadDeliverableFileID == FileID && p.UserID == CurrentUserId && (p.flag == "CH" || p.flag == "CO"));
                //        if (count > 0)
                //            res = "CH";
                //        else
                //        {
                //            res = "";
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return res;
        }





        public Boolean QuickSendEmailToClientUserForComment(int UserID, string UsersEmails, int DeliverableID, int fileID, string Reminder, string ServerUrl)
        {
           // try
            //{
                //string[] strColon = UsersEmails.TrimEnd(';').Split(';');

            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    User user = blUser.GetuserByID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    User dtUsers = null;
            //    dtUsers = blUser.GetuserByID(UserID);
              
            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    User dtAdminData = dtUsers;
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";


            //    for (int i = 0; i < strColon.Length; i++)
            //    {
            //        System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //        string[] str = strColon[i].Split(':');
            //        if (str[1].Trim() == "Y")
            //        {
            //            objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReview);
            //        }
            //        else
            //        {
            //            objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableViewing);
            //        }

            //        FileUrl = String.Empty;
            //        String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));
            //        String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
            //        String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
            //        message.Subject = emailSubject;


            //        string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "> Click here to see deliverable files for all revisions.</a>";

            //        String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //        emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //        emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //        emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //        emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //        emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            //        emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            //        emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            //        emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //        emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));
            //        emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);

            //        UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(fileID));                    
            //        BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //        ProjectMilestone milestone = new ProjectMilestone();
            //        if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //        {
            //            RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //            milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //            emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //            string RevNumber = "";
            //            if (Convert.ToString(revision.RevNumber).Length == 1)
            //            {
            //                RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //            }
            //            emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //        }
            //        else
            //        {

            //            milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));                        
            //            emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //            emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //        }

            //        if (VFile.FileExtention.Contains("pdf"))
            //        {
            //            FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + fileID + "&&UserID=" + Convert.ToString(str[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            //        }

            //        emailDesc = emailDesc.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //        message.Body = emailDesc;
            //        MailAddress mailID = new MailAddress(Convert.ToString(str[0].Trim()));
            //        message.To.Add(mailID);
            //        bool status = Common.GeneralFuntions.SendHtmlEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //        message = null;
            //    }


            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }




        public Boolean SendEmailToClientUserForComment(int UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, string messagedel = null)
        {
            //try
            //{
            //    string[] strColon = UsersEmails.TrimEnd(';').Split(';');
            //    string[] Files = fileID.TrimEnd(',').Split(',');
            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    User user = blUser.GetuserByID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    User dtUsers = null;
            //    dtUsers = blUser.GetuserByID(UserID);

            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    User dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";

            //    if (Reminder == "N")
            //    {
            //        for (int i = 0; i < strColon.Length; i++)
            //        {
            //            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //            string[] str = strColon[i].Split(':');
            //            if (str[1].Trim() == "Y")
            //            {
            //                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReview);
            //            }
            //            else
            //            {
            //                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableViewing);
            //            }

            //            FileUrl = String.Empty;
            //            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
            //            String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
            //            message.Subject = emailSubject;


            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>";

            //            String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //            emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //            emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //            emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //            emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            //            emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            //            emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            //            emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));
            //            emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);

            //            if (!string.IsNullOrEmpty(messagedel) && !String.IsNullOrWhiteSpace(messagedel))
            //                emailDesc = emailDesc.Replace("#Message#", messagedel);
            //            else
            //                emailDesc = emailDesc.Replace("#Message#", "");

            //            Guid objGuid = new Guid();
            //            objGuid = Guid.NewGuid();
            //            String MessageID = "<" + objGuid.ToString() + "@cubicleprojects.com>";
            //            message.Headers.Add("Message-ID", MessageID); //Set Message-ID in Email Header

            //            for (int k = 0; k < Files.Length; k++)
            //            {
            //                UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[k]));


            //                //   message.Headers.Add("In-Reply-To", MessageID);
            //                //message.Headers.Add("References", MessageID);
            //                //  message.Headers.Add("fileID", Files[k].ToString());

            //                //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //                //{
            //                //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //                //}
            //                //else
            //                //{
            //                //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //                //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //                //}

            //                BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //                ProjectMilestone milestone = new ProjectMilestone();
            //                if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //                {
            //                    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                    milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //                    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                    string RevNumber = "";
            //                    if (Convert.ToString(revision.RevNumber).Length == 1)
            //                    {
            //                        RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //                    }
            //                    emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //                }
            //                else
            //                {

            //                    milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                    //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //                    emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //                    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                }

            //                if (VFile.FileExtention.Contains("pdf"))
            //                {
            //                    FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[k] + "&&UserID=" + Convert.ToString(str[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            //                }
            //            }

            //            emailDesc = emailDesc.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //            message.Body = emailDesc;
            //            MailAddress mailID = new MailAddress(Convert.ToString(str[0].Trim()));
            //            message.To.Add(mailID);
            //            bool status = Common.GeneralFuntions.SendHtmlEmailsToClientUserWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);

            //            //System.Net.Mail.SmtpClient mailer = new System.Net.Mail.SmtpClient();
            //            //MailBee.ImapMail.Imap imp = new Imap();

            //            //// Second part of the log represents IMAP session.
            //            //imp.Log.Enabled = true;
            //            //imp.Log.Filename = "C:\\Temp\\log.txt";

            //            //imp.Connect("imap.here.com");
            //            //imp.Login("joe@here.com", "secret");

            //            //try
            //            //{
            //            //    imp.UploadMessage(mailer.Message, "Sent");
            //            //    Console.WriteLine("Uploaded successfully");
            //            //}
            //            //catch (MailBeeImapNegativeResponseException e)
            //            //{
            //            //    Console.WriteLine("Perhaps, can't select folder");
            //            //    if (!string.IsNullOrEmpty(e.HumanReadable))
            //            //    {
            //            //        Console.WriteLine("Server reported: " + e.HumanReadable);
            //            //    }
            //            //    Console.WriteLine();
            //            //    Console.WriteLine("The folders available are:");
            //            //    FolderCollection folders = imp.DownloadFolders();
            //            //    foreach (Folder fold in folders)
            //            //    {
            //            //        Console.WriteLine(fold.Name);
            //            //    }
            //            //}

            //            //imp.Disconnect();



            //            message = null;
            //        }
            //    }
            //    else if (Reminder == "Y")
            //    {
            //        for (int i = 0; i < strColon.Length; i++)
            //        {
            //            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //            objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReminder);

            //            FileUrl = String.Empty;
            //            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));

            //            message.Subject = emailSubject;
            //            String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //            emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //            emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //            emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //            emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            //            emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            //            emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            //            emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));




            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(strColon[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>";
            //            emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);
            //            UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[0]));

            //            //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            //{
            //            //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //            //}
            //            //else
            //            //{
            //            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //            //}

            //            BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            ProjectMilestone milestone = new ProjectMilestone();
            //            if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            {
            //                RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                string RevNumber = "";
            //                if (Convert.ToString(revision.RevNumber).Length == 1)
            //                {
            //                    RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //                }
            //                emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //            }
            //            else
            //            {

            //                milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //                emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //            }
            //            if (VFile.FileExtention.Contains("pdf"))
            //            {
            //                FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[0] + "&UserID=" + Convert.ToString(strColon[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";

            //                // Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "PDFClientViewer.aspx?FileID=" + Files[0] + "&ExClientEmailID=Click here to view or comment on PDF file .</a>";
            //            }

            //            emailDesc = emailDesc.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //            message.Body = emailDesc;
            //            MailAddress mailID = new MailAddress(Convert.ToString(strColon[i].Trim()));
            //            message.To.Add(mailID);
            //            bool status = Common.GeneralFuntions.SendHtmlEmailsToClientUserWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //            message = null;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }



        public Boolean SendEmailToClientUserFromExternal(string UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, string messagedel = null)
        {
            //try
            //{
            //    string[] strColon = UsersEmails.TrimEnd(';').Split(';');
            //    string[] Files = fileID.TrimEnd(',').Split(',');
            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    ExUser user = blUser.GetExuserByeEmailID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    ExUser dtUsers = null;
            //    dtUsers = blUser.GetExuserByeEmailID(UserID);
            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    ExUser dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";

            //    if (Reminder == "N")
            //    {
            //        for (int i = 0; i < strColon.Length; i++)
            //        {
            //            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();




            //            string[] str = strColon[i].Split(':');
            //            if (str[1].Trim() == "Y")
            //            {
            //                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReview);
            //            }
            //            else
            //            {
            //                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableViewingExternal);
            //            }

            //            FileUrl = String.Empty;
            //            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
            //            String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
            //            message.Subject = emailSubject;


            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>";

            //            String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //            emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //            emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //            emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //            emailDesc = emailDesc.Replace("#SenderEmail#", user.ExUser1);
            //            emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));
            //            emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);

            //            if (!string.IsNullOrEmpty(messagedel) && !String.IsNullOrWhiteSpace(messagedel))
            //                emailDesc = emailDesc.Replace("#Message#", messagedel);
            //            else
            //                emailDesc = emailDesc.Replace("#Message#", "");
            //            for (int k = 0; k < Files.Length; k++)
            //            {
            //                UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[k]));
            //                message.Headers.Add("Message-ID", Convert.ToString(Files[k])); //Set Message-ID in Email Header
            //                //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //                //{
            //                //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //                //}
            //                //else
            //                //{
            //                //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //                //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //                //}

            //                BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //                ProjectMilestone milestone = new ProjectMilestone();
            //                if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //                {
            //                    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                    milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //                    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                    string RevNumber = "";
            //                    if (Convert.ToString(revision.RevNumber).Length == 1)
            //                    {
            //                        RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //                    }
            //                    emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //                }
            //                else
            //                {

            //                    milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                    //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //                    emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //                    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                }

            //                if (VFile.FileExtention.Contains("pdf"))
            //                {
            //                    FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[k] + "&&UserID=" + Convert.ToString(str[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            //                }
            //            }
            //            emailDesc = emailDesc.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //            message.Body = emailDesc;
            //            MailAddress mailID = new MailAddress(Convert.ToString(str[0].Trim()));
            //            message.To.Add(mailID);
            //            bool status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //            message = null;
            //        }
            //    }
            //    else if (Reminder == "Y")
            //    {
            //        for (int i = 0; i < strColon.Length; i++)
            //        {
            //            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //            objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReminder);

            //            FileUrl = String.Empty;
            //            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));

            //            message.Subject = emailSubject;
            //            String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //            emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //            emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //            emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //            emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.ExUser1));
            //            emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));




            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(strColon[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>";
            //            emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);
            //            UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[0]));
            //            message.Headers.Add("Message-ID", Files[0].ToString()); //Set Message-ID in Email Header
            //            //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            //{
            //            //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //            //}
            //            //else
            //            //{
            //            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //            //}

            //            BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            ProjectMilestone milestone = new ProjectMilestone();
            //            if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            {
            //                RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                string RevNumber = "";
            //                if (Convert.ToString(revision.RevNumber).Length == 1)
            //                {
            //                    RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //                }
            //                emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //            }
            //            else
            //            {

            //                milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //                emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //            }
            //            if (VFile.FileExtention.Contains("pdf"))
            //            {
            //                FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[0] + "&UserID=" + Convert.ToString(strColon[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";

            //                // Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "PDFClientViewer.aspx?FileID=" + Files[0] + "&ExClientEmailID=Click here to view or comment on PDF file .</a>";
            //            }

            //            emailDesc = emailDesc.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //            message.Body = emailDesc;
            //            MailAddress mailID = new MailAddress(Convert.ToString(strColon[i].Trim()));
            //            message.To.Add(mailID);
            //            bool status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //            message = null;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }


        public String SendEmailToClientUserForCommentForEmailDetails(int UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, List<FileCheckerEmailDetail> lstEmailDetail, string messagedel = null, string subject = null)
        {
            String MessageID = "";

            //string Orgmessagedel = messagedel;

            //try
            //{
            //    string[] strColon = UsersEmails.TrimEnd(';').Split(';');
            //    string[] Files = fileID.TrimEnd(',').Split(',');
            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    User user = blUser.GetuserByID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();
            //    User dtUsers = null;
            //    dtUsers = blUser.GetuserByID(UserID);
            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    User dtAdminData = dtUsers;
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    BLFileCheckerRepository objFileChecker = new BLFileCheckerRepository();
            //    BLFileCheckerEmailDetailRepository objEmailDetail = new BLFileCheckerEmailDetailRepository();
            //    List<string> allexusers = new List<string>();
            //    String emailSubject = subject;
            //    string FileUrl = "";
            //    if (Reminder == "N")
            //    {
            //        if (!string.IsNullOrEmpty(strColon[0]))
            //        {
            //            for (int i = 0; i < strColon.Length; i++)
            //            {
            //                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //                string[] str = strColon[i].Split(':');
            //                allexusers.Add(str[0]);

            //                List<string> lstuseremail = new List<string>();
            //                if (str[1].Trim() == "Y")
            //                {
            //                    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReview);
            //                }
            //                else
            //                {
            //                    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableViewing);
            //                }

            //                FileUrl = String.Empty;


            //                //objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //                message.Subject = emailSubject;
            //                string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "&FileID=" + Files[0] + " target=_blank> Click here to see deliverable files for all revisions.</a>";

            //                messagedel = Orgmessagedel;
            //                messagedel = messagedel.Replace("#DeliverableDetailLink#", delirabledetail);
            //                Guid objGuid = new Guid();
            //                objGuid = Guid.NewGuid();
            //                MessageID = "<" + objGuid.ToString() + "@cubicleprojects.com>";
            //                message.Headers.Add("Message-ID", MessageID); //Set Message-ID in Email Header

            //                List<FileChecker> objchecker = new List<FileChecker>();
            //                List<FileChecker> objcheckerEmailDetail = new List<FileChecker>();
            //                for (int k = 0; k < Files.Length; k++)
            //                {
            //                    UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[k]));

            //                    //FileCheckerEmailDetail fc = objEmailDetail.UpdateCheckerMessageID(Convert.ToString(str[0].Trim()), Convert.ToInt32(Files[k]), MessageID, emailSubject);
            //                    //objcheckerEmailDetail.Add(fc);





            //                    if (VFile.FileExtention.Contains("pdf") || VFile.FileExtention.Contains("dwg"))
            //                    {
            //                        FileUrl = FileUrl + "<a href='" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[k] + "&&UserID=" + Convert.ToString(str[0].Trim()) + "' target=_blank> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            //                    }

            //                    if (VFile.FileExtention.Contains("aspx"))
            //                    {
            //                        FileUrl = FileUrl + "<a href='" + Convert.ToString(ServerUrl) + "ProcurementDocument.aspx?FileID=" + Files[k] + "&&UserID=" + Convert.ToString(str[0].Trim()) + "' target=_blank> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            //                    }
            //                }

            //                messagedel = messagedel.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //                message.Body = messagedel;


            //                //objchecker.ForEach(a => a.MessageBody = messagedel);


            //                // objFileChecker.UpdateUploadDeliverableFile(objchecker.ToArray());

            //                var lstUser = lstEmailDetail.Where(a => a.UserID == Convert.ToString(str[0].Trim())).ToList();
            //                lstUser.ForEach(a => a.MessageSubject = objEmailDetail.UpdateCheckerMessageID(a.FileCheckerID, a.SentCounter, MessageID, emailSubject).MessageSubject);
            //                lstUser.ForEach(a => a.MessageID = objEmailDetail.UpdateCheckerMessageID(a.FileCheckerID, a.SentCounter, MessageID, emailSubject).MessageID);
            //                lstUser.ForEach(a => { a.MessageBody = messagedel; a.EntityState = DominModel.EntityState.Modified; });
            //                objEmailDetail.UpdateUploadDeliverableFile(lstUser.ToArray());


            //                MailAddress mailID = new MailAddress(Convert.ToString(str[0].Trim()));
            //                message.To.Add(mailID);
            //                bool status = Common.GeneralFuntions.SendHtmlEmailsToClientUserWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);



            //                message = null;
            //            }
            //        }
            //        FileUrl = "";
            //        //var lstIUser = lstEmailDetail.Where(a => !allexusers.Contains(a.UserID)).ToList();
            //        foreach (var e in lstEmailDetail)
            //        {

            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadDeliverables.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "  target=_blank> Click here to see deliverable files for all revisions.</a>";

            //            messagedel = Orgmessagedel;
            //            messagedel = messagedel.Replace("#DeliverableDetailLink#", delirabledetail);
            //            //for (int k = 0; k < Files.Length; k++)
            //            //{
            //            //    UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[k]));
            //            //    if (VFile.FileExtention.Contains("pdf"))
            //            //    {
            //            //        FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[k] + "&&UserID=" + Convert.ToString(e.UserID) + "  target=_blank> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            //            //    }
            //            //}

            //            //messagedel = messagedel.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));

            //            var lstIUPUser = lstEmailDetail.Where(a => a.UserID == Convert.ToString(e.UserID.Trim())).ToList();
            //            lstIUPUser.ForEach(a => { a.MessageBody = messagedel; a.EntityState = DominModel.EntityState.Modified; });
            //            lstIUPUser.ForEach(a => a.MessageSubject = objEmailDetail.UpdateCheckerMessageID(a.FileCheckerID, a.SentCounter, MessageID, emailSubject).MessageSubject);
            //            objEmailDetail.UpdateUploadDeliverableFile(lstIUPUser.ToArray());
            //        }

            //    }
            //    else if (Reminder == "Y")
            //    {
            //        for (int i = 0; i < strColon.Length; i++)
            //        {
            //            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //            objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReminder);

            //            FileUrl = String.Empty;
            //            emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));

            //            message.Subject = emailSubject;
            //            Guid objGuid = new Guid();
            //            objGuid = Guid.NewGuid();
            //            MessageID = "<" + objGuid.ToString() + "@cubicleprojects.com>";
            //            message.Headers.Add("Message-ID", MessageID); //Set Message-ID in Email Header
            //            //String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //            //emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //            //emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            //emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            //emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //            //emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //            //emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            //            //emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            //            //emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            //            //emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));
            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(strColon[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>";
            //            messagedel = messagedel.Replace("#DeliverableDetailLink#", delirabledetail);
            //            UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[0]));

            //            //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            //{
            //            //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //            //}
            //            //else
            //            //{
            //            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //            //}

            //            //BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            //ProjectMilestone milestone = new ProjectMilestone();
            //            //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            //{
            //            //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //            //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //            //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //            //    string RevNumber = "";
            //            //    if (Convert.ToString(revision.RevNumber).Length == 1)
            //            //    {
            //            //        RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //            //    }
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //            //}
            //            //else
            //            //{

            //            //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //            //    //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //            //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //            //}
            //            if (VFile.FileExtention.Contains("pdf"))
            //            {
            //                FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[0] + "&UserID=" + Convert.ToString(strColon[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";

            //                // Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "PDFClientViewer.aspx?FileID=" + Files[0] + "&ExClientEmailID=Click here to view or comment on PDF file .</a>";
            //            }

            //            messagedel = messagedel.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //            message.Body = messagedel;
            //            MailAddress mailID = new MailAddress(Convert.ToString(strColon[i].Trim()));
            //            message.To.Add(mailID);
            //            bool status = Common.GeneralFuntions.SendHtmlEmailsToClientUserWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //            message = null;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return MessageID;
        }



        public Boolean SendEmailToClientUserFromExternalForEmailDetails(string UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl, string messagedel = null)
        {
            //try
            //{
            //    string[] strColon = UsersEmails.TrimEnd(';').Split(';');
            //    string[] Files = fileID.TrimEnd(',').Split(',');
            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    ExUser user = blUser.GetExuserByeEmailID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    ExUser dtUsers = null;
            //    dtUsers = blUser.GetExuserByeEmailID(UserID);
            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    ExUser dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";

            //    if (Reminder == "N")
            //    {
            //        for (int i = 0; i < strColon.Length; i++)
            //        {
            //            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();




            //            string[] str = strColon[i].Split(':');
            //            if (str[1].Trim() == "Y")
            //            {
            //                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReview);
            //            }
            //            else
            //            {
            //                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableViewingExternal);
            //            }

            //            FileUrl = String.Empty;
            //            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            //String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
            //            //String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
            //            message.Subject = emailSubject;


            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>";

            //            //String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //            //emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //            //emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            //emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //            //emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //            //emailDesc = emailDesc.Replace("#SenderEmail#", user.ExUser1);
            //            //emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            //emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));
            //            messagedel = messagedel.Replace("#DeliverableDetailLink#", delirabledetail);

            //            //if (!string.IsNullOrEmpty(messagedel) && !String.IsNullOrWhiteSpace(messagedel))
            //            //    emailDesc = emailDesc.Replace("#Message#", messagedel);
            //            //else
            //            //    emailDesc = emailDesc.Replace("#Message#", "");
            //            for (int k = 0; k < Files.Length; k++)
            //            {
            //                UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[k]));
            //                //message.Headers.Add("Message-ID", Convert.ToString(Files[k])); //Set Message-ID in Email Header
            //                //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //                //{
            //                //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //                //}
            //                //else
            //                //{
            //                //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //                //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //                //}

            //                //BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //                //ProjectMilestone milestone = new ProjectMilestone();
            //                //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //                //{
            //                //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //                //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //                //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                //    string RevNumber = "";
            //                //    if (Convert.ToString(revision.RevNumber).Length == 1)
            //                //    {
            //                //        RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //                //    }
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //                //}
            //                //else
            //                //{

            //                //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //                //    //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //                //    emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //                //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //                //}

            //                if (VFile.FileExtention.Contains("pdf"))
            //                {
            //                    FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[k] + "&&UserID=" + Convert.ToString(str[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            //                }
            //            }
            //            messagedel = messagedel.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //            message.Body = messagedel;
            //            MailAddress mailID = new MailAddress(Convert.ToString(str[0].Trim()));
            //            message.To.Add(mailID);
            //            bool status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //            message = null;
            //        }
            //    }
            //    else if (Reminder == "Y")
            //    {
            //        for (int i = 0; i < strColon.Length; i++)
            //        {
            //            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //            objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReminder);

            //            FileUrl = String.Empty;
            //            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));

            //            message.Subject = emailSubject;
            //            //String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //            //emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //            //emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            //emailDesc = emailDesc.Replace("#ClientDeilverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //            //emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //            //emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //            //emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.ExUser1));
            //            //emailDesc = emailDesc.Replace("#ClientProjectNo.#", Convert.ToString(project.ClientProjectNo));




            //            string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(strColon[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>";
            //            messagedel = messagedel.Replace("#DeliverableDetailLink#", delirabledetail);
            //            UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(Files[0]));
            //            //message.Headers.Add("Message-ID", Files[0].ToString()); //Set Message-ID in Email Header
            //            //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            //{
            //            //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //            //}
            //            //else
            //            //{
            //            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //            //}

            //            //BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //            //ProjectMilestone milestone = new ProjectMilestone();
            //            //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //            //{
            //            //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //            //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //            //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //            //    string RevNumber = "";
            //            //    if (Convert.ToString(revision.RevNumber).Length == 1)
            //            //    {
            //            //        RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //            //    }
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //            //}
            //            //else
            //            //{

            //            //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //            //    //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //            //    emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //            //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //            //}
            //            if (VFile.FileExtention.Contains("pdf"))
            //            {
            //                FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Files[0] + "&UserID=" + Convert.ToString(strColon[0].Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";

            //                // Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "PDFClientViewer.aspx?FileID=" + Files[0] + "&ExClientEmailID=Click here to view or comment on PDF file .</a>";
            //            }

            //            messagedel = messagedel.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //            message.Body = messagedel;
            //            MailAddress mailID = new MailAddress(Convert.ToString(strColon[i].Trim()));
            //            message.To.Add(mailID);
            //            bool status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //            message = null;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }


        public Boolean SendEmailTocheckerforreminder(int UserID, string UsersEmails, int DeliverableID, string fileID, string ServerUrl)
        {
            //try
            //{


            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    User user = blUser.GetuserByID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    User dtUsers = null;
            //    dtUsers = blUser.GetuserByID(UserID);
            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    User dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";
            //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReminder);
            //    FileUrl = String.Empty;
            //    String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));

            //    message.Subject = emailSubject;
            //    String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //    emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //    emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //    emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            //    emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //    emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //    emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            //    emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            //    emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            //    emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);




            //    string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "&FileID=" + fileID + "> Click here to see deliverable files for all revisions.</a>";
            //    emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);


            //    UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(fileID));
            //    //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //    //{
            //    //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //    //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            //    //}
            //    //else
            //    //{
            //    //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //    //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //    //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            //    //}
            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //    ProjectMilestone milestone = new ProjectMilestone();
            //    if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            //    {
            //        RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            //        milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //        emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //        string RevNumber = "";
            //        if (Convert.ToString(revision.RevNumber).Length == 1)
            //        {
            //            RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //        }
            //        emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            //    }
            //    else
            //    {

            //        milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            //        //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            //        emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //        emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //    }

            //    if (VFile.FileExtention.Contains("pdf"))
            //    {
            //        FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + fileID + "&UserID=" + Convert.ToString(UsersEmails.Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";

            //        // Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "PDFClientViewer.aspx?FileID=" + Files[0] + "&ExClientEmailID=Click here to view or comment on PDF file .</a>";
            //    }

            //    emailDesc = emailDesc.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            //    message.Body = emailDesc;
            //    MailAddress mailID = new MailAddress(Convert.ToString(UsersEmails.Trim()));
            //    message.To.Add(mailID);
            //    bool status = Common.GeneralFuntions.SendHtmlEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //    message = null;


            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }


        //When sender is Internal User
        public Boolean SendEmailToStakeHolder(int UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl)
        {
            //try
            //{


            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    User user = blUser.GetuserByID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    User dtUsers = null;
            //    dtUsers = blUser.GetuserByID(UserID);
            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    User dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";
            //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            //    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.StakeHolderNotification);

            //    FileUrl = String.Empty;
            //    String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.DeliverableNo));

            //    message.Subject = emailSubject;
            //    String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //    emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //    emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //    emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            //    emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //    emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //    emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            //    emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            //    emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            //    emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);




            //    // string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "> Click here to see deliverable files for all revisions.</a>";
            //    string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "&MilestoneID=" + Convert.ToString(MilestoneID) + "&RevisionID=" + Convert.ToString(RevisionID) + "&FileID=" + fileID + "> Click here to see deliverable files for all revisions.</a>";

            //    emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);

            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //    ProjectMilestone milestone = null;
            //    if (RevisionID > 0)
            //    {
            //        RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(RevisionID));
            //        milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //        emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //        string RevNumber = "";
            //        if (Convert.ToString(revision.RevNumber).Length == 1)
            //        {
            //            RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //        }
            //        emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);

            //    }
            //    else
            //    {
            //        milestone = blMile.GetMilestoneByID(Convert.ToInt32(MilestoneID));
            //        emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //        emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //    }

            //    message.Body = emailDesc;
            //    MailAddress mailID = new MailAddress(Convert.ToString(UsersEmails.Trim()));
            //    message.To.Add(mailID);
            //    bool status = Common.GeneralFuntions.SendHtmlEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //    message = null;


            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }

        //When sender is External User
        public Boolean SendEmailToStakeHolder(string UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl)
        {
            //try
            //{


            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    ExUser user = blUser.GetExuserByeEmailID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    ExUser dtUsers = null;
            //    dtUsers = blUser.GetExuserByeEmailID(UserID);
            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    ExUser dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";
            //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            //    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.StakeHolderNotificationFromExternal);

            //    FileUrl = String.Empty;
            //    String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));

            //    message.Subject = emailSubject;
            //    String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            //    emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //    emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //    emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            //    emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //    emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //    emailDesc = emailDesc.Replace("#SenderEmail#", user.ExUser1);
            //    emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);




            //    // string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "> Click here to see deliverable files for all revisions.</a>";
            //    string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "&MilestoneID=" + Convert.ToString(MilestoneID) + "&RevisionID=" + Convert.ToString(RevisionID) + "&FileID=" + fileID + "> Click here to see deliverable files for all revisions.</a>";

            //    emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);

            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //    ProjectMilestone milestone = null;
            //    if (RevisionID > 0)
            //    {
            //        RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(RevisionID));
            //        milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //        emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //        string RevNumber = "";
            //        if (Convert.ToString(revision.RevNumber).Length == 1)
            //        {
            //            RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //        }
            //        emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);

            //    }
            //    else
            //    {
            //        milestone = blMile.GetMilestoneByID(Convert.ToInt32(MilestoneID));
            //        emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //        emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //    }

            //    message.Body = emailDesc;
            //    MailAddress mailID = new MailAddress(Convert.ToString(UsersEmails.Trim()));
            //    message.To.Add(mailID);
            //    bool status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //    message = null;


            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }








        //When sender is Internal User
        public Boolean SendEmailToStakeHolder(int UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl, string messagedel = null, string subject = null)
        {
            //try
            //{


            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    User user = blUser.GetuserByID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    User dtUsers = null;
            //    dtUsers = blUser.GetuserByID(UserID);
            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    User dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";
            //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            //    //objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.StakeHolderNotification);

            //    FileUrl = String.Empty;
            //    //String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //    String emailSubject = subject;
            //    message.Subject = emailSubject;
            //    String emailDesc = messagedel;
            //    //emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //    //emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //    //emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            //    //emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //    //emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //    //emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            //    //emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            //    //emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            //    //emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);




            //    // string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "> Click here to see deliverable files for all revisions.</a>";
            //    string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "&MilestoneID=" + Convert.ToString(MilestoneID) + "&RevisionID=" + Convert.ToString(RevisionID) + "&FileID=" + fileID + "> Click here to see deliverable files for all revisions.</a>";

            //    emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);

            //    //BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //    //ProjectMilestone milestone = null;
            //    //if (RevisionID > 0)
            //    //{
            //    //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(RevisionID));
            //    //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //    //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //    //    string RevNumber = "";
            //    //    if (Convert.ToString(revision.RevNumber).Length == 1)
            //    //    {
            //    //        RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //    //    }
            //    //    emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);

            //    //}
            //    //else
            //    //{
            //    //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(MilestoneID));
            //    //    emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //    //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //    //}

            //    message.Body = emailDesc;
            //    MailAddress mailID = new MailAddress(Convert.ToString(UsersEmails.Trim()));
            //    message.To.Add(mailID);
            //    bool status = Common.GeneralFuntions.SendHtmlEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //    message = null;


            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }

        //When sender is External User
        public Boolean SendEmailToStakeHolder(string UserID, string UsersEmails, int DeliverableID, int MilestoneID, int RevisionID, string fileID, string ServerUrl, string messagedel = null, string subject = null)
        {
            //try
            //{


            //    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            //    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            //    BLUserRepository blUser = new BLUserRepository();
            //    ExUser user = blUser.GetExuserByeEmailID(UserID);
            //    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            //    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            //    BLClientRepository blClient = new BLClientRepository();
            //    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            //    BLRevisionFile blRev = new BLRevisionFile();

            //    ExUser dtUsers = null;
            //    dtUsers = blUser.GetExuserByeEmailID(UserID);
            //    //string AttachFileToDelete = "";

            //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //    BLConfigFileRepository configFile = new BLConfigFileRepository();
            //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            //    ExUser dtAdminData = dtUsers;

            //    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //    //emailDesc = emailDesc.Replace("#Password#", password);
            //    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            //    string FileUrl = "";
            //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            //    //objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.StakeHolderNotificationFromExternal);

            //    FileUrl = String.Empty;
            //    //String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));
            //    String emailSubject = subject;
            //    message.Subject = emailSubject;
            //    String emailDesc = messagedel;
            //    //emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            //    //emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            //    //emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            //    //emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            //    //emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            //    //emailDesc = emailDesc.Replace("#SenderEmail#", user.ExUser1);
            //    //emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);




            //    // string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "> Click here to see deliverable files for all revisions.</a>";
            //    string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "&MilestoneID=" + Convert.ToString(MilestoneID) + "&RevisionID=" + Convert.ToString(RevisionID) + "&FileID=" + fileID + "> Click here to see deliverable files for all revisions.</a>";

            //    emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);

            //    //BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            //    //ProjectMilestone milestone = null;
            //    //if (RevisionID > 0)
            //    //{
            //    //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(RevisionID));
            //    //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            //    //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //    //    string RevNumber = "";
            //    //    if (Convert.ToString(revision.RevNumber).Length == 1)
            //    //    {
            //    //        RevNumber = "0" + Convert.ToString(revision.RevNumber);
            //    //    }
            //    //    emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);

            //    //}
            //    //else
            //    //{
            //    //    milestone = blMile.GetMilestoneByID(Convert.ToInt32(MilestoneID));
            //    //    emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            //    //    emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            //    //}

            //    message.Body = emailDesc;
            //    MailAddress mailID = new MailAddress(Convert.ToString(UsersEmails.Trim()));
            //    message.To.Add(mailID);
            //    bool status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            //    message = null;


            //}
            //catch (Exception ex)
            //{
            //    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            //}
            return true;
        }



        public Boolean SendEmailToClientUserForCommentWithAttachment(int UserID, string UsersEmails, int DeliverableID, string fileID, string Reminder, string ServerUrl)
        {
            ////try
            ////{
            ////    string[] strColon = UsersEmails.TrimEnd(';').Split(';');
            ////    string[] Files = fileID.TrimEnd(',').Split(',');
            ////    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            ////    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            ////    BLUserRepository blUser = new BLUserRepository();
            ////    User user = blUser.GetuserByID(UserID);
            ////    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            ////    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            ////    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            ////    BLClientRepository blClient = new BLClientRepository();
            ////    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            ////    BLRevisionFile blRev = new BLRevisionFile();

            ////    User dtUsers = null;
            ////    dtUsers = blUser.GetuserByID(UserID);
            ////    //string AttachFileToDelete = "";

            ////    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            ////    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            ////    BLConfigFileRepository configFile = new BLConfigFileRepository();
            ////    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            ////    User dtAdminData = dtUsers;

            ////    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            ////    //emailDesc = emailDesc.Replace("#Password#", password);
            ////    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            ////    string FileUrl = "";

            ////    if (Reminder == "N")
            ////    {
            ////        for (int i = 0; i < strColon.Length; i++)
            ////        {
            ////            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            ////            string[] str = strColon[i].Split(':');
            ////            if (str[1].Trim() == "Y")
            ////            {
            ////                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReview);
            ////            }
            ////            else
            ////            {
            ////                objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableViewing);
            ////            }
            ////            string EmailFilePath = "";
            ////            string DelivarablePath = "";
            ////            FileUrl = String.Empty;
            ////            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));
            ////            String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
            ////            String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
            ////            message.Subject = emailSubject;
            ////            String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            ////            emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            ////            emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            ////            emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            ////            emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            ////            emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            ////            emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            ////            emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            ////            emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            ////            emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);
            ////            //  emailDesc = emailDesc.Replace("#DeliverableDetailLink#", Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()));

            ////            UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(fileID));
            ////            int iMilestoneID = Convert.ToInt32(VFile.MilestoneID);
            ////            DelivarablePath = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + DeliverabelDetails.ProjectTaskID + "&Page=PV&FileID=" + Convert.ToInt32(fileID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>" + "<br/>";

            ////            if (VFile.FileExtention.Contains("pdf"))
            ////            {
            ////                EmailFilePath = EmailFilePath + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Convert.ToInt32(fileID) + "&&UserID=" + Convert.ToString(str[0].Trim()) + "> Click here to view or comment on - " + VFile.FileName + ".</a>" + "<br/>";
            ////            }

            ////            //if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            ////            //{
            ////            //    RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            ////            //    emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            ////            //}
            ////            //else
            ////            //{
            ////            //    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            ////            //    ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            ////            //    emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            ////            //}

            ////            BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            ////            ProjectMilestone milestone = new ProjectMilestone();
            ////            if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            ////            {
            ////                RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            ////                milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            ////                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            ////                string RevNumber = "";
            ////                if (Convert.ToString(revision.RevNumber).Length == 1)
            ////                {
            ////                    RevNumber = "0" + Convert.ToString(revision.RevNumber);
            ////                }
            ////                emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            ////            }
            ////            else
            ////            {

            ////                milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            ////                //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            ////                emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            ////                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            ////            }



            ////            /* Create the email attachment with the uploaded file */
            ////            Attachment attachInternal = new Attachment(HttpContext.Current.Server.MapPath(VFile.FilePath));
            ////            message.Attachments.Add(attachInternal);
            ////            BLAttachTransmitalFilesRepository blAttachFile = new BLAttachTransmitalFilesRepository();
            ////            List<AttachTransmitalFile> transmittallst = blAttachFile.GetAll().Where(c => c.FileID == Convert.ToInt32(fileID)).ToList<AttachTransmitalFile>();
            ////            var lstattachedfiles = (from f in transmittallst select new { FileName = f.AttachFileName, Filepath = f.AttachFilePath }).Distinct();
            ////            foreach (var item in lstattachedfiles)
            ////            {
            ////                Attachment attachtransmittal = new Attachment(HttpContext.Current.Server.MapPath(item.Filepath));
            ////                message.Attachments.Add(attachtransmittal);
            ////            }

            ////            emailDesc = emailDesc.Replace("#DeliverableDetailLink#", DelivarablePath);
            ////            emailDesc = emailDesc.Replace("#PDFeditorLink#", EmailFilePath);
            ////            message.Body = emailDesc;
            ////            MailAddress mailID = new MailAddress(Convert.ToString(str[0].Trim()));
            ////            message.To.Add(mailID);
            ////            bool status = Common.GeneralFuntions.SendHtmlEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            ////            message = null;
            ////        }
            ////    }
            ////    else if (Reminder == "Y")
            ////    {
            ////        for (int i = 0; i < strColon.Length; i++)
            ////        {
            ////            string[] str = strColon[i].Split(':');
            ////            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            ////            objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableReminder);

            ////            FileUrl = String.Empty;
            ////            String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));

            ////            message.Subject = emailSubject;

            ////            string EmailFilePath = "";
            ////            string DelivarablePath = "";
            ////            FileUrl = String.Empty;
            ////            String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
            ////            String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
            ////            message.Subject = emailSubject;
            ////            String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            ////            emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            ////            emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            ////            emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            ////            emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            ////            emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            ////            emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            ////            emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            ////            emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            ////            emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);
            ////            //emailDesc = emailDesc.Replace("#DeliverableDetailLink#", Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()));
            ////            DelivarablePath = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + DeliverabelDetails.ProjectTaskID + "&Page=PV&FileID=" + Convert.ToInt32(fileID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>" + "<br/>";


            ////            UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(fileID));
            ////            int iMilestoneID = Convert.ToInt32(VFile.MilestoneID);
            ////            DelivarablePath = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + DeliverabelDetails.ProjectTaskID + "&Page=PV&FileID=" + Convert.ToInt32(fileID) + "&ExClientEmailID=" + Convert.ToString(str[0].Trim()) + "&FileID=" + Files[0] + "> Click here to see deliverable files for all revisions.</a>" + "<br/>";

            ////            if (VFile.FileExtention.Contains("pdf"))
            ////            {
            ////                EmailFilePath = EmailFilePath + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + Convert.ToInt32(fileID) + "&&UserID=" + Convert.ToString(str[0].Trim()) + "> Click here to view or comment on - " + VFile.FileName + ".</a>" + "<br/>";
            ////            }



            ////            BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            ////            ProjectMilestone milestone = new ProjectMilestone();
            ////            if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            ////            {
            ////                RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            ////                milestone = blMile.GetMilestoneByID(Convert.ToInt32(revision.StatusID));
            ////                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            ////                string RevNumber = "";
            ////                if (Convert.ToString(revision.RevNumber).Length == 1)
            ////                {
            ////                    RevNumber = "0" + Convert.ToString(revision.RevNumber);
            ////                }
            ////                emailDesc = emailDesc.Replace("#RevisionNo#", RevNumber);
            ////            }
            ////            else
            ////            {

            ////                milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            ////                //emailDesc = emailDesc.Replace("#RevisionNo#", string.Empty);
            ////                emailDesc = emailDesc.Replace("#RevisionNo#", "00");
            ////                emailDesc = emailDesc.Replace("#MAHRev#", milestone.MileStone);
            ////            }

            ////            emailDesc = emailDesc.Replace("#DeliverableDetailLink#", DelivarablePath);
            ////            emailDesc = emailDesc.Replace("#PDFeditorLink#", EmailFilePath);
            ////            message.Body = emailDesc;
            ////            MailAddress mailID = new MailAddress(Convert.ToString(str[0].Trim()));
            ////            message.To.Add(mailID);
            ////            bool status = Common.GeneralFuntions.SendHtmlEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            ////            message = null;
            ////        }
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            ////}
            return true;
        }
        public string generatemassage(string msg, string userid, DateTime? createdon, int UploadDeliverableFileID, List<ApprovalAttachmentFile> lstaaf)
        {

            string message = msg;
            //CultureInfo ci = new CultureInfo("en-GB");
            //BLUserRepository blu = new BLUserRepository();
            //if (userid.Contains("@") == false)
            //{
            //    int id = Convert.ToInt32(userid);
            //    User u = blu.GetuserByID(id);
            //    message = message.Replace("#USER#", u.FirstName + " " + u.LastName);
            //}
            //string dt = Convert.ToDateTime(createdon, ci).ToString("dd/MM/yyyy");
            //message = message.Replace("#Date#", dt == null ? "" : dt.ToString());


            //BLApprovalRelatedTaskRepository blART = new BLApprovalRelatedTaskRepository();
            //BLSelfApprovalCommentRepository blSAC = new BLSelfApprovalCommentRepository();
            //BLTaskListRepository blTask = new BLTaskListRepository();
            //List<ApprovalRelatedTask> lstART = blART.GetApprovalRelatedTaskByFileID(UploadDeliverableFileID);
            //List<SelfApprovalComment> lstSAC = blSAC.GetSelfApprovalCommentByFileID(UploadDeliverableFileID);
            //string message1 = "<ul style='padding-left:50px;'>";
            //if (lstART.Count() > 0)
            //{

            //    foreach (var setID in lstART.Select(x => x.SetID).Distinct())
            //    {
            //        var lstArt1 = lstART.Where(x => x.SetID == setID).Select(x => x.TaskID);
            //        List<string> lstTaskName = blTask.GetAllTaskListWithCompanyID(Convert.ToInt32(HttpContext.Current.Session["CompanyId"])).Where(x => lstArt1.Contains(x.ProjectTaskID)).Select(x => x.TaskName).ToList();

            //        string ART = String.Join(",", lstTaskName);


            //        foreach (var item in lstSAC.Where(x => x.SetID == setID))
            //        {
            //            message1 += "<li>" + ART + "-" + item.CommentDesc + "-";

            //            string attachmentlinks = "";
            //            foreach (var a in lstaaf.Where(a => a.ApprovalCommentID == item.CommentID))
            //            {
            //                string href = Common.BasePage.GetFileServerPath.ToString() + a.FilePath;

            //                if (a.FileExtention.Contains("pdf"))
            //                    attachmentlinks += "<a fileid='" + a.AttachFileID + "' source='Approval AttachmentFile' onclick='OpenAttachmentPdfviewer(this);' href='#'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //                else
            //                    attachmentlinks += "<a class='fancybox' href='" + href + "'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //                //attachmentlinks += "<a href=# >" + a.FileName + a.FileExtention + "</a><br>";
            //            }

            //            message1 += string.IsNullOrEmpty(attachmentlinks) ? "" : attachmentlinks;
            //            message1 += "</li>";
            //        }


            //        string attachmentlinks1 = "";
            //        foreach (var a in lstaaf.Where(a => a.ApprovalCommentID == null && a.SetID == setID))
            //        {
            //            string href = Common.BasePage.GetFileServerPath.ToString() + a.FilePath;

            //            if (a.FileExtention.Contains("pdf"))
            //                attachmentlinks1 += "<a fileid='" + a.AttachFileID + "' source='Approval AttachmentFile' onclick='OpenAttachmentPdfviewer(this);' href='#'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //            else
            //                attachmentlinks1 += "<a class='fancybox' href='" + href + "'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //        }
            //        if (attachmentlinks1 != "")
            //            message1 += "<li>" + ART + "-" + attachmentlinks1 + "</li>";

            //    }

            //}
            //else
            //{

            //    foreach (var item in lstSAC)
            //    {
            //        message1 += "<li>" + item.CommentDesc + "-";

            //        string attachmentlinks = "";
            //        foreach (var a in lstaaf.Where(a => a.ApprovalCommentID == item.CommentID))
            //        {
            //            string href = Common.BasePage.GetFileServerPath.ToString() + a.FilePath;

            //            if (a.FileExtention.Contains("pdf"))
            //                attachmentlinks += "<a fileid='" + a.AttachFileID + "' source='Approval AttachmentFile' onclick='OpenAttachmentPdfviewer(this);' href='#'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //            else
            //                attachmentlinks += "<a class='fancybox' href='" + href + "'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //            //attachmentlinks += "<a href=# >" + a.FileName + a.FileExtention + "</a><br>";
            //        }

            //        message1 += string.IsNullOrEmpty(attachmentlinks) ? "" : attachmentlinks;
            //        message1 += "</li>";
            //    }
            //    string attachmentlinks2 = "";
            //    foreach (var a in lstaaf.Where(a => a.ApprovalCommentID == null))
            //    {
            //        string href = Common.BasePage.GetFileServerPath.ToString() + a.FilePath;

            //        if (a.FileExtention.Contains("pdf"))
            //            attachmentlinks2 += "<a fileid='" + a.AttachFileID + "' source='Approval AttachmentFile' onclick='OpenAttachmentPdfviewer(this);' href='#'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //        else
            //            attachmentlinks2 += "<a class='fancybox' href='" + href + "'>'" + a.FileName + a.FileExtention + "'</a>&nbsp;,";
            //    }
            //    if (attachmentlinks2 != "")
            //        message1 += "<li>" + attachmentlinks2 + "</li>";
            //}





            //message1 += "</ul>";

            //message = message.Replace("#basistext#", string.IsNullOrEmpty(message1) ? "" : message1);
            ////message = message.Replace("#attachedfilelink#", string.IsNullOrEmpty(attachmentlinks) ? "" : attachmentlinks);


            return message;

        }

        //public string generatemassage(string msg, string userid, DateTime? createdon, int UploadDeliverableFileID, List<ApprovalAttachmentFile> lstaaf)
        //{

        //    string message = msg;
        //    CultureInfo ci = new CultureInfo("en-GB");
        //    BLUserRepository blu = new BLUserRepository();
        //    if (userid.Contains("@") == false)
        //    {
        //        int id = Convert.ToInt32(userid);
        //        User u = blu.GetuserByID(id);
        //        message = message.Replace("#USER#", u.FirstName + " " + u.LastName);
        //    }
        //    string dt = Convert.ToDateTime(createdon, ci).ToString("dd/MM/yyyy");
        //    message = message.Replace("#Date#", dt == null ? "" : dt.ToString());


        //    BLApprovalRelatedTaskRepository blART = new BLApprovalRelatedTaskRepository();
        //    BLSelfApprovalCommentRepository blSAC = new BLSelfApprovalCommentRepository();
        //    List<ApprovalRelatedTask> lstART = blART.GetApprovalRelatedTaskByFileID(UploadDeliverableFileID);
        //    List<SelfApprovalComment> lstSAC = blSAC.GetSelfApprovalCommentByFileID(UploadDeliverableFileID);

        //    string msgComment = "";
        //    string msgAttachment = "";
        //    string msgRelatedTask = "";

        //    if (lstART.Count() > 0)
        //    {
        //        foreach (var setID in lstART.Select(x => x.SetID).Distinct())
        //        {
        //            var lstArt1 = lstART.Where(x => x.SetID == setID);
        //            string ART = String.Join(",", lstArt1);



        //        }
        //    }
        //    else { }

        //    return "";
        //}

        public string ApproveFileByCheckerWithComments(int fileID, string UserID)
        {
            try
            {
                String strCheckerName = "";
                //BLFileStatusRepository objFileStatusRepository = new BLFileStatusRepository();
                //BLUploadDeliverableFile objUploadDeliverableRepository = new BLUploadDeliverableFile();
                ////update file Status of Users
                //objFileStatusRepository.UpdateFileStatusOnComment(UserID, fileID, Convert.ToInt32(Common.FileStatusID.Approved));
                ////update UpdateProgressDeliverable
                //UploadDeliverableFile uploadfile = GetUploadDeliverableFileByID(Convert.ToInt32(fileID));
                //int result = UpdateProgressDeliverable(Convert.ToInt32(uploadfile.MilestoneID), Convert.ToInt32(Common.DocStatusID.Approve), Convert.ToInt32(uploadfile.DeliverableListID), Convert.ToInt32(uploadfile.RevisionID), Convert.ToInt32(fileID), "A");

                //ProjectTaskList dList = GetDeliverableListByFileID(fileID);

                //BLMilestoneStakeholder bms = new BLMilestoneStakeholder();
                //List<MilestonesStakeHolder> lstStakeholder = bms.GetAllStakeHolderByMilestoneID(dList.ProjectID, (int)uploadfile.MilestoneID, (int)uploadfile.RevisionID, dList.ProjectTaskID);


                //BLTaskListRepository objTaskListRepository = new BLTaskListRepository();
                //BLUserRepository bluser = new BLUserRepository();
                //if (UserID.Contains("@"))
                //{
                //    strCheckerName = UserID;
                //}
                //else
                //{
                //    strCheckerName = bluser.GetUserFullName(Convert.ToInt32(UserID));
                //}

                //int i = -1;
                //do
                //{
                //    if (i == -1 || (i != -1 && !lstStakeholder[i].UserID.Contains('@')))
                //    {
                //        ////Go to PDF editor; 
                //        BLMessageRepository blMes = new BLMessageRepository();
                //        Message lstAM = new Message();
                //        lstAM.FromUserID = UserID;
                //        if (i == -1)
                //            lstAM.ToUserID = Convert.ToString(dList.TaskOwner);
                //        else
                //            lstAM.ToUserID = Convert.ToString(lstStakeholder[i].UserID);
                //        lstAM.Message1 = Common.MessageConstants.ApproveWithComments.Replace("#DeliverableName#", Convert.ToString(dList.TaskName)).Replace("#checkername#", strCheckerName);
                //        lstAM.RedirectURL = "pdfjs/viewer.html";
                //        lstAM.QueryString = "FileID=" + Convert.ToInt32(fileID) + "&&UserID=" + Convert.ToString(dList.TaskOwner);
                //        lstAM.MessageFor = "Approved with comment";
                //        lstAM.Active = "Y";
                //        lstAM.MessageType = "N";
                //        lstAM.Date = DateTime.Now;
                //        lstAM.EntityState = DominModel.EntityState.Added;
                //        blMes.AddMessage(lstAM);

                //        BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();
                //        MessageTemplate mst = blmt.GetMessageTemplateByMessage(Common.MessageConstants.ApproveWithComments);

                //        if (mst.IsEmail == true)
                //        {
                //            if (i == -1)
                //                blmt.SendNotification(Convert.ToInt32(UserID), lstAM.Message1, Convert.ToInt32(dList.TaskOwner));
                //            else
                //                blmt.SendNotification(Convert.ToInt32(UserID), lstAM.Message1, Convert.ToInt32(lstStakeholder[i].UserID));
                //        }
                //    }
                //    i++;
                //} while (i < lstStakeholder.Count);

                ////add log in activity log table 3
                //BLActivityLogRepository objActLog = new BLActivityLogRepository();
                //objActLog.AddActivityLogByFileID(strCheckerName, Convert.ToInt32(fileID), Common.MessageConstants.ActivityLogFileApprovedWithComments);

                return "1";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<PageDetail> FilterMode(string[] users, int FileID)
        {
            //BLPageCommentDetailRepository blFilecomment = new BLPageCommentDetailRepository();
            List<PageDetail> pageModel = null;
            //try
            //{
            //    BLPageDetailRepository blpageDetail = new BLPageDetailRepository();
            //    pageModel = blpageDetail.GetPageDetails(FileID).ToList();

            //    if (users.Count() > 0)
            //    {
            //        int i = 0;
            //        foreach (var page in pageModel)
            //        {
            //            var comments = page.PageCommentDetails.Where(p => users.Contains(p.CommentedBy)).Select(p => p).ToList<PageCommentDetail>();
            //            pageModel[i].PageCommentDetails = comments;
            //            i++;
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //}
            return pageModel;
        }

        public static string GetLatestChangeMilestoneName(int DeliverableID)
        {
            string res = "";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var list = db.usp_GetLatestChangeMilestone(DeliverableID);
                //    if (list != null)
                //    {
                //        res = list.OrderByDescending(o => o.createdOn).FirstOrDefault().Milestone;
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }



        public int UpdateProgressDeliverable(int MilestoneID, int docstatus, int DeliverableID, int RevisionID, int fileID, string filestatus)
        {
            int res = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    res = context.UPDATE_DELIVERABLE_PROGRESS(MilestoneID, docstatus, DeliverableID, RevisionID, fileID, filestatus);
            //}
            return res;
        }


        public List<UploadDeliverableFile> GetUploadDeliverableByArrDelId(List<int> UploadDeliverableFileID)
        {
            List<UploadDeliverableFile> res = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    res = (from q in context.UploadDeliverableFiles where UploadDeliverableFileID.Contains(q.UploadDeliverableFileID) select q).ToList<UploadDeliverableFile>();
            ////}
            return res;
        }
        public static string GetTaskProgressByDeliverableID(int DeliverableID)
        {
            string TaskProgress = "";
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var ProgressID = from udf in context.UploadDeliverableFiles
            //                     where udf.DeliverableListID == DeliverableID && udf.FileExtention == ".pdf"
            //                     select new
            //                     {
            //                         RevisionID = udf.RevisionID,
            //                         MilestoneID = udf.MilestoneID
            //                     };

            //    if (ProgressID.Max(a => a.RevisionID) == 0)
            //    {
            //        TaskProgress = context.ProjectMilestones.Where(a => a.ProjectMilestoneID == ProgressID.Max(q => q.MilestoneID)).Select(a => a.MileStone).FirstOrDefault();
            //    }
            //    else
            //    {
            //        TaskProgress = context.RevisionFiles.Where(a => a.RevisionID == ProgressID.Max(q => q.RevisionID)).Select(a => a.RevisionNo).FirstOrDefault();
            //    }

            //}
            return TaskProgress;
        }

        public int GetActivityType(int TaskType)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int? ActivityType = (from n in context.TaskTypes
            //                         where n.TaskTypeID == TaskType
            //                         select n.ActivityType).FirstOrDefault();


            //    return (int)ActivityType;
            //}
            return 0;
        }

        public int GetWhetherAdmin(int ProjectID, int DeliverableID, int MilestoneID)
        {
            int WhetherHasEditRight = 0;
            //using (var con = new Cubicle_EntityEntities())
            //{
            //    int UserID = 0, ProjectLeader = 0, ProjectAdmin = 0, TaskOwner = 0;
            //    if (!UserSession.UserID.Contains("@"))
            //    {

            //        UserID = Convert.ToInt32(UserSession.UserID);

            //        ProjectLeader = (from n in con.Projects
            //                         where n.ProjectID == ProjectID && n.ProjectLeader == UserID
            //                         select n.ProjectLeader).Count();

            //        ProjectAdmin = (from n in con.ProjectsAdmins
            //                        where n.ProjectID == ProjectID && n.UserID == UserID
            //                        select n.UserID).Count();

            //        TaskOwner = (from n in con.ProjectTaskLists
            //                     where n.ProjectTaskID == DeliverableID && n.TaskOwner == UserID
            //                     select n.TaskOwner).Count();
            //    }


            //    int FileChecker = (from n in con.UploadDeliverableFiles
            //                       join m in con.FileCheckers on n.UploadDeliverableFileID equals m.UploadDeliverableFileID
            //                       where n.DeliverableListID == DeliverableID && n.MilestoneID == MilestoneID && m.UserID == UserSession.UserID
            //                       select m.UserID
            //                           ).Count();

            //    int StakeHolder = (from n in con.MilestonesStakeHolders
            //                       where n.UserID == UserSession.UserID && ((n.MilestoneID == MilestoneID && n.Flag == "MS") || (n.TaskID == DeliverableID && n.MilestoneID == MilestoneID && n.Flag == "DS"))
            //                       select n
            //                           ).Count();


            //     WhetherHasEditRight = (from n in con.EstimationTaskColumnsMasters
            //                               join m in con.MaterialdetailsColumns on n.EstimationTaskColumnID equals m.EstimationTaskColumnID
            //                               where m.ProjectID == ProjectID && m.MilestoneID == MilestoneID
            //                               && ((ProjectLeader > 0 || ProjectAdmin > 0 ? m.ProjectAdminRights == "Edit" : 1 != 1)
            //                               || (TaskOwner > 0 || StakeHolder > 0 ? m.OwnerRights == "Edit" : 1 != 1)
            //                               || (FileChecker > 0 ? m.RecipientRights == "Edit" : 1 != 1))
            //                               select n).Count();

                
            //}
            return WhetherHasEditRight;
        }


        public int GetWhetherAdmin(int ProjectID, int DeliverableID)
        {
            int UserID = 0, TaskOwner = 0;
            ////using (var con = new Cubicle_EntityEntities())
            ////{
               


            ////    UserID = Convert.ToInt32(UserSession.UserID);


            ////    TaskOwner = (from n in con.ProjectTaskLists
            ////                 where n.ProjectTaskID == DeliverableID && n.TaskOwner == UserID
            ////                 select n.TaskOwner).Count();



            ////    int FileChecker = (from n in con.UploadDeliverableFiles
            ////                       join m in con.FileCheckers on n.UploadDeliverableFileID equals m.UploadDeliverableFileID
            ////                       where n.DeliverableListID == DeliverableID && m.UserID == UserSession.UserID
            ////                       select m.UserID
            ////                           ).Count();

            ////    int StakeHolder = (from n in con.MilestonesStakeHolders
            ////                       where n.UserID == UserSession.UserID && n.TaskID == DeliverableID
            ////                       select n
            ////                           ).Count();

              

            ////}
            //if (TaskOwner > 0 || FileChecker > 0 || StakeHolder > 0)
            //    return UserID;
            //else
                return -1;

        }
        public Boolean SendEmailTocheckerforApprove(int UserID, string UsersEmails, int DeliverableID, string fileID, string ServerUrl)
        {
            ////try
            ////{
            ////    BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            ////    ProjectTaskList DeliverabelDetails = blDel.GetDeliverableListByID(DeliverableID);
            ////    BLUserRepository blUser = new BLUserRepository();
            ////    User user = blUser.GetuserByID(UserID);
            ////    User Originatoruser = blUser.GetuserByID(Convert.ToInt32(DeliverabelDetails.TaskOwner));
            ////    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
            ////    Project project = blProject.GetProjectByID(DeliverabelDetails.ProjectID);
            ////    BLClientRepository blClient = new BLClientRepository();
            ////    Client client = blClient.GetClientByID(Convert.ToInt32(project.ClientCode));
            ////    BLRevisionFile blRev = new BLRevisionFile();
            ////    User dtUsers = null;
            ////    dtUsers = blUser.GetuserByID(UserID);
            ////    //string AttachFileToDelete = "";
            ////    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            ////    EmailTemplate objBEEmailTemplate = new EmailTemplate();
            ////    BLConfigFileRepository configFile = new BLConfigFileRepository();
            ////    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
            ////    User dtAdminData = dtUsers;
            ////    //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            ////    //emailDesc = emailDesc.Replace("#Password#", password);
            ////    BLUploadDeliverableFile blFile = new BLUploadDeliverableFile();
            ////    string FileUrl = "";
            ////    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            ////    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.DeliverableApproved);
            ////    FileUrl = String.Empty;
            ////    String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));
            ////    message.Subject = emailSubject;
            ////    String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
            ////    emailDesc = emailDesc.Replace("#DeliverableName#", DeliverabelDetails.TaskName);
            ////    emailDesc = emailDesc.Replace("#DeliverableNo#", Convert.ToString(DeliverabelDetails.DeliverableNo));
            ////    emailDesc = emailDesc.Replace("#ClientDeilverableNo#", DeliverabelDetails.DeliverableNo);
            ////    emailDesc = emailDesc.Replace("#ProjectName#", project.ProjectName);
            ////    emailDesc = emailDesc.Replace("#ProjectNo#", project.ProjectCode);
            ////    emailDesc = emailDesc.Replace("#SenderName#", user.FirstName + ' ' + user.LastName);
            ////    emailDesc = emailDesc.Replace("#SenderEmail#", Common.GeneralFuntions.Decrypt(user.EmailId));
            ////    emailDesc = emailDesc.Replace("#OriginatorName#", Originatoruser.FirstName + ' ' + Originatoruser.LastName);
            ////    emailDesc = emailDesc.Replace("#ClientProjectNo.#", project.ClientProjectNo);
            ////    string delirabledetail = "<a href=" + Convert.ToString(ServerUrl) + "UploadClientDeliverable.aspx?DeliverableID=" + Convert.ToString(DeliverabelDetails.ProjectTaskID) + "&ExClientEmailID=" + Convert.ToString(UsersEmails.Trim()) + "> Click here to see deliverable files for all revisions.</a>";
            ////    emailDesc = emailDesc.Replace("#DeliverableDetailLink#", delirabledetail);
            ////    UploadDeliverableFile VFile = blFile.GetUploadDeliverableFileByID(Convert.ToInt32(fileID));
            ////    if (VFile.RevisionID != null && Convert.ToInt32(VFile.RevisionID) > 0)
            ////    {
            ////        RevisionFile revision = blRev.GetRevisionFileByID(Convert.ToInt32(VFile.RevisionID));
            ////        emailDesc = emailDesc.Replace("#RevisionNo#", revision.RevisionNo);
            ////    }
            ////    else
            ////    {
            ////        BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
            ////        ProjectMilestone milestone = blMile.GetMilestoneByID(Convert.ToInt32(VFile.MilestoneID));
            ////        emailDesc = emailDesc.Replace("#RevisionNo#", milestone.ProjectMilestone1);
            ////    }
            ////    if (VFile.FileExtention.Contains("pdf"))
            ////    {
            ////        FileUrl = FileUrl + "<a href=" + Convert.ToString(ServerUrl) + "pdfjs/viewer.html?FileID=" + fileID + "&UserID=" + Convert.ToString(UsersEmails.Trim()) + "> Click here to view or comment on - " + Convert.ToString(VFile.FileName) + " .</a>" + "<br/>";
            ////        // Convert.ToString(ConfigurationManager.AppSettings["ServerUrl"]) + "PDFClientViewer.aspx?FileID=" + Files[0] + "&ExClientEmailID=Click here to view or comment on PDF file .</a>";
            ////    }
            ////    emailDesc = emailDesc.Replace("#PDFeditorLink#", FileUrl.TrimEnd(','));
            ////    message.Body = emailDesc;
            ////    MailAddress mailID = new MailAddress(Convert.ToString(UsersEmails.Trim()));
            ////    message.To.Add(mailID);
            ////    bool status = Common.GeneralFuntions.SendHtmlEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            ////    message = null;
            ////}
            ////catch (Exception ex)
            ////{
            ////    bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            ////}
            return true;
        }
        public int GetCompanyIDByTaskID(int TaskID)
        {

            int? CompanyID = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    CompanyID = (from ptl in context.ProjectTaskLists
            //                 join prj in context.Projects on ptl.ProjectID equals prj.ProjectID
            //                 where ptl.ProjectTaskID == TaskID
            //                 select prj.CompanyId).FirstOrDefault();
            //}

            return CompanyID != null ? (int)CompanyID : 0;
        }


        ////public int UploadFile(HttpPostedFile file, int DeliverableID, int MilestoneID, int RevisionID, string UserID, string Client = "W") //Client - From Web or Mobile.
        ////{
        ////    try
        ////    {
        ////        BLUploadDeliverableFile blUpld = new BLUploadDeliverableFile();
        ////        Project prj = blUpld.getProjectByDeliverableID(DeliverableID);

        ////        BLTaskListRepository objTask = new BLTaskListRepository();
        ////        ProjectTaskList task = objTask.GetTaskListByID(DeliverableID);

        ////        string deptname = new BLDepartmentRepository().GetDepartmentByID(task.DepatmentID).DepartmentName;
        ////        Company Company = null;
        ////        User user = null;
        ////        if (!UserID.Contains('@'))
        ////        {
        ////            BLUserRepository blUser = new BLUserRepository();
        ////            user = blUser.GetuserByID(Convert.ToInt32(UserID));
        ////            BLCompanyRepository blCom = new BLCompanyRepository();
        ////            Company = blCom.GetCompanyByCompanyID(Convert.ToInt32(user.CompanyId));
        ////        }

        ////        BLMilestoneStakeholder bms = new BLMilestoneStakeholder();
        ////        BLCheckerAttachmentFile blAttach = new BLCheckerAttachmentFile();
        ////        BLAttachmentFileRepository blattach = new BLAttachmentFileRepository();
        ////        List<MilestonesStakeHolder> lstStakeholder = bms.GetStakeHolderByMilestoneID(Convert.ToString(UserID), task.ProjectID, MilestoneID, RevisionID, DeliverableID);
        ////        int stkCount = 0;
        ////        stkCount = lstStakeholder.Count();
        ////        if (task.TaskOwner == Convert.ToInt32(UserID) || stkCount > 0)
        ////        {
        ////            string filePath = "";
        ////            string fileUploadDir = "";
        ////            string RevisionName = "", MilestoneName = "", TabName = "";

        ////            if (prj != null)
        ////            {

        ////                //for spectrum

        ////                if (Company != null && Convert.ToInt32(Common.CompanyID.Spectrum) == Company.CompanyId)
        ////                {
        ////                    //if(Common. CompanyID
        ////                    fileUploadDir = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(Company.ComanyName).Trim('.') + "/projectDocuments/" + prj.ProjectCode.ToString()) + "/" + Convert.ToString(task.TaskNo);
        ////                    filePath = "~/CompanyDocs/" + Convert.ToString(Company.ComanyName).Trim('.') + "/projectDocuments/" + prj.ProjectCode.ToString() + "/" + Convert.ToString(task.TaskNo);
        ////                }
        ////                else
        ////                {

        ////                    //decouple changes
        ////                    fileUploadDir = BasePage.networkdirectorypath + "\\" + Convert.ToString(Company.ComanyName).Trim('.') + "\\" + prj.ProjectCode + "\\" + deptname + "\\" + task.DeliverableNo;
        ////                    filePath = Convert.ToString(Company.ComanyName).Trim('.') + "/" + prj.ProjectCode + "/" + deptname + "/" + task.DeliverableNo;
        ////                }



        ////                if (RevisionID > 0)
        ////                {
        ////                    RevisionID = Convert.ToInt32(RevisionID);
        ////                    BLRevisionFile blRev = new BLRevisionFile();
        ////                    RevisionName = blRev.GetRevisionFileByID(RevisionID).RevisionNo;
        ////                    fileUploadDir = fileUploadDir + "/" + RevisionName;
        ////                    filePath = filePath + "/" + RevisionName;
        ////                    TabName = RevisionName;
        ////                }
        ////                else if (MilestoneID > 0)
        ////                {
        ////                    BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
        ////                    MilestoneName = blMile.GetMilestoneByID(MilestoneID).MileStone;
        ////                    fileUploadDir = fileUploadDir + "/" + MilestoneName;
        ////                    filePath = filePath + "/" + MilestoneName;
        ////                    TabName = MilestoneName;
        ////                }
        ////                if (!Directory.Exists(fileUploadDir))
        ////                {
        ////                    Directory.CreateDirectory(fileUploadDir);
        ////                }

        ////                // Document doc = new Document();
        ////                if (System.IO.Path.GetExtension(file.FileName) == ".dwg")
        ////                {

        ////                    //string baseUrl = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + HttpContext.Current.Request.ApplicationPath.TrimEnd('/') + "/";
        ////                    string baseUrl = BasePage.GetFileServerPath;
        ////                    file.SaveAs(fileUploadDir + "/" + file.FileName);
        ////                    Program pr = new Program();
        ////                    //string url = pr.getPdfURL("http://104.42.227.90/workpacktest/CompanyDocs/Premat%20Solutions%20Pvt%20Ltd/projectDocuments/TS-01/2/ABT/blocks_and_tables_-_imperial.dwg");// (fileUploadDir + "/" + fileUpload1.FileName);
        ////                    string url = pr.getPdfURL("http:" + baseUrl + filePath + "/" + file.FileName);
        ////                    DownloadToDocs(url, fileUploadDir + "/" + file.FileName.Replace(".dwg", ".pdf"));
        ////                    //System.IO.File.Delete(fileUploadDir + "/" + fileUpload1.FileName);
        ////                }
        ////                else
        ////                {
        ////                    file.SaveAs(fileUploadDir + "/" + file.FileName);
        ////                }


        ////                filePath = filePath + "/" + file.FileName;
        ////                UploadDeliverableFile upfile = new UploadDeliverableFile();
        ////                upfile.FilePath = filePath;
        ////                upfile.DeliverableListID = DeliverableID;
        ////                upfile.FileName = System.IO.Path.GetFileNameWithoutExtension(file.FileName);
        ////                upfile.FileExtention = System.IO.Path.GetExtension(file.FileName);
        ////                upfile.FileSize = (int)file.ContentLength;
        ////                upfile.MilestoneID = MilestoneID;
        ////                upfile.RevisionID = RevisionID;
        ////                upfile.CreatedOn = DateTime.Now;
        ////                upfile.CreatedBy = UserID;
        ////                upfile.Status = 0; //0 for uploaded
        ////                upfile.EntityState = DominModel.EntityState.Added;

        ////                blUpld.AddUploadDeliverableFile(upfile);

        ////                if (System.IO.Path.GetExtension(file.FileName) == ".dwg")
        ////                {
        ////                    upfile.EntityState = DominModel.EntityState.Modified;
        ////                    upfile.Dwgfileid = upfile.UploadDeliverableFileID;
        ////                    blUpld.UpdateUploadDeliverableFile(upfile);
        ////                }
        ////                //deliverable progress update
        ////                int result = blUpld.UpdateProgressDeliverable(MilestoneID, Convert.ToInt32(Common.DocStatusID.Upload), DeliverableID, RevisionID, 0, "U");
        ////                //end deliverable progress update
        ////                //add log in activity log table 1
        ////                BLActivityLogRepository objActLog = new BLActivityLogRepository();
        ////                string LoggedUserName = Convert.ToString(user.FirstName + ' ' + user.LastName);
        ////                objActLog.AddActivityLogByFileID(LoggedUserName, Convert.ToInt32(upfile.UploadDeliverableFileID), Common.MessageConstants.Fileuploaded);
        ////                addCustomPropertiesToFile(upfile, Company.CompanyId);

        ////                //add to index
        ////                String CompanyName = Convert.ToString(Company.ComanyName).Trim('.');
        ////                if (Client == "W")
        ////                {
        ////                    HttpContext.Current.Session["UploadedFileID"] = upfile.UploadDeliverableFileID;
        ////                    HttpContext.Current.Session["FileUploaded"] = file.FileName;
        ////                }

        ////                try
        ////                {
        ////                    if (System.IO.Path.GetExtension(file.FileName).ToUpper() == ".PDF")
        ////                    {
        ////                        string _luceneDir = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "CustomSearch_index", CompanyName);
        ////                        //string Lucenepath=Server.MapPath("~/CompanyDocs/" + Convert.ToString(Session["ComanyName"]).Trim('.') + "/projectDocuments/" + prj.ProjectCode.ToString()) + "/" + Convert.ToString(task.TaskNo);

        ////                        BLIndexDatatable objindex = new BLIndexDatatable();
        ////                        if (!Directory.Exists(_luceneDir))
        ////                        {
        ////                            BusinessLogic.CustomSearch._luceneDir = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "CustomSearch_index", CompanyName);
        ////                            Directory.CreateDirectory(BusinessLogic.CustomSearch._luceneDir);
        ////                        }
        ////                        //if (!Directory.Exists(_luceneDir))
        ////                        //    Directory.CreateDirectory(_luceneDir);
        ////                        objindex.AddToDatatable(Convert.ToInt32(upfile.UploadDeliverableFileID), (fileUploadDir + "/" + file.FileName), System.IO.Path.GetFileNameWithoutExtension(file.FileName), System.IO.Path.GetExtension(file.FileName), task.TaskName);
        ////                        //end to index
        ////                    }
                            
        ////                }
        ////                catch (Exception exx) { }

        ////                TrackFileUpload(TabName, DeliverableID, UserID);

        ////                //Send Notification to Selected Roles For this progresslevel on upload 
        ////                BLMessageRepository blMes = new BLMessageRepository();
        ////                blMes.SendNotificationToSelectedRolesAtSpecificWorkFlowStatge(upfile.UploadDeliverableFileID, DeliverableID, "Upload"); //DocStageId for Upload is one

        ////                return upfile.UploadDeliverableFileID;
        ////            }
        ////            return 0;
        ////        }
        ////        else
        ////        {
        ////            var cc = 0;

        ////            using (var context = new Cubicle_EntityEntities())
        ////            {
        ////                cc = (from d in context.UploadDeliverableFiles
        ////                      join f in context.FileCheckers on
        ////                      d.UploadDeliverableFileID equals f.UploadDeliverableFileID
        ////                      where d.MilestoneID == MilestoneID && d.DeliverableListID == DeliverableID && f.CanEdit == "Y"
        ////                      select d.UploadDeliverableFileID).Max();
        ////            }

        ////            string filePath = "";
        ////            string fileUploadDir = "";
        ////            string RevisionName = "", MilestoneName = "", TabName = "";

        ////            if (Company != null && Convert.ToInt32(Common.CompanyID.Spectrum) == Company.CompanyId)
        ////            {

        ////                fileUploadDir = HttpContext.Current.Server.MapPath("~/CompanyDocs/" + Convert.ToString(Company.ComanyName).Trim('.') + "/projectDocuments/" + prj.ProjectCode.ToString()) + "/" + Convert.ToString(task.TaskNo);
        ////                filePath = "~/CompanyDocs/" + Convert.ToString(Company.ComanyName).Trim('.') + "/projectDocuments/" + prj.ProjectCode.ToString() + "/" + Convert.ToString(task.TaskNo);
        ////            }
        ////            else
        ////            {
        ////                //Decouple Changes
        ////                fileUploadDir = BasePage.networkdirectorypath + "\\" + Convert.ToString(Company.ComanyName).Trim('.') + "\\" + prj.ProjectCode + "\\" + deptname + "\\" + task.DeliverableNo;
        ////                filePath = Convert.ToString(Company.ComanyName).Trim('.') + "/" + prj.ProjectCode + "/" + deptname + "/" + task.DeliverableNo;
        ////            }


        ////            if (RevisionID > 0)
        ////            {
        ////                RevisionID = Convert.ToInt32(RevisionID);
        ////                BLRevisionFile blRev = new BLRevisionFile();
        ////                RevisionName = blRev.GetRevisionFileByID(RevisionID).RevisionNo;
        ////                fileUploadDir = fileUploadDir + "/" + RevisionName;
        ////                filePath = filePath + "/" + RevisionName;
        ////                TabName = RevisionName;
        ////            }
        ////            else if (MilestoneID > 0)
        ////            {
        ////                BLProjectMilestoneRepository blMile = new BLProjectMilestoneRepository();
        ////                MilestoneName = blMile.GetMilestoneByID(MilestoneID).MileStone;
        ////                fileUploadDir = fileUploadDir + "/" + MilestoneName;
        ////                filePath = filePath + "/" + MilestoneName;
        ////                TabName = MilestoneName;
        ////            }

        ////            fileUploadDir = fileUploadDir + "\\" + "Attachments";
        ////            if (!Directory.Exists(fileUploadDir))
        ////            {
        ////                Directory.CreateDirectory(fileUploadDir);
        ////            }

        ////            /* Save the file on the server */
        ////            List<CheckerAttachmentFile> afLst = new List<CheckerAttachmentFile>();
        ////            string strFileName = blattach.Checkattachmentfilifexists(0, file.FileName, "AttachmentFile", DeliverableID, MilestoneID, RevisionID);
        ////            file.SaveAs(fileUploadDir + "\\" + strFileName);
        ////            filePath = filePath + "/Attachments/" + strFileName;
        ////            CheckerAttachmentFile af = new CheckerAttachmentFile();
        ////            af.FilePath = filePath;
        ////            //af.FileID = cc;
        ////            af.FileName = Path.GetFileNameWithoutExtension(strFileName);
        ////            af.FileExtention = Path.GetExtension(strFileName);
        ////            af.FileSize = (int)file.ContentLength;
        ////            af.CanDelete = "Y";
        ////            af.DeliverableListID = DeliverableID;
        ////            if (RevisionID == 0)
        ////            {
        ////                af.MilestoneID = MilestoneID;
        ////                af.RevisionID = 0;
        ////            }
        ////            else
        ////            {
        ////                af.MilestoneID = 0;
        ////                af.RevisionID = RevisionID;
        ////            }
        ////            af.CreatedBy = Convert.ToString(UserID);
        ////            af.CreatedOn = DateTime.Now;
        ////            af.ModifiedBy = Convert.ToString(cc);
        ////            af.EntityState = DominModel.EntityState.Added;
        ////            afLst.Add(af);

        ////            blAttach.AddAttachmentFile(afLst.ToArray());

        ////            return 0;
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
        ////        return 0;
        ////    }

        ////}

        private void DownloadToDocs(string url, string localFile)
        {
            ////var client = new HttpClient();
            ////var content = (StreamContent)client.GetAsync(url).Result.Content;
            ////var fname = localFile;
            ////using (var output = System.IO.File.Create(fname))
            ////{
            ////    content.ReadAsStreamAsync().Result.CopyTo(output);
            ////    output.Close();

            ////}

        }


        private void addCustomPropertiesToFile(UploadDeliverableFile file, int CompanyID)
        {
            ////string myPath = file.FilePath;
            ////OleDocumentProperties myFile = new DSOFile.OleDocumentProperties();
            ////myFile.Open(getPath(myPath, CompanyID), false, DSOFile.dsoFileOpenOptions.dsoOptionDefault);
            ////myFile.SummaryProperties.Keywords = "FileId:" + Convert.ToString(file.UploadDeliverableFileID) + ";";

         
            ////myFile.Save();
            ////myFile.Close(true);

            ////myPath = myPath.Substring(0, myPath.LastIndexOf("/"));
            ////myFile.Open(getPath(myPath, CompanyID), false, DSOFile.dsoFileOpenOptions.dsoOptionDefault);
            ////myFile.SummaryProperties.Keywords = "DeliverableId:" + Convert.ToString(file.DeliverableListID) + ";MilestoneId:" + Convert.ToString(file.MilestoneID) + ";RevisionID:" + Convert.ToString(file.RevisionID);

            ////myFile.Save();
            ////myFile.Close(true);


            ////myPath = myPath.Substring(0, myPath.LastIndexOf("/"));
            ////myFile.Open(getPath(myPath, CompanyID), false, DSOFile.dsoFileOpenOptions.dsoOptionDefault);
            ////myFile.SummaryProperties.Keywords = "DeliverableId:" + Convert.ToString(file.DeliverableListID) + ";";

            ////myFile.Save();
            ////myFile.Close(true);

         

        }

        private string getPath(string filePath, int CompanyID)
        {
            return "";

            //if (CompanyID > 0 && Convert.ToInt32(Common.CompanyID.Spectrum) == CompanyID)
            //{
            //    filePath = HttpContext.Current.Server.MapPath(filePath);
            //    return filePath;
            //}
            //else
            //    return BasePage.networkdirectorypath + filePath;

        }

        public void TrackFileUpload(string TabName, int DeliverableID, string UserID)
        {
            //string proj = "";
            //string delname = "";
            //BLUserActivityTrackerRepository tracker = new BLUserActivityTrackerRepository();
            //DominModel.UserActivityTracker useractivity = new DominModel.UserActivityTracker();
            //BLUploadDeliverableFile blUpld = new BLUploadDeliverableFile();
            //BLTaskListRepository task = new BLTaskListRepository();
            //ProjectTaskList pr = task.GetTaskListByID(DeliverableID);
            //Project prj = blUpld.getProjectByDeliverableID(DeliverableID);
            //proj = prj.ProjectName;
            //delname = pr.TaskName;
        
            //useractivity.CreatedBy = UserID;
            //useractivity.CreatedOn = DateTime.Now;
            //useractivity.Page = "Deliverable Details";
            //useractivity.Event = "File Uploaded";
            //useractivity.Text = TabName + " " + "file uploaded" + "-" + delname + " " + "for" + " " + proj;
            //useractivity.EntityState = DominModel.EntityState.Added;
            //tracker.AddUserActivityTracker(useractivity);

        }

    }



    public class RectAndText
    {
        public iTextSharp.text.Rectangle Rect;
        public String Text;
        public int pageIndex;
        public float x;
        public float y;
        public double pageHeight;
        public double pageWidth;
        public RectAndText(iTextSharp.text.Rectangle rect, String text, int pageIndex, float x, float y)
        {
            this.Rect = rect;
            this.Text = text;
            this.pageIndex = pageIndex;
            this.x = x;
            this.y = y;
        }
    }
}
