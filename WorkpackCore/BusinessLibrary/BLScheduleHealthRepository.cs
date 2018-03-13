using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLScheduleHealthRepository : IBLScheduleHealthRepository
    {
       

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ScheduleHealth> _scheduleHealthRepository;

        public BLScheduleHealthRepository(WorkpackDBContext context, IGenericDataRepository<ScheduleHealth> scheduleHealthRepository)
        {
            _context = context;
            _scheduleHealthRepository = scheduleHealthRepository;
        }




        public IList<ScheduleHealth> GetAllScheduleHealths()
        {
            return _scheduleHealthRepository.GetAll();
        }
        public ScheduleHealth GetScheduleHealthByID(Int32 scheduleHealthID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _scheduleHealthRepository.GetSingle(d => d.ScheduleHelthID == scheduleHealthID);
            //include related employees
        }
        public void AddScheduleHealth(params ScheduleHealth[] scheduleHealth)
        {
            /* Validation and error handling omitted */
            try
            {
                _scheduleHealthRepository.Add(scheduleHealth);
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
        public void UpdateScheduleHealth(params ScheduleHealth[] scheduleHealth)
        {
            /* Validation and error handling omitted */
            try
            {
                _scheduleHealthRepository.Update(scheduleHealth);
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
        public void RemoveScheduleHealth(params ScheduleHealth[] scheduleHealth)
        {
            /* Validation and error handling omitted */
            try
            {
                _scheduleHealthRepository.Remove(scheduleHealth);
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
        //public Boolean CheckDuplicate(ScheduleHealth scheduleHealth, Boolean IsInsert)
        //{
        //    Boolean Result = true;

        //    var c = _scheduleHealthRepository.GetSingle(p => p.ScheduleHealthName == scheduleHealth.ScheduleHealthName && p.ScheduleHealthCode == scheduleHealth.ScheduleHealthCode && p.ClientID==scheduleHealth.ClientID);
        //    if(!IsInsert)
        //    {
        //        if (c == null)
        //            Result = true; 
        //        else if (c.ScheduleHealthID == scheduleHealth.ScheduleHealthID)
        //            Result=true;
        //        else
        //            Result=false;
        //    }
        //    else
        //    {
        //        if (c == null)
        //            Result = true;
        //        else
        //            Result = false;
        //    }
        //    return Result;
        //}

        //public IList<Client_ScheduleHealth_View> GetScheduleHealthList(ScheduleHealth scheduleHealth)
        //{
        //    IList<Client_ScheduleHealth_View> fetchedClient = new List<Client_ScheduleHealth_View>();
        //    using (var Context = new Cubicle_EntityEntities())
        //    {
        //        IQueryable<Client_ScheduleHealth_View> query = Context.Client_ScheduleHealth_View;
        //        if (scheduleHealth.ScheduleHealthName != string.Empty)
        //            query = query.Where(p => p.ScheduleHealthName.ToUpper().Contains(scheduleHealth.ScheduleHealthName.ToUpper()));
        //        if (scheduleHealth.ScheduleHealthCode != string.Empty)
        //            query = query.Where(p => p.ScheduleHealthCode.ToUpper().Contains(scheduleHealth.ScheduleHealthCode.ToUpper()));
        //       if(scheduleHealth.ClientID!=0)
        //           query = query.Where(p => p.ClientID==scheduleHealth.ClientID);
        //        fetchedClient = query.ToList();
        //    }
        //    return fetchedClient;
        //}

        public ScheduleHealth GetScheduleHealthByType(string ScheduleType)
        {
            ScheduleHealth list=null;
            try
            {
           
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.ScheduleHealths.SingleOrDefault(d => d.ScheduleType == ScheduleType);
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
            return list;
        }
        public Boolean c_SaveScheduleHealth(ScheduleHealth scheduleHealth)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var Context = new Cubicle_EntityEntities())
            //        {
            //            var a = Context.ScheduleHealths.Where(p => p.ScheduleType == scheduleHealth.ScheduleType);
            //            foreach (var s in a)
            //                Context.ScheduleHealths.Remove(s);
            //            Context.SaveChanges();
            //            Context.ScheduleHealths.Add(scheduleHealth);
            //            Context.SaveChanges();
            //        }
            //        ts.Complete();
            //        res = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        res = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return res;           
        }
    }
}

