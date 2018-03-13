using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLCommentRepository : IBLCommentRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Comment> _commentRepository;

        public BLCommentRepository(WorkpackDBContext context, IGenericDataRepository<Comment> commentRepository)
        {
            _context = context;
            _commentRepository = commentRepository;
        }

        public IList<Comment> GetAllComments()
        {
            return _commentRepository.GetAll();
        }
        public Comment GetCommentByID(Int32 commentID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _commentRepository.GetSingle(d => d.CommentID == commentID);
            //include related employees
        }
        public void AddComment(params Comment[] comment)
        {
            /* Validation and error handling omitted */
            try
            {
                _commentRepository.Add(comment);
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
        public void UpdateComment(params Comment[] comment)
        {
            /* Validation and error handling omitted */
            try
            {
                _commentRepository.Update(comment);
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
        public void RemoveComment(params Comment[] comment)
        {
            /* Validation and error handling omitted */
            try
            {
                _commentRepository.Remove(comment);
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

        public static IList<usp_GetCommentsByResourceRequestID_Result> GetComments(Int32 ID)
        {
            IList<usp_GetCommentsByResourceRequestID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetCommentsByResourceRequestID(ID).ToList<usp_GetCommentsByResourceRequestID_Result>();
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
        public IList<Comment> GetCommentRecordsOnly(Int32 ID)
        {
            return _commentRepository.GetList(p => p.ID == ID);
        }

        public static IList<usp_GetCommentsByParentID_Result> GetCommentsByParentID(Int32 ID, int ProjectID)
        {
            IList<usp_GetCommentsByParentID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetCommentsByParentID(ID, ProjectID).ToList<usp_GetCommentsByParentID_Result>();
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

        public static IList<usp_GetCommentsByChildID_Result> GetCommentsByChildID(Int32 ID, Int32 ProjectID, String CommentFor)
        {
            IList<usp_GetCommentsByChildID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetCommentsByChildID(ID, ProjectID, CommentFor).ToList<usp_GetCommentsByChildID_Result>();
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


        public static IList<usp_GetCommentsByProjectID_Result> GetActiveCommentsByProjectID(Int32 ProjectID)
        {
            IList<usp_GetCommentsByProjectID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetCommentsByProjectID(ProjectID).ToList<usp_GetCommentsByProjectID_Result>();
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


        public static List<usp_GetCommentsByProjectIdAndID_Result> GetCommentsByProjectIdAndID(int ProjectID, int EstimationTaskID)
        {
            List<usp_GetCommentsByProjectIdAndID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetCommentsByProjectIdAndID(ProjectID, EstimationTaskID).ToList<usp_GetCommentsByProjectIdAndID_Result>();
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
        public List<Comment> GetAllCommentByTaskID(int TaskID)
        {
            List<Comment> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.Comments.Where(c => c.ChildID == TaskID).ToList<Comment>();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;

        }
        public static List<usp_GetComment_Result> getComment(int ParentID, int ChildId, int ProjectID)
        {
            List<usp_GetComment_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetComment(ParentID, ChildId, ProjectID).ToList<usp_GetComment_Result>();
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


        //public string GenerateTabsMenu(List<usp_getAllRevisionByProjectID_Result> list, int FileID, int DeliverableID, Label lbl, string status)
        //{
        //    //List<usp_getAllRevisionByProjectID_Result> remotab = new List<usp_getAllRevisionByProjectID_Result>();
        //    //List<usp_getAllRevisionByProjectID_Result> tablist = new List<usp_getAllRevisionByProjectID_Result>();
        //    //StringBuilder vsStrBldrIntial = new StringBuilder();

        //    ////begin remove tabs which have no files uploaded
        //    //for (int i = 0; i < list.Count(); i++)
        //    //{
        //    //    using (var context = new Cubicle_EntityEntities())
        //    //    {
        //    //        if (list[i].RevisionID > 0)
        //    //        {
        //    //            int? RevisionID = list[i].RevisionID;
        //    //            int count = context.UploadDeliverableFiles.Where(c => c.RevisionID == RevisionID && c.DeliverableListID == (int)DeliverableID).ToList().Count();
        //    //            if (count == 0)
        //    //                remotab.Add(list[i]);
        //    //        }
        //    //        else
        //    //        {
        //    //            int? Milestoneid = list[i].MilestoneID;
        //    //            int count = context.UploadDeliverableFiles.Where(c => c.MilestoneID == Milestoneid && c.DeliverableListID == (int)DeliverableID).ToList().Count();
        //    //            if (count == 0)
        //    //                remotab.Add(list[i]);
        //    //        }
        //    //    }
        //    //}

        //    //tablist = list.Where(p => !remotab.Any(p2 => p2.TabName == p.TabName)).ToList();
        //    ////end remove tabs which have no files uploaded

        //    //string active = "";
        //    //vsStrBldrIntial.Append("<ul class='nav'>");
        //    //using (var context = new Cubicle_EntityEntities())
        //    //{
        //    //    var activetabfile = context.UploadDeliverableFiles.Where(c => c.UploadDeliverableFileID == FileID).FirstOrDefault();
        //    //    var activetab = "";
        //    //    if (activetabfile.RevisionID > 0)
        //    //    {
        //    //        activetab = context.RevisionFiles.Where(c => c.RevisionID == activetabfile.RevisionID).SingleOrDefault().RevisionNo;
        //    //    }
        //    //    else
        //    //    {
        //    //        activetab = context.ProjectMilestones.Where(c => c.ProjectMilestoneID == activetabfile.MilestoneID).SingleOrDefault().ProjectMilestone1;
        //    //    }
        //    //    if (status == "Active")
        //    //    {
        //    //        lbl.Visible = false;
        //    //        lbl.Text = "File Name : " + activetabfile.FileName;
        //    //    }
        //    //    foreach (var tab in tablist)
        //    //    {
        //    //        if (status == "Active")
        //    //        {
        //    //            if (activetab == tab.TabName)
        //    //                active = "active";
        //    //            else
        //    //                active = "";
        //    //        }
        //    //        else
        //    //        {
        //    //            active = "dropdown";
        //    //        }
        //    //        vsStrBldrIntial.Append("<li class='" + active + "'> <a href='#' class='dropdown-toggle' data-toggle='dropdown'>" + tab.TabName + "");
        //    //        vsStrBldrIntial.Append("</a>");
        //    //        vsStrBldrIntial.Append("<ul class='dropdown-menuUp'>");
        //    //        vsStrBldrIntial.Append("<li class='menu'>");
        //    //        vsStrBldrIntial.Append("<ul class='notif'>");
        //    //        if (tab.RevisionID > 0)
        //    //        {
        //    //            var lsttabfiles = context.UploadDeliverableFiles.Where(c => c.DeliverableListID == (int)DeliverableID && c.RevisionID == tab.RevisionID).ToList<UploadDeliverableFile>();
        //    //            foreach (var item in lsttabfiles)
        //    //            {
        //    //                var vfileID = item.UploadDeliverableFileID;
        //    //                var vFileName = item.FileName;
        //    //                vsStrBldrIntial.Append("<li>  <span class='msg'> <a  href='CommentResolution.aspx?FILEID=" + Convert.ToString(item.UploadDeliverableFileID) + "&Flter=-1" + "' target='_self'> " + Convert.ToString(item.FileName) + "</a></span></li>");
        //    //            }
        //    //        }
        //    //        else
        //    //        {
        //    //            var lsttabfiles = context.UploadDeliverableFiles.Where(c => c.DeliverableListID == (int)DeliverableID && c.MilestoneID == tab.MilestoneID).ToList<UploadDeliverableFile>();
        //    //            foreach (var item in lsttabfiles)
        //    //            {
        //    //                var vfileID = item.UploadDeliverableFileID;
        //    //                var vFileName = item.FileName;
        //    //                vsStrBldrIntial.Append("<li>  <span class='msg'> <a  href='CommentResolution.aspx?FILEID=" + Convert.ToString(item.UploadDeliverableFileID) + "&Flter=-1" + "' target='_self'> " + Convert.ToString(item.FileName) + "</a></span></li>");
        //    //            }
        //    //        }
        //    //        vsStrBldrIntial.Append("</ul>");
        //    //        vsStrBldrIntial.Append("</li>");
        //    //        vsStrBldrIntial.Append("</ul>");
        //    //        vsStrBldrIntial.Append("</li>");
        //    //    }
        //    //}
        //    //vsStrBldrIntial.Append("</ul>");
        //    //return vsStrBldrIntial.ToString();

        //    return "";
        //}


    }
}
