using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using BusinessLogic;

namespace BusinessLibrary
{
    public class BLWBSTemplateDetailRepository : IBLWBSTemplateDetailRepository
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<WBSTemplateDetail> _wbsTemplateDetail;

        public BLWBSTemplateDetailRepository(WorkpackDBContext context, IGenericDataRepository<WBSTemplateDetail> wbsTemplateDetail)
        {
            _context = context;
            _wbsTemplateDetail = wbsTemplateDetail;
        }






        public IList<WBSTemplateDetail> GetAllWBSTemplateDetail()
        {
            return _wbsTemplateDetail.GetAll();
        }
        public WBSTemplateDetail GetWBSTemplateDetailByID(int wbsTemplateDetailID)
        {
            return _wbsTemplateDetail.GetSingle(d => d.WBSTemplateDetailId == wbsTemplateDetailID);
        }

        public WBSTemplateDetail GetWBSTemplateDetailByWBSID(int WBSID)
        {
            return _wbsTemplateDetail.GetSingle(d => d.WBSID == WBSID);
        }



        public List<WBSTemplateDetail> GetWBSTemplateDetailByTemplateID(int TemplateID)
        {
            List<WBSTemplateDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.WBSTemplateDetails.Where(a => a.WBSTemplateID == TemplateID).ToList<WBSTemplateDetail>();
            //}
            return lst;
        }

        public void AddWBSTemplate(params WBSTemplateDetail[] wbsTemplateDetail)
        {
            try
            {
                _wbsTemplateDetail.Add(wbsTemplateDetail);
            }
            catch (Exception ex)
            {
               //// //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateWBSTemplate(params WBSTemplateDetail[] wbsTemplateDetail)
        {
            try
            {
                _wbsTemplateDetail.Update(wbsTemplateDetail);
            }
            catch (Exception ex)
            {
               // //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveWBSTemplate(params WBSTemplateDetail[] wbsTemplateDetail)
        {
            try
            {
                _wbsTemplateDetail.Remove(wbsTemplateDetail);
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


        public List<WBSTemplateDetail> GetAllWBSTemplateDetailByWBSID(int WBSId)
        {
            List<WBSTemplateDetail> lst=null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.WBSTemplateDetails.Where(a => a.WBSID == WBSId).ToList<WBSTemplateDetail>();
            //}
            return lst;
        }


        public OperationResult UpdateWBSTemplateDetail(int projectid, int TemplateID, List<ProjectWB> TemplateData)
        {
            OperationResult result = new OperationResult();

             //using (TransactionScope ts = new TransactionScope())
             //   {
             //       try
             //       {


             //               BLWBSTemplateDetailRepository blwbsTemlateDetail = new BLWBSTemplateDetailRepository();
             //               List<WBSTemplateDetail> lstDetail = new List<WBSTemplateDetail>(); 
             //               List<WBSTemplateDetail> lstDelete = blwbsTemlateDetail.GetWBSTemplateDetailByTemplateID(TemplateID);
             //               blwbsTemlateDetail.RemoveWBSTemplate(lstDelete.ToArray());
             //               foreach (var lst in TemplateData)
             //               {

             //                   WBSTemplateDetail lstTemalate = new WBSTemplateDetail();
             //                   lstTemalate.WBSID = lst.WBSID;
             //                   lstTemalate.WBSTemplateID = TemplateID;
             //                   lstTemalate.EntityState = DominModel.EntityState.Added;
             //                   lstDetail.Add(lstTemalate);
             //               }
             //               blwbsTemlateDetail.AddWBSTemplate(lstDetail.ToArray());
             //               BLWBSTemplateRepository objWBSTemplate = new BLWBSTemplateRepository();
             //               result.returnData = objWBSTemplate.GetAllWBSTemplateObject();
             //               result.Message = MessageConstants.OperationSuccess;
             //               result.MessageType = "S";
             //               ts.Complete();
              
             //       }
             //       catch (Exception ex)
             //       {
             //           result.Message = MessageConstants.errorMsg;
             //           result.MessageType = "E";
             //           ts.Dispose();
             //       }
             //      }

            return result;
        }

    }
}
