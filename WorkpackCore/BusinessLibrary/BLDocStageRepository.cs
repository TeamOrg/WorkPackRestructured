using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{

    public class BLDocStageRepository : IBLDocStageRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<DocStage> _docstage;

        public BLDocStageRepository(WorkpackDBContext context, IGenericDataRepository<DocStage> docstage)
        {
            _context = context;
            _docstage = docstage;
        }
        public IList<DocStage> GetAlldocstage()
        {
            return _docstage.GetAll();
        }

        public int GetDocstageIdbyDocStage(string DocStage)
        {
            int DocstageId=0;
            //using (var context= new Cubicle_EntityEntities())
            //{
            //     DocstageId = context.DocStages.Where(a => a.DocStage1.ToUpper() == DocStage.ToUpper()).Select(a => a.DocStageID).FirstOrDefault();
            //}
            return DocstageId;
            
        }
        
    }
}
