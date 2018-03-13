using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProcurementDocumentDataRepository : IBLProcurementDocumentDataRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProcurementDocumentData> _procurementDocumentDataRepository;

        public BLProcurementDocumentDataRepository(WorkpackDBContext context, IGenericDataRepository<ProcurementDocumentData> procurementDocumentDataRepository)
        {
            _context = context;
            _procurementDocumentDataRepository = procurementDocumentDataRepository;
        }


        public List<object> GetAllDelListByProjectID(int ProjectID)
        {
            return _procurementDocumentDataRepository.GetAll().Where(a => a.ProjectID == ProjectID).ToList<object>();
        }

        public IList<ProcurementDocumentData> GetAllProcurementDocumentData()
        {
            IList<ProcurementDocumentData> lst = null;
            return lst;


            //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    IList<ProcurementDocumentData> lstTask = (from q in db.ProcurementDocumentDatas
            //                                              join r in db.Projects on q.ProjectID equals r.ProjectID
            //                                              where r.CompanyId == companyId
            //                                              select q).ToList<ProcurementDocumentData>();

            //    return lstTask;
            //}
        }

        public IList<object> GetAllProcurementDocumentData(int TaskID, int MilestoneID, int FileID)
        {
            IList<object> lst = null;
            return lst;


            //int companyId = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    var lstTask = (from q in db.ProcurementDocumentDatas
            //                   join r in db.Projects on q.ProjectID equals r.ProjectID
            //                   where r.CompanyId == companyId && q.TaskID == TaskID && q.MilestoneID == MilestoneID && q.FileID == FileID
            //                   select q).ToList();


            //    IList<object> lstProcData = lstTask.Select(q => new
            //    {
            //        ProcurementDocumentDataID = q.ProcurementDocumentDataID,
            //        ProjectID = q.ProjectID,
            //        TaskID = q.TaskID,
            //        MilestoneID = q.MilestoneID,
            //        String_1 = q.String_1,
            //        String_2 = q.String_2,
            //        String_3 = q.String_3,
            //        String_4 = q.String_4,
            //        String_5 = q.String_5,
            //        String_6 = q.String_6,
            //        String_7 = q.String_7,
            //        String_8 = q.String_8,
            //        String_9 = q.String_9,
            //        String_10 = q.String_10,
            //        Number_1 = q.Number_1,
            //        Number_2 = q.Number_2,
            //        Number_3 = q.Number_3,
            //        Number_4 = q.Number_4,
            //        Number_5 = q.Number_5,
            //        Number_6 = q.Number_6,
            //        Number_7 = q.Number_7,
            //        Number_8 = q.Number_8,
            //        Number_9 = q.Number_9,
            //        Number_10 = q.Number_10,
            //        DateTime_1 = q.DateTime_1.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_1) : null,
            //        DateTime_2 = q.DateTime_2.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_2) : null,
            //        DateTime_3 = q.DateTime_3.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_3) : null,
            //        DateTime_4 = q.DateTime_4.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_4) : null,
            //        DateTime_5 = q.DateTime_5.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_5) : null,
            //        DateTime_6 = q.DateTime_6.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_6) : null,
            //        DateTime_7 = q.DateTime_7.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_7) : null,
            //        DateTime_8 = q.DateTime_8.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_8) : null,
            //        DateTime_9 = q.DateTime_9.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_9) : null,
            //        DateTime_10 = q.DateTime_10.HasValue ? String.Format("{0:d/M/yyyy}", q.DateTime_10) : null,
            //        LongText_1 = q.LongText_1,
            //        LongText_2 = q.LongText_2,
            //        LongText_3 = q.LongText_3,
            //        LongText_4 = q.LongText_4,
            //        LongText_5 = q.LongText_5,
            //        LongText_6 = q.LongText_6,
            //        LongText_7 = q.LongText_7,
            //        LongText_8 = q.LongText_8,
            //        LongText_9 = q.LongText_9,
            //        LongText_10 = q.LongText_10
            //    }).ToList<object>();

            //    return lstProcData;
            //}
        }

        public List<ProcurementDocumentData> GetAllProcurementDocumentDataperprojectid(int projectid)
        {
            return _procurementDocumentDataRepository.GetAll().Where(pid => pid.ProjectID == projectid).ToList<ProcurementDocumentData>();
        }


        public ProcurementDocumentData GetProcurementDocumentDataByID(Int32 TaskID)
        {
            return _procurementDocumentDataRepository.GetSingle(d => d.TaskID == TaskID);
        }
        public void AddProcurementDocumentData(params ProcurementDocumentData[] ProcurementDocumentData)
        {

            _procurementDocumentDataRepository.Add(ProcurementDocumentData);

        }
        public void UpdateProcurementDocumentData(params ProcurementDocumentData[] ProcurementDocumentData)
        {
            _procurementDocumentDataRepository.Update(ProcurementDocumentData);
        }
        public void RemoveProcurementDocumentData(params ProcurementDocumentData[] ProcurementDocumentData)
        {
            try
            {
                _procurementDocumentDataRepository.Remove(ProcurementDocumentData);
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

        //public OperationResult checkUserRightsOnTask(int UserID, int TaskId)
        //{
        //    OperationResult result = new OperationResult();
        //    try
        //    {
        //        using (var db = new Cubicle_EntityEntities())
        //        {
        //            ProcurementDocumentData task = GetProcurementDocumentDataByID(TaskId);
        //            if (task != null)
        //            {
        //                BLUserRepository blUser = new BLUserRepository();
        //                User user = blUser.GetuserByID(UserID);
        //                if (task.DepatmentID != Convert.ToInt32(user.DepartmentID))
        //                {
        //                    BLProjectCreationRepository blProject = new BLProjectCreationRepository();
        //                    Project pr = blProject.GetProjectByID(task.ProjectID);
        //                    if (pr.ProjectLeader != UserID)
        //                    {
        //                        BLProjectsAdminRepository blProjectAdmin = new BLProjectsAdminRepository();
        //                        Boolean prAdmin = blProjectAdmin.IsProjectAdmin(Convert.ToInt32(task.ProjectID), Convert.ToInt32(UserID));
        //                        if (!prAdmin)
        //                        {
        //                            result.MessageType = "I";
        //                            result.Message = "You can not edit/delete this task.";
        //                        }
        //                        else
        //                        {
        //                            result.MessageType = "S";
        //                        }
        //                    }
        //                    else
        //                    {
        //                        result.MessageType = "S";
        //                    }
        //                }
        //                else
        //                {
        //                    result.MessageType = "S";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }

        //    return result;
        //}   

    }

}
