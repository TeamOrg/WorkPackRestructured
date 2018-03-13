using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLEmailTemplateRepository : IBLEmailTemplateRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<EmailTemplate> _emailTemplateRepository;

        public BLEmailTemplateRepository(WorkpackDBContext context, IGenericDataRepository<EmailTemplate> emailTemplateRepository)
        {
            _context = context;
            _emailTemplateRepository = emailTemplateRepository;
        }


        public IList<EmailTemplate> GetAllEmailTemplates()
        {
            return _emailTemplateRepository.GetAll();
        }
        public EmailTemplate GetEmailTemplateByID(Int32 emailTemplateID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _emailTemplateRepository.GetSingle(d => d.EmailTemplateID == emailTemplateID);
            //include related employees
        }
        public void AddEmailTemplate(params EmailTemplate[] emailTemplate)
        {
            /* Validation and error handling omitted */
            try
            {
                _emailTemplateRepository.Add(emailTemplate);
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
        public void UpdateEmailTemplate(params EmailTemplate[] emailTemplate)
        {
            /* Validation and error handling omitted */
            try
            {
                _emailTemplateRepository.Update(emailTemplate);
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
        public void RemoveEmailTemplate(params EmailTemplate[] emailTemplate)
        {
            /* Validation and error handling omitted */
            try
            {
                _emailTemplateRepository.Remove(emailTemplate);
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
        public Boolean CheckDuplicate(EmailTemplate emailTemplate, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //var c = _emailTemplateRepository.GetSingle(p => p.EmailTemplateSubject.ToUpper() == emailTemplate.EmailTemplateSubject.ToUpper() && p.CompanyID == companyId);
                //if (!IsInsert)
                //{
                //    if (c == null)
                //        Result = true;
                //    else if (c.EmailTemplateID == emailTemplate.EmailTemplateID)
                //        Result = true;
                //    else
                //        Result = false;
                //}
                //else
                //{
                //    if (c == null)
                //        Result = true;
                //    else
                //        Result = false;
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
            return Result;
        }
        public IList<EmailTemplate> GetEmailTemplateList(EmailTemplate emailTemplate)
        {
            IList<EmailTemplate> fetchedClient = new List<EmailTemplate>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //    IQueryable<EmailTemplate> query = Context.EmailTemplates.Include("User");
                //    query = query.Where(a => (string.IsNullOrEmpty(a.DisplayInGrid) ? "" : a.DisplayInGrid) != "N" && a.CompanyID == companyId);
                //    if (emailTemplate.EmailTemplateSubject != string.Empty)
                //        query = query.Where(p => p.EmailTemplateSubject.ToUpper().Contains(emailTemplate.EmailTemplateSubject.ToUpper()));
                //    if (emailTemplate.Status != "0")
                //        query = query.Where(p => p.Status.ToUpper() == emailTemplate.Status.ToUpper());
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

        public EmailTemplate LoadEmailTemplateBySubject(string Subject)
        {
            int companyId = 0; //Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            return _emailTemplateRepository.GetSingle(p => p.EmailTemplateSubject == Subject && p.CompanyID == companyId);
        }

        public EmailTemplate LoadEmailTemplateDesc(enu_EmailTemplate etDesc)
        {
            int companyId = 0;//Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            return _emailTemplateRepository.GetSingle(p => p.EmailTemplateDesc == GetEmailTemplateDesc(etDesc) && p.CompanyID == companyId);
        }
        
        private static string GetEmailTemplateDesc(enu_EmailTemplate etDesc)
        {
            switch (etDesc)
            {
                case enu_EmailTemplate.NewUserCreated:
                    return "New User Created";
                case enu_EmailTemplate.ForgotPassword:
                    return "Forgot Password";
                case enu_EmailTemplate.ChangePassword:
                    return "Change Password";
                case enu_EmailTemplate.PasswordReset:
                    return "Password Reset";
                case enu_EmailTemplate.DeliverableReview:
                    return "Deliverable Review";
                case enu_EmailTemplate.DeliverableViewing:
                    return "Deliverable Viewing";
                case enu_EmailTemplate.DeliverableApproval:
                    return "Deliverable Approve";
                case enu_EmailTemplate.AllCommentsApprovedForClientEmail:
                    return "All Comments Approved For Client Email";
                case enu_EmailTemplate.DeliverableReminder:
                    return "Deliverable Reminder";
                case enu_EmailTemplate.Transmittal:
                    return "Transmittal";
                case enu_EmailTemplate.WorkPackInvitation:
                    return "WorkPack Invitation Template";
                case enu_EmailTemplate.WorkPackColleaguesInvitation:
                    return "WorkPack Colleagues Invitation Template";
                case enu_EmailTemplate.WorkPackRegisterUser:
                    return "Welcome to WorkPack Template";
                case enu_EmailTemplate.UserInformation:
                    return "User Information Template";
                case enu_EmailTemplate.ProjectManager:
                    return "Project Manager Template";
                case enu_EmailTemplate.DocumentOwner:
                    return "Document Owner Template";
                case enu_EmailTemplate.TeamMember:
                    return "Team Member Template";
                case enu_EmailTemplate.NewTeamMemberRegistration:
                    return "Reg Team Member Template";
                case enu_EmailTemplate.ApprovalReqSentToAdmin:
                    return "Reg Sent For Approval";
                case enu_EmailTemplate.ApprovalReqAccepted:
                    return "Reg Appr Request Accepted";
                case enu_EmailTemplate.ApprovalReqDeclined:
                    return "Reg Appr Request Declined";
                case enu_EmailTemplate.SMTPTESTMAIL:
                    return "SMTP TEST MAIL";
                case enu_EmailTemplate.StakeHolderNotification:
                    return "StakeHolderNotification";
                case enu_EmailTemplate.DeliverableViewingExternal:
                    return "Deliverable Viewing External";
                case enu_EmailTemplate.StakeHolderNotificationFromExternal:
                    return "StakeHolderNotificationFromExternal";
                case enu_EmailTemplate.DeliverableApproved:
                    return "Deliverable Approved";

                   
                default: return "";
            }
        }
        public enum enu_EmailTemplate
        {
            NewUserCreated = 1,
            ForgotPassword = 2,
            ChangePassword = 3,
            PasswordReset = 4,
            DeliverableReview = 5,
            DeliverableViewing = 6,
            DeliverableApproval = 7,
            AllCommentsApprovedForClientEmail = 8,
            DeliverableReminder = 9,
            Transmittal=10,
            WorkPackInvitation = 11,
            WorkPackColleaguesInvitation = 12,
            WorkPackRegisterUser = 13,
            UserInformation = 14,
            ProjectManager = 15,
            DocumentOwner = 16,
            TeamMember = 17,
            NewTeamMemberRegistration = 18,
            ApprovalReqSentToAdmin = 19,
            ApprovalReqAccepted = 20,
            ApprovalReqDeclined = 21,
            SMTPTESTMAIL=22,
            StakeHolderNotification = 23,
            DeliverableViewingExternal = 24,
            StakeHolderNotificationFromExternal = 25,
            DeliverableApproved = 26,
        }  
    }
  
}

