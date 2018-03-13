using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLLevelOverloadingRepository : IBLLevelOverloadingRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<LevelOverloading> _LevelOverloadingRepository;

        public BLLevelOverloadingRepository(WorkpackDBContext context, IGenericDataRepository<LevelOverloading> LevelOverloadingRepository)
        {
            _context = context;
            _LevelOverloadingRepository = LevelOverloadingRepository;
        }


        public IList<LevelOverloading> GetAllLevelOverloading()
        {
            return _LevelOverloadingRepository.GetAll();
        }

        public IList<LevelOverloading> GetLevelOverloadingListByLoggedInUserID(int loggedinUserID)
        {
            IList<LevelOverloading> fetchedLevelOverloading = new List<LevelOverloading>();
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    fetchedLevelOverloading = Context.LevelOverloadings.Where(a => a.LoggedinUserID == loggedinUserID).ToList<LevelOverloading>();
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
            return fetchedLevelOverloading;
        }
    }
}
