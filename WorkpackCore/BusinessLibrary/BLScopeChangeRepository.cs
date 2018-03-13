using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLScopeChangeRepository : IBLScopeChangeRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ScopeChange> _scopeChangeRepository;

        public BLScopeChangeRepository(WorkpackDBContext context, IGenericDataRepository<ScopeChange> scopeChangeRepository)
        {
            _context = context;
            _scopeChangeRepository = scopeChangeRepository;
        }
        public IList<ScopeChange> GetAllTaskTypes()
        {
            return _scopeChangeRepository.GetAll();
        }
        public IList<ScopeChange> GetAllScopeChange()
        {
            return _scopeChangeRepository.GetAll();
        }
      

        public List<usp_getTransferFromUser_Result> getTransferFromUser(int taskID)
        {
            List<usp_getTransferFromUser_Result> list = null;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    list = context.usp_getTransferFromUser(taskID).ToList<usp_getTransferFromUser_Result>();
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
            return list;
        }
        public List<object> GetAllProjectUnderScopechange( int UserID,int ProjectArchived)
        {
            List<usp_ProjectListUnderScopeChange_Result> list = null;
            List<object> lst = null;
            //CultureInfo ci = new CultureInfo("en-GB");
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        list = context.usp_ProjectListUnderScopeChange(UserID,ProjectArchived).ToList<usp_ProjectListUnderScopeChange_Result>();

            //        lst = list.Select(g => new
            //        {
            //            id = g.ProjectID,
            //            ProjectCode = g.ProjectCode,
            //            ProjectName = g.ProjectName,
            //            Description = g.ProjectDescription,
            //            Status = g.ProjectStatus,
            //            StartDate = g.StartDate,
            //            EndDate = g.EndDate
            //        }).ToList<object>();
              
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
            return lst;
        }
        
        private void AddScopeChange(params ScopeChange[] scopeChange)
        {
            /* Validation and error handling omitted */
            try
            {
                _scopeChangeRepository.Add(scopeChange);                
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
        private void UpdateScopeChange(params ScopeChange[] scopeChange)
        {
            /* Validation and error handling omitted */
            try
            {
                _scopeChangeRepository.Update(scopeChange);
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
        private void RemoveScopeChange(params ScopeChange[] scopeChange)
        {
            /* Validation and error handling omitted */
            try
            {
                _scopeChangeRepository.Remove(scopeChange);
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
        public List<usp_ScopeChangeProjectTaskList_Result> GetScopeChangeReportByProjectID(int ProjectID)
        {
            List<usp_ScopeChangeProjectTaskList_Result> res = null;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    res = context.usp_ScopeChangeProjectTaskList(ProjectID).ToList<usp_ScopeChangeProjectTaskList_Result>();
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
            return res;
           
        }
        public int SaveScopeChange(ScopeChange scopeChange)
        {
            int res = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.Entry(scopeChange).State = System.Data.EntityState.Added;
                //    context.SaveChanges();
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

        public bool checkDuplicateScopeCode(string code)
        {
            Boolean res = false;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    string cod = code.ToUpper();
                ////    int val = (from a in context.ScopeChanges where a.ScopeCode.ToUpper() == cod select a).Count();
                ////    if (val > 0)
                ////        res = true;
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
            return res;
           
        }

    
    }
}
