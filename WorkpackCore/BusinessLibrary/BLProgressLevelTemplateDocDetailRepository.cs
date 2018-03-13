using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProgressLevelTemplateDocDetailRepository : IBLProgressLevelTemplateDocDetailRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProgressLevelTemplateDocDetail> _templatedocdetail;

        public BLProgressLevelTemplateDocDetailRepository(WorkpackDBContext context, IGenericDataRepository<ProgressLevelTemplateDocDetail> templatedocdetail)
        {
            _context = context;
            _templatedocdetail = templatedocdetail;
        }

        public IList<ProgressLevelTemplateDocDetail> GetAllTemplateDocDetail()
        {
            return _templatedocdetail.GetAll();
        }

        public void AddProgressLevelTemplateDocDetail(params ProgressLevelTemplateDocDetail[] templatedocdetails)
        {
            /* Validation and error handling omitted */
            try
            {
                _templatedocdetail.Add(templatedocdetails);
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

        public List<ProgressLevelTemplateDocDetail> GetAllpercentageByMilestoneAndTaskTypeID(int MilestoneID, int TaskTypeID)
        {
            List<ProgressLevelTemplateDocDetail> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProgressLevelTemplateDocDetails.Where(c => c.ProgressLevelTemplateDetailID == MilestoneID && c.TaskTypeID == TaskTypeID).ToList<ProgressLevelTemplateDocDetail>();
            //}
            return lst;
        }
    }
}
