using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLPageComment_imagesRepository
    {
        void AddPageComment_images(params PageComment_images[] PageComment_images);
        bool CheckDuplicate(PageComment_images PageComment_images, bool IsInsert);
        IList<PageComment_images> GetAllPageComment_imagess();
        IList<PageComment_images> GetPageComment_imagesbycommentdetailsid(int commentdetailsid);
        PageComment_images GetPageComment_imagesByID(int PageComment_imagesID);
        int GetPageComment_imagesByName(string PageComment_imagesName);
        void RemovePageComment_images(params PageComment_images[] PageComment_images);
        void UpdatePageComment_images(params PageComment_images[] PageComment_images);
    }
}