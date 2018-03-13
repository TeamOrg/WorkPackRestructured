using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLProgressLevelNotificationRepository : IBLProgressLevelNotificationRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProgressLevelNotification> _roleRepository;

        public BLProgressLevelNotificationRepository(WorkpackDBContext context, IGenericDataRepository<ProgressLevelNotification> roleRepository)
        {
            _context = context;
            _roleRepository = roleRepository;
        }

        public List<ProgressLevelNotification> GetAllProgressLevelNotificationByProjectMilestonesDocID(int ProjectMilestonesDocID)
        {
            List<ProgressLevelNotification> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProgressLevelNotifications.Where(c => c.ProjectMilestonesDocID == ProjectMilestonesDocID).ToList<ProgressLevelNotification>();
            //}
            return lst;
        }

        public ProgressLevelNotification GetProgressLevelNotificationByProjectMilestonesDocID(int ProjectMilestonesDocID)
        {
            try
            {
                return _roleRepository.GetSingle(d => d.ProjectMilestonesDocID == ProjectMilestonesDocID);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }

        public void AddProgressLevelNotification(params ProgressLevelNotification[] ProgressLevelNotification)
        {
            /* Validation and error handling omitted */
            try
            {
                _roleRepository.Add(ProgressLevelNotification);
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
        public void RemoveProgressLevelNotification(params ProgressLevelNotification[] ProgressLevelNotification)
        {
            try
            {
                _roleRepository.Remove(ProgressLevelNotification);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not deleted.");
            }
        }

        public List<List<string>> GetRolesByMilestonesIDandDocstageId(int MileStoneID, int DocstageID)
        {
            List<List<string>> lstUserRoles = new List<List<string>>();
            List<string> Roles = new List<string>();
            List<string> IntUser = new List<string>();
            List<string> ExtUser = new List<string>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int ProjectMilestonesDocID = context.ProjectMilestonesDocDetails.Where(a => a.DocStageID == DocstageID && a.ProjectMilestoneID == MileStoneID).Select(a => a.ProjectMilestonesDocID).FirstOrDefault();
            //    Roles = context.ProgressLevelNotifications.Where(a => a.ProjectMilestonesDocID == ProjectMilestonesDocID && a.RoleType == "R")
            //        .Join(context.ProgressLevelNotificationRoles, n => n.RoleId, r => r.RoleId, (n, r) => r.RoleName).ToList<string>();

                

            //    //int ProjectMilestonesDocID = context.ProjectMilestonesDocDetails.Where(a => a.DocStageID == DocstageID && a.ProjectMilestoneID == MileStoneID).Select(a => a.ProjectMilestonesDocID).FirstOrDefault();
            //    IntUser = context.ProgressLevelNotifications.Where(a => a.ProjectMilestonesDocID == ProjectMilestonesDocID && a.RoleType == "U").AsEnumerable().Select(a => a.RoleId.ToString()).ToList();

            //    ExtUser = (from p in context.ProgressLevelNotifications
            //              join q in context.ExUsers on p.RoleId equals q.ExUserID
            //              where p.ProjectMilestonesDocID == ProjectMilestonesDocID && p.RoleType == "E"
            //              select q.ExUser1).ToList();

            //    lstUserRoles.Add(Roles);
            //    lstUserRoles.Add(IntUser);
            //    lstUserRoles.Add(ExtUser);   
            //}

            return lstUserRoles;
        }        

        public List<string> GetIntUsersByMilestonesIDandDocstageId(int MileStoneID, int DocstageID)
        {

            List<string> IntUser = new List<string>();
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    int ProjectMilestonesDocID = context.ProjectMilestonesDocDetails.Where(a => a.DocStageID == DocstageID && a.ProjectMilestoneID == MileStoneID).Select(a => a.ProjectMilestonesDocID).FirstOrDefault();
            //    IntUser = context.ProgressLevelNotifications.Where(a => a.ProjectMilestonesDocID == ProjectMilestonesDocID && a.RoleType == "U").AsEnumerable().Select(a => a.RoleId.ToString()).ToList();

            //}

            return IntUser;
        }


    }
}
