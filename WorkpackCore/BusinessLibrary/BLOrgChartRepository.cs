using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLOrgChartRepository : IBLOrgChartRepository
    {
        public List<usp_ProjectsByUserIDForOrgChart_Result> getProjectList(int UserId, int projectAwaitedStatusID, int ProjectStatusArchived)
        {
            List<usp_ProjectsByUserIDForOrgChart_Result> lst = new List<usp_ProjectsByUserIDForOrgChart_Result>();
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_ProjectsByUserIDForOrgChart(UserId, projectAwaitedStatusID, ProjectStatusArchived).ToList<usp_ProjectsByUserIDForOrgChart_Result>();
                //}
            }
            catch(Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return lst;
        }

        public List<usp_ProjectLeaderByProject_Result> GetProjectLeader(int ProjectID)
        {
            List<usp_ProjectLeaderByProject_Result> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = context.usp_ProjectLeaderByProject(ProjectID).ToList<usp_ProjectLeaderByProject_Result>();
                //}
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw ex;
            }
            return lst;
        }

        public List<usp_FocalPointByProject_Result> GetProjectFocalPoints(int projectID)
        {
            List<usp_FocalPointByProject_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        lst = context.usp_FocalPointByProject(projectID).ToList<usp_FocalPointByProject_Result>();
            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw ex;
            //    }
            //}
            return lst;
        }

        public List<usp_TeamMembersByProject_Result> GetProjectTeamMembers(int ProjectID, int FocalPoint)
        {
            List<usp_TeamMembersByProject_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        lst = context.usp_TeamMembersByProject(ProjectID, FocalPoint).ToList<usp_TeamMembersByProject_Result>();
            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw ex;
            //    }
            //}
            return lst;
        }
        public List<usp_getMembersCountForProjectUnderFocalPt_Result> GetAllMembersCount(int ProjectID)
        {
            List<usp_getMembersCountForProjectUnderFocalPt_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    try
            //    {
            //        lst = context.usp_getMembersCountForProjectUnderFocalPt(ProjectID).ToList<usp_getMembersCountForProjectUnderFocalPt_Result>();
            //    }
            //    catch (Exception ex)
            //    {
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        throw ex;
            //    }
            //}
            return lst;
        }
    }
}
