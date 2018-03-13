using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDeliverablemessageRepository : IBLDeliverablemessageRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<DeliverableMessage> _deliverablemessageRepository;

        public BLDeliverablemessageRepository(WorkpackDBContext context, IGenericDataRepository<DeliverableMessage> deliverablemessageRepository)
        {
            _context = context;
            _deliverablemessageRepository = deliverablemessageRepository;
        }

        public IList<DeliverableMessage> GetAllDeliverablemessages()
        {
            return _deliverablemessageRepository.GetAll().ToList<DeliverableMessage>(); 
        }


        public DeliverableMessage GetAllDeliverablemessages(int Fileid,string userid)
        {
            //ICollection<DeliverableMessage> lstdel = null;
            //using (var context = new Cubicle_EntityEntities()) {



            DeliverableMessage lst = null; //context.DeliverableMessages.Where(a => a.RecipentID == userid && a.Uploaddeliberablefileid == Fileid).OrderByDescending(a => a.DeliverableMessageID).FirstOrDefault();

                return lst;
            //}

            
        }

        public List<object> GetAllDeliverablemessages(int Fileid)
        {
            //ICollection<DeliverableMessage> lstdel = null;
            //using (var context = new Cubicle_EntityEntities())
            //{

            //    return _deliverablemessageRepository.GetAll().Where(a=>a.Uploaddeliberablefileid==Fileid).Select(a=> new {
            //    a.DeliverableMessageID,
            //    a.Uploaddeliberablefileid,
            //    CreatedOn = a.CreatedOn.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
            //    a.Message,
            //   SendTo = BLUserRepository.GetUserNameById(Convert.ToString(a.RecipentID))

            //    }).ToList<object>();


            //}

            List<object> lst = null;
            return lst;


        } 
        public DeliverableMessage GetDeliverablemessageByID(Int32 DeliverablemessageID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _deliverablemessageRepository.GetSingle(d => d.DeliverableMessageID == DeliverablemessageID);                
                //include related employees
        }        
        public void AddDeliverablemessage(params DeliverableMessage[] Deliverablemessage)
        {
            /* Validation and error handling omitted */
            try
            {
                _deliverablemessageRepository.Add(Deliverablemessage);
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
    
        public void UpdateDeliverablemessage(params DeliverableMessage[] Deliverablemessage)
        {
            /* Validation and error handling omitted */
            try
            {
                _deliverablemessageRepository.Update(Deliverablemessage);
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
        public void RemoveDeliverablemessage(params DeliverableMessage[] Deliverablemessage)
        {
            /* Validation and error handling omitted */
            try
            {
                _deliverablemessageRepository.Remove(Deliverablemessage);
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
     
    }


    

    
}
