using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskMilestoneBookedQtyFileRepository : IBLTaskMilestoneBookedQtyFileRepository
    {
       



        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskMilestoneBookedQtyFile> _taskMilestoneBookedQtyFileRepository;

        public BLTaskMilestoneBookedQtyFileRepository(WorkpackDBContext context, IGenericDataRepository<TaskMilestoneBookedQtyFile> taskMilestoneBookedQtyFileRepository)
        {
            _context = context;
            _taskMilestoneBookedQtyFileRepository = taskMilestoneBookedQtyFileRepository;
        }



        public IList<TaskMilestoneBookedQtyFile> GetAllTaskMilestoneBookedQtyFile()
        {
            return _taskMilestoneBookedQtyFileRepository.GetAll();
        }


        public IList<TaskMilestoneBookedQtyFile> GetAllTaskMilestoneBookedQtyFileByID(Int32 TaskMilestoneBookedQtyID)
        {
            IList<TaskMilestoneBookedQtyFile> List = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    List = context.TaskMilestoneBookedQtyFiles.Where(a => a.TaskMilestoneBookedQtyID == TaskMilestoneBookedQtyID).ToList<TaskMilestoneBookedQtyFile>();
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
            return List;
        }


        public void AddTaskMilestoneBookedQtyFile(params TaskMilestoneBookedQtyFile[] taskMilestoneBookedQtyFile)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskMilestoneBookedQtyFileRepository.Add(taskMilestoneBookedQtyFile);
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

        public void RemoveTaskMilestoneBookedQtyFile(params TaskMilestoneBookedQtyFile[] taskMilestoneBookedQtyFile)
        {
            try
            {
                _taskMilestoneBookedQtyFileRepository.Remove(taskMilestoneBookedQtyFile);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

    }
}
