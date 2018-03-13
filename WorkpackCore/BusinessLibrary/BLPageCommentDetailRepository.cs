using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLPageCommentDetailRepository : IBLPageCommentDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<PageCommentDetail> _pageCommentDetailRepository;

        public BLPageCommentDetailRepository(WorkpackDBContext context, IGenericDataRepository<PageCommentDetail> pageCommentDetailRepository)
        {
            _context = context;
            _pageCommentDetailRepository = pageCommentDetailRepository;
        }
        public IList<PageCommentDetail> GetAllPageCommentDetail()
        {
            return _pageCommentDetailRepository.GetAll();
        }
        public PageCommentDetail GetPageCommentDetailByID(Int32 PageCommentDetailID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _pageCommentDetailRepository.GetSingle(d => d.PageCommentDetailID == PageCommentDetailID);
            //include related employees
        }

        public PageCommentDetail GetPageCommentDetailByID(long commentclientid)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _pageCommentDetailRepository.GetSingle(d => d.CommentClientid == commentclientid);
            //include related employees
        }
        public void AddPageCommentDetail(params PageCommentDetail[] pageCommentDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _pageCommentDetailRepository.Add(pageCommentDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdatePageCommentDetail(params PageCommentDetail[] pageCommentDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _pageCommentDetailRepository.Update(pageCommentDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }

        public List<string> isAnyResponsePresentAgainstCommentsByUserCheckerID(int FileID)
        {
            List<string> res = new List<string>();

            try
            {

                //using (var db = new Cubicle_EntityEntities())
                //{
                //    res = (from pc in db.PageCommentDetails
                //           join pch in db.PageCommentHistories on pc.PageCommentDetailID equals pch.PageCommentDetailID
                //           where pc.UploadDeliverableFileID == FileID
                //               && pch.ResponseText != null
                //           select pch.CreatedBy).ToList();

                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public void RemovePageCommentDetail(params PageCommentDetail[] pageCommentDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _pageCommentDetailRepository.Remove(pageCommentDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }

        public IList<usp_GetPageCommentDetails_Result> GetPageCommentDetail(int fileID, int OwnerID)
        {
            IList<usp_GetPageCommentDetails_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_GetPageCommentDetails(fileID, OwnerID).ToList<usp_GetPageCommentDetails_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public IList<usp_GetPageCommentDetailsForApprov_Result> GetPageCommentDetailForApprove(int FileID, string UserID)
        {
            IList<usp_GetPageCommentDetailsForApprov_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_GetPageCommentDetailsForApprov(FileID, UserID).ToList<usp_GetPageCommentDetailsForApprov_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public void GetDeliverableDetails(int FileID, out string ProjectInfo, out string DeliverableInfo, out string DeliverableID)
        {
            ProjectInfo = "";
            DeliverableInfo = "";
            DeliverableID = "0";
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var fid = (from f in db.UploadDeliverableFiles where f.UploadDeliverableFileID == FileID select f.DeliverableListID).FirstOrDefault();
                //    var deliverable = (from d in db.ProjectTaskLists where d.ProjectTaskID == fid select d).FirstOrDefault();

                //    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
                //    var project = blProject.GetProjectByID(deliverable.ProjectID);

                //    DeliverableID = Convert.ToString(fid.Value);
                //    ProjectInfo = project.ProjectName + "-" + project.ProjectCode;
                //    DeliverableInfo = deliverable.TaskName + "-" + Convert.ToString(deliverable.DeliverableNo);
                //}
            }
            catch (Exception ex)
            {
            }
        }

        public static IList<SP_GENERATE_TABS_Result> GenerateTabs(String UserID, String Flag, int DeliverableListID)
        {
            IList<SP_GENERATE_TABS_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.SP_GENERATE_TABS(UserID, DeliverableListID, Flag).ToList<SP_GENERATE_TABS_Result>();
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
        public static Boolean isAllCommentsApproved(int FileID)
        {
            Boolean res = false;
            try
            {
                //int CommentStatus = Convert.ToInt32(Common.CommentStatusID.Accepted);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var CommentList = from c in db.PageCommentDetails where c.UploadDeliverableFileID == FileID select c;
                //    if (CommentList.Count() == CommentList.Count(p => p.CommentStatus == CommentStatus))
                //        res = true;
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public Boolean isAllCommentsResponsedByOwner(int FileID, string checkerID)
        {
            Boolean res = false;
            Boolean AllCheckerHasCommented = true;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var CommentList = from c in db.PageCommentDetails where c.UploadDeliverableFileID == FileID && c.CommentedBy == checkerID select c;

                //    var CommentListCount = CommentList.Where(a => a.Response == null);
                //    if (CommentList.Count() > 0 && CommentListCount.Count() == 0)
                //        res = true;
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public static string[] GetAllUserRolesByFile(int FileID)
        {
            string res = "";
            try
            {
                //int CommentStatus = Convert.ToInt32(Common.CommentStatusID.Accepted);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var owner = (from d in db.ProjectTaskLists where (from u in db.UploadDeliverableFiles where u.UploadDeliverableFileID == FileID select u.DeliverableListID).Contains(d.ProjectTaskID) select d.TaskOwner).FirstOrDefault();
                //    res = Convert.ToString(owner) + ",";
                //    var CommentList = from f in db.FileCheckers where f.UploadDeliverableFileID == FileID select f.UserID;
                //    foreach (var u in CommentList)
                //        res = res + u + ",";
                //    res = res.TrimEnd(',');

                //}
            }
            catch (Exception ex)
            {
            }
            return res.Split(',');
        }
        public int getUnapprovedCommentCount(int FileID)
        {
            int? cnt = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    cnt = context.usp_getUnapprovedCommentCount(FileID).SingleOrDefault();
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
            return Convert.ToInt32(cnt);
        }

        public static List<FileUploadDirectoryFolderStructure> GetFileUploadDirectoryFolderStructure(int FileID)
        {
            List<FileUploadDirectoryFolderStructure> q = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    q = (from pd in context.UploadDeliverableFiles
                //         join od in context.ProjectTaskLists on pd.DeliverableListID equals od.ProjectTaskID
                //         join pr in context.Projects on od.ProjectID equals pr.ProjectID
                //         where pd.UploadDeliverableFileID == FileID
                //         select new FileUploadDirectoryFolderStructure
                //         {
                //             ProjectID = pr.ProjectID,
                //             ProjectCode = pr.ProjectCode,
                //             DeliverableID = od.ProjectTaskID,
                //             DeliverableNumber = od.TaskNo,
                //             FileName = pd.FileName,
                //             FileID = pd.UploadDeliverableFileID
                //         }).Distinct().ToList<FileUploadDirectoryFolderStructure>();
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

            return q;
        }

        public static int GetCommentsListByFileAndUserID(int FileID, string UserID)
        {
            int res = 0;
            //BLPageDetailRepository blpage = new BLPageDetailRepository();
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var count = 0;
                //    var pages = blpage.GetPageDetails(FileID);
                //    foreach (var page in pages)
                //    {
                //        var comments = page.PageCommentDetails.Count(p => p.CommentedBy == UserID);
                //        var circles = page.PageCircleDetails.Count(p => p.CreatedBy == UserID);
                //        var line = page.PageLineDetails.Count(p => p.CreatedBy == UserID);
                //        var rect = page.PageRecDetails.Count(p => p.CreatedBy == UserID);
                //        count = count + comments + circles + line + rect;
                //    }
                //    res = count;
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
        public static List<CommentByEmailIdByFileID> GetCommentByEmailIdByFileID(int FileID)
        {
            List<CommentByEmailIdByFileID> q = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    q = (from pd in context.PageCommentDetails
                //         join od in context.PageDetails on pd.UploadDeliverableFileID equals od.FileID
                //         join U in context.Users on pd.CommentedBy equals string.Concat(U.UserID)
                //         where pd.UploadDeliverableFileID == FileID
                //         select new CommentByEmailIdByFileID
                //         {
                //             UserID = pd.CommentedBy,
                //             EmailID = U.EmailId

                //         }).Distinct().ToList<CommentByEmailIdByFileID>();
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

            return q;
        }

        public static List<UserIDOfAllChkCoOr> GetAllUserIdByDeliverableListID(int DeliverableListID)
        {
            List<UserIDOfAllChkCoOr> q = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    q = (from pd in context.FileCheckers
                //         join od in context.UploadDeliverableFiles on pd.UploadDeliverableFileID equals od.UploadDeliverableFileID
                //         where od.DeliverableListID == DeliverableListID && pd.IsClient != "Y"
                //         select new UserIDOfAllChkCoOr
                //         {
                //             UserID = pd.UserID

                //         }).Distinct().ToList<UserIDOfAllChkCoOr>();
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
            return q;
        }

        public static List<PageCommentDetail> GetAllCommentsByFileID(int FileID)
        {
            List<PageCommentDetail> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from c in db.PageCommentDetails where c.UploadDeliverableFileID == FileID select c).ToList();
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


        public List<PageCommentDetail> getPageCommentByFileIdAndUserId(int FileID, string UserID)
        {
            List<PageCommentDetail> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from c in db.PageCommentDetails where c.UploadDeliverableFileID == FileID && c.CommentedBy == UserID select c).ToList();
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

        public static bool isAllCommentsApprovedFromCheker(int FileID)
        {
            bool res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    int approve = Convert.ToInt32(Common.FileStatusID.Approved);
                //    var FilestatusList = from c in db.FileStatus where c.FileID == FileID select c;
                //    if (FilestatusList.Count() == FilestatusList.Count(p => p.StatusID == approve))
                //        res = true;
                //}
            }
            catch (Exception ex)
            {
                res = false;
                throw ex;
            }
            return res;
        }

        public bool deletecommentfrompdfjs(int commentdetailsid)
        {

            bool success = false;
            //using (var ts = new TransactionScope())
            //{
            //    try
            //    {
            //        BLPageComment_imagesRepository blpcimg = new BLPageComment_imagesRepository();
            //        List<PageComment_images> lstpagecomimages = blpcimg.GetPageComment_imagesbycommentdetailsid(commentdetailsid).ToList();
            //        lstpagecomimages.ForEach(e => e.EntityState = DominModel.EntityState.Deleted);
            //        blpcimg.RemovePageComment_images(lstpagecomimages.ToArray());

            //        BLPageCommentHistoryRepository blpch = new BLPageCommentHistoryRepository();
            //        List<PageCommentHistory> lstpagehis = blpch.GetAllPageCommentHistoryByCommentDetailID(commentdetailsid);
            //        lstpagehis.ForEach(e => e.EntityState = DominModel.EntityState.Deleted);
            //        blpch.RemovePageCommentHistory(lstpagehis.ToArray());

            //        PageCommentDetail pcd = GetPageCommentDetailByID(commentdetailsid);
            //        pcd.EntityState = DominModel.EntityState.Deleted;

            //        RemovePageCommentDetail(pcd);

            //        ts.Complete();

            //        success = true;

            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //    }
            //}

            return success;
        }
    }

    public class CommentByEmailIdByFileID
    {
        public string UserID { get; set; }
        public string EmailID { get; set; }
    }
    public class UserIDOfAllChkCoOr
    {
        public string UserID { get; set; }
    }
    public class FileUploadDirectoryFolderStructure
    {
        public int ProjectID { get; set; }
        public string ProjectCode { get; set; }
        public int DeliverableID { get; set; }
        public int? DeliverableNumber { get; set; }
        public string FileName { get; set; }
        public int FileID { get; set; }
    }
}

