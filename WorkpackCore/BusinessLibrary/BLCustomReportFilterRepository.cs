using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;


namespace BusinessLibrary
{
    public class BLCustomReportFilterRepository : IBLCustomReportFilterRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<CustomReportFilterMaster> _customReportFilter;

        public BLCustomReportFilterRepository(WorkpackDBContext context, IGenericDataRepository<CustomReportFilterMaster> customReportFilter)
        {
            _context = context;
            _customReportFilter = customReportFilter;
        }

        public List<CustomReportFilterMaster> GetAllCustomReportFilter()
        {
            List<CustomReportFilterMaster> lstTask = new List<CustomReportFilterMaster>();

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstTask = (from q in db.CustomReportFilterMasters select q).ToList<CustomReportFilterMaster>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lstTask;
        }
       
        public CustomReportFilterMaster GetCustomReportFilterByID(int Id)
        {
            return _customReportFilter.GetSingle(d => d.CustomReportFilterID == Id);
        
        }

        public List<CustomReportFilterMaster> GetCustomReportFilterByCustomReportID(int CustomReportID)
        {
            List<CustomReportFilterMaster> lstCustomReportID = new List<CustomReportFilterMaster>();

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lstCustomReportID = (from q in db.CustomReportFilterMasters.Where(a => a.CustomReportID == CustomReportID) select q).ToList<CustomReportFilterMaster>();
                //}
            }
            catch (Exception ex)
            {
               // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
            }
            return lstCustomReportID;
        }
        public void AddCustomReportFilter(params CustomReportFilterMaster[] CustomReportFilter)
        {
            try
            {
                _customReportFilter.Add(CustomReportFilter);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateCustomReportFilter(params CustomReportFilterMaster[] CustomReportFilter)
        {
            try
            {
                _customReportFilter.Update(CustomReportFilter);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveCustomReportFilter(params CustomReportFilterMaster[] CustomReportFilter)
        {
            try
            {
                _customReportFilter.Remove(CustomReportFilter);
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
        }


        public OperationResult GetCustomReportFilter(int CustomReportID)
        {
            OperationResult res = new OperationResult();
            try
            {
                //BLCustomReportFilterRepository blcustreportfilter = new BLCustomReportFilterRepository();
                //ReturnCustomFilter rtn = new ReturnCustomFilter();
                //using (var dbcontext = new Cubicle_EntityEntities())
                //{
                  
                //    string OwnerID = "";
                //    string StartDate = "";
                //    string EndDate = "";
                //    string TaskTypeID = "";
                //    string DepartmentID = "";
                //    string PriorityID = "";
                //    List<CustomReportFilterMaster> listitem = dbcontext.CustomReportFilterMasters.Where(a => a.CustomReportID == CustomReportID  && a.CoulumnValue != null && a.CoulumnValue !="").ToList<CustomReportFilterMaster>();
                //    if (listitem.Count > 0)
                //    {
                //        foreach (var value in listitem)
                //        {
                //            if (value.TableName.ToUpper() == "USERS")
                //                OwnerID += value.CoulumnValue + ",";
                //            else if (value.TableName.ToUpper() == "TASKTYPE")
                //                TaskTypeID += value.CoulumnValue + ",";
                //            else if (value.TableName.ToUpper() == "DEPARTMENT")
                //                DepartmentID += value.CoulumnValue + ",";
                //            else if (value.TableName.ToUpper() == "PRIORITY")
                //                PriorityID += value.CoulumnValue + ",";
                //            else if (value.TableName.ToUpper() == "STARTDATE")  //startdate and end will have only single value in table
                //                StartDate= value.CoulumnValue ;
                //            else if (value.TableName.ToUpper() == "ENDDATE")
                //                EndDate = value.CoulumnValue ;
                //        }
                       
                //        rtn.DepartmentID = DepartmentID;
                //        rtn.OwnerID = OwnerID;
                //        rtn.PriorityID = PriorityID;
                //        rtn.TaskTypeID = TaskTypeID;
                //        rtn.StartDate = StartDate;
                //        rtn.EndDate = EndDate;
                      
                //    }
                //}
                //res.data = rtn;
                //res.MessageType = "S";
                //res.Message = "Success.";
            }
            catch (Exception ex)
            {
                res.MessageType = "E";
                res.Message = "Some error occured.Please try again.";
            }

            return res;
        }

       
    }
}

public class ReturnCustomFilter
{
    public string OwnerID { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string TaskTypeID { get; set; }
    public string DepartmentID { get; set; }
    public string PriorityID { get; set; }
}