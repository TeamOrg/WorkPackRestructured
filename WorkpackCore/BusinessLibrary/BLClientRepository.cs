using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLClientRepository : IBLClientRepository
    {
       
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Client> _clientRepository;

        public BLClientRepository(WorkpackDBContext context, IGenericDataRepository<Client> clientRepository)
        {
            _context = context;
            _clientRepository = clientRepository;
        }
        public IList<Client> GetAllClients()
        {
            //if (HttpContext.Current.Session["CompanyId"] != null)
            //    return _clientRepository.GetAll().Where(c => c.CompanyId == Convert.ToInt32(HttpContext.Current.Session["CompanyId"])).ToList<Client>();
            //else
            //    return _clientRepository.GetAll().ToList<Client>();

            IList<Client> list = null;
            return list;

        }
        public Client GetClientByID(Int32 clientID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _clientRepository.GetSingle(d => d.ClientID == clientID);
            //include related employees
        }
        public void AddClient(params Client[] client)
        {
            /* Validation and error handling omitted */
            try
            {
                _clientRepository.Add(client);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public List<object> GetAllClientsContracts()
        {
            List<object> ClientContract = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    ClientContract = (from c in Context.ClientContracts
                //                      join cl in Context.Clients on c.ClientID equals cl.ClientID
                //                      join con in Context.ContractMasters
                //                      on c.ContractID equals con.ContractID
                //                      select new
                //                      {
                //                          ClientID = c.ContractMappingID,
                //                          ClientCode = cl.Clientname + " - " + con.ContractCode
                //                      }).ToList<object>();
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
            return ClientContract;
        }

        public List<object> GetAllClientsContractsByClientID(int ClientID)
        {
            List<object> ClientContract = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    ClientContract = (from c in Context.ClientContracts
                //                      join cl in Context.Clients on c.ClientID equals cl.ClientID
                //                      join con in Context.ContractMasters
                //                      on c.ContractID equals con.ContractID
                //                      where c.ClientID == ClientID
                //                      select new
                //                      {
                //                          ClientContractID = c.ContractMappingID,
                //                          ClientContractCode = con.ContractCode
                //                      }).ToList<object>();
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
            return ClientContract;
        }
        public void UpdateClient(params Client[] client)
        {
            /* Validation and error handling omitted */
            try
            {
                _clientRepository.Update(client);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveClient(params Client[] client)
        {
            /* Validation and error handling omitted */
            try
            {
                _clientRepository.Remove(client);
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
        public Boolean CheckDuplicate(Client client, Boolean IsInsert)
        {
            Boolean Result = true;
            int companyID = 0;// Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            try
            {
                var c = _clientRepository.GetSingle(p => p.ClientCode.ToUpper() == client.ClientCode.ToUpper() && p.Clientname.ToUpper() == client.Clientname.ToUpper() && p.CompanyId == companyID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.ClientID == client.ClientID)
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
        public IList<Client> GetClientList(Client client)
        {
            IList<Client> fetchedClient = new List<Client>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<Client> query = Context.Clients;
                //    if (client.Clientname != string.Empty)
                //        query = query.Where(p => p.Clientname.ToUpper().Contains(client.Clientname.ToUpper()));
                //    if (client.ClientCode != string.Empty)
                //        query = query.Where(p => p.ClientCode.ToUpper().Contains(client.ClientCode.ToUpper()));
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
    }
}
