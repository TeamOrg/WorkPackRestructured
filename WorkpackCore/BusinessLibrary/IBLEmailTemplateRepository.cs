using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLEmailTemplateRepository
    {
        void AddEmailTemplate(params EmailTemplate[] emailTemplate);
        bool CheckDuplicate(EmailTemplate emailTemplate, bool IsInsert);
        IList<EmailTemplate> GetAllEmailTemplates();
        EmailTemplate GetEmailTemplateByID(int emailTemplateID);
        IList<EmailTemplate> GetEmailTemplateList(EmailTemplate emailTemplate);
        EmailTemplate LoadEmailTemplateBySubject(string Subject);
        EmailTemplate LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate etDesc);
        void RemoveEmailTemplate(params EmailTemplate[] emailTemplate);
        void UpdateEmailTemplate(params EmailTemplate[] emailTemplate);
    }
}