using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;
using System.Data;

namespace BusinessLibrary
{
    public class BLResourceRequestDesignationRepository : IBLResourceRequestDesignationRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ResourceRequestDesignation> _resourceRequestDesignation;
        public BLResourceRequestDesignationRepository(WorkpackDBContext context, IGenericDataRepository<ResourceRequestDesignation> resourceRequestDesignation)
        {
            _context = context;
            _resourceRequestDesignation = resourceRequestDesignation;
        }








        public IList<ResourceRequestDesignation> GetAllResourceRequestDesignation()
        {
            return _resourceRequestDesignation.GetAll();
        }

        public List<ResourceRequestDesignation> GetAllResourceRequestDesignationByResourceRequest(int ResourceRequestID)
        {
            List<ResourceRequestDesignation> lst = null;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    lst = Context.ResourceRequestDesignations.Where(a => a.ResourceRequestID == ResourceRequestID).ToList<ResourceRequestDesignation>();
            //}
            return lst;
        }
        public DataTable GetActualResources(int ProjectID)
        {
            DataTable dtlist = null;// new DataTable(); ;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //   var list = (from RR in db.ResourceRequests
                //            join RA in db.ResourceAllocations on RR.ResourceRequestID equals RA.ResourceRequestID
                //            join U in db.Users on RA.UserID equals U.UserID
                //            join dep in db.Departments on RR.DepartmentID equals dep.DepartmentID
                //            join des in db.Designations on RR.DesignationID equals des.DesignationID
                //            join rl in db.Roles on RA.RoleID equals rl.RoleID
                //            where RR.ProjectID == ProjectID
                //            select new
                //            {
                //                UserName = (U.FirstName + " " + U.LastName),
                //                Department = dep.DepartmentName,
                //                Role = des.DesignationName,
                //                AllocatedManHrs = RA.AllocatedManHrs,
                //                FromDate = RA.allocatedFromDate,
                //                ToDate = RA.allocatedToDate
                //            }).ToList();
                //   dtlist = Common.GeneralFuntions.ConvertToDataTable(list);
                //}
            }
            catch (Exception ex)
            {
            }
            return dtlist;
        }
        public ResourceRequestDesignation GetResourceRequestDesignationByID(int ResourceRequestDesignationID)
        {
            return _resourceRequestDesignation.GetSingle(d => d.ResourceRequestDesnID == ResourceRequestDesignationID);
        }
        public void AddResourceRequestDesignation(params ResourceRequestDesignation[] ResourceRequestDesignation)
        {
            try
            {
                _resourceRequestDesignation.Add(ResourceRequestDesignation);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not added.");
            }
        }
        public void UpdateResourceRequestDesignation(params ResourceRequestDesignation[] ResourceRequestDesignation)
        {
            try
            {
                _resourceRequestDesignation.Update(ResourceRequestDesignation);
            }
            catch (Exception ex)
            {
                //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                throw new Exception("Record not updated.");
            }
        }
        public void RemoveResourceRequestDesignation(params ResourceRequestDesignation[] ResourceRequestDesignation)
        {
            try
            {
                _resourceRequestDesignation.Remove(ResourceRequestDesignation);
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

    }
}
