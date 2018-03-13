using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLEstimationTaskDependencyRepository : IBLEstimationTaskDependencyRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EstimationTaskDependency> _estimationTaskdependencyRepository;

        public BLEstimationTaskDependencyRepository(WorkpackDBContext context, IGenericDataRepository<EstimationTaskDependency> estimationTaskdependencyRepository)
        {
            _context = context;
            _estimationTaskdependencyRepository = estimationTaskdependencyRepository;
        }



        public IList<EstimationTaskDependency> GetAllEstimationTaskDependency()
        {
            return _estimationTaskdependencyRepository.GetAll();
        }
      
        private void AddEstimationTaskDependency(params EstimationTaskDependency[] EstimationTaskdependency)
        {
            /* Validation and error handling omitted */
            try
            {
                _estimationTaskdependencyRepository.Add(EstimationTaskdependency);
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
        public void UpdateEstimationTaskDependency(params EstimationTaskDependency[] EstimationTaskdependency)
        {
            /* Validation and error handling omitted */
            try
            {
                _estimationTaskdependencyRepository.Update(EstimationTaskdependency);
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
        public void RemoveEstimationTaskDependency(params EstimationTaskDependency[] EstimationTaskdependency)
        {
            /* Validation and error handling omitted */
            try
            {
                _estimationTaskdependencyRepository.Remove(EstimationTaskdependency);
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

        
        public Boolean SaveEstimationTaskDependency(EstimationTaskDependency obj)
        {
            Boolean res = false;
            try
            {
                AddEstimationTaskDependency(obj);
                res = true;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
    


   
       
    }
}
