using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLNormSetRepository : IBLNormSetRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<NormSet> _NormSetRepository;

        public BLNormSetRepository(WorkpackDBContext context, IGenericDataRepository<NormSet> NormSetRepository)
        {
            _context = context;
            _NormSetRepository = NormSetRepository;
        }
        public IList<NormSet> GetAllNormSet()
        {
            int CompanyID = 0;// HttpContext.Current.Session["CompanyId"];
            return _NormSetRepository.GetAll().Where(c => c.CompanyId == Convert.ToInt32(CompanyID)).ToList<NormSet>();
        }
        public NormSet GetNormSetByID(Int32 NormSetID)
        {
            return _NormSetRepository.GetSingle(d => d.NormSetID == NormSetID);
        }
        public void AddNormSet(params NormSet[] NormSet)
        {
            try
            {
                _NormSetRepository.Add(NormSet);
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
        public void UpdateNormSet(params NormSet[] NormSet)
        {
            try
            {
                _NormSetRepository.Update(NormSet);
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
        public void RemoveNormSet(params NormSet[] NormSet)
        {
            try
            {
                _NormSetRepository.Remove(NormSet);
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

        public List<usp_getNormSetData_Result> GetAllNormSetData(int CompanyID)
        {
            List<usp_getNormSetData_Result> lst = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    lst = Context.usp_getNormSetData(CompanyID).ToList<usp_getNormSetData_Result>();
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


        public int GetDefaultCompanyNorm(string ClientName)
        {
            int DefaultCompanyNormID = 0;
            try
            {
                if ("PETRO" == ClientName)
                {
                    //using (var Context = new Cubicle_EntityEntities())
                    //{
                    //    var lst = Context.NormSets.Where(a => a.NormSetType == "com");
                    //    foreach (var item in lst)
                    //    {
                    //        DefaultCompanyNormID = item.NormSetID;
                    //        break;
                    //    }
                    //}
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

            return DefaultCompanyNormID;
        }


        public int InsertTemplateData(int? projectid, int templateid)
        {

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    int i = context.Usp_InsertTemplateData(projectid, templateid);

            //    return i;

            //}
            return 0;

        }


        public void InsertTempdataIntoMainTables(int templateid, int projectid, bool edit = false)
        {

            //using (var context = new Cubicle_EntityEntities())
            //{

            //    var i = context.Usp_InsertTempdataIntoMainTables(templateid, projectid, edit);

            //    CteateFoldersfortemplateTask(projectid,edit);

            //}



        }


        private void CteateFoldersfortemplateTask(int Projectid, bool edit)
        {

            //BLEstimationTaskDetailRepository bldel = new BLEstimationTaskDetailRepository();
            //BLProjectCreationRepository blpcr = new BLProjectCreationRepository();
            ////BLProjectMilestoneRepository pm = new BLProjectMilestoneRepository();
            ////List<ProjectMilestone> lstMilestone = pm.GetMilestoneByProjectID(Projectid);
            //BLDeliverableListRepository bldellst = new BLDeliverableListRepository();
            
            //BLDepartmentRepository blDept = new BLDepartmentRepository();
            //Project project = blpcr.GetProjectByID(Projectid);
            //IList<ProjectTaskList> iptl = BLDeliverableListRepository.GetTaskListByProjectID(Projectid, 0, 0);
            //Company Company = null;

            //if (!UserSession.UserID.Contains("@"))
            //{
            //    BLUserRepository blUser = new BLUserRepository();
            //    User user = blUser.GetuserByID(Convert.ToInt32(UserSession.UserID));
            //    BLCompanyRepository blCom = new BLCompanyRepository();
            //    Company = blCom.GetCompanyByCompanyID(Convert.ToInt32(user.CompanyId));
            //}
            //string Url = BasePage.networkdirectorypath + "\\" + Convert.ToString(Company.ComanyName).Trim('.') + "\\" + project.ProjectCode;
            //if (edit == true)
            //{
            //    System.IO.DirectoryInfo di = new DirectoryInfo(Url);

            //    foreach (DirectoryInfo dir in di.GetDirectories())
            //    {
            //        dir.Delete(true);
            //    }

            //    foreach (FileInfo file in di.GetFiles())
            //    {
            //        file.Delete();
            //    }
               

            //}

            //foreach (var task in iptl)
            //{
            //    List<usp_getAllRevisionByProjectID_Result> lstMilestone = bldellst.getAllRevisionByDeliverableID(task.ProjectTaskID, task.TaskTypeID);
            //    Department dept = blDept.GetDepartmentByID(task.DepatmentID);
            //    string bUrl = BasePage.networkdirectorypath + "\\" + Convert.ToString(Company.ComanyName).Trim('.') + "\\" + project.ProjectCode + "\\" + dept.DepartmentName + "\\" + task.DeliverableNo;
            //    foreach (var vpm in lstMilestone)
            //    {
            //        string fileUploadDir = bUrl + "\\" + vpm.TabName;
            //        if (!Directory.Exists(fileUploadDir))
            //        {
            //            Directory.CreateDirectory(fileUploadDir);
            //            bldel.addCustomPropertiesToFile(bUrl, fileUploadDir, task.ProjectTaskID, Convert.ToInt32(vpm.MilestoneID), vpm.RevisionID);
            //        }
            //    }



            //}

        }




        public int checkDuplicateNormName(string NormSetName, int NormSetID, int CompanyID)
        {
            int cnt = 0;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    cnt = Context.NormSets.Where(a => a.NormSetName.StartsWith(NormSetName) && a.NormSetName.EndsWith(NormSetName) && a.NormSetID != NormSetID && a.CompanyId == CompanyID).Count();
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

            return cnt;
        }

        public List<NormSet> getMappingNormSetByNormSetID(int CompanyNormSetID, int projectID)
        {
            List<NormSet> lst = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{

                //    var NoormIDs = Context.ProjectTaskLists.Where(a => a.ProjectID == projectID).Select(a => a.NormsID).Distinct();



                //    List<int> lstMapping = Context.NormsMappings.Where(a => a.CompanyNormSetID == CompanyNormSetID && NoormIDs.Contains(a.CompanyNormID)).Select(a => a.ContractNormSetID).Distinct().ToList<int>();
                //    lst = Context.NormSets.Where(a => a.NormSetID == CompanyNormSetID || lstMapping.Contains(a.NormSetID)).ToList<NormSet>();
                //    lst = lst.OrderBy(x => x.NormSetType).ToList();

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

        public bool deleteNormSet(int NormID)
        {
            bool status = true;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        //List<NormsDetail> normDet = getNormsDetailsByNormID(NormID);
            //        //foreach (var item in normDet)
            //        //{
            //        //    item.EntityState = DominModel.EntityState.Deleted;
            //        //}
            //        //RemoveNormDetails(normDet.ToArray());


            //        NormSet norm = GetNormSetByID(NormID);
            //        norm.EntityState = DominModel.EntityState.Deleted;
            //        RemoveNormSet(norm);

            //        ts.Complete();
            //        status = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        status = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    }
            //}
            return status;
        }
    }
}
