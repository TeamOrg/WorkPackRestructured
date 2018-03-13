using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMaterialColumn
    {
        void AddMaterial(params MaterialdetailsColumn[] attachmentFile);
        IList<MaterialdetailsColumn> GetProfile();
        void RemoveMaterial(params MaterialdetailsColumn[] attachmentFile);
        bool RemoveMaterialByID(int PKID);
        void UpdateMaterial(params MaterialdetailsColumn[] attachmentFile);
    }
}