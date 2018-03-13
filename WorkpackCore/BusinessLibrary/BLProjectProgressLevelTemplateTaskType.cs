using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{

    public class BLProjectProgressLevelTemplateTaskType : IBLProjectProgressLevelTemplateTaskType
    {


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectProgressLevelTemplateTaskType> _projectProgressLevelTemplateTaskType;

        public BLProjectProgressLevelTemplateTaskType(WorkpackDBContext context, IGenericDataRepository<ProjectProgressLevelTemplateTaskType> projectProgressLevelTemplateTaskType)
        {
            _context = context;
            _projectProgressLevelTemplateTaskType = projectProgressLevelTemplateTaskType;
        }






        public void AddProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType)
        {
            try
            {
                _projectProgressLevelTemplateTaskType.Add(projectProgressLevelTemplateTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType)
        {
            try
            {
                _projectProgressLevelTemplateTaskType.Update(projectProgressLevelTemplateTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType)
        {
            try
            {
                _projectProgressLevelTemplateTaskType.Remove(projectProgressLevelTemplateTaskType);
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

        public int getAddProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType)
        {
            int result = 0;
            try
            {
                result = _projectProgressLevelTemplateTaskType.getAdd(projectProgressLevelTemplateTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return result;
        }
        public int getUpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType)
        {
            int result = 0;
            try
            {
                result = _projectProgressLevelTemplateTaskType.getUpdate(projectProgressLevelTemplateTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
            return result;
        }
        public int getRemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplateTaskType[] projectProgressLevelTemplateTaskType)
        {
            int result = 0;
            try
            {
                result = _projectProgressLevelTemplateTaskType.getRemove(projectProgressLevelTemplateTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
            return result;
        }

        public IEnumerable<ProjectProgressLevelTemplateTaskType> GetTemplateTaskTypeByTemplateDetailID(int TemplateDetailID)
        {
            return _projectProgressLevelTemplateTaskType.GetAll().Where(c => c.ProgressLevelTemplateDetailID == TemplateDetailID).ToList();
        }

    }
}
