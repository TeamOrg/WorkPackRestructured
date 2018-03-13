using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNormsMappingRepository : IBLNormsMappingRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NormsMapping> _NormsMappingRepository;

        public BLNormsMappingRepository(WorkpackDBContext context, IGenericDataRepository<NormsMapping> NormsMappingRepository)
        {
            _context = context;
            _NormsMappingRepository = NormsMappingRepository;
        }
        public IList<NormsMapping> GetAllNormsMapping()
        {
            return _NormsMappingRepository.GetAll();
        }
        public NormsMapping GetNormsMappingByID(Int32 NormsMappingID)
        {
            return _NormsMappingRepository.GetSingle(d => d.NormsMappingID == NormsMappingID);
        }
        public void AddNormsMapping(params NormsMapping[] NormsMapping)
        {
            try
            {
                _NormsMappingRepository.Add(NormsMapping);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateNormsMapping(params NormsMapping[] NormsMapping)
        {
            try
            {
                _NormsMappingRepository.Update(NormsMapping);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveNormsMapping(params NormsMapping[] NormsMapping)
        {
            try
            {
                _NormsMappingRepository.Remove(NormsMapping);
            }
            catch (Exception ex)
            {
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }

        public NormsMapping GetNormsMappingByNormIdAndContractNormSetID(int NormID, int contactNormSetID)
        {
            NormsMapping res = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    res = Context.NormsMappings.Where(a => a.CompanyNormID == NormID && a.ContractNormSetID == contactNormSetID).SingleOrDefault();
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
            return res;
        }

        public List<usp_getAllContractNormDetailByCompanyNormSetID_Result> getAllContractNormDetailByCompanyNormSetID(int NormSetID)
        {
            List<usp_getAllContractNormDetailByCompanyNormSetID_Result> lst = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    lst = Context.usp_getAllContractNormDetailByCompanyNormSetID(NormSetID).ToList<usp_getAllContractNormDetailByCompanyNormSetID_Result>();
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

        public List<NormSet> getContractNormSetByCompNormID(int NormSetID)
        {
            List<NormSet> lstObj = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<int> lst = null;
                //    lst = (from q in Context.NormsMappings where q.CompanyNormSetID == NormSetID select q.ContractNormSetID).Distinct();
                //    lstObj = (from q in Context.NormSets where lst.Contains(q.NormSetID) select q).ToList<NormSet>();
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
            return lstObj;
        }
    }
}
