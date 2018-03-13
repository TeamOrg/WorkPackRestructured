using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTransmitalTemplateRepository
    {
        void AddTransmitalTemplate(params TransmitalTemplate[] TransmitalTemplate);
        bool CheckDuplicate(TransmitalTemplate TransmitalTemplate, bool IsInsert);
        IList<TransmitalTemplate> GetAllTransmitalTemplates();
        TransmitalTemplate GetTransmitalTemplateByID(int TransmitalTemplateID);
        IList<TransmitalTemplate> GetTransmitalTemplateList(TransmitalTemplate TransmitalTemplate);
        TransmitalTemplate LoadTransmitalTemplateBySubject(string Subject);
        void RemoveTransmitalTemplate(params TransmitalTemplate[] TransmitalTemplate);
        bool tranmitaltemplateused(int transmitatemplateid);
        void UpdateTransmitalTemplate(params TransmitalTemplate[] TransmitalTemplate);
    }
}