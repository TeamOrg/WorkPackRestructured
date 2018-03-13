using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskListColorCellRepository : IBLTaskListColorCellRepository
    {
       

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskListColorCell> _taskListColorCellRepository;

        public BLTaskListColorCellRepository(WorkpackDBContext context, IGenericDataRepository<TaskListColorCell> taskListColorCellRepository)
        {
            _context = context;
            _taskListColorCellRepository = taskListColorCellRepository;
        }


        public IList<TaskListColorCell> GetAllTaskListColorCell()
        {
            return _taskListColorCellRepository.GetAll();
        }
        public TaskListColorCell GetTaskListColorCellByID(Int32 projectTaskColorCellID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _taskListColorCellRepository.GetSingle(d => d.ProjectTaskColorCellID == projectTaskColorCellID);
            //include related employees
        }
        public List<object> GetTaskListColorCellByProjectID(Int32 ProjectID)
        {
            List<object> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskListColorCells
            //           where q.ProjectID == ProjectID 
            //           select new
            //           {
            //               id = q.ProjectTaskColorCellID,
            //               q.ProjectID,
            //               q.ProjectTaskID,
            //               q.DataMappingID,
            //               q.BackgroudColorCode,
            //               q.FontColorCode,
                          
            //           }).ToList<object>();

            //}
            return lst;
        }

        public TaskListColorCell GetTaskListColorCellByProjectIDTaskID(Int32 ProjectID, Int32 TaskID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _taskListColorCellRepository.GetSingle(d => d.ProjectID == ProjectID && d.ProjectTaskID == TaskID);
            //include related employees
        }


        public List<TaskListColorCell> GetTaskListColorCellByProjectIDTaskIDdatamappingID(Int32 ProjectID, Int32 TaskID, string datamappingID)
        {


            List<TaskListColorCell> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = (from q in context.TaskListColorCells where q.ProjectID == ProjectID && q.ProjectTaskID == TaskID && q.DataMappingID == datamappingID select q).ToList<TaskListColorCell>();
            //}
            return lst;
        }

        public void AddaskListColorCell(params TaskListColorCell[] projectTaskColorCellID)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskListColorCellRepository.Add(projectTaskColorCellID);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void UpdateaskListColorCell(params TaskListColorCell[] projectTaskColorCellID)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskListColorCellRepository.Update(projectTaskColorCellID);
            }
            catch (Exception ex)
            {
                //throw ex;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void RemoveaskListColorCell(params TaskListColorCell[] projectTaskColorCellID)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskListColorCellRepository.Remove(projectTaskColorCellID);
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

        public int updateTaskCellColor(string ProjectID, string TaskID, string colorcode, string colorType, string datamappingID)
        {
            int result = 1;
            //int projectID = Convert.ToInt32(ProjectID);
            //int taskID = Convert.ToInt32(TaskID);
            //BLTaskListColorCellRepository blBLTaskListColorCellRepository = new BLTaskListColorCellRepository();
            //List<TaskListColorCell> lst = null;
            //try
            //{
            //    //Delete previous
            //    lst = GetTaskListColorCellByProjectIDTaskIDdatamappingID(projectID, taskID, datamappingID);
            //    //foreach (var itemLst in lst)
            //    //{
            //    //    itemLst.EntityState = DominModel.EntityState.Deleted;
            //    //}
            //    //blBLTaskListColorCellRepository.RemoveaskListColorCell(lst.ToArray());
            //    //Insert Current
            //    TaskListColorCell TaskColorCell = new TaskListColorCell();
            //    if (lst.Count > 0)
            //    {
            //        foreach (var itemLst in lst)
            //        {
            //            itemLst.EntityState = DominModel.EntityState.Modified;
            //            itemLst.ProjectID = projectID;
            //            itemLst.ProjectTaskID = taskID;
            //            itemLst.DataMappingID = datamappingID;
            //            if (colorType == "B")
            //            {
            //                itemLst.BackgroudColorCode = colorcode;
            //            }
            //            if (colorType == "F")
            //            {
            //                itemLst.FontColorCode = colorcode;
            //            }
                        
            //        }
            //        blBLTaskListColorCellRepository.UpdateaskListColorCell(lst.ToArray());
            //    }
            //    else
            //    {
            //        TaskColorCell.ProjectTaskColorCellID = 0;
            //        TaskColorCell.ProjectID = projectID;
            //        TaskColorCell.ProjectTaskID = taskID;
            //        TaskColorCell.DataMappingID = datamappingID;
            //        if (colorType == "B")
            //        {
            //            TaskColorCell.BackgroudColorCode = colorcode;
            //        }
            //        if (colorType == "F")
            //        {
            //            TaskColorCell.FontColorCode = colorcode;
            //        }
            //        TaskColorCell.EntityState = DominModel.EntityState.Added;
            //       blBLTaskListColorCellRepository.AddaskListColorCell(TaskColorCell);
            //    }


              
              
            //}
            //catch (Exception ex)
            //{
            //    result = 0;
            //}

            return result;
        }

    } 
  
}
