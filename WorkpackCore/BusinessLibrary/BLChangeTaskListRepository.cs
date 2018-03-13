using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLChangeTaskListRepository : IBLChangeTaskListRepository
    {

        private readonly WorkpackDBContext _context;
        //private readonly IGenericDataRepository<AcceptanceClass> _acceptanceclassRepository;

        public BLChangeTaskListRepository(WorkpackDBContext context)
        {
            _context = context;
            //_acceptanceclassRepository = acceptanceclassRepository;
        }
        public IList<usp_ChangeProjectTaskList_Result> GetChageprojectTaskList(int ChangeScopeId, int NotificationGroupID)
        {
            IList<usp_ChangeProjectTaskList_Result> list = null;
            try
            {

                //list = _context.usp_ChangeProjectTaskList(ChangeScopeId, NotificationGroupID).ToList<usp_ChangeProjectTaskList_Result>();

            }
            catch (Exception ex)
            {
                //bool rethrow = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (rethrow)
                //{
                //    throw ex;
                //}
            }
            return list;
        }


        public IList<object> GetChageprojectTaskListObject(int ProjectID, int NotificationGroupID)
        {
            IList<object> list = null;
            try
            {
                
                   // list = _context.usp_ChangeScopeProjectTaskList(ProjectID, NotificationGroupID).ToList<object>();
                
            }
            catch (Exception ex)
            {
                //bool rethrow = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (rethrow)
                //{
                //    throw ex;
                //}
            }
            return list;
        }
        public List<usp_LockTaskListUnderScopeChange_Result> GetScopeChageprojectTaskListObject(int ProjectID)
        {
            List<usp_LockTaskListUnderScopeChange_Result> list = null;
            try
            {
                //using (var _context = new Cubicle_EntityEntities())
                //{
                //    list = _context.usp_LockTaskListUnderScopeChange(ProjectID).ToList<usp_LockTaskListUnderScopeChange_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool rethrow = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (rethrow)
                //{
                //    throw ex;
                //}
            }
            return list;
        }

        public string cellAllign(string oldvalue)
        {
            string brk = "";
            if (oldvalue != "" && oldvalue != null)
            {
                brk = "</br>";
            }
            return brk;
        }

        //public IList<object> GetChageTaskMilestoneListObject(int projectID)
        //{
        //    IList<object> list = null;
        //    try
        //    {
        //        using (var _context = new Cubicle_EntityEntities())
        //        {
        //            list = _context.usp_GetChangeMilestoneTargetDates(projectID).ToList<object>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        bool rethrow = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (rethrow)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}  





        public IList<usp_ChangeMilestoneTargetDates_Result> GetChageTaskMilestoneList(int ChangeScopeId)
        {
            IList<usp_ChangeMilestoneTargetDates_Result> list = null;
            try
            {

               // list = _context.usp_ChangeMilestoneTargetDates(ChangeScopeId).ToList<usp_ChangeMilestoneTargetDates_Result>();

            }
            catch (Exception ex)
            {
                //bool rethrow = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (rethrow)
                //{
                //    throw ex;
                //}
            }
            return list;
        }







    }
}
