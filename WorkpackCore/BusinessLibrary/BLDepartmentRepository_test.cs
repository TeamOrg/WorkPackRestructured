using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLDepartmentRepository_test : IBLDepartmentRepository_test
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Department_Test> _departmentRepository_test;

        public BLDepartmentRepository_test(WorkpackDBContext context, IGenericDataRepository<Department_Test> departmentRepository_test)
        {
            _context = context;
            _departmentRepository_test = departmentRepository_test;
        }

        public IList<Department_Test> GetAllDepartments()
            {
                return _departmentRepository_test.GetAll();
            }
            public Department_Test GetDepartmentByID(Int32 departmentID)
            {
                //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
                return _departmentRepository_test.GetSingle(d => d.Department_TestID == departmentID);
                //include related employees
            }
            public void AddDepartment(params Department_Test[] Department_Test)
            {
                /* Validation and error handling omitted */
                try
                {
                    _departmentRepository_test.Add(Department_Test);
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
            public void UpdateDepartment(params Department_Test[] Department_Test)
            {
                /* Validation and error handling omitted */
                try
                {
                    _departmentRepository_test.Update(Department_Test);
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
            public bool RemoveDepartment(params Department_Test[] Department_Test)
            {
                bool check = false;
                /* Validation and error handling omitted */
                try
                {
                 _departmentRepository_test.Remove(Department_Test);

                 check = true;
                }
                catch (Exception ex)
                {
                   check = false;
                    ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                    //if (false)
                    //{
                    throw ex;
                    //}
                }

                return check;
            }
            public Boolean CheckDuplicate(Department_Test Department_Test, Boolean IsInsert)
            {
                Boolean Result = true;
                try
                {
                    var c = _departmentRepository_test.GetSingle(p => p.Department_TestCode.ToUpper() == Department_Test.Department_TestCode.ToUpper() && p.Department_TestName.ToUpper() == Department_Test.Department_TestName.ToUpper());
                    if (!IsInsert)
                    {
                        if (c == null)
                            Result = true;
                        else if (c.Department_TestID == Department_Test.Department_TestID)
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
            public IList<Department_Test> GetDepartmentList(Department_Test Department_Test)
            {
                IList<Department_Test> fetchedClient = new List<Department_Test>();
                try
                {
                    //using (var Context = new Cubicle_EntityEntities())
                    //{
                    //    IQueryable<Department_Test> query = Context.Department_Test;
                    //    if (Department_Test.Department_TestName != string.Empty)
                    //        query = query.Where(p => p.Department_TestName.ToUpper().Contains(Department_Test.Department_TestName.ToUpper()));
                    //    if (Department_Test.Department_TestCode != string.Empty)
                    //        query = query.Where(p => p.Department_TestCode.ToUpper().Contains(Department_Test.Department_TestCode.ToUpper()));
                    //    fetchedClient = query.ToList();
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
                return fetchedClient;
            }
            public List<object> GetDepartmentLists()
            {
                List<object> fetchedClient = null;
                try
                {
                    //using (var Context = new Cubicle_EntityEntities())
                    //{
                    //    fetchedClient = (from dt in Context.Department_Test
                    //              select new { id = dt.Department_TestID, DepartmentTestName = dt.Department_TestName, DepartmentTestCode = dt.Department_TestCode }).ToList<object>();
                    //   // fetchedClient = query.ToList();
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
                return fetchedClient;
            }


        }
    }

