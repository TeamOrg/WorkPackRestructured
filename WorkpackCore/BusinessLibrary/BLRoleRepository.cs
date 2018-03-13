using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLRoleRepository : IBLRoleRepository
    {
        
        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<Role> _roleRepository;

        public BLRoleRepository(WorkpackDBContext context, IGenericDataRepository<Role> roleRepository)
        {
            _context = context;
            _roleRepository = roleRepository;
        }
        
        public IList<Role> GetAllRoles()
        {
            return _roleRepository.GetAll();
        } 
        public Role GetRoleByID(Int32 roleID)
        {
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties
            return _roleRepository.GetSingle(d => d.RoleID == roleID);                
                //include related employees
        }        
        public void AddRole(params Role[] role)
        {
            /* Validation and error handling omitted */
            try
            {
                _roleRepository.Add(role);
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

        public int GetRoleIDByRoleName(string roleName)
        {
            int RoleId = 0;
            //using (var Context = new Cubicle_EntityEntities())
            //{
            //    Role role = (from d in Context.Roles
            //                 where d.RoleName.ToUpper() == roleName.ToUpper()
            //                 select d).First();

            //    if (role != null)
            //    {
            //        RoleId = role.RoleID;
            //    }

                return RoleId;
            //}
        }
        

        public void UpdateRole(params Role[] role)
        {
            /* Validation and error handling omitted */
            try
            {
                _roleRepository.Update(role);
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
        public void RemoveRole(params Role[] role)
        {
            /* Validation and error handling omitted */
            try
            {
                _roleRepository.Remove(role);
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
        public Boolean CheckDuplicate(Role role,Boolean IsInsert)
        {
            Boolean Result = true;
            try
            {
                var c = _roleRepository.GetSingle(p => p.RoleName.ToUpper() == role.RoleName.ToUpper());
                if (!IsInsert)
                {
                    if (c == null)
                        Result = true;
                    else if (c.RoleID == role.RoleID)
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
        public IList<usp_GetRoleList_Result> GetRoleList(Role role)
        {
            IList<usp_GetRoleList_Result> fetchedRole = null;
            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<usp_GetRoleList_Result> query = Context.usp_GetRoleList().AsQueryable<usp_GetRoleList_Result>();
                //    if (role.RoleName != string.Empty)
                //        query = query.Where(p => p.RoleName.ToUpper().Contains(role.RoleName.ToUpper()));

                //    fetchedRole = query.ToList<usp_GetRoleList_Result>();
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
            return fetchedRole;
        }
    }
}
