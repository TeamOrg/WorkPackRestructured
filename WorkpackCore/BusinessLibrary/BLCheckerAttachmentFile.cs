using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLCheckerAttachmentFile : IBLCheckerAttachmentFile
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<CheckerAttachmentFile> _checkerAttachmentFile;

        public BLCheckerAttachmentFile(WorkpackDBContext context, IGenericDataRepository<CheckerAttachmentFile> checkerAttachmentFile)
        {
            _context = context;
            _checkerAttachmentFile = checkerAttachmentFile;
        }

        //public int GetProfileIDByCode(string ProfileCode)
        //{
        //    int ProfileID = 0;
        //    using (var Context = new Cubicle_EntityEntities())
        //    {
        //        Profile obj = _Profile.GetSingle(p => p.ProfileCode.ToUpper() == ProfileCode.ToUpper());
        //        if (obj != null)
        //        {
        //            ProfileID = obj.ProfileID;
        //        }
        //        return ProfileID;
        //    }
        //}
        public IList<CheckerAttachmentFile> GetCheckerAttachmentFile()
        {
            return _checkerAttachmentFile.GetAll();
        }
        public CheckerAttachmentFile GetByCheckerAttachmentFileID(int AttachCheckerFileID)
        {
            return _checkerAttachmentFile.GetSingle(d => d.AttachCheckerFileID == AttachCheckerFileID);
        }
        //public List<Profile> GetProfileByFileID(int DelFileID)
        //{
        //    List<Profile> lst = null;
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
        public void AddCheckerAttachmentFile(params CheckerAttachmentFile[] attachmentFile)
        {
            try
            {
                _checkerAttachmentFile.Add(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public void AddAttachmentFile(params CheckerAttachmentFile[] attachmentFile)
        {
            try
            {
                _checkerAttachmentFile.Add(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }



        public CheckerAttachmentFile GetAttachedFileByID(int AttachedFileID)
        {
            try
            {
                return _checkerAttachmentFile.GetSingle(d => d.AttachCheckerFileID == AttachedFileID);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateCheckerAttachmentFile(params CheckerAttachmentFile[] attachmentFile)
        {
            try
            {
                _checkerAttachmentFile.Update(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveCheckerAttachmentFile(params CheckerAttachmentFile[] attachmentFile)
        {
            try
            {
                _checkerAttachmentFile.Remove(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public List<CheckerAttachmentFile> GetAttachedFileBydelid(int delid, int milestoneid, int revisionid, string filename = "")
        {

            List<CheckerAttachmentFile> lst = new List<CheckerAttachmentFile>();
            //using (var context = new Cubicle_EntityEntities())
            //{
                //if (milestoneid > 0)
                //    lst = context.CheckerAttachmentFiles.Where(a => a.DeliverableListID == delid && a.MilestoneID == milestoneid).ToList();
                //else
                //    lst = context.CheckerAttachmentFiles.Where(a => a.DeliverableListID == delid && a.RevisionID == revisionid).ToList();


                return lst;

            //}

        }
    }
}
