using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLCustomReportRepository : IBLCustomReportRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<CustomReport> _customReport;

        public BLCustomReportRepository(WorkpackDBContext context, IGenericDataRepository<CustomReport> customReport)
        {
            _context = context;
            _customReport = customReport;
        }
        public List<CustomReport> GetAllCustomReport()
        {
            List<CustomReport> lstTask = new List<CustomReport>();

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstTask = (from q in db.CustomReports select q).ToList<CustomReport>();
                //}
            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lstTask;
        }

        public List<object> GetCustomReport(int CompanyId)
        {
            List<object> lstTask = new List<object>();

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstTask = (from q in db.CustomReports
                //               where q.CompanyId == CompanyId
                //               select new
                //               {
                //                   id = q.CustomReportID,
                //                   Status = q.Status,
                //                   Label = q.ReportTitle,
                //                   ReportCode = q.ReportCode,
                //                   TemplateID=q.TemplateID
                //               }).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lstTask;
        }
        public CustomReport GetCustomReportByID(int Id)
        {
            return _customReport.GetSingle(d => d.CustomReportID == Id);
        }

        public CustomReport GetCustomReportByModuleID(int ModuleId,  int CompanyID)
        {
            return _customReport.GetSingle(d => d.ModuleID == ModuleId && d.CompanyId==CompanyID);
        }
        public void AddCustomReport(params CustomReport[] CustomReport)
        {
            try
            {
                _customReport.Add(CustomReport);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateCustomReport(params CustomReport[] CustomReport)
        {
            try
            {
                _customReport.Update(CustomReport);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveCustomReport(params CustomReport[] CustomReport)
        {
            try
            {
                _customReport.Remove(CustomReport);
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
        }

        public void AddCustomReport(int CompanyID)
        {
            //BLEstimationColSettingTemplateDetail blestcol = new BLEstimationColSettingTemplateDetail();
            //BLEstimationColSettingTemplate blesttemp = new BLEstimationColSettingTemplate();
            
            //try
            //{
            //    //using (var context = new Cubicle_EntityEntities())
            //    //{
            //    //      context.InsertCustomReportsFromModule(CompanyID);
            //    //}

            //  List<object> lst=  GetCustomReport(CompanyID);

            //  foreach (dynamic a in lst)
            //  {
            //      int TemplateID = a.TemplateID;
            //    string id=  blesttemp.GetDefaultTemplateID(TemplateID);

            //   List<EstimationColSettingTemplateDetail> lstest=   blestcol.getEstimationSettingTemplateDetailByTempID(Convert.ToInt32(id),0);
            //   if (lstest.Count > 0)
            //   {
            //       lstest.ForEach(x => { x.CompanyId = CompanyID; x.EntityState = EntityState.Added; });
            //       blestcol.AddEstimationColSettingTemplate(lstest.ToArray());
            //   }


              
            //  }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    throw new Exception("Record not added.");
            //}
            
        }

    }
}
