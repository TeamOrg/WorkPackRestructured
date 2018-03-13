using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLMyProfileRepository
    {
        IList<usp_GetAllTechnologiesByUserID_Result> GetAllTechnologies(int Userid);
        IList<usp_getCurrentProjectsByUserID_Result> GetCurrentProjectsByUser(int UserId);
        UserEducationalQualification GetEducationQualification(int UserID);
        IList<UserEmployerHistory> GetEmployeeHistory(int UserID);
        UserEmployerHistory GetEmployeeHistoryByID(int EmpHistoryID);
        IList<usp_getPastProjectsByUserID_Result> GetPastProjectsByUser(int UserId);
        IList<usp_getUserTechnologiesByUser_Result> GetTechnologiesByUser(int UserId);
        IList<UserEmployeeProject> GetUserEmployeeProjects(int UserEmployeeHistoryID);
        IList<UserEmployeeProject> GetUserEmployeeProjectsByID(int UserEmpProID);
        IList<usp_getUserList_Result> GetUserProfileData(int UserId);
        IList<Skill> getUserSkillList(int UserID);
        bool InsertDeleteEmpHistory(UserEmployerHistory obj, string Status);
        bool InsertDeleteEmpProject(UserEmployeeProject obj, char Status);
        bool InsertDeleteUserTechnology(List<UserTechnology> objList, int userid);
        bool SaveUserSkillInfo(string skillList, int UserId);
        bool UpdateUserImage(string UserImage, int UserId);
        bool UpdateUserProfileFields(User obj, string EducatinQualification);
    }
}