using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLCommentedAttachFileRepository : IBLCommentedAttachFileRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<commentedAttachFile> _commentedAttachFile;

        public BLCommentedAttachFileRepository(WorkpackDBContext context, IGenericDataRepository<commentedAttachFile> commentedAttachFile)
        {
            _context = context;
            _commentedAttachFile = commentedAttachFile;
        }


        public IList<commentedAttachFile> GetAllcommentedAttachFile()
        {
            return _commentedAttachFile.GetAll();
        }
        public commentedAttachFile GetcommentedAttachFileByID(int commentedAttachFileID)
        {
            return _commentedAttachFile.GetSingle(d => d.commentedAttachFileId == commentedAttachFileID);
        }
        public void AddcommentedAttachFile(params commentedAttachFile[] commentedAttachFile)
        {
            try
            {
                _commentedAttachFile.Add(commentedAttachFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdatecommentedAttachFile(params commentedAttachFile[] commentedAttachFile)
        {
            try
            {
                _commentedAttachFile.Update(commentedAttachFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemovecommentedAttachFile(params commentedAttachFile[] commentedAttachFile)
        {
            try
            {
                _commentedAttachFile.Remove(commentedAttachFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }


        public List<commentedAttachFile> GetcommentedAttachFileByUserIdAndFileID(string UserID,int FileID)
        {

            List<commentedAttachFile> lst = null;//_context.commentedAttachFile.Where(a => a.UserID == UserID && a.FileID == FileID).ToList<commentedAttachFile>();
                return lst;
            
        }



        public List<commentedAttachFile> GetcommentedAttachFileByUserIdAndFileIDandAttachedFileName(string UserID, int FileID,string strFileName)
        {

            List<commentedAttachFile> lst = null; //_context.commentedAttachFile.Where(a => a.UserID == UserID && a.FileID == FileID && a.AttachFilePath.Contains(strFileName)).ToList<commentedAttachFile>();
                return lst;
            
        }







        public List<commentedAttachFile> GetcommentedAttachFileByFileID(int FileID)
        {

            List<commentedAttachFile> lst = null; //_context.commentedAttachFile.Where(a => a.FileID == FileID).ToList<commentedAttachFile>();
                return lst;
            
        }

    }
}
