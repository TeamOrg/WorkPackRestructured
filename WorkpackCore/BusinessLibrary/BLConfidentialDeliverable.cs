using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLConfidentialDeliverable : IBLConfidentialDeliverable
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Confidential> _confidentialDeliverable;

        public BLConfidentialDeliverable(WorkpackDBContext context, IGenericDataRepository<Confidential> confidentialDeliverable)
        {
            _context = context;
            _confidentialDeliverable = confidentialDeliverable;
        }

        public void AddConfidentialDeliverable(params Confidential[] Confidential)
        {
            try
            {
                _confidentialDeliverable.Add(Confidential);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public void RemoveConfidentialDeliverable(params Confidential[] Confidential)
        {
            try
            {
                _confidentialDeliverable.Remove(Confidential);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }




        public bool IsDeliverableConfidential(int DeliverableID, int MileStoneId, int RevisionId)
        {
            Confidential cnf = new Confidential();
            bool IsDeliverableConfidential = true;
            int? dellistid = DeliverableID;
            int? mileid = MileStoneId;
            int? revid = RevisionId;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    cnf = context.Confidentials.Where(a => a.DeliverableID == dellistid && a.MilestoneID == mileid && a.RevisionID == revid).FirstOrDefault();
            //}

            if (cnf == null)
            {
                IsDeliverableConfidential = false;
            }

            return IsDeliverableConfidential;
        }


    }
}
