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
        private readonly IGenericDataRepository<ExUser> _exUsers;

        public BLExUsersRepository(WorkpackDBContext context, IGenericDataRepository<ExUser> exUsers)
        {
            _context = context;
            _exUsers = exUsers;
        }


        public IList<ExUser> GetAllExUsers()
        {
            return _exUsers.GetAll();//.Where(a=>a.CompanyId==Convert.ToInt32(HttpContext.Current.Session["CompanyId"])).ToList();
        }
        public ExUser GetExUsersByID(int ExUsersID)
        {
            return _exUsers.GetSingle(d => d.ExUserID == ExUsersID);
        }
        public void AddExUsers(params ExUser[] ExUsers)
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
        public void UpdateExUsers(params ExUser[] ExUsers)
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
        public void RemoveExUsers(params ExUser[] ExUsers)
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
