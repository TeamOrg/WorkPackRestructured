using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLAttachTransmitalFilesRepository
    {
        void AddAttachTransmitalFiles(params AttachTransmitalFile[] attachFiles);
        IList<AttachTransmitalFile> GetAll();
        IList<AttachTransmitalFile> GetAttachTransmitalFiels(int FileId, int UserId);
        List<object> GetAttachTransmitalFielsByTransmittalID(int TransmittalId);
        AttachTransmitalFile GetAttachTransmitalFilesByID(int AttachFileID);
        void RemoveAttachTransmitalFiles(params AttachTransmitalFile[] attachFiles);
        IList<object> ShowAttachTransmitalFiels(int FileId, int UserId);
        void UpdateAttachTransmitalFiles(params AttachTransmitalFile[] attachFiles);
    }
}