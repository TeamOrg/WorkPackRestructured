using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLActivityLogRepository : IBLActivityLogRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ActivityLog> _ActivityLog;

        public BLActivityLogRepository(WorkpackDBContext context, IGenericDataRepository<ActivityLog> activityLog)
        {
            _context = context;
            _ActivityLog = activityLog;
        }
        
        public IList<ActivityLog> GetAllActivityLog()
        {
            return _ActivityLog.GetAll();
        }

        public ActivityLog GetActivityLogByID(int ActivityLogID)
        {
            return _ActivityLog.GetSingle(d => d.ActivityLogID == ActivityLogID);
        }
        public void AddActivityLog(params ActivityLog[] ActivityLog)
        {
            try
            {
                _ActivityLog.Add(ActivityLog);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not added.");
            }
        }
        public void UpdateActivityLog(params ActivityLog[] activityLog)
        {
            try
            {
                _ActivityLog.Update(activityLog);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not updated.");
            }
        }


        public void AddActivityLogByFileID(string ActionBy,int FileID,string Action)
        {
            //try
            //{
            //    int deliverableID = 0;
            //    int iMilestoneID = 0;
            //    int iRevisionID = 0;
            //    string fileName = "";
            //    string Rev = "";
            //    string Stage = "";


            //    List<ActivityLog> lstActivityLog = new List<ActivityLog>();
            //    BLUploadDeliverableFile objuploadDelRepository = new BLUploadDeliverableFile();
            //    BLProjectMilestoneRepository objPM = new BLProjectMilestoneRepository();
            //    BLRevisionFile objRF = new BLRevisionFile();
            //    UploadDeliverableFile lstUploadDeliverableFile = null;
            //    ProjectMilestone lstProjectMilestone = null;
            //    RevisionFile lstRevisionFile = null;
            //    int uploadDeliverableFileID = Convert.ToInt32(FileID);
            //    lstUploadDeliverableFile = objuploadDelRepository.GetUploadDeliverableFileByID(uploadDeliverableFileID);
            //    deliverableID = Convert.ToInt32(lstUploadDeliverableFile.DeliverableListID);
            //    iMilestoneID = Convert.ToInt32(lstUploadDeliverableFile.MilestoneID);
            //    iRevisionID = Convert.ToInt32(lstUploadDeliverableFile.RevisionID);
            //    fileName = Convert.ToString(lstUploadDeliverableFile.FileName);
            //    if (iRevisionID != 0)
            //    {
            //        lstRevisionFile = objRF.GetRevisionFileByID(iRevisionID);

            //        Rev = Convert.ToString(lstRevisionFile.RevNumber);
            //        if (Rev.Length == 1)
            //        {
            //            Rev = "0" + Rev;
            //        }
            //        Stage = lstRevisionFile.RevisionNo;
            //    }
            //    else
            //    {
            //        lstProjectMilestone = objPM.GetMilestoneByID(iMilestoneID);
            //        Rev = "00";
            //        Stage = lstProjectMilestone.ProjectMilestone1;
            //    }
            //    ActivityLog ActLog = new ActivityLog();
            //    ActLog.ActivityLogID = 0;
            //    ActLog.ProjectTaskID = deliverableID;
            //    ActLog.FileID = FileID;
            //    ActLog.RevNumber = Rev;
            //    ActLog.RevName = Stage;
            //    ActLog.Action = Action;
            //    ActLog.ActionBy = ActionBy;
            //    ActLog.ActionDate = DateTime.Now;
            //    ActLog.EntityState = EntityState.Added;
            //    lstActivityLog.Add(ActLog);
            //    AddActivityLog(lstActivityLog.ToArray());


            //}
            //catch (Exception ex)
            //{
            //    ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    //throw new Exception("Record not updated.");
            //}
        }





        public void RemoveActivityLog(params ActivityLog[] activityLog)
        {
            try
            {
                _ActivityLog.Remove(activityLog);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not deleted.");
            }
        }

      

      





    }
}
