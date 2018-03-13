using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectTempDocumentsRepository
    {
        void AddprojectTempDocument(params ProjectTempDocument[] ProjectDocuments);
        IList<ProjectTempDocument> GetAllProjectTempDocument();
        List<ProjectTempDocument> GetAllProjectTempDocumentByUserID(string UserID);
        ProjectTempDocument GetProjectTempDocumentByID(int ProjectTempDocumentID);
        void RemoveprojectTempDocument(params ProjectTempDocument[] projectDocument);
        void UpdateprojectTempDocument(params ProjectTempDocument[] projectDocument);
    }
}