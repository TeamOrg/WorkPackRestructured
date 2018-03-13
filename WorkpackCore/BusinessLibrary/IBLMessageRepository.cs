using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMessageRepository
    {
        void AddMessage(params Message[] message);
        IList<Message> GetAllMessages();
        Message GetMessageByID(int messageID);
        IList<NotifiMessage> GetTopMessage(int iUserID, int toprecords);
        IList<NotifiMessage> GetTopNotiMessag(int iUserID, int toprecords);
        void RemoveMessage(params Message[] skill);
        void SendNotifications(int ProjectID, int FromUserID, int ToUserID, string NotificationMessage, string RedirectURL, string MessageFor, string MessageType);
        void SendNotificationToSelectedRolesAtSpecificWorkFlowStatge(int FileID, int TaskId, string DocStage);
        void UpdateDeActiveMyAllMessage(string ToUserID, string messageType);
        void UpdateMessage(params Message[] Message);
    }
}