using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLTaskDependencyRepository : IBLTaskDependencyRepository
    {
       


        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<TaskDependency> _taskdependencyRepository;

        public BLTaskDependencyRepository(WorkpackDBContext context, IGenericDataRepository<TaskDependency> taskdependencyRepositoryv)
        {
            _context = context;
            _taskdependencyRepository = taskdependencyRepositoryv;
        }





        public IList<TaskDependency> GetAllTaskDependencies()
        {
            return _taskdependencyRepository.GetAll();
        }
        public TaskDependency GetTaskDependencyByID(Int32 taskdependencyID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _taskdependencyRepository.GetSingle(d => d.TaskDependencyID == taskdependencyID);                
                //include related employees
        }
        public void AddTaskDependency(params TaskDependency[] taskdependency)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskdependencyRepository.Add(taskdependency);
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
        public void UpdateTaskDependency(params TaskDependency[] taskdependency)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskdependencyRepository.Update(taskdependency);
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
        public void RemoveTaskDependency(params TaskDependency[] taskdependency)
        {
            /* Validation and error handling omitted */
            try
            {
                _taskdependencyRepository.Remove(taskdependency);
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
        public IList<usp_getTaskDependency_Result> Fetch(int ProjectTaskID)
        {
            IList<usp_getTaskDependency_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getTaskDependency(ProjectTaskID).ToList<usp_getTaskDependency_Result>();
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
            return list;
        }
        public IList<DependencyType> GetDependencyTypeList()
        {
            IList<DependencyType>list=null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = (from a in context.DependencyTypes select a).ToList();
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
            return list;
        }
        public IList<usp_GetProjectTaskListForDependency_Result> GetProjectTaskID(int ProjectTaskID, int ProjectID)
        {
            IList<usp_GetProjectTaskListForDependency_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetProjectTaskListForDependency(ProjectTaskID, ProjectID).ToList<usp_GetProjectTaskListForDependency_Result>();
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
            return list;
        }
         public Boolean SaveTaskDependency(TaskDependency obj)
        {
            Boolean res = false;
            try
            {
                AddTaskDependency(obj);
                res = true;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public Boolean DeleteTaskDependency(int TaskDependencyID)
        {
            Boolean res = false;
            try
            {
                //TaskDependency obj = GetTaskDependencyByID(TaskDependencyID);
                //obj.EntityState = DominModel.EntityState.Deleted;
                //RemoveTaskDependency(obj);
                res = true;
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }

        public Boolean ValidDependencyCheck(string strPreTaskNode, string strSucTaskNode)
        {
            Boolean Validrelation = true;
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        string PreTaskNode = strPreTaskNode;
            //    CheckBackNode:
            //        var BackNode = context.usp_GetBackNode(strPreTaskNode).ToList<string>();
            //        if (BackNode.Count() > 0)
            //        {
            //            foreach (var a in BackNode)
            //            {
            //                if (a.Trim() != string.Empty)
            //                {
            //                    if (BackNode.Contains(strSucTaskNode))
            //                    {
            //                        Validrelation = false;
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        PreTaskNode = a;
            //                        goto CheckBackNode;
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            InsertDependencyHeap(strPreTaskNode, strSucTaskNode);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    if (false)
            //    {
            //        throw ex;
            //    }
            //}
            return Validrelation;
        }
        public void InsertDependencyHeap(String strPreTaskNode, String strSucTaskNode)
        {
            //String strPriTaskID = strPreTaskNode.Replace("S", String.Empty).Replace("F", String.Empty);
            //String strSuccTaskID = strSucTaskNode.Replace("S", String.Empty).Replace("F", String.Empty);
            //ArrayList arrTaskID = new ArrayList();
            //arrTaskID.Add(strPriTaskID);
            //arrTaskID.Add(strSuccTaskID);
            //ArrayList arrTaskSFCol = new ArrayList();
            //arrTaskSFCol.Add((strPreTaskNode.Contains("S") ? "S" : "F"));
            //arrTaskSFCol.Add((strSucTaskNode.Contains("S") ? "S" : "F"));
            //ArrayList arrTaskSFColValue = new ArrayList();
            //arrTaskSFColValue.Add(strPreTaskNode);
            //arrTaskSFColValue.Add(strSucTaskNode);
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {

            //            for (int i = 0; i < arrTaskID.Count; i++)
            //            {
            //                int tid = Convert.ToInt32(arrTaskID[i]);
            //                var TaskDependencyChainList = (from a in context.TaskDependencyChains where a.TaskID == tid select a).ToList<TaskDependencyChain>();

            //                if (TaskDependencyChainList.Count < 1)
            //                {
            //                    TaskDependencyChain obj = new TaskDependencyChain();
            //                    obj.TaskID = Convert.ToInt32(arrTaskID[i]);
            //                    obj.TaskS = Convert.ToString(arrTaskID[i]) + "S";
            //                    obj.TaskF = Convert.ToString(arrTaskID[i]) + "F";
            //                    context.Entry(obj).State = System.Data.EntityState.Added;
            //                    context.SaveChanges();
            //                }

            //            }
            //            string strColSucc = "";
            //            if (arrTaskSFCol[1].ToString().Contains("S"))
            //            {
            //                strColSucc = "TaskSB";
            //            }
            //            else
            //            {
            //                strColSucc = "TaskFB";
            //            }

            //            string strCol = "";
            //            if (arrTaskSFCol[0].ToString().Contains("S"))
            //            {
            //                strCol = "TaskSF";
            //            }
            //            else
            //            {
            //                strCol = "TaskFF";
            //            }
            //            int arrTID1 = Convert.ToInt32(arrTaskID[1]);
            //            TaskDependencyChain objTaskDC = (from a in context.TaskDependencyChains where a.TaskID == arrTID1 select a).FirstOrDefault();
            //         //   int strColSuccCount = (from a in context.TaskDependencyChains where a.TaskID == arrTID1 select (strColSucc == "TaskSB") ? a.TaskSB : a.TaskFB).Count();
            //           // if (strColSuccCount == 0)
            //            if ((strColSucc == "TaskSB" ? objTaskDC.TaskSB : objTaskDC.TaskFB) == null)
            //            {
            //                if (strColSucc == "TaskSB")
            //                    objTaskDC.TaskSB = objTaskDC.TaskSB + strPreTaskNode;
            //                else
            //                    objTaskDC.TaskFB = objTaskDC.TaskFB + strPreTaskNode;

            //                context.Entry(objTaskDC).State = System.Data.EntityState.Modified;
            //                context.SaveChanges();
            //            }
            //            else
            //            {
            //                if (strColSucc == "TaskSB")
            //                    objTaskDC.TaskSB = objTaskDC.TaskSB+"," + strPreTaskNode;
            //                else
            //                    objTaskDC.TaskFB = objTaskDC.TaskFB+"," + strPreTaskNode;

            //                context.Entry(objTaskDC).State = System.Data.EntityState.Modified;
            //                context.SaveChanges();

            //            }


            //            int arrTID0 = Convert.ToInt32(arrTaskID[0]);
            //            TaskDependencyChain objTaskDC1 = (from a in context.TaskDependencyChains where a.TaskID == arrTID0 select a).FirstOrDefault();
            //          //  int strcolCount = (from a in context.TaskDependencyChains where a.TaskID == arrTID0 select (strCol == "TaskSF") ? a.TaskSF : a.TaskFF).Count();
            //           // if (strcolCount == 0)
            //            if ((strCol == "TaskSF" ? objTaskDC1.TaskSF : objTaskDC1.TaskFF) == null)
            //            {
            //                if (strCol == "TaskSF")
            //                    objTaskDC1.TaskSF = objTaskDC1.TaskSF + strSucTaskNode;
            //                else
            //                    objTaskDC1.TaskFF = objTaskDC1.TaskFF + strSucTaskNode;

            //                context.Entry(objTaskDC1).State = System.Data.EntityState.Modified;
            //                context.SaveChanges();
            //            }
            //            else
            //            {
            //                if (strCol == "TaskSF")
            //                    objTaskDC1.TaskSF =  objTaskDC1.TaskSF+"," + strSucTaskNode;
            //                else
            //                    objTaskDC1.TaskFF = objTaskDC1.TaskFF + "," + strSucTaskNode;

            //                context.Entry(objTaskDC1).State = System.Data.EntityState.Modified;
            //                context.SaveChanges();
            //            }


            //        }
            //        ts.Complete();
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
        }
        public static Decimal GetAllocatedHrsForAPeriod(DateTime From, DateTime To)
        {
            decimal res = 0.0m;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    res = context.usp_Get_Total_AvailableHrs(From, To).Single().GetValueOrDefault();
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
            return res;
        }
        public int GetTaskIDByTaskObjectID(int TaskObjectID, int ProjectID)
        {
            int itaskID = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var val = (from a in context.ProjectTaskLists where a.ProjectID == ProjectID && a.TaskObjectID == TaskObjectID select a).SingleOrDefault();
                //    if (val != null)
                //        itaskID = val.ProjectTaskID;
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
            return itaskID;
        }

        public Boolean CheckDuplicate(TaskDependency TDependency, Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _taskdependencyRepository.GetSingle(p => p.DependencyTaskID == TDependency.DependencyTaskID && p.TaskID == TDependency.TaskID);
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.DependencyTaskID == TDependency.DependencyTaskID && c.DependencyTaskID == TDependency.DependencyTaskID)
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

        public List<TaskDependency> GetPredecessorTaskByTaskID(int TaskID)
        {
            List<TaskDependency> lst = null;
            //using(var context =new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskDependencies.Where(c => c.TaskID == TaskID).ToList<TaskDependency>();
            //}
            return lst;
        }

        public List<TaskDependency> GetSuccessorTaskByTaskID(int DependecyTaskID)
        {
            List<TaskDependency> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.TaskDependencies.Where(c => c.DependencyTaskID == DependecyTaskID).ToList<TaskDependency>();
            //}
            return lst;
        }
        
      
       
       
     
    }
}
