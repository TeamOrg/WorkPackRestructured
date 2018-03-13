using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskListColorCellRepository
    {
        void AddaskListColorCell(params TaskListColorCell[] projectTaskColorCellID);
        IList<TaskListColorCell> GetAllTaskListColorCell();
        TaskListColorCell GetTaskListColorCellByID(int projectTaskColorCellID);
        List<object> GetTaskListColorCellByProjectID(int ProjectID);
        TaskListColorCell GetTaskListColorCellByProjectIDTaskID(int ProjectID, int TaskID);
        List<TaskListColorCell> GetTaskListColorCellByProjectIDTaskIDdatamappingID(int ProjectID, int TaskID, string datamappingID);
        void RemoveaskListColorCell(params TaskListColorCell[] projectTaskColorCellID);
        void UpdateaskListColorCell(params TaskListColorCell[] projectTaskColorCellID);
        int updateTaskCellColor(string ProjectID, string TaskID, string colorcode, string colorType, string datamappingID);
    }
}