using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskTypeRepository : IBLTaskTypeRepository
    {
       

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskType> _tasktypeRepository;

        public BLTaskTypeRepository(WorkpackDBContext context, IGenericDataRepository<TaskType> tasktypeRepository)
        {
            _context = context;
            _tasktypeRepository = tasktypeRepository;
        }



        public IList<TaskType> GetAllTaskTypes()
        {
            IList<TaskType> lst = null;
            return lst;

                //_tasktypeRepository.GetAll().Where(c => c.CompanyId == Convert.ToInt32(HttpContext.Current.Session["CompanyId"])).ToList<TaskType>();
        } 
        public TaskType GetTaskTypeByID(Int32 tasktypeID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _tasktypeRepository.GetSingle(d => d.TaskTypeID == tasktypeID);                
                //include related employees
        }



        public int GetTaskTypeByName(string tasktypeID, int companyid)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties

            int tid =0;
            //using (var context = new Cubicle_EntityEntities())

            //{
            //     tid = (from b in context.TaskTypes
            //            where b.TaskType1.ToUpper() == tasktypeID.ToUpper() && b.CompanyId == companyid
            //              select b).ToList<TaskType>().FirstOrDefault().TaskTypeID;
           
            //}


            return tid;

            //include related employees
        }
      

        public void AddTaskType(params TaskType[] tasktype)
        {
            /* Validation and error handling omitted */
            try
            {
                _tasktypeRepository.Add(tasktype);
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
        public void UpdateTaskType(params TaskType[] tasktype)
        {
            /* Validation and error handling omitted */
            try
            {
                _tasktypeRepository.Update(tasktype);
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
        public void RemoveTaskType(params TaskType[] tasktype)
        {
            /* Validation and error handling omitted */
            try
            {
                _tasktypeRepository.Remove(tasktype);
            }
            catch (Exception ex)
            {
                throw ex;              
            }
        }



        public Boolean CheckDuplicate(TaskType tasktype,Boolean IsInsert)
        {
            Boolean Result = true;
            int companyID=0;
            //companyID = Convert.ToInt16(HttpContext.Current.Session["CompanyId"]);
            //Convert.ToInt32(Session["CompanyId"])
            //try
            //{
            //    var c = _tasktypeRepository.GetSingle(p => p.TaskType1.ToUpper() == tasktype.TaskType1.ToUpper() && p.CompanyId == companyID);
            //    if (!IsInsert)
            //    {
            //        if (c == null)
            //            Result = true;
            //        else if (c.TaskTypeID == tasktype.TaskTypeID)
            //            Result = true;
            //        else
            //            Result = false;
            //    }
            //    else
            //    {
            //        if (c == null)
            //            Result = true;
            //        else
            //            Result = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return Result;
        }
        public IList<Usp_Gettasktypewithactivity_Result> GetTaskTypeList(TaskType tasktype)
        {
            IList<Usp_Gettasktypewithactivity_Result> fetchedTaskType = new List<Usp_Gettasktypewithactivity_Result>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    int companyID = Convert.ToInt16(HttpContext.Current.Session["CompanyId"]);
                //    IQueryable<Usp_Gettasktypewithactivity_Result> query = Context.Usp_Gettasktypewithactivity(companyID).AsQueryable<Usp_Gettasktypewithactivity_Result>();


                //    if (tasktype.TaskType1 != string.Empty)
                //        query = query.Where(p => p.TaskType.ToUpper().Contains(tasktype.TaskType1.ToUpper()));
                //    fetchedTaskType = query.ToList<Usp_Gettasktypewithactivity_Result>();
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
            return fetchedTaskType;
        }
        public List<object> GetAllTaskTypeList()
        {
            List<object> listData = null;
           
            try
            {
                ////using (var Context = new Cubicle_EntityEntities())
                ////{
                ////    //var listData = Context.TaskTypes;                  
                ////    //fetchedTaskType = query.ToList(object);
                ////       listData  = (from c in Context.TaskTypes
                ////                      select new
                ////                      {
                ////                          TaskTypeID = c.TaskTypeID,
                ////                          TaskType1 = c.TaskType1
                ////                      }).ToList<object>();
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
            return listData;
        }

        public List<object> GetAllTaskTypeList( int Companyid)
        {
            List<object> listData = null;

            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    //var listData = Context.TaskTypes;                  
                //    //fetchedTaskType = query.ToList(object);
                //    listData = (from c in Context.TaskTypes
                //                where c.CompanyId == Companyid
                //                select new
                //                {
                //                    TaskTypeID = c.TaskTypeID,
                //                    TaskType = c.TaskType1
                //                }).ToList<object>();
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
            return listData;
        }


        public TaskType getTaskTypeByTaskGroup()
        {
            TaskType tt = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    int companyid = (int)HttpContext.Current.Session["CompanyId"];
                //    tt = (from c in Context.TaskTypes where c.TaskGroup == "Y" && c.CompanyId == companyid select c).SingleOrDefault();
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
            return tt;
        }

        public TaskType getTaskTypeByTaskGroup(string TaskGroup)
        {
            TaskType tt = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    int companyid = (int)HttpContext.Current.Session["CompanyId"];
                //    tt = (from c in Context.TaskTypes where c.TaskGroup == TaskGroup && c.CompanyId == companyid select c).FirstOrDefault();
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
            return tt;
        }

        static public List<object> BindActivityCategorylst()
        {
            List<object> obj = null;
            //int masterTaskType = Convert.ToInt32(Common.MasterTaskType.Task);
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    obj = (from u in context.ActivityTypes
            //           where u.MasterTaskTypeID == masterTaskType
            //           select new { TypeID = u.ActivityTypeID, Activity = u.Activity }).ToList<object>();

            //}

            return obj;
        }

        public TaskType getTaskTypeByMilestoneGroup()
        {
            TaskType tt = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    int companyid= (int)HttpContext.Current.Session["CompanyId"];
                //    tt = (from c in Context.TaskTypes where c.TaskGroup == "M" && c.CompanyId == companyid select c).SingleOrDefault();
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
            return tt;
        }

    }
}
