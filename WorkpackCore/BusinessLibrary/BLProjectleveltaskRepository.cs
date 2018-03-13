using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectleveltaskRepository : IBLProjectleveltaskRepository
    {

        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Projectleveltask> _projectleveltask;

        public BLProjectleveltaskRepository(WorkpackDBContext context, IGenericDataRepository<Projectleveltask> projectleveltask)
        {
            _context = context;
            _projectleveltask = projectleveltask;
        }





        public Projectleveltask GetProjectleveltaskByID(int Id)
        {
            return _projectleveltask.GetSingle(d => d.ProjectleveltaskID == Id);
        }
        public void AddProjectleveltask(params Projectleveltask[] Projectleveltask)
        {
            try
            {
                _projectleveltask.Add(Projectleveltask);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectleveltask(params Projectleveltask[] Projectleveltask)
        {
            try
            {
                _projectleveltask.Update(Projectleveltask);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectleveltask(params Projectleveltask[] Projectleveltask)
        {
            try
            {
                _projectleveltask.Remove(Projectleveltask);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void UpdateProjectTaskProgress(int ProjectID,string Completionon,string ActionType)
        {
        
        //using(var context = new Cubicle_EntityEntities()){

        //    context.USP_UpdateProjectTaskProgress(ProjectID, Completionon, ActionType);
        
        //}
        
        }

            

        public bool CheckDuplicateofProjectLeveltasks( int projectlevelltaskid, string name )
        {

            return false;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())

            //    {

            //        Projectleveltask plt = context.Projectleveltasks.Where(a => a.DocumentDescription.Trim() == name.Trim() && a.ProjectleveltaskID == projectlevelltaskid).FirstOrDefault();

            //        if (plt != null)
            //            return true;
            //        else
            //            return false;

            //    }
              
            //}
            //catch (Exception ex)
            //{
            //    throw ex;

            //}
        }

        public List<Usp_GetProjectleveltasksForMilestone_Result> GetProjectleveltasksForMilestone(int Projectid) {

            List<Usp_GetProjectleveltasksForMilestone_Result> lst = new List<Usp_GetProjectleveltasksForMilestone_Result>();

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.Usp_GetProjectleveltasksForMilestone(Projectid).ToList<Usp_GetProjectleveltasksForMilestone_Result>();
            
            //}
            return lst;
        
        }


       
    }
}
