using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProjectWBSRepository : IBLProjectWBSRepository
    {
        

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProjectWB> _projectWBS;

        public BLProjectWBSRepository(WorkpackDBContext context, IGenericDataRepository<ProjectWB> projectWBS)
        {
            _context = context;
            _projectWBS = projectWBS;
        }






        public IList<ProjectWB> GetAllProjectWBS()
        {
            return _projectWBS.GetAll();
        }
        public ProjectWB getProjectWBSByID(int WBId)
        {
            return _projectWBS.GetSingle(d=>d.WBSID==WBId);
        }
        public List<ProjectWB> getProjectWBSListByProjectID(int projectID)
        {
            return _projectWBS.GetList(d => d.ProjectID == projectID).ToList<ProjectWB>();
        }
        public List<object> getProjectWBSByProjectID(int projectID)
        {
             List <object> lst= null;
            return lst;

            //using(var context=new Cubicle_EntityEntities())
            //{
            //    var lst = (from q in context.ProjectWBS
            //               where q.ProjectID == projectID
            //               select new
            //               {
            //                   id=q.WBSID,
            //                   q.WBSID,
            //                   q.WBSName,
            //                   q.WBSCode,
            //                   q.ParentWBSID,
            //                   q.ImportWBSID,
            //                   q.ImportParentWBSID,
            //                   q.ProjectID,
            //                   ParentWBSCode = (from r in context.ProjectWBS where r.WBSID == q.ParentWBSID select r.WBSCode).FirstOrDefault(),
            //                   ParentWBSName = (from r in context.ProjectWBS where r.WBSID == q.ParentWBSID select r.WBSName).FirstOrDefault(),
            //                   IsParent = (from r in context.ProjectWBS where r.ParentWBSID == q.WBSID select r).Count()
            //               }).ToList<object>();
            //    return lst;
            //}
        }

        public List<object> getProjectTaskWBSByProjectID(int projectID)
        {

            List<object> lst = null;
            return lst;

            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var lst = (from q in context.ProjectWBS.ToList() 
            //               where q.ProjectID == projectID
            //               select new
            //               {
            //                   id = q.WBSID,
            //                   q.WBSID,
            //                   q.WBSName,
            //                   q.WBSCode,
            //                   q.ParentWBSID,
            //                   q.ImportWBSID,
            //                   q.ImportParentWBSID,
            //                   q.ProjectID,
            //                   ParentWBSCode = (from r in context.ProjectWBS where r.WBSID == q.ParentWBSID select r.WBSCode).FirstOrDefault(),
            //                   ParentWBSName = (from r in context.ProjectWBS where r.WBSID == q.ParentWBSID select r.WBSName).FirstOrDefault(),
            //                   IsParent = (from r in context.ProjectWBS where r.ParentWBSID == q.WBSID select r).Count(),
            //                   TaskCount=(from t in context.ProjectTaskLists.ToList() where t.ProjectID==projectID && t.WBSID==q.WBSID.ToString() select t).Count()
            //               }).ToList<object>();
            //    return lst;
            //}
        }

        public List<object> getProjectWBSByWbsID(int wbsid)
        {

            List<object> lst = null;
            return lst;



            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var lst = (from q in context.ProjectWBS.ToList()
            //               where q.WBSID == wbsid
            //               select new
            //               {
            //                   WBSID=q.WBSID,
            //                   WBSCode = q.WBSCode
            //                   }).ToList<object>();
            //    return lst;
            //}
        }
        public void AddProjectWBS(params ProjectWB[] projectWBS)
        {
            try
            {
                _projectWBS.Add(projectWBS);
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
        public void RemoveProjectWBS(params ProjectWB[] projectWBS)
        {
            try
            {
                RemoveProjectWBSFromTemplate(projectWBS);
                _projectWBS.Remove(projectWBS);
            }
            catch (Exception ex)
            {
                throw ex;               
            }
        }
        public int CheckTaskByWBSID(string WBSID,int ProjectID)
        {
            int res = 0;
           
                //using ( var context = new Cubicle_EntityEntities())
                //{
                //    try
                //    {
                //        int x = context.ProjectTaskLists.Where(a => a.WBSID == WBSID && a.ProjectID==ProjectID).Count();                       
                //    }
                //    catch (Exception ex)
                //    {
                //        res = 0 ;
                //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);      
                //    }
                    return res;
                //}
            
        }
        public bool RemoveWBSByWBSID(int WBSID)
        {
            bool status = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        try
            //        {                       
            //            var x = context.ProjectWBS.Where(a => a.WBSID == WBSID);
            //            foreach (var item in x)
            //            {
            //                context.ProjectWBS.Remove(item);
            //                context.SaveChanges();
            //                status = true;
            //                ts.Complete();
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            ts.Dispose();
            //            status = false; ;
            //            //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //            throw new Exception("Record not deleted.");

            //        }
                    return status;
            //    }
            //}
        }
        public bool RemoveWBSByWWBSTemplateDetailWBSId(int WBSID)
        {
            bool status = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        try
            //        {
            //            var x = context.WBSTemplateDetails.Where(a => a.WBSID == WBSID);
            //            foreach (var item in x)
            //            {
            //                context.WBSTemplateDetails.Remove(item);
            //                context.SaveChanges();
            //                status = true;
            //                ts.Complete();
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            ts.Dispose();
            //            status = false; ;
            //            //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //            throw new Exception("Record not deleted.");

            //        }
                    return status;
            //    }
            //}
        }
        public void RemoveProjectWBSByProjectID(int ProjectID, string ProjectCode)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        List<string> lst = null;
            //        lst = ((from t in context.ProjectTaskLists.ToList() where t.ProjectID == ProjectID select t.WBSID).Union
            //            ((from w in context.ProjectWBS.ToList() where w.ProjectID == ProjectID && w.WBSCode == ProjectCode select w.WBSID.ToString()))).ToList<string>();

            //        var x = (from w in context.ProjectWBS.ToList() where w.ProjectID == ProjectID && !lst.Contains(w.WBSID.ToString()) select w).ToList();
                 
            //        foreach (var item in x)
            //        {
                        
            //            context.ProjectWBS.Remove(item);
            //            context.SaveChanges();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw new Exception("Record not deleted.");
            //    }
            //}
        }
        private void RemoveProjectWBSFromTemplate(ProjectWB[] projectWBS)
        {
            try
            {
                //BLWBSTemplateDetailRepository blWbsT = new BLWBSTemplateDetailRepository();
                //List<WBSTemplateDetail> lst = new List<WBSTemplateDetail>();
                //foreach (var item in projectWBS)
                //{
                //    List<WBSTemplateDetail> wbsT = blWbsT.GetAllWBSTemplateDetailByWBSID(item.WBSID);
                //    foreach (var t in wbsT)
                //    {
                //        t.EntityState = DomainModelLibrary.EntityState.Deleted;
                //        lst.Add(t);
                //    }
                //}
                //blWbsT.RemoveWBSTemplate(lst.ToArray());
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


        public void UpdateWBSCodeOnchangeOfprojectCode(int ProjectID, string OriginalWBScode, string ChangeWBS)
        {
        //    ProjectWBSRepository wbRepo = new ProjectWBSRepository();
        //    List<ProjectWB> lst = new List<ProjectWB>();
        //    using (var context = new Cubicle_EntityEntities())
        //    {
             
        //        int ID = Convert.ToInt32(ProjectID);
        //        var x = context.ProjectWBS.Where(a => a.ProjectID == ID && a.WBSCode.ToUpper() == OriginalWBScode);
        //        foreach (var item in x)
        //        {
        //            item.WBSCode = ChangeWBS;
        //            item.EntityState = DominModel.EntityState.Modified;
        //            lst.Add(item);
        //        }
        //    }
        //    wbRepo.Update(lst.ToArray());
        }
























        public bool checkDuplicateWBSCode(string code, string projectID, int EditWBSId = 0)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string cod = code.ToUpper();
                //    int prjID = Convert.ToInt32(projectID);
                //    int val = (from a in context.ProjectWBS where a.WBSID != EditWBSId && a.WBSCode.ToUpper() == cod && a.ProjectID == prjID select a).Count();
                //    if (val > 0)
                //        res = true;
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
        public bool checkDuplicateWBSCodeInTemplate(string code, string TemplateID, int EditWBSId = 0)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string cod = code.ToUpper();
                //    int ID = Convert.ToInt32(TemplateID);
                //    int val = (from a in context.WBSTemplateDetails where a.WBSCode.ToUpper() == cod && a.WBSTemplateID == ID select a).Count();
                //    if (val > 0)
                //        res = true;
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


        public bool checkDuplicateWBSCodeInEDitMode(string code, string TemplateID, int WBSID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string cod = code.ToUpper();
                //    int ID = Convert.ToInt32(TemplateID);
                //    int val = (from a in context.WBSTemplateDetails where a.WBSID != WBSID && a.WBSCode.ToUpper() == cod && a.WBSTemplateID == ID select a).Count();
                //    if (val > 0)
                //        res = true;
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
        public bool checkDuplicateWBSCodeInEditMode(string code, string projectID, int EditWBSId)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string cod = code.ToUpper();
                //    int prjID = Convert.ToInt32(projectID);
                //    int val = (from a in context.ProjectWBS where a.WBSID != EditWBSId && a.WBSCode.ToUpper() == cod && a.ProjectID == prjID select a).Count();
                //    if (val > 0)
                //        res = true;
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




        public bool UpdateProjectWBSCode(int WBSID,String WBSCode)
        {
            Boolean res = false;          
            try
            { 
                //ProjectWBSRepository wbRepo = new ProjectWBSRepository();               
                //BLProjectWBSRepository bLwbs = new BLProjectWBSRepository();
                //ProjectWB pWb = bLwbs.getProjectWBSByID(WBSID);
                //pWb.WBSCode = WBSCode;
                //pWb.EntityState = DominModel.EntityState.Modified;
                //wbRepo.Update(pWb);
                res = true;     
            }
            catch (Exception ex)
            {
                res = false;     
            }
            return res;     
        }

        public bool UpdateTemplateWBSCode(int WBSID, String WBSCode)
        {
            Boolean res = false;
            try
            {
                //WBSTemplateDetail wbRepo = new WBSTemplateDetail();
                //BLWBSTemplateDetailRepository bLwbs = new BLWBSTemplateDetailRepository();



                //WBSTemplateDetail pWb = bLwbs.GetWBSTemplateDetailByWBSID(WBSID);
                //pWb.WBSCode = WBSCode;
                //pWb.EntityState = EntityState.Modified;
                //bLwbs.UpdateWBSTemplate(pWb);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }


        public bool UpdateProjectParentWBS(int WBSID, int ParentWBSID)
        {
            Boolean res = false;
            try
            {
                //ProjectWBSRepository wbRepo = new ProjectWBSRepository();
                //BLProjectWBSRepository bLwbs = new BLProjectWBSRepository();
                //ProjectWB pWb = bLwbs.getProjectWBSByID(WBSID);
                //pWb.ParentWBSID = ParentWBSID;
                //pWb.EntityState = EntityState.Modified;
                //wbRepo.Update(pWb);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool UpdateTemplateParentWBS(int WBSID, int ParentWBSID)
        {
            Boolean res = false;
            try
            {
                //List<WBSTemplateDetail> lst = null;
                //WBSTemplateDetail wbRepo = new WBSTemplateDetail();
                //BLWBSTemplateDetailRepository bLwbs = new BLWBSTemplateDetailRepository();
                //lst = bLwbs.GetAllWBSTemplateDetailByWBSID(WBSID);
                //foreach (var item in lst)
                //{
                //    item.ParentWBSID = ParentWBSID;
                //    item.EntityState = DominModel.EntityState.Modified;
                //}
                //bLwbs.UpdateWBSTemplate(lst.ToArray());
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }



        public bool UpdateProjectWBSName(int WBSID, String WBSName)
        {
            Boolean res = false;
            try
            {
                //ProjectWBSRepository wbRepo = new ProjectWBSRepository();
                //BLProjectWBSRepository bLwbs = new BLProjectWBSRepository();
                //ProjectWB pWb = bLwbs.getProjectWBSByID(WBSID);
                //pWb.WBSName = WBSName;
                //pWb.EntityState = DominModel.EntityState.Modified;
                //wbRepo.Update(pWb);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }

        public bool UpdateTemplateWBSName(int WBSID, String WBSName)
        {
            Boolean res = false;
            try
            {
                //List<WBSTemplateDetail> lst = null;
                //WBSTemplateDetail wbRepo = new WBSTemplateDetail();
                //BLWBSTemplateDetailRepository bLwbs = new BLWBSTemplateDetailRepository();
                //lst = bLwbs.GetAllWBSTemplateDetailByWBSID(WBSID);
                //foreach (var item in lst)
                //{
                //    item.WBSName = WBSName;
                //    item.EntityState = DominModel.EntityState.Modified;                  
                //}                
                //bLwbs.UpdateWBSTemplate(lst.ToArray());
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }



        public int getParentidbyImportWBSParentID(string ImportpARENTWBSID, String projectID)
        {
            int WBSParentID = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                   
                //    int ID = Convert.ToInt32(projectID);
                //    var x = context.ProjectWBS.Where(a => a.ProjectID == ID && a.ImportWBSID.ToUpper() == ImportpARENTWBSID);
                //    foreach (var item in x)
                //    {
                //        WBSParentID = item.WBSID;
                //    }
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
            return WBSParentID;
        }



        public int getWBSID(string WBScode,String projectID)
        {
            int WBSParentID = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string cod = WBScode.ToUpper();
                //    int ID = Convert.ToInt32(projectID);
                //    var x = context.ProjectWBS.Where(a => a.ProjectID == ID && a.WBSCode.ToUpper() == cod);    
                //    foreach (var item in x)
                //    {
                //      WBSParentID=item.WBSID;
                //    }
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
            return WBSParentID;
        }
        public bool checkDuplicateWBSTemplateCode(string code, int EditWBSId = 0)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    string cod = code.ToUpper();
                //    int val = (from a in context.WBSTemplates where a.WBSTemplateName.Contains(code) && a.WBSTemplateName.EndsWith(code) && a.WBSTemplateName.StartsWith(code) select a).Count();
                //    if (val > 0)
                //        res = true;
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
        public List<object> getProjectWBSByTemplateID(string WbsTempId)
        {
            List<object> lst = null;
            return lst;


            //int Id = Convert.ToInt32(WbsTempId);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var lst = (from r in context.WBSTemplateDetails join
            //                    q in context.ProjectWBS on r.WBSID equals q.WBSID
            //               where r.WBSTemplateID == Id
            //               select new
            //               {
            //                   id=q.WBSID,
            //                   q.WBSID,
            //                   q.WBSName,
            //                   q.WBSCode,
            //                   q.ParentWBSID,
            //                   q.ImportWBSID,
            //                   q.ImportParentWBSID,
            //                   q.ProjectID,
            //                   ParentWBSCode = (from s in context.ProjectWBS where s.WBSID == q.ParentWBSID select s.WBSCode).FirstOrDefault(),
            //                   ParentWBSName = (from s in context.ProjectWBS where s.WBSID == q.ParentWBSID select s.WBSName).FirstOrDefault()
            //               }).ToList<object>();
            //    return lst;

            //}
        }
        public List<object> getWBSByTemplateID(string WbsTempId)
        {
            List<object> lst = null;
            return lst;


            //int Id = Convert.ToInt32(WbsTempId);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var lst = (from q in context.WBSTemplateDetails                           
            //               where q.WBSTemplateID == Id
            //               select new
            //               {
            //                   id = q.WBSID,
            //                   q.WBSID,
            //                   q.WBSName,
            //                   q.WBSCode,
            //                   q.ParentWBSID,
            //                   ImportWBSID = "",
            //                   ImportParentWBSID = "",
            //                   ProjectID = q.WBSTemplateID,
            //                   ParentWBSCode = (from s in context.WBSTemplateDetails where s.WBSID == q.ParentWBSID select s.WBSCode).FirstOrDefault(),
            //                   ParentWBSName = (from s in context.WBSTemplateDetails where s.WBSID == q.ParentWBSID select s.WBSName).FirstOrDefault(),
            //                   TaskCount=0
            //               }).ToList<object>();
            //    return lst;

            //}
        }
        public List<ProjectWB> getProjectWBSByTemplateID(int WbsTempId)
        {
            List<ProjectWB> lst = null;
            return lst;


            //int Id = Convert.ToInt32(WbsTempId);
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    List<ProjectWB> lst = (from r in context.WBSTemplateDetails
            //                                join
            //                                q in context.ProjectWBS on r.WBSID equals q.WBSID
            //                           where r.WBSTemplateID == Id
            //                           select q).ToList<ProjectWB>();
            //    return lst;
            //}
        }


        public ProjectWB getDefaultWbsByProjectID(int projectId, string ProjectCode)
        {
            ProjectWB wbs = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    wbs = (from q in context.ProjectWBS where q.ProjectID == projectId && q.WBSCode == ProjectCode select q).SingleOrDefault();
            //}
            return wbs;
        }
    }
}
