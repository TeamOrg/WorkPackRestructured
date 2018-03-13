using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{

    public class BLApprovalAttachmentFileRepository : IBLApprovalAttachmentFileRepository
    {

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ApprovalAttachmentFile> _attachmentFile;

        public BLApprovalAttachmentFileRepository(WorkpackDBContext context, IGenericDataRepository<ApprovalAttachmentFile> attachmentFile)
        {
            _context = context;
            _attachmentFile = attachmentFile;
        }
        
        public IList<ApprovalAttachmentFile> GetAllAttachmentFile()
        {
            return _attachmentFile.GetAll();
        }
        public ApprovalAttachmentFile GetAttachmentFileByAttachFileID(int attachmentFileID)
        {
            return _attachmentFile.GetSingle(d => d.AttachFileID == attachmentFileID);
        }
        public List<ApprovalAttachmentFile> GetAttachmentFileByDelFileID(int DelFileID)
        {
            List<ApprovalAttachmentFile> lst = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    lst = Context.ApprovalAttachmentFiles.Where(a => a.FileID == DelFileID).ToList<ApprovalAttachmentFile>();                    
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
            return lst;
        }
        public void AddAttachmentFile(params ApprovalAttachmentFile[] attachmentFile)
        {
            try
            {
                _attachmentFile.Add(attachmentFile);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not added.");
            }
        }
        public void UpdateAttachmentFile(params ApprovalAttachmentFile[] attachmentFile)
        {
            try
            {
                _attachmentFile.Update(attachmentFile);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not updated.");
            }
        }
        public void RemoveAttachmentFile(params ApprovalAttachmentFile[] attachmentFile)
        {
            try
            {
                _attachmentFile.Remove(attachmentFile);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //throw new Exception("Record not deleted.");
            }
        }
    }
}
