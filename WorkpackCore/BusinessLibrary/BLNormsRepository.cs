using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNormsRepository : IBLNormsRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Norm> _Norms;

        public BLNormsRepository(WorkpackDBContext context, IGenericDataRepository<Norm> Norms)
        {
            _context = context;
            _Norms = Norms;
        }
        public IList<Norm> GetAllNorms()
        {
            int CompanyId = 0;//HttpContext.Current.Session["CompanyId"];
            return _Norms.GetAll().Where(c => c.CompanyId == Convert.ToInt32(CompanyId)).ToList<Norm>(); 
        }
        public Norm GetNormsByID(int NormsID)
        {
            return _Norms.GetSingle(d => d.NormsID == NormsID);
        }
        public void AddNorms(params Norm[] Norms)
        {
            try
            {
                _Norms.Add(Norms);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateNorms(params Norm[] Norms)
        {
            try
            {
                _Norms.Update(Norms);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveNorms(params Norm[] Norms)
        {
            try
            {
                _Norms.Remove(Norms);
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

        public List<Norm> GetAllNormsByNormSetID(int NormSetID)
        {
            List<Norm> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    result = context.Norms.Where(a => a.NormSetID == NormSetID).ToList<Norm>();
            //}

            return result;
        }

        public List<Norm> GetAllNormsByProjectID(int ProjectID)
        {
            List<Norm> result = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int NormSetID = context.Projects.Where(a => a.ProjectID == ProjectID).Select(a => a.NormSetID).FirstOrDefault();
            //    result = GetAllNormsByNormSetID(NormSetID);
            //}
            return result;
        }

        public string GetActivityCodeByNormsID(int NormsID)
        {
            string result = null;
            string[] arrCode = null;
            string NormsName = null;
            string DepartmentCode = null;
            string StageCode = null;
            //String QueryDate = String.Empty;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var innerJoinQuery = from q in context.Norms
            //                         where q.NormsID == NormsID                                    
            //                         select q;
                      


            //    foreach (var a in innerJoinQuery)
            //    {
            //          QueryDate= a.DepartmentID + "&" + a.NormsName + "&" + a.ProjectStage;
            //    }
            //    arrCode = QueryDate.ToString().Split('&');
            //}

         
            //NormsName = arrCode[1].ToString();
            //if (Convert.ToInt32(arrCode[0]) > 0)
            //{
            //    var deptID=Convert.ToInt32(arrCode[0]);
            //    using (var context1 = new Cubicle_EntityEntities())
            //    {
            //        var varDepartmentCode = from r in context1.Departments
            //                                where r.DepartmentID == deptID
            //                  select r;

            //        foreach (var a in varDepartmentCode)
            //        {
            //            DepartmentCode =a.DepartmentCode ;
            //        }
            //    }

            //}
            //else
            //{
            //    DepartmentCode = "All";
            //}

            //if (Convert.ToInt32(arrCode[2]) > 0)
            //{
            //    using (var context2 = new Cubicle_EntityEntities())
            //    {
            //        var ProjectStageID = Convert.ToInt32(arrCode[2]);
            //       var varStageCode = from S in context2.ProjectStages
            //                          where S.ProjectStageID == ProjectStageID
            //                          select S;
            //       foreach (var a in varStageCode)
            //       {
            //           StageCode = a.StageCode;
            //       }
            //    }
            //}
            //else
            //{
            //    StageCode = "All";
            //}




            
            return result = DepartmentCode + " - " + NormsName + " - " + StageCode;
        }


        
    }
}
