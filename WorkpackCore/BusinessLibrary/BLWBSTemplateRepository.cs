using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public class BLWBSTemplateRepository : IBLWBSTemplateRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<WBSTemplate> _wbsTemplate;

        public BLWBSTemplateRepository(WorkpackDBContext context, IGenericDataRepository<WBSTemplate> wbsTemplate)
        {
            _context = context;
            _wbsTemplate = wbsTemplate;
        }





        public IList<WBSTemplate> GetAllWBSTemplate()
        {
            return _wbsTemplate.GetAll();
        }



        public List<object> GetAllWBSTemplateObject()
        {
            List<object> list = null;
            ////int companyID=Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    list = (from q in context.WBSTemplates where q.CompanyId== companyID select new { TemplateId = q.WBSTemplateID, TemplateName = q.WBSTemplateName }).ToList<object>();
            ////}
            return list;    
        }

        public WBSTemplate GetWBSTemplateByID(int wbsTemplateID)
        {
            return _wbsTemplate.GetSingle(d => d.WBSTemplateID == wbsTemplateID);
        }

      


        public List<object> GetWBSTemplateByTemplateName(string wbsTemplateName)
        {
            List<object> obj = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{
            ////    obj = (from q in context.WBSTemplates
            ////           where q.WBSTemplateName == wbsTemplateName
            ////           select new
            ////           {
            ////               q.WBSTemplateID,
            ////               q.WBSTemplateName,
            ////               q.modifiedBy,
            ////               q.modifiedOn
            ////           }).ToList<object>();
            ////}

            return obj;
        }



        public bool saveTemplate(string TemplateName, string UserID, List<WBSTemplateDetail> TemplateData, out OperationResult result)
        {
            bool status = false;
            result = new OperationResult();
            ////using (TransactionScope ts = new TransactionScope())
            ////{
            ////    try
            ////    {
            ////        BLWBSTemplateRepository objWBSTemplate = new BLWBSTemplateRepository();
            ////        WBSTemplate WBSTemplate = new WBSTemplate();
            ////        WBSTemplate.WBSTemplateName = TemplateName;
            ////        WBSTemplate.createdBy = Convert.ToInt32(UserID);
            ////        WBSTemplate.createdOn = DateTime.Now;
            ////        WBSTemplate.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            ////        WBSTemplate.EntityState = DominModel.EntityState.Added;
            ////        objWBSTemplate.AddWBSTemplate(WBSTemplate);
            ////        WBSTemplateDetailRepository objBLWBSTemplateDetail = new WBSTemplateDetailRepository();
            ////        WBSTemplateDetail objWBSTemplateDetail = new WBSTemplateDetail();
            ////        foreach (var item in TemplateData)
            ////        {
                       
            ////            item.EntityState = DominModel.EntityState.Added;
            ////            item.WBSTemplateID = WBSTemplate.WBSTemplateID;                    
            ////            item.EntityState = DominModel.EntityState.Added;
            ////        }
            ////        objBLWBSTemplateDetail.Add(TemplateData.ToArray());
            ////        status = true;
            ////        result.returnData = objWBSTemplate.GetAllWBSTemplateObject();
            ////        ts.Complete();
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        status = false;
            ////        ts.Dispose();
            ////    }
            //}

            return status;
        }




        public void AddWBSTemplate(params WBSTemplate[] wbsTemplate)
        {
            try
            {
                _wbsTemplate.Add(wbsTemplate);
            }
            catch (Exception ex)
            {
               // //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
//throw new Exception("Record not added.");
            }
        }
        public void UpdateWBSTemplate(params WBSTemplate[] wbsTemplate)
        {
            try
            {
                _wbsTemplate.Update(wbsTemplate);
            }
            catch (Exception ex)
            {
////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
              //  throw new Exception("Record not updated.");
            }
        }
        public void RemoveWBSTemplate(params WBSTemplate[] wbsTemplate)
        {
            try
            {
                _wbsTemplate.Remove(wbsTemplate);
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



        public bool DeleteWBSTemplate(int TemplateID, out OperationResult result)
        {
            bool status = false;
           result = new OperationResult();
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        List<WBSTemplateDetail> TemplateDetailData = null;
            //        BLWBSTemplateDetailRepository objTempDetail = new BLWBSTemplateDetailRepository();
            //        TemplateDetailData = objTempDetail.GetWBSTemplateDetailByTemplateID(TemplateID);
            //        foreach (var item in TemplateDetailData)
            //        {
            //            item.EntityState = DominModel.EntityState.Deleted;
            //        }
            //        objTempDetail.RemoveWBSTemplate(TemplateDetailData.ToArray());
            //        BLWBSTemplateRepository objTemp = new BLWBSTemplateRepository();
            //        WBSTemplate objTemplate = GetWBSTemplateByID(TemplateID);
            //        objTemplate.EntityState = DominModel.EntityState.Deleted;                    
            //        objTemp.RemoveWBSTemplate(objTemplate);
            //        status = true;
            //        result.returnData = objTemp.GetAllWBSTemplateObject();
            //        ts.Complete();
            //    }
            //    catch (Exception ex)
            //    {
            //        status = false;
            //        ts.Dispose();
            //    }
            //}

            return status;
        }

    }
}
