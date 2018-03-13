using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLProjectWBSRepository
    {
        void AddProjectWBS(params ProjectWB[] projectWBS);
        bool checkDuplicateWBSCode(string code, string projectID, int EditWBSId = 0);
        bool checkDuplicateWBSCodeInEditMode(string code, string projectID, int EditWBSId);
        bool checkDuplicateWBSCodeInEDitMode(string code, string TemplateID, int WBSID);
        bool checkDuplicateWBSCodeInTemplate(string code, string TemplateID, int EditWBSId = 0);
        bool checkDuplicateWBSTemplateCode(string code, int EditWBSId = 0);
        int CheckTaskByWBSID(string WBSID, int ProjectID);
        IList<ProjectWB> GetAllProjectWBS();
        ProjectWB getDefaultWbsByProjectID(int projectId, string ProjectCode);
        int getParentidbyImportWBSParentID(string ImportpARENTWBSID, string projectID);
        List<object> getProjectTaskWBSByProjectID(int projectID);
        ProjectWB getProjectWBSByID(int WBId);
        List<object> getProjectWBSByProjectID(int projectID);
        List<ProjectWB> getProjectWBSByTemplateID(int WbsTempId);
        List<object> getProjectWBSByTemplateID(string WbsTempId);
        List<object> getProjectWBSByWbsID(int wbsid);
        List<ProjectWB> getProjectWBSListByProjectID(int projectID);
        List<object> getWBSByTemplateID(string WbsTempId);
        int getWBSID(string WBScode, string projectID);
        void RemoveProjectWBS(params ProjectWB[] projectWBS);
        void RemoveProjectWBSByProjectID(int ProjectID, string ProjectCode);
        bool RemoveWBSByWBSID(int WBSID);
        bool RemoveWBSByWWBSTemplateDetailWBSId(int WBSID);
        bool UpdateProjectParentWBS(int WBSID, int ParentWBSID);
        bool UpdateProjectWBSCode(int WBSID, string WBSCode);
        bool UpdateProjectWBSName(int WBSID, string WBSName);
        bool UpdateTemplateParentWBS(int WBSID, int ParentWBSID);
        bool UpdateTemplateWBSCode(int WBSID, string WBSCode);
        bool UpdateTemplateWBSName(int WBSID, string WBSName);
        void UpdateWBSCodeOnchangeOfprojectCode(int ProjectID, string OriginalWBScode, string ChangeWBS);
    }
}