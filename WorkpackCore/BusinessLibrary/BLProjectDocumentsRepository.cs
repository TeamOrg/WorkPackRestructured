using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectDocumentsRepository : IBLProjectDocumentsRepository
    {
        



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectDocument> _projectDocuments;

        public BLProjectDocumentsRepository(WorkpackDBContext context, IGenericDataRepository<ProjectDocument> projectDocuments)
        {
            _context = context;
            _projectDocuments = projectDocuments;
        }



        public IList<ProjectDocument> GetAllProjectDocument()
        {
            return _projectDocuments.GetAll();
        }
        public List<ProjectDocument> GetAllProjectDocumentByProjectID(int ProjectID)
        {
            List<ProjectDocument> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProjectDocuments.Where(a => a.ProjectID == ProjectID).OrderByDescending(a=>a.CreatedOn).ToList<ProjectDocument>();
            //}
            return lst;
        }
        public ProjectDocument GetProjectDocumentByID(int ProjectDocumentID)
        {
            return _projectDocuments.GetSingle(d => d.ProjectlDocumentsID == ProjectDocumentID);
        }
        public void AddprojectDocument(params ProjectDocument[] ProjectDocuments)
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
        public void UpdateprojectDocument(params ProjectDocument[] projectDocument)
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
        public void RemoveprojectDocument(params ProjectDocument[] projectDocument)
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

        public void RemoveRemoveprojectDocumentByProjectID(int ProjectID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.ProjectDocuments.Where(a => a.ProjectID == ProjectID);
            //        foreach (var item in x)
            //        {
            //            context.ProjectDocuments.Remove(item);
            //            context.SaveChanges();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw new Exception("Record not deleted.");
            //    }
            //}
        }

    }
}
