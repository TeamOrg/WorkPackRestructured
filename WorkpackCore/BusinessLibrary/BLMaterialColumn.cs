using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMaterialColumn : IBLMaterialColumn
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MaterialdetailsColumn> _Material;

        public BLMaterialColumn(WorkpackDBContext context, IGenericDataRepository<MaterialdetailsColumn> Material)
        {
            _context = context;
            _Material = Material;
        }

        public IList<MaterialdetailsColumn> GetProfile()
        {
            return _Material.GetAll();
        }
        //public Profile GetByProfileID(int ProfileId)
        //{
        //    return _Material.GetSingle(d => d.ProfileID == ProfileId);
        //}
        //public List<MaterialdetailsColumn> GetProfileByFileID(int DelFileID)
        //{
        //    List<MaterialdetailsColumn> lst = null;
        //    try
        //    {
        //        using (var Context = new Cubicle_EntityEntities())
        //        {
        //            lst = Context.Profiles.Where(a => a.ProfileID == DelFileID).ToList<Profile>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
        //        if (false)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return lst;
        //}
        public void AddMaterial(params MaterialdetailsColumn[] attachmentFile)
        {
            try
            {
                _Material.Add(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateMaterial(params MaterialdetailsColumn[] attachmentFile)
        {
            try
            {
                _Material.Update(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveMaterial(params MaterialdetailsColumn[] attachmentFile)
        {
            try
            {
                _Material.Remove(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
        public bool RemoveMaterialByID(int PKID)
        {
            bool status = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        try
            //        {
            //            var x = context.MaterialdetailsColumns.Where(a => a.MaterialdetailsColID == PKID);
            //            foreach (var item in x)
            //            {

            //                context.MaterialdetailsColumns.Remove(item);
            //                context.SaveChanges();

            //                //int count = context.MaterialdetailsColumns.Where(a => a.EstimationTaskColumnID == item.EstimationTaskColumnID).Count();
            //                //if (count == 0)
            //                //{
            //                //    EstimationTaskColumnsMaster obj = context.EstimationTaskColumnsMasters.Where(a => a.EstimationTaskColumnID == item.EstimationTaskColumnID).FirstOrDefault();
            //                //    obj.AllowDelete = "Y";
            //                //    obj.EntityState = EntityState.Modified;
            //                //    BLEstimationTaskColumnsMasterRepository blObj = new BLEstimationTaskColumnsMasterRepository();
            //                //    blObj.UpdateEstimationTaskColumnsMasters(obj);
            //                //}

            //                status = true;
            //                ts.Complete();
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            ts.Dispose();
            //            status = false; ;
            //            //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //            throw new Exception("Record not deleted.");

            //        }
            //        return status;
            //    }
            //}
            return status;
        }
    }
}
