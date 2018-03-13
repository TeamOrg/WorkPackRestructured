using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLRelatedTasksRepository : IBLRelatedTasksRepository
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<RelatedTask> _relatedTasksRepository;
        public BLRelatedTasksRepository(WorkpackDBContext context, IGenericDataRepository<RelatedTask> relatedTasksRepository)
        {
            _context = context;
            _relatedTasksRepository = relatedTasksRepository;
        }
        public IList<RelatedTask> GetRelatedTaskByID(Int32 TaskMilestoneBookedQtyID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            //return _relatedTasksRepository.(d => d.TaskMilestoneBookedQtyID == TaskMilestoneBookedQtyID);                
            //include related employees

            IList<RelatedTask> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.RelatedTasks.Where(a => a.TaskMilestoneBookedQtyID == TaskMilestoneBookedQtyID).ToList<RelatedTask>();
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
            return List;


        }

        public List<int> GetRelatedTaskByTaskID(int ProjectTaskid, int ProjectID, int Milestoneid)
        {

            List<int> lstrel = new List<int>();
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    lstrel = (from a in context.TaskMilestoneBookedQties
            //              join up in context.UploadDeliverableFiles on a.FileID equals up.UploadDeliverableFileID
            //              join p in context.ProjectTaskLists on a.TaskID equals p.ProjectTaskID
            //              join b in context.RelatedTasks on a.TaskMilestoneBookedQtyID equals b.TaskMilestoneBookedQtyID
            //              where a.TaskID != ProjectTaskid && p.ProjectID == ProjectID && a.MileStoneID == Milestoneid
            //              select b.TaskID.Value).Distinct().ToList<int>();

            //}

            return lstrel;

        }
        public List<int> GetPrevioslySelectedRelatedTaskTask(int FileId, int Milestoneid, int projectID)
        {
            List<int> lstids = new List<int>();
            //BLProjectMilestoneRepository blprojmile = new BLProjectMilestoneRepository();
            //BLUploadDeliverableFile blupfile = new BLUploadDeliverableFile();
            //BLTaskMilestoneBookedQtyRepository bltm = new BLTaskMilestoneBookedQtyRepository();
            //UploadDeliverableFile upfile = new UploadDeliverableFile();
            //TaskMilestoneBookedQty BookedQty = new TaskMilestoneBookedQty();
            //if (FileId > 0)
            //{
            //    BookedQty = bltm.GetTaskMilestoneBookedQtyByFileId(FileId).FirstOrDefault();

            //    upfile = blupfile.GetUploadDeliverableFileByID(FileId);
            //}
            //List<ProjectMilestone> lstmilestone = blprojmile.GetMilestoneByProjectID(projectID);
            //lstmilestone = lstmilestone.Where(x => x.ProjectMilestoneID < Milestoneid).OrderByDescending(x=>x.ProjectMilestoneID).ToList();
            //if (lstmilestone.Count() > 0 && Convert.ToInt32(Common.CompanyID.Spectrum) == Convert.ToInt32(HttpContext.Current.Session["CompanyId"]) && upfile!= null)
            //{
            //    ProjectMilestone tmbq = lstmilestone.Take(1).FirstOrDefault();
            //    List<UploadDeliverableFile> lstupload = blupfile.GetAllUploadDeliverableFile().Where(x => x.MilestoneID == tmbq.ProjectMilestoneID && x.DeliverableListID == upfile.DeliverableListID).ToList();
            //    lstupload = lstupload.Where(x => x.FileName.ToUpper() == upfile.FileName.ToUpper() && x.FileExtention.ToUpper() == upfile.FileExtention.ToUpper()).ToList();
            //    if (lstupload.Count > 0 && BookedQty == null)
            //    {
            //        UploadDeliverableFile upfilematch = lstupload.OrderByDescending(x=>x.UploadDeliverableFileID).FirstOrDefault();
            //        TaskMilestoneBookedQty BookedQtymatch = bltm.GetTaskMilestoneBookedQtyByFileId(upfilematch.UploadDeliverableFileID).FirstOrDefault();
            //        lstids = GetRelatedTaskByID(BookedQtymatch.TaskMilestoneBookedQtyID).Select(x => x.TaskID.Value).ToList();
            //    }

            //    else if (BookedQty != null)
            //    {

            //        lstids = GetRelatedTaskByID(BookedQty.TaskMilestoneBookedQtyID).Select(x => x.TaskID.Value).ToList();

            //    }
            //}

            //else if (BookedQty != null)
            //{

            //    lstids = GetRelatedTaskByID(BookedQty.TaskMilestoneBookedQtyID).Select(x => x.TaskID.Value).ToList();
            
            //}



            return lstids;



        }
        public List<object> GetRelatedTaskForDropdownByFileID(int FileId)
        {

            List<object> lstRelatedTask = new List<object>();
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    var lstRel = (from a in context.TaskMilestoneBookedQties
            //                  join up in context.UploadDeliverableFiles on a.FileID equals up.UploadDeliverableFileID
            //                  join b in context.RelatedTasks on a.TaskMilestoneBookedQtyID equals b.TaskMilestoneBookedQtyID
            //                  join p in context.ProjectTaskLists on b.TaskID equals p.ProjectTaskID
            //                  where up.UploadDeliverableFileID == FileId
            //                  select new { TaskID = b.TaskID, TaskName = p.TaskName });

            //    lstRelatedTask = lstRel.ToList<object>();
            //}
            return lstRelatedTask;
        }


        public List<RelatedTask> GetRelatedTaskByFileID(int FileId)
        {

            List<RelatedTask> lstRelatedTask = new List<RelatedTask>();
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    var lstRel = (from a in context.TaskMilestoneBookedQties
            //                  join up in context.UploadDeliverableFiles on a.FileID equals up.UploadDeliverableFileID
            //                  join b in context.RelatedTasks on a.TaskMilestoneBookedQtyID equals b.TaskMilestoneBookedQtyID
            //                  join p in context.ProjectTaskLists on b.TaskID equals p.ProjectTaskID
            //                  where up.UploadDeliverableFileID == FileId
            //                  select b);

            //    lstRelatedTask = lstRel.ToList<RelatedTask>();
            //}
            return lstRelatedTask;
        }


        public void AddRelatedTasks(params RelatedTask[] relatedTasks)
        {
            /* Validation and error handling omitted */
            try
            {
                _relatedTasksRepository.Add(relatedTasks);
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
        public void UpdateRelatedTasks(params RelatedTask[] relatedTasks)
        {
            /* Validation and error handling omitted */
            try
            {
                _relatedTasksRepository.Update(relatedTasks);
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
        public void RemoveRelatedTasks(params RelatedTask[] relatedTasks)
        {
            /* Validation and error handling omitted */
            try
            {
                _relatedTasksRepository.Remove(relatedTasks);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool WhetherAllRelatedTaskApproved(int FileID)
        {
            return false;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int countRelatedTask = (from r in context.RelatedTasks
            //                            join t in context.TaskMilestoneBookedQties on r.TaskMilestoneBookedQtyID equals t.TaskMilestoneBookedQtyID
            //                            where t.FileID == FileID 
            //                            select r).Count();

            //    int countApprovedRelatedTask = (from ar in context.ApprovalRelatedTasks
            //                                    join r in context.RelatedTasks on ar.TaskID equals r.TaskID
            //                                    join t in context.TaskMilestoneBookedQties on new { x = (int)r.TaskMilestoneBookedQtyID, y = (int)ar.UploadDeliverableFileID } equals new { x = t.TaskMilestoneBookedQtyID, y = t.FileID }
            //                                    where t.FileID == FileID
            //                                    select ar.TaskID).Distinct().Count();

            //    if (countRelatedTask == countApprovedRelatedTask)
            //        return true;
            //    else
            //        return false;
            //}

        }


    }
}
