using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLAssignResourceForEstimationRepository : IBLAssignResourceForEstimationRepository
    {

        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<AssignResourceForEstimation> _assignResourceForEstimationRepository;

        public BLAssignResourceForEstimationRepository(WorkpackDBContext context, IGenericDataRepository<AssignResourceForEstimation> assignResourceForEstimationRepository)
        {
            _context = context;
            _assignResourceForEstimationRepository = assignResourceForEstimationRepository;
        }
        public IList<AssignResourceForEstimation> GetAllAssignResourceForEstimation()
        {
            return _assignResourceForEstimationRepository.GetAll();
        }
        public AssignResourceForEstimation GetAssignResourceForEstimationByID(Int32 assignResourceForEstimationID)
        {
            return _assignResourceForEstimationRepository.GetSingle(d => d.EstimationID == assignResourceForEstimationID);
            //include _assignResourceForEstimationRepository employees
        }
        public void AddAssignResourceForEstimation(params AssignResourceForEstimation[] assignResourceForEstimation)
        {
            /* Validation and error handling omitted */
            _assignResourceForEstimationRepository.Add(assignResourceForEstimation);
        }
        public void UpdateAssignResourceForEstimation(params AssignResourceForEstimation[] assignResourceForEstimation)
        {
            /* Validation and error handling omitted */
            _assignResourceForEstimationRepository.Update(assignResourceForEstimation);
        }
        public void RemoveAssignResourceForEstimation(params AssignResourceForEstimation[] assignResourceForEstimation)
        {
            /* Validation and error handling omitted */
            try
            {
                _assignResourceForEstimationRepository.Remove(assignResourceForEstimation);
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
        public List<AssignResourceForEstimation> GetAssignResourceForEstimationByProjectID(int ProjectID)
        {
            List<AssignResourceForEstimation> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.AssignResourceForEstimations.Where(a => a.ProjectID == ProjectID).ToList<AssignResourceForEstimation>();
            //}
            return lst;
        }

        public int GetAssignResourceUserID(int ProjectID, int UserID)
        {
            int iUserID = 0;
            List<AssignResourceForEstimation> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.AssignResourceForEstimations.Where(a => a.ProjectID == ProjectID && a.UserID == UserID).ToList<AssignResourceForEstimation>();
            //}
            //if (lst.Count() > 0)
            //{
            //    iUserID = UserID;
            //}
            return iUserID;


        }
    }


    
}
