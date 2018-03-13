using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLClientAssetRepository : IBLClientAssetRepository
    {         

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ClientAsset> _clientAssetRepository;

        public BLClientAssetRepository(WorkpackDBContext context, IGenericDataRepository<ClientAsset> clientAssetRepository)
        {
            _context = context;
            _clientAssetRepository = clientAssetRepository;
        }
        public IList<ClientAsset> GetAllClientAssets()
        {
            return _clientAssetRepository.GetAll();
        }
        public ClientAsset GetClientAssetByID(Int32 clientAssetID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _clientAssetRepository.GetSingle(d => d.ClientAssetID == clientAssetID);                
                //include related employees
        }
        public void AddClientAsset(params ClientAsset[] clientAsset)
        {
            /* Validation and error handling omitted */
            _clientAssetRepository.Add(clientAsset);
        }
        public void UpdateClientAsset(params ClientAsset[] clientAsset)
        {
            /* Validation and error handling omitted */
            _clientAssetRepository.Update(clientAsset);
        }
        public void RemoveClientAsset(params ClientAsset[] clientAsset)
        {
            /* Validation and error handling omitted */
            try
            {
                _clientAssetRepository.Remove(clientAsset);
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
        public Boolean CheckDuplicate(ClientAsset clientAsset, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _clientAssetRepository.GetSingle(p => p.ClientAssetName.ToUpper() == clientAsset.ClientAssetName.ToUpper() && p.ClientAssetCode.ToUpper() == clientAsset.ClientAssetCode.ToUpper() && p.ClientID == clientAsset.ClientID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.ClientAssetID == clientAsset.ClientAssetID)
                        Result = true;
                    else
                        Result = false;
                }
                else
                {
                    if (c == null)
                        Result = true;
                    else
                        Result = false;
                }
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return Result;
        }
        public IList<usp_getClientAsset_Result> GetClientAssetList(ClientAsset clientAsset)
        {
            IList<usp_getClientAsset_Result> fetchedClient = new List<usp_getClientAsset_Result>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<usp_getClientAsset_Result> query = Context.usp_getClientAsset(0).AsQueryable<usp_getClientAsset_Result>();
                //    if (clientAsset.ClientAssetName != string.Empty)
                //        query = query.Where(p => p.ClientAssetName.ToUpper().Contains(clientAsset.ClientAssetName.ToUpper()));
                //    if (clientAsset.ClientAssetCode != string.Empty)
                //        query = query.Where(p => p.ClientAssetCode.ToUpper().Contains(clientAsset.ClientAssetCode.ToUpper()));
                //    if (clientAsset.ClientID != 0)
                //        query = query.Where(p => p.ClientID == clientAsset.ClientID);
                //    fetchedClient = query.ToList();
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
            return fetchedClient;
        }
        public IList<ClientAsset> GetClientAssetsByClientID(int ClientID)
        {
            IList<ClientAsset> list = new List<ClientAsset>();
            try
            {
                list = _clientAssetRepository.GetList(p => p.ClientID == ClientID);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public static IList<ClientAsset> GetClientAssetsByDepartment(int Dept)
        {
            IList<ClientAsset> list = null;

            //using (var db = new Cubicle_EntityEntities())
            //{
            //    list = (from c in db.ClientAssets
            //            join
            //                p in db.Projects on c.ClientAssetID equals p.ClientAssetID
            //            join
            //                pt in db.ProjectTaskLists on p.ProjectID equals pt.ProjectID
            //            where pt.DepatmentID == Dept
            //            select c).Distinct().ToList();
            //}
            return list;
        }
       
    }
}
