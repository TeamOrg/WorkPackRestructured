using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLEstimationColSettingTemplateDetail : IBLEstimationColSettingTemplateDetail
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EstimationColSettingTemplateDetail> _estimationColSettingTemplateDetail;

        public BLEstimationColSettingTemplateDetail(WorkpackDBContext context, IGenericDataRepository<EstimationColSettingTemplateDetail> estimationColSettingTemplateDetail)
        {
            _context = context;
            _estimationColSettingTemplateDetail = estimationColSettingTemplateDetail;
        }
        public EstimationColSettingTemplateDetail getEstimationColSettingTemplateDetailByID(int EstimationColSettingTemplateDetailID)
        {
            return _estimationColSettingTemplateDetail.GetSingle(d => d.EstimationColSettingTemplateDetailID == EstimationColSettingTemplateDetailID);
        }
        public IList<EstimationColSettingTemplateDetail> GetAllEstimationColSettingTemplateDetail()
        {
            return _estimationColSettingTemplateDetail.GetAll();
        }
        public void AddEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail)
        {
            //try
            //{
            //    _estimationColSettingTemplateDetail.Add(EstimationColSettingTemplateDetail);
            //}
            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }

            //    ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    throw new Exception("Record not added.");
            //}
        }
        public void UpdateEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail)
        {
            try
            {
                _estimationColSettingTemplateDetail.Update(EstimationColSettingTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail)
        {
            try
            {
                _estimationColSettingTemplateDetail.Remove(EstimationColSettingTemplateDetail);
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

        public int getAddEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail)
        {
            int result = 0;
            try
            {
                result = _estimationColSettingTemplateDetail.getAdd(EstimationColSettingTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return result;
        }
        public int getUpdateEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail)
        {
            int result = 0;
            try
            {
                result = _estimationColSettingTemplateDetail.getUpdate(EstimationColSettingTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
            return result;
        }
        public int getRemoveEstimationColSettingTemplate(params EstimationColSettingTemplateDetail[] EstimationColSettingTemplateDetail)
        {
            int result = 0;
            try
            {
                result = _estimationColSettingTemplateDetail.getRemove(EstimationColSettingTemplateDetail);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
            return result;
        }
        public int GetMaxDiplayNumberTemplate(int TemplateID)
        {
            int maxdisplay = 0;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    maxdisplay = (from t in context.EstimationColSettingTemplateDetails
            //                  where t.EstimationColSettingTemplateID == TemplateID
            //                  orderby t.DisplayOrder descending
            //                  select (t.DisplayOrder)).FirstOrDefault();
            //}
            return maxdisplay + 1;
        }
        #region "added after slick implementation"


        public List<EstimationColSettingTemplateDetail> getEstimationSettingTemplateDetailByTempID(int TemplateID)
        {
            List<EstimationColSettingTemplateDetail> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.EstimationColSettingTemplateDetails.Where(a => a.EstimationColSettingTemplateID == TemplateID).ToList<EstimationColSettingTemplateDetail>();
            //}
            return result;
        }


        public List<EstimationColSettingTemplateDetail> getEstimationSettingTemplateDetailByTempID(int TemplateID,int companyid)
        {
            List<EstimationColSettingTemplateDetail> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if(companyid>0)
            //    result = context.EstimationColSettingTemplateDetails.Where(a => a.EstimationColSettingTemplateID == TemplateID && a.CompanyId ==  companyid).ToList<EstimationColSettingTemplateDetail>();
            //    else 
            //       result = context.EstimationColSettingTemplateDetails.Where(a => a.EstimationColSettingTemplateID == TemplateID && a.CompanyId ==  (int?)null).ToList<EstimationColSettingTemplateDetail>();
            //}
            return result;
        }




        //public EstimationColSettingTemplateDetail GetLastUsedBufferColoumn(int projectid, string datatype)
        //{

        //    EstimationColSettingTemplateDetail estcol = new EstimationColSettingTemplateDetail();

        //    using (var context = new Cubicle_EntityEntities())
        //    {

        //        estcol = context.EstimationColSettingTemplateDetails.Where(a => a.ProjectID == projectid && a.ProjectTaskListColumn.Contains(datatype)).OrderByDescending(x => x.EstimationColSettingTemplateDetailID).FirstOrDefault();
        //        //estcol = (from a in context.EstimationColSettingTemplateDetails
        //        //          join b in context.EstimationColSettingTemplates on a.EstimationColSettingTemplateID equals b.EstimationColSettingTemplateID
        //        //          where a.ProjectID == projectid && a.ProjectTaskListColumn.Contains(datatype) && b.MasterTaskTypeID == MasterTaskTypeID
        //        //          select a).OrderByDescending(x => x.EstimationColSettingTemplateDetailID).FirstOrDefault();
        //    }

        //    return estcol;
        //}

        //public List<EstimationColSettingTemplateDetail> GetLastUsedBufferColoumn(int? projectid, string datatype)
        //{

        //    List<EstimationColSettingTemplateDetail> estcol = new List<EstimationColSettingTemplateDetail>();

        //    using (var context = new Cubicle_EntityEntities())
        //    {
                
        //        estcol = context.EstimationColSettingTemplateDetails.Where(x => x.ProjectID == projectid && x.ProjectTaskListColumn.Contains(datatype)).ToList();
        //        //estcol = (from a in context.EstimationColSettingTemplateDetails
        //        //          join b in context.EstimationColSettingTemplates on a.EstimationColSettingTemplateID equals b.EstimationColSettingTemplateID
        //        //          where a.ProjectID == projectid && a.ProjectTaskListColumn.Contains(datatype) && b.MasterTaskTypeID == MasterTaskTypeID
        //        //          select a).ToList();

        //    }

        //    return estcol;
        //}


        public List<EstimationColSettingTemplateDetail> GetLastUsedBufferColoumnByTemplateID(int? templateID, string datatype, int MasterTaskTypeR)
        {

            List<EstimationColSettingTemplateDetail> estcol = new List<EstimationColSettingTemplateDetail>();

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int companyid = (int)HttpContext.Current.Session["CompanyId"];
            //    estcol = context.EstimationColSettingTemplateDetails.Where(x => x.EstimationColSettingTemplateID == templateID && x.ProjectTaskListColumn.Contains(datatype) && x.CompanyId == (MasterTaskTypeR > 3 ? companyid : x.CompanyId) ).ToList();
            //    //estcol = (from a in context.EstimationColSettingTemplateDetails
            //    //          join b in context.EstimationColSettingTemplates on a.EstimationColSettingTemplateID equals b.EstimationColSettingTemplateID
            //    //          where a.ProjectID == projectid && a.ProjectTaskListColumn.Contains(datatype) && b.MasterTaskTypeID == MasterTaskTypeID
            //    //          select a).ToList();

            //}

            return estcol;
        }

        public EstimationColSettingTemplateDetail GetLastUsedBufferColoumnByTemplateID(int templateID, string datatype, int MasterTaskTypeR)
        {

            EstimationColSettingTemplateDetail estcol = new EstimationColSettingTemplateDetail();

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int companyid = (int)HttpContext.Current.Session["CompanyId"];
            //    estcol = context.EstimationColSettingTemplateDetails.Where(a => a.EstimationColSettingTemplateID == templateID && a.ProjectTaskListColumn.Contains(datatype) && a.CompanyId == (MasterTaskTypeR > 3 ? companyid : a.CompanyId)).OrderByDescending(x => x.EstimationColSettingTemplateDetailID).FirstOrDefault();
            //    //estcol = (from a in context.EstimationColSettingTemplateDetails
            //    //          join b in context.EstimationColSettingTemplates on a.EstimationColSettingTemplateID equals b.EstimationColSettingTemplateID
            //    //          where a.ProjectID == projectid && a.ProjectTaskListColumn.Contains(datatype) && b.MasterTaskTypeID == MasterTaskTypeID
            //    //          select a).OrderByDescending(x => x.EstimationColSettingTemplateDetailID).FirstOrDefault();
            //}

            return estcol;
        }

        #endregion


    }
}
