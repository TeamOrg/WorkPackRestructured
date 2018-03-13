using System.Collections.Generic;
using DomainModelLibrary;
using iTextSharp.text;

namespace BusinessLibrary
{
    public interface IBLSimilarProjectRepository
    {
        void AddSimilarProject(params SimilarProject[] similarProjects);
        IList<SimilarProject> GetAllSimilarProject();
        SimilarProject GetSimilarProjectByID(int similarProjectID);
        List<ListItem> GetSimilarProjectByProjectID(int ProjectID);
        List<ListItem> GetSimilarProjectRecursiveByProjectID(int ProjectID);
        void RemoveSimilarProject(params SimilarProject[] similarProjects);
        void RemoveSimilarProjectByProjectID(int ProjectID);
        void UpdateSimilarProject(params SimilarProject[] similarProjects);
    }
}