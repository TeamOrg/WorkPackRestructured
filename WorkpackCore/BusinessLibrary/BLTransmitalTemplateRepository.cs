using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Net.Http;

namespace BusinessLibrary
{
    public  class BLTransmitalTemplateRepository : IBLTransmitalTemplateRepository
    {

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TransmitalTemplate> _transmitalTemplateRepository;

        public BLTransmitalTemplateRepository(WorkpackDBContext context, IGenericDataRepository<TransmitalTemplate> transmitalTemplateRepository)
        {
            _context = context;
            _transmitalTemplateRepository = transmitalTemplateRepository;
        }





        public IList<TransmitalTemplate> GetAllTransmitalTemplates()
        {
           IList<TransmitalTemplate> lst = new List<TransmitalTemplate>();
            return lst;
            //int companyId = Convert.ToInt32(HttpContent.Current.Session["CompanyId"]);
            //return _transmitalTemplateRepository.GetAll().Where(a => a.Companyid == companyId).ToList();
        }
        public TransmitalTemplate GetTransmitalTemplateByID(Int32 TransmitalTemplateID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _transmitalTemplateRepository.GetSingle(d => d.TransmitalTemplateID == TransmitalTemplateID);
            //include related employees
        }
        public void AddTransmitalTemplate(params TransmitalTemplate[] TransmitalTemplate)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmitalTemplateRepository.Add(TransmitalTemplate);
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
        public void UpdateTransmitalTemplate(params TransmitalTemplate[] TransmitalTemplate)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmitalTemplateRepository.Update(TransmitalTemplate);
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
        public void RemoveTransmitalTemplate(params TransmitalTemplate[] TransmitalTemplate)
        {
            /* Validation and error handling omitted */
            try
            {
                _transmitalTemplateRepository.Remove(TransmitalTemplate);
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

        public Boolean tranmitaltemplateused(int transmitatemplateid)
        {
            int count = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //     count = context.Transmittals.Where(a => a.TransmitalTemplateID == transmitatemplateid).Count();
               
            //}
            if (count > 0)
                return false;
            else return true;
        }
        public Boolean CheckDuplicate(TransmitalTemplate TransmitalTemplate, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _transmitalTemplateRepository.GetSingle(p => p.TransmitalTemplateName.ToUpper() == TransmitalTemplate.TransmitalTemplateName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.TransmitalTemplateID == TransmitalTemplate.TransmitalTemplateID)
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
        public IList<TransmitalTemplate> GetTransmitalTemplateList(TransmitalTemplate TransmitalTemplate)
        {
            IList<TransmitalTemplate> fetchedClient = new List<TransmitalTemplate>();
            try
            {
                ////using (var Context = new Cubicle_EntityEntities())
                ////{
                ////   IEnumerable<TransmitalTemplate> query = GetAllTransmitalTemplates();
                ////    if (TransmitalTemplate.TransmitalTemplateName != string.Empty)
                ////        query = query.Where(p => p.TransmitalTemplateName.ToUpper().Contains(TransmitalTemplate.TransmitalTemplateName.ToUpper()));
                ////    //if (TransmitalTemplate.Status != "Y")
                ////    //    query = query.Where(p => p.Status.ToUpper() == TransmitalTemplate.Status.ToUpper());
                ////    fetchedClient = query.ToList();
                ////}
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

        public TransmitalTemplate LoadTransmitalTemplateBySubject(string Subject)
        {
            return _transmitalTemplateRepository.GetSingle(p => p.TransmitalTemplateName == Subject);
        }


    }
}
