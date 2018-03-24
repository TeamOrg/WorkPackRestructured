using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelLibrary;

namespace BusinessLibrary
{
    class SlickGridStructureClass
    {

    }
    public class SlickGridTaskCreationColumns
    {
        public string id;
        public string name;
        public string field;
        public string DataMappingID;
        public int width;
        public string cssClass;
        public string headerCssClass;
        public string editor;
        public string validator;
        public DropdownBinding options;
        public DropdownBinding autocompleteOptions;
        public bool canCellBeSelected;
        public bool canCellBeActive;
        public List<object> columnDefaultValues;
        public string vEvent;
        public string vEventMethod;
        public string columnType;
        public string IsDropDown;
        public string DisplayInGrid;

    }

    public class SlickGridDependencyData
    {
        public string id;
        public string DependencyTask { get; set; }
        public int DependencyType { get; set; }
        public string DependencyTypeCode { get; set; }
        public string DependencyTypeInitial { get; set; }
        public int LagDay { get; set; }
        public int TaskDependencyID { get; set; }
        public int TaskID { get; set; }
        public int DependencyTaskID { get; set; }
    }

    public class SlickGridDependency
    {
        public List<SlickGridDependencyData> lstData;
        public List<DependencyType> lstDepType;
        public List<usp_GetProjectTaskListForDependency_Result> lstPredecessorTask;
    }

    public class SlickGridDependency_Contract
    {
        public List<SlickGridDependencyData> lstData;
        public List<DependencyType> lstDepType;
        public List<usp_GetProjectTaskListForDependency_Contract_Result> lstPredecessorTask;
    }

    public class SettingGrid
    {
        public List<object> Settings;
        public List<object> SettingTemplate;
        public List<List<object>> list = new List<List<object>>();
        public List<object> lstObj = new List<object>();
        public object data;
    }
    public class AssignTaskOwner
    {
        public string Id;
        public string Name;
        public string Hours;
    }
    public class OperationResult
    {
        public string Message;
        public string MessageType; // Success:S or Error:E
        public IList<object> returnData;
        public List<List<object>> list = new List<List<object>>();
        public List<Dictionary<string, string>> lstDict = new List<Dictionary<string, string>>();
        public object data;
    }

    public class DropdownBinding
    {
        public List<object> options;
        public bool optionSelect;     // true/false
        public bool autocomplete;     // true/false
        public string Id;
        public string Name;
    }

    public class DropdownData
    {
        public int Id;
        public string Value;
    }

    public class ProjectTaskListSlickGrid
    {
        public int id;
        public int? NormsID;
        public string NormName;
        public int DepatmentID;
        public string DepatmentName;
        public string TaskName;
        public int TaskTypeID;
        public string TaskTypeName;
        public int? Duration;
        public decimal AllottedHours;
        public string WBSID;
        public string WBSName;
        public int? Priority;
        public string PriorityName;
        public string StartDate;
        public string EndDate;
        public string Remarks;
        public string TaskNo;
        public int? TaskStatus;
        public string TaskStatusName;
        public int? NormDeptID;
        public int Lock;
        public string LastEditedBy;
    }
    public class ProjectsUnderChangScope
    {
        public int id;
        public string ProjectCode;
        public string ProjectName;
        public string Status;
        public string Description;
        public DateTime StartDate;
        public DateTime EndDate;
    }
    public class ProjectTaskListCompareCost
    {


        public int ProjectTaskID;
        public int EstimationTaskColumnID;
        public string IsDbField;
        public string DisplayColName;
        public string DBColName;
        public int? DBColPkID;
        public string TableName;
        public int? DisplayOrder;
        public string DataType;
        public string InputOutput;
        public string EquationID;
        public string IsDropDown;
        public string PermanentNameInDb;
        public string IsMandatory;
        public int? ProjectID;
        public int? DepartmentID;
        public int DesignationID;
        public decimal DesgHours;
        public int? NormsID;
    }

    public class SlickGridMaterialTrackingColumns
    {
        public string id;
        public string name;
        public string field;
        public string DataMappingID;
        public int width;
        public string cssClass;
        public string headerCssClass;
        public string editor;
        public string validator;
        public DropdownBinding options;
        public bool canCellBeSelected;
        public bool canCellBeActive;
        public List<object> columnDefaultValues;
        public string vEvent;
        public string vEventMethod;
        public string columnType;
        public string IsDropDown;
    }


    public class ProcurementDocumentColumnsMasterColumns
    {
        public string id;
        public string name;
        public string field;
        public string DataMappingID;
        public int width;
        public string cssClass;
        public string headerCssClass;
        public string editor;
        public string validator;
        public DropdownBinding options;
        public bool canCellBeSelected;
        public bool canCellBeActive;
        public List<object> columnDefaultValues;
        public string vEvent;
        public string vEventMethod;
        public string columnType;
        public string IsDropDown;
    }



    public class NormsManageTableColumnData
    {
        public int NormsManageTableColId { get; set; }
        public int NormsManageTableID { get; set; }
        public string NormsManageTableName { get; set; }
        public string NormsManageTableColName { get; set; }
        public string NormsManageMasterTable { get; set; }
        public string NormsManageMasterTableColumn { get; set; }

    }

    public class MyObject
    {
        public string DataType { get; set; }
        public string EquationID { get; set; }
        public string Equationvalidation { get; set; }
        public string InputOutput { get; set; }
        public string IsMandatory { get; set; }
        public string DependonNorms { get; set; }
        public string DefaultValue { get; set; }
        public string PermanentNameInDb { get; set; }
        public string NameInDb { get; set; }
        public string EquationCalculation { get; set; }
        public string ValidationMessage { get; set; }
        public string TableName { get; set; }
        public string DBColName { get; set; }
        public string Group { get; set; }
        public List<object> autoCompleteOption { get; set; }
        public Nullable<int> colId { get; set; }
    }


    public class GridTaskCreationColumns
    {
        public string id;
        public string name;
        public string field;
        public string DataMappingID;
        public int width;
        public string cssClass;
        public string headerCssClass;
        public string editor;
        public string validator;
        public DropdownBinding options;
        public DropdownBinding autocompleteOptions;
        public bool canCellBeSelected;
        public bool canCellBeActive;
        public List<MyObject> columnDefaultValues;
        public string vEvent;
        public string vEventMethod;
        public string columnType;
        public string IsDropDown;
    }

    public class GridMaterialReceiptFormCreationColumns
    {
        public string id;
        public string name;
        public string field;
        public string DataMappingID;
        public int width;
        public string cssClass;
        public string headerCssClass;
        public string editor;
        public string validator;
        public DropdownBinding options;
        public DropdownBinding autocompleteOptions;
        public bool canCellBeSelected;
        public bool canCellBeActive;
        public List<MyMaterialReceiptObject> columnDefaultValues;
        public string vEvent;
        public string vEventMethod;
        public string columnType;
        public string IsDropDown;
    }

    public class MyMaterialReceiptObject
    {
        public string DataType { get; set; }
        public string InputOutput { get; set; }
        public string IsMandatory { get; set; }
        public string DefaultValue { get; set; }
        public string PermanentNameInDb { get; set; }
        public string NameInDb { get; set; }
        public string ValidationMessage { get; set; }
        public string TableName { get; set; }
        public string DBColName { get; set; }
        public string Group { get; set; }
        public List<object> autoCompleteOption { get; set; }
        public Nullable<int> colId { get; set; }
    }

}
