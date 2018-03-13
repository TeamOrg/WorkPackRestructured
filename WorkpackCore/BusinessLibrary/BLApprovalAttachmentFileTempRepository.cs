using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{

    public class BLApprovalAttachmentFileTempRepository : IBLApprovalAttachmentFileTempRepository
    {  
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ApprovalAttachmentFileTemp> _attachmentFile;

        public BLApprovalAttachmentFileTempRepository(WorkpackDBContext context, IGenericDataRepository<ApprovalAttachmentFileTemp> attachmentFile)
        {
            _context = context;
            _attachmentFile = attachmentFile;
        }
        public IList<ApprovalAttachmentFileTemp> GetAllAttachmentFile()
        {
            return _attachmentFile.GetAll();
        }
        public ApprovalAttachmentFileTemp GetAttachmentFileByAttachFileID(int attachmentFileID)
        {
            return _attachmentFile.GetSingle(d => d.AttachFileID == attachmentFileID);
        }
        public List<ApprovalAttachmentFileTemp> GetAttachmentFileByDelFileID(int DelFileID, string UserId)
        {
            List<ApprovalAttachmentFileTemp> lst = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    lst = Context.ApprovalAttachmentFileTemps.Where(a => a.FileID == DelFileID && a.CreatedBy == UserId).ToList<ApprovalAttachmentFileTemp>();
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
        public void AddAttachmentFileTemp(params ApprovalAttachmentFileTemp[] attachmentFile)
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
        public void UpdateAttachmentFile(params ApprovalAttachmentFileTemp[] attachmentFile)
        {
            try
            {
                _attachmentFile.Update(attachmentFile);
            }
            catch (Exception ex)
            {
                //////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                ////throw new Exception("Record not updated.");
            }
        }
        public void RemoveAttachmentFile(params ApprovalAttachmentFileTemp[] attachmentFile)
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
