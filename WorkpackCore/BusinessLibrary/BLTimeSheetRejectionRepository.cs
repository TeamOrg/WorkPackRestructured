using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTimeSheetRejectionRepository : IBLTimeSheetRejectionRepository
    {
       


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TimeSheetRejection> _timesheetRejection;

        public BLTimeSheetRejectionRepository(WorkpackDBContext context, IGenericDataRepository<TimeSheetRejection> timesheetRejection)
        {
            _context = context;
            _timesheetRejection = timesheetRejection;
        }




        public IList<TimeSheetRejection> GetAllTimesheetRejection()
        {
            return _timesheetRejection.GetAll();
        }
        public TimeSheetRejection GetTimesheetRejectionByID(int TimesheetRejectionID)
        {
            return _timesheetRejection.GetSingle(d => d.TimeSheetRejectionID == TimesheetRejectionID);
        }


        //public List<object> GetTimesheetRejectionByTimeSheetWeeklyID(int TimeSheetWeeklyID, int? OwnerID)
        //{
        //    List<object> lst = new List<object>();
        //    try
        //    {
        //        using (var dbcontext = new Cubicle_EntityEntities())
        //        {


        //                lst = (from TSW in dbcontext.TimeSheetWeeklies 
        //                       join TSR in dbcontext.TimeSheetRejections.AsEnumerable()
        //                       on TSW.TimeSheetWeeklyID equals TSR.TimeSheetWeeklyID
        //                       join TSD in dbcontext.TimeSheetWeeklyDetails on TSW.TimeSheetWeeklyID equals TSD.TimeSheetWeeklyID
        //                       join U in dbcontext.Users on TSR.RejectedBy equals U.UserID
        //                       where TSW.TimeSheetWeeklyID == TimeSheetWeeklyID && TSW.ApprovalDate == null && TSW.FinalStatus == 0 && TSD.UserID == OwnerID
        //                      select new 
        //                       {
        //                           Rejectedby = U.FirstName + " " + U.LastName,
        //                           RejectedOn = TSR.RejectionDate.ToString(),
        //                           RejectionReason = TSR.RejectionReason
        //                       } ).Distinct().ToList<object>();



        //                       //select new
        //                       //{
        //                       //    Rejectedby = U.FirstName + " " + U.LastName,
        //                       //    RejectedOn = TSR.RejectionDate.ToString(),
        //                       //    RejectionReason = TSR.RejectionReason
        //                       //}).Distinct().ToList<object>();





        //                //List<object> myList = new List<object>();
        //                //IEnumerable<object> myEnumerable = lst;
        //                //List<object> listAgain =  from my in  myEnumerable select new
        //                //       {
        //                //           Rejectedby =my(XString),
        //                //           RejectedOn = TSR.RejectionDate.ToString(),
        //                //           RejectionReason = TSR.RejectionReason
        //                //       }).Distinct().ToList<object>();



        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        bool false = UserInterfaceExceptionHandler.HandleException(ref ex);

        //    }

        //    return lst;
        //}


        public List<object> GetTimesheetRejectionByTimeSheetWeeklyID(int TimeSheetWeeklyID, int? OwnerID)
        {
            List<object> lst = new List<object>();
            try
            {
                ////using (var dbcontext = new Cubicle_EntityEntities())
                ////{


                ////    lst = (from TSW in dbcontext.TimeSheetWeeklies
                ////           join TSR in dbcontext.TimeSheetRejections.AsEnumerable()
                ////           on TSW.TimeSheetWeeklyID equals TSR.TimeSheetWeeklyID
                ////           join TSD in dbcontext.TimeSheetWeeklyDetails on TSW.TimeSheetWeeklyID equals TSD.TimeSheetWeeklyID
                ////           join U in dbcontext.Users on TSR.RejectedBy equals U.UserID
                ////           where TSW.TimeSheetWeeklyID == TimeSheetWeeklyID && TSW.ApprovalDate == null && TSW.FinalStatus == 0 && TSD.UserID == OwnerID

                ////           select new
                ////            {
                ////                TimeSheetRejectionID = TSR.TimeSheetRejectionID,
                ////                Rejectedby = U.FirstName + " " + U.LastName,
                ////                RejectedOn = TSR.RejectionDate,
                ////                RejectionReason = TSR.RejectionReason
                ////            }).Distinct().AsEnumerable().Select(x => new
                ////           {
                ////               TimeSheetRejectionID = x.TimeSheetRejectionID,
                ////               Rejectedby = x.Rejectedby,
                ////               RejectedOn = x.RejectedOn.ToString(),
                ////               RejectionReason = x.RejectionReason
                ////           }).OrderByDescending(a=>a.TimeSheetRejectionID).ToList<object>();



                ////    //select new
                ////    //{
                ////    //    Rejectedby = U.FirstName + " " + U.LastName,
                ////    //    RejectedOn = TSR.RejectionDate.ToString(),
                ////    //    RejectionReason = TSR.RejectionReason
                ////    //}).Distinct().ToList<object>();





                ////    //List<object> myList = new List<object>();
                ////    //IEnumerable<object> myEnumerable = lst;
                ////    //List<object> listAgain =  from my in  myEnumerable select new
                ////    //       {
                ////    //           Rejectedby =my(XString),
                ////    //           RejectedOn = TSR.RejectionDate.ToString(),
                ////    //           RejectionReason = TSR.RejectionReason
                ////    //       }).Distinct().ToList<object>();



                ////}
            }
            catch (Exception ex)
            {
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);

            }

            return lst;
        }
        public void AddTimesheetRejection(params TimeSheetRejection[] TimesheetRejection)
        {
            try
            {
                _timesheetRejection.Add(TimesheetRejection);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateTimesheetRejection(params TimeSheetRejection[] TimesheetRejection)
        {
            try
            {
                _timesheetRejection.Update(TimesheetRejection);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTimesheetRejection(params TimeSheetRejection[] TimesheetRejection)
        {
            try
            {
                _timesheetRejection.Remove(TimesheetRejection);
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
    }
}
