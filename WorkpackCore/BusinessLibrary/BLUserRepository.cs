using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using System.Net.Http;
using System.Collections;
using System.Net.Mail;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLUserRepository : IBLUserRepository
    {

        private readonly WorkpackDBContext _context;
        private readonly IGenericDataRepository<User> _userRepository;
        private readonly IBLCompanyRepository _companyRepository;
        private readonly IBLEmailTemplateRepository _emailTemplateRepository;
        private readonly IBLConfigFileRepository _configFileRepository;
        private readonly IBLEstimationTaskDetailRepository _estimationTaskDetailRepository;

        public BLUserRepository(WorkpackDBContext context, IGenericDataRepository<User> userRepository, IBLCompanyRepository companyRepository,
                                IBLEmailTemplateRepository emailTemplateRepository, IBLConfigFileRepository _configFileRepository, IBLEstimationTaskDetailRepository estimationTaskDetailRepository)
        {
            _context = context;
            _userRepository = userRepository;
            _companyRepository = companyRepository;
            _emailTemplateRepository = emailTemplateRepository;
            _estimationTaskDetailRepository = estimationTaskDetailRepository;
        }


        public IList<User> GetAllusers(int CompanyId)
        {
            List<User> lst = (from q in _context.User where q.CompanyId == CompanyId select q).ToList<User>();
            return lst;
        }

        public IList<User> GetAllusers()
        {
            IList<User> lst = null;
            // return _userRepository.GetAll().Where(c => c.CompanyId == Convert.ToInt32(HttpContent.Current.Session["CompanyId"])).ToList<User>();
            return lst;

        }

        //public List<object> GetAllWorkpackExternalusers()
        //{
        //    List<object> list = null;
        //    int? Companyid = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
        //    using (var context = new Cubicle_EntityEntities())
        //    {
        //       list= (from U in context.Users
        //             join D in context.Designations
        //             on U.DesignationID equals D.DesignationID
        //             join C in context.Companies
        //             on U.CompanyId equals C.CompanyId
        //             where U.CompanyId !=Companyid && U.Status=="A"
        //              select new 
        //              {
        //                  UserID = U.UserID,
        //                           UserName = U.FirstName +" "+ U.LastName +"-"+D.DesignationName +"-"+C.ComanyName +"-"+U.EmailID1
        //                          }).ToList<object>();

        //    }

        //   return list.ToList();
        //}
        public User GetuserByID(Int32 userID)
        {
            return _userRepository.GetSingle(d => d.UserID == userID);
        }

        public List<User> GetuserByID(params Int32[] userID)
        {
            List<User> lst = new List<User>();
            //using (var db = new Cubicle_EntityEntities())
            //{
            //    lst = db.Users.Where(a => userID.Contains(a.UserID)).ToList<User>();
            //}
            return lst;

        }

        public User GetuserByEmailID(string userID)
        {
            return _userRepository.GetSingle(d => d.EmailID1 == userID);
        }
       
        public OperationResult CreateOrEditUser(User vUser, UserRole[] userRole, int CompanyID, int UserId)
        {
            OperationResult opr = new OperationResult();
            int status = 0;
            User user = null;
            string strValidUser = CheckActiveUsersValidation(Convert.ToInt32(vUser.UserID), "", CompanyID);

            if (strValidUser != "" && strValidUser.Length > 1)
            {
                opr.Message = strValidUser;
                opr.MessageType = "E";
                return opr;
            }

            try
            {
                if (Convert.ToInt32(vUser.UserID) > 0)
                {
                    user = GetuserByID(Convert.ToInt32(vUser.UserID));
                }
                else
                    user = new User();

                string RoleList = GetSelectedRoles(userRole);
                if (RoleList == string.Empty)
                {
                    opr.Message = CommonLibrary.MessageConstants.SelectUserRole;
                    opr.MessageType = "E";
                    return opr;
                }

                user.FirstName = vUser.FirstName;
                user.LastName = vUser.LastName;
                user.CompanyId = CompanyID;
                user.Gender = vUser.Gender;
                user.IsDormantUser = "N";
                string imgPath = "";
                if (imgPath == string.Empty)
                {
                    imgPath = "~/UserImage/M.png";
                }
                user.ImagePath = imgPath.Replace(" ", "%20");
                if (Convert.ToInt32(user.UserID) == 0)
                {
                    user.UserCode = CommonLibrary.GeneralFuntions.GenerateRandomUserCode(vUser.FirstName.Trim(), 8);
                    user.Password = CommonLibrary.GeneralFuntions.Encrypt(CommonLibrary.GeneralFuntions.GenerateRandomPassword(vUser.LastName.Trim(), 8));
                    user.SysGenPwd = true;
                }

                user.EmailId = CommonLibrary.GeneralFuntions.Encrypt(vUser.EmailID1.ToLower());
                user.EmailID1 = vUser.EmailID1;
                user.DepartmentID = vUser.DepartmentID;
                user.DesignationID = vUser.DesignationID;
                user.EmpCode = "";
                user.Status = vUser.Status;
                user.ReportingTo = vUser.ReportingTo;
                user.CreatedBy =Convert.ToString(UserId);
                user.ModifiedBy = Convert.ToString(UserId);
                if (user.UserID == 0)
                {
                    user.MAxNotification = 20;
                    user.MaxAlert = 20;
                }
                
                User userByEmail = null;
                userByEmail = GetUserByEmailID(user.EmailId, Convert.ToInt32(user.UserID));
                if (userByEmail == null)
                {
                    bool sent = false;
                    if (user.UserID != 0)
                    {
                        user.EntityState = EntityState.Modified;
                        status = SaveNewUser(user, RoleList.Split(','));

                        opr.Message = CommonLibrary.MessageConstants.OperationSuccess;
                        opr.MessageType = "S";
                    }
                    else
                    {
                        user.EntityState = EntityState.Added;
                        status = SaveNewUser(user, RoleList.Split(','));
                        sent = SendEmail(user);

                        //Activity Tracker log 
                        _estimationTaskDetailRepository.ActivityTracker("User added from user creation form", "User Creation form ", Convert.ToString(UserId), "User added");

                        if (status > 0 && sent == true)
                        {
                            opr.Message = CommonLibrary.MessageConstants.OperationSuccess;
                            opr.MessageType = "S";
                        }
                        else
                        {
                            opr.Message = CommonLibrary.MessageConstants.EmailFailure;
                            opr.MessageType = "I";
                        }
                    }
                }
                else
                {
                    opr.Message = CommonLibrary.MessageConstants.DuplicateEmailID.Replace("#USER_NAME#", Convert.ToString(userByEmail.FirstName) + " " + Convert.ToString(userByEmail.LastName));
                    opr.MessageType = "E";
                }
            }
            catch (Exception ex)
            {
                // bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
                opr.Message = CommonLibrary.MessageConstants.errorMsg;
                opr.MessageType = "E";
            }

            return opr;
        }

        private string GetSelectedRoles(UserRole[] userRole)
        {
            string str = "";
            for (int i = 0; i < userRole.Length; i++)
            {
                int RoleID = Convert.ToInt32(userRole[i].RoleID);
                str = str + RoleID + ",";
            }
            return str.TrimEnd(',');
        }

        private bool SendEmail(User objUsers)
        {
            User dtUsers = null;
            bool sent = false;
            dtUsers = ValidateUser(objUsers.UserCode);
            if (SendEmailToUser(dtUsers))
            {
                sent = true;
            }
            else
            {
                sent = false;
            }
            return sent;
        }

        private Boolean SendEmailToUser(User dtUsers)
        {
            try
            {
                MailMessage message = new MailMessage();
                EmailTemplate objBEEmailTemplate = new EmailTemplate();
                ConfigFile dtEmailConfig = _configFileRepository.GetConfigFileByID(1);
                objBEEmailTemplate = _emailTemplateRepository.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.NewUserCreated);

                String emailDesc = objBEEmailTemplate.EmailTemplateMessage;
                String emailSubject = objBEEmailTemplate.EmailTemplateSubject;
                String emaildesctwo = objBEEmailTemplate.EmailTemplateMessage;
                String emaildescthree = objBEEmailTemplate.EmailTemplateMessage;
                String username = Convert.ToString(dtUsers.FirstName) + " " + Convert.ToString(dtUsers.LastName);
                MailAddress mailID = new MailAddress(CommonLibrary.GeneralFuntions.Decrypt(Convert.ToString(dtUsers.EmailId)), username);
                message.To.Add(mailID);
                String password = CommonLibrary.GeneralFuntions.Decrypt(dtUsers.Password);
                message.Subject = emailSubject;
                int companyid = Convert.ToInt32(dtUsers.CompanyId);
                Company c = _companyRepository.GetCompanyByCompanyID(companyid);
                User u = GetuserByID(Convert.ToInt32(dtUsers.CreatedBy));
                emailDesc = emailDesc.Replace("#CompanyName#", c.ComanyName);
                emailDesc = emailDesc.Replace("#AdminName#", u.FirstName + " " + u.LastName);
                emailDesc = emailDesc.Replace("#UserEmailID#", CommonLibrary.GeneralFuntions.Decrypt(Convert.ToString(dtUsers.EmailId)));
                emailDesc = emailDesc.Replace("#Password#", password);
                message.Body = emailDesc;
                return CommonLibrary.GeneralFuntions.SendEmailsWithAuthenticate(message, CommonLibrary.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtUsers);

            }
            catch (Exception ex)
            {
                //bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
                //Common.GeneralFuntions.ShowMessage("E", "", MessageConstants.errorMsg, 200, positionArray);
            }
            return false;
        }

        public List<object> GetAllusersForMatrix()
        {
            List<object> lst = null;
            try
            {
                //int companyid = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    lst = (from q in db.Users
                //           where q.CompanyId == companyid
                //           select new { FullName = q.FirstName + " " + q.LastName, UserID = q.UserID }).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
            }
            return lst;
        }
        public List<User> GetuserByName(string username)
        {

            List<User> uname = null;
            //Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties

            ////using (var context = new Cubicle_EntityEntities())
            ////{

            ////    try
            ////    {

            ////        string[] splitedname = username.Split(' ');

            ////        int companyid = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);

            ////        if (splitedname.Count() == 3)
            ////        {
            ////            uname = (from q in context.Users where (q.FirstName.ToUpper() ?? "") + " " + (q.MiddleName.ToUpper() ?? "") + " " + (q.LastName.ToUpper() ?? "") == username && q.CompanyId == companyid select q).ToList<User>();
            ////        }

            ////        else if (splitedname.Count() == 2)
            ////        {
            ////            uname = (from q in context.Users where (q.FirstName.ToUpper() ?? "") + " " + (q.LastName.ToUpper() ?? "") == username && q.CompanyId == companyid select q).ToList<User>();

            ////        }

            ////        else if (splitedname.Count() == 1)
            ////        {
            ////            uname = (from q in context.Users where (q.FirstName.ToUpper() ?? "") == username && q.CompanyId == companyid select q).ToList<User>();
            ////        }

            ////    }


            ////    catch (Exception ex)
            ////    {

            ////    }

            ////}
            return uname;
            //include related employees
        }


        public List<InternalUser> GetAllusersInternalModel()
        {
            List<InternalUser> lst = (from q in _userRepository.GetAll() select new InternalUser { UserID = q.UserID, FirstName = q.FirstName, LastName = q.LastName, UserCode = q.UserCode }).ToList<InternalUser>();
            return lst;
        }

        public static List<ExUser> GetExternalusers()
        {
            List<ExUser> list = null;
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{
                ////    list = (from u in db.ExUsers select u).ToList();
                ////}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        //ExUserTable Methods
        public static List<ExUser> GetClientEmailIds(string email)
        {
            List<ExUser> list = null;
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{
                ////    list = (from u in db.ExUsers where u.ExUser1.Contains(email) select u).ToList();
                ////}
            }
            catch (Exception ex)
            {
            }
            return list;
        }

        public static List<object> GetClientEmailsWithInternalUser(string email, int projectId, int companyId)
        {
            List<object> list = null;
            List<object> lst = null;
            List<object> res = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    BLUserRepository user = new BLUserRepository();
                //    lst = (from b in user.c_GetAllUsers(projectId)
                //           where b.FirstName.ToLower().Contains(email.ToLower()) || b.LastName.ToLower().Contains(email.ToLower())
                //           select new { label = b.FirstName + " " + b.LastName, value = b.FirstName + " " + b.LastName, UserId = b.UserID }).ToList<object>();


                //    list = (from a in db.ExUsers
                //            where   a.CompanyId==companyId && a.ExUser1.Contains(email)
                //            select new { label = a.ExUser1, value = a.ExUser1, UserId = a.ExUser1 }).ToList<object>();
                //    res = lst.Concat(list).ToList();

                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public static Boolean InsertExUsers(List<string> users, int CompanyID)
        {
            Boolean res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var list = from u in users where !db.ExUsers.Any(us => us.ExUser1 == u) select u;
                //    foreach (var l in list)
                //    {
                //        ExUser exu = new ExUser();
                //        exu.ExUser1 = l;
                //        exu.CompanyId = CompanyID;
                //        db.Entry(exu).State = System.Data.EntityState.Added;
                //        db.SaveChanges();

                //    }
                //    res = true;
                //}
            }
            catch (Exception ex)
            {
            }
            return res;
        }

        public String GetUserFullName(Int32 userID)
        {


            String strUserName = "";
            if (userID > 0)
            {
                User user = _userRepository.GetSingle(d => d.UserID == userID);
                strUserName = user.FirstName + "  " + user.LastName;
            }
            return strUserName;
        }

        public static string GetUserNameById(string UserID)
        {
            string res = "";
            try
            {
                if (UserID.Contains('@'))
                {
                    res = UserID;
                }
                else
                {
                    int uid = Convert.ToInt32(UserID);
                    //using (var db = new Cubicle_EntityEntities())
                    //{
                    //    var list = (from u in db.Users where u.UserID == uid select u.FirstName + " " + u.LastName).FirstOrDefault();
                    //    res = list;

                    //}
                }
            }
            catch (Exception ex)
            {
            }
            return res;
        }




        public User GetUserDetailsbyID(int UserId)
        {
            User obj = null;

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    obj = db.Users.FirstOrDefault(p => p.UserID == UserId); //&& p.Locked != 1 && p.Status == "A");                   
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }
        public int GetAdminUserID(int CompanyId)
        {
            //BLRoleRepository objRole = new BLRoleRepository();
            int userId = 0;
            try
            {
                //int RoleID = objRole.GetRoleIDByRoleName("Administrator");
                ////using (var Context = new Cubicle_EntityEntities())
                ////{
                ////    userId = (from ur in Context.UserRoles
                ////              join u in Context.Users on ur.UserID equals u.UserID
                ////              where u.CompanyId == CompanyId && ur.RoleID == RoleID
                ////              select u.UserID).FirstOrDefault();
                ////}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return userId;
        }

        public List<object> GetResourceManagerRoleUsers(int CompanyId, int DeptID)
        {
            //BLRoleRepository objRole = new BLRoleRepository();
            List<object> users = null;
            try
            {
                //int RoleID = objRole.GetRoleIDByRoleName("Resource Manager");
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    users = (from ur in Context.UserRoles
                //             join u in Context.Users on ur.UserID equals u.UserID
                //             where u.CompanyId == CompanyId && ur.RoleID == RoleID && u.DepartmentID == DeptID
                //             select new { UserID = u.UserID, UserName = u.FirstName + " " + u.LastName }).ToList<object>();
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return users;
        }


        public void Adduser(params User[] user)
        {
            /* Validation and error handling omitted */
            try
            {
                _userRepository.Add(user);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void Updateuser(params User[] user)
        {
            /* Validation and error handling omitted */
            try
            {
                _userRepository.Update(user);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }
        public void Removeuser(params User[] user)
        {
            /* Validation and error handling omitted */
            try
            {
                _userRepository.Remove(user);
            }
            catch (Exception ex)
            {
                throw ex;
                //////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
        }

        public IList<usp_getUserList_Result> GetuserList(User user)
        {
            IList<usp_getUserList_Result> fetcheduser = null;
            try
            {
                fetcheduser = new List<usp_getUserList_Result>();
                //using (_context)
                //{
                    IQueryable<usp_getUserList_Result> query = _context.usp_getUserList(0, 0, user.CompanyId).ToList<usp_getUserList_Result>().AsQueryable();
                    if (user.EmpCode!= null && user.EmpCode != string.Empty)
                        query = query.Where(p => p.EmpCode.ToUpper().Contains(user.EmpCode.ToUpper()));
                    if (user.FirstName != null && user.FirstName != string.Empty)
                        query = query.Where(p => p.FirstName.ToUpper().Contains(user.FirstName.ToUpper()));
                    if (user.MiddleName != null && user.MiddleName != string.Empty)
                        query = query.Where(p => p.MiddleName.ToUpper().Contains(user.MiddleName.ToUpper()));
                    if (user.LastName != null && user.LastName != string.Empty)
                        query = query.Where(p => p.LastName.ToUpper().Contains(user.LastName.ToUpper()));
                    if (user.DepartmentID != null && user.DepartmentID != 0)
                        query = query.Where(p => p.DepartmentID == user.DepartmentID);
                    if (user.DesignationID != null && user.DesignationID != 0)
                        query = query.Where(p => p.DesignationID == user.DesignationID);
                    if (user.CompanyId != null && user.CompanyId != 0)
                        query = query.Where(p => p.CompanyId == user.CompanyId);

                    fetcheduser = query.ToList();
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return fetcheduser;
        }




        public void ImportSandboxTestingProjectDate(string companyName, Nullable<int> companyID, Nullable<int> userID)
        {
            try
            {

                ////using (var Context = new Cubicle_EntityEntities())
                ////{
                ////    using (var context = new Cubicle_EntityEntities())
                ////    {
                ////        context.USP_IMPORT_DEFAULT_PROJECTDATA(companyName, companyID, userID);
                ////    }
                ////}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
        }



        public int GetExUserCompanyID(string EmailID)
        {
            int CompanyID = 0;

            try
            {

                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    using (var context = new Cubicle_EntityEntities())
                //    {
                //        var ExUser = context.SP_GET_EXUSER_DETAIL().Where(a => a.ExUser.ToUpper() == EmailID.ToUpper()).ToList<SP_GET_EXUSER_DETAIL_Result>().FirstOrDefault();
                //        CompanyID = Convert.ToInt32(ExUser.CompanyId);
                //    }
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return CompanyID;
        }



        public IList<usp_getUserList_Result> GlobalGetuserList(User user)
        {
            IList<usp_getUserList_Result> fetcheduser = null;
            try
            {
                fetcheduser = new List<usp_getUserList_Result>();
                //using (var Context = new Cubicle_EntityEntities())
                //{
                //    IQueryable<usp_getUserList_Result> query = Context.usp_getUserList(0, 0, 0).ToList<usp_getUserList_Result>().AsQueryable();
                //    if (user.EmpCode != string.Empty)
                //        query = query.Where(p => p.EmpCode.ToUpper().Contains(user.EmpCode.ToUpper()));
                //    if (user.FirstName != string.Empty)
                //        query = query.Where(p => p.FirstName.ToUpper().Contains(user.FirstName.ToUpper()));
                //    if (user.MiddleName != string.Empty)
                //        query = query.Where(p => p.MiddleName.ToUpper().Contains(user.MiddleName.ToUpper()));
                //    if (user.LastName != string.Empty)
                //        query = query.Where(p => p.LastName.ToUpper().Contains(user.LastName.ToUpper()));
                //    if (user.DepartmentID != 0)
                //        query = query.Where(p => p.DepartmentID == user.DepartmentID);
                //    if (user.DesignationID != 0)
                //        query = query.Where(p => p.DesignationID == user.DesignationID);
                //    if (user.EmailID1 != string.Empty)
                //        query = query.Where(p => p.EmailId == Common.GeneralFuntions.Encrypt(user.EmailID1.ToLower()));
                //    if (user.MobileNo != string.Empty)
                //        query = query.Where(p => p.MobileNo == user.MobileNo);
                //    if (user.CompanyId != 0)
                //        query = query.Where(p => p.CompanyId == user.CompanyId);

                //    fetcheduser = query.ToList();
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return fetcheduser;
        }





        public IList<usp_getUserList_Result> c_GetAllUsers(int projectid = 0)
        {
            List<usp_getUserList_Result> list = null;
            try
            {
                //int iCompanyID = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                //list = new List<usp_getUserList_Result>();
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getUserList(0, projectid, iCompanyID).ToList<usp_getUserList_Result>();
                //}
            }
            catch (Exception ex)
            {
                // ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public IList<usp_getUserList_Result> c_GetAllStakeHolder(int MilestoneID, int TaskID)
        {
            List<usp_getUserList_Result> list = null;
            try
            {
                ////int iCompanyID = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
                ////BLDeliverableListRepository bldel = new BLDeliverableListRepository();
                ////ProjectTaskList pt = bldel.getTaskDetailsByTaskId(TaskID);
                ////list = new List<usp_getUserList_Result>();
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    list = context.usp_getUserList(0, pt.ProjectID, iCompanyID).ToList<usp_getUserList_Result>();


                ////}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return list;
        }

        public IList<User> GetUsersByDepartment(int DepartmentID, int Projectid = 0)
        {
            IList<User> List = new List<User>();
            try
            {
                //BLExtProjectMemberRepository blepmr = new BLExtProjectMemberRepository();
                if (DepartmentID > 0)
                {
                    List = _userRepository.GetList(p => p.DepartmentID == DepartmentID);
                }
                else if (Projectid > 0)
                {
                    //List = GetAllusers().Union(blepmr.GetExternalMember(Projectid, false)).ToList<User>(); ;


                }
                else
                {
                    List = GetAllusers();
                }
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;
        }

        public List<int> GetLimitedusers()
        {
            List<int> lst = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{

            ////    lst = (from t in context.Users where t.Status == "A" && t.IsDormantUser == "Y" select t.UserID).ToList<int>();
            ////}





            return lst;
        }

        public ArrayList GetNoOfLimitedUsers()
        {

            ArrayList objarray = new ArrayList();
            IList<User> List = new List<User>();
            try
            {
                List = _userRepository.GetList(p => p.Status == "A");
                if (List.Count > 0)
                {
                    objarray.Add(List.Where(a => a.IsDormantUser == "N").Count());
                    objarray.Add(List.Where(a => a.IsDormantUser == "Y").Count());
                }
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return objarray;
        }


        public string CheckActiveUsersValidation(int userID, string mode, int CompanyId)
        {
            string validNoOfUsers = "";
            int ActiveUser = 0;
            IList<User> List = new List<User>();
            List = _userRepository.GetList(p => p.Status == "A" && p.CompanyId == CompanyId);
            Company com = _companyRepository.GetCompanyByCompanyID(CompanyId);
            ActiveUser = List.Count();
            if (userID == 0 && mode == "login")
            {
                ActiveUser = ActiveUser + 1;
            }
            if (ActiveUser > com.LicencesNumber)
            {
                validNoOfUsers = "Number of active user  licenses (" + com.LicencesNumber + ") has been exceeded.Please contact sales for new licenses.";
            }
            return validNoOfUsers;
        }






        public string CheckLimitedUsers()
        {
            string validNoOfUsers = "";
            //ArrayList objarray = new ArrayList();
            //int LimitedUser = Common.MessageConstants.LimitedUser;
            //int NormalUser = Common.MessageConstants.NormalUser;
            //objarray = GetNoOfLimitedUsers();
            //if (objarray.Count == 2)
            //{
            //    if (Convert.ToInt32(objarray[0]) > NormalUser)
            //    {

            //        validNoOfUsers = "Number of active user  licenses (" + Convert.ToInt32(objarray[0]) + ") has been exceeded.Please contact sales for new licenses.";
            //    }
            //    else if (Convert.ToInt32(objarray[1]) > LimitedUser)
            //    {
            //        validNoOfUsers = " Number of limited user licenses (" + Convert.ToInt32(objarray[1]) + ") has been exceeded.Please contact sales for new licenses.";
            //    }
            //}
            return validNoOfUsers;
        }




        public static IList<User> GetUsersInMonth(DateTime Month, int DepartmentID, int DesignationID)
        {
            DateTime fDate = new DateTime(Month.Year, Month.Month, 1);
            DateTime eDate = fDate.AddMonths(1).AddDays(-1);
            IList<User> userList = null;
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{

                ////    userList = (from u in db.Users
                ////                where u.DepartmentID == (DepartmentID == 0 ? u.DepartmentID : DepartmentID)
                ////                     && u.DesignationID == (DesignationID == 0 ? u.DesignationID : DesignationID)
                ////                    && u.Status == "A" && u.JoiningDate <= eDate
                ////                select u).ToList<User>();
                ////}
            }
            catch (Exception ex)
            {
            }
            return userList;
        }

        public static List<decimal> GetUserAvailablityInMonth(List<User> uList, DateTime Month)
        {
            DateTime fDate = new DateTime(Month.Year, Month.Month, 1);
            DateTime eDate = fDate.AddMonths(1).AddDays(-1);
            List<decimal> userCount = null;
            try
            {
                userCount = new List<decimal>();
                ////using (var db = new Cubicle_EntityEntities())
                ////{
                ////    foreach (var u in uList)
                ////    {
                ////        var userLeave = from c in
                ////                            (from l in db.Leaves
                ////                             where (l.FromDate >= fDate)
                ////                                 && (l.ToDate <= eDate) && l.UserID == u.UserID && l.ApprovedBY > 0
                ////                             select new
                ////                             {
                ////                                 FromDate = (l.FromDate.Month == fDate.Month && l.FromDate.Year == fDate.Year) ? l.FromDate : fDate.Date,
                ////                                 ToDate = (l.ToDate.Month == eDate.Month && l.ToDate.Year == eDate.Year) ? l.ToDate : eDate.Date,
                ////                                 l.IsHalfDay,
                ////                                 l.UserID,
                ////                             })
                ////                        select new
                ////                        {
                ////                            NoDays = c.IsHalfDay == "N" ? c.ToDate.Day - c.FromDate.Day : 0.5
                ////                        };
                ////        double AvailableUser = userLeave.Count() == 0 ? 1 : userLeave.Sum(p => p.NoDays) == 0 ? 1 : 1 - (userLeave.Sum(p => p.NoDays) / DateTime.DaysInMonth(fDate.Year, fDate.Month));
                ////        userCount.Add(Convert.ToDecimal(AvailableUser));
                ////    }
                ////}
            }
            catch (Exception ex)
            {
            }
            return userCount;
        }

        public User GetDeptFocalPoint(int DepartmentID)
        {
            User obj = null;
            try
            {
                obj = _userRepository.GetSingle(p => p.FocalPoint == "1" && p.DepartmentID == DepartmentID);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }


        public User GetUserByEmailID(string EmailID, int UserID)
        {
            User obj = null;
            // int CompanyID = Convert.ToInt32(HttpContext.Current.Session["CompanyId"]);
            try
            {
                if (UserID == 0)
                {
                    obj = _userRepository.GetSingle(p => p.EmailId == EmailID);
                }
                else
                {
                    obj = _userRepository.GetSingle(p => p.EmailId == EmailID && p.UserID != UserID);
                }
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }

        public User GetUserByMobileNumber(string Mobile, int UserID)
        {
            User mob = null;
            try
            {
                if (UserID == 0)
                {
                    mob = _userRepository.GetSingle(p => p.MobileNo == Mobile);
                }
                else
                {
                    mob = _userRepository.GetSingle(p => p.MobileNo == Mobile && p.UserID != UserID);
                }
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return mob;
        }



        public User GetUserByEmpCode(string EmpCode)
        {
            User obj = null;
            try
            {
                obj = _userRepository.GetSingle(p => p.EmpCode == EmpCode);
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }

        public IList<usp_getUserRoleAssigned_Result> GetAllRolesByUser(int UserID)
        {
            IList<usp_getUserRoleAssigned_Result> List = new List<usp_getUserRoleAssigned_Result>();
            try
            {
               List = _context.usp_getUserRoleAssigned(UserID).ToList<usp_getUserRoleAssigned_Result>();
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return List;
        }


        public Boolean IsLoggedInUserAdmin(int UserID)
        {
            Boolean IsAdmin = false;
            //BLUserRepository UserRoleList = new BLUserRepository();
            //BLRoleRepository objRole = new BLRoleRepository();
            //IList<usp_getUserRoleAssigned_Result> List = null;
            //int AdminRoleID = objRole.GetRoleIDByRoleName("Administrator");
            //List = UserRoleList.GetAllRolesByUser(UserID);
            //List = List.Where(a => a.RoleID == AdminRoleID && a.RoleAssigned > 0).ToList<usp_getUserRoleAssigned_Result>();
            //if (List.Count() > 0)
            //{
            //    IsAdmin = true;
            //}

            return IsAdmin;
        }

        public Boolean IsLoggedInUserProjManager(int UserID)
        {
            Boolean IsProjManager = false;
            //BLProjectCreationRepository ProjList = new BLProjectCreationRepository();
            //BLUserRepository UserRoleList = new BLUserRepository();
            //BLRoleRepository objRole = new BLRoleRepository();
            //IList<usp_getUserRoleAssigned_Result> List = null;
            //int ProjManagerRoleID = objRole.GetRoleIDByRoleName("Project Manager");
            //List = UserRoleList.GetAllRolesByUser(UserID);
            //List = List.Where(a => a.RoleID == ProjManagerRoleID && a.RoleAssigned > 0).ToList<usp_getUserRoleAssigned_Result>();
            //if (List.Count() > 0)
            //{
            //    IsProjManager = true;
            //}
            return IsProjManager;
        }






        public User ValidateUser(string UserCode)
        {
            User obj = null;
            try
            {
                obj = _userRepository.GetSingle(p => p.UserCode == UserCode && p.Status == "A");
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }
        public int SaveNewUser(User objUser, string[] RoleList)
        {
            int res = 0;

            try
            {
                using (_context)
                {
                    _context.User.Attach(objUser);
                    _context.Entry(objUser).State = objUser.EntityState == EntityState.Added ? Microsoft.EntityFrameworkCore.EntityState.Added : Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _context.SaveChanges();
                    res = objUser.UserID;
                    if (!InsertUserRole(RoleList, res))
                    {
                        res = 0;
                        throw new Exception("An error occured.");
                    }

                }
            }
            catch (Exception ex)
            {

                res = 0;
                //bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }

            return res;
        }




        public string SaveRegisterUser(User objUser, string isCheckBoxChecked)
        {
            int UserID = 0;
            int RoleID = 0;
            string strRole = "";
            // BLRoleRepository objRole = new BLRoleRepository();

            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    context.Users.Attach(objUser);
                //    context.Entry(objUser).State = objUser.EntityState == EntityState.Added ? System.Data.EntityState.Added : System.Data.EntityState.Modified;
                //    context.SaveChanges();
                //    UserID = objUser.UserID;
                //    if (isCheckBoxChecked == "")
                //    {
                //        RoleID = objRole.GetRoleIDByRoleName("Administrator");
                //        InsertRegisterUserRole(RoleID, UserID);
                //        strRole = Convert.ToString(RoleID);
                //        RoleID = objRole.GetRoleIDByRoleName("Project Manager");
                //        InsertRegisterUserRole(RoleID, UserID);
                //        strRole = strRole + "," + Convert.ToString(RoleID);

                //    }
                //    if (isCheckBoxChecked == "N")
                //    {
                //        RoleID = objRole.GetRoleIDByRoleName("Document Owner");
                //        InsertRegisterUserRole(RoleID, UserID);
                //        strRole = Convert.ToString(RoleID);
                //    }
                //    if (isCheckBoxChecked == "Y")
                //    {
                //        RoleID = objRole.GetRoleIDByRoleName("Document Owner");
                //        InsertRegisterUserRole(RoleID, UserID);
                //        strRole = Convert.ToString(RoleID);
                //        RoleID = objRole.GetRoleIDByRoleName("Project Manager");
                //        InsertRegisterUserRole(RoleID, UserID);
                //        strRole = strRole + "," + Convert.ToString(RoleID);
                //    }

                //}
            }
            catch (Exception ex)
            {

                UserID = 0;
                //  bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }

            return strRole;
        }




        public Boolean InsertUserRole(string[] RoleList, int UserId)
        {
            Boolean res = false;

            try
            {
                using (_context)
                {
                    foreach (var a in _context.UserRole.Where(p => p.UserID == UserId))
                    {
                        _context.UserRole.Remove(a);
                    }
                    _context.SaveChanges();
                    foreach (var val in RoleList)
                    {
                        UserRole obj = new UserRole { UserID = UserId, RoleID = Convert.ToInt32(val) };
                        _context.UserRole.Add(obj);
                    }
                    _context.SaveChanges();
                }

                res = true;
            }
            catch (Exception ex)
            {

                res = false;
                // bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }

            return res;
        }





        public Boolean InsertRegisterUserRole(int RoleID, int UserId)
        {
            Boolean res = false;

            try
            {
                //using (var Context = new Cubicle_EntityEntities())
                //{

                //    UserRole obj = new UserRole { UserID = UserId, RoleID = Convert.ToInt32(RoleID) };
                //    Context.UserRoles.Add(obj);
                //    Context.SaveChanges();
                //    res = true;
                //}

            }
            catch (Exception ex)
            {

                res = false;
                //  bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
                throw ex;
            }

            return res;
        }





        public static ArrayList getResourceManagerByProjectIdAndDeptId(int projectId, int DeptID)
        {
            ArrayList aUserID = new ArrayList();
            //IUserRepository _userResource = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var user = (from q in context.ResourceRequests where q.DepartmentID == DeptID && q.ProjectID == projectId select q).FirstOrDefault();
                //    if (user != null)
                //    {
                //        aUserID.Add(user.ResourceManagerID);
                //    }
                //}
            }
            catch (Exception ex)
            {

            }
            return aUserID;
        }



        public static ArrayList isDepartmentHeadUserID(int DeptID)
        {
            ArrayList aUserID = new ArrayList();
            //IUserRepository _userResource = null;
            try
            {
                //_userResource = new UserRepository();
                //var user = _userResource.GetList(u => u.FocalPoint == "1" && u.DepartmentID == @DeptID).SingleOrDefault();
                //if (user != null)
                //{
                //    aUserID.Add(user.UserID);
                //    aUserID.Add(user.FirstName + ' ' + user.LastName);
                //}
            }
            catch (Exception ex)
            {

            }
            return aUserID;
        }
        public static ArrayList AllocatedUserID(int DeptID, int RequestID, int ProjectID)
        {
            ArrayList aUserID = new ArrayList();
            List<ResourceAllocation> lst = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    lst = (from ra in context.ResourceAllocations
                //           join rr in context.ResourceRequests on ra.ResourceRequestID equals rr.ResourceRequestID
                //           where rr.ProjectID == ProjectID && rr.RequestID == RequestID && rr.DepartmentID == DeptID
                //           select ra).Distinct().ToList<ResourceAllocation>();
                //    foreach (var item in lst)
                //    {
                //        if (!aUserID.Contains(item.UserID))
                //        {
                //            aUserID.Add(item.UserID);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return aUserID;
        }

        public static Boolean UpdateMaxAlertORNotification(Int32 userID, int Max, String MaxAlert)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var user = context.Users.FirstOrDefault(p => p.UserID == userID);
                //    if (user != null)
                //    {
                //        if (MaxAlert == "MAxNotification")
                //            user.MAxNotification = Max;
                //        else
                //            user.MaxAlert = Max;
                //        context.Entry(user).State = System.Data.EntityState.Modified;
                //        context.SaveChanges();
                //        res = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public static int GetMaxAlertORNotification(Int32 userID, String MaxAlert)
        {
            int res = 0;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    if (MaxAlert == "MaxAlert")
                ////        res = context.Users.Where(u => u.UserID == userID).Max(p => p.MaxAlert).GetValueOrDefault();
                ////    else
                ////        res = context.Users.Where(u => u.UserID == userID).Max(p => p.MAxNotification).GetValueOrDefault();

                ////}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }


        public User ValidUserEmail(string Email)
        {
            User obj = null;

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    obj = db.Users.FirstOrDefault(p => p.EmailId == Email); //&& p.Locked != 1 && p.Status == "A");                   
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }


        public User ValidUserEmailForGoogle(string Email)
        {
            User obj = null;

            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    obj = db.Users.FirstOrDefault(p => p.EmailID1 == Email && p.CreatedBy == "GoogleAccount"); //&& p.Locked != 1 && p.Status == "A");                   
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return obj;
        }

        private Boolean SendEmailToUserForChangedPassword(string NewPassowrd, User dtUsers)
        {
            //MailMessage message = new MailMessage();
            //BLEmailTemplateRepository objBLEmailTemplate = new BLEmailTemplateRepository();
            ////BLEmailTemplate objBLEmailTemplate = new BLEmailTemplate();
            //EmailTemplate objBEEmailTemplate = new EmailTemplate();
            //BLConfigFileRepository objConfig = new BLConfigFileRepository();
            //ConfigFile dtEmailConfig = objConfig.GetAllConfigFiles().FirstOrDefault();
            //User dtAdminData = dtUsers;

            //EmailTemplate dtEmailTemplate = objBLEmailTemplate.LoadEmailTemplateDesc(BLEmailTemplateRepository.enu_EmailTemplate.ForgotPassword);

            //String emailDesc = Convert.ToString(dtEmailTemplate.EmailTemplateMessage);
            //String emailSubject = Convert.ToString(dtEmailTemplate.EmailTemplateSubject);
            //String emaildesctwo = Convert.ToString(dtEmailTemplate.EmailTemplateMessage);
            //String emaildescthree = Convert.ToString(dtEmailTemplate.EmailTemplateMessage);

            //String username = Convert.ToString(dtUsers.FirstName) + " " + Convert.ToString(dtUsers.LastName);
            //MailAddress mailID = new MailAddress(Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)), username);
            //message.To.Add(mailID);
            //message.Subject = emailSubject;
            //emailDesc = emailDesc.Replace("#ToName#", username);
            //emailDesc = emailDesc.Replace("#UserEmailId#", Common.GeneralFuntions.DecryptString(Convert.ToString(dtUsers.EmailId)));
            //emailDesc = emailDesc.Replace("#UserPassword#", NewPassowrd);
            //message.Body = emailDesc;
            //return Common.GeneralFuntions.SendEmailsWithAuthenticate(message, Common.GeneralFuntions.EmailFor.Other, dtEmailConfig, dtAdminData);
            return false;

        }

        public Boolean CreateNewPassword_ForgetPwd(User objUser)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    String n_Password = String.Empty;
            //    String userEmail = Common.GeneralFuntions.DecryptString(Convert.ToString(objUser.EmailId));
            //    String o_Password = Common.GeneralFuntions.DecryptString(Convert.ToString(objUser.Password));
            //    try
            //    {
            //        n_Password = Common.GeneralFuntions.GenerateRandomPassword(userEmail, 8);
            //        using (var db = new Cubicle_EntityEntities())
            //        {
            //            ManagePassword managePwd = new ManagePassword();
            //            managePwd.LogType = "U";
            //            managePwd.EmailId = Convert.ToString(objUser.EmailId);
            //            managePwd.Password = Convert.ToString(objUser.Password);
            //            managePwd.UserCode = Convert.ToString(objUser.UserID);
            //            managePwd.CreatedBy = Convert.ToString(objUser.UserID);
            //            managePwd.CreatedOn = System.DateTime.Now;
            //            db.Entry(managePwd).State = System.Data.EntityState.Added;
            //            db.SaveChanges();
            //            var user = db.Users.FirstOrDefault(p => p.UserID == objUser.UserID);
            //            user.Password = Common.GeneralFuntions.Encrypt(n_Password);
            //            user.ModifiedBy = Convert.ToString(objUser.UserID);
            //            user.ModifiedOn = System.DateTime.Now;
            //            user.SysGenPwd = true;
            //            db.Entry(user).State = System.Data.EntityState.Modified;
            //            db.SaveChanges();
            //            if (SendEmailToUserForChangedPassword(n_Password, objUser))
            //            {
            //                res = true;
            //                ts.Complete();
            //            }
            //            else
            //            {
            //                res = false;
            //                ts.Dispose();
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        res = false;
            //        ts.Dispose();
            //        ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return res;
        }

        public static Boolean LockUserAccess(string userEmailID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var user = context.Users.FirstOrDefault(p => p.EmailId == userEmailID && p.Status == "A");
                //    if (user != null)
                //    {
                //        user.Locked = 1;
                //        user.AttemptCount = 0;
                //        context.Entry(user).State = System.Data.EntityState.Modified;
                //        context.SaveChanges();
                //        res = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public static Boolean UpdateAttemptCount(String userEmailId)
        {
            Boolean res = false;
            try
            {

                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var user = context.Users.FirstOrDefault(p => p.EmailId == userEmailId && p.Status == "A");
                //    if (user != null)
                //    {
                //        user.AttemptCount = user.AttemptCount + 1;
                //        context.Entry(user).State = System.Data.EntityState.Modified;
                //        context.SaveChanges();
                //        res = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }

        public static Boolean checkIsAdmin(int UserID, string AdminUser)
        {
            Boolean res = false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var val = from n in db.UserRoles
                //              where (n.RoleID == (from n2 in db.Roles where n2.RoleName == AdminUser select n2.RoleID).FirstOrDefault() &&
                //              n.UserID == UserID)
                //              select n;
                //    if (val != null)
                //    {
                //        if (val.Count() > 0)
                //            res = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }

        public static Boolean UpdateLogInTime(Int32 userID, String ipAddress)
        {
            Boolean res = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var user = context.Users.FirstOrDefault(p => p.UserID == userID);
            //    if (user != null)
            //    {
            //        user.LogIn = DateTime.Now;
            //        user.LoggedIPAddress = ipAddress;
            //        user.ModifiedBy = Convert.ToString(HttpContext.Current.Session["UserID"]);
            //        user.ModifiedOn = DateTime.Now;
            //        context.Entry(user).State = System.Data.EntityState.Modified;
            //        context.SaveChanges();
            //        res = true;
            //    }
            //}

            return res;
        }
        public static Boolean UpdateLogOutTime(Int32 userID)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var user = context.Users.FirstOrDefault(p => p.UserID == userID);
                //    if (user != null)
                //    {
                //        user.LogOut = DateTime.Now;
                //        user.ModifiedBy = Convert.ToString(HttpContext.Current.Session["UserID"]);
                //        user.ModifiedOn = DateTime.Now;
                //        context.Entry(user).State = System.Data.EntityState.Modified;
                //        context.SaveChanges();
                //        res = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                if (false)
                {
                    throw ex;
                }
            }
            return res;
        }
        public static Boolean SetAttemptCountToZero(String userEmailId)
        {
            Boolean res = false;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    var user = context.Users.FirstOrDefault(p => p.EmailId == userEmailId && p.Status == "A");
            //    if (user != null)
            //    {
            //        user.AttemptCount = 0;
            //        context.Entry(user).State = System.Data.EntityState.Modified;
            //        context.SaveChanges();
            //        res = true;
            //    }
            //}
            return res;
        }
        public Boolean CreateNewPassword_ChangePassword(User objUser, ManagePassword objManagePassword)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var db = new Cubicle_EntityEntities())
            //        {
            //            db.Entry(objManagePassword).State = System.Data.EntityState.Added;
            //            db.SaveChanges();
            //            db.Entry(objUser).State = System.Data.EntityState.Modified;
            //            db.SaveChanges();
            //            res = true;
            //            ts.Complete();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return res;
        }

        public static bool upgradeDatabase(string sqlQuery)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var db = new Cubicle_EntityEntities())
            //        {
            //            db.Database.ExecuteSqlCommand(sqlQuery);
            //            db.SaveChanges();
            //            res = true;
            //            ts.Complete();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //    }
            //}
            return res;
        }

        public static usp_getUserList_Result UserDetails(int UserID)
        {
            usp_getUserList_Result val = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    val = db.usp_getUserList(UserID, 0, 0).ToList<usp_getUserList_Result>().FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
            }
            return val;
        }

        public static List<SP_SHOW_PRE_SUCC_TASK_Result> ShowPreCussTask(Int32 tASKID)
        {
            List<SP_SHOW_PRE_SUCC_TASK_Result> val = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    val = db.SP_SHOW_PRE_SUCC_TASK(tASKID).ToList<SP_SHOW_PRE_SUCC_TASK_Result>();
                //}
            }
            catch (Exception ex)
            {
            }
            return val;
        }

        public List<usp_getPlanningEnginner_Result> getPlanningEnginner()
        {
            List<usp_getPlanningEnginner_Result> lst = null;
            try
            {
                ////using (var db = new Cubicle_EntityEntities())
                ////{
                ////    lst = db.usp_getPlanningEnginner().ToList<usp_getPlanningEnginner_Result>();
                ////}
            }
            catch (Exception ex)
            {
            }
            return lst;
        }

        public List<object> GetNormsFieldData(string key)
        {
            List<object> res = null;
            ////using (var context = new Cubicle_EntityEntities())
            ////{

            ////    try
            ////    {
            ////        res = (from q in context.Users
            ////               where q.FirstName.ToUpper().Contains(key.ToUpper())
            ////               select new
            ////               {
            ////                   id = q.UserID,
            ////                   text = q.FirstName + " " + q.LastName
            ////               }).ToList<object>();
            ////    }
            ////    catch (Exception ex)
            ////    {

            ////    }

            ////}
            return res;
        }

        public List<usp_getDynamicAutocompleteData_Result> GetNormsFieldData(string CompanyId, string key, string tableName, string columnName, string filter, string filterValue = "")
        {
            List<usp_getDynamicAutocompleteData_Result> lst = null;
            //using (var context = new Cubicle_EntityEntities())
            //{
            //    NewBLEstimationTaskListRepository blObj = new NewBLEstimationTaskListRepository();

            //    try
            //    {
            //        lst = blObj.getDynamicAutocompleteData(key, tableName, columnName, filter, filterValue, CompanyId).ToList<usp_getDynamicAutocompleteData_Result>();
            //        if (key != "" && key != null)
            //            lst = lst.Where(x => x.Name.ToUpper().Contains(key.ToUpper())).ToList();

            //    }
            //    catch (Exception ex)
            //    {

            //    }

            //}
            return lst;
        }



    }

    public class InternalUser
    {
        public int UserID;
        public string FirstName;
        public string LastName;
        public string UserCode;
    }
}
