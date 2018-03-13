using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProfile : IBLProfile
    {

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<CompanyProfile> _profile;

        public BLProfile(WorkpackDBContext context, IGenericDataRepository<CompanyProfile> profile)
        {
            _context = context;
            _profile = profile;
        }

        public int GetProfileIDByCode(string ProfileCode)
        {
            int ProfileID = 0;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    CompanyProfile obj = _profile.GetSingle(p => p.ProfileCode.ToUpper() == ProfileCode.ToUpper());
            //    if (obj != null)
            //    {
            //        ProfileID = obj.ProfileID;
            //    }
            //    return ProfileID;
            //}
            return ProfileID;
        }
        public IList<CompanyProfile> GetProfile()
        {
            return _profile.GetAll();
        }
        public CompanyProfile GetByProfileID(int ProfileId)
        {
            return _profile.GetSingle(d => d.ProfileID == ProfileId);
        }
        public List<CompanyProfile> GetProfileByFileID(int DelFileID)
        {
            List<CompanyProfile> lst = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    lst = Context.Profiles.Where(a => a.ProfileID == DelFileID).ToList<CompanyProfile>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return lst;
        }
        public void AddProfile(params CompanyProfile[] attachmentFile)
        {
            try
            {
                _profile.Add(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProfile(params CompanyProfile[] attachmentFile)
        {
            try
            {
                _profile.Update(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveProfile(params CompanyProfile[] attachmentFile)
        {
            try
            {
                _profile.Remove(attachmentFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }
    }
}
