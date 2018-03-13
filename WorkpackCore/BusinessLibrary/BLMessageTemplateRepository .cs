using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMessageTemplateRepository : IBLMessageTemplateRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MessageTemplate> _MessageTemplate;

        public BLMessageTemplateRepository(WorkpackDBContext context, IGenericDataRepository<MessageTemplate> MessageTemplate)
        {
            _context = context;
            _MessageTemplate = MessageTemplate;
        }


        public IList<MessageTemplate> GetAllMessageTemplate()
        {
            return _MessageTemplate.GetAll();
        }

        public MessageTemplate GetMessageTemplateByID(int MessageTemplateID)
        {
            return _MessageTemplate.GetSingle(d => d.MessageTemplateID == MessageTemplateID);
        }

        public MessageTemplate GetMessageTemplateByMessage(string message)
        {
            MessageTemplate lst = new MessageTemplate();

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    lst = context.MessageTemplates.Where(a => a.Message.Trim().Contains(message.Trim())).FirstOrDefault();
            //}

            return lst;
        }
        public void AddMessageTemplate(params MessageTemplate[] MessageTemplate)
        {
            try
            {
                _MessageTemplate.Add(MessageTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateMessageTemplate(params MessageTemplate[] MessageTemplate)
        {
            try
            {
                _MessageTemplate.Update(MessageTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }



        public bool SendNotification(dynamic UID, string sendmessage, dynamic touserid)
        {
            try
            {

                bool status = false;
                //string UserID = Convert.ToString(UID);
                //string ToUserID = Convert.ToString(touserid);
                //string EmailTo = "";
                //string Link = "";
                //if (UserID.Contains('@'))
                //{

                //    BLUserRepository blUser = new BLUserRepository();
                //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
                //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
                //    BLConfigFileRepository configFile = new BLConfigFileRepository();
                //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
                //    ExUser dtAdminData = blUser.GetExuserByeEmailID(Convert.ToString(UserID));
                //    if (ToUserID.Contains('@'))
                //    {
                //        EmailTo = ToUserID;
                //        Link = "<br> <a href='http://service.workpack.in/login/Registration.aspx' target='_blank'>Click here to register on Workpack</a>";
                //    }
                //    else
                //    {
                //        User touser = blUser.GetuserByID(touserid);
                //        EmailTo = Convert.ToString(touser.EmailID1.Trim());
                //        Link = "<br> <a href='http://service.workpack.in/login/Default.aspx' target='_blank'>Click here to login to Workpack</a>";
                //    }
                //    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.AllCommentsApprovedForClientEmail);
                //    //String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));
                //    String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
                //    String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
                //    MailAddress mailID = new MailAddress(EmailTo);
                //    message.To.Add(mailID);
                //    message.Subject = "WorkPack Notification";
                //    message.Body = sendmessage + Link;
                //    status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);

                //}
                //else
                //{
                //    BLUserRepository blUser = new BLUserRepository();
                //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                //    BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
                //    EmailTemplate objBEEmailTemplate = new EmailTemplate();
                //    BLConfigFileRepository configFile = new BLConfigFileRepository();
                //    ConfigFile dtEmailConfig = configFile.GetConfigFileByID(1);
                //    User dtAdminData = blUser.GetuserByID(Convert.ToInt32(UserID));
                //    if (ToUserID.Contains('@'))
                //    {
                //        EmailTo = ToUserID;
                //        Link = "<br> <a href='http://service.workpack.in/login/Registration.aspx' target='_blank'>Click here to register on Workpack</a>";
                //    }
                //    else
                //    {
                //        User touser = blUser.GetuserByID(touserid);
                //        EmailTo = Convert.ToString(touser.EmailID1.Trim());
                //        Link = "<br> <a href='http://service.workpack.in/login/Default.aspx' target='_blank'>Click here to login to Workpack</a>";
                //    }
                //    objBEEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.AllCommentsApprovedForClientEmail);
                //    //String emailSubject = objBEEmailTemplate.EmailTemplateSubject.Replace("#ProjectName#", project.ProjectName).Replace("#DeliverableNumber#", Convert.ToString(DeliverabelDetails.TaskNo));
                //    String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
                //    String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
                //    MailAddress mailID = new MailAddress(EmailTo);
                //    message.To.Add(mailID);
                //    message.Subject = "WorkPack Notification";
                //    message.Body = sendmessage + Link;
                //    status = Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);

                //}


                return status;

            }

            catch (Exception ex)
            {
                return false;
            }
        }




        public void RemoveMessageTemplate(params MessageTemplate[] MessageTemplate)
        {
            try
            {
                _MessageTemplate.Remove(MessageTemplate);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
        public IList<MessageTemplate> GetMessageTemplateList(MessageTemplate MessageTemplate)
        {
            IList<MessageTemplate> fetchedClient = new List<MessageTemplate>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<MessageTemplate> query = Context.MessageTemplates;
                //    if (MessageTemplate.Message != string.Empty)
                //        query = query.Where(p => p.Message.ToUpper().Contains(MessageTemplate.Message.ToUpper()));
                //    if (MessageTemplate.FromUser != string.Empty)
                //        query = query.Where(p => p.FromUser.ToUpper().Contains(MessageTemplate.FromUser.ToUpper()));
                //    if (MessageTemplate.ToUser != string.Empty)
                //        query = query.Where(p => p.ToUser.ToUpper().Contains(MessageTemplate.ToUser.ToUpper()));
                //    fetchedClient = query.ToList();
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
            return fetchedClient;
        }


    }
}
