using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectDocumentsRepository
    {
        void AddprojectDocument(params ProjectDocument[] ProjectDocuments);
        IList<ProjectDocument> GetAllProjectDocument();
        List<ProjectDocument> GetAllProjectDocumentByProjectID(int ProjectID);
        ProjectDocument GetProjectDocumentByID(int ProjectDocumentID);
        void RemoveprojectDocument(params ProjectDocument[] projectDocument);
        void RemoveRemoveprojectDocumentByProjectID(int ProjectID);
        void UpdateprojectDocument(params ProjectDocument[] projectDocument);
    }
}