using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectTempDocumentsRepository : IBLProjectTempDocumentsRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectTempDocument> _projectDocuments;

        public BLProjectTempDocumentsRepository(WorkpackDBContext context, IGenericDataRepository<ProjectTempDocument> projectDocuments)
        {
            _context = context;
            _projectDocuments = projectDocuments;
        }





        public IList<ProjectTempDocument> GetAllProjectTempDocument()
        {
            return _projectDocuments.GetAll();
        }
        public List<ProjectTempDocument> GetAllProjectTempDocumentByUserID(string UserID)
        {
            List<ProjectTempDocument> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProjectTempDocuments.Where(a => a.CreatedBy == UserID).ToList<ProjectTempDocument>();
            //}
            return lst;
        }
        public ProjectTempDocument GetProjectTempDocumentByID(int ProjectTempDocumentID)
        {
            return _projectDocuments.GetSingle(d => d.ProjectlDocumentsID == ProjectTempDocumentID);
        }
        public void AddprojectTempDocument(params ProjectTempDocument[] ProjectDocuments)
        {
            try
            {
                _projectDocuments.Add(ProjectDocuments);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateprojectTempDocument(params ProjectTempDocument[] projectDocument)
        {
            try
            {
                _projectDocuments.Update(projectDocument);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveprojectTempDocument(params ProjectTempDocument[] projectDocument)
        {
            try
            {
                _projectDocuments.Remove(projectDocument);
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
    }
}
