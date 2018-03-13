using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class BLMyProfileRepository : IBLMyProfileRepository
    {
        public IList<usp_getUserList_Result> GetUserProfileData(Int32 UserId)
        {
            IList<usp_getUserList_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getUserList(UserId,0,0).ToList<usp_getUserList_Result>();
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
        public IList<Skill> getUserSkillList(int UserID)
        {
            IList<Skill> list = null;
            try
            {
                ////using (var context = new Cubicle_EntityEntities())
                ////{
                ////    var Skil= context.UserSkillInformations.FirstOrDefault(p=>p.UserID==UserID);
                ////    if (Skil != null)
                ////    {
                ////        Int32[] UserSkills = Skil.SkillList.Split(',').ToArray().Select(int.Parse).ToArray();
                ////        list = (from s in context.Skills join u in UserSkills on s.SkillID equals u select s).ToList<Skill>();
                ////    }
                ////}
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
        public IList<usp_getUserTechnologiesByUser_Result> GetTechnologiesByUser(int UserId)
        {
            IList<usp_getUserTechnologiesByUser_Result> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list = context.usp_getUserTechnologiesByUser(UserId).ToList<usp_getUserTechnologiesByUser_Result>();
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
        public IList<UserEmployerHistory> GetEmployeeHistory(int UserID)
        {
            IList<UserEmployerHistory> list = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    list=(from a in context.UserEmployerHistories where a.UserID==UserID select a).ToList<UserEmployerHistory>();
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
        public Boolean UpdateUserImage(string UserImage, Int32 UserId)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    var user = context.Users.FirstOrDefault(p => p.UserID == UserId);
                //    if (user != null)
                //    {
                //        user.ImagePath = UserImage;
                //        context.Entry(user).State = System.Data.EntityState.Modified;
                //        context.SaveChanges();
                //        res = true;
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
        public UserEducationalQualification GetEducationQualification(int UserID)
        {
            UserEducationalQualification obj = null;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    obj = context.UserEducationalQualifications.FirstOrDefault(p => p.UserID == UserID);
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
            return obj;
        }
        public Boolean UpdateUserProfileFields(User obj, string EducatinQualification)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            var user = context.Users.FirstOrDefault(u => u.UserID == obj.UserID);
            //            var eq = context.UserEducationalQualifications.FirstOrDefault(p => p.UserID == obj.UserID);
            //            if (eq == null)
            //            {
            //                UserEducationalQualification ueq = new UserEducationalQualification();
            //                ueq.UserID = obj.UserID;
            //                ueq.Qualification = EducatinQualification;
            //                context.Entry(ueq).State = System.Data.EntityState.Added;
            //                context.SaveChanges();
            //            }
            //            else
            //            {
            //                eq.Qualification = EducatinQualification;
            //                context.Entry(eq).State = System.Data.EntityState.Modified;
            //                context.SaveChanges();
            //            }
            //            if (user != null)
            //            {
            //                user.Location = obj.Location;
            //                user.EmailPassword = obj.EmailPassword;
            //                context.Entry(user).State = System.Data.EntityState.Modified;
            //                context.SaveChanges();
            //                ts.Complete();
            //                res = true;
            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        res = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return res;
        }
        public Boolean SaveUserSkillInfo(string skillList, int UserId)
        {
            Boolean res=false;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    var skillInfo = db.UserSkillInformations.FirstOrDefault(p => p.UserID == UserId);
                //    if (skillInfo == null)
                //    {
                //        if (skillList.Length != 0)
                //        {
                //            UserSkillInformation _skillinfo = new UserSkillInformation();
                //            _skillinfo.UserID = UserId;
                //            _skillinfo.SkillList = skillList;
                //            db.Entry(_skillinfo).State = System.Data.EntityState.Added;
                //            db.SaveChanges();
                //            res = true;
                //        }
                //    }
                //    else
                //    {
                //        skillInfo.UserID = UserId;
                //        skillInfo.SkillList = skillList;
                //        db.Entry(skillInfo).State = System.Data.EntityState.Modified;
                //        db.SaveChanges();
                //        res = true;
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
        public UserEmployerHistory GetEmployeeHistoryByID(int EmpHistoryID)
        {
            UserEmployerHistory list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.UserEmployerHistories.FirstOrDefault(a=> a.UserEmployerHistoryID == EmpHistoryID) ;
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
        public Boolean InsertDeleteEmpHistory(UserEmployerHistory obj, string Status)
        {
            Boolean res=false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    if (Status == "I")
                //    {
                //        context.Entry(obj).State = System.Data.EntityState.Added;
                //        context.SaveChanges();
                //        res = true;
                //    }
                //    if (Status == "U")
                //    {
                //        var val = context.UserEmployerHistories.FirstOrDefault(p => p.UserEmployerHistoryID == obj.UserEmployerHistoryID);
                //        if (val != null)
                //        {
                //            val.UserID = obj.UserID;
                //            val.CompanyName = obj.CompanyName;
                //            val.DurationFrom = obj.DurationFrom;
                //            val.DurationTo = obj.DurationTo;
                //            val.Currentemployer = obj.Currentemployer;
                //            context.Entry(val).State = System.Data.EntityState.Modified;
                //            context.SaveChanges();
                //            res = true;
                //        }
                //    }
                //    if (Status == "D")
                //    {
                //        var val = context.UserEmployerHistories.FirstOrDefault(p => p.UserEmployerHistoryID == obj.UserEmployerHistoryID);
                //        if (val != null)
                //        {
                //            context.Entry(val).State = System.Data.EntityState.Deleted;
                //            context.SaveChanges();
                //            res = true;
                //        }
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
        public IList<usp_GetAllTechnologiesByUserID_Result> GetAllTechnologies(int Userid)
        {
            IList<usp_GetAllTechnologiesByUserID_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_GetAllTechnologiesByUserID(Userid).ToList<usp_GetAllTechnologiesByUserID_Result>();
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
        public Boolean InsertDeleteUserTechnology(List<UserTechnology> objList,int userid)
        {
            Boolean res = false;
            //using (TransactionScope ts = new TransactionScope())
            //{
            //    try
            //    {
            //        using (var context = new Cubicle_EntityEntities())
            //        {
            //            var utList = from a in context.UserTechnologies where a.UserID == userid select a;
            //            foreach (var a in utList)
            //            {
            //                context.Entry(a).State = System.Data.EntityState.Deleted;
            //            }
            //            context.SaveChanges();
            //            foreach (var o in objList)
            //            {
            //                context.Entry(o).State = System.Data.EntityState.Added;
            //            }
            //            context.SaveChanges();
            //            res = true;
            //            ts.Complete();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        ts.Dispose();
            //        res = false;
            //        //bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
            //        if (false)
            //        {
            //            throw ex;
            //        }
            //    }
            //}
            return res;
        }
        public IList<usp_getCurrentProjectsByUserID_Result> GetCurrentProjectsByUser(Int32 UserId)
        {
            IList<usp_getCurrentProjectsByUserID_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getCurrentProjectsByUserID(UserId).ToList<usp_getCurrentProjectsByUserID_Result>();
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
        public IList<usp_getPastProjectsByUserID_Result> GetPastProjectsByUser(Int32 UserId)
        {
            IList<usp_getPastProjectsByUserID_Result> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = db.usp_getPastProjectsByUserID(UserId).ToList<usp_getPastProjectsByUserID_Result>();
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
        public IList<UserEmployeeProject> GetUserEmployeeProjectsByID(int UserEmpProID)
        {
            IList<UserEmployeeProject>list=null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from a in db.UserEmployeeProjects where a.UserEmployeeProjectID == UserEmpProID select a).ToList<UserEmployeeProject>();
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
        public IList<UserEmployeeProject> GetUserEmployeeProjects( int UserEmployeeHistoryID)
        {
            IList<UserEmployeeProject> list = null;
            try
            {
                //using (var db = new Cubicle_EntityEntities())
                //{
                //    list = (from h in db.UserEmployeeProjects where h.UserEmployerHistoryID == UserEmployeeHistoryID select h).ToList<UserEmployeeProject>();                    
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
        public Boolean InsertDeleteEmpProject(UserEmployeeProject obj, char Status)
        {
            Boolean res = false;
            try
            {
                //using (var context = new Cubicle_EntityEntities())
                //{
                //    if (Status == 'I')
                //    {
                //        UserEmployeeProject _uEp = new UserEmployeeProject();
                //        _uEp.ProjectName = obj.ProjectName;
                //        _uEp.Description = obj.Description;
                //        _uEp.UserEmployerHistoryID = obj.UserEmployerHistoryID;
                //        context.Entry(_uEp).State = System.Data.EntityState.Added;
                //        context.SaveChanges();
                //        res = true;
                //    }
                //    if (Status == 'U')
                //    {
                //        var val = context.UserEmployeeProjects.FirstOrDefault(a=>a.UserEmployeeProjectID == a.UserEmployeeProjectID);
                //        if (val != null)
                //        {
                //            val.ProjectName = obj.ProjectName;
                //            val.Description = obj.Description;
                //            val.UserEmployerHistoryID = obj.UserEmployerHistoryID;
                //            context.Entry(val).State = System.Data.EntityState.Modified;
                //            context.SaveChanges();
                //            res = true;
                //        }
                //    }
                //    if (Status == 'D')
                //    {
                //        var val = context.UserEmployeeProjects.FirstOrDefault(a => a.UserEmployeeProjectID == a.UserEmployeeProjectID);
                //        if (val != null)
                //        {                           
                //            context.Entry(val).State = System.Data.EntityState.Deleted;
                //            context.SaveChanges();
                //            res = true;
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                res = false;
                throw ex;
                ////bool false = BusinessLogicExceptionHandler.HandleException(ref ex);
                //if (false)
                //{
                //    throw ex;
                //}
            }
            return res;
        }    

    }
}
