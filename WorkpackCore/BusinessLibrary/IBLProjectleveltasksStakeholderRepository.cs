using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectleveltasksStakeholderRepository
    {
        void AddProjectleveltasksStakeholder(params ProjectleveltasksStakeholder[] ProjectleveltasksStakeholder);
        ProjectleveltasksStakeholder GetProjectleveltasksStakeholderByID(int Id);
        void RemoveProjectleveltasksStakeholder(params ProjectleveltasksStakeholder[] ProjectleveltasksStakeholder);
        void UpdateProjectleveltasksStakeholder(params ProjectleveltasksStakeholder[] ProjectleveltasksStakeholder);
    }
}