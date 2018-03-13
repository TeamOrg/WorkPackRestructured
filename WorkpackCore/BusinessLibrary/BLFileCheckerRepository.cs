using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public class BLFileCheckerRepository : IBLFileCheckerRepository
    {     

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<FileChecker> _fileChecker;

        public BLFileCheckerRepository(WorkpackDBContext context, IGenericDataRepository<FileChecker> fileChecker)
        {
            _context = context;
            _fileChecker = fileChecker;
        }
        public IList<FileChecker> GetAllFileCheckers()
        {
            return _fileChecker.GetAll();
        }
       
        public FileChecker GetFileCheckerByID(int FileCheckerID)
        {
            return _fileChecker.GetSingle(d => d.FileCheckerID == FileCheckerID);
        }



        public FileChecker UpdateCheckerMessageID(string UserID, int FileID, string messageID, string emailSubject)
        {

            //List<FileChecker> objchecker = new List<FileChecker>();
           FileChecker lstChecker = GetAllFileCheckers().Where(a => a.UserID == UserID && a.UploadDeliverableFileID == FileID).FirstOrDefault();

           
                        lstChecker.MessageSubject = emailSubject;
                        lstChecker.MessageID = messageID;
                        lstChecker.EntityState = EntityState.Modified;
                        
                    
            return lstChecker;
                  //UpdateUploadDeliverableFile(objchecker.ToArray());               
            }



        public int  getFilecheckerIdByUserIDFileID(string UserID, int? FileID)
        {

            //List<FileChecker> objchecker = new List<FileChecker>();
            FileChecker lstChecker = GetAllFileCheckers().Where(a => a.UserID == UserID && a.UploadDeliverableFileID == FileID).FirstOrDefault();
            return lstChecker.FileCheckerID;
            //UpdateUploadDeliverableFile(objchecker.ToArray());               
        }







        public void AddUploadDeliverableFile(params FileChecker[] fileChecker)
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
        public void UpdateUploadDeliverableFile(params FileChecker[] fileChecker)
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
        public void RemoveUploadDeliverableFile(params FileChecker[] fileChecker)
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


        public void PopulatesenderData(List<FileCheckerEmailDetail> lstfc, ref DataTable dt, int ProjectID)
        {
            
            //var fc = lstfc.GroupBy(x =>new{ x.SentCounter , x.UploadDeliverableFileID}).First().OrderByDescending(a => a.SentCounter).FirstOrDefault();

            //BLFileCheckerEmailDetailRepository objEmailChecker = new BLFileCheckerEmailDetailRepository();
            //string FilesName = objEmailChecker.GetAllFileCheckersBySentCounter(Convert.ToInt32(fc.SentCounter), lstfc);
            //string FilesNameUD = FilesName;
            //FilesName = FilesName.Split('#')[0].ToString();
            //string FilesIds = FilesNameUD.Split('#')[1].ToString();

       
            //BLUserRepository blu= new BLUserRepository();
            //BLUploadDeliverableFile blupl = new BLUploadDeliverableFile();
            //string messageId = !string.IsNullOrEmpty(fc.MessageID) ?fc.MessageID.Substring(1, fc.MessageID.Length - 2).Split('@')[0]:Guid.NewGuid().ToString();
         
            //var vlstfc = lstfc.Where(a => a.UserID.Contains("@")).ToList();
            //if (fc != null) {
            //    if (!string.IsNullOrEmpty(fc.SenderId))
            //    {
            //        UploadDeliverableFile uf = blupl.GetUploadDeliverableFileByID(Convert.ToInt32(fc.UploadDeliverableFileID));
            //        DataRow dr;

            //        string subject = "<a href=#  vParameters=" + FilesIds + " ProjectID=" + ProjectID.ToString() + " MsgID=" + messageId + " Type=INTERNAL flag=" + "R" + " onclick=RedirecttoEmaildetails(this) >" + fc.MessageSubject + "</a>";
            //        dr = dt.NewRow();
            //        dr["From"] = fc.SenderId.Contains("@") ? fc.SenderId : blu.GetuserByID(Convert.ToInt32(fc.SenderId)).EmailID1;
            //        dr["To"] = string.Join(",<br>", lstfc.Where(a => a.SentCounter == fc.SentCounter && fc.UploadDeliverableFileID == a.UploadDeliverableFileID).Select(x => x.UserID.Contains("@") ? x.UserID : blu.GetuserByID(Convert.ToInt32(x.UserID)).FirstName + " " + blu.GetuserByID(Convert.ToInt32(x.UserID)).LastName).ToArray());
            //        dr["Subject"] = subject;
            //        dr["Date"] = fc.CreatedOn.Value;
            //        dr["File Name"] = FilesName;
            //        dr["Body"] = fc.MessageBody;
            //        dr["MsgID"] = messageId;
            //        dr["Flag"] = "S";
            //        dr["SentCounter"] = fc.SentCounter;

            //        dt.Rows.Add(dr);
            //    }
                
            //    lstfc = lstfc.Where(x => !(lstfc.Where(a => a.SentCounter == fc.SentCounter).Select(a => a.FileCheckerEmailDetailID).ToList()).Contains(x.FileCheckerEmailDetailID)).ToList();

             
            //}
            



            //if (lstfc.Count > 0)
            //    PopulatesenderData(lstfc, ref dt, ProjectID);
            
        }


        //public void PopulatesenderDataForInternal(List<FileCheckerEmailDetail> lstfc, ref DataTable dt, int ProjectID)
        //{

        //    var fc = lstfc.GroupBy(x => new { x.SentCounter, x.UploadDeliverableFileID }).First().OrderByDescending(a => a.SentCounter).FirstOrDefault();
        //    //var fcc = lstfc.Where(x => x.UserID.Equals(UserID.ToString())).FirstOrDefault();
        //    BLUserRepository blu = new BLUserRepository();
        //    BLUploadDeliverableFile blupl = new BLUploadDeliverableFile();
        //    CultureInfo ci = new CultureInfo("en-Gb");

        //    if (fc != null)
        //    {
        //        if (!string.IsNullOrEmpty(fc.SenderId))
        //        {
        //            UploadDeliverableFile uf = blupl.GetUploadDeliverableFileByID(Convert.ToInt32(fc.UploadDeliverableFileID));
        //            DataRow dr;
        //            string messageId = Guid.NewGuid().ToString();
        //            //string subject = "<a href=#  vParameters=" + uf.UploadDeliverableFileID + " ProjectID=" + ProjectID.ToString() + " MsgID=" + fc.MessageID.Substring(1, fc.MessageID.Length - 2).Split('@')[0] + " Type=INTERNAL flag=" + "R" + " onclick=RedirecttoEmaildetails(this) >" + fc.MessageSubject + "</a>";

        //            string subject = "<a href=#  vParameters=" + uf.UploadDeliverableFileID + " ProjectID=" + ProjectID.ToString() + " MsgID="+ messageId+  " Type=INTERNAL flag=" + "R" + " onclick=RedirecttoEmaildetails(this) >" + fc.MessageSubject + "</a>";
        //            dr = dt.NewRow();
        //            dr["From"] = fc.SenderId.Contains("@") ? fc.SenderId : blu.GetuserByID(Convert.ToInt32(fc.SenderId)).EmailID1;
        //            dr["To"] = string.Join(",<br>", blu.GetuserByID(lstfc.Where(a => a.SentCounter == fc.SentCounter && fc.UploadDeliverableFileID == a.UploadDeliverableFileID).Select(x => Convert.ToInt32(x.UserID)).ToArray()).Select(a => a.FirstName + " " + a.LastName).ToList());
        //            dr["Subject"] = subject;
        //            dr["Date"] = fc.CreatedOn.Value;
        //            dr["File Name"] = uf.FileName + uf.FileExtention;
        //            dr["Body"] = fc.MessageBody;
        //            dr["MsgID"] = messageId;
        //            dr["Flag"] = "S";
        //            dr["SentCounter"] = fc.SentCounter;

        //            dt.Rows.Add(dr);
        //        }
        //        lstfc = lstfc.Where(x => !(lstfc.Where(a => a.SentCounter == fc.SentCounter && fc.UploadDeliverableFileID == a.UploadDeliverableFileID).Select(a => a.FileCheckerEmailDetailID).ToList()).Contains(x.FileCheckerEmailDetailID)).ToList();
        //    }
        //    var lstfilecheckExternal = lstfc.Where(a => a.UserID.Contains("@")).ToList();



        //    if (lstfc.Count > 0 && lstfilecheckExternal.Count > 0)
        //        PopulatesenderData(lstfc, ref dt, ProjectID);
        //    if (lstfc.Count > 0 && lstfilecheckExternal.Count == 0)
        //        PopulatesenderDataForInternal(lstfc, ref dt, ProjectID);


        //   // if (lstfc.Count > 0)
        //     //   PopulatesenderDataForInternal(lstfc, ref dt, ProjectID);
        //}

        public List<FileChecker> GetFileCheckerByUploadDelFileID(string FileIDs)
        {
            List<FileChecker> lst=null;
            List<int?> hh = FileIDs.TrimEnd(',').Split(',').ToList<string>().Select<string,int?>(q=>Convert.ToInt32(q)).ToList<int?>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = new List<FileChecker>();
            //    lst = context.FileCheckers.Where(a=>hh.Contains(a.UploadDeliverableFileID)).ToList<FileChecker>();
                
            //}
            return lst;
        }
        public List<FileChecker> GetFileCheckerByFileID(int FileID)
        {
            List<FileChecker> lst = null;           
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.FileCheckers.Where(a =>a.UploadDeliverableFileID==FileID).ToList<FileChecker>();

            //}
            return lst;
        }

        public List<FileChecker> GetFileCheckerCanEditByFileID(int FileID)
        {
            List<FileChecker> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.FileCheckers.Where(a => a.UploadDeliverableFileID == FileID && a.CanEdit=="Y").ToList<FileChecker>();

            //}
            return lst;
        }

        public IList<FileChecker> GetFileCheckerList(string Userid, int FileID, string CanEdit)
        {
            IList<FileChecker> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = db.FileCheckers.Where(f => f.UserID == Userid && f.UploadDeliverableFileID == FileID && f.CanEdit == CanEdit).ToList();
            //}
           return list;
        }

        public List<FileChecker> DuplicateFileChecker(string Userid, int FileID, string Type)
        {
            List<FileChecker> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = db.FileCheckers.Where(f => f.UserID == Userid && f.UploadDeliverableFileID == FileID && f.flag.Contains(Type == "INTERNAL" ? "CH" : "CO")).ToList<FileChecker>();
            //}
            return list;
        }

        //bipin 
        public int GetSentCounter(int FileID)
        {
            List<FileChecker> list = null;
            int Icoount = 0;

            //using (var db = new Cubicle_EntityEntities())
            //{
                
            //   // list = db.FileCheckers.Where(f => f.UploadDeliverableFileID == FileID ).ToList<FileChecker>();


            //    var results = from c in db.FileCheckers
            //                  join cn in db.FileCheckerEmailDetails on c.FileCheckerID equals cn.FileCheckerID
            //                  where (c.UploadDeliverableFileID == FileID)
            //                  select new { SentCounter = cn.SentCounter };


            //    var item = results.Max(x => x.SentCounter);
            //    var qq = item.GetValueOrDefault();
            //    if (qq == null)
            //    {
            //        Icoount = 1;
            //    }
            //    else
            //    {
            //        Icoount = Convert.ToInt32(qq) + 1;
            //    }
              

            //}
            return Icoount;
        }



 public string GetCheckerList(string UserID,int FileID)
    {
        string lstchecker = "";
        
        //int iFileID = Convert.ToInt32(FileID);
        List<FileChecker> list = null;
        List<FileChecker> listChecker = null;
        int Icoount = 0;          
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = db.FileCheckers.Where(f => f.UploadDeliverableFileID == FileID && f.UserID == UserID).ToList<FileChecker>();
            //    var item = list.Max(x => x.SentCounter);
            //    var SentCounter = item.GetValueOrDefault();
            //    Icoount = Convert.ToInt32(SentCounter);
            //    listChecker = db.FileCheckers.Where(f => f.UploadDeliverableFileID == FileID && f.SentCounter == Icoount).ToList<FileChecker>();
            //    foreach(var itemchk in listChecker)
            //    {

            //        lstchecker +=  BLUserRepository.GetUserNameById(itemchk.UserID) + ",";
                   
            //    }  
            //}
            return lstchecker.TrimEnd(',');
        }
        public List<FileChecker> DuplicateFileChecker(string Userid, int FileID)
        {
            List<FileChecker> list = null;
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = db.FileCheckers.Where(f => f.UserID == Userid && f.UploadDeliverableFileID == FileID).ToList<FileChecker>();
            //}
            return list;
        }

        public void SetReadOnlyDemaildetails(string Userid, int FileID, int SentCounter)
        {
            //BLUploadDeliverableFile blup = new BLUploadDeliverableFile();
            //BLUserRepository blu = new BLUserRepository();
            //BLFileCheckerEmailDetailRepository blfcemail = new BLFileCheckerEmailDetailRepository();
            //User u = blu.GetuserByID(Convert.ToInt32(blup.GetUploadDeliverableFileByID(FileID).CreatedBy));
            //var fc = blfcemail.GetFileCheckerEmailDetailAsPerFileidUseridSentcounter(Userid, FileID, SentCounter);
            //if (fc != null)
            //{
            //    BasePage.checker = GetCheckerList(Userid, FileID);
            //    BasePage.Body = fc.MessageBody;
            //    BasePage.sender = u.FirstName + " " + u.LastName + "(" + u.EmailID1 + ")";
            //    BasePage.SenderUserName = u.FirstName + " " + u.LastName;
            //    BasePage.subject = fc.MessageSubject;
            //}
        }

        //public List<ListItem> GetFileCheckersByFileID(int FileID)
        //{
        //    List<ListItem> list = null;
        //    using (var db = new Cubicle_EntityEntities())
        //    {
        //        list = new List<ListItem>();
        //        var UserIds = (from f in db.FileCheckers
        //                       where
        //                       f.UploadDeliverableFileID == FileID && (f.flag == "CH" || f.flag == "CO") && f.CanEdit == "Y"
        //                       select new { f.UserID, f.IsClient });
        //        if (UserIds.Count() > 0)
        //        {
        //            List<int?> inUsers = (from id in UserIds where id.IsClient == "N" select id.UserID).ToList<string>().Select<string, int?>(q => Convert.ToInt32(q)).ToList<int?>();
        //            list= (from u in db.Users where inUsers.Contains(u.UserID) select new ListItem { Text = u.FirstName + " " + u.LastName, Value =SqlFunctions.StringConvert((double) u.UserID).Trim() }).ToList<ListItem>();
        //            foreach (var l in (from id in UserIds where id.IsClient == "Y" select id.UserID))
        //            {
        //                list.Add(new ListItem { Text = l, Value = l });
        //            }
                                                      
                    
        //        }

        //    }
        //    return list;
        //}
      
    }
}
