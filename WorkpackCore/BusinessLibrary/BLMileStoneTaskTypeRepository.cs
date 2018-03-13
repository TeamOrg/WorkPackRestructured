using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMileStoneTaskTypeRepository : IBLMileStoneTaskTypeRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<MileStoneTaskType> _mileStoneTaskTypeRepository;

        public BLMileStoneTaskTypeRepository(WorkpackDBContext context, IGenericDataRepository<MileStoneTaskType> mileStoneTaskTypeRepository)
        {
            _context = context;
            _mileStoneTaskTypeRepository = mileStoneTaskTypeRepository;
        }


        public void AddMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType)
        {
            try
            {
                _mileStoneTaskTypeRepository.Add(mileStoneTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public int getAddMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType)
        {
            int result = 0;
            try
            {
                result = _mileStoneTaskTypeRepository.getAdd(mileStoneTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
            return result;
        }
        public void UpdateMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType)
        {
            try
            {
                _mileStoneTaskTypeRepository.Update(mileStoneTaskType);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public List<MileStoneTaskType> GetMileStoneTaskTypeByMileStoneID(int MileStoneId)
        {
            return _mileStoneTaskTypeRepository.GetList(c => c.MileStoneID == MileStoneId).ToList<MileStoneTaskType>();
        }

        public List<ProjectMilestone> GetMileStoneByProjectIDAndTaskTypeID(int ProjectID, int TaskTypeID)
        {
            List<ProjectMilestone> lst = new List<ProjectMilestone>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.ProjectMilestones
            //           join r in context.MileStoneTaskTypes on q.ProjectMilestoneID equals r.MileStoneID
            //           where r.TaskTypeID == TaskTypeID && q.ProjectID == ProjectID
            //           select q).ToList<ProjectMilestone>();
            //}

            return lst;
        }

        public void RemoveMileStoneTaskType(MileStoneTaskType[] mileStoneTaskType)
        {
            try
            {
                _mileStoneTaskTypeRepository.Remove(mileStoneTaskType);
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
