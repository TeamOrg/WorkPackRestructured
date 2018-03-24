using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Collections;

namespace BusinessLibrary
{
    public class BLProjectCreationRepository : IBLProjectCreationRepository
    {
        public int ProjectStatusClosed = 0;      
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Project> _projectCreation;

        public BLProjectCreationRepository(WorkpackDBContext context, IGenericDataRepository<Project> projectCreation)
        {
            _context = context;
            _projectCreation = projectCreation;
        }
        
        public IList<Project> GetAllProject(int companyId)
        {
            return (from q in _context.Projects where q.CompanyId == companyId select q).ToList();
        }
        public static IList<Project> GetAllOnGoingProjects()
        {
            IList<Project> list = null;
            //BLProjectCreationRepository objbl = new BLProjectCreationRepository();
            //List<int> prid = new List<int>();
            //prid = objbl.GetAllProjectIDByProjectStatus(Convert.ToInt32(Common.ProjectStatus.OnGoing).ToString()); //to filter ongoing projects 
           
            //try
            //{
            //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //    using (var db = new Cubicle_EntityEntities())
            //    {
            //        list = (from a in db.Projects.Where(c => prid.Contains(c.ProjectID) && c.SysGen == null && c.CompanyId == CompanyId) select a).OrderBy(x => x.ProjectName).ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            return list;
        }

        public IList<Project> GetProjectsWithNoTaskList()
        {
            IList<Project> list = null;
            try
            {
               //string userid=Convert.ToString(HttpContext.Current.Session["UserId"]);
               // using (var db = new Cubicle_EntityEntities())
               // {                   

               // list= ( from q in db.Projects
               //         where !(from p in db.ProjectTaskLists select p.ProjectID).Contains(q.ProjectID)
               //         && q.CreatedBy == userid
               //         select q).ToList();
                                   
               // }

            }
            catch (Exception ex)
            { 
            }
            return list;
       }



        public static IList<Project> GetAllOnGoingProjectsWithDeliverable()
        {
            IList<Project> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    List<ProjectTaskList> lstPrTask = (from q in db.ProjectTaskLists
                //                                       where q.IsDeliverable == true
                //                                       select q).ToList<ProjectTaskList>();
                //    list = (from a in db.Projects where a.SysGen == null && lstPrTask.Select(d => d.ProjectID).Contains(a.ProjectID) select a).OrderBy(x => x.ProjectName).ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static List<ProjectModel> GetAllOnGoingProjectsModel()
        {
            List<ProjectModel> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from a in db.Projects.Where(c => c.SysGen == null)
                //            select new ProjectModel
                //            {
                //                ProjectID = a.ProjectID,
                //                ProjectName = a.ProjectName,
                //                ProjectCode = a.ProjectCode

                //            }).OrderBy(x => x.ProjectName).ToList<ProjectModel>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public List<object> GetAllProjectLeader()
        {
            List<object> list = null;
            try
            {
                //int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from P in db.Projects
                //            join U in db.Users on P.ProjectLeader equals U.UserID
                //            where P.CompanyId == CompanyId
                //            select new
                //            {
                //                ProjectLeaderID = P.ProjectLeader,
                //                ProjectLeaderName = U.FirstName + " " + U.LastName
                //            }).Distinct().ToList<object>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public List<object> GetAllProjectCostReport(int ProjectID, string groupby, string distribution)
        {
            List<object> list = null;
            //int local = Convert.ToInt32(Common.ResourceCategory.Local);
            //int regional = Convert.ToInt32(Common.ResourceCategory.Regional);
            //int expat = Convert.ToInt32(Common.ResourceCategory.Expat);
            try
            {

                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_ProjectWiseCostReport(ProjectID,local,regional,expat,0,0,0,groupby,distribution).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public List<object> GetAllProjectCode(int ProjectStatusArchived)
        {
            List<object> list = null;
            string[] ProjStatus = { ProjectStatusArchived.ToString() };
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    int CompanyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //    list = (from P in db.Projects
                //            where !ProjStatus.Contains(P.ProjectStatus) && P.SysGen == null && P.CompanyId == CompanyId
                //            orderby P.ProjectCode descending
                //            select new
                //            {
                //                ProjectCode = P.ProjectCode,
                //                ProjectID = P.ProjectID
                //            }
                //            ).ToList<object>();

                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public List<object> GetAllProjectCodeArchived(int ProjectStatusArchived)
        {
            List<object> list = null;

            try
            {
                var ProjectStatus = ProjectStatusArchived.ToString();
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from P in db.Projects
                //            where P.ProjectStatus == ProjectStatus
                //            select new
                //            {
                //                ProjectCode = P.ProjectCode,
                //                ProjectID = P.ProjectID
                //            }).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }





        public List<int> GetAllProjectIDOfClosedArchived()
        {
            List<int> list = null;

            try
            {
                //int projectstatusClosed = Convert.ToInt32(Common.ProjectStatus.Closed);
                //int projectstatusArchived = Convert.ToInt32(Common.ProjectStatus.Archived);
                //string prstatusClosed = Convert.ToString(projectstatusClosed);
                //string prstatusArchived = Convert.ToString(projectstatusArchived);
                ////List<string> status = new List<string>();
                ////status.Add(prstatusClosed);
                ////status.Add(prstatusArchived);

                //using (var db = new Cubicle_EntityEntities())
                //{
                //    //list = db.Projects.Where(a =>status.Contains(a.ProjectStatus)).Select(a => a.ProjectID).ToList<int>();
                //   list = db.Projects.Where(a => a.ProjectStatus == prstatusClosed || a.ProjectStatus == prstatusArchived).Select(a => a.ProjectID).ToList<int>();
                // }
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public List<int> GetAllProjectIDByProjectStatus(string status)
        {
            List<int> list = null;

            try
            {
               
             
                  list = _context.Projects.Where(c => c.ProjectStatus == status && (c.SysGen == null||c.SysGen.ToLower() == "dummy")).Select(a => a.ProjectID).ToList<int>();
               

            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public bool UpdateProjectStatus(int ProjectID,string status)
        {
            bool result = false;
            try
            {
                //Project lstblProject = GetProjectByID(ProjectID);
                //lstblProject.ProjectStatus = status;
                //lstblProject.EntityState = DominModel.EntityState.Modified;
                //_projectCreation.Update(lstblProject);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
           
            
            
        
        }




        //public void UpdateUserAlertFlagDM(int ProjectID)
        //{
        //    Project lstblProject = GetProjectByID(ProjectID);
        //    lstblProject.HideUserAlertDM = "Y";
        //    lstblProject.EntityState = DominModel.EntityState.Modified;
        //    SaveProject(lstblProject);
        //}
        //public int SaveProject(Project objProject)
        //{
        //    int ProjectId= 0;

        //    try
        //    {
        //        using (var context = new Cubicle_EntityEntities())
        //        {
        //            context.Projects.Attach(objProject);
        //            context.Entry(objProject).State = objProject.EntityState == EntityState.Added ? System.Data.EntityState.Added : System.Data.EntityState.Modified;
        //            context.SaveChanges();
        //            ProjectId = objProject.ProjectID;

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        ProjectId = 0;
        //        bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
        //        throw ex;
        //    }

        //    return ProjectId;
        //}      



        public Project GetProjectByID(int projectID)
        {
           // return _projectCreation.GetSingle(d => d.ProjectID == projectID && d.ProjectName != "No Project Selected");
            return _projectCreation.GetSingle(d => d.ProjectID == projectID);
        }


        public Project GetDummyProjectByCompanyID(int Companyid)
        {
            return _projectCreation.GetSingle(d => d.CompanyId == Companyid && d.SysGen=="Dummy");
        }
        public Project GetProjectWithCompanyByID(int projectID)
        {
            // return _projectCreation.GetSingle(d => d.ProjectID == projectID && d.ProjectName != "No Project Selected");
            //return _projectCreation.GetSingle(d => d.ProjectID == projectID);

            Project pr = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    pr = context.Projects.Include("Company").Where(a => a.ProjectID == projectID).SingleOrDefault();
            //}
            return pr;
        }

        public Project GetProjectByIDWithMilestone(int projectID)
        {
            Project pr = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    pr = context.Projects.Include("ProjectMilestones").Where(a => a.ProjectID == projectID).SingleOrDefault();
            //}
            return pr;
        }

        public IList<Project> GetAllProjectsByClientAsset_Client(string Client, int ClientAsset)
        {
            IList<Project> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from p in db.Projects where p.ClientCode == (Client == "0" ? p.ClientCode : Client) && p.ClientAssetID == (ClientAsset == 0 ? p.ClientAssetID : ClientAsset) select p).ToList<Project>();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public ArrayList GetCurrentlyWorkingOnProjects(DateTime fromdt, DateTime todt, int userid, int EstimationID, int AwaitedID)
        {
            ArrayList arr = new ArrayList();
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var lst = (from p in db.getTaskWiseDailyHrsDistr(fromdt, todt, userid, EstimationID, AwaitedID)
                //               join pr in db.Projects on p.ProjectID equals pr.ProjectID
                //               orderby p.DailyHrs descending
                //               group p by new { ProjectID = p.ProjectID, ProjectName = pr.ProjectName, ProjectCode = pr.ProjectCode } into g
                //               select new { ProjectName = g.Key.ProjectName + " - " + g.Key.ProjectCode, ProjectID = g.Key.ProjectID }).Take(3).ToList();

                //    foreach (var item in lst.ToList())
                //    {

                //        arr.Add(item.ProjectID + "#" + item.ProjectName);
                //    }

                //}
            }
            catch (Exception ex)
            {
            }
            return arr;

        }
        //public Project GetProjectByProjectCode(string projectCode, int projectid)
        //{
            
            //if (projectid == 0)
            //{
            //    return _projectCreation.GetSingle(d => d.ProjectCode.ToString().ToUpper() == projectCode.ToString().ToUpper() && d.CompanyId == Convert.ToInt32(HttpContext.Current.Session["CompanyId"]));
            //}
            //else
            //{
            //    return _projectCreation.GetSingle(d => d.ProjectCode.ToString().ToUpper() == projectCode.ToString().ToUpper() && d.ProjectID != projectid && d.CompanyId == Convert.ToInt32(HttpContext.Current.Session["CompanyId"]));
            //}

        //}
        public void AddProject(params Project[] projects)
        {
            try
            {
                _projectCreation.Add(projects);

                //foreach (var project in projects)
                //{
                //    IProjectWBSRepository _projectWbs = new ProjectWBSRepository();
                //    var count = _projectWbs.GetList(p => p.ProjectID == project.ProjectID && p.WBSCode == project.ProjectCode).Count();
                //    if (count == 0)
                //    {
                //        var pwb = new ProjectWB();
                //        pwb.WBSName = project.ProjectName;
                //        pwb.WBSCode = project.ProjectCode;
                //        pwb.ParentWBSID = 0;
                //        pwb.ProjectID = project.ProjectID;
                //        pwb.EntityState = EntityState.Added;
                //        _projectWbs.Add(pwb);
                //    }
                //}

            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateProject(params Project[] projects)
        {
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        _projectCreation.Update(projects);

            //        foreach (var project in projects)
            //        {
            //            IProjectWBSRepository _projectWbs = new ProjectWBSRepository();
            //            var pwbs = _projectWbs.GetList(p => p.ProjectID == project.ProjectID && p.WBSCode == project.ProjectCode);
            //            foreach (var p in pwbs)
            //            {
            //                p.WBSName = project.ProjectName;
            //                p.WBSCode = project.ProjectCode;
            //                p.EntityState = EntityState.Modified;
            //                _projectWbs.Update(p);
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
        public void RemoveProject(params Project[] projects)
        {
            try
            {
                _projectCreation.Remove(projects);
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

        public bool deleteproject(int projID)
        {
            bool success;

            try
            {
                success = true;
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    int succe = context.usp_deleteProject(projID);
                //}
            }
            catch (Exception ex)
            {
                success = false;
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return success;
        }


        public List<object> getProjectDropDownData(string DataType, int DeptID = 0)
        {
            List<object> list = null;
            try
            {
                list = new List<object>();
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectCreationDropDownData(DataType, DeptID).ToList<object>();
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

        public static List<usp_get_BindFocalPoint_Result> GetClientFocalPointsByClientID(int ClientID)
        {
            List<usp_get_BindFocalPoint_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_get_BindFocalPoint(ClientID).ToList<usp_get_BindFocalPoint_Result>();

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
        public IList<SP_GET_SEARCH_BAR_RESULT_Result> SearchResults(string category, int userid, string query)
        {
            List<SP_GET_SEARCH_BAR_RESULT_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.SP_GET_SEARCH_BAR_RESULT(category, userid, query).ToList<SP_GET_SEARCH_BAR_RESULT_Result>();

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
 
        public List<usp_getProjectDeptDataByprojectID_Result> getProjectDeptByProjectID(int ProjectID)
        {
            List<usp_getProjectDeptDataByprojectID_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectDeptDataByprojectID(ProjectID).ToList<usp_getProjectDeptDataByprojectID_Result>();
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

        //public System.Data.DataTable LINQToDataTable(IEnumerable<Project> enumerable)
        //{
        //    return _projectCreation.LINQToDataTable(enumerable);
        //}


        public usp_getProjectDataByprojectID_Result GetAllProjectRelatedDataByID(int projectID)
        {
            usp_getProjectDataByprojectID_Result list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.usp_getProjectDataByprojectID(projectID).FirstOrDefault();
            //}
            return list;
        }



        public void GenerateResourceRequest(int ProjectID, string ProjectStatusFlag, int TaskStatusID, int UserID)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    context.usp_GenerateResourceRequest(ProjectID, ProjectStatusFlag, TaskStatusID, UserID);
            //}
        }



        public Boolean GenerateResourceRequest(int projectID)
        {
            Boolean isResourceRequestGenerated = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var items = from item in context.ResourceRequests
            //                where item.ProjectID == projectID && item.SysGen != "Y"
            //                select item;

            //    if (items.Count() > 0)
            //    {
            //        isResourceRequestGenerated = true;
            //    }

            //}
            return isResourceRequestGenerated;
        }












        public List<usp_getMilestoneDetailsAndTask_Result> getMilestoneDetailsAndTask(int ProjectID)
        {
            List<usp_getMilestoneDetailsAndTask_Result> list = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = context.usp_getMilestoneDetailsAndTask(ProjectID).ToList<usp_getMilestoneDetailsAndTask_Result>();
            //}
            return list;
        }

        public int getEnableImport(int ProjectID, int ActivityType)
        {
            int list = 0;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    list = (from n in context.ProjectMilestones
            //            join m in context.TaskMilestoneTargetDates on n.ProjectMilestoneID equals m.MileStoneID
            //            where n.ProjectID == ProjectID && n.ActivityTypeID == ActivityType
            //            select n
            //           ).Count();

            //}
            return list;
        }


        public List<usp_searchUserProject_Result> searchUserProject(Project project, Int32 UserID, int ProjectStatusArchived)
        {
            int ProjectStatusOnGoing = Convert.ToInt32(CommonLibrary.ProjectStatus.OnGoing);
            List<usp_searchUserProject_Result> lst = null;
            List<usp_searchUserProject_Result> list = null;
            try
            {
                
                    lst = _context.usp_searchUserProject(project.ProjectType, project.ProjectStage, Convert.ToInt32(project.ProjectCode),
                                                        project.ClientProjectNo, project.ClientAssetID, Convert.ToInt32(project.ProjectStatus), project.ProjectStartDate,
                                                        project.ProjectEndDate, project.ProjectLeader, UserID, ProjectStatusArchived).ToList<usp_searchUserProject_Result>();


                    list = lst.Where(a => a.ProjectStatus == Convert.ToString(ProjectStatusOnGoing)).ToList<usp_searchUserProject_Result>();

                
            }
            catch (Exception ex)
            {
                //bool rethrow = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return list;
        }

        public List<usp_searchUserProject_Result> searchUserClosedProject(Project project, Int32 UserID, int ProjectStatusArchived)
        {
//            ProjectStatusClosed = Convert.ToInt32(Common.ProjectStatus.Closed);
            List<usp_searchUserProject_Result> lst = null;
            List<usp_searchUserProject_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_searchUserProject(project.ProjectType, project.ProjectStage, Convert.ToInt32(project.ProjectCode),
                //                                        project.ClientProjectNo, project.ClientAssetID, Convert.ToInt32(project.ProjectStatus), project.ProjectStartDate,
                //                                        project.ProjectEndDate, project.ProjectLeader, UserID, ProjectStatusArchived).ToList<usp_searchUserProject_Result>();


                //    list = lst.Where(a => a.ProjectStatus == Convert.ToString(ProjectStatusClosed)).ToList<usp_searchUserProject_Result>();

                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return list;
        }
        public List<usp_searchUserProject_Result> searchUserEstimationProject(Project project, Int32 UserID, int ProjectStatusArchived)
        {
 //         int ProjectStatusEstimation = Convert.ToInt32(Common.ProjectStatus.Estimation);
            List<usp_searchUserProject_Result> lst = null;
            List<usp_searchUserProject_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_searchUserProject(project.ProjectType, project.ProjectStage, Convert.ToInt32(project.ProjectCode),
                //                                        project.ClientProjectNo, project.ClientAssetID, Convert.ToInt32(project.ProjectStatus), project.ProjectStartDate,
                //                                        project.ProjectEndDate, project.ProjectLeader, UserID, ProjectStatusArchived).ToList<usp_searchUserProject_Result>();


                //    list = lst.Where(a => a.ProjectStatus == Convert.ToString(ProjectStatusEstimation)).ToList<usp_searchUserProject_Result>();

                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return list;
        }
        
        
        public List<usp_searchUserProjectList_Result> searchProjectList(int ProjectType, int ProjectStage, int ProjectCode,
                                                        string ClientProjectNo, int ClientAssetID, int ProjectStatus, string ProjectStartDate,
                                                        string ProjectEndDate, int ProjectLeader, int UserID, int ProjectStatusArchived, int AwaitedID, int EstimationID)
        {
            List<usp_searchUserProjectList_Result> list = null;
            //CultureInfo ci = new CultureInfo("en-GB");
            //Project c = new Project();
            //Nullable<DateTime> FromDate;
            //Nullable<DateTime> ToDate;
            //if (ProjectStartDate == "")
            //{
            //    FromDate = null;
            //}
            //else
            //{
            //    FromDate = Convert.ToDateTime(ProjectStartDate, ci).Date;
            //}
            //if (ProjectEndDate == "")
            //{
            //    ToDate = null;
            //}
            //else
            //{
            //    ToDate = Convert.ToDateTime(ProjectEndDate, ci).Date;
            //}
            //try
            //{
            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        list = context.usp_searchUserProjectList(ProjectType, ProjectStage, Convert.ToInt32(ProjectCode),
            //                                           ClientProjectNo, ClientAssetID, Convert.ToInt32(ProjectStatus), FromDate,
            //                                            ToDate, ProjectLeader, UserID, ProjectStatusArchived, AwaitedID, EstimationID).ToList<usp_searchUserProjectList_Result>();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //    throw ex;
            //}
            return list;
        }
        public List<usp_GetUserArchivedProject_Result> searchArchivedProject(Project project, Int32 ProjectStatus, Int32 UserID)
        {
            List<usp_GetUserArchivedProject_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_GetUserArchivedProject(project.ProjectType, project.ProjectStage, Convert.ToInt32(project.ProjectCode),
                //                                        project.ClientProjectNo, project.ClientAssetID, project.ProjectStartDate,
                //                                        project.ProjectEndDate, project.ProjectLeader, Convert.ToInt32(project.ClientCode), ProjectStatus, UserID).ToList<usp_GetUserArchivedProject_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return list;
        }

        public string getProjectCostHealth(Int32 pkId, string healthType)
        {
            Decimal str = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    str = Convert.ToDecimal(context.SP_PROJECT_OVERHEAD(pkId).FirstOrDefault().GetValueOrDefault());
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
            return GetHealthColort(healthType, str) + "#" + str;
        }

        public static String GetHealthColort(string vScheduleType, decimal Per)
        {
            String strColor = "";
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var items = from item in context.ScheduleHealths
                //                where item.ScheduleType == vScheduleType
                //                select new
                //                {
                //                    col1 = Per <= item.GreenP ? "Green" : (Per > item.GreenP && Per <= item.YellowToP ? "Yellow" : "Red")
                //                };
                //    if (items.Count() > 0)
                //    {
                //        strColor = Convert.ToString(items.SingleOrDefault().col1);
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

            return strColor;
        }

        public string getProjectScheduleHealth(int ProjectID, string healthType)
        {
            decimal ipercentage = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    ipercentage = Convert.ToDecimal(context.SP_PROJECT_DELAY(ProjectID).FirstOrDefault().GetValueOrDefault());
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

            return GetHealthColort(healthType, ipercentage) + "#" + ipercentage;
        }

        public static IList<usp_getDeptInvolvedInProject_Result> getDeptInvolvedInProject(int ProjectID)
        {
            IList<usp_getDeptInvolvedInProject_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getDeptInvolvedInProject(ProjectID).ToList<usp_getDeptInvolvedInProject_Result>();
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

        public static IList<usp_getDeptInvolvedInProject_Contract_Result> getDeptInvolvedInProject_Contract(int ProjectID)
        {
            IList<usp_getDeptInvolvedInProject_Contract_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getDeptInvolvedInProject_Contract(ProjectID).ToList<usp_getDeptInvolvedInProject_Contract_Result>();
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

        public List<usp_getProjectTaskOwner_Result> getProjectTaskOwner(int projectID)
        {
            List<usp_getProjectTaskOwner_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getProjectTaskOwner(projectID).ToList<usp_getProjectTaskOwner_Result>();
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

        public static IList<usp_getUserAndProjectTaskWithDependency_Result> getUserProjectDropDownData(int UserID, int ProjectID, int DeptID, string ScheduleLevel,string showForecast)
        {
            IList<usp_getUserAndProjectTaskWithDependency_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                
                //{
                //    ((System.Data.Entity.Infrastructure.IObjectContextAdapter)Context).ObjectContext.CommandTimeout = 0;
                //    list = Context.usp_getUserAndProjectTaskWithDependency(UserID, ProjectID, DeptID, ScheduleLevel, showForecast).ToList<usp_getUserAndProjectTaskWithDependency_Result>();
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

        public static IList<usp_getUserAndProjectTaskWithDependency_Contract_Result> getUserProjectDropDownData_Contract(int UserID, int ProjectID, int DeptID, int ProjectContractID)
        {
            IList<usp_getUserAndProjectTaskWithDependency_Contract_Result> list = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    list = Context.usp_getUserAndProjectTaskWithDependency_Contract(UserID, ProjectID, DeptID, ProjectContractID).ToList<usp_getUserAndProjectTaskWithDependency_Contract_Result>();
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



        public static Boolean DeleteProject(int ProjectID)
        {
            Boolean res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var proj = (from p in db.Projects where p.ProjectID == ProjectID select p).FirstOrDefault();
                //    if (proj != null)
                //    {
                //        db.Entry(proj).State = System.Data.EntityState.Deleted;
                //        db.SaveChanges();
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
            return res;
        }

        public static List<object> GetAllProjectForDropdown()
        {
            List<object> list = null;
            try
            {
                //int CompanyID =Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from a in db.Projects.Where(a=>a.CompanyId==CompanyID && a.ProjectName!="No Project Selected") select new { ProjectID = a.ProjectID, ProjectName = a.ProjectName + " - " + a.ProjectCode }).ToList<object>();
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

        public static List<String> GetProject()
        {
            List<String> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from a in db.Projects select new { Project = a.ProjectName + " - " + a.ProjectCode }.ToString()).ToList();
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

        public static List<String> GetLookupList(String lookupOption, String lookupCriteria)
        {
           // String m_UserCode = HttpContext.Current.Session["UserCode"].ToString();
            List<String> empList = new List<String>();
            List<String> InvoiceList = new List<String>();
            List<String> dt = null;
            switch (lookupOption.ToLower())
            {
                case "project":
                    dt = GetProject();

                    foreach (var drList in dt)
                    {
                        empList.Add(Convert.ToString(drList));
                    }
                    break;
            }
            return empList;
        }

        public static IList<Project> GetProjectsByDept(int Dept, int Asset)
        {
            IList<Project> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from p in db.Projects
                //            join
                //                pt in db.ProjectTaskLists on p.ProjectID equals pt.ProjectID
                //            where pt.DepatmentID == (Dept == 0 ? pt.DepatmentID : Dept) &&
                //            p.ClientAssetID == (Asset == 0 ? p.ClientAssetID : Asset)
                //            select p).Distinct().ToList();
                //}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public List<Project> GetXmlImportProject(int ProjectID)
        {
            List<Project> list = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    IQueryable<Project> lst = Context.Projects.Include("ProjectWBS").Where(a => a.ProjectID == ProjectID);
            //    list = lst.ToList<Project>();
            //}
            return list;
        }



       

        public List<ProjectStatu> GetAllProjectStatus()
        {
            List<ProjectStatu> list = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    list = Context.ProjectStatus.ToList<ProjectStatu>();
            //}
            return list;
        }

        public List<object> getAssignEngineers(int DeptID, int ProjectID, int EstimationID, int AwaitedID)
        {
            List<object> list = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    list = Context.usp_getAssignEngineers(DeptID, ProjectID, EstimationID, AwaitedID).ToList<object>();
            //}
            return list;
        }

        public string checkEditProjectDate(string ProjectID, DateTime stratDate1, DateTime endDate1)
        {
            string Msg = "";
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    System.Data.Objects.ObjectParameter p = new System.Data.Objects.ObjectParameter("AvailableHrs", 0);
            //    var result = context.usp_checkEditProjectDate(Convert.ToInt32(ProjectID), stratDate1, endDate1).First();
            //    Msg = result;
            //}
            return Msg;
        }


        public string DeleteProjectEstimationTasksDetail(int ProjectID, string MasterTaskType="1")
        {
            string str = "0";
            //using (TransactionScope ts = new TransactionScope())
            //{

            //    try
            //    {
            //        BLTaskListRepository bltasklist = new BLTaskListRepository();
            //        List<int> lstProjecttask = bltasklist.GetAllTaskListByProjectID(ProjectID).Select(c => c.ProjectTaskID).ToList<int>();
            //        // delete EstimationTaskColumnsMaster for selected project
            //        using (var context = new Cubicle_EntityEntities())
            //        {

            //            BLEstimationTaskColumnsMasterRepository objEstimationTaskColumns = new BLEstimationTaskColumnsMasterRepository();
            //            IList<EstimationTaskColumnsMaster> lst = objEstimationTaskColumns.GetAllEstimationTaskColumnsMastersByProjectID(ProjectID, Convert.ToInt32(MasterTaskType));
            //            foreach (var item in lst)
            //            {
            //                item.EntityState = DominModel.EntityState.Deleted;
            //            }
            //            objEstimationTaskColumns.RemoveEstimationTaskColumnsMasters(lst.ToArray());
            //        }
            //        // delete TaskDesignation for selected project
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            BLTaskDesignationRepository objTaskDesignation = new BLTaskDesignationRepository();
            //            IList<TaskDesignation> lst = objTaskDesignation.GetTaskDesignationByProjectID(ProjectID);
            //            foreach (var item in lst)
            //            {
            //                item.EntityState = DominModel.EntityState.Deleted;
            //            }
            //            objTaskDesignation.RemoveTaskDesignation(lst.ToArray());
            //        }

            //        // new delete TaskDependency for selected project
            //        using (var context = new Cubicle_EntityEntities())
            //        {


            //            BLTaskDependencyRepository blTaskDependency = new BLTaskDependencyRepository();
            //            IList<TaskDependency> lst = blTaskDependency.GetAllTaskDependencies().Where(c => lstProjecttask.Contains(c.TaskID)).ToList<TaskDependency>();
            //            foreach (var item in lst)
            //            {
            //                item.EntityState = DominModel.EntityState.Deleted;
            //            }
            //            blTaskDependency.RemoveTaskDependency(lst.ToArray());
            //        }




            //        //new delete Task details for selected project
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            BLTaskDeatilsRepository bltaskdetails = new BLTaskDeatilsRepository();
            //            List<TaskDetail> lstTaskdetails = bltaskdetails.GetAllTaskDetail().Where(c => lstProjecttask.Contains(c.ProjectTaskID)).ToList<TaskDetail>();

            //            foreach (var item in lstTaskdetails)
            //            {
            //                item.EntityState = DominModel.EntityState.Deleted;
            //            }
            //            bltaskdetails.RemoveTaskDetails(lstTaskdetails.ToArray());
            //        }





            //        // new delete ProjectTaskList for selected project
            //        using (var context = new Cubicle_EntityEntities())
            //        {



            //            IList<ProjectTaskList> lst = bltasklist.GetAllTaskListByProjectID(ProjectID);
            //            foreach (var item in lst)
            //            {
            //                item.EntityState = DominModel.EntityState.Deleted;
            //            }
            //            bltasklist.RemoveTaskList(lst.ToArray());
            //        }





            //        // delete ResourceAllocation for selected project
            //        using (var context = new Cubicle_EntityEntities())
            //        {


            //            BLAllocateResourceRepository objResourceAllocation = new BLAllocateResourceRepository();
            //            IList<ResourceAllocation> lst = objResourceAllocation.AllocatedResourcesByProjectID(ProjectID);
            //            foreach (var item in lst)
            //            {
            //                item.EntityState = DominModel.EntityState.Deleted;
            //            }
            //            objResourceAllocation.RemoveResourceRequestAllocation(lst.ToArray());
            //        }


            //        // delete ResourceRequest for selected project
            //        using (var context = new Cubicle_EntityEntities())
            //        {


            //            BLResourceRequestRepository objResourceRequest = new BLResourceRequestRepository();
            //            List<ResourceRequest> lst = objResourceRequest.GetResourceRequestByProjectID(ProjectID);
            //            foreach (var item in lst)
            //            {
            //                item.EntityState = DominModel.EntityState.Deleted;
            //            }
            //            objResourceRequest.RemoveResourceRequestDesignation(lst.ToArray());
            //        }





            //        str = "1";
            //        ts.Complete();
            //    }
            //    catch (Exception ex)
            //    {
            //        str = "0";
            //        ts.Dispose();
            //        bool false = UserInterfaceExceptionHandler.HandleException(ref ex);


            //    }
            //}
            return str;
        }









        public void deleteAllTaskRelatedDataBeyondProjectPeriod(int ProjectID, DateTime StartDate, DateTime EndDate, string DateShift)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    context.usp_deleteAllTaskDataByProjectID(ProjectID, StartDate, EndDate, DateShift);
            //}
        }

        public void ReSetTaskStartDateBeyoundProjectStartDate(int ProjectID, DateTime StartDate, DateTime EndDate, string DateShift)
        {
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    context.usp_deleteAllTaskDataByProjectID(ProjectID, StartDate, EndDate, DateShift);
            //}
        }

        public List<usp_ProjectBurnChart_Result> GetPlannedAndAchievedProgress(int ProjectID)
        {
            List<usp_ProjectBurnChart_Result> list = null;
            //try
            //{
            //    int dept = 0;
            //    int desg = 0;
            //    int task = 0;

            //    int EstimationID = Convert.ToInt32(Common.ProjectStatus.Estimation);
            //    int AwaitedID = Convert.ToInt32(Common.ProjectStatus.Awaited);


            //    using (var context = new Cubicle_EntityEntities())
            //    {
            //        list = context.usp_ProjectBurnChart(ProjectID, dept, desg, task, AwaitedID, EstimationID).ToList<usp_ProjectBurnChart_Result>();
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
            return list;
        }
        public int AssignEngForEstimation(string xml, int createdBy, int resourceRequestStatusID, int TaskStatusAccepted, int TaskStatusAssigned)
        {
            int status = 0;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    status = context.usp_AssignEngForEstimation(xml, createdBy, resourceRequestStatusID, TaskStatusAccepted, TaskStatusAssigned);
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

            return status;

        }

        public List<ProjectsAdmin> getProjectAdmin(int ProjectID)
        {
            List<ProjectsAdmin> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.ProjectsAdmins.Where(a => a.ProjectID == ProjectID).ToList<ProjectsAdmin>();
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

        public bool IsProjectMember(int UserID, int ProjectID)
        {
            bool IsProjectMember = false;
            IList<usp_IsProjectMember_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_IsProjectMember(UserID, ProjectID).ToList<usp_IsProjectMember_Result>();
                //    if (list.Count > 0)
                //    {
                //        IsProjectMember = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
            return IsProjectMember;
        }





        public void CreateStandardMDL(int projectID, int userID)
        {
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    db.USP_CreateStandardMDL(projectID, userID);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class ProjectModel
    {
        public int ProjectID;
        public string ProjectCode;
        public string ProjectName;
    }
}
