using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLNextStepUserMessagesRepository
    {
        void AddNextStepMessagesUsers(params NextStepMessageUser[] nextStepMessageUser);
        IList<NextStepMessageUser> GetAllUsersAvailable();
        List<usp_InsertNextStepMessagesUser_Result> GetNextStepMessageUserByUserID(int UserID, int ProjectID);
        void UpdateNextStepMessagesUsers(params NextStepMessageUser[] nextStepMessageUser);
    }
}