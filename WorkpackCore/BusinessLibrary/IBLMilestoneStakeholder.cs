using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMilestoneStakeholder
    {
        void AddMaterial(params MilestonesStakeHolder[] attachmentFile);
        List<MilestonesStakeHolder> GetAllStakeHolderByMilestoneID(int ProjectID, int MilestoneID, int RevisionID, int TaskID);
        List<string> GetAllStakeHolderByMilestoneIDStageNotify(int MilestoneID, int TaskID);
        List<MilestonesStakeHolder> GetDrpStakeHolderByMilestoneID(int ProjectID, int MilestoneID);
        IList<MilestonesStakeHolder> GetProfile();
        List<MilestonesStakeHolder> GetStakeHolderByMilestoneID(string UserID, int ProjectID, int MilestoneID, int RevisionID, int TaskID);
        bool IsStakeholder(int projectID, string UserID, int MilestoneID);
        void RemoveMaterial(params MilestonesStakeHolder[] attachmentFile);
        void RemoveStakeholderByProjectID(int ProjectID, int milestoneID);
        List<MilestonesStakeHolder> StakeHolderNotify(int ProjectID, int MilestoneID, int TaskID);
        void UpdateMaterial(params MilestonesStakeHolder[] attachmentFile);
    }
}