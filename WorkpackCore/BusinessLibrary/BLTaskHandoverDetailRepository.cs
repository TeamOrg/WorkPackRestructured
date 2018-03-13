using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    class BLTaskHandoverDetailRepository : IBLTaskHandoverDetailRepository
    {

        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskHandoverDetail> _taskHandoverDetail;

        public BLTaskHandoverDetailRepository(WorkpackDBContext context, IGenericDataRepository<TaskHandoverDetail> taskHandoverDetail)
        {
            _context = context;
            _taskHandoverDetail = taskHandoverDetail;
        }





        public IList<TaskHandoverDetail> GetAllTaskHandoverDetail()
        {
            return _taskHandoverDetail.GetAll();
        }
        public TaskHandoverDetail GetTaskStartEndJustificationByID(Int32 TaskHandoverDetailID)
        {
            return _taskHandoverDetail.GetSingle(d => d.TaskHandoverDetailID == TaskHandoverDetailID);         
        }
        public void AddTaskHandoverDetail(params TaskHandoverDetail[] taskHandoverDetail)
        {
            try
            {
                _taskHandoverDetail.Add(taskHandoverDetail);
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
        public void UpdateTaskHandoverDetail(params TaskHandoverDetail[] taskHandoverDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskHandoverDetail.Update(taskHandoverDetail);
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
        public void RemoveTaskHandoverDetail(params TaskHandoverDetail[] taskHandoverDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskHandoverDetail.Remove(taskHandoverDetail);
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

        public List<TaskHandoverDetail> GetAllTaskHandoverDetailByTaskID(int TaskID)
        {
            List<TaskHandoverDetail> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.TaskHandoverDetails.Where(a => a.TaskID == TaskID).ToList<TaskHandoverDetail>();
            //}
            return lst;
        }

    }
    
}
