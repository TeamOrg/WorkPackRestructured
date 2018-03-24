using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLExUsersRepository : IBLExUsersRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ExUsers> _exUsers;

        public BLExUsersRepository(WorkpackDBContext context, IGenericDataRepository<ExUsers> exUsers)
        {
            _context = context;
            _exUsers = exUsers;
        }


        public IList<ExUsers> GetAllExUsers(int companyId)
        {
            return (from q in _context.ExUser where q.CompanyId== companyId select q).ToList();
        }
        public ExUsers GetExUsersByID(int ExUsersID)
        {
            return _exUsers.GetSingle(d => d.ExUserID == ExUsersID);
        }
        public void AddExUsers(params ExUsers[] ExUsers)
        {
            try
            {
                _exUsers.Add(ExUsers);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateExUsers(params ExUsers[] ExUsers)
        {
            try
            {
                _exUsers.Update(ExUsers);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveExUsers(params ExUsers[] ExUsers)
        {
            try
            {
                _exUsers.Remove(ExUsers);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        
    
    }
}
