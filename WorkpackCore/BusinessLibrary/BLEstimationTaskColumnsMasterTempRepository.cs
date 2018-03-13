using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLEstimationTaskColumnsMasterTempRepository : IBLEstimationTaskColumnsMasterTempRepository

    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EstimationTaskColumnsMasterTemp> _estimationTaskColumnsMasterTemp;

        public BLEstimationTaskColumnsMasterTempRepository(WorkpackDBContext context, IGenericDataRepository<EstimationTaskColumnsMasterTemp> estimationTaskColumnsMasterTemp)
        {
            _context = context;
            _estimationTaskColumnsMasterTemp = estimationTaskColumnsMasterTemp;
        }


        public IList<EstimationTaskColumnsMasterTemp> GetAllEstimationTaskColumnsMastersTemp()
        {
            return _estimationTaskColumnsMasterTemp.GetAll();
        }
       

        public int AddEstimationTaskColumnsMastersTemp(params EstimationTaskColumnsMasterTemp[] EstimationTaskColumnsMasterTemp)
        {
            int result = 0;
            try
            {
               result= _estimationTaskColumnsMasterTemp.getAdd(EstimationTaskColumnsMasterTemp);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return result;
        }
        public void UpdateEstimationTaskColumnsMasterTemp(params EstimationTaskColumnsMasterTemp[] EstimationTaskColumnsMasterTemp)
        {
            try
            {
                _estimationTaskColumnsMasterTemp.Update(EstimationTaskColumnsMasterTemp);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
       
        public void RemoveEstimationTaskColumnsMasterTemp(params EstimationTaskColumnsMasterTemp[] EstimationTaskColumnsMasterTemp)
        {
            try
            {
                _estimationTaskColumnsMasterTemp.Remove(EstimationTaskColumnsMasterTemp);
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
       
       
       
       
        public bool checkDuplNameInDb(string NameInDb, int PrimaryId, int ProjectID, int NormSetID, string TemplateID, int MasterTaskType)
        {
            int cnt = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if ((Convert.ToString(TemplateID as object) != "" && Convert.ToInt32(TemplateID) > 0) || MasterTaskType>3)
            //    {
            //        int vTempId = Convert.ToInt32(TemplateID);
            //        cnt = context.EstimationColSettingTemplateDetails.Where(a => a.NameInDb.StartsWith(NameInDb) && a.NameInDb.EndsWith(NameInDb) && a.EstimationColSettingTemplateDetailID!=PrimaryId && a.EstimationColSettingTemplateID == vTempId).Count();
            //    }
            //    else
            //    {
            //        cnt = context.EstimationTaskColumnsMasters.Where(a => a.NameInDb.StartsWith(NameInDb) && a.NameInDb.EndsWith(NameInDb) && a.EstimationTaskColumnID != PrimaryId && a.ProjectID == ProjectID && a.MasterTaskTypeID == MasterTaskType).Count();
            //    }
            //}
            if (cnt > 0)
                return true;
            else
                return false;
        }
        public bool checkDuplFieldName(string FieldName, int PrimaryID, int ProjectID, string TemplateID, int MasterTaskType)
        {
            int cnt = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (Convert.ToString(TemplateID as object) != "" && Convert.ToInt32(TemplateID) > 0)
            //    {
            //        int vTempId = Convert.ToInt32(TemplateID);
            //        cnt = context.EstimationColSettingTemplateDetails.Where(a => a.DisplayColName.StartsWith(FieldName) && a.DisplayColName.EndsWith(FieldName) && a.EstimationColSettingTemplateDetailID != PrimaryID && a.EstimationColSettingTemplateID == vTempId).Count();
            //    }
            //    else
            //    {
            //        cnt = context.EstimationTaskColumnsMasters.Where(a => a.DisplayColName.StartsWith(FieldName) && a.DisplayColName.EndsWith(FieldName) && a.EstimationTaskColumnID != PrimaryID && a.ProjectID == ProjectID && a.MasterTaskTypeID == MasterTaskType).Count();
            //    }
            //}
            if (cnt > 0)
                return true;
            else
                return false;
        }
       
        
       

    }
}
