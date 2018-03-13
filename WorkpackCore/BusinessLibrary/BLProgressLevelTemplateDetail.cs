using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProgressLevelTemplateDetail : IBLProgressLevelTemplateDetail
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProgressLevelTemplateDetail> _progressLevelTemplateDetail;

        public BLProgressLevelTemplateDetail(WorkpackDBContext context, IGenericDataRepository<ProgressLevelTemplateDetail> progressLevelTemplateDetail)
        {
            _context = context;
            _progressLevelTemplateDetail = progressLevelTemplateDetail;
        }

        public void AddProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail)
        {
            try
            {
                _progressLevelTemplateDetail.Add(progressLevelTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail)
        {
            try
            {
                _progressLevelTemplateDetail.Update(progressLevelTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail)
        {
            try
            {
                _progressLevelTemplateDetail.Remove(progressLevelTemplateDetail);
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

        public int getAddProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail)
        {
            int result = 0;
            try
            {
                result = _progressLevelTemplateDetail.getAdd(progressLevelTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return result;
        }
        public int getUpdateProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail)
        {
            int result = 0;
            try
            {
                result = _progressLevelTemplateDetail.getUpdate(progressLevelTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
            return result;
        }
        public int getRemoveProjectProgressLevelTemplate(params ProgressLevelTemplateDetail[] progressLevelTemplateDetail)
        {
            int result = 0;
            try
            {
                result = _progressLevelTemplateDetail.getRemove(progressLevelTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
            return result;
        }        

        public ProgressLevelTemplateDetail GetTemplateDetailByID(int TemplateDetailID)
        {
            ProgressLevelTemplateDetail obj = null;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    obj = context.ProgressLevelTemplateDetails.Where(a => a.ProgressLevelTemplateDetailID == TemplateDetailID).FirstOrDefault();

            //}

            return obj;
        }

        public IEnumerable<ProjectProgressLevelTemplateTaskType> GetTemplateTaskTypeByID(int TemplateDetailID)
        {
            List<ProjectProgressLevelTemplateTaskType> lst = null;


            return lst;

        }

        public List<ProgressLevelTemplateDetail> GetTemplateDetailsFromDocBytemplateID(int TemplateID)
        {
            List<ProgressLevelTemplateDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from td in context.ProgressLevelTemplateDetails
            //           join dd in context.ProgressLevelTemplateDocDetails
            //               on td.ProgressLevelTemplateDetailID equals dd.ProgressLevelTemplateDetailID
            //               where td.ProgressLevelTemplateID==TemplateID
            //           select td).ToList<ProgressLevelTemplateDetail>();
            //}
            return lst;
        }

        public List<ProgressLevelTemplateDetail> GetTemplateDetailsBytemplateID(int TemplateID, int TaskTypeID)
        {
            List<ProgressLevelTemplateDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from td in context.ProgressLevelTemplateDetails 
            //           join tdd in context.ProgressLevelTemplateDocDetails
            //           on td.ProgressLevelTemplateDetailID equals tdd.ProgressLevelTemplateDetailID
            //           where td.ProgressLevelTemplateID == TemplateID && tdd.TaskTypeID == TaskTypeID
            //           select td).ToList<ProgressLevelTemplateDetail>();
            //}
            return lst;
        }

        public List<ProgressLevelTemplateDocDetail> GetTemplateDocDetailsByTemplateDetID(int TemplateDetID)
        {
            List<ProgressLevelTemplateDocDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProgressLevelTemplateDocDetails.Where(c=>c.ProgressLevelTemplateDetailID==TemplateDetID).ToList<ProgressLevelTemplateDocDetail>();
            //}
            return lst;
        }
    }
}
