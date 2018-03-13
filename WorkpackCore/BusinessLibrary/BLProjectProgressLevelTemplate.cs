using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectProgressLevelTemplate : IBLProjectProgressLevelTemplate
    {
        




        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectProgressLevelTemplate> _projectProgressTemplate;

        public BLProjectProgressLevelTemplate(WorkpackDBContext context, IGenericDataRepository<ProjectProgressLevelTemplate> projectProgressTemplate)
        {
            _context = context;
            _projectProgressTemplate = projectProgressTemplate;
        }
        public ProjectProgressLevelTemplate GetMilestoneTemplateByName(string Name)
        {
            return _projectProgressTemplate.GetSingle(c => c.ProgressLevelTemplateName == Name);
        }

        public ProjectProgressLevelTemplate GetProgressTemplateByID(int TemplateDetailID)
        {
            return _projectProgressTemplate.GetSingle(c => c.ProgressLevelTemplateID == TemplateDetailID);
        }
        public void AddProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate)
        {
            try
            {
                _projectProgressTemplate.Add(projectProgressLevelTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate)
        {
            try
            {
                _projectProgressTemplate.Update(projectProgressLevelTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate)
        {
            try
            {
                _projectProgressTemplate.Remove(projectProgressLevelTemplate);
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

        public int getAddProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate)
        {
            int result = 0;
            try
            {
               result= _projectProgressTemplate.getAdd(projectProgressLevelTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return result;
        }
        public int getUpdateProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate)
        {
            int result = 0;
            try
            {
                result = _projectProgressTemplate.getUpdate(projectProgressLevelTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
            return result;
        }
        public int getRemoveProjectProgressLevelTemplate(params ProjectProgressLevelTemplate[] projectProgressLevelTemplate)
        {
            int result = 0;
            try
            {
                result = _projectProgressTemplate.getRemove(projectProgressLevelTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
            return result;
        }


    }
}
