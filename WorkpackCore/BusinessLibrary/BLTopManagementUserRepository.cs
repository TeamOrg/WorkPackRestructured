using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTopManagementUserRepository : IBLTopManagementUserRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TopManagementUser> _topmanagement;

        public BLTopManagementUserRepository(WorkpackDBContext context, IGenericDataRepository<TopManagementUser> topmanagement)
        {
            _context = context;
            _topmanagement = topmanagement;
        }




        public IList<TopManagementUser> GetAllTopManagementUsers()
        {
            return _topmanagement.GetAll();
        }

        public void AddTopManagementUsers(params TopManagementUser[] TopManagementUsers)
        {
            try
            {
                _topmanagement.Add(TopManagementUsers);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public void UpdateTopManagementUsers(params TopManagementUser[] TopManagementUsers)
        {
            try
            {
                _topmanagement.Update(TopManagementUsers);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveTopManagementUsers(params TopManagementUser[] TopManagementUsers)
        {
            try
            {
                _topmanagement.Remove(TopManagementUsers);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public void RemoveTopManagemnt()
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.TopManagementUsers;
            //        foreach (var item in x)
            //        {
            //            context.TopManagementUsers.Remove(item);
            //            context.SaveChanges();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw new Exception("Record not deleted.");
            //    }
            //}
        }
    }
}
