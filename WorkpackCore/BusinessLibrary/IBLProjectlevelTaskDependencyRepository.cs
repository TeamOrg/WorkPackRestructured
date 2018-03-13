using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectlevelTaskDependencyRepository
    {
        void AddProjectlevelTaskDependency(params ProjectlevelTaskDependency[] ProjectlevelTaskDependency);
        bool DeleteProjectlevelTaskDependency(int TaskDependencyID);
        ProjectlevelTaskDependency GetProjectlevelTaskDependencyByID(int Id);
        void RemoveProjectlevelTaskDependency(params ProjectlevelTaskDependency[] ProjectlevelTaskDependency);
        void UpdateProjectlevelTaskDependency(params ProjectlevelTaskDependency[] ProjectlevelTaskDependency);
    }
}