using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMilestoneStakeholder : IBLMilestoneStakeholder
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MilestonesStakeHolder> _Material;

        public BLMilestoneStakeholder(WorkpackDBContext context, IGenericDataRepository<MilestonesStakeHolder> Material)
        {
            _context = context;
            _Material = Material;
        }
        public IList<MilestonesStakeHolder> GetProfile()
        {
            return _Material.GetAll();
        }
        //public Profile GetByProfileID(int ProfileId)
        //{
        //    return _Material.GetSingle(d => d.ProfileID == ProfileId);
        //}
        //public List<MaterialdetailsColumn> GetProfileByFileID(int DelFileID)
        //{
        //    List<MaterialdetailsColumn> lst = null;
        //    try
        //    {
        //        using (var Context = new Cubicle_EntityEntities())
        //        {
        //            lst = Context.Profiles.Where(a => a.ProfileID == DelFileID).ToList<Profile>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return lst;
        //}
        public void AddMaterial(params MilestonesStakeHolder[] attachmentFile)
        {
            try
            {
                _Material.Add(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateMaterial(params MilestonesStakeHolder[] attachmentFile)
        {
            try
            {
                _Material.Update(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveMaterial(params MilestonesStakeHolder[] attachmentFile)
        {
            try
            {
                _Material.Remove(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public List<MilestonesStakeHolder> GetStakeHolderByMilestoneID(string UserID, int ProjectID, int MilestoneID, int RevisionID, int TaskID)
        {
            List<MilestonesStakeHolder> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (RevisionID > 0)
            //    {
            //        lst = context.MilestonesStakeHolders.Where(a => a.UserID == UserID && a.ProjectID == ProjectID && a.RevisionID == RevisionID).ToList<MilestonesStakeHolder>();
            //    }
            //    else
            //    {
            //        lst = context.MilestonesStakeHolders.Where(a => a.UserID == UserID && a.ProjectID == ProjectID && a.MilestoneID == MilestoneID).ToList<MilestonesStakeHolder>();
            //    }
            //    if (lst.Count() > 0 && (lst.Where(a => a.Flag.Trim() == "MS").Count() > 0 || lst.Where(a => (a.Flag.Trim() == "DS") && a.TaskID == TaskID).Count() > 0))
            //    {
            //        return lst;
            //    }
            //    else
            //    {
            //        lst = new List<MilestonesStakeHolder>();
            //    }
            //}
            return lst;
        }


        public List<MilestonesStakeHolder> GetAllStakeHolderByMilestoneID(int ProjectID, int MilestoneID, int RevisionID, int TaskID)
        {
            List<MilestonesStakeHolder> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    if (RevisionID > 0)
            //    {
            //        lst = context.MilestonesStakeHolders.Where(a => a.ProjectID == ProjectID && a.RevisionID == RevisionID).ToList<MilestonesStakeHolder>();
            //    }
            //    else
            //    {
            //        lst = context.MilestonesStakeHolders.Where(a => a.ProjectID == ProjectID && a.MilestoneID == MilestoneID).ToList<MilestonesStakeHolder>();
            //    }
            //    if (lst.Count() > 0 && (lst.Where(a => a.Flag.Trim() == "MS").Count() > 0 || lst.Where(a => (a.Flag.Trim() == "DS") && a.TaskID == TaskID).Count() > 0))
            //    {
            //        return lst;
            //    }
            //    else
            //    {
            //        lst = new List<MilestonesStakeHolder>();
            //    }
            //}
            return lst;
        }

        public List<string> GetAllStakeHolderByMilestoneIDStageNotify(int MilestoneID, int TaskID)
        {
            List<MilestonesStakeHolder> lst = null;
            List<string> result = new List<string>();
          //  using (var context = new Cubicle_EntityEntities())
          //  {               
          //      lst = context.MilestonesStakeHolders.Where(a =>a.MilestoneID == MilestoneID).ToList<MilestonesStakeHolder>();               
          //      if (lst.Count() >0)                    
          //      {
          //result= lst.Where(a => a.Flag.Trim() == "MS").Select(a=>a.UserID).ToList<string>().Union(lst.Where(a => (a.Flag.Trim() == "DS") && a.TaskID == TaskID).Select(a => a.UserID).ToList<string>()).ToList();
               
          //      }
          //  }
            return result;
           
        }


        public List<MilestonesStakeHolder> StakeHolderNotify(int ProjectID, int MilestoneID, int TaskID)
        {
            List<MilestonesStakeHolder> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.MilestonesStakeHolders.Where(a => a.ProjectID == ProjectID && a.MilestoneID == MilestoneID).ToList<MilestonesStakeHolder>();

            //}
            return lst;
        }

        public void RemoveStakeholderByProjectID(int ProjectID, int milestoneID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        var x = context.MilestonesStakeHolders.Where(a => a.ProjectID == ProjectID && a.Flag.Trim() == "MS" && a.MilestoneID == milestoneID);
            //        foreach (var item in x)
            //        {

            //            context.MilestonesStakeHolders.Remove(item);
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

        public Boolean IsStakeholder(int projectID, string UserID, int MilestoneID)
        {
            Boolean IsProjectAdmin = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var items = from item in context.MilestonesStakeHolders
            //                where item.ProjectID == projectID && item.UserID == UserID && item.MilestoneID == MilestoneID && item.Flag == "MS"
            //                select item;

            //    if (items.Count() > 0)
            //    {
            //        IsProjectAdmin = true;
            //    }

            //}
            return IsProjectAdmin;
        }

        public List<MilestonesStakeHolder> GetDrpStakeHolderByMilestoneID(int ProjectID, int MilestoneID)
        {
            List<MilestonesStakeHolder> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.MilestonesStakeHolders.Where(a => a.ProjectID == ProjectID && a.MilestoneID == MilestoneID).ToList<MilestonesStakeHolder>();
            //    if (lst.Count() > 0 && (lst.Where(a => a.Flag.Trim() == "MS").Count() > 0))
            //    {
            //        return lst;
            //    }
            //    else
            //    {
            //        lst = new List<MilestonesStakeHolder>();
            //    }
            //}
            return lst;
        }
    }
}
