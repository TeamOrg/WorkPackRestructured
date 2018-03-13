using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using CommonLibrary;

namespace BusinessLibrary
{
    public class BLEstimationColSettingTemplate : IDisposable, IBLEstimationColSettingTemplate
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EstimationColSettingTemplate> _estimationColSettingTemplate;

        public BLEstimationColSettingTemplate(WorkpackDBContext context, IGenericDataRepository<EstimationColSettingTemplate> estimationColSettingTemplate)
        {
            _context = context;
            _estimationColSettingTemplate = estimationColSettingTemplate;
        }


        public EstimationColSettingTemplate GetEstimationColSettingTemplateByName(string Name)
        {
            return _estimationColSettingTemplate.GetSingle(c => c.EstimationColSettingTemplateName == Name);
        }
        public EstimationColSettingTemplate GetEstimationColSettingTemplateById(int TemplateID)
        {
            return _estimationColSettingTemplate.GetSingle(c => c.EstimationColSettingTemplateID == TemplateID);
        }
        public IList<EstimationColSettingTemplate> GetAllEstimationColSettingTemplate()
        {
            return _estimationColSettingTemplate.GetAll();
        }

        public List<object> GetAllEstimationColSettingTemplateObject(int MasterTaskType)
        {
            List<object> list = null;
            //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = (from q in context.EstimationColSettingTemplates where q.CompanyId == companyId && q.MasterTaskTypeID == MasterTaskType select new { TemplateId = q.EstimationColSettingTemplateID, TemplateName = q.EstimationColSettingTemplateName }).ToList<object>();
            //}
            return list;    
        }


        public List<object> GetAllEstimationColSettingTemplateObject()
        {
            List<object> list = null;
            //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = (from q in context.EstimationColSettingTemplates where q.CompanyId == companyId  select new { TemplateId = q.EstimationColSettingTemplateID, TemplateName = q.EstimationColSettingTemplateName }).ToList<object>();
            //}
            return list;
        }


        public void AddEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate)
        {
            try
            {
                _estimationColSettingTemplate.Add(EstimationColSettingTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public void applyDefaultTemplateSetting(string ProjectID, string TemplateId, string UserID, int MasterTaskType)
        {


            //List<EstimationTaskColumnsMaster> lst = new List<EstimationTaskColumnsMaster>();
            //StringBuilder vMessage = new StringBuilder();
            //int n, m;
            //bool isProjectIDNumeric = int.TryParse(ProjectID, out n);
            //bool isTemplateIdNumeric = int.TryParse(TemplateId, out m);
            //BLEstimationColSettingTemplateDetail blObjTempDet = new BLEstimationColSettingTemplateDetail();

            //if (isProjectIDNumeric && isTemplateIdNumeric && m > 0)
            //{
            //    List<EstimationColSettingTemplateDetail> TemplateData = blObjTempDet.getEstimationSettingTemplateDetailByTempID(m);
            //    if (TemplateData.Count() > 0)
            //    {
            //        int i = 1;
            //        foreach (var item in TemplateData)
            //        {
            //            string Msg = "<b>Row-" + i.ToString() + "</b> Required- ";
            //            bool validtaionFail = false;
            //            if (item.DisplayColName == null || item.DisplayColName.Length == 0)
            //            {
            //                validtaionFail = true;
            //                Msg += "DisplayColName";
            //            }
            //            if (item.NameInDb == null && Convert.ToString(item.NameInDb as object).Length > 0)
            //            {
            //                validtaionFail = true;
            //                Msg += "NameInDb";
            //            }
            //            if ((item.IsDbField == "Y" || item.IsDropDown == "Y") && (item.TableName == null || item.DBColName == null) && item.NameInDb!="Owner")
            //            {
            //                validtaionFail = true;
            //                Msg += "TableName/DBColName";
            //            }
            //            if (item.InputOutput != "" && Convert.ToString(item.InputOutput as object).ToLower() == "output" && (item.EquationID == null || Convert.ToString(item.EquationID as object).Trim().Length == 0))
            //            {
            //                validtaionFail = true;
            //                Msg += "Equation";
            //            }

            //            i = i + 1;

            //            if (validtaionFail)
            //            {
            //                vMessage.Append(Msg).AppendLine();
            //            }
            //            else
            //            {
            //                EstimationTaskColumnsMaster objDet = new EstimationTaskColumnsMaster();
            //                objDet.IsDbField = item.IsDbField;
            //                objDet.DisplayColName = item.DisplayColName;
            //                objDet.DBColName = item.DBColName;
            //                objDet.DBFKID = item.DBFKID;
            //                objDet.TableName = item.TableName;
            //                objDet.DisplayOrder = item.DisplayOrder;
            //                objDet.DataType = item.DataType;
            //                objDet.InputOutput = item.InputOutput;
            //                objDet.EquationID = item.EquationID;
            //                objDet.DisplayInGrid = item.DisplayInGrid;
            //                objDet.IsDropDown = item.IsDropDown;
            //                objDet.NameInDb = item.NameInDb;
            //                objDet.IsMandatory = item.IsMandatory;
            //                objDet.IsPkField = item.IsPkField;
            //                objDet.IsSearchField = item.IsSearchField;
            //                objDet.DBColPkID = item.DBColPkID;
            //                objDet.AllowDelete = item.AllowDelete;
            //                objDet.FilterColumn = item.FilterColumn;
            //                objDet.ProjectTaskListColumn = item.ProjectTaskListColumn;
            //                objDet.ValidationMessage = item.ValidationMessage;
            //                objDet.DefaultValue = item.DefaultValue;
            //                objDet.DependonNorms = item.DependonNorms;
            //                objDet.ProjectID = Convert.ToInt32(ProjectID);
            //                objDet.PermanentNameInDb = item.PermanentNameInDb;
            //                objDet.MasterTaskTypeID = MasterTaskType;
            //                objDet.EntityState = DominModel.EntityState.Added;
            //                lst.Add(objDet);

            //            }

            //            item.EntityState = DominModel.EntityState.Added;
            //        }

            //        if (vMessage.Length == 0)
            //        {
            //            BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //            blObj.applySettingTaskTemplate(lst, Convert.ToInt32(ProjectID), Convert.ToInt32(UserID), MasterTaskType);
            //        }

            //    }

            //}
        }


        public void UpdateEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate)
        {
            try
            {
                _estimationColSettingTemplate.Update(EstimationColSettingTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate)
        {
            try
            {
                _estimationColSettingTemplate.Remove(EstimationColSettingTemplate);
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

        public int getAddEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate)
        {
            int result = 0;
            try
            {
                result = _estimationColSettingTemplate.getAdd(EstimationColSettingTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return result;
        }
        public int getUpdateEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate)
        {
            int result = 0;
            try
            {
                result = _estimationColSettingTemplate.getUpdate(EstimationColSettingTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
            return result;
        }
        public int getRemoveEstimationColSettingTemplate(params EstimationColSettingTemplate[] EstimationColSettingTemplate)
        {
            int result = 0;
            try
            {
                result = _estimationColSettingTemplate.getRemove(EstimationColSettingTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
            return result;
        }
        public List<EstimationTaskColumnsMaster> GetEstimationTaskColumnsMasterDetailsByID(int EstimationTaskColumnID)
        {
            List<EstimationTaskColumnsMaster> list = null;
            //using(var context=new Cubicle_EntityEntities())
            //{
            //    list = context.EstimationTaskColumnsMasters.Where(c => c.EstimationTaskColumnID == EstimationTaskColumnID).ToList<EstimationTaskColumnsMaster>();
            //}
            return list;            
        }


        public string GetDefaultTemplateID(int MasterTaskType)
        {
            string result = "0";
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var www = context.EstimationColSettingTemplates.Where(c => c.DefaultTemplate == "Y" && c.MasterTaskTypeID == MasterTaskType && c.CompanyId == null);
            //          foreach (var item in www)
            //        {
            //            result =Convert.ToString(item.EstimationColSettingTemplateID);
            //        }
                         
            //}
            return result;
        }




        public void Dispose()
        {
            throw new NotImplementedException();
        }


        #region "added after slick implementation"


        public bool saveTemplate(string TemplateName, string UserID, int ProjectID, int TemplateID, out OperationResult result, string MasterTaskType="1")
        {
            bool status = false;
            result = new OperationResult();
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        BLEstimationColSettingTemplate EstimationColTemplate = new BLEstimationColSettingTemplate();
            //        EstimationColSettingTemplate objTemplate = new EstimationColSettingTemplate();
            //        objTemplate.EstimationColSettingTemplateName = TemplateName;
            //        objTemplate.CreatedBy = Convert.ToInt32(UserID);
            //        objTemplate.CreatedOn = DateTime.Now;
            //        objTemplate.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //        objTemplate.MasterTaskTypeID = Convert.ToInt32(MasterTaskType);
            //        objTemplate.EntityState = DominModel.EntityState.Added;
            //        EstimationColTemplate.AddEstimationColSettingTemplate(objTemplate);

            //        BLEstimationColSettingTemplateDetail objTempDetail = new BLEstimationColSettingTemplateDetail();
            //        List<EstimationColSettingTemplateDetail> lst = new List<EstimationColSettingTemplateDetail>();

            //        if (TemplateID > 0)
            //        {
            //            int NewTempID = objTemplate.EstimationColSettingTemplateID;
            //            lst = objTempDetail.getEstimationSettingTemplateDetailByTempID(TemplateID);
            //            lst = lst.Select(x => { x.EntityState = DominModel.EntityState.Added; x.EstimationColSettingTemplateID = NewTempID; return x; }).ToList<EstimationColSettingTemplateDetail>();
            //        }
            //        else if (TemplateID == 0 && ProjectID > 0)
            //        {
            //            BLEstimationTaskColumnsMasterRepository blObjEstMaster = new BLEstimationTaskColumnsMasterRepository();
            //            List<EstimationTaskColumnsMaster> lstMaster = blObjEstMaster.GetAllEstimationTaskColumnsMastersByProjectID(ProjectID, Convert.ToInt32(MasterTaskType)).ToList<EstimationTaskColumnsMaster>();

            //            foreach (var item in lstMaster)
            //            {
            //                EstimationColSettingTemplateDetail objDet = new EstimationColSettingTemplateDetail();
            //                objDet.EstimationColSettingTemplateID = Convert.ToInt32(objTemplate.EstimationColSettingTemplateID);
            //                objDet.EstimationTaskColumnID = item.EstimationTaskColumnID;
            //                objDet.IsDbField = item.IsDbField;
            //                objDet.DisplayColName = item.DisplayColName;
            //                objDet.DBColName = item.DBColName;
            //                objDet.DBFKID = item.DBFKID;
            //                objDet.TableName = item.TableName;
            //                objDet.DisplayOrder = item.DisplayOrder;
            //                objDet.DataType = item.DataType;
            //                objDet.InputOutput = item.InputOutput;
            //                objDet.EquationID = item.EquationID;
            //                objDet.DisplayInGrid = item.DisplayInGrid;
            //                objDet.IsDropDown = item.IsDropDown;
            //                objDet.NameInDb = item.NameInDb;
            //                objDet.IsMandatory = item.IsMandatory;
            //                objDet.IsPkField = item.IsPkField;
            //                objDet.IsSearchField = item.IsSearchField;
            //                objDet.DBColPkID = item.DBColPkID;
            //                objDet.AllowDelete = item.AllowDelete;
            //                objDet.FilterColumn = item.FilterColumn;
            //                objDet.ProjectTaskListColumn = item.ProjectTaskListColumn;
            //                objDet.ValidationMessage = item.ValidationMessage;
            //                objDet.DefaultValue = item.DefaultValue;
            //                objDet.DependonNorms = item.DependonNorms;
            //                objDet.ProjectID = Convert.ToInt32(ProjectID);
            //                objDet.PermanentNameInDb = item.PermanentNameInDb;
            //                objDet.Equationvalidation = item.Equationvalidation;
            //                objDet.EntityState = DominModel.EntityState.Added;

            //                lst.Add(objDet);
            //            }
            //        }

            //        objTempDetail.AddEstimationColSettingTemplate(lst.ToArray());
            //        status = true;

            //        result.returnData = EstimationColTemplate.GetAllEstimationColSettingTemplateObject(Convert.ToInt32(MasterTaskType));

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

        public bool deleteSettingTemplate(int TemplateID, out OperationResult result, string MasterTaskType = "1")
        {
            bool status = false;
            result = new OperationResult();
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {

            //        BLEstimationColSettingTemplateDetail objTempDetail = new BLEstimationColSettingTemplateDetail();
            //        List<EstimationColSettingTemplateDetail> TemplateDetailData = objTempDetail.getEstimationSettingTemplateDetailByTempID(TemplateID);
            //        foreach (var q in TemplateDetailData)
            //        {
            //            q.EntityState = DominModel.EntityState.Deleted;
            //        }
            //        objTempDetail.RemoveEstimationColSettingTemplate(TemplateDetailData.ToArray());

            //        BLEstimationColSettingTemplate EstimationColTemplate = new BLEstimationColSettingTemplate();
            //        EstimationColSettingTemplate objTemplate = EstimationColTemplate.GetEstimationColSettingTemplateById(TemplateID);
            //        objTemplate.EntityState = DominModel.EntityState.Deleted;
            //        EstimationColTemplate.RemoveEstimationColSettingTemplate(objTemplate);

            //        status = true;

            //        result.returnData = EstimationColTemplate.GetAllEstimationColSettingTemplateObject(Convert.ToInt32(MasterTaskType));

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

        public List<object> GetObjEstimationColSettingTemplateByName(string Name)
        {
            List<object> obj = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    obj = (from q in context.EstimationColSettingTemplates.AsEnumerable()
            //           where q.EstimationColSettingTemplateName == Name && q.CompanyId == Convert.ToInt32(HttpContext.Current.Session["CompanyId"])
            //           select new
            //      {
            //          q.EstimationColSettingTemplateID,
            //          q.EstimationColSettingTemplateName,
            //          q.CreatedBy,
            //          q.CreatedOn
            //      }).ToList<object>();
            //}

            return obj;
        }

        public bool saveSettingTemplateChanges(int TemplateId, int UserID, List<EstimationColSettingTemplateDetail> TemplateData, out OperationResult result)
        {
            bool status = false;
            result = new OperationResult();
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        //Delete Previous record
            //        BLEstimationColSettingTemplateDetail tempDet = new BLEstimationColSettingTemplateDetail();
            //        List<EstimationColSettingTemplateDetail> lstTempDetail = tempDet.getEstimationSettingTemplateDetailByTempID(TemplateId);
            //        foreach (var item in lstTempDetail)
            //        {
            //            item.EntityState = DominModel.EntityState.Deleted;
            //        }
            //        tempDet.RemoveEstimationColSettingTemplate(lstTempDetail.ToArray());
            //        //Add record
            //        foreach (var item in TemplateData)
            //        {
            //            item.EntityState = DominModel.EntityState.Added;
            //        }
            //        tempDet.AddEstimationColSettingTemplate(lstTempDetail.ToArray());

            //        ts.Complete();
            //        status = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        status = false;
            //        ts.Dispose();
            //    }
            //}

            return status;
        }
        

        #endregion



    }
}
