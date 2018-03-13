using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskProgressHistoryRepository : IBLTaskProgressHistoryRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskProgressHistory> _progresshistory;

        public BLTaskProgressHistoryRepository(WorkpackDBContext context, IGenericDataRepository<TaskProgressHistory> progresshistory)
        {
            _context = context;
            _progresshistory = progresshistory;
        }






        public IList<TaskProgressHistory> GetAllprogressHistory()
        {
            return _progresshistory.GetAll();
        }
        public IList<TaskProgressHistory> GetprogressHistoryByTaskIDCurrentDate(int TaskID)
        {
            IList<TaskProgressHistory> list = null;
            var cur_date = DateTime.Now.Date;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{

                //    list = (from t in context.TaskProgressHistories where t.TaskID == TaskID && t.ProgressDate.Value == cur_date select t).ToList<TaskProgressHistory>();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public TaskProgressHistory GetprogresshistoryByID(int progresshistoryID)
        {
            return _progresshistory.GetSingle(d => d.TaskProgressHistoryID == progresshistoryID);
        }
        public void AddprogressHistory(params TaskProgressHistory[] progresshistory)
        {
            try
            {
                _progresshistory.Add(progresshistory);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void Updateprogresshistroy(params TaskProgressHistory[] progresshistory)
        {
            try
            {
                _progresshistory.Update(progresshistory);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void Removeprogresshistory(params TaskProgressHistory[] progresshistory)
        {
            try
            {
                _progresshistory.Remove(progresshistory);
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

        public void UpdateTaskProgressHistory(int ProjectTaskID, decimal ProgressValue,int UserID)
        {
        //    try
        //    {
        //        BLUserRepository objcomp = new BLUserRepository();
        //        User lstUser = null;
        //        lstUser = objcomp.GetuserByID(UserID);
        //        int CompID=(int)lstUser.CompanyId;
        //        IList<TaskProgressHistory> lsttaskprghistory=GetprogressHistoryByTaskIDCurrentDate(ProjectTaskID);
        //        if (lsttaskprghistory.Count > 0)
        //        {
        //            foreach (var i in lsttaskprghistory)
        //            {
        //                i.TaskProgress = ProgressValue;
        //                i.EntityState = DominModel.EntityState.Modified;
        //                Updateprogresshistroy(i);
        //            }
        //        }
        //        else
        //        {
        //            BLAlertsSettingRepository blalert = new BLAlertsSettingRepository();
        //            IList<AlertsSetting> alert = blalert.GetAllAlertsSettings(CompID);
        //            DateTime NextCheckindate = DateTime.Now;
        //            if (alert.Count > 0)
        //            {
        //                int datetoadd = Convert.ToInt32(alert.SingleOrDefault().SendProgressRequestNOD);
        //                NextCheckindate = NextCheckindate.AddDays(datetoadd);
        //            }
        //            TaskProgressHistory taskprogress = new TaskProgressHistory();
        //            taskprogress.TaskID = ProjectTaskID;
        //            taskprogress.TaskProgress = ProgressValue;
        //            taskprogress.ProgressDate = Convert.ToDateTime(DateTime.Now);
        //            taskprogress.CreatedBy = UserID;
        //            taskprogress.CreatedOn = Convert.ToDateTime(DateTime.Now);
        //            taskprogress.NextProgressCheckingDate = Convert.ToDateTime(NextCheckindate);
        //            taskprogress.EntityState = DominModel.EntityState.Added;
        //            AddprogressHistory(taskprogress);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        }
    }
}

