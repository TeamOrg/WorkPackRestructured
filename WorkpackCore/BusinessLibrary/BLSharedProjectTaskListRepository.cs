using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLSharedProjectTaskListRepository : IBLSharedProjectTaskListRepository
    {
         



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<SharedProjectTaskList> _sharedtaskRepository;

        public BLSharedProjectTaskListRepository(WorkpackDBContext context, IGenericDataRepository<SharedProjectTaskList> sharedtaskRepository)
        {
            _context = context;
            _sharedtaskRepository = sharedtaskRepository;
        }





        public IList<SharedProjectTaskList> GetAllSharedProjectTaskList()
        {
            return _sharedtaskRepository.GetAll();
        }
        public SharedProjectTaskList GetSharedProjectTaskListByID(Int32 SharedTaskID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _sharedtaskRepository.GetSingle(d => d.SharedTaskID == SharedTaskID);                
                //include related employees
        }
        public void AddSharedProjectTaskList(params SharedProjectTaskList[] SharedTask)
        {
            /* Validation and error handling omitted */
            try
            {
                _sharedtaskRepository.Add(SharedTask);
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
        public void UpdateSharedProjectTaskList(params SharedProjectTaskList[] sharedtask)
        {
            /* Validation and error handling omitted */
            try
            {
                _sharedtaskRepository.Update(sharedtask);
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
        public void RemoveSharedProjectTaskList(params SharedProjectTaskList[] sharedtask)
        {
            /* Validation and error handling omitted */
            try
            {
                _sharedtaskRepository.Remove(sharedtask);
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

        public bool ShareTaskByProjectID(int ProjectID, int MasterTaskTypeID, string usr)
        {
            bool result = false;
            //BLSharedProjectTaskListRepository blsharetask = new BLSharedProjectTaskListRepository();
            //SharedProjectTaskList sharedtask = null;
            //try
            //{
            //    string usrid = usr.Split(':')[0];                
            //    string CanEdit = usr.Split(':')[1];
            //    if (!usrid.Contains('@'))
            //    {
            //        List<SharedProjectTaskList> lstalreadysharedtask = blsharetask.DuplicateSharedTask(usrid, ProjectID, MasterTaskTypeID);
            //        if (lstalreadysharedtask.Count() > 0)
            //        {
            //            sharedtask = lstalreadysharedtask.SingleOrDefault();
            //            sharedtask.CanEdit = "Y";  //CanEdit; // for now 
            //            sharedtask.ModifiedBy = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            //            sharedtask.ModifiedOn =DateTime.Now;
            //            sharedtask.EntityState = DominModel.EntityState.Modified;
            //            blsharetask.UpdateSharedProjectTaskList(sharedtask);
            //            result = true;
            //        }
            //        else
            //        {
            //            sharedtask = new SharedProjectTaskList();
            //            sharedtask.ProjectID = ProjectID;
            //            sharedtask.MasterTaskTypeID = MasterTaskTypeID;
            //            sharedtask.UserID = Convert.ToInt32(usrid);
            //            sharedtask.CanEdit = "Y";  //CanEdit; // for now 
            //            sharedtask.CreatedBy = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            //            sharedtask.CreatedOn = DateTime.Now;
            //            sharedtask.EntityState = DominModel.EntityState.Added;
            //            blsharetask.AddSharedProjectTaskList(sharedtask);
            //            result = true;
            //        }
                    
            //    }
                
            //}
            //catch (Exception ex)
            //{
               
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        result = false;
            //       // throw ex;
            //    }
            //}
            return result;
        }
        public List<SharedProjectTaskList> DuplicateSharedTask(string Userid, int ProjectID, int MasterTaskTypeID)
        {
            List<SharedProjectTaskList> list = null;
            //int Usrid= Convert.ToInt32(Userid);
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list= new List<SharedProjectTaskList>();
            //    list = db.SharedProjectTaskLists.Where(f => f.UserID == (int)Usrid && f.ProjectID == (int)ProjectID && f.MasterTaskTypeID==MasterTaskTypeID).ToList<SharedProjectTaskList>();
            //}
            return list;
        }

        public bool HasSharedTask(int ProjectID, int MasterTaskTypeID, int UserID)
        {
            bool Result = false;
            List<SharedProjectTaskList> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = new List<SharedProjectTaskList>();
                //    list = db.SharedProjectTaskLists.Where(f => f.UserID == (int)UserID && f.ProjectID == (int)ProjectID && f.MasterTaskTypeID == MasterTaskTypeID).ToList<SharedProjectTaskList>();
                //    if(list.Count>0)
                //          Result = true ;
                //}
            }
            catch (Exception ex)
            {

                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    Result = false;
                    // throw ex;
                }
            }
            return Result;
        }

        public bool CanUserEditSharedTask(int ProjectID, int MasterTaskTypeID, int UserID)
        {
            bool Result = false;
            string CanEdit = "";
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{

                ////    CanEdit = db.SharedProjectTaskLists.Where(f => f.UserID == (int)UserID && f.ProjectID == (int)ProjectID && f.MasterTaskTypeID == MasterTaskTypeID).Select(s => s.CanEdit).FirstOrDefault();
                ////    if (CanEdit== "Y")
                ////        Result = true;
                ////}
            }
            catch (Exception ex)
            {

                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    Result = false;
                    // throw ex;
                }
            }
            return Result;
        }
    }
}
