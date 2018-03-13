using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLUserCommentRepository : IBLUserCommentRepository
    {
        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<UserComment> _usercommentRepository;

        public BLUserCommentRepository(WorkpackDBContext context, IGenericDataRepository<UserComment> usercommentRepository)
        {
            _context = context;
            _usercommentRepository = usercommentRepository;
        }





        public IList<UserComment> GetAllUserComments()
        {
            return _usercommentRepository.GetAll();
        }
        public UserComment GetCommentListByCommentID_UserID(Int32 CommentID,Int32 UserID)
        {
            return _usercommentRepository.GetList(p => p.CommentID == CommentID && p.UserID == UserID).FirstOrDefault();
        }
        public UserComment GetUserCommentByID(Int32 UserCommentID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _usercommentRepository.GetSingle(d => d.UserCommentID == UserCommentID);                
                //include related employees
        }
        public void AddUserComment(params UserComment[] userComment)
        {
            /* Validation and error handling omitted */
            try
            {
                _usercommentRepository.Add(userComment);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateUserComment(params UserComment[] userComment)
        {
            /* Validation and error handling omitted */
            try
            {
                _usercommentRepository.Update(userComment);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveUserComment(params UserComment[] userComment)
        {
            /* Validation and error handling omitted */
            try
            {
                _usercommentRepository.Remove(userComment);
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

        public Boolean AddUserCommentList(List<Int_ListItem> commentIDList, Int32 UserID)
        {
            Boolean res = false;

                try
                {
                   

                    
                    var CommentIDs = from c in commentIDList
                                     join u in GetAllUserComments().ToList<UserComment>() on new { CommentID = c.itemField1, UserID=c.itemField2 } equals
                                         new { u.CommentID, u.UserID } into groups
                                     where !groups.Any()
                                     select c.itemField1;
                    
                  //  var CommentIDs = (from c in commentIDList select c).Except(from u in GetAllUserComments().ToList<UserComment>() select u.CommentID);
                    List<UserComment> userList = new List<UserComment>();
                    foreach (var l in CommentIDs)
                    {
                        UserComment uc = new UserComment();
                        uc.CommentID = Convert.ToInt32(l);
                        uc.EntityState = EntityState.Added;
                        uc.CreatedOn = System.DateTime.Now;
                        uc.UserID = UserID;
                        userList.Add(uc);
                    }
                    if(userList.Count()>0)
                    AddUserComment(userList.ToArray());
                 
                    res = true;
                }
                catch (Exception ex)
                {
                   
                    res = false;
                }

            return res;
        }
        
    }
}
