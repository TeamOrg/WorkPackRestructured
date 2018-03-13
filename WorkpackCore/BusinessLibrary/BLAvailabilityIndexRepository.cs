using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLAvailabilityIndexRepository : IBLAvailabilityIndexRepository
    {
        //private readonly WorkpackDBContext _context;
        //private readonly IGenericDataRepository<AcceptanceClass> _availabilityIndexRepository;

        //public BLAvailabilityIndexRepository(WorkpackDBContext context, IGenericDataRepository<AcceptanceClass> availabilityIndexRepository)
        //{
        //    _context = context;
        //    _availabilityIndexRepository = availabilityIndexRepository;
        //}

        
            
            
            
            
            
        //public string GetAvailabilityHrs(DateTime From, DateTime To, int UserID)
        //{
        //    ObjectParameter p=new ObjectParameter("availableHrs",typeof(decimal));
        //    string res="0.00";
        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //           context.usp_getAvailableHrsByUserID(From, To, UserID,p);
        //           res = Convert.ToString(p.Value);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return res;
        //}
        public IList<usp_AvailabilityInWeek_Result> GetAvailabilityIndex(DateTime From, DateTime To, int UserID,out string totalHrs,int EstimationID, int AwaitedID)
        {
            //ObjectParameter p = new ObjectParameter("totalHrs", typeof(decimal));
            IList<usp_AvailabilityInWeek_Result> list = null;
            totalHrs = "0.00";
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_AvailabilityInWeek(From, To, UserID, EstimationID, AwaitedID, p).ToList<usp_AvailabilityInWeek_Result>();
                //    totalHrs = Convert.ToString(p.Value);
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
            return list;          
        }

       
    }
}
