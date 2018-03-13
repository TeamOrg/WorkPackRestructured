using System.Collections.Generic;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public interface IBLTaskDesignationRepository
    {
        void AddTaskDesignation(params TaskDesignation[] TaskDesignation);
        IList<TaskDesignation> GetAllTaskDesignation();
        List<TaskDesignation> GetTaskDesignationByEstimationTaskID(int EstimationTaskID);
        TaskDesignation GetTaskDesignationByID(int TaskDesignationID);
        List<TaskDesignation> GetTaskDesignationByProjectID(int ProjectID);
        List<TaskDesignation> GetTaskDesignationByProjectTaskID(int ProjectTaskID);
        List<ProjectTaskListCompareCost> GetTaskDesignationDetailsByProjectID(int ProjectID);
        List<object> GetTaskDesignationIDAndNameByProjectTaskID(int ProjectTaskID);
        decimal GetUpdatedHours(int ParentTaskID, int DesignationID, decimal allottedHrs);
        decimal GetUpdatedHoursToOtherDesignation(int ParentTaskID, int selectedDesg, int DesignationID, decimal allottedHrs);
        void InsertIntoTaskDesgnByEstID(int EstimationTaskID);
        void RemoveTaskDesignation(params TaskDesignation[] TaskDesignation);
        void UpdateTaskDesignation(params TaskDesignation[] TaskDesignation);
    }
}