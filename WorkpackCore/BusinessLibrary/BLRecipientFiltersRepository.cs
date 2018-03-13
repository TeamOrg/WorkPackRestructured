using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLRecipientFiltersRepository : IBLRecipientFiltersRepository
    {

        


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<RecipientFilter> _recipientFiltersRepository;

        public BLRecipientFiltersRepository(WorkpackDBContext context, IGenericDataRepository<RecipientFilter> recipientFiltersRepository)
        {
            _context = context;
            _recipientFiltersRepository = recipientFiltersRepository;
        }







        public IList<RecipientFilter> GetAllRecipientFilter()
        {
            return _recipientFiltersRepository.GetAll();
        }

        public RecipientFilter GetRecipientFilterByID(Int32 RecipientFiltersRepositoryID)
        {
            return _recipientFiltersRepository.GetSingle(d => d.RecipientFiltersID == RecipientFiltersRepositoryID);
        }

        public void AddRecipientFilterts(params RecipientFilter[] RecipientFiltersRepository)
        {
            try
            {
                _recipientFiltersRepository.Add(RecipientFiltersRepository);
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
        public void UpdateRecipientFilters(params RecipientFilter[] RecipientFiltersRepository)
        {
            try
            {
                _recipientFiltersRepository.Update(RecipientFiltersRepository);
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
        public void RemoveRecipientFilters(params RecipientFilter[] RecipientFiltersRepository)
        {
            try
            {
                _recipientFiltersRepository.Remove(RecipientFiltersRepository);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void addRecipientIds(string RecipientIds, int DocumentFiltersID)
        {
            try
            {
                string[] arr = RecipientIds.Split(',');
                RecipientFilter rec = new RecipientFilter();
                rec.DocumentFiltersID = DocumentFiltersID;
                for (int i = 0; i < arr.Length; i++)
                {
                    string[] val = arr[i].Split('-');
                    if (val.Length > 1)
                    {
                        if (val[0] == "Department")
                        {
                            rec.DepartmentID = Convert.ToInt32(val[1]);
                        }
                        else if (val[0] == "Designation")
                        {
                            rec.DesignationID = Convert.ToInt32(val[1]);
                        }
                        else if (val[0] == "Role")
                        {
                            rec.RoleID = Convert.ToInt32(val[1]);
                        }
                    }
                }

                rec.EntityState = DomainModelLibrary.EntityState.Added;
                AddRecipientFilterts(rec);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<RecipientFilter> GetRecipientFilterByDocFilterId(int prId)
        {
            List<RecipientFilter> lstRec = null;
            return lstRec;


            //using (var context = new Cubicle_EntityEntities())
            //{
            //    List<RecipientFilter> lstRec = context.RecipientFilters.Where(a => a.DocumentFiltersID == prId).ToList<RecipientFilter>();
            //    lstRec = lstRec.Select(a => { a.EntityState = DominModel.EntityState.Deleted; return a; }).ToList<RecipientFilter>();
            //    return lstRec;
            //}
        }
    }
}
