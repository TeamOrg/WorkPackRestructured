using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDocumentFiltersRepository : IBLDocumentFiltersRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<DocumentFilter> _documentFiltersRepository;

        public BLDocumentFiltersRepository(WorkpackDBContext context, IGenericDataRepository<DocumentFilter> documentFiltersRepository)
        {
            _context = context;
            _documentFiltersRepository = documentFiltersRepository;
        }
        public IList<DocumentFilter> GetAllDocumentFilter()
        {
            return _documentFiltersRepository.GetAll();
        }

        public DocumentFilter GetDocumentFilterByID(Int32 documentFiltersRepositoryID)
        {
            return _documentFiltersRepository.GetSingle(d => d.DocumentFiltersID == documentFiltersRepositoryID);
        }

        public void AddDocumentFilters(params DocumentFilter[] documentFiltersRepository)
        {
            try
            {
                _documentFiltersRepository.Add(documentFiltersRepository);
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
        public void UpdateDocumentFilters(params DocumentFilter[] documentFiltersRepository)
        {
            try
            {
                _documentFiltersRepository.Update(documentFiltersRepository);
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
        public void RemoveDocumentFilters(params DocumentFilter[] documentFiltersRepository)
        {
            try
            {
                _documentFiltersRepository.Remove(documentFiltersRepository);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int addDocFilterIds(string projectID, string DocFilterIds, string Action)
        {
            string[] arr = DocFilterIds.Split(',');
            DocumentFilter doc = new DocumentFilter();
            doc.ProjectID = Convert.ToInt32(projectID);
            doc.CanComment = Convert.ToBoolean(Action);
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    string[] val = arr[i].Split('-');
                    if (val.Length > 1)
                    {
                        if (val[0] == "Department")
                        {
                            doc.DepartmentID = Convert.ToInt32(val[1]);
                        }
                        else if (val[0] == "TaskType")
                        {
                            doc.TaskTypeID = Convert.ToInt32(val[1]);
                        }
                        else if (val[0] == "Priority")
                        {
                            doc.PriorityID = Convert.ToInt32(val[1]);
                        }
                        else if (val[0] == "Milestone")
                        {
                            doc.MilestoneID = Convert.ToInt32(val[1]);
                        }
                        else if (val[0] == "Revision")
                        {
                            doc.RevisionID = Convert.ToInt32(val[1]);
                        }
                    }
                }

                doc.EntityState = EntityState.Added;
                AddDocumentFilters(doc);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return doc.DocumentFiltersID;
        }



        public List<usp_getDistributionMatrixByProjectId_Result> getDistributionMatrix(string projectID)
        {
            List<usp_getDistributionMatrixByProjectId_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int prId = Convert.ToInt32(projectID);
            //   

            //    lst = context.usp_getDistributionMatrixByProjectId(prId).ToList<usp_getDistributionMatrixByProjectId_Result>();

            //    return lst;
            //}
            return lst;
        }

        public bool deleteDistributionMatrix(string DocumentFiltersID)
        {

            //using (var ts = new TransactionScope())
            //{
            //    int prId = Convert.ToInt32(DocumentFiltersID);
            //    try
            //    {
            //        BLRecipientFiltersRepository blRec = new BLRecipientFiltersRepository();
            //        BLIndividualRecipientsRepository blInd = new BLIndividualRecipientsRepository();

            //        DocumentFilter lstDoc = GetDocumentFilterByID(prId);
            //        lstDoc.EntityState = EntityState.Deleted;

            //        List<RecipientFilter> lstRec = blRec.GetRecipientFilterByDocFilterId(prId);

            //        List<IndividualRecipient> lstInd = blInd.GetIndividualRecipientByDocFilterId(prId);

            //        blRec.RemoveRecipientFilters(lstRec.ToArray());
            //        blInd.RemoveIndividualRecipients(lstInd.ToArray());
            //        RemoveDocumentFilters(lstDoc);

            //        ts.Complete();
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        throw ex;
            //    }

            //}

            return true;

        }

        public List<usp_getUserByDistributionMatrixByTaskId_Result> getUserByDistributionMatrixByTaskId(int DeliverableId, int MilestoneId, int RevisionId)
        {

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int prId = Convert.ToInt32(DeliverableId);
            //    List<usp_getUserByDistributionMatrixByTaskId_Result> lst = null;

            //    lst = context.usp_getUserByDistributionMatrixByTaskId(prId, MilestoneId, RevisionId).ToList<usp_getUserByDistributionMatrixByTaskId_Result>();

            //    return lst;
            //}
            List<usp_getUserByDistributionMatrixByTaskId_Result> lst = null;
            return lst;
        }
    }
}
