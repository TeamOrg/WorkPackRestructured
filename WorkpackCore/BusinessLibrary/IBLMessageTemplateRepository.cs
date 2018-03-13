using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMessageTemplateRepository
    {
        void AddMessageTemplate(params MessageTemplate[] MessageTemplate);
        IList<MessageTemplate> GetAllMessageTemplate();
        MessageTemplate GetMessageTemplateByID(int MessageTemplateID);
        MessageTemplate GetMessageTemplateByMessage(string message);
        IList<MessageTemplate> GetMessageTemplateList(MessageTemplate MessageTemplate);
        void RemoveMessageTemplate(params MessageTemplate[] MessageTemplate);
        bool SendNotification(dynamic UID, string sendmessage, dynamic touserid);
        void UpdateMessageTemplate(params MessageTemplate[] MessageTemplate);
    }
}