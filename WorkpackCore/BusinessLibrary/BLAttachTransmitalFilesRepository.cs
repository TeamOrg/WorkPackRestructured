using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLAttachTransmitalFilesRepository : IBLAttachTransmitalFilesRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<AttachTransmitalFile> _attachTransmitalFilesRepository;

        public BLAttachTransmitalFilesRepository(WorkpackDBContext context, IGenericDataRepository<AttachTransmitalFile> attachTransmitalFilesRepository)
        {
            _context = context;
            _attachTransmitalFilesRepository = attachTransmitalFilesRepository;
        }
        public IList<AttachTransmitalFile> GetAll()
        {
            return _attachTransmitalFilesRepository.GetAll();
        }
        public AttachTransmitalFile GetAttachTransmitalFilesByID(Int32 AttachFileID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _attachTransmitalFilesRepository.GetSingle(d => d.AttachFileID == AttachFileID);
            //include related employees
        }
        public void AddAttachTransmitalFiles(params AttachTransmitalFile[] attachFiles)
        {
            /* Validation and error handling omitted */
            try
            {
                _attachTransmitalFilesRepository.Add(attachFiles);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public void UpdateAttachTransmitalFiles(params AttachTransmitalFile[] attachFiles)
        {
            /* Validation and error handling omitted */
            try
            {
                _attachTransmitalFilesRepository.Update(attachFiles);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
           
        }
        public void RemoveAttachTransmitalFiles(params AttachTransmitalFile[] attachFiles)
        {
            /* Validation and error handling omitted */
            try
            {
                _attachTransmitalFilesRepository.Remove(attachFiles);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }
        public IList<AttachTransmitalFile> GetAttachTransmitalFiels(int FileId, int UserId)
        {
            IList<AttachTransmitalFile>list=null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from f in db.AttachTransmitalFiles where f.FileID == FileId && f.UserID == UserId select f).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public IList<object> ShowAttachTransmitalFiels(int FileId, int UserId)
        {
            IList<object> list = null;
            try
            {
                int i = 0;
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from f in db.AttachTransmitalFiles
                //            where f.FileID == FileId && f.UserID == UserId
                //            select new { i=i+1, id = f.AttachFileID, AttachFileName = f.AttachFileName, AttachFilePath = f.AttachFilePath }).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public List<object> GetAttachTransmitalFielsByTransmittalID(int TransmittalId)
        {
            List<object> list = null;
            try
            {
                int i = 0;
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from q in db.AttachTransmitalFiles where q.TransmittalId==TransmittalId select q).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
    }
}
