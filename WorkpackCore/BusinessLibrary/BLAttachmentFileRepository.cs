using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.IO;

namespace BusinessLibrary
{
    public class BLAttachmentFileRepository : IBLAttachmentFileRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<AttachmentFile> _attachmentFile;

        public BLAttachmentFileRepository(WorkpackDBContext context, IGenericDataRepository<AttachmentFile> attachmentFile)
        {
            _context = context;
            _attachmentFile = attachmentFile;
        }
        public IList<AttachmentFile> GetAllAttachmentFile()
        {
            return _attachmentFile.GetAll();
        }
        public AttachmentFile GetAttachmentFileByAttachFileID(int attachmentFileID)
        {
            return _attachmentFile.GetSingle(d => d.AttachFileID == attachmentFileID);
        }
        public List<AttachmentFile> GetAttachmentFileByDelFileID(int DelFileID)
        {
            List<AttachmentFile> lst = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    lst = Context.AttachmentFiles.Where(a => a.FileID == DelFileID).ToList<AttachmentFile>();
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
        public void AddAttachmentFile(params AttachmentFile[] attachmentFile)
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
        public void UpdateAttachmentFile(params AttachmentFile[] attachmentFile)
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
        public void RemoveAttachmentFile(params AttachmentFile[] attachmentFile)
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



        public bool Checkattachmentfilifexists(int fileid, int refid)
        {


            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    if (Context.AttachmentFiles.Where(a => a.FileID == fileid && a.ReferenceFileid == refid).Count() > 0)
            //        return true;

            //    else
            //        return false;
            //}
            return false;
        }

        public string Checkattachmentfilifexists(int fileid, string filename, string tablename, int delid = 0, int milestoneid = 0, int revesionid = 0)
        {


            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    int count = 0;
            //    BLUploadDeliverableFile blu = new BLUploadDeliverableFile();
            //    BLCheckerAttachmentFile blcheckerattach = new BLCheckerAttachmentFile();
            //    List<int> lst = new List<int>();
            //    List<int> lstpgc = new List<int>();
            //    int? DeliverableListID;
            //    int? MilestoneID;
            //    int? RevisionID;

            //    if (fileid > 0)
            //    {
            //        DeliverableListID = blu.GetUploadDeliverableFileByID(fileid).DeliverableListID;
            //        MilestoneID = blu.GetUploadDeliverableFileByID(fileid).MilestoneID;
            //        RevisionID = blu.GetUploadDeliverableFileByID(fileid).RevisionID;
            //    }
            //    else
            //    {

            //        DeliverableListID = delid;
            //        MilestoneID = milestoneid;
            //        RevisionID = revesionid;
            //    }


            //    if (MilestoneID > 0)
            //        lst = blu.GetUploadDeliverableFileByRevMilID("", Convert.ToInt32(MilestoneID), Convert.ToInt32(DeliverableListID)).Select(a => a.UploadDeliverableFileID).ToList<int>();
            //    else
            //        lst = blu.GetUploadDeliverableFileByRevMilID("R", Convert.ToInt32(RevisionID), Convert.ToInt32(DeliverableListID)).Select(a => a.UploadDeliverableFileID).ToList<int>();
            //    string filenamereturn = "";
            //    string name = Path.GetFileNameWithoutExtension(filename);
            //    string ext = Path.GetExtension(filename);
            //    lstpgc = Context.PageCommentDetails.Where(a => lst.Contains((int)a.UploadDeliverableFileID)).Select(a => a.PageCommentDetailID).ToList<int>();

            //    if (tablename == "AttachmentFile")
            //    {
            //        List<string> lstatt = new List<string>();
            //        List<AttachmentFile> attach = GetAllAttachmentFile().Where(a => lst.Contains((int)a.FileID)).ToList();
            //        List<PageComment_images> lstpi = Context.PageComment_images.Where(a => lstpgc.Contains((int)a.PageCommentDetailID)).ToList();
            //        List<commentedAttachFile> lstca = Context.commentedAttachFile.Where(a => lst.Contains((int)a.FileID)).ToList();
            //        List<CheckerAttachmentFile> lstchecatta = blcheckerattach.GetAttachedFileBydelid(Convert.ToInt32(DeliverableListID), Convert.ToInt32(MilestoneID), Convert.ToInt32(RevisionID));
            //        foreach (AttachmentFile a in attach)
            //            lstatt.Add(a.FileName);
            //        foreach (CheckerAttachmentFile a in lstchecatta)
            //            lstatt.Add(a.FileName);
            //        foreach (PageComment_images a in lstpi)
            //            lstatt.Add(a.FileName.Split('.')[0]);
            //        foreach (commentedAttachFile ca in lstca)
            //            lstatt.Add(ca.AttachFilePath.Substring(ca.AttachFilePath.LastIndexOf(@"/") + 1).Split('.')[0]);

            //        count = Context.AttachmentFiles.Where(a => lst.Contains((int)a.FileID) && a.FileName.ToUpper()==name.ToUpper() && a.FileExtention.ToUpper() == ext.ToUpper() && a.ReferenceFileid == null).Count();
            //        count += Context.PageComment_images.Where(a => lstpgc.Contains((int)a.PageCommentDetailID) && a.FileName.ToUpper()==filename.ToUpper()).Count();
            //        count += lstchecatta.Where(a => a.FileName.ToUpper()==name.ToUpper() && a.FileExtention.ToUpper() == ext.ToUpper()).Count();
            //        List<string> lsts = Context.commentedAttachFile.Where(a => lst.Contains((int)a.FileID)).Select(a => a.AttachFilePath).ToList<string>();
            //        if (lsts.Count() > 0)
            //            count += lsts.Where(a => a.Substring(a.LastIndexOf(@"/") + 1).ToUpper()==filename.ToUpper()).Count();

            //        if (count > 0)
            //        {
            //            int a = 0;
            //            while (true)
            //            {
            //                a++;
            //                int c= lstatt.Where(x => x.ToUpper() == (name + "(" + Convert.ToString(a) + ")").ToUpper()).Count();
            //                if (c == 0)
            //                {
            //                    filenamereturn = name + "(" + Convert.ToString(a) + ")" + ext;
            //                    break;
            //                }
            //            }
            //        }

            //    }
            //    if (filenamereturn == "")
            //    {
            //        filenamereturn = filename;
            //    }


            //    return filenamereturn;
            //}
            return "";
        }

        public List<GetAttachmentFileAsPerSource_Result> GetFileAsAttachment(int fileid, string source)
        {
            List<GetAttachmentFileAsPerSource_Result> fileAsAttachment = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    fileAsAttachment = Context.GetAttachmentFileAsPerSource(fileid, source).ToList<GetAttachmentFileAsPerSource_Result>();                
            //}
            return fileAsAttachment;
        }



    }

    public class FileAsAttachment
    {
        public int AttachFileID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string AttachmentSource { get; set; }
    }
}
