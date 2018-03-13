using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectleveltasksStakeholderRepository : IBLProjectleveltasksStakeholderRepository
    {

        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectleveltasksStakeholder> _projectleveltasksStakeholder;

        public BLProjectleveltasksStakeholderRepository(WorkpackDBContext context, IGenericDataRepository<ProjectleveltasksStakeholder> projectleveltasksStakeholder)
        {
            _context = context;
            _projectleveltasksStakeholder = projectleveltasksStakeholder;
        }



        public ProjectleveltasksStakeholder GetProjectleveltasksStakeholderByID(int Id)
        {
            return _projectleveltasksStakeholder.GetSingle(d => d.ProjectleveltasksStakeholdersID == Id);
        }





        public void AddProjectleveltasksStakeholder(params ProjectleveltasksStakeholder[] ProjectleveltasksStakeholder)
        {
            try
            {
                _projectleveltasksStakeholder.Add(ProjectleveltasksStakeholder);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectleveltasksStakeholder(params ProjectleveltasksStakeholder[] ProjectleveltasksStakeholder)
        {
            try
            {
                _projectleveltasksStakeholder.Update(ProjectleveltasksStakeholder);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectleveltasksStakeholder(params ProjectleveltasksStakeholder[] ProjectleveltasksStakeholder)
        {
            try
            {
                _projectleveltasksStakeholder.Remove(ProjectleveltasksStakeholder);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
