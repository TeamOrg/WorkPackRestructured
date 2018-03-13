using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLFileStatusRepository : IBLFileStatusRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<FileStatu> _fileStatus;

        public BLFileStatusRepository(WorkpackDBContext context, IGenericDataRepository<FileStatu> fileStatus)
        {
            _context = context;
            _fileStatus = fileStatus;
        }
        public IList<FileStatu> GetAllFileStatus()
        {
            return _fileStatus.GetAll();
        }

        public FileStatu GetFileStatusByID(int FileStatusID)
        {
            return _fileStatus.GetSingle(d => d.FileStatusID == FileStatusID);
        }
        public void AddFileStatus(params FileStatu[] fileStatus)
        {
            try
            {
                _fileStatus.Add(fileStatus);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateFileStatuse(params FileStatu[] fileStatus)
        {
            try
            {
                _fileStatus.Update(fileStatus);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }

        public List<FileStatu> DuplicateFilestatus(string Userid, int FileID)
        {
            List<FileStatu> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = db.FileStatus.Where(f => f.UserID == Userid && f.FileID == FileID).ToList<FileStatu>();
            //}
            return list;
        }


        public void RemoveFileStatuse(params FileStatu[] fileStatus)
        {
            try
            {
                _fileStatus.Remove(fileStatus);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

      

        public void DuplicateFileCheckerhavingNoCommentRight(string Userid, int FileID, int milestone)
        {
        
            //BLFileStatusRepository objFileStatus = new BLFileStatusRepository();
              
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    var listData = (from ch in db.FileCheckers
            //                    join ud in db.UploadDeliverableFiles on ch.UploadDeliverableFileID equals ud.UploadDeliverableFileID
            //                    where ch.UploadDeliverableFileID == FileID && ud.MilestoneID == milestone && ch.UserID == Userid && ch.CanEdit.Contains("N")
            //                    select new
            //                    {
            //                        UploadDeliverableFileID = ch.UploadDeliverableFileID,
            //                        UserID = ch.UserID,
            //                        MilestoneID = ud.MilestoneID
            //                    }).ToList();

            //    foreach (var item in listData)
            //    {
            //        int fileID =Convert.ToInt32(item.UploadDeliverableFileID);
            //        string userID = item.UserID;
            //        List<FileStatu> lstFileStatus = new List<FileStatu>();
            //        int milestoneid =Convert.ToInt32(item.MilestoneID);
            //        lstFileStatus = GetDuplicateFileCheckerhavingNoCommentRight(fileID,userID,milestoneid);                    
            //        foreach (var itemdelete in lstFileStatus)
            //        {
            //            FileStatu lst = new FileStatu();
            //            lst.FileStatusID = itemdelete.FileStatusID;
            //            lst.FileID = itemdelete.FileStatusID;
            //            lst.ProgresslevelID = itemdelete.ProgresslevelID;
            //            lst.UserID = itemdelete.UserID;
            //            lst.StatusID = itemdelete.StatusID;
            //            lst.EntityState = DominModel.EntityState.Deleted;
            //            objFileStatus.RemoveFileStatuse(lst);
            //        }
            //    }
            //}
        }
        public List<FileStatu> GetDuplicateFileCheckerhavingNoCommentRight(int FileID,string userID,int ProgresslevelID)
        {
            List<FileStatu> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list =(from a in db.FileStatus.Where(a=>a.FileID==FileID && a.UserID==userID && a.ProgresslevelID==ProgresslevelID) select a).ToList<FileStatu>();
            //}
            return list;
        }
        public List<FileStatu> GetApprovedCountList(int FileID, int ProgresslevelID)
        {
            List<FileStatu> list = null;
            //int AprroveStatusID=Convert.ToInt32(Common.FileStatusID.Approved);
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = (from a in db.FileStatus.Where(a => a.FileID == FileID && a.ProgresslevelID == ProgresslevelID && a.StatusID==AprroveStatusID) select a).ToList<FileStatu>();
            //}
            return list;
        }
        public bool IsFileApprovedByUser(int FileID, string userID)
        {
           bool IsFileApprovedByUser =false;
            //int AprroveStatusID=Convert.ToInt32(Common.FileStatusID.Approved);
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    var list = (from a in db.FileStatus.Where(a => a.FileID == FileID && a.UserID == userID && a.StatusID == AprroveStatusID) select a).ToList<FileStatu>();
            //    if (list.Count > 0)
            //    {
            //        IsFileApprovedByUser = true;
            //    }
            //}
            return IsFileApprovedByUser;
        }



        public int GetfileStatusID(int FileID)
        {
            int FileStatusID = 0;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //  // var list = (from a in db.FileStatus.Where(a => a.FileID == FileID ) select a).ToList<FileStatu>();

            //   var list = (from a in db.FileStatus
            //                     join b in db.FileCheckers
            //                         on new { UserID = a.UserID, UploadDeliverableFileID = a.FileID }
            //                         equals new { UserID = b.UserID, UploadDeliverableFileID = b.UploadDeliverableFileID }
            //                     where a.FileID == FileID && b.CanEdit=="Y"
            //                     select a).ToList<FileStatu>();

            //   var listStatus = (from a in db.FileStatus join b in db.FileCheckers
            //                                             on new { UserID = a.UserID, UploadDeliverableFileID = a.FileID }
            //      equals new { UserID = b.UserID, UploadDeliverableFileID = b.UploadDeliverableFileID }
            //      where a.FileID == FileID &&  b.CanEdit=="Y" && a.StatusID==0
            //      select a ).ToList<FileStatu>();



            //   var listCanEditNo = (from a in db.FileStatus
            //               join b in db.FileCheckers
            //                   on new { UserID = a.UserID, UploadDeliverableFileID = a.FileID }
            //                   equals new { UserID = b.UserID, UploadDeliverableFileID = b.UploadDeliverableFileID }
            //               where a.FileID == FileID && b.CanEdit == "N"
            //               select a).ToList<FileStatu>();

              





            //   var listUploaded = list.Where(a=>a.StatusID== Convert.ToInt32(Common.FileStatusID.Uploaded)).ToList<FileStatu>();
            //   var listCommented = list.Where(a => a.StatusID == Convert.ToInt32(Common.FileStatusID.Commented)).ToList<FileStatu>();
            //   var listCommentResolution = list.Where(a => a.StatusID == Convert.ToInt32(Common.FileStatusID.CommentResolution)).ToList<FileStatu>();
            //   var listApproved = list.Where(a => a.StatusID == Convert.ToInt32(Common.FileStatusID.Approved)).ToList<FileStatu>();


            //   if (list.Count == listUploaded.Count())
            //   {
            //       FileStatusID = Convert.ToInt32(Common.FileStatusID.Uploaded);
            //   }
            //   else if (list.Count == listCommented.Count())
            //   {
            //       FileStatusID = Convert.ToInt32(Common.FileStatusID.Commented);
            //   }
            //   else if (list.Count == listCommentResolution.Count())
            //   {
            //       FileStatusID = Convert.ToInt32(Common.FileStatusID.CommentResolution);
            //   }
            //   else if (list.Count == listApproved.Count())
            //   {
            //       FileStatusID = Convert.ToInt32(Common.FileStatusID.Approved);
            //   }
            //   else
            //   {
            //       FileStatusID =Convert.ToInt32(list.Min(a=>a.StatusID));
            //       int  MaxFileStatusID = Convert.ToInt32(list.Max(a => a.StatusID));
            //       if (FileStatusID == Convert.ToInt32(Common.FileStatusID.Commented))
            //       {  
            //           FileStatusID = Convert.ToInt32(Common.FileStatusID.Commented);
            //       }
            //       else if (FileStatusID == Convert.ToInt32(Common.FileStatusID.CommentResolution))
            //       {
            //           FileStatusID = Convert.ToInt32(Common.FileStatusID.CommentResolution);
            //       }
            //       else if (FileStatusID == Convert.ToInt32(Common.FileStatusID.Approved))
            //       {
            //           FileStatusID = Convert.ToInt32(Common.FileStatusID.Approved);
            //       }
            //       else
            //       {
            //           if (FileStatusID == 0 && MaxFileStatusID > 0 )                       
            //           {
            //               FileStatusID = Convert.ToInt32(Common.FileStatusID.Commented);
            //           }
            //           else if (listStatus.Count > 0)
            //           {
            //               FileStatusID = 4;
            //           }
            //       }                  
                  
            //   }

            //   if (((list.Count + listCanEditNo.Count) == (listStatus.Count + listCanEditNo.Count)) && (list.Count + listCanEditNo.Count) > 0)
            //   {
            //       FileStatusID = 4;
            //   }
              



            //}
            return FileStatusID;
        }


        public string FilestatusText(int iFileID)
        {
            //    BLUploadDeliverableFile uploader = new BLUploadDeliverableFile();        
            //    UploadDeliverableFile objupload = new UploadDeliverableFile();
            string str = "";// uploader.GetUploaderInfo(iFileID);       
            int p = GetfileStatusID(iFileID);
            string src = "";
            switch (p)
            {
                case 0:
                    src= "Uploaded <br> " +str;
                    break;
                case 1:
                    src = "Commented";
                    break;
                case 2:
                    src = "Comment Resolution";
                    break;
                case 3:
                    src = "Approved";
                    break;
                case 4:
                    src = "Sent";
                    break;

                default:
                    src = "Uploaded <br> "+str;
                    break;
            }
            return src;

        }




        public void UpdateFileStatusOnComment(string Userid, int FileID,int statusID)
        {
            //BLFileStatusRepository objFileStatus = new BLFileStatusRepository();
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    var listData = (from ch in db.UploadDeliverableFiles where ch.UploadDeliverableFileID == FileID 
            //                    select new {MilestoneID = ch.MilestoneID}).Distinct().ToList();
            //      int milestone = 0;
            //      int revisionID = 0;
            //      foreach (var item in listData)
            //      {
            //          milestone = Convert.ToInt32(item.MilestoneID);
            //      }
                   
            //    if(milestone==0)
            //    {
            //        var listRevisonData = (from ch in db.UploadDeliverableFiles
            //                        where ch.UploadDeliverableFileID == FileID
            //                        select new { RevisionID = ch.RevisionID }).Distinct().ToList();              
                    
            //        foreach (var item in listRevisonData)
            //         {
            //            revisionID = Convert.ToInt32(item.RevisionID);
            //         }

            //        var RlistData = (from ch in db.RevisionFiles
            //                         where ch.RevisionID == revisionID
            //                         select new { MilestoneID = ch.StatusID }).Distinct().ToList();

            //        foreach (var item in RlistData)
            //        {
            //            milestone = Convert.ToInt32(item.MilestoneID);
            //        }


            //    }


            //    BLFileStatusRepository blFileStatus = new BLFileStatusRepository();
            //    List<FileStatu> lstblFileStatus = blFileStatus.GetDuplicateFileCheckerhavingNoCommentRight(FileID, Userid, milestone).ToList<FileStatu>();
            //    foreach (var item in lstblFileStatus)
            //    {

            //        item.StatusID = statusID;
            //        item.EntityState = DominModel.EntityState.Modified;

            //    }
            //    blFileStatus.UpdateFileStatuse(lstblFileStatus.ToArray());
            //}
        }





    }
}
