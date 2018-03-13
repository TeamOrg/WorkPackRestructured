using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLBufferFieldRepository
    {
        string AddBufferDropDownData(int bufferfieldid, string ItemName, string ItemCode);
        void AddBufferField(params BufferField[] BufferField);
        string DeleteBufferDropDownData(int bufferfieldid, int ItemID);
        List<BufferField> GetAllBufferField();
        List<object> GetBufferDropDownData(int bufferfieldid);
        List<object> GetBufferField();
        BufferField GetBufferFieldByID(int Id);
        void RemoveBufferField(params BufferField[] BufferField);
        bool SetBufferFiledActiveInactive(int bufferfieldid, string Status);
        string UpdateBufferDropDownData(int bufferfieldid, int ItemID, string ItemName, string ItemCode);
        void UpdateBufferField(params BufferField[] BufferField);
    }
}