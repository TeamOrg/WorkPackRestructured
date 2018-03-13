using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLExtProjectMemberRepository : IBLExtProjectMemberRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ExtProjectsMember> _extProjectsMember;

        public BLExtProjectMemberRepository(WorkpackDBContext context, IGenericDataRepository<ExtProjectsMember> extProjectsMember)
        {
            _context = context;
            _extProjectsMember = extProjectsMember;
        }


        public void AddExtProjectsMember(params ExtProjectsMember[] ProjectsMember)
        {
            try
            {
                _extProjectsMember.Add(ProjectsMember);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void RemoveProjectsMemberByProjectID(int ProjectID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.ExtProjectsMembers.Where(a => a.ProjectID == ProjectID);
            //        foreach (var item in x)
            //        {
            //            context.ExtProjectsMembers.Remove(item);
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
      public void UpdateExtProjectsMember(params ExtProjectsMember[] ProjectsMember)
        {
            try
            {
                _extProjectsMember.Update(ProjectsMember);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public Boolean IsExtProjectMember(int projectID, int UserID)
        {
            Boolean IsProjectMember = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var items = from item in context.ExtProjectsMembers
            //                where item.ProjectID == projectID && item.UserID == UserID
            //                select item;

            //    if (items.Count() > 0)
            //    {
            //        IsProjectMember = true;
            //    }

            //}
            return IsProjectMember;
        }

        public Boolean IsExtProjectMemberJoined(int projectID, int UserID)
        {
            Boolean IsProjectMember = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var items = from item in context.ExtProjectsMembers
            //                where item.ProjectID == projectID && item.UserID == UserID && item.HasJoined=="Y"
            //                select item;

            //    if (items.Count() > 0)
            //    {
            //        IsProjectMember = true;
            //    }

            //}
            return IsProjectMember;
        }

        public List<User> GetExternalMember(int projectID,bool hasjoinedfilter=false)
        {
            try
            {
                List<User> lst = null;             
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = (from t in context.Users
                //           join p in context.ExtProjectsMembers on t.UserID equals p.UserID
                //           where p.ProjectID == projectID && p.HasJoined == (hasjoinedfilter== false ? "Y" : p.HasJoined)
                //           select t).ToList<User>();
                //}
                return lst;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Some error occured.");
            }
        }
    }
}
