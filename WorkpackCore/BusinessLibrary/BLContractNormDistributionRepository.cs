using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLContractNormDistributionRepository : IBLContractNormDistributionRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ContractNormDistribution> _contractNormDistributionRepository;

        public BLContractNormDistributionRepository(WorkpackDBContext context, IGenericDataRepository<ContractNormDistribution> contractNormDistributionRepository)
        {
            _context = context;
            _contractNormDistributionRepository = contractNormDistributionRepository;
        }
        public IList<ContractNormDistribution> GetAllContractNormDistributions()
        {
            return _contractNormDistributionRepository.GetAll();
        } 
        public ContractNormDistribution GetContractNormDistributionByID(Int32 ContractNormDistributionID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _contractNormDistributionRepository.GetSingle(d => d.ContractDistrID == ContractNormDistributionID);                
                //include related employees
        }        
        public void AddContractNormDistribution(params ContractNormDistribution[] ContractNormDistribution)
        {
            try
            {
                _contractNormDistributionRepository.Add(ContractNormDistribution);
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
        public void UpdateContractNormDistribution(params ContractNormDistribution[] ContractNormDistribution)
        {
            try
            {
                _contractNormDistributionRepository.Update(ContractNormDistribution);
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
        public void RemoveContractNormDistribution(params ContractNormDistribution[] ContractNormDistribution)
        {
            try
            {
                _contractNormDistributionRepository.Remove(ContractNormDistribution);
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

        public List<usp_GetContractNormsDistribution_Result> GetContractNormsDistribution()
        {
            List<usp_GetContractNormsDistribution_Result> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_GetContractNormsDistribution().ToList<usp_GetContractNormsDistribution_Result>();
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
    }
}
