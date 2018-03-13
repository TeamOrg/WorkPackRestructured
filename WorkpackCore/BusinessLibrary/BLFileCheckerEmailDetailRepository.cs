using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public class BLFileCheckerEmailDetailRepository : IBLFileCheckerEmailDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<FileCheckerEmailDetail> _fileChecker;

        public BLFileCheckerEmailDetailRepository(WorkpackDBContext context, IGenericDataRepository<FileCheckerEmailDetail> fileChecker)
        {
            _context = context;
            _fileChecker = fileChecker;
        }



        public IList<FileCheckerEmailDetail> GetAllFileCheckers()
        {
            return _fileChecker.GetAll();
        }




        public string GetAllFileCheckersBySentCounter(Int32 SentCounter,List<FileCheckerEmailDetail> lstfc)
        {
           // BLUploadDeliverableFile blupl = new BLUploadDeliverableFile();
                List<FileCheckerEmailDetail> lst=null;
                string filesName = "";
                string fileIds = ""; 

                lst = lstfc.Where(a => a.SentCounter == SentCounter).ToList<FileCheckerEmailDetail>();
                ArrayList arr = new ArrayList();
                

                //foreach (var item in lst)
                //{
                //    if (arr.Contains(item.UploadDeliverableFileID) == false)
                //    {
                //        UploadDeliverableFile uf = blupl.GetUploadDeliverableFileByID(Convert.ToInt32(item.UploadDeliverableFileID));
                //        filesName = filesName + uf.FileName + (uf.FileExtention.Contains("aspx") ? "" : uf.FileExtention)+ " , " ;
                //        arr.Add(item.UploadDeliverableFileID);
                //        fileIds = fileIds + item.UploadDeliverableFileID + ",";
                //    }
                  
                //}
                //filesName = filesName.TrimEnd(filesName[filesName.Length - 1]);
                return filesName.TrimEnd(',') + "#" + fileIds;
        }


        public FileCheckerEmailDetail GetFileCheckerByID(int FileCheckerID)
        {
            return _fileChecker.GetSingle(d => d.FileCheckerID == FileCheckerID);
        }

        public void AddUploadDeliverableFile(params FileCheckerEmailDetail[] fileChecker)
        {
            try
            {
                _fileChecker.Add(fileChecker);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateUploadDeliverableFile(params FileCheckerEmailDetail[] fileChecker)
        {
            try
            {
                _fileChecker.Update(fileChecker);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }

        public FileCheckerEmailDetail GetFileCheckerEmailDetailAsPerFileidUseridSentcounter(string userid, int fileid, int sentcounter)
        {
            return _fileChecker.GetSingle(d => d.UserID == userid.Trim() && d.UploadDeliverableFileID == fileid && d.SentCounter == sentcounter);
        }


        public FileCheckerEmailDetail UpdateCheckerMessageID(int? FilecheckeID, int? sentCounter, string MessageID, string MessageSubject)
        {

            //List<FileChecker> objchecker = new List<FileChecker>();
            FileCheckerEmailDetail lstChecker = GetAllFileCheckers().Where(a => a.FileCheckerID == FilecheckeID && a.SentCounter == sentCounter).FirstOrDefault();


            lstChecker.MessageSubject = MessageSubject;
            lstChecker.MessageID = MessageID;
            lstChecker.EntityState = EntityState.Modified;


            return lstChecker;
            //UpdateUploadDeliverableFile(objchecker.ToArray());               
        }



        public void RemoveUploadDeliverableFile(params FileCheckerEmailDetail[] fileChecker)
        {
            try
            {
                _fileChecker.Remove(fileChecker);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }



    }
}
