using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLIndividualRecipientsRepository : IBLIndividualRecipientsRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<IndividualRecipient> _individualRecipientssRepository;

        public BLIndividualRecipientsRepository(WorkpackDBContext context, IGenericDataRepository<IndividualRecipient> individualRecipientssRepository)
        {
            _context = context;
            _individualRecipientssRepository = individualRecipientssRepository;
        }
        public IList<IndividualRecipient> GetAllIndividualRecipient()
        {
            return _individualRecipientssRepository.GetAll();
        }

        public IndividualRecipient GetIndividualRecipientByID(Int32 IndividualRecipientsRepositoryID)
        {
            return _individualRecipientssRepository.GetSingle(d => d.IndividualRecipientsID == IndividualRecipientsRepositoryID);
        }

        public void AddIndividualRecipientts(params IndividualRecipient[] IndividualRecipientsRepository)
        {
            try
            {
                _individualRecipientssRepository.Add(IndividualRecipientsRepository);
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
        public void UpdateIndividualRecipients(params IndividualRecipient[] IndividualRecipientsRepository)
        {
            try
            {
                _individualRecipientssRepository.Update(IndividualRecipientsRepository);
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
        public void RemoveIndividualRecipients(params IndividualRecipient[] IndividualRecipientsRepository)
        {
            try
            {
                _individualRecipientssRepository.Remove(IndividualRecipientsRepository);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void addIndividualIds(string IndividualIds, int DocumentFiltersID)
        {
            try
            {
                string[] arr = IndividualIds.Split(',');
                List<IndividualRecipient> lstInd = new List<IndividualRecipient>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Convert.ToInt32(arr[i]) > 0)
                    {
                        IndividualRecipient ind = new IndividualRecipient();
                        ind.DocumentFiltersID = DocumentFiltersID;
                        ind.UserID = Convert.ToInt32(arr[i]);
                        ind.EntityState = EntityState.Added;
                        lstInd.Add(ind);
                    }
                }

                AddIndividualRecipientts(lstInd.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IndividualRecipient> GetIndividualRecipientByDocFilterId(int prId)
        {
            List<IndividualRecipient> lstInd = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    List<IndividualRecipient> lstInd = context.IndividualRecipients.Where(a => a.DocumentFiltersID == prId).ToList<IndividualRecipient>();
            //    lstInd = lstInd.Select(a => { a.EntityState = DominModel.EntityState.Deleted; return a; }).ToList<IndividualRecipient>();
            //    return lstInd;
            //}
            return lstInd;
        }
    }
}
