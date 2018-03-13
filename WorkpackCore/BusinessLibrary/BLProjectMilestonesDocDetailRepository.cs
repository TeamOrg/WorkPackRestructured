using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectMilestonesDocDetailRepository : IBLProjectMilestonesDocDetailRepository
    {

        





        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectMilestonesDocDetail> _progressdeliverable;

        public BLProjectMilestonesDocDetailRepository(WorkpackDBContext context, IGenericDataRepository<ProjectMilestonesDocDetail> progressdeliverable)
        {
            _context = context;
            _progressdeliverable = progressdeliverable;
        }
        



        public IList<ProjectMilestonesDocDetail> GetAllProjectMilestonesDocDetail()
        {
            return _progressdeliverable.GetAll();
        }

        public void AddProjectMilestonesDocDetail(params ProjectMilestonesDocDetail[] progressdeliverabledetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _progressdeliverable.Add(progressdeliverabledetail);
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
        public void RemoveProjectMilestonesDocDetail(params ProjectMilestonesDocDetail[] ProjectMilestonesDocDetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _progressdeliverable.Remove(ProjectMilestonesDocDetail);
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
        public List<ProjectMilestonesDocDetail> GetAllpercentageByMilestoneAndTaskTypeID(int MilestoneID, int TaskTypeID)
        {
            List<ProjectMilestonesDocDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProjectMilestonesDocDetails.Where(c => c.ProjectMilestoneID == MilestoneID && c.TaskTypeID == TaskTypeID).ToList<ProjectMilestonesDocDetail>();
            //}
            return lst;
        }
        public void UpdateProjectMilestonesDocDetail(params ProjectMilestonesDocDetail[] progressdeliverabledetail)
        {
            /* Validation and error handling omitted */
            try
            {
                _progressdeliverable.Update(progressdeliverabledetail);
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
        public List<ProjectMilestonesDocDetail> GetAllpercentageByMilestone(int MilestoneID)
        {
            List<ProjectMilestonesDocDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProjectMilestonesDocDetails.Where(c => c.ProjectMilestoneID == MilestoneID).ToList<ProjectMilestonesDocDetail>();
            //}
            return lst;
        }
       
    }
}
