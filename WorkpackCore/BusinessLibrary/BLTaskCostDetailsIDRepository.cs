using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskCostDetailsIDRepository : IBLTaskCostDetailsIDRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskCostDetail> _taskCostDetailsIDRepository;

        public BLTaskCostDetailsIDRepository(WorkpackDBContext context, IGenericDataRepository<TaskCostDetail> taskCostDetailsIDRepository)
        {
            _context = context;
            _taskCostDetailsIDRepository = taskCostDetailsIDRepository;
        }






        public IList<TaskCostDetail> GetAllTaskCostDetails()
        {
            return _taskCostDetailsIDRepository.GetAll();
        }
        public TaskCostDetail GetTaskCostDetailID(Int32 TaskCostDetailID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _taskCostDetailsIDRepository.GetSingle(d => d.TaskCostDetailsID == TaskCostDetailID);
            //include related employees
        }
        public void AddTaskCostDetail(params TaskCostDetail[] taskCostDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskCostDetailsIDRepository.Add(taskCostDetail);
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
        public void UpdateTaskCostDetail(params TaskCostDetail[] taskCostDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskCostDetailsIDRepository.Update(taskCostDetail);
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
        public void RemoveTaskCostDetail(params TaskCostDetail[] taskCostDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskCostDetailsIDRepository.Remove(taskCostDetail);
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

        public List<TaskCostDetail> GetTaskCostDetailByTaskID(int TaskID)
        {
            /* Validation and error handling omitted */
            List<TaskCostDetail> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.TaskCostDetails.Where(c => c.TaskID == TaskID).ToList<TaskCostDetail>();
                //}
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
            return lst;
        }
    }
}