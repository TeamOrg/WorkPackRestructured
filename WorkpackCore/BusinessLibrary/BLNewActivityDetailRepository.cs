using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNewActivityDetailRepository : IBLNewActivityDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NewActivityDetail> _NewActivityDetail;

        public BLNewActivityDetailRepository(WorkpackDBContext context, IGenericDataRepository<NewActivityDetail> NewActivityDetail)
        {
            _context = context;
            _NewActivityDetail = NewActivityDetail;
        }
        public IList<NewActivityDetail> GetAllNewActivityDetails()
        {
            return _NewActivityDetail.GetAll();
        }
        public NewActivityDetail GetNewActivityDetailByID(int NewActivityDetailID)
        {
            return _NewActivityDetail.GetSingle(d => d.NewActivityDetailID == NewActivityDetailID);
        }
        public void AddNewActivityDetails(params NewActivityDetail[] NewActivityDetails)
        {
            try
            {
                _NewActivityDetail.Add(NewActivityDetails);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNewActivityDetails(params NewActivityDetail[] NewActivityDetails)
        {
            try
            {
                _NewActivityDetail.Update(NewActivityDetails);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNewActivityDetails(params NewActivityDetail[] NewActivityDetails)
        {
            try
            {
                _NewActivityDetail.Remove(NewActivityDetails);
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

        public List<usp_GetAllNewActivityUsersByActvityID_Result> GetAllNewActivityUsersByActvityID(int ActivityID)
        {
            List<usp_GetAllNewActivityUsersByActvityID_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_GetAllNewActivityUsersByActvityID(ActivityID).ToList<usp_GetAllNewActivityUsersByActvityID_Result>();
            //}
            return lst;
        }

        public List<NewActivityDetail> GetAllNewActivityDetailsByActivityID(int NewActivityID)
        {
            List<NewActivityDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.NewActivityDetails.Where(a => a.NewActivityID == NewActivityID).ToList<NewActivityDetail>();
            //}
            return lst;
        }
    }
}
