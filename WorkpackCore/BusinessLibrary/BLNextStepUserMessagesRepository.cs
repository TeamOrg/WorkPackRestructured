using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNextStepUserMessagesRepository : IBLNextStepUserMessagesRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NextStepMessageUser> _NextStepUserMessagesRepository;

        public BLNextStepUserMessagesRepository(WorkpackDBContext context, IGenericDataRepository<NextStepMessageUser> NextStepUserMessagesRepository)
        {
            _context = context;
            _NextStepUserMessagesRepository = NextStepUserMessagesRepository;
        }


        public IList<NextStepMessageUser> GetAllUsersAvailable()
        {
            return _NextStepUserMessagesRepository.GetAll();
        }

        public void AddNextStepMessagesUsers(params NextStepMessageUser[] nextStepMessageUser)
        {
            /* Validation and error handling omitted */
            _NextStepUserMessagesRepository.Add(nextStepMessageUser);
        }
        public void UpdateNextStepMessagesUsers(params NextStepMessageUser[] nextStepMessageUser)
        {
            /* Validation and error handling omitted */
            _NextStepUserMessagesRepository.Update(nextStepMessageUser);
        }

        public List<usp_InsertNextStepMessagesUser_Result> GetNextStepMessageUserByUserID(int UserID,int ProjectID)
        {
            List<usp_InsertNextStepMessagesUser_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.usp_InsertNextStepMessagesUser(UserID,ProjectID).ToList<usp_InsertNextStepMessagesUser_Result>();
            //}
            return lst;
        }

    }
}
