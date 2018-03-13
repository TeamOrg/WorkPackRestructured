using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLRevisionFile : IBLRevisionFile
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<RevisionFile> _revisionFile;

        public BLRevisionFile(WorkpackDBContext context, IGenericDataRepository<RevisionFile> revisionFile)
        {
            _context = context;
            _revisionFile = revisionFile;
        }







        public IList<RevisionFile> GetAllRevisionFile()
        {
            return _revisionFile.GetAll();
        }
        public RevisionFile GetRevisionFileByID(int revisionFileID)
        {
            return _revisionFile.GetSingle(d => d.RevisionID == revisionFileID);
        }
        public void AddRevisionFile(params RevisionFile[] revisionFile)
        {
            try
            {
                _revisionFile.Add(revisionFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateRevisionFile(params RevisionFile[] revisionFile)
        {
            try
            {
                _revisionFile.Update(revisionFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveRevisionFile(params RevisionFile[] revisionFile)
        {
            try
            {
                _revisionFile.Remove(revisionFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
        public List<RevisionFile> GetRevisionFileByDeliverableID(int DeliverableID)
        {


            List<RevisionFile> lst = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    lst = context.RevisionFiles.Where(a => a.DeliverableID == DeliverableID).ToList<RevisionFile>();
             return lst;
            ////}
        }

        public RevisionFile GetRevisionFileByDeliverableIDandMilestoneID(int DeliverableID, int MilestoneId)
        {
            return _revisionFile.GetSingle(x => x.DeliverableID == DeliverableID && x.StatusID == MilestoneId);
        }


        public bool checkRevisionName(string RevisionName,int DeliverableID)
        {
           // BLDeliverableListRepository blDel = new BLDeliverableListRepository();
            bool res=true;
           try{
                //ProjectTaskList dlist = blDel.GetDeliverableListByID(DeliverableID);
                //List<usp_getAllRevisionByProjectID_Result> lst = blDel.getAllRevisionByDeliverableID(DeliverableID, dlist.TaskTypeID);
                //int i = lst.Count(p => p.TabName == RevisionName);
                //int i = context.RevisionFiles.Where(a => a.DeliverableID == DeliverableID && a.RevisionNo.StartsWith(RevisionName) && a.RevisionNo.EndsWith(RevisionName)).Count();
                //int iM = (from t in context.TaskMilestoneTargetDates
                //          join m in context.ProjectMilestones on t.MileStoneID equals m.ProjectMilestoneID
                //          where t.TaskID == DeliverableID && m.ProjectMilestone1.StartsWith(RevisionName) && m.ProjectMilestone1.EndsWith(RevisionName)
                //          select t).Count();
                //// int iM = context.proje.Where(a => a.DeliverableID == DeliverableID && a.RevisionNo.StartsWith(RevisionName) && a.RevisionNo.EndsWith(RevisionName)).Count();
                //if (i > 0 || iM>0)
                //if(i>0)
                //    res= true;
                //else
                //    res= false;
            }
            catch(Exception ex){
            }
            return res;
        }
        public bool addRevision(string RevisionName, int DeliverableID, int statusID, string UserID, string RevisionType)
        {


            return false;

    //        try
    //        {
    //            using (var context = new Cubicle_EntityEntities())
    //            {

    //                int i = 0;

    //                if(statusID>0)
    //                {
    //                    BLProjectMilestoneRepository blprm = new BLProjectMilestoneRepository();
    //                    ProjectMilestone prmile = blprm.GetMilestoneByID(statusID);
    //                    RevisionType = Convert.ToString(prmile.Type);

    //                    i = (from a in context.RevisionFiles where a.StatusID == statusID && a.DeliverableID == DeliverableID select a).ToList().Count();
    //                    i = i + 1;    
                     
                    
    //                }
    //                if (RevisionName != "" && DeliverableID != 0)
    //                {
    //                    BLRevisionFile blRev = new BLRevisionFile();
    //                    RevisionFile rev = new RevisionFile();
    //                    rev.RevisionNo = RevisionName;
    //                    rev.DeliverableID = DeliverableID;
    //                    rev.StatusID = statusID;
    //                    rev.CreatedOn = DateTime.Now;
    //                    rev.CreatedBy = UserID;
    //                    rev.Type = RevisionType;
    //                    rev.RevNumber = i;
    //                    rev.EntityState = DominModel.EntityState.Added;
    //                    blRev.AddRevisionFile(rev);
    //                    return true;
    //                }
    //                else
    //                {
    //                    return false;
    //                }

    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
    //            return false;
    //        }
     }
    }
}
