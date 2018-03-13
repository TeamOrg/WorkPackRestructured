using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLClientFocalPointRepository : IBLClientFocalPointRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ClientFocalPoint> _clientFPRepository;

        public BLClientFocalPointRepository(WorkpackDBContext context, IGenericDataRepository<ClientFocalPoint> clientFPRepository)
        {
            _context = context;
            _clientFPRepository = clientFPRepository;
        }
        public IList<ClientFocalPoint> GetAllClientFocalPoints()
        {
            return _clientFPRepository.GetAll();
        }
        public ClientFocalPoint GetClientFocalPointByID(Int32 clientFPID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _clientFPRepository.GetSingle(d => d.ClientFocalPointID == clientFPID);                
                //include related employees
        }
        public void AddClientFocalPoint(params ClientFocalPoint[] clientFP)
        {
            /* Validation and error handling omitted */
            try
            {
                _clientFPRepository.Add(clientFP);
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
        public void UpdateClientFocalPoint(params ClientFocalPoint[] clientFP)
        {
            /* Validation and error handling omitted */
            try
            {
                _clientFPRepository.Update(clientFP);
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
        public void RemoveClientFocalPoint(params ClientFocalPoint[] clientFP)
        {
            /* Validation and error handling omitted */
            try
            {
                _clientFPRepository.Remove(clientFP);
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
        public Boolean CheckDuplicate(ClientFocalPoint clientFP, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _clientFPRepository.GetSingle(p => p.ClientFocalPointName.ToUpper() == clientFP.ClientFocalPointName.ToUpper() && p.ClientFocalPointCode.ToUpper() == clientFP.ClientFocalPointCode.ToUpper() && p.ClientID == clientFP.ClientID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.ClientFocalPointID == clientFP.ClientFocalPointID)
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
        public IList<Client_FocalPoint> GetClientFocalPointList(ClientFocalPoint clientFP)
        {
            IList<Client_FocalPoint> list = null ;
            try
            {
                //using (PMEntities context = new PMEntities("name=PMEntities"))
                //{
                //    var items = context.Knowledge_Project_Members.Include("Knowledge_Project").Include("Profile_Information")
                //                .Where(p => p.Knowledge_Project.Guid == ProjectGuid)
                //                .Select(row => new UserDetail { IdMember = row.IdMember, UserName = row.Profile_Information.UserName });

                //    return items.ToList();
                //}
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    IQueryable<Client_FocalPoint> query = db.ClientFocalPoints.Include("Clients").Select(p => new Client_FocalPoint { ClientID = p.ClientID, ClientName = p.Client.Clientname, FocalPointID = p.ClientFocalPointID, FocalPointCode = p.ClientFocalPointCode, FocalPointName = p.ClientFocalPointName });
                //    if (clientFP.ClientFocalPointName != string.Empty)
                //        query = query.Where(p => p.FocalPointName.ToUpper().Contains(clientFP.ClientFocalPointName.ToUpper()));
                //    if (clientFP.ClientFocalPointCode != string.Empty)
                //        query = query.Where(p => p.FocalPointCode.ToUpper().Contains(clientFP.ClientFocalPointCode.ToUpper()));
                //    if (clientFP.ClientID != 0)
                //        query = query.Where(p => p.ClientID == clientFP.ClientID);

                //    list = query.ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        //public IList<Client_ClientFocalPoint_View> GetClientFocalPointList(ClientFocalPoint clientFP)
        //{
        //    IList<Client_ClientFocalPoint_View> fetchedClient = new List<Client_ClientFocalPoint_View>();
        //    try
        //    {
        //        using (var Context = new Cubicle_EntityEntities())
        //        {
        //            IQueryable<Client_ClientFocalPoint_View> query = Context.Client_ClientFocalPoint_View;
        //            if (clientFP.ClientFocalPointName != string.Empty)
        //                query = query.Where(p => p.ClientFocalPointName.ToUpper().Contains(clientFP.ClientFocalPointName.ToUpper()));
        //            if (clientFP.ClientFocalPointCode != string.Empty)
        //                query = query.Where(p => p.ClientFocalPointCode.ToUpper().Contains(clientFP.ClientFocalPointCode.ToUpper()));
        //            if (clientFP.ClientID != 0)
        //                query = query.Where(p => p.ClientID == clientFP.ClientID);
        //            fetchedClient = query.ToList();
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
        //    return fetchedClient;
        //}
    }
    
}
