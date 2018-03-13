using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLEstimationTaskListRepository : IBLEstimationTaskListRepository
    { 
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EstimationTaskList> _estimationTaskList;

        public BLEstimationTaskListRepository(WorkpackDBContext context, IGenericDataRepository<EstimationTaskList> estimationTaskList)
        {
            _context = context;
            _estimationTaskList = estimationTaskList;
        }

        public IList<EstimationTaskList> GetAllEstimationTaskList()
        {
            return _estimationTaskList.GetAll();
        }
       
        public void AddEstimationTaskList(params EstimationTaskList[] EstimationTaskList)
        {
            try
            {
                _estimationTaskList.Add(EstimationTaskList);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateEstimationTaskList(params EstimationTaskList[] EstimationTaskList)
        {
            try
            {
                _estimationTaskList.Update(EstimationTaskList);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveEstimationTaskList(params EstimationTaskList[] EstimationTaskList)
        {
            try
            {
                _estimationTaskList.Remove(EstimationTaskList);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }


     

    

       

    
      
      
     
        public List<usp_getWorkingDateDuration_Result> getWorkingDateDuration(DateTime startdate, DateTime enddate)
        {
            List<usp_getWorkingDateDuration_Result> result = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    result = context.usp_getWorkingDateDuration(startdate, enddate).ToList<usp_getWorkingDateDuration_Result>();
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
            return result;
        }

        public List<usp_getDynamicDropdownData_Result> getDynamicDropdownData1(string TableName, string DBColName, string FilterColumn, string FilterValue)
        {
            List<usp_getDynamicDropdownData_Result> result = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    result = context.usp_getDynamicDropdownData(TableName, DBColName, Convert.ToString(FilterColumn as object), FilterValue).ToList<usp_getDynamicDropdownData_Result>();
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
            return result;
        }

        #region "After Slick grid"

        public bool checkUniqueness(int ProjectID, string DataMappingID, string code, int id)
        {
            bool result = true;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    int n = 0;
                //    bool isDataMappingIdNumeric = int.TryParse(DataMappingID, out n);
                //    List<usp_checkUniqueNess_Result> lst = context.usp_checkUniqueNess(ProjectID, DataMappingID, n, Convert.ToString(code as object).Trim().ToLower(), id).ToList<usp_checkUniqueNess_Result>();
                //    if (lst.Count > 0)
                //    {
                //        if (lst[0].Vcount > 0)
                //            result = false;
                //        else
                //            result = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                return true;
            }

            return result;
        }

        #endregion


        public List<object> getNormsDetailForTask(int NormID)
        {
            List<object> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var lstItem = (from q in context.NormsDetails
                //                   join r in context.NormsColumnsMasters on q.NormsColumnID equals r.NormsColumnID
                //                   where q.NormsID == NormID
                //                   select new
                //                   {
                //                       q.ColValue,
                //                       r.NameInDb,
                //                       r.TableName
                //                   });

                //    lst = lstItem.ToList<object>();
                //   // var gg=from q in context.EstimationTaskColumnsMasters

                //    //foreach (var item in lstItem)
                //    //{
                //    //    if (Convert.ToString(item.TableName as object) != "")
                //    //    {
                //    //        ProjectTaskListSlickGrid
                //    //    }
                //    //}

                //}
            }
            catch (Exception ex)
            {
                return lst;
            }

            return lst;
        }
    }
}
