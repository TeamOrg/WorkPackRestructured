using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{



    public class BLProgressLevelNotificationRoleRepository : IBLProgressLevelNotificationRoleRepository
    {
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<ProgressLevelNotificationRole> _roleRepository;

        public BLProgressLevelNotificationRoleRepository(WorkpackDBContext context, IGenericDataRepository<ProgressLevelNotificationRole> roleRepository)
        {
            _context = context;
            _roleRepository = roleRepository;
        }
        public IList<ProgressLevelNotificationRole> GetAllRoles()
        {
            return _roleRepository.GetAll();
        }


        public int GetRoleIDByRoleName(string RoleName)
        {
            int Roleid= 0;
            //using(var context = new Cubicle_EntityEntities())
            //{
            //   Roleid =  (from u in context.ProgressLevelNotificationRoles
            //                 where u.RoleName==RoleName
            //                 select u.RoleId).SingleOrDefault();
            //}
            return Roleid;
        }

        public List<ProgressLevelNotificationRole> GetAllProgressLevelNotificationRoleByRoleID(int RoleID)
        {
            List<ProgressLevelNotificationRole> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    lst = context.ProgressLevelNotificationRoles.Where(c => c.RoleId == (int)RoleID).ToList<ProgressLevelNotificationRole>();
            //}
            return lst;
        }
    }


}
