using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMessageRepository : IBLMessageRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Message> _messageRepository;

        public BLMessageRepository(WorkpackDBContext context, IGenericDataRepository<Message> messageRepository)
        {
            _context = context;
            _messageRepository = messageRepository;
        }

        public IList<Message> GetAllMessages()
        {
            int CompanyId = 0; // HttpContext.Current.Session["CompanyId"]);
            return _messageRepository.GetAll().Where(c => c.CompanyId == CompanyId).ToList<Message>();
        }
        public Message GetMessageByID(Int32 messageID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _messageRepository.GetSingle(d => d.MessageID == messageID);
            //include related employees
        }
        public void AddMessage(params Message[] message)
        {
            /* Validation and error handling omitted */
            try
            {
                firebase fb = new firebase();
                foreach (var a in message)
                {
                    a.Date = System.DateTime.Now;
                }
                _messageRepository.Add(message);

                fb.addfirebase(message);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }





        public void UpdateMessage(params Message[] Message)
        {
            /* Validation and error handling omitted */
            try
            {
                _messageRepository.Update(Message);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveMessage(params Message[] skill)
        {
            /* Validation and error handling omitted */
            try
            {
                _messageRepository.Remove(skill);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }

        ////public static void GetCommunicationTitle(int ID, Literal ltr, string TaskOrResourceRequest)
        ////{
        ////    try
        ////    {
        ////        //using (var Context = new Cubicle_EntityEntities())
        ////        //{
        ////        //    ltr.Text = Context.usp_GetCommunicationTitle(ID, TaskOrResourceRequest).FirstOrDefault().ToString();
        ////        //}
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        ////        if (false)
        ////        {
        ////            throw ex;
        ////        }
        ////    }
        ////}
        ////public static void GetCommunicationTitleResource(int ID, Literal ltr, string TaskOrResourceRequest, int dept)
        ////{
        ////    try
        ////    {
        ////        //using (var Context = new Cubicle_EntityEntities())
        ////        //{
        ////        //    string Department = Context.Departments.Where(c => c.DepartmentID == dept).Select(a => a.DepartmentName).SingleOrDefault();
        ////        //    ltr.Text = Department.ToString();
        ////        //}
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        ////        if (false)
        ////        {
        ////            throw ex;
        ////        }
        ////    }
        ////}
        public static void UpdateDeActiveMessage(int MessageID)
        {
            try
            {
                //BLMessageRepository objBLMessageRepository = new BLMessageRepository();
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var Message = context.Messages.FirstOrDefault(p => p.MessageID == MessageID);
                //    var url = Message.RedirectURL;
                //    var toUser = Message.ToUserID;
                //    var Active = Message.Active;
                //    using (var con = new Cubicle_EntityEntities())
                //    {
                //        List<Message> Mess = con.Messages.Where(p => p.RedirectURL == url && p.ToUserID == toUser && p.Active == "Y").ToList<Message>();
                //        foreach (var item in Mess)
                //        {
                //            item.Active = "N";
                //            item.VisitDate = DateTime.Now;
                //            item.EntityState = DominModel.EntityState.Modified;
                //        }
                //        objBLMessageRepository.UpdateMessage(Mess.ToArray());
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public static void UpdateDeActiveMessageByMessageID(int MessageID)
        {
            try
            {
                //BLMessageRepository objBLMessageRepository = new BLMessageRepository();
                //using (var con = new Cubicle_EntityEntities())
                //{
                //    List<Message> Mess = con.Messages.Where(p => p.MessageID == MessageID).ToList<Message>();
                //    foreach (var item in Mess)
                //    {
                //        item.Active = "N";
                //        item.VisitDate = DateTime.Now;
                //        item.EntityState = DominModel.EntityState.Modified;
                //    }
                //    objBLMessageRepository.UpdateMessage(Mess.ToArray());
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public static int GetModuleidByPageName(string StrPage)
        {
            int res = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var PageModuleID = context.ModulePages.Where(p => p.Page == StrPage).FirstOrDefault();
                //    if (PageModuleID != null)
                //    {
                //        res = PageModuleID.ModuleID.GetValueOrDefault();
                //    }
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public void SendNotifications(int ProjectID, int FromUserID, int ToUserID, string NotificationMessage, string RedirectURL, string MessageFor, string MessageType)
        {
            try
            {

                //BLMessageRepository blMsg = new BLMessageRepository();
                //Message BEobjMessage = new Message();
                //BEobjMessage.MessageID = 0;
                //BEobjMessage.FromUserID = Convert.ToString(FromUserID);
                //BEobjMessage.ToUserID = Convert.ToString(ToUserID);
                //BEobjMessage.Message1 = NotificationMessage;
                //BEobjMessage.RedirectURL = RedirectURL;
                //BEobjMessage.MessageFor = MessageFor;
                //BEobjMessage.QueryString = "ProjectID=" + ProjectID;
                //BEobjMessage.Active = "Y";
                //BEobjMessage.MessageType = MessageType;
                //BEobjMessage.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //BEobjMessage.EntityState = DominModel.EntityState.Added;
                //blMsg.AddMessage(BEobjMessage);

            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }

        }
        public void UpdateDeActiveMyAllMessage(String ToUserID, String messageType)
        {
            try
            {
                int Userid = Convert.ToInt32(ToUserID);
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List<Message> lstMessage = new List<Message>();
                //    lstMessage = context.Messages.Where(p => p.ToUserID == ToUserID && p.MessageType == messageType && p.Active == "Y").ToList<Message>();
                //    foreach (var Mess in lstMessage)
                //    {
                //        Mess.Active = "N";
                //        Mess.VisitDate = DateTime.Now;
                //        Mess.EntityState = DominModel.EntityState.Modified;
                //    }

                //    UpdateMessage(lstMessage.ToArray<Message>());
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public static IList<videoTutorial> GetVedioLink(string PageUrl, string strGuidType)
        {
            IList<videoTutorial> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = (from a in context.videoTutorials where a.ModuleLink == PageUrl && a.GuidType == strGuidType select a).OrderBy(p => p.videoLinkUrl).ToList();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static Int32 GetModuleIDByPage(string PageUrl)
        {

            int ModuleID = 0;
            IList<Module> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = (from a in context.Modules where a.URL == PageUrl select a).ToList();
                //    ModuleID = list.Single().ModuleID;
                //}

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var PageModuleID = context.Modules.Where(p => p.URL == PageUrl).FirstOrDefault();
                //    if (PageModuleID != null)
                //    {
                //        ModuleID = PageModuleID.ModuleID;
                //        HttpContext.Current.Session["ModuleName"] = PageModuleID.ModuleName;
                //    }
                //}

            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return ModuleID;
        }

        public IList<NotifiMessage> GetTopNotiMessag(Int32 iUserID, int toprecords)
        {
            IList<NotifiMessage> list = null;
            try
            {
                list = new List<NotifiMessage>();
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string iuser = Convert.ToString(iUserID);
                //    var val = (from u in context.Users.ToList()
                //               join m in context.Messages on
                //                u.UserID.ToString() equals m.FromUserID
                //               where m.MessageType == "N" && m.ToUserID == iuser.ToString() && !m.FromUserID.Contains("@")
                //               select new
                //               {
                //                   FullName = u.FirstName + " " + u.LastName,
                //                   ImagePath = u.ImagePath,
                //                   m.MessageID,
                //                   m.FromUserID,
                //                   m.ToUserID,
                //                   Content = m.Message1,
                //                   m.RedirectURL,
                //                   m.QueryString,
                //                   m.MessageFor,
                //                   m.Active,
                //                   m.MessageType,
                //                   m.Date,
                //                   m.VisitDate
                //               }).OrderByDescending(p => p.Date).Take(toprecords);

                //    foreach (var a in val)
                //    {

                //        NotifiMessage n = new NotifiMessage();
                //        n.FullName = a.FullName;
                //        n.ImagePath = a.ImagePath;
                //        n.MessageID = a.MessageID;
                //        n.FromUserID = a.FromUserID;
                //        n.ToUserID = a.ToUserID;
                //        n.Content = a.Content;
                //        n.RedirectURL = a.RedirectURL;
                //        n.QueryString = a.QueryString;
                //        n.MessageFor = a.MessageFor;
                //        n.Active = a.Active;
                //        n.MessageType = a.MessageType;
                //        n.Date = a.Date;
                //        n.VisitDate = a.VisitDate.GetValueOrDefault();
                //        list.Add(n);
                //    }

                //    var Cval = (from m in context.Messages.Where(m1 => m1.ToUserID == iuser)
                //                where m.FromUserID.Contains("@")
                //                select new
                //                {
                //                    FullName = m.ToUserID,
                //                    ImagePath = "",
                //                    m.MessageID,
                //                    m.FromUserID,
                //                    m.ToUserID,
                //                    Content = m.Message1,
                //                    m.RedirectURL,
                //                    m.QueryString,
                //                    m.MessageFor,
                //                    m.Active,
                //                    m.MessageType,
                //                    m.Date,
                //                    m.VisitDate
                //                }).OrderByDescending(p => p.Date).Take(toprecords);




                //    foreach (var a in Cval)
                //    {
                //        NotifiMessage n = new NotifiMessage();
                //        n.FullName = a.FullName;
                //        n.ImagePath = a.ImagePath;
                //        n.MessageID = a.MessageID;
                //        n.FromUserID = a.FromUserID;
                //        n.ToUserID = a.ToUserID;
                //        n.Content = a.Content;
                //        n.RedirectURL = a.RedirectURL;
                //        n.QueryString = a.QueryString;
                //        n.MessageFor = a.MessageFor;
                //        n.Active = a.Active;
                //        n.MessageType = a.MessageType;
                //        n.Date = a.Date;
                //        n.VisitDate = a.VisitDate.GetValueOrDefault();
                //        list.Add(n);
                //    }

                //}
                //list = list.OrderByDescending(c => c.Date).ToList<NotifiMessage>();
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public IList<NotifiMessage> GetTopMessage(Int32 iUserID, int toprecords)
        {
            IList<NotifiMessage> list = null;
            try
            {
                list = new List<NotifiMessage>();
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string iuser = Convert.ToString(iUserID);
                //    var val = (from u in context.Users.ToList()
                //               join m in context.Messages on
                //                  u.UserID.ToString() equals m.FromUserID
                //               where m.MessageType == "A" && m.ToUserID == iuser.ToString() && !m.FromUserID.Contains("@")

                //               select new
                //               {
                //                   FullName = u.FirstName + " " + u.LastName,
                //                   ImagePath = u.ImagePath,
                //                   m.MessageID,
                //                   m.FromUserID,
                //                   m.ToUserID,
                //                   Content = m.Message1,
                //                   m.RedirectURL,
                //                   m.QueryString,
                //                   m.MessageFor,
                //                   m.Active,
                //                   m.MessageType,
                //                   m.Date,
                //                   m.VisitDate
                //               }).OrderByDescending(p => p.Date).Take(toprecords);


                //    var cval = (from m in context.Messages.Where(m1 => m1.ToUserID == iuser)
                //                where m.FromUserID.Contains("@")

                //                select new
                //                {
                //                    FullName = m.ToUserID,
                //                    ImagePath = "",
                //                    m.MessageID,
                //                    m.FromUserID,
                //                    m.ToUserID,
                //                    Content = m.Message1,
                //                    m.RedirectURL,
                //                    m.QueryString,
                //                    m.MessageFor,
                //                    m.Active,
                //                    m.MessageType,
                //                    m.Date,
                //                    m.VisitDate
                //                }).OrderByDescending(p => p.Date).Take(toprecords);

                //    foreach (var a in val)
                //    {
                //        NotifiMessage n = new NotifiMessage();
                //        n.FullName = a.FullName;
                //        n.ImagePath = a.ImagePath;
                //        n.MessageID = a.MessageID;
                //        n.FromUserID = a.FromUserID;
                //        n.ToUserID = a.ToUserID;
                //        n.Content = a.Content;
                //        n.RedirectURL = a.RedirectURL;
                //        n.QueryString = a.QueryString;
                //        n.MessageFor = a.MessageFor;
                //        n.Active = a.Active;
                //        n.MessageType = a.MessageType;
                //        n.Date = a.Date;
                //        n.VisitDate = a.VisitDate.GetValueOrDefault();
                //        list.Add(n);
                //    }
                //    foreach (var a in cval)
                //    {
                //        NotifiMessage n = new NotifiMessage();
                //        n.FullName = a.ToUserID;
                //        n.ImagePath = "";
                //        n.MessageID = a.MessageID;
                //        n.FromUserID = a.FromUserID;
                //        n.ToUserID = a.ToUserID;
                //        n.Content = a.Content;
                //        n.RedirectURL = a.RedirectURL;
                //        n.QueryString = a.QueryString;
                //        n.MessageFor = a.MessageFor;
                //        n.Active = a.Active;
                //        n.MessageType = a.MessageType;
                //        n.Date = a.Date;
                //        n.VisitDate = a.VisitDate.GetValueOrDefault();
                //        list.Add(n);
                //    }

                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }
        public static IList<User_Message> GetMessage(int UserID, String strMessageTYpe)
        {
            IList<User_Message> list = new List<User_Message>();
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = (from u in db.Users.ToList()
                //               join m in db.Messages on
                //             u.UserID.ToString() equals m.FromUserID
                //               where m.ToUserID == UserID.ToString() && m.Active == "Y" && m.MessageType == strMessageTYpe && !m.FromUserID.Contains("@")
                //               select new
                //               {
                //                   m.MessageID,
                //                   FullName = u.FirstName + " " + u.LastName,
                //                   ImagePath = u.ImagePath,
                //                   m.FromUserID,
                //                   m.ToUserID,
                //                   m.RedirectURL,
                //                   m.Message1,
                //                   m.QueryString,
                //                   m.MessageFor,
                //                   m.Active,
                //                   m.MessageType,
                //                   m.Date,
                //                   m.VisitDate,
                //                   m.IsProgressAlert
                //               }).OrderByDescending(p => p.Date);
                //    //kkj

                //    var strUseID = UserID.ToString();
                //    var cval = (from m in db.Messages
                //                where m.ToUserID == strUseID && m.Active == "Y" && m.MessageType == strMessageTYpe && m.FromUserID.Contains("@")
                //                select new
                //                {
                //                    m.MessageID,
                //                    FullName = m.ToUserID,
                //                    ImagePath = "",
                //                    m.FromUserID,
                //                    m.ToUserID,
                //                    m.RedirectURL,
                //                    m.Message1,
                //                    m.QueryString,
                //                    m.MessageFor,
                //                    m.Active,
                //                    m.MessageType,
                //                    m.Date,
                //                    m.VisitDate,
                //                    m.IsProgressAlert
                //                }).OrderByDescending(p => p.Date);


                //    foreach (var a in val)
                //    {
                //        User_Message u = new User_Message();
                //        u.Active = a.Active;
                //        u.Date = a.Date;
                //        u.FromUserID = a.FromUserID;
                //        u.FullName = a.FullName;
                //        u.ImagePath = a.ImagePath;
                //        u.Message = a.Message1;
                //        u.MessageFor = a.MessageFor;
                //        u.MessageID = a.MessageID;
                //        u.MessageType = a.MessageType;
                //        u.RedirectURL = a.RedirectURL;
                //        u.QueryString = a.QueryString;
                //        u.ToUserID = a.ToUserID;
                //        u.VisitDate = a.VisitDate;
                //        u.IsProgressAlert = a.IsProgressAlert;
                //        list.Add(u);
                //    }

                //    foreach (var a in cval)
                //    {
                //        User_Message u = new User_Message();
                //        u.Active = a.Active;
                //        u.Date = a.Date;
                //        u.FromUserID = a.FromUserID;
                //        u.FullName = a.FullName;
                //        u.ImagePath = a.ImagePath;
                //        u.Message = a.Message1;
                //        u.MessageFor = a.MessageFor;
                //        u.MessageID = a.MessageID;
                //        u.MessageType = a.MessageType;
                //        u.RedirectURL = a.RedirectURL;
                //        u.QueryString = a.QueryString;
                //        u.ToUserID = a.ToUserID;
                //        u.VisitDate = a.VisitDate;
                //        u.IsProgressAlert = a.IsProgressAlert;
                //        list.Add(u);
                //    }


                //}
                //list = list.OrderByDescending(c => c.Date).ToList<User_Message>();
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public void SendNotificationToSelectedRolesAtSpecificWorkFlowStatge(int FileID, int TaskId, string DocStage)
        {
            //"#OriginatorName# has responded to your comments on #FileName# of deliverable - #DeliverableName#.";
            //BLUploadDeliverableFile objblupload = new BLUploadDeliverableFile();
            //UploadDeliverableFile upfile = new UploadDeliverableFile();
            //BLProjectMilestoneRepository objblprogress = new BLProjectMilestoneRepository();
            //ProjectTaskList delDet = objblupload.GetDeliverableListByFileID(FileID);
            //BLRevisionFile objblrevision = new BLRevisionFile();
            //ProjectMilestone ProgressLevel = new ProjectMilestone();
            //BLMessageRepository blMessage = new BLMessageRepository();
            //upfile = objblupload.GetUploadDeliverableFileByID(FileID);
            //RevisionFile Revisionfile = new RevisionFile();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    Revisionfile = context.RevisionFiles.Where(a => a.RevisionID == upfile.RevisionID).FirstOrDefault();
            //}

            //int MileStoneId = 0;
            //if (upfile.MilestoneID > 0)
            //{
            //    MileStoneId = (int)upfile.MilestoneID;
            //}
            //else
            //{
            //    MileStoneId = (int)Revisionfile.StatusID;
            //}

            //BLDocStageRepository bldocstage = new BLDocStageRepository();
            ////Get Selected Roles for sending notification
            //BLProgressLevelNotificationRepository blrole = new BLProgressLevelNotificationRepository();
            //List<List<string>> SelectedRoles = blrole.GetRolesByMilestonesIDandDocstageId(MileStoneId, bldocstage.GetDocstageIdbyDocStage(DocStage));
            //List<string> exusers = new List<string>();
            //List<string> inusers = new List<string>();
            //if (SelectedRoles[0] != null)
            //{
            //    foreach (var items in SelectedRoles[0])
            //    {
            //        if (items == "Recipient" && DocStage != "Upload")
            //        {
            //            //get all recipient of this file
            //            BLFileCheckerRepository blfilechecker = new BLFileCheckerRepository();
            //            List<FileChecker> Recipient = new List<FileChecker>();
            //            Recipient = blfilechecker.GetFileCheckerByFileID(FileID);
            //            foreach (var data in Recipient)
            //            {
            //                if (data.UserID.Contains("@"))
            //                {
            //                    exusers.Add(data.UserID);
            //                }
            //                else
            //                    inusers.Add(data.UserID);
            //            }
            //        }
            //        if (items == "Stakeholders" && DocStage != "Send")
            //        {
            //            //get stakeholders for milestone
            //            List<string> lst = new List<string>();
            //            List<string> lstsakteholder = new List<string>();
            //            BLMilestoneStakeholder blstake = new BLMilestoneStakeholder();
            //            lstsakteholder = blstake.GetAllStakeHolderByMilestoneIDStageNotify(MileStoneId, TaskId);
            //            foreach (var item in lstsakteholder)
            //            {
            //                if (item.Contains("@"))
            //                {
            //                    exusers.Add(item);
            //                }
            //                else
            //                    inusers.Add(item);
            //            }
            //        }
            //        if (items == "Owner")
            //        {
            //            //get task owner
            //            int? Taskowner = objblupload.GetDeliverableListByFileID(FileID).TaskOwner;
            //            inusers.Add(Convert.ToString(Taskowner));
            //        }
            //    }
            //}

            //if (SelectedRoles[1] != null)
            //{
            //    inusers = inusers.Union(SelectedRoles[1]).ToList();
            //}
            //if (SelectedRoles[2] != null)
            //{
            //    exusers = exusers.Union(SelectedRoles[2]).ToList();
            //}


            ////Send Notification to internal users
            //foreach (var users in inusers)
            //{
            //    Message lstM = new Message();
            //    lstM.FromUserID = Convert.ToString(HttpContext.Current.Session["UserID"]);
            //    lstM.ToUserID = Convert.ToString(users);
            //    if (DocStage == "Upload")
            //    {
            //        lstM.Message1 = Common.MessageConstants.Deliverable_is_uploaded.Replace("#OriginatorName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#DeliverableName#", delDet.TaskName);
            //        if (upfile.FileExtention.Contains(".pdf"))
            //        {
            //            lstM.RedirectURL = "pdfjs/viewer.html";
            //            lstM.QueryString = "FileID=" + Convert.ToInt32(FileID) + "&&Flter=1&&UserID=" + Convert.ToString(users) + "&&Dwgpdffileid=0";
            //        }
            //        else
            //        {
            //            lstM.RedirectURL = "UploadDeliverables.aspx";
            //            int DelID = BLUploadDeliverableFile.getDeliverableListIdByFileID(Convert.ToInt32(FileID));
            //            lstM.QueryString = "DeliverableID=" + Convert.ToString(DelID) + "&Page=PV&FileID=" + Convert.ToString(FileID);
            //        }
            //        lstM.MessageFor = "UploadDeliverables";
            //    }
            //    else if (DocStage == "Send")
            //    {
            //        lstM.Message1 = Common.MessageConstants.Deliverable_is_sent_for_comments_noti.Replace("#OriginatorName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#DeliverableName#", delDet.TaskName);
            //        if (upfile.FileExtention.Contains(".pdf"))
            //        {
            //            lstM.RedirectURL = "pdfjs/viewer.html";
            //            lstM.QueryString = "FileID=" + Convert.ToInt32(FileID) + "&&Flter=1&&UserID=" + Convert.ToString(users) + "&&Dwgpdffileid=0";
            //        }

            //        else
            //        {
            //            lstM.RedirectURL = "UploadDeliverables.aspx";
            //            int DelID = BLUploadDeliverableFile.getDeliverableListIdByFileID(Convert.ToInt32(FileID));
            //            lstM.QueryString = "DeliverableID=" + Convert.ToString(DelID) + "&Page=PV&FileID=" + Convert.ToString(FileID);
            //        }
            //        lstM.MessageFor = "UploadDeliverables";
            //    }
            //    else if (DocStage == "Comment")
            //    {
            //        lstM.Message1 = ("#CheckerName# has sent a commented and marked-up file for #DeliverableName#.").Replace("#CheckerName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#DeliverableName#", delDet.TaskName);
            //        lstM.RedirectURL = "CommentResolution.aspx";
            //        lstM.MessageFor = "CommentResolution";
            //        lstM.QueryString = "FILEID=" + FileID;
            //    }
            //    else if (DocStage == "Response")
            //    {
            //        lstM.Message1 = Common.MessageConstants.Send_response_to_the_comments_noti.Replace("#OriginatorName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#FileName#", upfile.FileName.ToString()).Replace("#DeliverableName#", delDet.TaskName);
            //        lstM.RedirectURL = "CommentResolutionApprove.aspx";
            //        lstM.QueryString = "FileID=" + Convert.ToInt32(FileID);
            //        lstM.MessageFor = "CommentResolutionApprove";

            //    }
            //    else if (DocStage == "Approve")
            //    {
            //        lstM.Message1 = Common.MessageConstants.All_the_comments_from_All_the_checkers_are_approved.Replace("#DeliverableName#", delDet.TaskName);
            //        lstM.RedirectURL = "CommentResolution.aspx";
            //        lstM.QueryString = "FILEID=" + Convert.ToString(FileID);
            //        lstM.MessageFor = "All Approved";
            //    }
            //    lstM.Active = "Y";
            //    lstM.MessageType = "N";
            //    lstM.Date = DateTime.Now;
            //    lstM.CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //    lstM.EntityState = DominModel.EntityState.Added;
            //    blMessage.AddMessage(lstM);
            //}


            ////Send Notification to external users
            //foreach (var users in exusers)
            //{
            //    BLMessageTemplateRepository blmt = new BLMessageTemplateRepository();

            //    string FromUserID = Convert.ToString(HttpContext.Current.Session["UserID"]);
            //    string ToUserID = Convert.ToString(users);
            //    if (DocStage == "Upload")
            //    {
            //        string Message1 = Common.MessageConstants.Deliverable_is_uploaded.Replace("#OriginatorName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#DeliverableName#", delDet.TaskName);
            //        blmt.SendNotification(FromUserID, Message1, ToUserID);
            //    }
            //    else if (DocStage == "Send")
            //    {
            //        string Message1 = Common.MessageConstants.Deliverable_is_sent_for_comments_noti.Replace("#OriginatorName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#DeliverableName#", delDet.TaskName);
            //        blmt.SendNotification(FromUserID, Message1, ToUserID);
            //    }
            //    else if (DocStage == "Comment")
            //    {
            //        string Message1 = ("#CheckerName# has sent a commented and marked-up file for #DeliverableName#.").Replace("#CheckerName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#DeliverableName#", delDet.TaskName);
            //        blmt.SendNotification(FromUserID, Message1, ToUserID);
            //    }
            //    else if (DocStage == "Response")
            //    {
            //        string Message1 = Common.MessageConstants.Send_response_to_the_comments_noti.Replace("#OriginatorName#", Convert.ToString(HttpContext.Current.Session["UserName"])).Replace("#FileName#", upfile.FileName.ToString()).Replace("#DeliverableName#", delDet.TaskName);
            //        blmt.SendNotification(FromUserID, Message1, ToUserID);

            //    }
            //    else if (DocStage == "Approve")
            //    {
            //        string Message1 = Common.MessageConstants.All_the_comments_from_All_the_checkers_are_approved.Replace("#DeliverableName#", delDet.TaskName);
            //        blmt.SendNotification(FromUserID, Message1, ToUserID);
            //    }                
            //}
        }
    }

    public class firebase
    {
        private const string Authsectert = "1234";
        private const string BasePath = "https://workpack.firebaseio.com/";
        //private readonly IFirebaseConfig config;
        //BLUserRepository blu = new BLUserRepository();
        public firebase()
        {
            try
            {
               // config = new FirebaseConfig
                   //{
                   //    //AuthSecret = Authsectert,
                   //    BasePath = BasePath
                   //};

            }
            catch (Exception ex) { }
        }






        public void addfirebase(params Message[] message)
        {
            try
            {
                //foreach (Message m in message)
                //{
                //    User u = blu.GetuserByID(Convert.ToInt32(m.ToUserID));
                //    IFirebaseClient client = new FirebaseClient(config);

                //    Dictionary<string, string> values = new Dictionary<string, string>();
                //    String timeStamp = "msg_" + GetTimestamp(DateTime.Now);
                //    values.Add(timeStamp, m.Message1);
                //    if (u != null)
                //    {
                //        if (u.FirebaseID != null)
                //        {
                //            var response = client.Update(u.FirebaseID, values);
                //        }
                //    }
                //}

                //return;

            }
            catch (Exception ex) { }
        }



        private string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

    }
}
