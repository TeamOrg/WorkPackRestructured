using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLResourceLevelChartRepository : IBLResourceLevelChartRepository
    {
         



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ResourceLevelChart> _resourceLevelChartRepository;

        public BLResourceLevelChartRepository(WorkpackDBContext context, IGenericDataRepository<ResourceLevelChart> resourceLevelChartRepository)
        {
            _context = context;
            _resourceLevelChartRepository = resourceLevelChartRepository;
        }






        public IList<ResourceLevelChart> GetAllResourceLevelChart()
        {
            return _resourceLevelChartRepository.GetAll();
        }

        public IList<ResourceLevelChart> GetResourceLevelChartByLoggedInUserID(int loggedinUserID)
        {
            IList<ResourceLevelChart> lst = new List<ResourceLevelChart>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    lst = Context.ResourceLevelCharts.Where(a => a.LoggedinUserID == loggedinUserID).ToList<ResourceLevelChart>();
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
            return lst;
        }
    }
}
